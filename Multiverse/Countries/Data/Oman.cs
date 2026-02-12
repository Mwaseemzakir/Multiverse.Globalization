using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Oman =
        new Country(
            CountryNames.Oman, "512", "OM", "OMN",
            "+968", "Muscat", "Asia",
            CurrencyHelper.RialOmani,
            LanguageHelper.Arabic);
}