using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Afghanistan =
        new Country(
            CountryNames.Afghanistan, "004", "AF", "AFG",
            "+93", "Kabul", "Asia",
            CurrencyHelper.Afghani,
            LanguageHelper.Pushto, LanguageHelper.Persian);
}