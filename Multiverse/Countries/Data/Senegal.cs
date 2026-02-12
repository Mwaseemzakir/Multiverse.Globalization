using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Senegal =
        new Country(
            CountryNames.Senegal, "686", "SN", "SEN",
            "+221", "Dakar", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}