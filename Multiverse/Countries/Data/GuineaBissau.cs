using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country GuineaBissau =
        new Country(
            CountryNames.GuineaBissau, "624", "GW", "GNB",
            "+245", "Bissau", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.Portuguese);
}