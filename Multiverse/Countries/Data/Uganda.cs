using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Uganda =
        new Country(
            CountryNames.Uganda, "800", "UG", "UGA",
            "+256", "Kampala", "Africa",
            CurrencyHelper.UgandanShilling,
            LanguageHelper.English, LanguageHelper.Swahili);
}