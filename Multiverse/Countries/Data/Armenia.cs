namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Armenia country.</summary>
    public static readonly Country Armenia =
        new(
            CountryNames.Armenia, "051", "AM", "ARM",
            "+374", "Yerevan", "Asia",
            CurrencyHelper.ArmenianDram,
            LanguageHelper.Armenian);
}