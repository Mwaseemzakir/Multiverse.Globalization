using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Bhutan =
        new Country(
            CountryNames.Bhutan, "064", "BT", "BTN",
            "+975", "Thimphu", "Asia",
            CurrencyHelper.BhutaneseNgultrum,
            LanguageHelper.Dzongkha);
}