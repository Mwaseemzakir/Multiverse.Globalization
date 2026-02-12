using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Panama =
        new Country(
            CountryNames.Panama, "591", "PA", "PAN",
            "+507", "Panama City", "Americas",
            CurrencyHelper.Balboa,
            LanguageHelper.Spanish);
}