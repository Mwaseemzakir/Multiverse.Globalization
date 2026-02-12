using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country IsleOfMan =
        new Country(
            CountryNames.IsleOfMan, "833", "IM", "IMN",
            "+44", "Douglas", "Europe",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English);
}