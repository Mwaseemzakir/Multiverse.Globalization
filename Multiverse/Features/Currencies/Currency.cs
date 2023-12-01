namespace Multiverse.Features.Currencies;
public record Currency
{
    public static readonly Currency None = new(string.Empty, 0, string.Empty);

    #region  Currencies
    private static readonly Currency AFN = new("Afghani", 971, "AFN");
    #endregion
    private Currency(string currencyName, int number, string code)
    {
        Code = code;
        Number = number;
        CurrencyName = currencyName;
    }
    public string Code { get; private set; } = string.Empty;
    public int Number { get; private set; }
    public string Country { get; private set; } = string.Empty;
    public string CurrencyName { get; private set; } = string.Empty;
    public static readonly IReadOnlyDictionary<string, Currency> CodeCurrencies = CreateCodeCurrencies();
    public static readonly IReadOnlyDictionary<int, Currency> NumberCurrencies = CreateNumberCurrencies();
    public static bool ValidNumberCode(int number)
    {
        if (number > 0 )
        {
            return NumberCurrencies.ContainsKey(number);
        }
        return false;
    }
    public static bool ValidIsoCode(string code)
    {
        if (!string.IsNullOrWhiteSpace(code) && code.Length == 3)
        {
            string upperVariant = code.ToUpperInvariant();

            if (code != upperVariant)
            {
                code = upperVariant;
            }

            return CodeCurrencies.ContainsKey(code);
        }
        return false;
    }
    private static IReadOnlyDictionary<string, Currency> CreateCodeCurrencies()
    {
        var type = typeof(Currency);

        var fields = type.GetFields(
                        BindingFlags.NonPublic |
                        BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Currency))
            .Select(f => (Currency)f.GetValue(default)!);

        return fields.ToDictionary(f => f.Code);
    }
    private static IReadOnlyDictionary<int, Currency> CreateNumberCurrencies()
    {
        var type = typeof(Currency);

        var fields = type.GetFields(
                               BindingFlags.NonPublic |
                               BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Currency))
            .Select(f => (Currency)f.GetValue(default)!);

        return fields.ToDictionary(f => f.Number);
    }
}