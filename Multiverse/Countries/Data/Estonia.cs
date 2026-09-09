namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Estonia country.</summary>
    public static readonly Country Estonia =
        new(
            CountryNames.Estonia, "233", "EE", "EST",
            "+372", "Tallinn", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Estonian);
}