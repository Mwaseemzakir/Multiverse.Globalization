using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Angola =
        new Country(
            CountryNames.Angola, "024", "AO", "AGO",
            "+244", "Luanda", "Africa",
            CurrencyHelper.AngolanKwanza,
            LanguageHelper.Portuguese);
}