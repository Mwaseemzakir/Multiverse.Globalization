using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Cambodia =
        new Country(
            CountryNames.Cambodia, "116", "KH", "KHM",
            "+855", "Phnom Penh", "Asia",
            CurrencyHelper.CambodianRiel,
            LanguageHelper.CentralKhmer);
}