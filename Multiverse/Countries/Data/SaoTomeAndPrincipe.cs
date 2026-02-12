using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaoTomeAndPrincipe =
        new Country(
            CountryNames.SaoTomeAndPrincipe, "678", "ST", "STP",
            "+239", "Sao Tome", "Africa",
            CurrencyHelper.SaoTomeDobra,
            LanguageHelper.Portuguese);
}