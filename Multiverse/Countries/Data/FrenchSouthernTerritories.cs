using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The French Southern Territories country.</summary>
    public static readonly Country FrenchSouthernTerritories =
        new Country(
            CountryNames.FrenchSouthernTerritories, "260", "TF", "ATF",
            "+262", "Port-aux-Francais", "Antarctic",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}