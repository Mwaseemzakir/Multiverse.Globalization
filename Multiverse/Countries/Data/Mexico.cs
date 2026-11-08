namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Mexico country.</summary>
    public static readonly Country Mexico =
        new(
            CountryNames.Mexico, "484", "MX", "MEX",
            "+52", "Mexico City", "Americas",
            CurrencyHelper.MexicanPeso,
            LanguageHelper.Spanish);
}