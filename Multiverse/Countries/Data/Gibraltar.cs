using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Gibraltar =
        new Country(
            CountryNames.Gibraltar, "292", "GI", "GIB",
            "+350", "Gibraltar", "Europe",
            CurrencyHelper.GibraltarPound,
            LanguageHelper.English);
}