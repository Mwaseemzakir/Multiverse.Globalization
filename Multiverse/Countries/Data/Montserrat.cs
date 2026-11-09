namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Montserrat country.</summary>
    public static readonly Country Montserrat =
        new(
            CountryNames.Montserrat, "500", "MS", "MSR",
            "+1", "Plymouth", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}