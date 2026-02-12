using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Martinique =
        new Country(
            CountryNames.Martinique, "474", "MQ", "MTQ",
            "+596", "Fort-de-France", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}