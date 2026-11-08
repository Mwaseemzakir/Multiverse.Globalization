namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Israel country.</summary>
    public static readonly Country Israel =
        new(
            CountryNames.Israel, "376", "IL", "ISR",
            "+972", "Jerusalem", "Asia",
            CurrencyHelper.NewIsraeliSheqel,
            LanguageHelper.Hebrew, LanguageHelper.Arabic);
}