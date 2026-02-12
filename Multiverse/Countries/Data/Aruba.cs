using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Aruba =
        new Country(
            CountryNames.Aruba, "533", "AW", "ABW",
            "+297", "Oranjestad", "Americas",
            CurrencyHelper.ArubanFlorin,
            LanguageHelper.Dutch, LanguageHelper.Spanish, LanguageHelper.English);
}