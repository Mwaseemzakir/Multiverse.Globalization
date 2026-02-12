using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Belgium =
        new Country(
            CountryNames.Belgium, "056", "BE", "BEL",
            "+32", "Brussels", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Dutch, LanguageHelper.French, LanguageHelper.German);
}