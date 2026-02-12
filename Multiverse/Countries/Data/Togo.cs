using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Togo =
        new Country(
            CountryNames.Togo, "768", "TG", "TGO",
            "+228", "Lome", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}