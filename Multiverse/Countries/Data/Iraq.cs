using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Iraq =
        new Country(
            CountryNames.Iraq, "368", "IQ", "IRQ",
            "+964", "Baghdad", "Asia",
            CurrencyHelper.IraqiDinar,
            LanguageHelper.Arabic);
}