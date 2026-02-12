using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Norway =
        new Country(
            CountryNames.Norway, "578", "NO", "NOR",
            "+47", "Oslo", "Europe",
            CurrencyHelper.NorwegianKrone,
            LanguageHelper.Norwegian);
}