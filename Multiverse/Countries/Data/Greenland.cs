using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Greenland =
        new Country(
            CountryNames.Greenland, "304", "GL", "GRL",
            "+299", "Nuuk", "Americas",
            CurrencyHelper.DanishKrone,
            LanguageHelper.Danish);
}