using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Comoros country.</summary>
    public static readonly Country Comoros =
        new Country(
            CountryNames.Comoros, "174", "KM", "COM",
            "+269", "Moroni", "Africa",
            CurrencyHelper.ComorianFranc,
            LanguageHelper.Arabic, LanguageHelper.French);
}