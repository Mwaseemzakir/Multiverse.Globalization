using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Mexico =
        new Country(
            CountryNames.Mexico, "484", "MX", "MEX",
            "+52", "Mexico City", "Americas",
            CurrencyHelper.MexicanPeso,
            LanguageHelper.Spanish);
}