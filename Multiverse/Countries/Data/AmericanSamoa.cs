using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country AmericanSamoa =
        new Country(
            CountryNames.AmericanSamoa, "016", "AS", "ASM",
            "+1", "Pago Pago", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.English, LanguageHelper.Samoan);
}