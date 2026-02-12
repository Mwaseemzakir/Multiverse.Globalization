using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Cameroon =
        new Country(
            CountryNames.Cameroon, "120", "CM", "CMR",
            "+237", "Yaounde", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.French, LanguageHelper.English);
}