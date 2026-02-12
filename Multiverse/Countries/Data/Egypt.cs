using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Egypt =
        new Country(
            CountryNames.Egypt, "818", "EG", "EGY",
            "+20", "Cairo", "Africa",
            CurrencyHelper.EgyptianPound,
            LanguageHelper.Arabic);
}