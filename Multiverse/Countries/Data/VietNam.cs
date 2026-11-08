namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Viet Nam country.</summary>
    public static readonly Country VietNam =
        new(
            CountryNames.VietNam, "704", "VN", "VNM",
            "+84", "Hanoi", "Asia",
            CurrencyHelper.Dong,
            LanguageHelper.Vietnamese);
}