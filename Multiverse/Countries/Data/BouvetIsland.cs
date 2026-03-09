using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Bouvet Island country.</summary>
    public static readonly Country BouvetIsland =
        new Country(
            CountryNames.BouvetIsland, "074", "BV", "BVT",
            "+47", "", "Antarctic",
            CurrencyHelper.NorwegianKrone);
}