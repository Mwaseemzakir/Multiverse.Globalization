namespace Multiverse.Globalization.Currencies;

/// <summary>
/// Where the currency symbol sits relative to the amount when formatting.
/// </summary>
public enum CurrencySymbolPosition
{
    /// <summary>Symbol before the amount, e.g. "$1,234.50". The convention in en-US, en-GB, ja-JP.</summary>
    Prefix,

    /// <summary>Symbol after the amount separated by a space, e.g. "1.234,50 €". The convention across much of Europe.</summary>
    Suffix,

    /// <summary>No symbol at all — just the formatted amount, e.g. "1,234.50".</summary>
    None
}
