namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Andorra country.</summary>
    public static readonly Country Andorra =
        new(
            CountryNames.Andorra, "020", "AD", "AND",
            "+376", "Andorra la Vella", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Catalan);
}