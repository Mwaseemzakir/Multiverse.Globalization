namespace Multiverse.Globalization.Countries;

/// <summary>
/// Describes how a country's alpha-2/alpha-3 codes relate to ISO 3166-1.
/// </summary>
public enum CountryCodeStatus
{
    /// <summary>No country code is assigned, for example <see cref="CountryHelper.None"/>.</summary>
    Unspecified = 0,

    /// <summary>The code is currently assigned in ISO 3166-1.</summary>
    OfficiallyAssigned = 1,

    /// <summary>The code was formerly assigned and is retained for backward compatibility.</summary>
    FormerlyAssigned = 2
}