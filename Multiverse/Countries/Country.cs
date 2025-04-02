using System;
using System.Collections.Generic;
using System.Linq;
using static Multiverse.Globalization.Countries.CountryHelper;

namespace Multiverse.Globalization.Countries;

public sealed class Country
{
    internal Country(
        string name,
        string numericCode,
        string alpha2Code,
        string alpha3Code)
    {
        Name = name;
        NumericCode = numericCode;
        Alpha2Code = alpha2Code;
        Alpha3Code = alpha3Code;
    }

    public string Name { get; private set; } = string.Empty;
    public string Alpha3Code { get; private set; } = string.Empty;
    public string Alpha2Code { get; private set; } = string.Empty;
    public string NumericCode { get; private set; } = string.Empty;

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
        identifier = identifier.ToLowerInvariant();

        return !string.IsNullOrWhiteSpace(identifier) && (
            Alpha2CodeMap.ContainsKey(identifier) ||
            Alpha3CodeMap.ContainsKey(identifier) ||
            NumericCodeMap.ContainsKey(identifier) ||
            NameMap.ContainsKey(identifier));
    }

    /// <summary>
    /// Retrieves a list of all available Country objects.
    /// </summary>
    public static List<Country> GetAll() => CountryHelper.GetAll();
}
