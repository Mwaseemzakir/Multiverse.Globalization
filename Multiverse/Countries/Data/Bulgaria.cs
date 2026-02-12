using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Bulgaria =
        new Country(
            CountryNames.Bulgaria, "100", "BG", "BGR",
            "+359", "Sofia", "Europe",
            CurrencyHelper.BulgarianLev,
            LanguageHelper.Bulgarian);
}