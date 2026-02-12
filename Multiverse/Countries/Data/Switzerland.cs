using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Switzerland =
        new Country(
            CountryNames.Switzerland, "756", "CH", "CHE",
            "+41", "Bern", "Europe",
            CurrencyHelper.SwissFranc,
            LanguageHelper.German, LanguageHelper.French, LanguageHelper.Italian);
}