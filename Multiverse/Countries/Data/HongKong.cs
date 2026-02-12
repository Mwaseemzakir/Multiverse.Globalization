using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country HongKong =
        new Country(
            CountryNames.HongKong, "344", "HK", "HKG",
            "+852", "Hong Kong", "Asia",
            CurrencyHelper.HongKongDollar,
            LanguageHelper.Chinese, LanguageHelper.English);
}