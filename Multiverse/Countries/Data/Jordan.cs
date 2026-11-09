namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Jordan country.</summary>
    public static readonly Country Jordan =
        new(
            CountryNames.Jordan, "400", "JO", "JOR",
            "+962", "Amman", "Asia",
            CurrencyHelper.JordanianDinar,
            LanguageHelper.Arabic);
}