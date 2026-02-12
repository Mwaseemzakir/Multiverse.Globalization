using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaudiArabia =
        new Country(
            CountryNames.SaudiArabia, "682", "SA", "SAU",
            "+966", "Riyadh", "Asia",
            CurrencyHelper.SaudiRiyal,
            LanguageHelper.Arabic);
}