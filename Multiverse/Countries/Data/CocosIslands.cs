using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Cocos Islands country.</summary>
    public static readonly Country CocosIslands =
        new Country(
            CountryNames.CocosIslands, "166", "CC", "CCK",
            "+61", "West Island", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English);
}