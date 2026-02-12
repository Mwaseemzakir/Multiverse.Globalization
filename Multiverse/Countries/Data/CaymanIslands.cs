using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CaymanIslands =
        new Country(
            CountryNames.CaymanIslands, "136", "KY", "CYM",
            "+1", "George Town", "Americas",
            CurrencyHelper.CaymanIslandsDollar,
            LanguageHelper.English);
}