using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Italy =
        new Country(
            CountryNames.Italy, "380", "IT", "ITA",
            "+39", "Rome", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Italian);
}