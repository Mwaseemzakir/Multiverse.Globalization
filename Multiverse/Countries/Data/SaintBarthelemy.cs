using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaintBarthelemy =
        new Country(
            CountryNames.SaintBarthelemy, "652", "BL", "BLM",
            "+590", "Gustavia", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}