using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Puerto Rico country.</summary>
    public static readonly Country PuertoRico =
        new Country(
            CountryNames.PuertoRico, "630", "PR", "PRI",
            "+1", "San Juan", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.Spanish, LanguageHelper.English);
}