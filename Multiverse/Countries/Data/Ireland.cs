using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Ireland =
        new Country(
            CountryNames.Ireland, "372", "IE", "IRL",
            "+353", "Dublin", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Irish, LanguageHelper.English);
}