using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CongoBrazzaville =
        new Country(
            CountryNames.CongoBrazzaville, "178", "CG", "COG",
            "+242", "Brazzaville", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.French);
}