namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Sint Maarten country.</summary>
    public static readonly Country SintMaarten =
        new(
            CountryNames.SintMaarten, "534", "SX", "SXM",
            "+1", "Philipsburg", "Americas",
            CurrencyHelper.NetherlandsAntilleanGuilder,
            LanguageHelper.Dutch, LanguageHelper.English);
}