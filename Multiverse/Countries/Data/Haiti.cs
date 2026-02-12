using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Haiti =
        new Country(
            CountryNames.Haiti, "332", "HT", "HTI",
            "+509", "Port-au-Prince", "Americas",
            CurrencyHelper.HaitianGourde,
            LanguageHelper.French);
}