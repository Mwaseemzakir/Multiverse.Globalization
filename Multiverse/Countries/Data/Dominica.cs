using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Dominica =
        new Country(
            CountryNames.Dominica, "212", "DM", "DMA",
            "+1", "Roseau", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}