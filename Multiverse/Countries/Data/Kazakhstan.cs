using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Kazakhstan country.</summary>
    public static readonly Country Kazakhstan =
        new Country(
            CountryNames.Kazakhstan, "398", "KZ", "KAZ",
            "+7", "Astana", "Asia",
            CurrencyHelper.Tenge,
            LanguageHelper.Kazakh, LanguageHelper.Russian);
}