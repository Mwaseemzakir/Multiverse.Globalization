using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Curacao country.</summary>
    public static readonly Country Curacao =
        new Country(
            CountryNames.Curacao, "531", "CW", "CUW",
            "+599", "Willemstad", "Americas",
            CurrencyHelper.NetherlandsAntilleanGuilder,
            LanguageHelper.Dutch);
}