using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country VenezuelaBolivarianRepublic =
        new Country(
            CountryNames.VenezuelaBolivarianRepublic, "862", "VE", "VEN",
            "+58", "Caracas", "Americas",
            CurrencyHelper.VenezuelanBolivar,
            LanguageHelper.Spanish);
}