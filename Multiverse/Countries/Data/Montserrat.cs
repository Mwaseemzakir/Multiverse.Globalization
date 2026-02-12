using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Montserrat =
        new Country(
            CountryNames.Montserrat, "500", "MS", "MSR",
            "+1", "Plymouth", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}