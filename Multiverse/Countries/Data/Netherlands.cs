namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Netherlands country.</summary>
    public static readonly Country Netherlands =
        new(
            CountryNames.Netherlands, "528", "NL", "NLD",
            "+31", "Amsterdam", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Dutch);
}