namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Chad country.</summary>
    public static readonly Country Chad =
        new(
            CountryNames.Chad, "148", "TD", "TCD",
            "+235", "N'Djamena", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.French, LanguageHelper.Arabic);
}