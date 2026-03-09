using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Rwanda country.</summary>
    public static readonly Country Rwanda =
        new Country(
            CountryNames.Rwanda, "646", "RW", "RWA",
            "+250", "Kigali", "Africa",
            CurrencyHelper.RwandanFranc,
            LanguageHelper.Kinyarwanda, LanguageHelper.French, LanguageHelper.English);
}