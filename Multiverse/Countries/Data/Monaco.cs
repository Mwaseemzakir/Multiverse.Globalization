using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Monaco country.</summary>
    public static readonly Country Monaco =
        new Country(
            CountryNames.Monaco, "492", "MC", "MCO",
            "+377", "Monaco", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}