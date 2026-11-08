namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Zambia country.</summary>
    public static readonly Country Zambia =
        new(
            CountryNames.Zambia, "894", "ZM", "ZMB",
            "+260", "Lusaka", "Africa",
            CurrencyHelper.ZambianKwacha,
            LanguageHelper.English);
}