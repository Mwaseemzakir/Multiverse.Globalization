using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CzechRepublic =
        new Country(
            CountryNames.CzechRepublic, "203", "CZ", "CZE",
            "+420", "Prague", "Europe",
            CurrencyHelper.CzechKoruna,
            LanguageHelper.Czech);
}