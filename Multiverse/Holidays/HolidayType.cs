namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Categorizes a public holiday.
/// </summary>
public enum HolidayType
{
    /// <summary>A national public holiday observed across the entire country.</summary>
    Public,

    /// <summary>A bank/government holiday — offices and banks close, but not necessarily all businesses.</summary>
    Bank,

    /// <summary>A religious or observance-based holiday.</summary>
    Religious,

    /// <summary>A national/independence/republic day.</summary>
    National,

    /// <summary>A commemoration or remembrance day.</summary>
    Observance
}
