using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Romania =
        new Country(
            CountryNames.Romania, "642", "RO", "ROU",
            "+40", "Bucharest", "Europe",
            CurrencyHelper.RomanianLeu,
            LanguageHelper.Romanian);
}