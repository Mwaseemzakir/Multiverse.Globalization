namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Vanuatu country.</summary>
    public static readonly Country Vanuatu =
        new(
            CountryNames.Vanuatu, "548", "VU", "VUT",
            "+678", "Port Vila", "Oceania",
            CurrencyHelper.VanuatuVatu,
            LanguageHelper.Bislama, LanguageHelper.English, LanguageHelper.French);
}