using System;

namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Represents a movable holiday whose date changes each year.
/// Movable holidays include Easter-based holidays, nth-weekday holidays (e.g. Thanksgiving),
/// and other holidays computed from rules rather than fixed dates.
/// </summary>
public sealed class MovableHoliday
{
    private readonly Func<int, DateTime?> _dateCalculator;

    internal MovableHoliday(string name, HolidayType type, Func<int, DateTime?> dateCalculator)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        Name = name;
        Type = type;
        _dateCalculator = dateCalculator ?? throw new ArgumentNullException(nameof(dateCalculator));
    }

    /// <summary>Holiday name, e.g. "Easter Sunday", "Thanksgiving".</summary>
    public string Name { get; }

    /// <summary>Category of the holiday.</summary>
    public HolidayType Type { get; }

    /// <summary>
    /// Computes the date of the holiday for the given year, or null if not applicable.
    /// </summary>
    public DateTime? GetDate(int year) => _dateCalculator(year);

    /// <summary>
    /// Returns the date for the current year, or null if not applicable.
    /// </summary>
    public DateTime? Date => GetDate(DateTime.Today.Year);

    /// <summary>
    /// Checks if the given date falls on this movable holiday.
    /// </summary>
    public bool IsOnDate(DateTime date)
    {
        var holidayDate = GetDate(date.Year);
        return holidayDate.HasValue && holidayDate.Value.Date == date.Date;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        var date = Date;
        return date.HasValue
            ? $"{Name} ({date.Value:MMM dd, yyyy})"
            : Name;
    }

    // ── Calculation Helpers ───────────────────────────────────────

    /// <summary>
    /// Computes Easter Sunday for a given year using the Anonymous Gregorian algorithm.
    /// Valid for years 1583–9999.
    /// </summary>
    public static DateTime ComputeEasterSunday(int year)
    {
        int a = year % 19;
        int b = year / 100;
        int c = year % 100;
        int d = b / 4;
        int e = b % 4;
        int f = (b + 8) / 25;
        int g = (b - f + 1) / 3;
        int h = (19 * a + b - d - g + 15) % 30;
        int i = c / 4;
        int k = c % 4;
        int l = (32 + 2 * e + 2 * i - h - k) % 7;
        int m = (a + 11 * h + 22 * l) / 451;
        int month = (h + l - 7 * m + 114) / 31;
        int day = ((h + l - 7 * m + 114) % 31) + 1;
        return new DateTime(year, month, day);
    }

    /// <summary>
    /// Returns the date of the Nth occurrence of a given day of week in a month.
    /// For example, NthWeekdayOfMonth(2026, 11, DayOfWeek.Thursday, 4) returns the 4th Thursday of November 2026 (Thanksgiving).
    /// </summary>
    public static DateTime NthWeekdayOfMonth(int year, int month, DayOfWeek dayOfWeek, int n)
    {
        var firstDay = new DateTime(year, month, 1);
        int daysUntil = ((int)dayOfWeek - (int)firstDay.DayOfWeek + 7) % 7;
        var firstOccurrence = firstDay.AddDays(daysUntil);
        return firstOccurrence.AddDays(7 * (n - 1));
    }

    /// <summary>
    /// Returns the last occurrence of a given day of week in a month.
    /// For example, LastWeekdayOfMonth(2026, 5, DayOfWeek.Monday) returns the last Monday of May 2026 (Memorial Day).
    /// </summary>
    public static DateTime LastWeekdayOfMonth(int year, int month, DayOfWeek dayOfWeek)
    {
        var lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
        int daysBack = ((int)lastDay.DayOfWeek - (int)dayOfWeek + 7) % 7;
        return lastDay.AddDays(-daysBack);
    }

    /// <summary>
    /// Returns the last occurrence of a given day of week on or before a specific date.
    /// For example, LastWeekdayBefore(2026, 5, 25, DayOfWeek.Monday) returns the Monday on or before May 25 (Victoria Day in Canada).
    /// </summary>
    public static DateTime LastWeekdayBefore(int year, int month, int dayOfMonth, DayOfWeek dayOfWeek)
    {
        var target = new DateTime(year, month, dayOfMonth);
        int daysBack = ((int)target.DayOfWeek - (int)dayOfWeek + 7) % 7;
        return target.AddDays(-daysBack);
    }
}
