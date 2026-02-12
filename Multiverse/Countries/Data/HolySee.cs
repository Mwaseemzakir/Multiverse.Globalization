using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country HolySee =
        new Country(
            CountryNames.HolySee, "336", "VA", "VAT",
            "+379", "Vatican City", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Italian, LanguageHelper.Latin);
}