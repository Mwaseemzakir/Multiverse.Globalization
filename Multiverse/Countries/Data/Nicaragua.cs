using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Nicaragua country.</summary>
    public static readonly Country Nicaragua =
        new Country(
            CountryNames.Nicaragua, "558", "NI", "NIC",
            "+505", "Managua", "Americas",
            CurrencyHelper.NicaraguanCordoba,
            LanguageHelper.Spanish);
}