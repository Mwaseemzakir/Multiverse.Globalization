using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Indonesia =
        new Country(
            CountryNames.Indonesia, "360", "ID", "IDN",
            "+62", "Jakarta", "Asia",
            CurrencyHelper.Rupiah,
            LanguageHelper.Indonesian);
}