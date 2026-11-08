namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Ireland country.</summary>
    public static readonly Country Ireland =
        new(
            CountryNames.Ireland, "372", "IE", "IRL",
            "+353", "Dublin", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Irish, LanguageHelper.English);
}