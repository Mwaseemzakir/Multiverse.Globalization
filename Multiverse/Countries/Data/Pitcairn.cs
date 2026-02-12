using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Pitcairn =
        new Country(
            CountryNames.Pitcairn, "612", "PN", "PCN",
            "+870", "Adamstown", "Oceania",
            CurrencyHelper.NewZealandDollar,
            LanguageHelper.English);
}