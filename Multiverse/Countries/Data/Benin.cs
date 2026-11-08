namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Benin country.</summary>
    public static readonly Country Benin =
        new(
            CountryNames.Benin, "204", "BJ", "BEN",
            "+229", "Porto-Novo", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}