namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Grenada country.</summary>
    public static readonly Country Grenada =
        new(
            CountryNames.Grenada, "308", "GD", "GRD",
            "+1", "Saint George's", "Americas",
            CurrencyHelper.EastCaribbeanDollar,
            LanguageHelper.English);
}