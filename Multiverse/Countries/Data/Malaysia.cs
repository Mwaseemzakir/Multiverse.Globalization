using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Malaysia country.</summary>
    public static readonly Country Malaysia =
        new Country(
            CountryNames.Malaysia, "458", "MY", "MYS",
            "+60", "Kuala Lumpur", "Asia",
            CurrencyHelper.MalaysianRinggit,
            LanguageHelper.Malay);
}