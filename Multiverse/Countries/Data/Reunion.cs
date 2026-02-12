using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Reunion =
        new Country(
            CountryNames.Reunion, "638", "RE", "REU",
            "+262", "Saint-Denis", "Africa",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}