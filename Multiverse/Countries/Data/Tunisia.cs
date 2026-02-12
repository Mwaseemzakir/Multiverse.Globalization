using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Tunisia =
        new Country(
            CountryNames.Tunisia, "788", "TN", "TUN",
            "+216", "Tunis", "Africa",
            CurrencyHelper.TunisianDinar,
            LanguageHelper.Arabic);
}