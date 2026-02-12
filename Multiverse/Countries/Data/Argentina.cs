using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Argentina =
        new Country(
            CountryNames.Argentina, "032", "AR", "ARG",
            "+54", "Buenos Aires", "Americas",
            CurrencyHelper.ArgentinePeso,
            LanguageHelper.Spanish);
}