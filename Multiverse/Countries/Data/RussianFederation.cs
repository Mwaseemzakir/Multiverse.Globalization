using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country RussianFederation =
        new Country(
            CountryNames.RussianFederation, "643", "RU", "RUS",
            "+7", "Moscow", "Europe",
            CurrencyHelper.RussianRuble,
            LanguageHelper.Russian);
}