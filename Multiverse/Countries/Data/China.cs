using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The China country.</summary>
    public static readonly Country China =
        new Country(
            CountryNames.China, "156", "CN", "CHN",
            "+86", "Beijing", "Asia",
            CurrencyHelper.YuanRenminbi,
            LanguageHelper.Chinese);
}