using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Vanuatu =
        new Country(
            CountryNames.Vanuatu, "548", "VU", "VUT",
            "+678", "Port Vila", "Oceania",
            CurrencyHelper.VanuatuVatu,
            LanguageHelper.Bislama, LanguageHelper.English, LanguageHelper.French);
}