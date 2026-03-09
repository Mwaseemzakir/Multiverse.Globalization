using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Brazil country.</summary>
    public static readonly Country Brazil =
        new Country(
            CountryNames.Brazil, "076", "BR", "BRA",
            "+55", "Brasilia", "Americas",
            CurrencyHelper.BrazilianReal,
            LanguageHelper.Portuguese);
}