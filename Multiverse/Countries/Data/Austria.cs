using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Austria =
        new Country(
            CountryNames.Austria, "040", "AT", "AUT",
            "+43", "Vienna", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.German);
}