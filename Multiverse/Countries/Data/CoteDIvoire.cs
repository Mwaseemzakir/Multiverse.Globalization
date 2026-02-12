using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CoteDIvoire =
        new Country(
            CountryNames.CoteDIvoire, "384", "CI", "CIV",
            "+225", "Yamoussoukro", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}