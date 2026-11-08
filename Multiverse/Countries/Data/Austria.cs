namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Austria country.</summary>
    public static readonly Country Austria =
        new(
            CountryNames.Austria, "040", "AT", "AUT",
            "+43", "Vienna", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.German);
}