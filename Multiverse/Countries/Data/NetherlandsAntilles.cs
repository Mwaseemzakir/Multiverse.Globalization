namespace Multiverse.Globalization.Countries;

public static partial class CountryHelper
{
    /// <summary>
    /// The former Netherlands Antilles entry, retained for compatibility after the AN/ANT codes
    /// were withdrawn from ISO 3166-1 in 2010.
    /// </summary>
    public static readonly Country NetherlandsAntilles =
        new Country(
            CountryNames.NetherlandsAntilles, "530", "AN", "ANT",
            "+599", "Willemstad", "Americas",
            CurrencyHelper.NetherlandsAntilleanGuilder,
            CountryCodeStatus.FormerlyAssigned,
            LanguageHelper.Dutch);
}
