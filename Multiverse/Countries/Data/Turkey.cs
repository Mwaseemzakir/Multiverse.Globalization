using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Turkey =
        new Country(
            CountryNames.Turkey, "792", "TR", "TUR",
            "+90", "Ankara", "Asia",
            CurrencyHelper.TurkishLira,
            LanguageHelper.Turkish);
}