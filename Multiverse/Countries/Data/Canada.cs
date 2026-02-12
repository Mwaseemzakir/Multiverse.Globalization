using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Canada =
        new Country(
            CountryNames.Canada, "124", "CA", "CAN",
            "+1", "Ottawa", "Americas",
            CurrencyHelper.CanadianDollar,
            LanguageHelper.English, LanguageHelper.French);
}