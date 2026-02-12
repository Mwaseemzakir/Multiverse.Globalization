using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Somalia =
        new Country(
            CountryNames.Somalia, "706", "SO", "SOM",
            "+252", "Mogadishu", "Africa",
            CurrencyHelper.SomaliShilling,
            LanguageHelper.Somali, LanguageHelper.Arabic);
}