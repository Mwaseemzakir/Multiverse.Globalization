using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Niue =
        new Country(
            CountryNames.Niue, "570", "NU", "NIU",
            "+683", "Alofi", "Oceania",
            CurrencyHelper.NewZealandDollar,
            LanguageHelper.English);
}