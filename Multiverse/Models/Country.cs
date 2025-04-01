using System.Collections.Generic;
using System.Linq;

namespace Multiverse.Models;

public sealed class Country
{
    public static int Count => Alpha2CodeMap.Count;
    private static readonly IReadOnlyDictionary<string, Country> Alpha2CodeMap = CountryHelpers.Alpha2CodeMap;
    private static readonly IReadOnlyDictionary<string, Country> Alpha3CodeMap = CountryHelpers.Alpha3CodeMap;
    private static readonly IReadOnlyDictionary<string, Country> NumericCodeMap = CountryHelpers.NumericCodeMap;

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

    public static bool IsValidAlpha2Code(string code) =>
        !string.IsNullOrWhiteSpace(code) && Alpha2CodeMap.ContainsKey(code.ToUpperInvariant());

    public static bool IsValidAlpha3Code(string code) =>
        !string.IsNullOrWhiteSpace(code) && Alpha3CodeMap.ContainsKey(code.ToUpperInvariant());

    public static bool IsValidNumericCode(string code) =>
        !string.IsNullOrWhiteSpace(code) && NumericCodeMap.ContainsKey(code.ToUpperInvariant());

    public static bool IsValidCode(string code) =>
        !string.IsNullOrWhiteSpace(code) && ( 
        IsValidAlpha2Code(code) 
        || IsValidAlpha3Code(code) 
        || IsValidNumericCode(code) );

    public static Country? GetByAlpha2CodeOrDefault(string code) =>
        IsValidAlpha2Code(code) ? Alpha2CodeMap[code.ToUpperInvariant()] : default;

    public static Country? GetByAlpha3CodeOrDefault(string code) =>
        IsValidAlpha3Code(code) ? Alpha3CodeMap[code.ToUpperInvariant()] : default;

    public static Country? GetByNumericCodeOrDefault(string code) =>
        IsValidNumericCode(code) ? NumericCodeMap[code.ToUpperInvariant()] : default;

    public static bool TryGetByAlpha2Code(string code, out Country? country)
    {
        if(IsValidAlpha2Code(code))
        {
            return Alpha2CodeMap.TryGetValue(code.ToUpperInvariant(), out country);
        }
        country = default;
        return false;
    }

    public static bool TryGetByAlpha3Code(string code, out Country? country)
    {
        if(IsValidAlpha3Code(code))
        {
            return Alpha3CodeMap.TryGetValue(code.ToUpperInvariant(), out country);
        }
        country = default;
        return false;
    }

    public static bool TryGetByNumericCode(string numericCode, out Country? country)
    {
        if(IsValidNumericCode(numericCode))
        {
            return NumericCodeMap.TryGetValue(numericCode.ToUpperInvariant(), out country);
        }
        country = default;
        return false;
    }

    public static List<Country> GetAll() => CountryHelpers.GetAll();

    public static Country? ParseCountry(string code)
    {
        if(string.IsNullOrWhiteSpace(code) || !IsValidCode(code))
        {
            return default;
        }

        return code.Length switch
        {
            2 => GetByAlpha2CodeOrDefault(code),
            3 when code.All(char.IsDigit) => GetByNumericCodeOrDefault(code),
            3 => GetByAlpha3CodeOrDefault(code),
            _ => default
        };
    }

    public static IEnumerable<string> GetAlpha2Codes() => Alpha2CodeMap.Keys;
    public static IEnumerable<string> GetAlpha3Codes() => Alpha3CodeMap.Keys;
    public static IEnumerable<string> GetNumericCodes() => NumericCodeMap.Keys;
}