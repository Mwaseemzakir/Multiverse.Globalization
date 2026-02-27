using System;
using System.Collections.Generic;
using static Multiverse.Globalization.Currencies.CurrencyHelper;

namespace Multiverse.Globalization.Currencies;

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

    public int Number { get; private set; }
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string Symbol { get; private set; } = string.Empty;

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

    /// <inheritdoc />
    public override string ToString() => $"{Name} ({Code})";

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Currency other && Code == other.Code;

    /// <inheritdoc />
    public override int GetHashCode() => Code.GetHashCode();
}
