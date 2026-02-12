using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Lesotho =
        new Country(
            CountryNames.Lesotho, "426", "LS", "LSO",
            "+266", "Maseru", "Africa",
            CurrencyHelper.LesothoLoti,
            LanguageHelper.English, LanguageHelper.SothoSouthern);
}