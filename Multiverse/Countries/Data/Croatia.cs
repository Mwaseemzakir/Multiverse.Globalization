using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Croatia =
        new Country(
            CountryNames.Croatia, "191", "HR", "HRV",
            "+385", "Zagreb", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Croatian);
}