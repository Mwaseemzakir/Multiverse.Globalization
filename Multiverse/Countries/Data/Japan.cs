using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Japan =
        new Country(
            CountryNames.Japan, "392", "JP", "JPN",
            "+81", "Tokyo", "Asia",
            CurrencyHelper.Yen,
            LanguageHelper.Japanese);
}