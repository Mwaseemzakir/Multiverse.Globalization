namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Oman country.</summary>
    public static readonly Country Oman =
        new(
            CountryNames.Oman, "512", "OM", "OMN",
            "+968", "Muscat", "Asia",
            CurrencyHelper.RialOmani,
            LanguageHelper.Arabic);
}