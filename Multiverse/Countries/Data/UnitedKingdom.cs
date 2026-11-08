namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The United Kingdom country.</summary>
    public static readonly Country UnitedKingdom =
        new(
            CountryNames.UnitedKingdom, "826", "GB", "GBR",
            "+44", "London", "Europe",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English);
}