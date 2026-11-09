namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Myanmar country.</summary>
    public static readonly Country Myanmar =
        new(
            CountryNames.Myanmar, "104", "MM", "MMR",
            "+95", "Naypyidaw", "Asia",
            CurrencyHelper.MyanmarKyat,
            LanguageHelper.Burmese);
}