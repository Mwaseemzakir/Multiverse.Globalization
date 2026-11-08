namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Romania country.</summary>
    public static readonly Country Romania =
        new(
            CountryNames.Romania, "642", "RO", "ROU",
            "+40", "Bucharest", "Europe",
            CurrencyHelper.RomanianLeu,
            LanguageHelper.Romanian);
}