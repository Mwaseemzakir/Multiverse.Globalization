using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Tajikistan =
        new Country(
            CountryNames.Tajikistan, "762", "TJ", "TJK",
            "+992", "Dushanbe", "Asia",
            CurrencyHelper.Somoni,
            LanguageHelper.Tajik);
}