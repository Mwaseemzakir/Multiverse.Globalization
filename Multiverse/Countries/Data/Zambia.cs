using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Zambia =
        new Country(
            CountryNames.Zambia, "894", "ZM", "ZMB",
            "+260", "Lusaka", "Africa",
            CurrencyHelper.ZambianKwacha,
            LanguageHelper.English);
}