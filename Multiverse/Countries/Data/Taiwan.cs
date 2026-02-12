using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Taiwan =
        new Country(
            CountryNames.Taiwan, "158", "TW", "TWN",
            "+886", "Taipei", "Asia",
            CurrencyHelper.NewTaiwanDollar,
            LanguageHelper.Chinese);
}