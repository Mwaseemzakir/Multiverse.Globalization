using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Portugal =
        new Country(
            CountryNames.Portugal, "620", "PT", "PRT",
            "+351", "Lisbon", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Portuguese);
}