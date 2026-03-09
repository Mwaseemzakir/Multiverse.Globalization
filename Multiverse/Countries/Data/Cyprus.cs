using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Cyprus country.</summary>
    public static readonly Country Cyprus =
        new Country(
            CountryNames.Cyprus, "196", "CY", "CYP",
            "+357", "Nicosia", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.GreekModern, LanguageHelper.Turkish);
}