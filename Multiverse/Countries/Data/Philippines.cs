using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Philippines =
        new Country(
            CountryNames.Philippines, "608", "PH", "PHL",
            "+63", "Manila", "Asia",
            CurrencyHelper.PhilippinePeso,
            LanguageHelper.Filipino, LanguageHelper.English);
}