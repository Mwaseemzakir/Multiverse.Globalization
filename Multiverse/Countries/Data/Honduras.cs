using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Honduras =
        new Country(
            CountryNames.Honduras, "340", "HN", "HND",
            "+504", "Tegucigalpa", "Americas",
            CurrencyHelper.Lempira,
            LanguageHelper.Spanish);
}