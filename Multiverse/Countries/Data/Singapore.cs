using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Singapore =
        new Country(
            CountryNames.Singapore, "702", "SG", "SGP",
            "+65", "Singapore", "Asia",
            CurrencyHelper.SingaporeDollar,
            LanguageHelper.English, LanguageHelper.Malay, LanguageHelper.Chinese, LanguageHelper.Tamil);
}