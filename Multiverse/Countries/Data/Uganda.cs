namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Uganda country.</summary>
    public static readonly Country Uganda =
        new(
            CountryNames.Uganda, "800", "UG", "UGA",
            "+256", "Kampala", "Africa",
            CurrencyHelper.UgandanShilling,
            LanguageHelper.English, LanguageHelper.Swahili);
}