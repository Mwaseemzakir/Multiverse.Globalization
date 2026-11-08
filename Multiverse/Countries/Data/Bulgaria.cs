namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Bulgaria country.</summary>
    public static readonly Country Bulgaria =
        new(
            CountryNames.Bulgaria, "100", "BG", "BGR",
            "+359", "Sofia", "Europe",
            CurrencyHelper.BulgarianLev,
            LanguageHelper.Bulgarian);
}