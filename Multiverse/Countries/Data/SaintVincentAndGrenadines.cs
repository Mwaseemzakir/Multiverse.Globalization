using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Saint Vincent And Grenadines country.</summary>
    public static readonly Country SaintVincentAndGrenadines =
        new Country(
            CountryNames.SaintVincentAndGrenadines, "670", "VC", "VCT",
            "+1", "Kingstown", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}