using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Anguilla =
        new Country(
            CountryNames.Anguilla, "660", "AI", "AIA",
            "+1", "The Valley", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}