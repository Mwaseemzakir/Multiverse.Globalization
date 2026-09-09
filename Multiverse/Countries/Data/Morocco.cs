namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Morocco country.</summary>
    public static readonly Country Morocco =
        new(
            CountryNames.Morocco, "504", "MA", "MAR",
            "+212", "Rabat", "Africa",
            CurrencyHelper.MoroccanDirham,
            LanguageHelper.Arabic);
}