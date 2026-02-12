using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Nigeria =
        new Country(
            CountryNames.Nigeria, "566", "NG", "NGA",
            "+234", "Abuja", "Africa",
            CurrencyHelper.Naira,
            LanguageHelper.English);
}