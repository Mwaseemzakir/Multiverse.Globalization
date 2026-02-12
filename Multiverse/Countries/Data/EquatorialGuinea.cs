using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country EquatorialGuinea =
        new Country(
            CountryNames.EquatorialGuinea, "226", "GQ", "GNQ",
            "+240", "Malabo", "Africa",
            CurrencyHelper.CfaFrancBeac,
            LanguageHelper.Spanish, LanguageHelper.French, LanguageHelper.Portuguese);
}