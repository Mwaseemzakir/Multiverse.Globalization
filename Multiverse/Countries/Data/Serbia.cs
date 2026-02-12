using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Serbia =
        new Country(
            CountryNames.Serbia, "688", "RS", "SRB",
            "+381", "Belgrade", "Europe",
            CurrencyHelper.SerbianDinar,
            LanguageHelper.Serbian);
}