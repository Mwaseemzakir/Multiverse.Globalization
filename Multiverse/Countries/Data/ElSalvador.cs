using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The El Salvador country.</summary>
    public static readonly Country ElSalvador =
        new Country(
            CountryNames.ElSalvador, "222", "SV", "SLV",
            "+503", "San Salvador", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.Spanish);
}