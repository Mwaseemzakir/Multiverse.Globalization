namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Mozambique country.</summary>
    public static readonly Country Mozambique =
        new(
            CountryNames.Mozambique, "508", "MZ", "MOZ",
            "+258", "Maputo", "Africa",
            CurrencyHelper.MozambicanMetical,
            LanguageHelper.Portuguese);
}