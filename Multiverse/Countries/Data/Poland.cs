using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Poland =
        new Country(
            CountryNames.Poland, "616", "PL", "POL",
            "+48", "Warsaw", "Europe",
            CurrencyHelper.Zloty,
            LanguageHelper.Polish);
}