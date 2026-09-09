namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The French Guiana country.</summary>
    public static readonly Country FrenchGuiana =
        new(
            CountryNames.FrenchGuiana, "254", "GF", "GUF",
            "+594", "Cayenne", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}