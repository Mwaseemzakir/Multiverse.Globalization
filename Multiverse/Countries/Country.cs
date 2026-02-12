using System;
using System.Collections.Generic;
using System.Linq;
using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;
using static Multiverse.Globalization.Countries.CountryHelper;

namespace Multiverse.Globalization.Countries;

public sealed class Country
{
    internal Country(
        string name,
        string numericCode,
        string alpha2Code,
        string alpha3Code,
        string callingCode,
        string capital,
        string region,
        Currency? currency,
        params Language[] officialLanguages)
    {
        Name = name;
        NumericCode = numericCode;
        Alpha2Code = alpha2Code;
        Alpha3Code = alpha3Code;
        CallingCode = callingCode;
        Capital = capital;
        Region = region;
        Currency = currency;
        OfficialLanguages = officialLanguages ?? Array.Empty<Language>();
    }

    /// <summary>Country name.</summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>ISO 3166-1 alpha-3 code (3-letter).</summary>
    public string Alpha3Code { get; private set; } = string.Empty;

    /// <summary>ISO 3166-1 alpha-2 code (2-letter).</summary>
    public string Alpha2Code { get; private set; } = string.Empty;

    /// <summary>ISO 3166-1 numeric code (3-digit).</summary>
    public string NumericCode { get; private set; } = string.Empty;

    /// <summary>International dialing code (E.164), e.g. "+1", "+44".</summary>
    public string CallingCode { get; private set; } = string.Empty;

    /// <summary>Capital city name.</summary>
    public string Capital { get; private set; } = string.Empty;

    /// <summary>Geographic region/continent, e.g. "Asia", "Europe", "Americas", "Africa", "Oceania", "Antarctic".</summary>
    public string Region { get; private set; } = string.Empty;

    /// <summary>Primary currency used in this country.</summary>
    public Currency? Currency { get; private set; }

    /// <summary>Primary ISO 4217 currency code derived from the Currency property, e.g. "USD", "EUR".</summary>
    public string CurrencyCode => Currency?.Code ?? string.Empty;

    /// <summary>Official languages of this country.</summary>
    public IReadOnlyList<Language> OfficialLanguages { get; private set; } = Array.Empty<Language>();

    /// <summary>Unicode flag emoji derived from the Alpha-2 code.</summary>
    public string Flag =>
        string.IsNullOrEmpty(Alpha2Code)
            ? string.Empty
            : string.Concat(Alpha2Code.ToUpperInvariant().Select(c => char.ConvertFromUtf32(c - 'A' + 0x1F1E6)));

    /// <summary>
    /// Retrieves a Country object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, numeric code, or the name of the country. Returns null if not found.
    /// </summary>
    public static Country? GetCountryOrDefault(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return default;

        identifier = identifier.ToLowerInvariant();

        if (Alpha2CodeMap.ContainsKey(identifier))
            return Alpha2CodeMap[identifier];

        if (identifier.All(char.IsDigit) && NumericCodeMap.ContainsKey(identifier))
            return NumericCodeMap[identifier];

        if (Alpha3CodeMap.ContainsKey(identifier))
            return Alpha3CodeMap[identifier];

        if (NameMap.ContainsKey(identifier))
            return NameMap[identifier];

        return default;
    }

    /// <summary>
    /// Retrieves a Country object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, numeric code, or the name of the country. Throws an exception if not found.
    /// </summary>
    public static Country GetCountry(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentNullException("Must provide the identifier value");

        if (!IsValid(identifier))
            throw new CountryNotFoundException($"Country with identifier '{identifier}' was not found.");

        identifier = identifier.ToLowerInvariant();

        return identifier switch
        {
            _ when Alpha2CodeMap.ContainsKey(identifier) => Alpha2CodeMap[identifier],
            _ when identifier.All(char.IsDigit) && NumericCodeMap.ContainsKey(identifier) => NumericCodeMap[identifier],
            _ when Alpha3CodeMap.ContainsKey(identifier) => Alpha3CodeMap[identifier],
            _ when NameMap.ContainsKey(identifier) => NameMap[identifier],
            _ => throw new CountryNotFoundException($"Country with identifier '{identifier}' was not found.")
        };
    }

    /// <summary>
    /// Checks if the provided identifier is valid. The identifier can be an Alpha-2 code, 
    /// Alpha-3 code, numeric code, or the name of the country.
    /// </summary>
    public static bool IsValid(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return false;

        identifier = identifier.ToLowerInvariant();

        return Alpha2CodeMap.ContainsKey(identifier) ||
            Alpha3CodeMap.ContainsKey(identifier) ||
            NumericCodeMap.ContainsKey(identifier) ||
            NameMap.ContainsKey(identifier);
    }

    /// <summary>
    /// Retrieves a list of all available Country objects.
    /// </summary>
    public static List<Country> GetAll() => CountryHelper.GetAll();
}
