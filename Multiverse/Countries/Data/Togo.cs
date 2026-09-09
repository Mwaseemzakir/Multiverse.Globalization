namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Togo country.</summary>
    public static readonly Country Togo =
        new(
            CountryNames.Togo, "768", "TG", "TGO",
            "+228", "Lome", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}