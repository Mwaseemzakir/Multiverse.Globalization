using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Kyrgyzstan =
        new Country(
            CountryNames.Kyrgyzstan, "417", "KG", "KGZ",
            "+996", "Bishkek", "Asia",
            CurrencyHelper.Som,
            LanguageHelper.Kirghiz, LanguageHelper.Russian);
}