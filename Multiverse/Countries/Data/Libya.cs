namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Libya country.</summary>
    public static readonly Country Libya =
        new(
            CountryNames.Libya, "434", "LY", "LBY",
            "+218", "Tripoli", "Africa",
            CurrencyHelper.LibyanDinar,
            LanguageHelper.Arabic);
}