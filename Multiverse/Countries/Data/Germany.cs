using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Germany country.</summary>
    public static readonly Country Germany =
        new Country(
            CountryNames.Germany, "276", "DE", "DEU",
            "+49", "Berlin", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.German);
}