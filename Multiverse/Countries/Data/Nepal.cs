namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Nepal country.</summary>
    public static readonly Country Nepal =
        new(
            CountryNames.Nepal, "524", "NP", "NPL",
            "+977", "Kathmandu", "Asia",
            CurrencyHelper.NepaleseRupee,
            LanguageHelper.Nepali);
}