using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Germany =
        new Country(
            CountryNames.Germany, "276", "DE", "DEU",
            "+49", "Berlin", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.German);
}