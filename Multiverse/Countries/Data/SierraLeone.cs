using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SierraLeone =
        new Country(
            CountryNames.SierraLeone, "694", "SL", "SLE",
            "+232", "Freetown", "Africa",
            CurrencyHelper.SierraLeoneanLeone,
            LanguageHelper.English);
}