using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Mozambique =
        new Country(
            CountryNames.Mozambique, "508", "MZ", "MOZ",
            "+258", "Maputo", "Africa",
            CurrencyHelper.MozambicanMetical,
            LanguageHelper.Portuguese);
}