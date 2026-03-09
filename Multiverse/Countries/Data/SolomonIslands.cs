using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Solomon Islands country.</summary>
    public static readonly Country SolomonIslands =
        new Country(
            CountryNames.SolomonIslands, "090", "SB", "SLB",
            "+677", "Honiara", "Oceania",
            CurrencyHelper.SolomonIslandsDollar,
            LanguageHelper.English);
}