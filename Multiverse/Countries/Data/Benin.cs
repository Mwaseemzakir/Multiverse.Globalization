using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Benin country.</summary>
    public static readonly Country Benin =
        new Country(
            CountryNames.Benin, "204", "BJ", "BEN",
            "+229", "Porto-Novo", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}