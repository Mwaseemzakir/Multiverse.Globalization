using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Latvia =
        new Country(
            CountryNames.Latvia, "428", "LV", "LVA",
            "+371", "Riga", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Latvian);
}