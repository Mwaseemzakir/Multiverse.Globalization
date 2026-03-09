using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Cook Islands country.</summary>
    public static readonly Country CookIslands =
        new Country(
            CountryNames.CookIslands, "184", "CK", "COK",
            "+682", "Avarua", "Oceania",
            CurrencyHelper.NewZealandDollar,
            LanguageHelper.English, LanguageHelper.Maori);
}