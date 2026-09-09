namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Provides holiday data for all 250 countries and territories.
/// Each entry maps an ISO 3166-1 alpha-2 code to a list of fixed-date public holidays.
/// </summary>
public static class HolidayHelper
{
    private static readonly Dictionary<string, List<Holiday>> _holidays = InitializeHolidays();

    /// <summary>
    /// Returns the holidays for a given country alpha-2 code, or an empty list if none are defined.
    /// </summary>
    internal static IReadOnlyList<Holiday> GetHolidaysForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return [];

        return _holidays.TryGetValue(alpha2Code.ToUpperInvariant(), out var list)
            ? list.AsReadOnly()
            : new List<Holiday>();
    }

    /// <summary>
    /// Returns the complete mapping of alpha-2 codes to holiday lists.
    /// </summary>
    public static IReadOnlyDictionary<string, List<Holiday>> All => _holidays;

    private static Dictionary<string, List<Holiday>> InitializeHolidays()
    {
        var h = new Dictionary<string, List<Holiday>>
        {
            // ══════════════════════════════════════════════════════════════
            //  ASIA
            // ══════════════════════════════════════════════════════════════

            ["AF"] =
        [
            new("Afghan New Year (Nowruz)", 3, 21, HolidayType.Public),
            new("Independence Day", 8, 19, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
        ],

            ["AM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Christmas Day", 1, 6, HolidayType.Religious),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Republic Day", 5, 28, HolidayType.National),
            new("Independence Day", 9, 21, HolidayType.National),
        ],

            ["AZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Nowruz", 3, 20, HolidayType.Public),
            new("Republic Day", 5, 28, HolidayType.National),
            new("Independence Day", 10, 18, HolidayType.National),
        ],

            ["BH"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 12, 16, HolidayType.National),
        ],

            ["BD"] =
        [
            new("International Mother Language Day", 2, 21, HolidayType.Public),
            new("Independence Day", 3, 26, HolidayType.National),
            new("Bengali New Year", 4, 14, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory Day", 12, 16, HolidayType.National),
        ],

            ["BT"] =
        [
            new("National Day", 12, 17, HolidayType.National),
            new("King's Birthday", 2, 21, HolidayType.Public),
        ],

            ["BN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 2, 23, HolidayType.National),
            new("Sultan's Birthday", 7, 15, HolidayType.Public),
        ],

            ["KH"] =
        [
            new("International New Year", 1, 1, HolidayType.Public),
            new("Victory over Genocide Day", 1, 7, HolidayType.National),
            new("Khmer New Year", 4, 14, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 9, HolidayType.National),
        ],

            ["CN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 10, 1, HolidayType.National),
        ],

            ["CY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Greek Independence Day", 3, 25, HolidayType.National),
            new("Cyprus National Day", 4, 1, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Christmas Day", 1, 7, HolidayType.Religious),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Independence Day", 5, 26, HolidayType.National),
        ],

            ["IN"] =
        [
            new("Republic Day", 1, 26, HolidayType.National),
            new("Independence Day", 8, 15, HolidayType.National),
            new("Gandhi Jayanti", 10, 2, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Labour Day", 5, 1, HolidayType.Public),
        ],

            ["ID"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Pancasila Day", 6, 1, HolidayType.National),
            new("Independence Day", 8, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["IR"] =
        [
            new("Nowruz", 3, 20, HolidayType.Public),
            new("Islamic Republic Day", 4, 1, HolidayType.National),
            new("Nature Day", 4, 2, HolidayType.Public),
        ],

            ["IQ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Army Day", 1, 6, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Republic Day", 7, 14, HolidayType.National),
            new("National Day", 10, 3, HolidayType.National),
        ],

            ["IL"] =
        [
            new("Holocaust Remembrance Day", 4, 28, HolidayType.Observance),
            new("Memorial Day", 5, 4, HolidayType.Observance),
            new("Independence Day", 5, 5, HolidayType.National),
        ],

            ["JP"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Coming of Age Day", 1, 13, HolidayType.Public),
            new("National Foundation Day", 2, 11, HolidayType.National),
            new("Emperor's Birthday", 2, 23, HolidayType.Public),
            new("Vernal Equinox Day", 3, 20, HolidayType.Public),
            new("Showa Day", 4, 29, HolidayType.Public),
            new("Constitution Memorial Day", 5, 3, HolidayType.National),
            new("Greenery Day", 5, 4, HolidayType.Public),
            new("Children's Day", 5, 5, HolidayType.Public),
            new("Mountain Day", 8, 11, HolidayType.Public),
            new("Culture Day", 11, 3, HolidayType.Public),
            new("Labour Thanksgiving Day", 11, 23, HolidayType.Public),
        ],

            ["JO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 5, 25, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["KZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Nowruz", 3, 22, HolidayType.Public),
            new("Unity Day", 5, 1, HolidayType.Public),
            new("Capital Day", 7, 6, HolidayType.Public),
            new("Independence Day", 12, 16, HolidayType.National),
        ],

            ["KW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 2, 25, HolidayType.National),
            new("Liberation Day", 2, 26, HolidayType.National),
        ],

            ["KG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Nowruz", 3, 21, HolidayType.Public),
            new("Independence Day", 8, 31, HolidayType.National),
        ],

            ["LA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Lao New Year", 4, 14, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 12, 2, HolidayType.National),
        ],

            ["LB"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 22, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Yang di-Pertuan Agong's Birthday", 6, 3, HolidayType.Public),
            new("Malaysia Day", 9, 16, HolidayType.National),
            new("National Day", 8, 31, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MV"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 7, 26, HolidayType.National),
            new("Republic Day", 11, 11, HolidayType.National),
        ],

            ["MN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Naadam", 7, 11, HolidayType.National),
            new("Independence Day", 12, 29, HolidayType.National),
        ],

            ["MM"] =
        [
            new("Independence Day", 1, 4, HolidayType.National),
            new("Union Day", 2, 12, HolidayType.National),
            new("Peasants' Day", 3, 2, HolidayType.Public),
            new("Armed Forces Day", 3, 27, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NP"] =
        [
            new("Prithvi Jayanti", 1, 11, HolidayType.National),
            new("Martyrs' Day", 1, 30, HolidayType.National),
            new("Republic Day", 5, 29, HolidayType.National),
            new("Constitution Day", 9, 19, HolidayType.National),
        ],

            ["KP"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Day of the Sun", 4, 15, HolidayType.National),
            new("Day of the Shining Star", 2, 16, HolidayType.National),
            new("Foundation Day", 9, 9, HolidayType.National),
        ],

            ["OM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 11, 18, HolidayType.National),
        ],

            ["PK"] =
        [
            new("Kashmir Day", 2, 5, HolidayType.Observance),
            new("Pakistan Day", 3, 23, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 14, HolidayType.National),
            new("Iqbal Day", 11, 9, HolidayType.National),
            new("Quaid-e-Azam Day", 12, 25, HolidayType.National),
        ],

            ["PS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 15, HolidayType.National),
        ],

            ["PH"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Araw ng Kagitingan", 4, 9, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 6, 12, HolidayType.National),
            new("National Heroes Day", 8, 25, HolidayType.National),
            new("Bonifacio Day", 11, 30, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Rizal Day", 12, 30, HolidayType.National),
        ],

            ["QA"] =
        [
            new("National Day", 12, 18, HolidayType.National),
            new("National Sports Day", 2, 11, HolidayType.Public),
        ],

            ["SA"] =
        [
            new("National Day", 9, 23, HolidayType.National),
            new("Founding Day", 2, 22, HolidayType.National),
        ],

            ["SG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 8, 9, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["KR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Movement Day", 3, 1, HolidayType.National),
            new("Children's Day", 5, 5, HolidayType.Public),
            new("Memorial Day", 6, 6, HolidayType.Observance),
            new("Liberation Day", 8, 15, HolidayType.National),
            new("National Foundation Day", 10, 3, HolidayType.National),
            new("Hangul Day", 10, 9, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LK"] =
        [
            new("Independence Day", 2, 4, HolidayType.National),
            new("Sinhala and Tamil New Year", 4, 14, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Revolution Day", 3, 8, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Martyrs' Day", 5, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Peace Memorial Day", 2, 28, HolidayType.National),
            new("Children's Day", 4, 4, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 10, 10, HolidayType.National),
        ],

            ["TJ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Nowruz", 3, 21, HolidayType.Public),
            new("Independence Day", 9, 9, HolidayType.National),
        ],

            ["TH"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Chakri Memorial Day", 4, 6, HolidayType.National),
            new("Songkran", 4, 13, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("King's Birthday", 7, 28, HolidayType.National),
            new("Queen's Birthday", 6, 3, HolidayType.National),
            new("Constitution Day", 12, 10, HolidayType.National),
        ],

            ["TL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Restoration Day", 5, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Sovereignty and Children's Day", 4, 23, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Commemoration of Ataturk, Youth and Sports Day", 5, 19, HolidayType.National),
            new("Democracy and National Unity Day", 7, 15, HolidayType.National),
            new("Victory Day", 8, 30, HolidayType.National),
            new("Republic Day", 10, 29, HolidayType.National),
        ],

            ["TM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Nowruz", 3, 21, HolidayType.Public),
            new("Independence Day", 10, 27, HolidayType.National),
        ],

            ["AE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Commemoration Day", 11, 30, HolidayType.National),
            new("National Day", 12, 2, HolidayType.National),
        ],

            ["UZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Nowruz", 3, 21, HolidayType.Public),
            new("Memorial Day", 5, 9, HolidayType.Observance),
            new("Independence Day", 9, 1, HolidayType.National),
            new("Constitution Day", 12, 8, HolidayType.National),
        ],

            ["VN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Reunification Day", 4, 30, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 9, 2, HolidayType.National),
        ],

            ["YE"] =
        [
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Unification Day", 5, 22, HolidayType.National),
            new("Revolution Day", 9, 26, HolidayType.National),
            new("Revolution Day (November)", 10, 14, HolidayType.National),
        ],

            // ══════════════════════════════════════════════════════════════
            //  EUROPE
            // ══════════════════════════════════════════════════════════════

            ["AL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Summer Day", 3, 14, HolidayType.Public),
            new("Nowruz", 3, 22, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 28, HolidayType.National),
            new("Liberation Day", 11, 29, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["AD"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 3, 14, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 9, 8, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["AT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("National Day", 10, 26, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("St. Stephen's Day", 12, 26, HolidayType.Religious),
        ],

            ["BY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory Day", 5, 9, HolidayType.National),
            new("Independence Day", 7, 3, HolidayType.National),
            new("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
        ],

            ["BE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 7, 21, HolidayType.National),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Armistice Day", 11, 11, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 3, 1, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Statehood Day", 11, 25, HolidayType.National),
        ],

            ["BG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Liberation Day", 3, 3, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("St. George's Day", 5, 6, HolidayType.National),
            new("Education Day", 5, 24, HolidayType.Public),
            new("Unification Day", 9, 6, HolidayType.National),
            new("Independence Day", 9, 22, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["HR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Statehood Day", 5, 30, HolidayType.National),
            new("Anti-Fascist Struggle Day", 6, 22, HolidayType.National),
            new("Victory Day", 8, 5, HolidayType.National),
            new("Independence Day", 10, 8, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Liberation Day", 5, 8, HolidayType.National),
            new("Saints Cyril and Methodius Day", 7, 5, HolidayType.Religious),
            new("Jan Hus Day", 7, 6, HolidayType.National),
            new("Statehood Day", 9, 28, HolidayType.National),
            new("Independence Day", 10, 28, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["DK"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 6, 5, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Second Christmas Day", 12, 26, HolidayType.Religious),
        ],

            ["EE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 2, 24, HolidayType.National),
            new("Victory Day", 6, 23, HolidayType.National),
            new("Midsummer Day", 6, 24, HolidayType.Public),
            new("Independence Restoration Day", 8, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["FI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 12, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("St. Stephen's Day", 12, 26, HolidayType.Religious),
        ],

            ["FR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory in Europe Day", 5, 8, HolidayType.National),
            new("Bastille Day", 7, 14, HolidayType.National),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Armistice Day", 11, 11, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["DE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("German Unity Day", 10, 3, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("St. Stephen's Day", 12, 26, HolidayType.Religious),
        ],

            ["GR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Independence Day", 3, 25, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Ohi Day", 10, 28, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["HU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 3, 15, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("St. Stephen's Day", 8, 20, HolidayType.National),
            new("National Day (1956 Revolution)", 10, 23, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["IS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 6, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["IE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("St. Brigid's Day", 2, 1, HolidayType.Public),
            new("St. Patrick's Day", 3, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("St. Stephen's Day", 12, 26, HolidayType.Religious),
        ],

            ["IT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Liberation Day", 4, 25, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Republic Day", 6, 2, HolidayType.National),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Immaculate Conception", 12, 8, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("St. Stephen's Day", 12, 26, HolidayType.Religious),
        ],

            ["LV"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Declaration Day", 5, 4, HolidayType.National),
            new("Midsummer Eve", 6, 23, HolidayType.Public),
            new("Midsummer Day", 6, 24, HolidayType.Public),
            new("Independence Day", 11, 18, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Candlemas", 2, 2, HolidayType.Religious),
            new("National Day", 8, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Restoration Day", 2, 16, HolidayType.National),
            new("Independence Day", 3, 11, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Statehood Day", 7, 6, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Europe Day", 5, 9, HolidayType.Public),
            new("National Day", 6, 23, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Feast of St. Paul's Shipwreck", 2, 10, HolidayType.Religious),
            new("Freedom Day", 3, 31, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Sette Giugno", 6, 7, HolidayType.National),
            new("Feast of the Assumption", 8, 15, HolidayType.Religious),
            new("Independence Day", 9, 21, HolidayType.National),
            new("Republic Day", 12, 13, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MD"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory Day", 5, 9, HolidayType.National),
            new("Independence Day", 8, 27, HolidayType.National),
            new("Romanian Language Day", 8, 31, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MC"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 11, 19, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ME"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 5, 21, HolidayType.National),
            new("Statehood Day", 7, 13, HolidayType.National),
        ],

            ["NL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("King's Day", 4, 27, HolidayType.National),
            new("Liberation Day", 5, 5, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Second Christmas Day", 12, 26, HolidayType.Religious),
        ],

            ["MK"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Saints Cyril and Methodius Day", 5, 24, HolidayType.Religious),
            new("Republic Day", 8, 2, HolidayType.National),
            new("Independence Day", 9, 8, HolidayType.National),
            new("Revolution Day", 10, 11, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Constitution Day", 5, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Second Christmas Day", 12, 26, HolidayType.Religious),
        ],

            ["PL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 5, 3, HolidayType.National),
            new("Independence Day", 11, 11, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Second Christmas Day", 12, 26, HolidayType.Religious),
        ],

            ["PT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Freedom Day", 4, 25, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Portugal Day", 6, 10, HolidayType.National),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("Republic Day", 10, 5, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Restoration of Independence Day", 12, 1, HolidayType.National),
            new("Immaculate Conception", 12, 8, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["RO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Unification Day", 1, 24, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Children's Day", 6, 1, HolidayType.Public),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("St. Andrew's Day", 11, 30, HolidayType.Religious),
            new("Great Union Day", 12, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["RU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
            new("Defender of the Fatherland Day", 2, 23, HolidayType.National),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory Day", 5, 9, HolidayType.National),
            new("Russia Day", 6, 12, HolidayType.National),
            new("Unity Day", 11, 4, HolidayType.National),
        ],

            ["SM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Feast of St. Agatha", 2, 5, HolidayType.Religious),
            new("Anniversary of the Arengo", 3, 25, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Foundation Day", 9, 3, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["RS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Statehood Day", 2, 15, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Armistice Day", 11, 11, HolidayType.National),
            new("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
        ],

            ["SK"] =
        [
            new("New Year's/Republic Day", 1, 1, HolidayType.National),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory Day", 5, 8, HolidayType.National),
            new("Saints Cyril and Methodius Day", 7, 5, HolidayType.Religious),
            new("Constitution Day", 9, 1, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Freedom and Democracy Day", 11, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Culture Day", 2, 8, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Statehood Day", 6, 25, HolidayType.National),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("Reformation Day", 10, 31, HolidayType.Religious),
            new("Independence Day", 12, 26, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ES"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("National Day", 10, 12, HolidayType.National),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Constitution Day", 12, 6, HolidayType.National),
            new("Immaculate Conception", 12, 8, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 6, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Second Christmas Day", 12, 26, HolidayType.Religious),
        ],

            ["CH"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 8, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["UA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Victory Day", 5, 9, HolidayType.National),
            new("Constitution Day", 6, 28, HolidayType.National),
            new("Independence Day", 8, 24, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GB"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Bank),
            new("St. Patrick's Day", 3, 17, HolidayType.Bank),
            new("Christmas Day", 12, 25, HolidayType.Public),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["VA"] =
        [
            new("Solemnity of Mary", 1, 1, HolidayType.Religious),
            new("Epiphany", 1, 6, HolidayType.Religious),
            new("Anniversary of the Foundation of Vatican City", 2, 11, HolidayType.National),
            new("Assumption Day", 8, 15, HolidayType.Religious),
            new("All Saints' Day", 11, 1, HolidayType.Religious),
            new("Immaculate Conception", 12, 8, HolidayType.Religious),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            // ══════════════════════════════════════════════════════════════
            //  AFRICA
            // ══════════════════════════════════════════════════════════════

            ["DZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 5, HolidayType.National),
            new("Revolution Day", 11, 1, HolidayType.National),
        ],

            ["AO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Liberation Day", 2, 4, HolidayType.National),
            new("Peace Day", 4, 4, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 11, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BJ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Sir Seretse Khama Day", 7, 1, HolidayType.National),
            new("Independence Day", 9, 30, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["BF"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 5, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Unity Day", 2, 5, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CV"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Heroes' Day", 1, 20, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 5, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Youth Day", 2, 11, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Day", 5, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CF"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Boganda Day", 3, 29, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 13, HolidayType.National),
            new("Republic Day", 12, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TD"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 11, HolidayType.National),
            new("Republic Day", 11, 28, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["KM"] =
        [
            new("Independence Day", 7, 6, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
        ],

            ["CG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CD"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Martyrs' Day", 1, 4, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 6, 30, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 7, HolidayType.National),
            new("National Peace Day", 11, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["DJ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 6, 27, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["EG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Revolution Day", 1, 25, HolidayType.National),
            new("Sinai Liberation Day", 4, 25, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Revolution Day (July)", 7, 23, HolidayType.National),
            new("Armed Forces Day", 10, 6, HolidayType.National),
        ],

            ["GQ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 10, 12, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ER"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 5, 24, HolidayType.National),
            new("Martyrs' Day", 6, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("King's Birthday", 4, 19, HolidayType.National),
            new("Independence Day", 9, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ET"] =
        [
            new("Christmas (Genna)", 1, 7, HolidayType.Religious),
            new("Adwa Victory Day", 3, 2, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Patriots' Day", 5, 5, HolidayType.National),
            new("Ethiopian New Year", 9, 11, HolidayType.Public),
        ],

            ["GA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 2, 18, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GH"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 3, 6, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Republic Day", 7, 1, HolidayType.National),
            new("Founders' Day", 9, 21, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 10, 2, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Heroes' Day", 1, 20, HolidayType.National),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 24, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["KE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Madaraka Day", 6, 1, HolidayType.National),
            new("Mashujaa Day", 10, 20, HolidayType.National),
            new("Jamhuri Day", 12, 12, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Moshoeshoe's Day", 3, 11, HolidayType.National),
            new("Independence Day", 10, 4, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Armed Forces Day", 2, 11, HolidayType.National),
            new("Independence Day", 7, 26, HolidayType.National),
            new("Thanksgiving Day", 11, 7, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LY"] =
        [
            new("Revolution Day", 2, 17, HolidayType.National),
            new("Independence Day", 12, 24, HolidayType.National),
        ],

            ["MG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 6, 26, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("John Chilembwe Day", 1, 15, HolidayType.National),
            new("Martyrs' Day", 3, 3, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ML"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Army Day", 1, 20, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 22, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 28, HolidayType.National),
        ],

            ["MU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Abolition of Slavery Day", 2, 1, HolidayType.National),
            new("Independence Day", 3, 12, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Manifesto Day", 1, 11, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Throne Day", 7, 30, HolidayType.National),
            new("Revolution Day", 8, 20, HolidayType.National),
            new("Independence Day", 11, 18, HolidayType.National),
        ],

            ["MZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Heroes' Day", 2, 3, HolidayType.National),
            new("Women's Day", 4, 7, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 6, 25, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 3, 21, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Africa Day", 5, 25, HolidayType.Public),
            new("Heroes' Day", 8, 26, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 3, HolidayType.National),
            new("Republic Day", 12, 18, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Democracy Day", 6, 12, HolidayType.National),
            new("Independence Day", 10, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["RW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Heroes' Day", 2, 1, HolidayType.National),
            new("Genocide Memorial Day", 4, 7, HolidayType.Observance),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 1, HolidayType.National),
            new("Liberation Day", 7, 4, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ST"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 12, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 4, 4, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SC"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Liberation Day", 6, 5, HolidayType.National),
            new("Constitution Day", 6, 18, HolidayType.National),
            new("Independence Day", 6, 29, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 4, 27, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 1, HolidayType.National),
        ],

            ["ZA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Human Rights Day", 3, 21, HolidayType.National),
            new("Freedom Day", 4, 27, HolidayType.National),
            new("Workers' Day", 5, 1, HolidayType.Public),
            new("Youth Day", 6, 16, HolidayType.National),
            new("National Women's Day", 8, 9, HolidayType.National),
            new("Heritage Day", 9, 24, HolidayType.National),
            new("Day of Reconciliation", 12, 16, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Day of Goodwill", 12, 26, HolidayType.Public),
        ],

            ["SS"] =
        [
            new("Independence Day", 7, 9, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SD"] =
        [
            new("Independence Day", 1, 1, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
        ],

            ["TZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Zanzibar Revolution Day", 1, 12, HolidayType.National),
            new("Union Day", 4, 26, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Saba Saba Day", 7, 7, HolidayType.Public),
            new("Nane Nane Day", 8, 8, HolidayType.Public),
            new("Independence Day", 12, 9, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 4, 27, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Revolution Day", 1, 14, HolidayType.National),
            new("Independence Day", 3, 20, HolidayType.National),
            new("Martyrs' Day", 4, 9, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Republic Day", 7, 25, HolidayType.National),
        ],

            ["UG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Liberation Day", 1, 26, HolidayType.National),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Martyrs' Day", 6, 3, HolidayType.Religious),
            new("Heroes' Day", 6, 9, HolidayType.National),
            new("Independence Day", 10, 9, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ZM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Women's Day", 3, 8, HolidayType.Public),
            new("Youth Day", 3, 12, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Africa Day", 5, 25, HolidayType.Public),
            new("Heroes' Day", 7, 7, HolidayType.National),
            new("Unity Day", 7, 8, HolidayType.National),
            new("Farmers' Day", 8, 5, HolidayType.Public),
            new("Independence Day", 10, 24, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["ZW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 4, 18, HolidayType.National),
            new("Workers' Day", 5, 1, HolidayType.Public),
            new("Africa Day", 5, 25, HolidayType.Public),
            new("Heroes' Day", 8, 11, HolidayType.National),
            new("Defence Forces Day", 8, 12, HolidayType.National),
            new("Unity Day", 12, 22, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            // ══════════════════════════════════════════════════════════════
            //  AMERICAS
            // ══════════════════════════════════════════════════════════════

            ["AG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["AR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Carnival", 2, 12, HolidayType.Public),
            new("Memorial Day", 3, 24, HolidayType.Observance),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("May Revolution Day", 5, 25, HolidayType.National),
            new("Flag Day", 6, 20, HolidayType.National),
            new("Independence Day", 7, 9, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 6, 6, HolidayType.Public),
            new("Independence Day", 7, 10, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["BB"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Errol Barrow Day", 1, 21, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Emancipation Day", 8, 1, HolidayType.National),
            new("Independence Day", 11, 30, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Heroes Day", 3, 10, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("St. George's Caye Day", 9, 10, HolidayType.National),
            new("Independence Day", 9, 21, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Plurinational State Day", 1, 22, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 8, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Tiradentes Day", 4, 21, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 7, HolidayType.National),
            new("Our Lady of Aparecida", 10, 12, HolidayType.Religious),
            new("All Souls' Day", 11, 2, HolidayType.Religious),
            new("Republic Day", 11, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Canada Day", 7, 1, HolidayType.National),
            new("Labour Day", 9, 1, HolidayType.Public),
            new("National Day for Truth and Reconciliation", 9, 30, HolidayType.Public),
            new("Remembrance Day", 11, 11, HolidayType.Observance),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Navy Day", 5, 21, HolidayType.National),
            new("National Day", 9, 18, HolidayType.National),
            new("Army Day", 9, 19, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 20, HolidayType.National),
            new("Battle of Boyaca", 8, 7, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Juan Santamaria Day", 4, 11, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CU"] =
        [
            new("Liberation Day", 1, 1, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("National Rebellion Day", 7, 26, HolidayType.National),
            new("Independence Day", 10, 10, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["DM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 3, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["DO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Duarte Day", 1, 26, HolidayType.National),
            new("Independence Day", 2, 27, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Restoration Day", 8, 16, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["EC"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Battle of Pichincha", 5, 24, HolidayType.National),
            new("Independence Day", 8, 10, HolidayType.National),
            new("Independence of Guayaquil", 10, 9, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SV"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GD"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 2, 7, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Army Day", 6, 30, HolidayType.National),
            new("Independence Day", 9, 15, HolidayType.National),
            new("Revolution Day", 10, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Republic Day", 2, 23, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 5, 26, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["HT"] =
        [
            new("Independence Day", 1, 1, HolidayType.National),
            new("Ancestors' Day", 1, 2, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Flag Day", 5, 18, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["HN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["JM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 23, HolidayType.Public),
            new("Emancipation Day", 8, 1, HolidayType.National),
            new("Independence Day", 8, 6, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["MX"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 2, 5, HolidayType.National),
            new("Benito Juárez's Birthday", 3, 21, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 16, HolidayType.National),
            new("Revolution Day", 11, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Revolution Day", 7, 19, HolidayType.National),
            new("Independence Day", 9, 15, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["PA"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Martyrs' Day", 1, 9, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Separation Day", 11, 3, HolidayType.National),
            new("Flag Day", 11, 4, HolidayType.National),
            new("Independence Day", 11, 28, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["PY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Heroes' Day", 3, 1, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 5, 14, HolidayType.National),
            new("Chaco Armistice Day", 6, 12, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["PE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 28, HolidayType.National),
            new("Santa Rosa de Lima Day", 8, 30, HolidayType.Religious),
            new("Battle of Angamos", 10, 8, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["KN"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 9, 19, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["LC"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 2, 22, HolidayType.National),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["VC"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 10, 27, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 11, 25, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TT"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 6, 19, HolidayType.Public),
            new("Emancipation Day", 8, 1, HolidayType.National),
            new("Independence Day", 8, 31, HolidayType.National),
            new("Republic Day", 9, 24, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["US"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Martin Luther King Jr. Day", 1, 20, HolidayType.Public),
            new("Presidents' Day", 2, 17, HolidayType.Public),
            new("Memorial Day", 5, 26, HolidayType.Public),
            new("Independence Day", 7, 4, HolidayType.National),
            new("Labor Day", 9, 1, HolidayType.Public),
            new("Columbus Day", 10, 13, HolidayType.Public),
            new("Veterans Day", 11, 11, HolidayType.Public),
            new("Thanksgiving Day", 11, 27, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["UY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Battle of Las Piedras", 5, 18, HolidayType.National),
            new("Independence Day", 8, 25, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["VE"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Independence Day", 7, 5, HolidayType.National),
            new("Simón Bolívar's Birthday", 7, 24, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            // ══════════════════════════════════════════════════════════════
            //  OCEANIA
            // ══════════════════════════════════════════════════════════════

            ["AU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Australia Day", 1, 26, HolidayType.National),
            new("Anzac Day", 4, 25, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["FJ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Fiji Day", 10, 10, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["KI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 7, 12, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MH"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 5, 1, HolidayType.National),
            new("Independence Day", 10, 21, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["FM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 5, 10, HolidayType.National),
            new("Independence Day", 11, 3, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 1, 31, HolidayType.National),
            new("Constitution Day", 5, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["NZ"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Day after New Year's Day", 1, 2, HolidayType.Public),
            new("Waitangi Day", 2, 6, HolidayType.National),
            new("Anzac Day", 4, 25, HolidayType.National),
            new("Matariki", 6, 20, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["PW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 7, 9, HolidayType.National),
            new("Independence Day", 10, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["PG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 9, 16, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["WS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 6, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["SB"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 7, 7, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Emancipation Day", 6, 4, HolidayType.National),
            new("Independence Day", 11, 4, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["TV"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 10, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["VU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Independence Day", 7, 30, HolidayType.National),
            new("Unity Day", 11, 29, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            // ══════════════════════════════════════════════════════════════
            //  TERRITORIES & DEPENDENCIES
            // ══════════════════════════════════════════════════════════════

            ["AS"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Flag Day", 4, 17, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["AI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Anguilla Day", 5, 30, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["AW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Flag Day", 3, 18, HolidayType.National),
            new("King's Day", 4, 27, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["BM"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Bermuda Day", 5, 24, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
            new("Boxing Day", 12, 26, HolidayType.Public),
        ],

            ["VG"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Territory Day", 7, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["KY"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Constitution Day", 7, 7, HolidayType.National),
            new("Remembrance Day", 11, 11, HolidayType.Observance),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CK"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Anzac Day", 4, 25, HolidayType.Observance),
            new("Constitution Day", 8, 4, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["CW"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Flag Day", 7, 2, HolidayType.National),
            new("King's Day", 4, 27, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["FK"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Liberation Day", 6, 14, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["FO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Olavsoka", 7, 29, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 9, 10, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GL"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("National Day", 6, 21, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["GU"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Guam Discovery Day", 3, 3, HolidayType.National),
            new("Liberation Day", 7, 21, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["HK"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("HKSAR Establishment Day", 7, 1, HolidayType.National),
            new("National Day", 10, 1, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["MO"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Labour Day", 5, 1, HolidayType.Public),
            new("MSAR Establishment Day", 12, 20, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["PR"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Three Kings Day", 1, 6, HolidayType.Religious),
            new("Independence Day", 7, 4, HolidayType.National),
            new("Constitution Day", 7, 25, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ],

            ["VI"] =
        [
            new("New Year's Day", 1, 1, HolidayType.Public),
            new("Three Kings Day", 1, 6, HolidayType.Religious),
            new("Transfer Day", 3, 31, HolidayType.National),
            new("Independence Day", 7, 4, HolidayType.National),
            new("Christmas Day", 12, 25, HolidayType.Religious),
        ]
        };

        return h;
    }
}
