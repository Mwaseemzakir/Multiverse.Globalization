namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Thailand country.</summary>
    public static readonly Country Thailand =
        new(
            CountryNames.Thailand, "764", "TH", "THA",
            "+66", "Bangkok", "Asia",
            CurrencyHelper.Baht,
            LanguageHelper.Thai);
}