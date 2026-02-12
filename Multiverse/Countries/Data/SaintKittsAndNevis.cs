using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaintKittsAndNevis =
        new Country(
            CountryNames.SaintKittsAndNevis, "659", "KN", "KNA",
            "+1", "Basseterre", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}