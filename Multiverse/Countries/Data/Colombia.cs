namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Colombia country.</summary>
    public static readonly Country Colombia =
        new(
            CountryNames.Colombia, "170", "CO", "COL",
            "+57", "Bogota", "Americas",
            CurrencyHelper.ColombianPeso,
            LanguageHelper.Spanish);
}