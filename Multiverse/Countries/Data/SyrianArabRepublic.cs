using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Syrian Arab Republic country.</summary>
    public static readonly Country SyrianArabRepublic =
        new Country(
            CountryNames.SyrianArabRepublic, "760", "SY", "SYR",
            "+963", "Damascus", "Asia",
            CurrencyHelper.SyrianPound,
            LanguageHelper.Arabic);
}