namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The USMinor Outlying Islands country.</summary>
    public static readonly Country USMinorOutlyingIslands =
        new(
            CountryNames.USMinorOutlyingIslands, "581", "UM", "UMI",
            "+1", "", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}