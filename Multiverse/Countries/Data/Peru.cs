namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Peru country.</summary>
    public static readonly Country Peru =
        new(
            CountryNames.Peru, "604", "PE", "PER",
            "+51", "Lima", "Americas",
            CurrencyHelper.Sol,
            LanguageHelper.Spanish);
}