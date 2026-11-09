namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Korea North country.</summary>
    public static readonly Country KoreaNorth =
        new(
            CountryNames.KoreaNorth, "408", "KP", "PRK",
            "+850", "Pyongyang", "Asia",
            CurrencyHelper.NorthKoreanWon,
            LanguageHelper.Korean);
}