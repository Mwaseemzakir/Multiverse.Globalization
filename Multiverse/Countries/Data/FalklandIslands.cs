using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Falkland Islands country.</summary>
    public static readonly Country FalklandIslands =
        new Country(
            CountryNames.FalklandIslands, "238", "FK", "FLK",
            "+500", "Stanley", "Americas",
            CurrencyHelper.FalklandIslandsPound,
            LanguageHelper.English);
}