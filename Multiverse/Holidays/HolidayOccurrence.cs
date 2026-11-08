namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Represents a single holiday occurrence resolved to a concrete date, unifying fixed-date
/// <see cref="Holiday"/> and computed <see cref="MovableHoliday"/> entries for combined queries
/// such as <see cref="Countries.Country.GetHolidayOccurrencesOnDate"/>.
/// </summary>
public sealed class HolidayOccurrence
{
    internal HolidayOccurrence(string name, DateTime date, HolidayType type, bool isMovable)
        : this(name, date, date, type, isMovable)
    {
    }

    internal HolidayOccurrence(string name, DateTime date, DateTime observedDate, HolidayType type, bool isMovable)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        Name = name;
        Date = date.Date;
        ObservedDate = observedDate.Date;
        Type = type;
        IsMovable = isMovable;
    }

    /// <summary>Holiday name, e.g. "Independence Day", "Easter Sunday".</summary>
    public string Name { get; }

    /// <summary>The calendar date this holiday falls on in the queried year.</summary>
    public DateTime Date { get; }

    /// <summary>
    /// The date the holiday is actually taken as a day off, after the country's
    /// <see cref="HolidayObservanceRule"/> has moved it off a weekend. Equal to
    /// <see cref="Date"/> where no shift applies.
    /// </summary>
    public DateTime ObservedDate { get; }

    /// <summary>
    /// Whether this holiday was shifted off its calendar date by a substitute-day rule,
    /// e.g. New Year's Day 2028 falling on a Saturday and being taken on the Monday.
    /// </summary>
    public bool IsSubstituted => ObservedDate != Date;

    /// <summary>Category of the holiday.</summary>
    public HolidayType Type { get; }

    /// <summary>
    /// Whether this occurrence came from a movable holiday rule (e.g. Easter, Thanksgiving)
    /// rather than a fixed month/day <see cref="Holiday"/>.
    /// </summary>
    public bool IsMovable { get; }

    /// <inheritdoc/>
    public override string ToString() => IsSubstituted
        ? $"{Name} ({Date:MMM dd, yyyy}, observed {ObservedDate:MMM dd, yyyy})"
        : $"{Name} ({Date:MMM dd, yyyy})";
}
