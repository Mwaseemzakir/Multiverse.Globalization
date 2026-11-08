namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Gabon country.</summary>
    public static readonly Country Gabon =
        new(
            CountryNames.Gabon, "266", "GA", "GAB",
            "+241", "Libreville", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.French);
}