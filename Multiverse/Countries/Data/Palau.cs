namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Palau country.</summary>
    public static readonly Country Palau =
        new(
            CountryNames.Palau, "585", "PW", "PLW",
            "+680", "Ngerulmud", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.Palauan, LanguageHelper.English);
}