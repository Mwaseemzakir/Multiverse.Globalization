namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Serbia country.</summary>
    public static readonly Country Serbia =
        new(
            CountryNames.Serbia, "688", "RS", "SRB",
            "+381", "Belgrade", "Europe",
            CurrencyHelper.SerbianDinar,
            LanguageHelper.Serbian);
}