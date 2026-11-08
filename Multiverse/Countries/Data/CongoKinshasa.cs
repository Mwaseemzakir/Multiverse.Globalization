namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Congo Kinshasa country.</summary>
    public static readonly Country CongoKinshasa =
        new(
            CountryNames.CongoKinshasa, "180", "CD", "COD",
            "+243", "Kinshasa", "Africa",
            CurrencyHelper.CongoleseFranc,
            LanguageHelper.French);
}