using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country TrinidadAndTobago =
        new Country(
            CountryNames.TrinidadAndTobago, "780", "TT", "TTO",
            "+1", "Port of Spain", "Americas",
            CurrencyHelper.TrinidadDollar,
            LanguageHelper.English);
}