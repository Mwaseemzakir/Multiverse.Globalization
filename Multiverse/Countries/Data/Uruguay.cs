using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Uruguay =
        new Country(
            CountryNames.Uruguay, "858", "UY", "URY",
            "+598", "Montevideo", "Americas",
            CurrencyHelper.PesoUruguayo,
            LanguageHelper.Spanish);
}