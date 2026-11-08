namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Hong Kong country.</summary>
    public static readonly Country HongKong =
        new(
            CountryNames.HongKong, "344", "HK", "HKG",
            "+852", "Hong Kong", "Asia",
            CurrencyHelper.HongKongDollar,
            LanguageHelper.Chinese, LanguageHelper.English);
}