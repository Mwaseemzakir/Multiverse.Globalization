using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Tokelau =
        new Country(
            CountryNames.Tokelau, "772", "TK", "TKL",
            "+690", "", "Oceania",
            CurrencyHelper.NewZealandDollar,
            LanguageHelper.English);
}