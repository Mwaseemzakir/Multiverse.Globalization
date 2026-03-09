using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Finland country.</summary>
    public static readonly Country Finland =
        new Country(
            CountryNames.Finland, "246", "FI", "FIN",
            "+358", "Helsinki", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Finnish, LanguageHelper.Swedish);
}