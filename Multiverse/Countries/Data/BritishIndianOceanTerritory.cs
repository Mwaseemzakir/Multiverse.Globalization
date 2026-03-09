using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The British Indian Ocean Territory country.</summary>
    public static readonly Country BritishIndianOceanTerritory =
        new Country(
            CountryNames.BritishIndianOceanTerritory, "086", "IO", "IOT",
            "+246", "Diego Garcia", "Africa",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}