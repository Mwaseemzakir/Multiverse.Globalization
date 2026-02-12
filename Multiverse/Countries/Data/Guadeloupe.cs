using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Guadeloupe =
        new Country(
            CountryNames.Guadeloupe, "312", "GP", "GLP",
            "+590", "Basse-Terre", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}