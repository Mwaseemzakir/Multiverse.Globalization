namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Malaysia country.</summary>
    public static readonly Country Malaysia =
        new(
            CountryNames.Malaysia, "458", "MY", "MYS",
            "+60", "Kuala Lumpur", "Asia",
            CurrencyHelper.MalaysianRinggit,
            LanguageHelper.Malay);
}