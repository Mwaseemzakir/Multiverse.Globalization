using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Svalbard And Jan Mayen Islands country.</summary>
    public static readonly Country SvalbardAndJanMayenIslands =
        new Country(
            CountryNames.SvalbardAndJanMayenIslands, "744", "SJ", "SJM",
            "+47", "Longyearbyen", "Europe",
            CurrencyHelper.NorwegianKrone,
            LanguageHelper.Norwegian);
}