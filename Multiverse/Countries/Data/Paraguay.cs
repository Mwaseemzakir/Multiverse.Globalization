namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Paraguay country.</summary>
    public static readonly Country Paraguay =
        new(
            CountryNames.Paraguay, "600", "PY", "PRY",
            "+595", "Asuncion", "Americas",
            CurrencyHelper.Guarani,
            LanguageHelper.Spanish, LanguageHelper.Guarani);
}