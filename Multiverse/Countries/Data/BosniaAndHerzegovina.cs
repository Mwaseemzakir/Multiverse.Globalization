using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country BosniaAndHerzegovina =
        new Country(
            CountryNames.BosniaAndHerzegovina, "070", "BA", "BIH",
            "+387", "Sarajevo", "Europe",
            CurrencyHelper.BosniaConvertibleMark,
            LanguageHelper.Bosnian, LanguageHelper.Croatian, LanguageHelper.Serbian);
}