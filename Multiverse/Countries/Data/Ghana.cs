using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Ghana country.</summary>
    public static readonly Country Ghana =
        new Country(
            CountryNames.Ghana, "288", "GH", "GHA",
            "+233", "Accra", "Africa",
            CurrencyHelper.GhanaCedi,
            LanguageHelper.English);
}