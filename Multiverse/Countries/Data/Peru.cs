using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Peru =
        new Country(
            CountryNames.Peru, "604", "PE", "PER",
            "+51", "Lima", "Americas",
            CurrencyHelper.Sol,
            LanguageHelper.Spanish);
}