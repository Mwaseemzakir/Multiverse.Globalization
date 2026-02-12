using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Denmark =
        new Country(
            CountryNames.Denmark, "208", "DK", "DNK",
            "+45", "Copenhagen", "Europe",
            CurrencyHelper.DanishKrone,
            LanguageHelper.Danish);
}