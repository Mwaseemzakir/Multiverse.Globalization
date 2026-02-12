using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Jordan =
        new Country(
            CountryNames.Jordan, "400", "JO", "JOR",
            "+962", "Amman", "Asia",
            CurrencyHelper.JordanianDinar,
            LanguageHelper.Arabic);
}