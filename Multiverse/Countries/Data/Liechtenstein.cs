using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Liechtenstein country.</summary>
    public static readonly Country Liechtenstein =
        new Country(
            CountryNames.Liechtenstein, "438", "LI", "LIE",
            "+423", "Vaduz", "Europe",
            CurrencyHelper.SwissFranc,
            LanguageHelper.German);
}