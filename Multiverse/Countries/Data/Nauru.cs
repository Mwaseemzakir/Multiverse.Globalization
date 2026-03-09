using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Nauru country.</summary>
    public static readonly Country Nauru =
        new Country(
            CountryNames.Nauru, "520", "NR", "NRU",
            "+674", "Yaren", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.Nauru, LanguageHelper.English);
}