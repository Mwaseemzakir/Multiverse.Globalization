using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Northern Mariana Islands country.</summary>
    public static readonly Country NorthernMarianaIslands =
        new Country(
            CountryNames.NorthernMarianaIslands, "580", "MP", "MNP",
            "+1", "Saipan", "Oceania",
            CurrencyHelper.UsDollar,
            LanguageHelper.English, LanguageHelper.Chamorro);
}