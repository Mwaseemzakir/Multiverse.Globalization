using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Myanmar =
        new Country(
            CountryNames.Myanmar, "104", "MM", "MMR",
            "+95", "Naypyidaw", "Asia",
            CurrencyHelper.MyanmarKyat,
            LanguageHelper.Burmese);
}