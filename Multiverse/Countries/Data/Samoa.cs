namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Samoa country.</summary>
    public static readonly Country Samoa =
        new(
            CountryNames.Samoa, "882", "WS", "WSM",
            "+685", "Apia", "Oceania",
            CurrencyHelper.SamoanTala,
            LanguageHelper.Samoan, LanguageHelper.English);
}