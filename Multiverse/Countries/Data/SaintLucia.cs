using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaintLucia =
        new Country(
            CountryNames.SaintLucia, "662", "LC", "LCA",
            "+1", "Castries", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}