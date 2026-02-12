using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Burundi =
        new Country(
            CountryNames.Burundi, "108", "BI", "BDI",
            "+257", "Gitega", "Africa",
            CurrencyHelper.BurundianFranc,
            LanguageHelper.French, LanguageHelper.Rundi);
}