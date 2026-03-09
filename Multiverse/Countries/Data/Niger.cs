using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Niger country.</summary>
    public static readonly Country Niger =
        new Country(
            CountryNames.Niger, "562", "NE", "NER",
            "+227", "Niamey", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}