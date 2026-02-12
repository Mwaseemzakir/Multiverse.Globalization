using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaintHelena =
        new Country(
            CountryNames.SaintHelena, "654", "SH", "SHN",
            "+290", "Jamestown", "Africa",
            CurrencyHelper.SaintHelenaPound,
            LanguageHelper.English);
}