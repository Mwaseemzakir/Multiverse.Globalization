using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Algeria =
        new Country(
            CountryNames.Algeria, "012", "DZ", "DZA",
            "+213", "Algiers", "Africa",
            CurrencyHelper.AlgerianDinar,
            LanguageHelper.Arabic);
}