namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Iran country.</summary>
    public static readonly Country Iran =
        new(
            CountryNames.Iran, "364", "IR", "IRN",
            "+98", "Tehran", "Asia",
            CurrencyHelper.IranianRial,
            LanguageHelper.Persian);
}