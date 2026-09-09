namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Cape Verde country.</summary>
    public static readonly Country CapeVerde =
        new(
            CountryNames.CapeVerde, "132", "CV", "CPV",
            "+238", "Praia", "Africa",
            CurrencyHelper.CapeVerdeanEscudo,
            LanguageHelper.Portuguese);
}