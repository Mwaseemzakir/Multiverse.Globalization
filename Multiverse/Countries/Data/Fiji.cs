using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Fiji =
        new Country(
            CountryNames.Fiji, "242", "FJ", "FJI",
            "+679", "Suva", "Oceania",
            CurrencyHelper.FijianDollar,
            LanguageHelper.English, LanguageHelper.Fijian, LanguageHelper.Hindi);
}