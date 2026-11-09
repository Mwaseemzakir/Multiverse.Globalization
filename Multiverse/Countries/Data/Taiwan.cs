namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Taiwan country.</summary>
    public static readonly Country Taiwan =
        new(
            CountryNames.Taiwan, "158", "TW", "TWN",
            "+886", "Taipei", "Asia",
            CurrencyHelper.NewTaiwanDollar,
            LanguageHelper.Chinese);
}