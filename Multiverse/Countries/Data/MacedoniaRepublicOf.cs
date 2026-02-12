using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country MacedoniaRepublicOf =
        new Country(
            CountryNames.MacedoniaRepublicOf, "807", "MK", "MKD",
            "+389", "Skopje", "Europe",
            CurrencyHelper.MacedonianDenar,
            LanguageHelper.Macedonian);
}