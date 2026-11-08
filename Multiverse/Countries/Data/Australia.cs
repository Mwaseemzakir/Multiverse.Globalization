namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Australia country.</summary>
    public static readonly Country Australia =
        new(
            CountryNames.Australia, "036", "AU", "AUS",
            "+61", "Canberra", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English);
}