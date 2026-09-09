namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Western Sahara country.</summary>
    public static readonly Country WesternSahara =
        new(
            CountryNames.WesternSahara, "732", "EH", "ESH",
            "+212", "El Aaiun", "Africa",
            CurrencyHelper.MoroccanDirham,
            LanguageHelper.Arabic);
}