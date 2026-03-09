using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Marshall Islands country.</summary>
    public static readonly Country MarshallIslands =
        new Country(
            CountryNames.MarshallIslands, "584", "MH", "MHL",
            "+692", "Majuro", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.Marshallese, LanguageHelper.English);
}