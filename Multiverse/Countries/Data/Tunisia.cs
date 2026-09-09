namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Tunisia country.</summary>
    public static readonly Country Tunisia =
        new(
            CountryNames.Tunisia, "788", "TN", "TUN",
            "+216", "Tunis", "Africa",
            CurrencyHelper.TunisianDinar,
            LanguageHelper.Arabic);
}