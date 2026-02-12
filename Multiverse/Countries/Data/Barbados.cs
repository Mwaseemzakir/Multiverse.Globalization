using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Barbados =
        new Country(
            CountryNames.Barbados, "052", "BB", "BRB",
            "+1", "Bridgetown", "Americas",
            CurrencyHelper.BarbadosDollar,
            LanguageHelper.English);
}