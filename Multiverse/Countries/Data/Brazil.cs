using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Brazil =
        new Country(
            CountryNames.Brazil, "076", "BR", "BRA",
            "+55", "Brasilia", "Americas",
            CurrencyHelper.BrazilianReal,
            LanguageHelper.Portuguese);
}