namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Luxembourg country.</summary>
    public static readonly Country Luxembourg =
        new(
            CountryNames.Luxembourg, "442", "LU", "LUX",
            "+352", "Luxembourg", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Luxembourgish, LanguageHelper.French, LanguageHelper.German);
}