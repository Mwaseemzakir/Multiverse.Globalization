namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Gambia country.</summary>
    public static readonly Country Gambia =
        new(
            CountryNames.Gambia, "270", "GM", "GMB",
            "+220", "Banjul", "Africa",
            CurrencyHelper.GambianDalasi,
            LanguageHelper.English);
}