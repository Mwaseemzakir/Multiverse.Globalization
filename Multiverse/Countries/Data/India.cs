using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country India =
        new Country(
            CountryNames.India, "356", "IN", "IND",
            "+91", "New Delhi", "Asia",
            CurrencyHelper.IndianRupee,
            LanguageHelper.Hindi, LanguageHelper.English);
}