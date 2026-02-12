using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Azerbaijan =
        new Country(
            CountryNames.Azerbaijan, "031", "AZ", "AZE",
            "+994", "Baku", "Asia",
            CurrencyHelper.AzerbaijanManat,
            LanguageHelper.Azerbaijani);
}