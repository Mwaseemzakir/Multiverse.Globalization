using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country BritishVirginIslands =
        new Country(
            CountryNames.BritishVirginIslands, "092", "VG", "VGB",
            "+1", "Road Town", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}