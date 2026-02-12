using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Albania =
        new Country(
            CountryNames.Albania, "008", "AL", "ALB",
            "+355", "Tirana", "Europe",
            CurrencyHelper.AlbanianLek,
            LanguageHelper.Albanian);
}