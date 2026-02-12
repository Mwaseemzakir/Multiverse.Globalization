using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Palestine =
        new Country(
            CountryNames.Palestine, "275", "PS", "PSE",
            "+970", "Ramallah", "Asia",
            CurrencyHelper.NewIsraeliSheqel,
            LanguageHelper.Arabic);
}