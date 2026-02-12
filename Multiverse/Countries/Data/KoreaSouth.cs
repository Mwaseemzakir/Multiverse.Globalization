using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country KoreaSouth =
        new Country(
            CountryNames.KoreaSouth, "410", "KR", "KOR",
            "+82", "Seoul", "Asia",
            CurrencyHelper.Won,
            LanguageHelper.Korean);
}