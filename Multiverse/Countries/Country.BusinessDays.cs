namespace Multiverse.Globalization.Countries;

/// <summary>
/// Year-aware holiday resolution and working-day arithmetic for a country, combining its
/// fixed holidays, movable holidays, weekend, and substitute-day rule.
/// </summary>
public sealed partial class Country
{
    /// <summary>
    /// Upper bound on the days <see cref="AddBusinessDays"/> will step through before giving up,
    /// so a country configured with no working days cannot spin forever.
    /// </summary>
    private const int MaxBusinessDaySearchDays = 4000;

    private readonly Dictionary<int, IReadOnlyList<HolidayOccurrence>> _holidaysByYear = [];
    private readonly object _holidaysByYearLock = new();

    // ── Weekends ────────────────────────────────────────────────────

    /// <summary>
    /// Days of the week that form the weekend in this country. Saturday and Sunday for most
    /// of the world; Friday and Saturday across much of the Middle East and North Africa.
    /// </summary>
    public IReadOnlyList<DayOfWeek> WeekendDays
        => field ??= WeekendHelper.GetWeekendDaysForCountry(Alpha2Code);

    /// <summary>Checks whether the given date falls on this country's weekend.</summary>
    public bool IsWeekend(DateTime date)
    {
        var day = date.DayOfWeek;

        foreach (var weekendDay in WeekendDays)
            if (weekendDay == day)
                return true;

        return false;
    }

    // ── Holidays for a year ─────────────────────────────────────────

    /// <summary>
    /// The rule this country applies when a public holiday lands on a weekend.
    /// </summary>
    public HolidayObservanceRule ObservanceRule
        => HolidayObservanceHelper.GetRuleForCountry(Alpha2Code);

    /// <summary>
    /// Returns every holiday observed in this country during the given year — fixed and movable
    /// alike — resolved to concrete dates and ordered chronologically. Where the country applies
    /// a substitute-day rule, each occurrence also carries the
    /// <see cref="HolidayOccurrence.ObservedDate"/> the day off is actually taken.
    /// </summary>
    /// <param name="year">The calendar year, 1583–9999 (the range over which Easter is computable).</param>
    public IReadOnlyList<HolidayOccurrence> GetHolidays(int year)
    {
        if (year < 1583 || year > 9999)
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1583 and 9999.");

        lock (_holidaysByYearLock)
        {
            if (_holidaysByYear.TryGetValue(year, out var cached))
                return cached;

            var resolved = ResolveHolidays(year);
            _holidaysByYear[year] = resolved;
            return resolved;
        }
    }

