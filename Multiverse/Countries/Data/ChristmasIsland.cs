using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country ChristmasIsland =
        new Country(
            CountryNames.ChristmasIsland, "162", "CX", "CXR",
            "+61", "Flying Fish Cove", "Oceania",
            CurrencyHelper.AustralianDollar,
            LanguageHelper.English);
}