namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Italy country.</summary>
    public static readonly Country Italy =
        new(
            CountryNames.Italy, "380", "IT", "ITA",
            "+39", "Rome", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Italian);
}