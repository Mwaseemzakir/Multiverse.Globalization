using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Bonaire Sint Eustatiusand Saba country.</summary>
    public static readonly Country BonaireSintEustatiusandSaba =
        new Country(
            CountryNames.BonaireSintEustatiusandSaba, "535", "BQ", "BES",
            "+599", "Kralendijk", "Americas",
            CurrencyHelper.UsDollar,
            LanguageHelper.Dutch);
}