namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Ukraine country.</summary>
    public static readonly Country Ukraine =
        new(
            CountryNames.Ukraine, "804", "UA", "UKR",
            "+380", "Kyiv", "Europe",
            CurrencyHelper.Hryvnia,
            LanguageHelper.Ukrainian);
}