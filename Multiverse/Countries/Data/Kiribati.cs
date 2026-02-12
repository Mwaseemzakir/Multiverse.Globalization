using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Kiribati =
        new Country(
            CountryNames.Kiribati, "296", "KI", "KIR",
            "+686", "South Tarawa", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English, LanguageHelper.Gilbertese);
}