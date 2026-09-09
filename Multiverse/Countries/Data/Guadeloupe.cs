namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Guadeloupe country.</summary>
    public static readonly Country Guadeloupe =
        new(
            CountryNames.Guadeloupe, "312", "GP", "GLP",
            "+590", "Basse-Terre", "Americas",
            CurrencyHelper.Euro,
            LanguageHelper.French);
}