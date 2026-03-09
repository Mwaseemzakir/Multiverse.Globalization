using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Saudi Arabia country.</summary>
    public static readonly Country SaudiArabia =
        new Country(
            CountryNames.SaudiArabia, "682", "SA", "SAU",
            "+966", "Riyadh", "Asia",
            CurrencyHelper.SaudiRiyal,
            LanguageHelper.Arabic);
}