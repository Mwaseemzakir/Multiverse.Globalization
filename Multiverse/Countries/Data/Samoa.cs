using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Samoa =
        new Country(
            CountryNames.Samoa, "882", "WS", "WSM",
            "+685", "Apia", "Oceania",
            CurrencyHelper.SamoanTala,
            LanguageHelper.Samoan, LanguageHelper.English);
}