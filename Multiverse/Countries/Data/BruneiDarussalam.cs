using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Brunei Darussalam country.</summary>
    public static readonly Country BruneiDarussalam =
        new Country(
            CountryNames.BruneiDarussalam, "096", "BN", "BRN",
            "+673", "Bandar Seri Begawan", "Asia",
            CurrencyHelper.BruneiDollar,
            LanguageHelper.Malay, LanguageHelper.English);
}