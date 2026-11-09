namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Mauritania country.</summary>
    public static readonly Country Mauritania =
        new(
            CountryNames.Mauritania, "478", "MR", "MRT",
            "+222", "Nouakchott", "Africa",
            CurrencyHelper.MauritanianOuguiya,
            LanguageHelper.Arabic);
}