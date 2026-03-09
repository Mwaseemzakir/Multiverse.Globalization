using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Cuba country.</summary>
    public static readonly Country Cuba =
        new Country(
            CountryNames.Cuba, "192", "CU", "CUB",
            "+53", "Havana", "Americas",
            CurrencyHelper.CubanPeso,
            LanguageHelper.Spanish);
}