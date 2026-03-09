using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>The Montenegro country.</summary>
    public static readonly Country Montenegro =
        new Country(
            CountryNames.Montenegro, "499", "ME", "MNE",
            "+382", "Podgorica", "Europe",
            CurrencyHelper.Euro,
            LanguageHelper.Montenegrin);
}