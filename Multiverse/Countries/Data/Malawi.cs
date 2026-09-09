namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Malawi country.</summary>
    public static readonly Country Malawi =
        new(
            CountryNames.Malawi, "454", "MW", "MWI",
            "+265", "Lilongwe", "Africa",
            CurrencyHelper.MalawianKwacha,
            LanguageHelper.English, LanguageHelper.Chichewa);
}