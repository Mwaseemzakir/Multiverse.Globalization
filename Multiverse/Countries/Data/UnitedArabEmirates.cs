using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country UnitedArabEmirates =
        new Country(
            CountryNames.UnitedArabEmirates, "784", "AE", "ARE",
            "+971", "Abu Dhabi", "Asia",
            CurrencyHelper.UaeDirham,
            LanguageHelper.Arabic);
}