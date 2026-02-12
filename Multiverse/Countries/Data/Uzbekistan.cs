using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Uzbekistan =
        new Country(
            CountryNames.Uzbekistan, "860", "UZ", "UZB",
            "+998", "Tashkent", "Asia",
            CurrencyHelper.UzbekistanSum,
            LanguageHelper.Uzbek);
}