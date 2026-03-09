using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Tanzania United Republic Of country.</summary>
    public static readonly Country TanzaniaUnitedRepublicOf =
        new Country(
            CountryNames.TanzaniaUnitedRepublicOf, "834", "TZ", "TZA",
            "+255", "Dodoma", "Africa",
            CurrencyHelper.TanzanianShilling,
            LanguageHelper.Swahili, LanguageHelper.English);
}