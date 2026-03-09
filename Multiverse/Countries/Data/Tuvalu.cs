using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Tuvalu country.</summary>
    public static readonly Country Tuvalu =
        new Country(
            CountryNames.Tuvalu, "798", "TV", "TUV",
            "+688", "Funafuti", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English);
}