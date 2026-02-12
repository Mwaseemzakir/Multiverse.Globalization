using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country FrenchPolynesia =
        new Country(
            CountryNames.FrenchPolynesia, "258", "PF", "PYF",
            "+689", "Papeete", "Oceania",
            CurrencyHelper.CfpFranc,
            LanguageHelper.French);
}