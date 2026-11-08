namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Isle Of Man country.</summary>
    public static readonly Country IsleOfMan =
        new(
            CountryNames.IsleOfMan, "833", "IM", "IMN",
            "+44", "Douglas", "Europe",
            CurrencyHelper.PoundSterling,
            LanguageHelper.English);
}