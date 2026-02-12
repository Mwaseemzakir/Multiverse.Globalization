using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Spain =
        new Country(
            CountryNames.Spain, "724", "ES", "ESP",
            "+34", "Madrid", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Spanish);
}