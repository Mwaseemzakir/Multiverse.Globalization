using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Netherlands =
        new Country(
            CountryNames.Netherlands, "528", "NL", "NLD",
            "+31", "Amsterdam", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Dutch);
}