namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Hungary country.</summary>
    public static readonly Country Hungary =
        new(
            CountryNames.Hungary, "348", "HU", "HUN",
            "+36", "Budapest", "Europe",
            CurrencyHelper.Forint,
            LanguageHelper.Hungarian);
}