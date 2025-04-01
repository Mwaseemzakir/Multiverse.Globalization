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
    public static bool IsValid(string identifier) =>
        !string.IsNullOrWhiteSpace(identifier) &&
        (CodeMap.ContainsKey(identifier.ToUpperInvariant()) || NameMap.ContainsKey(identifier.ToUpperInvariant()));

    /// <summary>
    /// Retrieves a Currency object based on the provided identifier, which can be a currency code or name. 
    /// Returns null if not found.
    /// </summary>
    public static Currency? GetCurrencyOrDefault(string identifier) =>
        IsValid(identifier) ?
        CodeMap.ContainsKey(identifier.ToUpperInvariant()) ? CodeMap[identifier.ToUpperInvariant()] : NameMap[identifier.ToUpperInvariant()] 
        : default;

    /// <summary>
    /// Retrieves a Currency object based on the provided identifier, which can be a currency code or name. 
    /// Throws an exception if not found.
    /// </summary>
    public static Currency GetCurrency(string identifier)
    {
        if (identifier == null)
            throw new ArgumentNullException(nameof(identifier));

        if (!IsValid(identifier))
            throw new CurrencyNotFoundException($"Currency with identifier '{identifier}' was not found.");

        return CodeMap.ContainsKey(identifier.ToUpperInvariant()) ? CodeMap[identifier.ToUpperInvariant()] : NameMap[identifier.ToUpperInvariant()];
    }

    /// <summary>
    /// Retrieves a Currency object based on the provided number. 
    /// Returns null if not found.
    /// </summary>
    public static Currency? GetCurrencyOrDefault(int number) =>
        NumberMap.ContainsKey(number) ? NumberMap[number] : default;

    /// <summary>
    /// Retrieves a Currency object based on the provided number. 
    /// Throws an exception if not found.
    /// </summary>
    public static Currency GetCurrency(int number)
    {
        if (!NumberMap.ContainsKey(number))
            throw new CurrencyNotFoundException($"Currency with number '{number}' was not found.");

        return NumberMap[number];
    }

    /// <summary>
    /// Retrieves a list of all available Currency objects.
    /// </summary>
    public static List<Currency> GetAll() => CurrencyHelper.GetAll();
}
