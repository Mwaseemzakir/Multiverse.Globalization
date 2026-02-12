using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Slovakia =
        new Country(
            CountryNames.Slovakia, "703", "SK", "SVK",
            "+421", "Bratislava", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Slovak);
}