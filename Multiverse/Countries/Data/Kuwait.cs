namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Kuwait country.</summary>
    public static readonly Country Kuwait =
        new(
            CountryNames.Kuwait, "414", "KW", "KWT",
            "+965", "Kuwait City", "Asia",
            CurrencyHelper.KuwaitiDinar,
            LanguageHelper.Arabic);
}