namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The American Samoa country.</summary>
    public static readonly Country AmericanSamoa =
        new(
            CountryNames.AmericanSamoa, "016", "AS", "ASM",
            "+1", "Pago Pago", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.English, LanguageHelper.Samoan);
}