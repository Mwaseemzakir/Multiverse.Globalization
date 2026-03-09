using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The New Caledonia country.</summary>
    public static readonly Country NewCaledonia =
        new Country(
            CountryNames.NewCaledonia, "540", "NC", "NCL",
            "+687", "Noumea", "Oceania",
            CurrencyHelper.CfpFranc,
            LanguageHelper.French);
}