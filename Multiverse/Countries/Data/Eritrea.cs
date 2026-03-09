using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Eritrea country.</summary>
    public static readonly Country Eritrea =
        new Country(
            CountryNames.Eritrea, "232", "ER", "ERI",
            "+291", "Asmara", "Africa",
            CurrencyHelper.EritreanNakfa,
            LanguageHelper.Tigrinya, LanguageHelper.Arabic, LanguageHelper.English);
}