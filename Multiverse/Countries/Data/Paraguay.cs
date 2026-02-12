using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Paraguay =
        new Country(
            CountryNames.Paraguay, "600", "PY", "PRY",
            "+595", "Asuncion", "Americas",
            CurrencyHelper.Guarani,
            LanguageHelper.Spanish, LanguageHelper.Guarani);
}