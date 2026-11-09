namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Indonesia country.</summary>
    public static readonly Country Indonesia =
        new(
            CountryNames.Indonesia, "360", "ID", "IDN",
            "+62", "Jakarta", "Asia",
            CurrencyHelper.Rupiah,
            LanguageHelper.Indonesian);
}