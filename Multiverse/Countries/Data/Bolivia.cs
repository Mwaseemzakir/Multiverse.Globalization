namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Bolivia country.</summary>
    public static readonly Country Bolivia =
        new(
            CountryNames.Bolivia, "068", "BO", "BOL",
            "+591", "Sucre", "Americas",
            CurrencyHelper.Boliviano,
            LanguageHelper.Spanish, LanguageHelper.Quechua, LanguageHelper.Aymara);
}