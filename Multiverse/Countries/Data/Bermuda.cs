using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Bermuda =
        new Country(
            CountryNames.Bermuda, "060", "BM", "BMU",
            "+1", "Hamilton", "Americas",
            CurrencyHelper.BermudianDollar,
            LanguageHelper.English);
}