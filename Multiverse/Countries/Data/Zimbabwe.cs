using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Zimbabwe =
        new Country(
            CountryNames.Zimbabwe, "716", "ZW", "ZWE",
            "+263", "Harare", "Africa",
            CurrencyHelper.ZimbabweanDollar,
            LanguageHelper.English, LanguageHelper.Shona);
}