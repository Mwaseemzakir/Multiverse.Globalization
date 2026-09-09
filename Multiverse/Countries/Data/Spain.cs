namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Spain country.</summary>
    public static readonly Country Spain =
        new(
            CountryNames.Spain, "724", "ES", "ESP",
            "+34", "Madrid", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Spanish);
}