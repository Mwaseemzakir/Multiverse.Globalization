using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Estonia =
        new Country(
            CountryNames.Estonia, "233", "EE", "EST",
            "+372", "Tallinn", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Estonian);
}