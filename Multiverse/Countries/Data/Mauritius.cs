using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Mauritius country.</summary>
    public static readonly Country Mauritius =
        new Country(
            CountryNames.Mauritius, "480", "MU", "MUS",
            "+230", "Port Louis", "Africa",
            CurrencyHelper.MauritianRupee,
            LanguageHelper.English);
}