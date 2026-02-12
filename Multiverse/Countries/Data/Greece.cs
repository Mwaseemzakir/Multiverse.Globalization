using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Greece =
        new Country(
            CountryNames.Greece, "300", "GR", "GRC",
            "+30", "Athens", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.GreekModern);
}