using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Palau =
        new Country(
            CountryNames.Palau, "585", "PW", "PLW",
            "+680", "Ngerulmud", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.Palauan, LanguageHelper.English);
}