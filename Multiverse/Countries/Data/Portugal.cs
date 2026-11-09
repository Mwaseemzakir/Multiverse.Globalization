namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Portugal country.</summary>
    public static readonly Country Portugal =
        new(
            CountryNames.Portugal, "620", "PT", "PRT",
            "+351", "Lisbon", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Portuguese);
}