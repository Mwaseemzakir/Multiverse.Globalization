using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Luxembourg =
        new Country(
            CountryNames.Luxembourg, "442", "LU", "LUX",
            "+352", "Luxembourg", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Luxembourgish, LanguageHelper.French, LanguageHelper.German);
}