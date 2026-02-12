using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Ukraine =
        new Country(
            CountryNames.Ukraine, "804", "UA", "UKR",
            "+380", "Kyiv", "Europe",
            CurrencyHelper.Hryvnia,
            LanguageHelper.Ukrainian);
}