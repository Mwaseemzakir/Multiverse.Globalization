namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Belgium country.</summary>
    public static readonly Country Belgium =
        new(
            CountryNames.Belgium, "056", "BE", "BEL",
            "+32", "Brussels", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Dutch, LanguageHelper.French, LanguageHelper.German);
}