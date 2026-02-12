using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country VietNam =
        new Country(
            CountryNames.VietNam, "704", "VN", "VNM",
            "+84", "Hanoi", "Asia",
            CurrencyHelper.Dong,
            LanguageHelper.Vietnamese);
}