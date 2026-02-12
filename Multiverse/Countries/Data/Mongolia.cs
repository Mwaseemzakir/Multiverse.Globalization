using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Mongolia =
        new Country(
            CountryNames.Mongolia, "496", "MN", "MNG",
            "+976", "Ulaanbaatar", "Asia",
            CurrencyHelper.MongolianTugrik,
            LanguageHelper.Mongolian);
}