using Multiverse.Helpers;
using System.Collections.Generic;

namespace Multiverse.Models;

public sealed class Currency
{
    public static int Count => CodeCurrencies.Count;
    private static readonly IReadOnlyDictionary<string, Currency> CodeCurrencies = CurrencyHelpers.CodeMap;
    private static readonly IReadOnlyDictionary<int, Currency> NumberCurrencies = CurrencyHelpers.NumberMap;

    internal Currency(
        string currencyName,
        int number,
        string code)
    {
        Code = code;
        Number = number;
        CurrencyName = currencyName;
    }

    public int Number { get; private set; }
    public string Code { get; private set; } = string.Empty;
    public string CurrencyName { get; private set; } = string.Empty;

    public static bool IsValidNumberCode(int number) =>
        number > 0 && NumberCurrencies.ContainsKey(number);

    public static bool IsValidIsoCode(string code) =>
        !string.IsNullOrWhiteSpace(code) 
        && code.Length == 3 
        && CodeCurrencies.ContainsKey(code.ToUpperInvariant());

    public static Currency? GetByIsoCodeOrDefault(string code) =>
        IsValidIsoCode(code) ? CodeCurrencies[code.ToUpperInvariant()] : default;

    public static Currency? GetByNumberOrDefault(int number) =>
        IsValidNumberCode(number) ? NumberCurrencies[number] : default;

    public static bool TryGetByIsoCodeOrDefault(string code, out Currency? currency)
    {
        if(IsValidIsoCode(code))
        {
            return CodeCurrencies.TryGetValue(code.ToUpperInvariant(), out currency);
        }

        currency = default;
        return false;
    }

    public static bool TryGetByNumberOrDefault(int number, out Currency? currency)
    {
        if(IsValidNumberCode(number))
        {
            return NumberCurrencies.TryGetValue(number, out currency);
        }

        currency = default;
        return false;
    }

    public static List<Currency> GetAll() => CurrencyHelpers.GetAll();
    public static IEnumerable<string> GetIsoCodes() => CodeCurrencies.Keys;
    public static IEnumerable<int> GetNumericCodes() => NumberCurrencies.Keys;
}
