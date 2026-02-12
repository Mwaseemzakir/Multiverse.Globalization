using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country MicronesiaFederatedStatesOf =
        new Country(
            CountryNames.MicronesiaFederatedStatesOf, "583", "FM", "FSM",
            "+691", "Palikir", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}