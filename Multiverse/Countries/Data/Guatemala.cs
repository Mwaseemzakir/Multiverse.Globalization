using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Guatemala country.</summary>
    public static readonly Country Guatemala =
        new Country(
            CountryNames.Guatemala, "320", "GT", "GTM",
            "+502", "Guatemala City", "Americas",
            CurrencyHelper.Quetzal,
            LanguageHelper.Spanish);
}