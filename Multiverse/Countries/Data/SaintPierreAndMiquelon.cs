using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Saint Pierre And Miquelon country.</summary>
    public static readonly Country SaintPierreAndMiquelon =
        new Country(
            CountryNames.SaintPierreAndMiquelon, "666", "PM", "SPM",
            "+508", "Saint-Pierre", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}