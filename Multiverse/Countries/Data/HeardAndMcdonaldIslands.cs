using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country HeardAndMcdonaldIslands =
        new Country(
            CountryNames.HeardAndMcdonaldIslands, "334", "HM", "HMD",
            "+672", "", "Antarctic",
            CurrencyHelper.AustralianDollar);
}