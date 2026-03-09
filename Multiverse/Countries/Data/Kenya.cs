using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Kenya country.</summary>
    public static readonly Country Kenya =
        new Country(
            CountryNames.Kenya, "404", "KE", "KEN",
            "+254", "Nairobi", "Africa",
            CurrencyHelper.KenyanShilling,
            LanguageHelper.English, LanguageHelper.Swahili);
}