    /// <summary>
    /// Returns every holiday observed between two dates inclusive, spanning year boundaries.
    /// Occurrences are matched on their <see cref="HolidayOccurrence.ObservedDate"/>.
    /// </summary>
    /// <param name="from">Start of the range, inclusive.</param>
    /// <param name="to">End of the range, inclusive.</param>
    public IReadOnlyList<HolidayOccurrence> GetHolidays(DateTime from, DateTime to)
    {
        if (to.Date < from.Date)
            throw new ArgumentException("The end of the range must not precede its start.", nameof(to));

        var results = new List<HolidayOccurrence>();

        for (var year = from.Year; year <= to.Year; year++)
            results.AddRange(GetHolidays(year)
                .Where(h => h.ObservedDate >= from.Date && h.ObservedDate <= to.Date));

        return results
            .OrderBy(h => h.ObservedDate)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Checks whether the given date is a day off in this country — a public holiday on its own
    /// date, or a substitute day standing in for one that fell on a weekend.
    /// <para>
    /// Unlike <see cref="IsPublicHoliday"/> this is year-aware and includes movable holidays,
    /// so Easter Monday and Thanksgiving are recognised.
    /// </para>
    /// <para>
    /// <see cref="HolidayType.Observance"/> entries are commemorations rather than days off
    /// (Easter Sunday in the US, for instance) and are excluded. Use <see cref="GetHolidaysOn"/>
    /// to see everything falling on a date.
    /// </para>
    /// </summary>
    public bool IsHoliday(DateTime date)
    {
        var target = date.Date;
        var holidays = GetHolidays(target.Year);

        foreach (var holiday in holidays)
            if (holiday.ObservedDate == target && IsDayOff(holiday.Type))
                return true;

        return false;
    }

    /// <summary>
    /// Whether a holiday of this type closes offices. Observances are commemorations — they are
    /// neither days off nor eligible for a substitute day when they fall on a weekend.
    /// </summary>
    private static bool IsDayOff(HolidayType type)
    {
        return type != HolidayType.Observance;
    }

    /// <summary>
    /// Returns the holidays observed on the given date, resolved for that date's year.
    /// </summary>
    public IReadOnlyList<HolidayOccurrence> GetHolidaysOn(DateTime date)
    {
        var target = date.Date;

        return GetHolidays(target.Year)
            .Where(h => h.ObservedDate == target)
            .ToList()
            .AsReadOnly();
    }

    // ── Working days ────────────────────────────────────────────────

    /// <summary>
    /// Checks whether the given date is a working day — neither a weekend day
    /// nor a public holiday in this country.
    /// </summary>
    public bool IsWorkingDay(DateTime date)
    {
        return !IsWeekend(date) && !IsHoliday(date);
    }

    /// <summary>Returns the first working day strictly after the given date.</summary>
    public DateTime NextWorkingDay(DateTime date)
    {
        var candidate = date.Date.AddDays(1);

        for (var i = 0; i < MaxBusinessDaySearchDays; i++)
        {
            if (IsWorkingDay(candidate))
                return candidate;

            candidate = candidate.AddDays(1);
        }

        throw new InvalidOperationException(
            $"{Name} ({Alpha2Code}) has no working day within {MaxBusinessDaySearchDays} days of {date:yyyy-MM-dd}.");
    }

    /// <summary>Returns the last working day strictly before the given date.</summary>
    public DateTime PreviousWorkingDay(DateTime date)
    {
        var candidate = date.Date.AddDays(-1);

        for (var i = 0; i < MaxBusinessDaySearchDays; i++)
        {
            if (IsWorkingDay(candidate))
                return candidate;

            candidate = candidate.AddDays(-1);
        }

        throw new InvalidOperationException(
            $"{Name} ({Alpha2Code}) has no working day within {MaxBusinessDaySearchDays} days of {date:yyyy-MM-dd}.");
    }

    /// <summary>
    /// Advances a date by a number of working days, skipping weekends and public holidays.
    /// A negative count walks backwards. Zero returns the date unchanged, even if it is not
    /// itself a working day.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <param name="businessDays">Working days to add; may be negative.</param>
    public DateTime AddBusinessDays(DateTime date, int businessDays)
    {
        if (businessDays == 0)
            return date.Date;

        var remaining = Math.Abs(businessDays);
        var current = date.Date;

        while (remaining > 0)
        {
            current = businessDays > 0
                ? NextWorkingDay(current)
                : PreviousWorkingDay(current);

            remaining--;
        }

        return current;
    }

    /// <summary>
    /// Counts the working days in a date range, including both endpoints when they are
    /// themselves working days.
    /// </summary>
    /// <param name="from">Start of the range, inclusive.</param>
    /// <param name="to">End of the range, inclusive.</param>
    public int CountBusinessDays(DateTime from, DateTime to)
    {
        if (to.Date < from.Date)
            throw new ArgumentException("The end of the range must not precede its start.", nameof(to));

        var count = 0;

        for (var day = from.Date; day <= to.Date; day = day.AddDays(1))
            if (IsWorkingDay(day))
                count++;

        return count;
    }

    // ── Resolution ──────────────────────────────────────────────────

    /// <summary>
    /// Materialises this country's fixed and movable holidays for a year, then applies the
    /// substitute-day rule in date order so that a shifted holiday never lands on a day already
    /// taken by another one.
    /// </summary>
    private IReadOnlyList<HolidayOccurrence> ResolveHolidays(int year)
    {
        var dated = new List<(string Name, DateTime Date, HolidayType Type, bool IsMovable)>();
        var movableNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var movable in MovableHolidays)
        {
            var date = movable.GetDate(year);

            if (!date.HasValue)
                continue;

            movableNames.Add(movable.Name);
            dated.Add((movable.Name, date.Value.Date, movable.Type, true));
        }

        foreach (var holiday in Holidays)
        {
            // Several countries list a holiday both as a fixed date (a snapshot of one year)
            // and as a movable rule — US Thanksgiving is in both. The rule is the accurate one,
            // so the fixed entry is dropped rather than reported as a second holiday.
            if (movableNames.Contains(holiday.Name))
                continue;

            // February 29 entries simply do not occur in a common year.
            if (holiday.Day > DateTime.DaysInMonth(year, holiday.Month))
                continue;

            dated.Add((holiday.Name, holiday.GetDate(year), holiday.Type, false));
        }

        var rule = ObservanceRule;
        var taken = new HashSet<DateTime>();
        var occurrences = new List<HolidayOccurrence>(dated.Count);

        foreach (var entry in dated.OrderBy(d => d.Date).ThenBy(d => d.Name, StringComparer.Ordinal))
        {
            var observed = IsDayOff(entry.Type)
                ? ApplyObservanceRule(entry.Date, rule, taken)
                : entry.Date;

            if (IsDayOff(entry.Type))
                taken.Add(observed);

            occurrences.Add(new HolidayOccurrence(entry.Name, entry.Date, observed, entry.Type, entry.IsMovable));
        }

        return occurrences
            .OrderBy(h => h.ObservedDate)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Moves a holiday off the weekend according to <paramref name="rule"/>, stepping past any
    /// date already claimed by an earlier holiday — the reason the UK can end up with a Tuesday
    /// substitute when Christmas Day and Boxing Day both fall on a weekend.
    /// </summary>
    private DateTime ApplyObservanceRule(DateTime date, HolidayObservanceRule rule, HashSet<DateTime> taken)
    {
        // Only a weekend triggers a substitute day. Two holidays genuinely sharing a weekday
        // are left where they are — that is a real calendar, not a collision to resolve.
        if (rule == HolidayObservanceRule.None || !IsWeekend(date))
            return date;

        // The US rule pulls a Saturday holiday back to the Friday before it.
        if (rule == HolidayObservanceRule.NearestWorkingDay && date.DayOfWeek == DayOfWeek.Saturday)
        {
            var backwards = date.AddDays(-1);

            for (var i = 0; i < MaxBusinessDaySearchDays; i++)
            {
                if (!IsWeekend(backwards) && !taken.Contains(backwards))
                    return backwards;

                backwards = backwards.AddDays(-1);
            }
        }

        var forwards = date;

        for (var i = 0; i < MaxBusinessDaySearchDays; i++)
        {
            forwards = forwards.AddDays(1);

            if (!IsWeekend(forwards) && !taken.Contains(forwards))
                return forwards;
        }

        // No free working day was found; leave the holiday on its calendar date.
        return date;
    }
}
