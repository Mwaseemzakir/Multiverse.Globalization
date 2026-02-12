using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Seychelles =
        new Country(
            CountryNames.Seychelles, "690", "SC", "SYC",
            "+248", "Victoria", "Africa",
            CurrencyHelper.SeychelloisRupee,
            LanguageHelper.French, LanguageHelper.English);
}