using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SouthSudan =
        new Country(
            CountryNames.SouthSudan, "728", "SS", "SSD",
            "+211", "Juba", "Africa",
            CurrencyHelper.SouthSudanesePound,
            LanguageHelper.English);
}