namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Madagascar country.</summary>
    public static readonly Country Madagascar =
        new(
            CountryNames.Madagascar, "450", "MG", "MDG",
            "+261", "Antananarivo", "Africa",
            CurrencyHelper.MalagasyAriary,
            LanguageHelper.French, LanguageHelper.Malagasy);
}