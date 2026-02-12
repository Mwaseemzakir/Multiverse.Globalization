using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Guyana =
        new Country(
            CountryNames.Guyana, "328", "GY", "GUY",
            "+592", "Georgetown", "Americas",
            CurrencyHelper.GuyaneseDollar,
            LanguageHelper.English);
}