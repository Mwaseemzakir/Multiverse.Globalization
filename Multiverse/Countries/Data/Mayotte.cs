using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Mayotte country.</summary>
    public static readonly Country Mayotte =
        new Country(
            CountryNames.Mayotte, "175", "YT", "MYT",
            "+262", "Mamoudzou", "Africa",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}