using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Jamaica country.</summary>
    public static readonly Country Jamaica =
        new Country(
            CountryNames.Jamaica, "388", "JM", "JAM",
            "+1", "Kingston", "Americas",
            CurrencyHelper.JamaicanDollar,
            LanguageHelper.English);
}