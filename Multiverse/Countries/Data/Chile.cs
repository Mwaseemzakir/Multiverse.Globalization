using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Chile =
        new Country(
            CountryNames.Chile, "152", "CL", "CHL",
            "+56", "Santiago", "Americas",
            CurrencyHelper.ChileanPeso,
            LanguageHelper.Spanish);
}