using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Yemen =
        new Country(
            CountryNames.Yemen, "887", "YE", "YEM",
            "+967", "Sana'a", "Asia",
            CurrencyHelper.YemeniRial,
            LanguageHelper.Arabic);
}