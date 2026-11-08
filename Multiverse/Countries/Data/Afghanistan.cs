namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Afghanistan country.</summary>
    public static readonly Country Afghanistan =
        new(
            CountryNames.Afghanistan, "004", "AF", "AFG",
            "+93", "Kabul", "Asia",
            CurrencyHelper.Afghani,
            LanguageHelper.Pushto, LanguageHelper.Persian);
}