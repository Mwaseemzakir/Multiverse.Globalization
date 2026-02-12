using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Tonga =
        new Country(
            CountryNames.Tonga, "776", "TO", "TON",
            "+676", "Nuku'alofa", "Oceania",
            CurrencyHelper.TonganPaanga,
            LanguageHelper.TongaIslands, LanguageHelper.English);
}