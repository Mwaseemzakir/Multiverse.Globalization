using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The New Zealand country.</summary>
    public static readonly Country NewZealand =
        new Country(
            CountryNames.NewZealand, "554", "NZ", "NZL",
            "+64", "Wellington", "Oceania",
            CurrencyHelper.NewZealandDollar,
            LanguageHelper.English, LanguageHelper.Maori);
}