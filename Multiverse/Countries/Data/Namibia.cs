using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Namibia =
        new Country(
            CountryNames.Namibia, "516", "NA", "NAM",
            "+264", "Windhoek", "Africa",
            CurrencyHelper.NamibianDollar,
            LanguageHelper.English);
}