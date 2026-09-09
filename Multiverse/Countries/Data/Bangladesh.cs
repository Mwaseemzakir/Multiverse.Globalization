namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Bangladesh country.</summary>
    public static readonly Country Bangladesh =
        new(
            CountryNames.Bangladesh, "050", "BD", "BGD",
            "+880", "Dhaka", "Asia",
            CurrencyHelper.Taka,
            LanguageHelper.Bengali);
}