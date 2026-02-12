using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Andorra =
        new Country(
            CountryNames.Andorra, "020", "AD", "AND",
            "+376", "Andorra la Vella", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Catalan);
}