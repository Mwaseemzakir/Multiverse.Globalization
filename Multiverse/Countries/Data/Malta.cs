using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Malta =
        new Country(
            CountryNames.Malta, "470", "MT", "MLT",
            "+356", "Valletta", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Maltese, LanguageHelper.English);
}