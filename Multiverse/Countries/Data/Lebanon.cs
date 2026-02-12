using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Lebanon =
        new Country(
            CountryNames.Lebanon, "422", "LB", "LBN",
            "+961", "Beirut", "Asia",
            CurrencyHelper.LebanesePound,
            LanguageHelper.Arabic);
}