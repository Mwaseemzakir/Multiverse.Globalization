using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Gambia =
        new Country(
            CountryNames.Gambia, "270", "GM", "GMB",
            "+220", "Banjul", "Africa",
            CurrencyHelper.GambianDalasi,
            LanguageHelper.English);
}