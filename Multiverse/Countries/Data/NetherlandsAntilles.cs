using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country NetherlandsAntilles =
        new Country(
            CountryNames.NetherlandsAntilles, "530", "AN", "ANT",
            "+599", "Willemstad", "Americas",
            CurrencyHelper.NetherlandsAntilleanGuilder,
            LanguageHelper.Dutch);
}