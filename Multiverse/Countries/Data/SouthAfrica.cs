using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The South Africa country.</summary>
    public static readonly Country SouthAfrica =
        new Country(
            CountryNames.SouthAfrica, "710", "ZA", "ZAF",
            "+27", "Pretoria", "Africa",
            CurrencyHelper.Rand,
            LanguageHelper.Afrikaans, LanguageHelper.English, LanguageHelper.Zulu);
}