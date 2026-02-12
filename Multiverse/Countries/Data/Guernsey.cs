using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Guernsey =
        new Country(
            CountryNames.Guernsey, "831", "GG", "GGY",
            "+44", "Saint Peter Port", "Europe",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English, LanguageHelper.French);
}