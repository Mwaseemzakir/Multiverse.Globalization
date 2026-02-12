using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country VirginIslandsUS =
        new Country(
            CountryNames.VirginIslandsUS, "850", "VI", "VIR",
            "+1", "Charlotte Amalie", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}