namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Georgia country.</summary>
    public static readonly Country Georgia =
        new(
            CountryNames.Georgia, "268", "GE", "GEO",
            "+995", "Tbilisi", "Asia",
            CurrencyHelper.Lari,
            LanguageHelper.Georgian);
}