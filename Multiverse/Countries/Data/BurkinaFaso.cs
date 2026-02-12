using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country BurkinaFaso =
        new Country(
            CountryNames.BurkinaFaso, "854", "BF", "BFA",
            "+226", "Ouagadougou", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}