namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Timor Leste country.</summary>
    public static readonly Country TimorLeste =
        new(
            CountryNames.TimorLeste, "626", "TL", "TLS",
            "+670", "Dili", "Asia",
            CurrencyHelper.UsDollar,
            LanguageHelper.Portuguese, LanguageHelper.Tetum);
}