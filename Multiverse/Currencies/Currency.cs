using System;
using System.Collections.Generic;
using System.Linq;
using static Multiverse.Globalization.Currencies.CurrencyHelper;

namespace Multiverse.Globalization.Currencies;

/// <summary>
/// Represents an ISO 4217 currency with its code, name, number, and symbol.
/// </summary>
public sealed class Currency
{  
    internal Currency(
        int number,
        string name,
        string code,
        string symbol)
    {
        Code = code;
        Number = number;
        Name = name;
        Symbol = symbol;
    }

    /// <summary>ISO 4217 numeric code.</summary>
    public int Number { get; private set; }
    /// <summary>ISO 4217 three-letter currency code, e.g. "USD".</summary>
    public string Code { get; private set; } = string.Empty;
    /// <summary>Full name of the currency, e.g. "US Dollar".</summary>
    public string Name { get; private set; } = string.Empty;
    /// <summary>Currency symbol, e.g. "$", "€", "£".</summary>
    public string Symbol { get; private set; } = string.Empty;

    /// <summary>
    /// Number of decimal places (minor units) for this currency.
    /// Most currencies use 2 (e.g. USD, EUR). Some use 0 (e.g. JPY), 3 (e.g. KWD, BHD), or 4 (e.g. CLF).
    /// </summary>
    public int DecimalPlaces { get; private set; } = 2;

    internal void SetDecimalPlaces(int places) => DecimalPlaces = places;

    /// <summary>
    /// Checks if the provided identifier is valid. 
    /// The identifier can be a currency code or name.
    /// </summary>
    public static bool IsValid(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return false;

        var key = identifier.ToLowerInvariant();
        return CodeMap.ContainsKey(key) || NameMap.ContainsKey(key);
    }

    /// <summary>
    /// Checks if the provided identifier is valid. 
    /// The identifier would be currency number
    /// </summary>
    public static bool IsValid(int number)
    {
        return NumberMap.ContainsKey(number);
    }

    /// <summary>
    /// Retrieves a Currency object based on the provided identifier, which can be a currency code or name. 
    /// Returns null if not found.
    /// </summary>
    public static Currency? GetCurrencyOrDefault(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return default;

        var key = identifier.ToLowerInvariant();

        if (CodeMap.TryGetValue(key, out var byCode))
            return byCode;

        if (NameMap.TryGetValue(key, out var byName))
            return byName;

        return default;
    }

    /// <summary>
    /// Retrieves a Currency object based on the provided identifier, which can be a currency code or name. 
    /// Throws an exception if not found.
    /// </summary>
    public static Currency GetCurrency(string identifier)
    {
        if (identifier == null)
            throw new ArgumentNullException(nameof(identifier));

        return GetCurrencyOrDefault(identifier)
            ?? throw new CurrencyNotFoundException($"Currency with identifier '{identifier}' was not found.");
    }

    /// <summary>
    /// Retrieves a Currency object based on the provided number. 
    /// Returns null if not found.
    /// </summary>
    public static Currency? GetCurrencyOrDefault(int number) =>
        NumberMap.TryGetValue(number, out var currency) ? currency : default;

    /// <summary>
    /// Retrieves a Currency object based on the provided number. 
    /// Throws an exception if not found.
    /// </summary>
    public static Currency GetCurrency(int number)
    {
        return GetCurrencyOrDefault(number)
            ?? throw new CurrencyNotFoundException($"Currency with number '{number}' was not found.");
    }

    /// <summary>
    /// Retrieves a list of all available Currency objects.
    /// </summary>
    public static IReadOnlyList<Currency> GetAll() => CurrencyHelper.GetAll();

    /// <summary>
    /// Returns all countries that use this currency as their primary currency.
    /// </summary>
    public IReadOnlyList<Countries.Country> GetCountriesUsingCurrency()
        => Countries.Country.GetAll()
            .Where(c => c.Currency != null && c.Currency.Code == Code)
            .ToList()
            .AsReadOnly();

    /// <inheritdoc />
    public override string ToString() => $"{Name} ({Code})";

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Currency other && Code == other.Code;

    /// <inheritdoc />
    public override int GetHashCode() => Code.GetHashCode();
}
