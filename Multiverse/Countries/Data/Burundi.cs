namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Burundi country.</summary>
    public static readonly Country Burundi =
        new(
            CountryNames.Burundi, "108", "BI", "BDI",
            "+257", "Gitega", "Africa",
            CurrencyHelper.BurundianFranc,
            LanguageHelper.French, LanguageHelper.Rundi);
}