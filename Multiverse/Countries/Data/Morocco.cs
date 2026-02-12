using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Morocco =
        new Country(
            CountryNames.Morocco, "504", "MA", "MAR",
            "+212", "Rabat", "Africa",
            CurrencyHelper.MoroccanDirham,
            LanguageHelper.Arabic);
}