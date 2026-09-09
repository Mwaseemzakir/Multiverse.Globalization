namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Reunion country.</summary>
    public static readonly Country Reunion =
        new(
            CountryNames.Reunion, "638", "RE", "REU",
            "+262", "Saint-Denis", "Africa",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}