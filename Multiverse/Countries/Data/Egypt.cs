namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Egypt country.</summary>
    public static readonly Country Egypt =
        new(
            CountryNames.Egypt, "818", "EG", "EGY",
            "+20", "Cairo", "Africa",
            CurrencyHelper.EgyptianPound,
            LanguageHelper.Arabic);
}