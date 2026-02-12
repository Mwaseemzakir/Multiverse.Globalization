using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Bangladesh =
        new Country(
            CountryNames.Bangladesh, "050", "BD", "BGD",
            "+880", "Dhaka", "Asia",
            CurrencyHelper.Taka,
            LanguageHelper.Bengali);
}