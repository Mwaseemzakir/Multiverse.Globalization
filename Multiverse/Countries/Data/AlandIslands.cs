using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Aland Islands country.</summary>
    public static readonly Country AlandIslands =
        new Country(
            CountryNames.AlandIslands, "248", "AX", "ALA",
            "+358", "Mariehamn", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Swedish);
}