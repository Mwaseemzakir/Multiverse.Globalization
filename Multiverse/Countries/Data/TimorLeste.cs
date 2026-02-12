using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country TimorLeste =
        new Country(
            CountryNames.TimorLeste, "626", "TL", "TLS",
            "+670", "Dili", "Asia",
            CurrencyHelper.UsDollar,
            LanguageHelper.Portuguese, LanguageHelper.Tetum);
}