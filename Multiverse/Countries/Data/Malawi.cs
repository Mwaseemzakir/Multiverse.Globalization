using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Malawi =
        new Country(
            CountryNames.Malawi, "454", "MW", "MWI",
            "+265", "Lilongwe", "Africa",
            CurrencyHelper.MalawianKwacha,
            LanguageHelper.English, LanguageHelper.Chichewa);
}