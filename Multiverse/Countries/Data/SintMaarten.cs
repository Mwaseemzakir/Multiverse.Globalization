using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SintMaarten =
        new Country(
            CountryNames.SintMaarten, "534", "SX", "SXM",
            "+1", "Philipsburg", "Americas",
            CurrencyHelper.NetherlandsAntilleanGuilder,
            LanguageHelper.Dutch, LanguageHelper.English);
}