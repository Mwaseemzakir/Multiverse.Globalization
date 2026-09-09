namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Maldives country.</summary>
    public static readonly Country Maldives =
        new(
            CountryNames.Maldives, "462", "MV", "MDV",
            "+960", "Male", "Asia",
            CurrencyHelper.MaldivianRufiyaa,
            LanguageHelper.Divehi);
}