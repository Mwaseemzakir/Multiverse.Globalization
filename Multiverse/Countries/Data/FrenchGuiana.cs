using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country FrenchGuiana =
        new Country(
            CountryNames.FrenchGuiana, "254", "GF", "GUF",
            "+594", "Cayenne", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}