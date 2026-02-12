using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Kuwait =
        new Country(
            CountryNames.Kuwait, "414", "KW", "KWT",
            "+965", "Kuwait City", "Asia",
            CurrencyHelper.KuwaitiDinar,
            LanguageHelper.Arabic);
}