namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Moldova country.</summary>
    public static readonly Country Moldova =
        new(
            CountryNames.Moldova, "498", "MD", "MDA",
            "+373", "Chisinau", "Europe",
            CurrencyHelper.MoldovanLeu,
            LanguageHelper.Romanian);
}