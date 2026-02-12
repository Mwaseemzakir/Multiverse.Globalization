using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Lithuania =
        new Country(
            CountryNames.Lithuania, "440", "LT", "LTU",
            "+370", "Vilnius", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Lithuanian);
}