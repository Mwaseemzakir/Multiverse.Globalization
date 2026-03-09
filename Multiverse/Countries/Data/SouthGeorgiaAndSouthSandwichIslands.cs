using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The South Georgia And South Sandwich Islands country.</summary>
    public static readonly Country SouthGeorgiaAndSouthSandwichIslands =
        new Country(
            CountryNames.SouthGeorgiaAndSouthSandwichIslands, "239", "GS", "SGS",
            "+500", "King Edward Point", "Americas",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English);
}