using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Sri Lanka country.</summary>
    public static readonly Country SriLanka =
        new Country(
            CountryNames.SriLanka, "144", "LK", "LKA",
            "+94", "Sri Jayawardenepura Kotte", "Asia",
            CurrencyHelper.SriLankaRupee,
            LanguageHelper.Sinhala, LanguageHelper.Tamil);
}