using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Qatar =
        new Country(
            CountryNames.Qatar, "634", "QA", "QAT",
            "+974", "Doha", "Asia",
            CurrencyHelper.QatariRial,
            LanguageHelper.Arabic);
}