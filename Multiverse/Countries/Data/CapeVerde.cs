using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country CapeVerde =
        new Country(
            CountryNames.CapeVerde, "132", "CV", "CPV",
            "+238", "Praia", "Africa",
            CurrencyHelper.CapeVerdeanEscudo,
            LanguageHelper.Portuguese);
}