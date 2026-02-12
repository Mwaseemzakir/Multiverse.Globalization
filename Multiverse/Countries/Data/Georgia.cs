using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Georgia =
        new Country(
            CountryNames.Georgia, "268", "GE", "GEO",
            "+995", "Tbilisi", "Asia",
            CurrencyHelper.Lari,
            LanguageHelper.Georgian);
}