using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Macao =
        new Country(
            CountryNames.Macao, "446", "MO", "MAC",
            "+853", "Macao", "Asia",
            CurrencyHelper.MacanesePataca,
            LanguageHelper.Chinese, LanguageHelper.Portuguese);
}