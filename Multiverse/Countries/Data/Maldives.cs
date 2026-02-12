using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Maldives =
        new Country(
            CountryNames.Maldives, "462", "MV", "MDV",
            "+960", "Male", "Asia",
            CurrencyHelper.MaldivianRufiyaa,
            LanguageHelper.Divehi);
}