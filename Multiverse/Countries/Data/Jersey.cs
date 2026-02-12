using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Jersey =
        new Country(
            CountryNames.Jersey, "832", "JE", "JEY",
            "+44", "Saint Helier", "Europe",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English, LanguageHelper.French);
}