using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Iceland =
        new Country(
            CountryNames.Iceland, "352", "IS", "ISL",
            "+354", "Reykjavik", "Europe",
            CurrencyHelper.IcelandKrona,
            LanguageHelper.Icelandic);
}