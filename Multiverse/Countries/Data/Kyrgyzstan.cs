namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Kyrgyzstan country.</summary>
    public static readonly Country Kyrgyzstan =
        new(
            CountryNames.Kyrgyzstan, "417", "KG", "KGZ",
            "+996", "Bishkek", "Asia",
            CurrencyHelper.Som,
            LanguageHelper.Kirghiz, LanguageHelper.Russian);
}