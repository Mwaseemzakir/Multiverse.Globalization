using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Grenada =
        new Country(
            CountryNames.Grenada, "308", "GD", "GRD",
            "+1", "Saint George's", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}