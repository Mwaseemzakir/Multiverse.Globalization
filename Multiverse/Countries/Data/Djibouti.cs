using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Djibouti =
        new Country(
            CountryNames.Djibouti, "262", "DJ", "DJI",
            "+253", "Djibouti", "Africa",
            CurrencyHelper.DjiboutianFranc,
            LanguageHelper.French, LanguageHelper.Arabic);
}