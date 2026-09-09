namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Comoros country.</summary>
    public static readonly Country Comoros =
        new(
            CountryNames.Comoros, "174", "KM", "COM",
            "+269", "Moroni", "Africa",
            CurrencyHelper.ComorianFranc,
            LanguageHelper.Arabic, LanguageHelper.French);
}