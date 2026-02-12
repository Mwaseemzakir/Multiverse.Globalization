using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country SaintMartinFrenchPart =
        new Country(
            CountryNames.SaintMartinFrenchPart, "663", "MF", "MAF",
            "+590", "Marigot", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}