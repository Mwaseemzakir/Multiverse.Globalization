using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Netherlands Antilles country.</summary>
    public static readonly Country NetherlandsAntilles =
        new Country(
            CountryNames.NetherlandsAntilles, "530", "AN", "ANT",
            "+599", "Willemstad", "Americas",
            CurrencyHelper.NetherlandsAntilleanGuilder,
            LanguageHelper.Dutch);
}