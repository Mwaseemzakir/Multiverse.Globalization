using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Liberia =
        new Country(
            CountryNames.Liberia, "430", "LR", "LBR",
            "+231", "Monrovia", "Africa",
            CurrencyHelper.LiberianDollar,
            LanguageHelper.English);
}