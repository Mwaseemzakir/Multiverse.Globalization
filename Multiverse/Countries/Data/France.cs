using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country France =
        new Country(
            CountryNames.France, "250", "FR", "FRA",
            "+33", "Paris", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}