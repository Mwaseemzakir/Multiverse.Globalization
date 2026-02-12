using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Australia =
        new Country(
            CountryNames.Australia, "036", "AU", "AUS",
            "+61", "Canberra", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English);
}