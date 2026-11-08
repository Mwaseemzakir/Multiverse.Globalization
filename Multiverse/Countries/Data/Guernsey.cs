namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Guernsey country.</summary>
    public static readonly Country Guernsey =
        new(
            CountryNames.Guernsey, "831", "GG", "GGY",
            "+44", "Saint Peter Port", "Europe",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English, LanguageHelper.French);
}