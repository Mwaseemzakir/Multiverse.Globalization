using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Faroe Islands country.</summary>
    public static readonly Country FaroeIslands =
        new Country(
            CountryNames.FaroeIslands, "234", "FO", "FRO",
            "+298", "Torshavn", "Europe",
            CurrencyHelper.DanishKrone,
            LanguageHelper.Danish);
}