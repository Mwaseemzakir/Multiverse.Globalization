using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Colombia =
        new Country(
            CountryNames.Colombia, "170", "CO", "COL",
            "+57", "Bogota", "Americas",
            CurrencyHelper.ColombianPeso,
            LanguageHelper.Spanish);
}