using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Guam =
        new Country(
            CountryNames.Guam, "316", "GU", "GUM",
            "+1", "Hagatna", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.English, LanguageHelper.Chamorro);
}