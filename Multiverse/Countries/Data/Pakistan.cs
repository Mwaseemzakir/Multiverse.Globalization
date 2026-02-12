using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Pakistan =
        new Country(
            CountryNames.Pakistan, "586", "PK", "PAK",
            "+92", "Islamabad", "Asia",
            CurrencyHelper.PakistanRupee,
            LanguageHelper.Urdu, LanguageHelper.English);
}