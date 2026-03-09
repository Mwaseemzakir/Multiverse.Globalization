using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Lao PDR country.</summary>
    public static readonly Country LaoPDR =
        new Country(
            CountryNames.LaoPDR, "418", "LA", "LAO",
            "+856", "Vientiane", "Asia",
            CurrencyHelper.LaoKip,
            LanguageHelper.Lao);
}