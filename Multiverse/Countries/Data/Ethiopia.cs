using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Ethiopia =
        new Country(
            CountryNames.Ethiopia, "231", "ET", "ETH",
            "+251", "Addis Ababa", "Africa",
            CurrencyHelper.EthiopianBirr,
            LanguageHelper.Amharic);
}