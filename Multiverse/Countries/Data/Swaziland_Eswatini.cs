using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    public static readonly Country Swaziland_Eswatini =
        new Country(
            CountryNames.Swaziland_Eswatini, "748", "SZ", "SWZ",
            "+268", "Mbabane", "Africa",
            CurrencyHelper.SwaziLilangeni,
            LanguageHelper.English, LanguageHelper.Swati);
}