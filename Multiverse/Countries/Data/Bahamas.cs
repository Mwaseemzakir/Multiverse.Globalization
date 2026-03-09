using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Bahamas country.</summary>
    public static readonly Country Bahamas =
        new Country(
            CountryNames.Bahamas, "044", "BS", "BHS",
            "+1", "Nassau", "Americas",
            CurrencyHelper.BahamianDollar,
            LanguageHelper.English);
}