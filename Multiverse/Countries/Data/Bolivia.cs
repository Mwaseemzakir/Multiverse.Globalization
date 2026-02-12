using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Bolivia =
        new Country(
            CountryNames.Bolivia, "068", "BO", "BOL",
            "+591", "Sucre", "Americas",
            CurrencyHelper.Boliviano,
            LanguageHelper.Spanish, LanguageHelper.Quechua, LanguageHelper.Aymara);
}