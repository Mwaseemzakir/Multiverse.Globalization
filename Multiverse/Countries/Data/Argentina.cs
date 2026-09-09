namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Argentina country.</summary>
    public static readonly Country Argentina =
        new(
            CountryNames.Argentina, "032", "AR", "ARG",
            "+54", "Buenos Aires", "Americas",
            CurrencyHelper.ArgentinePeso,
            LanguageHelper.Spanish);
}