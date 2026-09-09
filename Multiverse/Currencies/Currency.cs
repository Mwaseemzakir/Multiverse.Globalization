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
    public int Number { get; }
    /// <summary>ISO 4217 three-letter currency code, e.g. "USD".</summary>
    public string Code { get; }
    /// <summary>Full name of the currency, e.g. "US Dollar".</summary>
    public string Name { get; }
    /// <summary>Currency symbol, e.g. "$", "€", "£".</summary>
    public string Symbol { get; }

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
            return null;

        var key = identifier.ToLowerInvariant();

        if (CodeMap.TryGetValue(key, out var byCode))
            return byCode;

        if (NameMap.TryGetValue(key, out var byName))
            return byName;

        return null;
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
        NumberMap.TryGetValue(number, out var currency) ? currency : null;

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

    // ── Formatting ────────────────────────────────────────────

    /// <summary>
    /// Formats a monetary amount in this currency, rounded to <see cref="DecimalPlaces"/> and
    /// rendered with the separators of the supplied country, e.g. "$1,234.50" for the US or
    /// "1.234,50 €" for Germany.
    /// </summary>
    /// <param name="amount">The amount to format.</param>
    /// <param name="locale">
    /// The country locale supplying the decimal and group separators, typically
    /// <c>Country.GetCountry("DE").Locale</c>. When null, invariant separators ("." and ",") are used.
    /// </param>
    /// <param name="position">Where to place the currency symbol. Defaults to <see cref="CurrencySymbolPosition.Prefix"/>.</param>
    public string Format(
        decimal amount,
        Countries.CountryLocale? locale = null,
        CurrencySymbolPosition position = CurrencySymbolPosition.Prefix)
    {
        var number = locale is null
            ? Math.Round(amount, DecimalPlaces, MidpointRounding.AwayFromZero)
                .ToString("N" + DecimalPlaces.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    System.Globalization.CultureInfo.InvariantCulture)
            : locale.FormatNumber(amount, DecimalPlaces);

        if (position == CurrencySymbolPosition.None || Symbol.Length == 0)
            return number;

        return position == CurrencySymbolPosition.Prefix
            ? Symbol + number
            : number + " " + Symbol;
    }

    /// <summary>
    /// Rounds an amount to this currency's minor unit, e.g. 2 decimals for USD, 0 for JPY,
    /// 3 for KWD. Uses away-from-zero rounding, the convention for monetary values.
    /// </summary>
    public decimal Round(decimal amount) =>
        Math.Round(amount, DecimalPlaces, MidpointRounding.AwayFromZero);

    /// <summary>
    /// Converts a whole number of minor units (cents, pence, fils) into a major-unit amount,
    /// e.g. <c>123450</c> USD minor units becomes <c>1234.50</c>.
    /// </summary>
    public decimal FromMinorUnits(long minorUnits)
    {
        decimal factor = 1;
        for (var i = 0; i < DecimalPlaces; i++)
            factor *= 10;

        return minorUnits / factor;
    }

    /// <summary>
    /// Converts a major-unit amount into whole minor units, e.g. <c>1234.50</c> USD becomes
    /// <c>123450</c>. The amount is rounded to the currency's minor unit first.
    /// </summary>
    public long ToMinorUnits(decimal amount)
    {
        decimal factor = 1;
        for (var i = 0; i < DecimalPlaces; i++)
            factor *= 10;

        return (long)Math.Round(amount * factor, 0, MidpointRounding.AwayFromZero);
    }

    /// <inheritdoc />
    public override string ToString() => $"{Name} ({Code})";

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Currency other && Code == other.Code;

    /// <inheritdoc />
    public override int GetHashCode() => Code.GetHashCode();
}
