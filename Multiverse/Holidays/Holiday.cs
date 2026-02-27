using System;

namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Represents a fixed-date public holiday within a country.
/// A holiday has a fixed month/day and a type classification.
/// <para>
/// Note: Only fixed-date holidays are supported. Movable holidays
/// (e.g. Easter, Eid al-Fitr, Diwali, Chinese New Year, Thanksgiving)
/// whose dates vary by year are not included.
/// </para>
/// </summary>
public sealed class Holiday
{
    internal Holiday(string name, int month, int day, HolidayType type)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        if (month < 1 || month > 12)
            throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");

        if (day < 1 || day > 31)
            throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31.");

        Name = name;
        Month = month;
        Day = day;
        Type = type;
    }

    /// <summary>Holiday name, e.g. "Independence Day", "Christmas Day".</summary>
    public string Name { get; }

    /// <summary>Month of the holiday (1–12).</summary>
    public int Month { get; }

    /// <summary>Day of the holiday (1–31).</summary>
    public int Day { get; }

    /// <summary>Category of the holiday.</summary>
    public HolidayType Type { get; }

    /// <summary>
    /// Returns the <see cref="DateTime"/> for this holiday in the given year.
    /// </summary>
    public DateTime GetDate(int year) => new DateTime(year, Month, Day);

    /// <summary>
    /// Returns the <see cref="DateTime"/> for this holiday in the current year.
    /// </summary>
    public DateTime Date => new DateTime(DateTime.Today.Year, Month, Day);

    /// <summary>
    /// Checks if the given date falls on this holiday (month and day match, ignoring year).
    /// </summary>
    public bool IsOnDate(DateTime date) => date.Month == Month && date.Day == Day;

    public override string ToString() => $"{Name} ({Month:D2}/{Day:D2})";
}
