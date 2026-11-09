namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Greenland country.</summary>
    public static readonly Country Greenland =
        new(
            CountryNames.Greenland, "304", "GL", "GRL",
            "+299", "Nuuk", "Americas",
            CurrencyHelper.DanishKrone,
            LanguageHelper.Danish);
}