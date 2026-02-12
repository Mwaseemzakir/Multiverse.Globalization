using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Ecuador =
        new Country(
            CountryNames.Ecuador, "218", "EC", "ECU",
            "+593", "Quito", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.Spanish);
}