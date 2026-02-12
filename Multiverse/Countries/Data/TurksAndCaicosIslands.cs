using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country TurksAndCaicosIslands =
        new Country(
            CountryNames.TurksAndCaicosIslands, "796", "TC", "TCA",
            "+1", "Cockburn Town", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.English);
}