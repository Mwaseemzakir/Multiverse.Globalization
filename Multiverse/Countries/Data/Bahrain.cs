using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Bahrain =
        new Country(
            CountryNames.Bahrain, "048", "BH", "BHR",
            "+973", "Manama", "Asia",
            CurrencyHelper.BahrainiDinar,
            LanguageHelper.Arabic);
}