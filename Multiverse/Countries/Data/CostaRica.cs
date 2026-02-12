using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CostaRica =
        new Country(
            CountryNames.CostaRica, "188", "CR", "CRI",
            "+506", "San Jose", "Americas",
            CurrencyHelper.CostaRicanColon,
            LanguageHelper.Spanish);
}