using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Papua New Guinea country.</summary>
    public static readonly Country PapuaNewGuinea =
        new Country(
            CountryNames.PapuaNewGuinea, "598", "PG", "PNG",
            "+675", "Port Moresby", "Oceania",
            CurrencyHelper.PapuaNewGuineanKina,
            LanguageHelper.English);
}