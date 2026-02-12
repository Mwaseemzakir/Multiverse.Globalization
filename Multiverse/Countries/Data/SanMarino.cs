using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SanMarino =
        new Country(
            CountryNames.SanMarino, "674", "SM", "SMR",
            "+378", "San Marino", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Italian);
}