using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country WallisAndFutunaIslands =
        new Country(
            CountryNames.WallisAndFutunaIslands, "876", "WF", "WLF",
            "+681", "Mata-Utu", "Oceania",
            CurrencyHelper.CfpFranc,
            LanguageHelper.French);
}