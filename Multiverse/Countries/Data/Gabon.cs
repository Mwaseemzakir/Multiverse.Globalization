using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Gabon =
        new Country(
            CountryNames.Gabon, "266", "GA", "GAB",
            "+241", "Libreville", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.French);
}