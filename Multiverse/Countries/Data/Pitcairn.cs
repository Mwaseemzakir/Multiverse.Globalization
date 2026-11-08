namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Pitcairn country.</summary>
    public static readonly Country Pitcairn =
        new(
            CountryNames.Pitcairn, "612", "PN", "PCN",
            "+870", "Adamstown", "Oceania",
            CurrencyHelper.NewZealandDollar,
            LanguageHelper.English);
}