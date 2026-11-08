namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Macao country.</summary>
    public static readonly Country Macao =
        new(
            CountryNames.Macao, "446", "MO", "MAC",
            "+853", "Macao", "Asia",
            CurrencyHelper.MacanesePataca,
            LanguageHelper.Chinese, LanguageHelper.Portuguese);
}