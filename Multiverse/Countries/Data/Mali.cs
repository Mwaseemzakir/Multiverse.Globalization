using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Mali =
        new Country(
            CountryNames.Mali, "466", "ML", "MLI",
            "+223", "Bamako", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}