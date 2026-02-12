using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Sudan =
        new Country(
            CountryNames.Sudan, "736", "SD", "SDN",
            "+249", "Khartoum", "Africa",
            CurrencyHelper.SudanesePound,
            LanguageHelper.Arabic, LanguageHelper.English);
}