namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Poland country.</summary>
    public static readonly Country Poland =
        new(
            CountryNames.Poland, "616", "PL", "POL",
            "+48", "Warsaw", "Europe",
            CurrencyHelper.Zloty,
            LanguageHelper.Polish);
}