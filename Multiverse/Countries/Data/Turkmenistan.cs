using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Turkmenistan =
        new Country(
            CountryNames.Turkmenistan, "795", "TM", "TKM",
            "+993", "Ashgabat", "Asia",
            CurrencyHelper.TurkmenistanNewManat,
            LanguageHelper.Turkmen);
}