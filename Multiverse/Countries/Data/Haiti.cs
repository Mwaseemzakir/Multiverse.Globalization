namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Haiti country.</summary>
    public static readonly Country Haiti =
        new(
            CountryNames.Haiti, "332", "HT", "HTI",
            "+509", "Port-au-Prince", "Americas",
            CurrencyHelper.HaitianGourde,
            LanguageHelper.French);
}