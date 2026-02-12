using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Belize =
        new Country(
            CountryNames.Belize, "084", "BZ", "BLZ",
            "+501", "Belmopan", "Americas",
            CurrencyHelper.BelizeDollar,
            LanguageHelper.English, LanguageHelper.Spanish);
}