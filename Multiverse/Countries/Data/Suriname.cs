using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Suriname country.</summary>
    public static readonly Country Suriname =
        new Country(
            CountryNames.Suriname, "740", "SR", "SUR",
            "+597", "Paramaribo", "Americas",
            CurrencyHelper.SurinameseDollar,
            LanguageHelper.Dutch);
}