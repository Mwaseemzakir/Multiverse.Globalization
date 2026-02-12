using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country NorfolkIsland =
        new Country(
            CountryNames.NorfolkIsland, "574", "NF", "NFK",
            "+672", "Kingston", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English);
}