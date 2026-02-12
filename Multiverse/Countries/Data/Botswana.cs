using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Botswana =
        new Country(
            CountryNames.Botswana, "072", "BW", "BWA",
            "+267", "Gaborone", "Africa",
            CurrencyHelper.BotswanaPula,
            LanguageHelper.English, LanguageHelper.Tswana);
}