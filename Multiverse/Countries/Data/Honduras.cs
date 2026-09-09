namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Honduras country.</summary>
    public static readonly Country Honduras =
        new(
            CountryNames.Honduras, "340", "HN", "HND",
            "+504", "Tegucigalpa", "Americas",
            CurrencyHelper.Lempira,
            LanguageHelper.Spanish);
}