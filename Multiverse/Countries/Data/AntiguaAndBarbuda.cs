using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country AntiguaAndBarbuda =
        new Country(
            CountryNames.AntiguaAndBarbuda, "028", "AG", "ATG",
            "+1", "Saint John's", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}