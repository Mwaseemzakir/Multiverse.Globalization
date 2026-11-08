namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Namibia country.</summary>
    public static readonly Country Namibia =
        new(
            CountryNames.Namibia, "516", "NA", "NAM",
            "+264", "Windhoek", "Africa",
            CurrencyHelper.NamibianDollar,
            LanguageHelper.English);
}