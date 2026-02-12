using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Israel =
        new Country(
            CountryNames.Israel, "376", "IL", "ISR",
            "+972", "Jerusalem", "Asia",
            CurrencyHelper.NewIsraeliSheqel,
            LanguageHelper.Hebrew, LanguageHelper.Arabic);
}