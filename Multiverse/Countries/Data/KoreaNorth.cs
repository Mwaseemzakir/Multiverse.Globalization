using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country KoreaNorth =
        new Country(
            CountryNames.KoreaNorth, "408", "KP", "PRK",
            "+850", "Pyongyang", "Asia",
            CurrencyHelper.NorthKoreanWon,
            LanguageHelper.Korean);
}