using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Western Sahara country.</summary>
    public static readonly Country WesternSahara =
        new Country(
            CountryNames.WesternSahara, "732", "EH", "ESH",
            "+212", "El Aaiun", "Africa",
            CurrencyHelper.MoroccanDirham,
            LanguageHelper.Arabic);
}