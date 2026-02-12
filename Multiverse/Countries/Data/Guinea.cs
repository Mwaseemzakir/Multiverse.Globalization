using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Guinea =
        new Country(
            CountryNames.Guinea, "324", "GN", "GIN",
            "+224", "Conakry", "Africa",
            CurrencyHelper.GuineanFranc,
            LanguageHelper.French);
}