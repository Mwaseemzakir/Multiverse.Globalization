using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Moldova =
        new Country(
            CountryNames.Moldova, "498", "MD", "MDA",
            "+373", "Chisinau", "Europe",
            CurrencyHelper.MoldovanLeu,
            LanguageHelper.Romanian);
}