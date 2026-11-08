namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Guinea country.</summary>
    public static readonly Country Guinea =
        new(
            CountryNames.Guinea, "324", "GN", "GIN",
            "+224", "Conakry", "Africa",
            CurrencyHelper.GuineanFranc,
            LanguageHelper.French);
}