namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Liberia country.</summary>
    public static readonly Country Liberia =
        new(
            CountryNames.Liberia, "430", "LR", "LBR",
            "+231", "Monrovia", "Africa",
            CurrencyHelper.LiberianDollar,
            LanguageHelper.English);
}