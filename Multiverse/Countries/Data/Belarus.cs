using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Belarus country.</summary>
    public static readonly Country Belarus =
        new Country(
            CountryNames.Belarus, "112", "BY", "BLR",
            "+375", "Minsk", "Europe",
            CurrencyHelper.BelarusianRuble,
            LanguageHelper.Belarusian, LanguageHelper.Russian);
}