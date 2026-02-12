using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Provides access to all country instances and lookup dictionaries.
/// Individual countries are defined as partial class members in the Data folder.
/// </summary>
public static partial class CountryHelper
{
    /// <summary>Empty sentinel value representing no country.</summary>
    public static readonly Country None = new Country("", "", "", "", "", "", "", null);

    private static readonly Lazy<List<Country>> _all = new(() =>
        typeof(CountryHelper)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Country))
            .Select(f => (Country)f.GetValue(null)!)
            .OrderBy(c => c.Name)
            .ToList());

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _alpha2CodeMap = new(() =>
        _all.Value.ToDictionary(c => c.Alpha2Code.ToLowerInvariant()));

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _alpha3CodeMap = new(() =>
        _all.Value.ToDictionary(c => c.Alpha3Code.ToLowerInvariant()));

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _nameMap = new(() =>
        _all.Value.ToDictionary(c => c.Name.ToLowerInvariant()));

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _numericCodeMap = new(() =>
        _all.Value.ToDictionary(c => c.NumericCode));

    /// <summary>Returns a new list containing all countries.</summary>
    public static List<Country> GetAll() => new(_all.Value);

    /// <summary>Lookup by ISO 3166-1 alpha-2 code (case-insensitive).</summary>
    public static IReadOnlyDictionary<string, Country> Alpha2CodeMap => _alpha2CodeMap.Value;

    /// <summary>Lookup by ISO 3166-1 alpha-3 code (case-insensitive).</summary>
    public static IReadOnlyDictionary<string, Country> Alpha3CodeMap => _alpha3CodeMap.Value;

    /// <summary>Lookup by country name (case-insensitive).</summary>
    public static IReadOnlyDictionary<string, Country> NameMap => _nameMap.Value;

    /// <summary>Lookup by ISO 3166-1 numeric code.</summary>
    public static IReadOnlyDictionary<string, Country> NumericCodeMap => _numericCodeMap.Value;
}
