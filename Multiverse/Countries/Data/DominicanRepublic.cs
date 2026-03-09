using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Dominican Republic country.</summary>
    public static readonly Country DominicanRepublic =
        new Country(
            CountryNames.DominicanRepublic, "214", "DO", "DOM",
            "+1", "Santo Domingo", "Americas",
            CurrencyHelper.DominicanPeso,
            LanguageHelper.Spanish);
}