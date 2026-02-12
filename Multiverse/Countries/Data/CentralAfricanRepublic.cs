using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CentralAfricanRepublic =
        new Country(
            CountryNames.CentralAfricanRepublic, "140", "CF", "CAF",
            "+236", "Bangui", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.French);
}