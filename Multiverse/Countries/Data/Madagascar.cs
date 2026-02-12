using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Madagascar =
        new Country(
            CountryNames.Madagascar, "450", "MG", "MDG",
            "+261", "Antananarivo", "Africa",
            CurrencyHelper.MalagasyAriary,
            LanguageHelper.French, LanguageHelper.Malagasy);
}