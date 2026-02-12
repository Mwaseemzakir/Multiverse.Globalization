using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Armenia =
        new Country(
            CountryNames.Armenia, "051", "AM", "ARM",
            "+374", "Yerevan", "Asia",
            CurrencyHelper.ArmenianDram,
            LanguageHelper.Armenian);
}