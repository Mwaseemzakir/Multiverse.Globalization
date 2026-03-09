using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Slovenia country.</summary>
    public static readonly Country Slovenia =
        new Country(
            CountryNames.Slovenia, "705", "SI", "SVN",
            "+386", "Ljubljana", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Slovenian);
}