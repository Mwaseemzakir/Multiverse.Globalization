using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The United States Of America country.</summary>
    public static readonly Country UnitedStatesOfAmerica =
        new Country(
            CountryNames.UnitedStatesOfAmerica, "840", "US", "USA",
            "+1", "Washington, D.C.", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}