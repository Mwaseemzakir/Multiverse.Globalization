namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Greece country.</summary>
    public static readonly Country Greece =
        new(
            CountryNames.Greece, "300", "GR", "GRC",
            "+30", "Athens", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.GreekModern);
}