namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Burkina Faso country.</summary>
    public static readonly Country BurkinaFaso =
        new(
            CountryNames.BurkinaFaso, "854", "BF", "BFA",
            "+226", "Ouagadougou", "Africa",
            CurrencyHelper.CfaFrancBceao,
            LanguageHelper.French);
}