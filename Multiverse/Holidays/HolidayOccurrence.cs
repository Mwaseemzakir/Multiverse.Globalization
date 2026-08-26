namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Represents a single holiday occurrence resolved to a concrete date, unifying fixed-date
/// <see cref="Holiday"/> and computed <see cref="MovableHoliday"/> entries for combined queries
/// such as <see cref="Countries.Country.GetHolidayOccurrencesOnDate"/>.
/// </summary>
public sealed class HolidayOccurrence
{
    internal HolidayOccurrence(string name, DateTime date, HolidayType type, bool isMovable)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        Name = name;
        Date = date;
        Type = type;
        IsMovable = isMovable;
    }

    /// <summary>Holiday name, e.g. "Independence Day", "Easter Sunday".</summary>
    public string Name { get; }

    /// <summary>The concrete date this holiday falls on in the queried year.</summary>
    public DateTime Date { get; }

    /// <summary>Category of the holiday.</summary>
    public HolidayType Type { get; }

    /// <summary>
    /// Whether this occurrence came from a movable holiday rule (e.g. Easter, Thanksgiving)
    /// rather than a fixed month/day <see cref="Holiday"/>.
    /// </summary>
    public bool IsMovable { get; }

    /// <inheritdoc/>
    public override string ToString() => $"{Name} ({Date:MMM dd, yyyy})";
}
