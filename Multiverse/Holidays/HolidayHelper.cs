using System.Collections.Generic;

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
            return new List<Holiday>();

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
        var h = new Dictionary<string, List<Holiday>>();

        // ══════════════════════════════════════════════════════════════
        //  ASIA
        // ══════════════════════════════════════════════════════════════

        h["AF"] = new List<Holiday>
        {
            new Holiday("Afghan New Year (Nowruz)", 3, 21, HolidayType.Public),
            new Holiday("Independence Day", 8, 19, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
        };

        h["AM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Christmas Day", 1, 6, HolidayType.Religious),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Republic Day", 5, 28, HolidayType.National),
            new Holiday("Independence Day", 9, 21, HolidayType.National),
        };

        h["AZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Nowruz", 3, 20, HolidayType.Public),
            new Holiday("Republic Day", 5, 28, HolidayType.National),
            new Holiday("Independence Day", 10, 18, HolidayType.National),
        };

        h["BH"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 12, 16, HolidayType.National),
        };

        h["BD"] = new List<Holiday>
        {
            new Holiday("International Mother Language Day", 2, 21, HolidayType.Public),
            new Holiday("Independence Day", 3, 26, HolidayType.National),
            new Holiday("Bengali New Year", 4, 14, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory Day", 12, 16, HolidayType.National),
        };

        h["BT"] = new List<Holiday>
        {
            new Holiday("National Day", 12, 17, HolidayType.National),
            new Holiday("King's Birthday", 2, 21, HolidayType.Public),
        };

        h["BN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 2, 23, HolidayType.National),
            new Holiday("Sultan's Birthday", 7, 15, HolidayType.Public),
        };

        h["KH"] = new List<Holiday>
        {
            new Holiday("International New Year", 1, 1, HolidayType.Public),
            new Holiday("Victory over Genocide Day", 1, 7, HolidayType.National),
            new Holiday("Khmer New Year", 4, 14, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 9, HolidayType.National),
        };

        h["CN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 10, 1, HolidayType.National),
        };

        h["CY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Greek Independence Day", 3, 25, HolidayType.National),
            new Holiday("Cyprus National Day", 4, 1, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Christmas Day", 1, 7, HolidayType.Religious),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Independence Day", 5, 26, HolidayType.National),
        };

        h["IN"] = new List<Holiday>
        {
            new Holiday("Republic Day", 1, 26, HolidayType.National),
            new Holiday("Independence Day", 8, 15, HolidayType.National),
            new Holiday("Gandhi Jayanti", 10, 2, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
        };

        h["ID"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Pancasila Day", 6, 1, HolidayType.National),
            new Holiday("Independence Day", 8, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["IR"] = new List<Holiday>
        {
            new Holiday("Nowruz", 3, 20, HolidayType.Public),
            new Holiday("Islamic Republic Day", 4, 1, HolidayType.National),
            new Holiday("Nature Day", 4, 2, HolidayType.Public),
        };

        h["IQ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Army Day", 1, 6, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Republic Day", 7, 14, HolidayType.National),
            new Holiday("National Day", 10, 3, HolidayType.National),
        };

        h["IL"] = new List<Holiday>
        {
            new Holiday("Holocaust Remembrance Day", 4, 28, HolidayType.Observance),
            new Holiday("Memorial Day", 5, 4, HolidayType.Observance),
            new Holiday("Independence Day", 5, 5, HolidayType.National),
        };

        h["JP"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Coming of Age Day", 1, 13, HolidayType.Public),
            new Holiday("National Foundation Day", 2, 11, HolidayType.National),
            new Holiday("Emperor's Birthday", 2, 23, HolidayType.Public),
            new Holiday("Vernal Equinox Day", 3, 20, HolidayType.Public),
            new Holiday("Showa Day", 4, 29, HolidayType.Public),
            new Holiday("Constitution Memorial Day", 5, 3, HolidayType.National),
            new Holiday("Greenery Day", 5, 4, HolidayType.Public),
            new Holiday("Children's Day", 5, 5, HolidayType.Public),
            new Holiday("Mountain Day", 8, 11, HolidayType.Public),
            new Holiday("Culture Day", 11, 3, HolidayType.Public),
            new Holiday("Labour Thanksgiving Day", 11, 23, HolidayType.Public),
        };

        h["JO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 5, 25, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["KZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Nowruz", 3, 22, HolidayType.Public),
            new Holiday("Unity Day", 5, 1, HolidayType.Public),
            new Holiday("Capital Day", 7, 6, HolidayType.Public),
            new Holiday("Independence Day", 12, 16, HolidayType.National),
        };

        h["KW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 2, 25, HolidayType.National),
            new Holiday("Liberation Day", 2, 26, HolidayType.National),
        };

        h["KG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Nowruz", 3, 21, HolidayType.Public),
            new Holiday("Independence Day", 8, 31, HolidayType.National),
        };

        h["LA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Lao New Year", 4, 14, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 12, 2, HolidayType.National),
        };

        h["LB"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 22, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Yang di-Pertuan Agong's Birthday", 6, 3, HolidayType.Public),
            new Holiday("Malaysia Day", 9, 16, HolidayType.National),
            new Holiday("National Day", 8, 31, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MV"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 26, HolidayType.National),
            new Holiday("Republic Day", 11, 11, HolidayType.National),
        };

        h["MN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Naadam", 7, 11, HolidayType.National),
            new Holiday("Independence Day", 12, 29, HolidayType.National),
        };

        h["MM"] = new List<Holiday>
        {
            new Holiday("Independence Day", 1, 4, HolidayType.National),
            new Holiday("Union Day", 2, 12, HolidayType.National),
            new Holiday("Peasants' Day", 3, 2, HolidayType.Public),
            new Holiday("Armed Forces Day", 3, 27, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NP"] = new List<Holiday>
        {
            new Holiday("Prithvi Jayanti", 1, 11, HolidayType.National),
            new Holiday("Martyrs' Day", 1, 30, HolidayType.National),
            new Holiday("Republic Day", 5, 29, HolidayType.National),
            new Holiday("Constitution Day", 9, 19, HolidayType.National),
        };

        h["KP"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Day of the Sun", 4, 15, HolidayType.National),
            new Holiday("Day of the Shining Star", 2, 16, HolidayType.National),
            new Holiday("Foundation Day", 9, 9, HolidayType.National),
        };

        h["OM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 11, 18, HolidayType.National),
        };

        h["PK"] = new List<Holiday>
        {
            new Holiday("Kashmir Day", 2, 5, HolidayType.Observance),
            new Holiday("Pakistan Day", 3, 23, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 14, HolidayType.National),
            new Holiday("Iqbal Day", 11, 9, HolidayType.National),
            new Holiday("Quaid-e-Azam Day", 12, 25, HolidayType.National),
        };

        h["PS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 15, HolidayType.National),
        };

        h["PH"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Araw ng Kagitingan", 4, 9, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 6, 12, HolidayType.National),
            new Holiday("National Heroes Day", 8, 25, HolidayType.National),
            new Holiday("Bonifacio Day", 11, 30, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Rizal Day", 12, 30, HolidayType.National),
        };

        h["QA"] = new List<Holiday>
        {
            new Holiday("National Day", 12, 18, HolidayType.National),
            new Holiday("National Sports Day", 2, 11, HolidayType.Public),
        };

        h["SA"] = new List<Holiday>
        {
            new Holiday("National Day", 9, 23, HolidayType.National),
            new Holiday("Founding Day", 2, 22, HolidayType.National),
        };

        h["SG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 8, 9, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["KR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Movement Day", 3, 1, HolidayType.National),
            new Holiday("Children's Day", 5, 5, HolidayType.Public),
            new Holiday("Memorial Day", 6, 6, HolidayType.Observance),
            new Holiday("Liberation Day", 8, 15, HolidayType.National),
            new Holiday("National Foundation Day", 10, 3, HolidayType.National),
            new Holiday("Hangul Day", 10, 9, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LK"] = new List<Holiday>
        {
            new Holiday("Independence Day", 2, 4, HolidayType.National),
            new Holiday("Sinhala and Tamil New Year", 4, 14, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Revolution Day", 3, 8, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Martyrs' Day", 5, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Peace Memorial Day", 2, 28, HolidayType.National),
            new Holiday("Children's Day", 4, 4, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 10, 10, HolidayType.National),
        };

        h["TJ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Nowruz", 3, 21, HolidayType.Public),
            new Holiday("Independence Day", 9, 9, HolidayType.National),
        };

        h["TH"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Chakri Memorial Day", 4, 6, HolidayType.National),
            new Holiday("Songkran", 4, 13, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("King's Birthday", 7, 28, HolidayType.National),
            new Holiday("Queen's Birthday", 6, 3, HolidayType.National),
            new Holiday("Constitution Day", 12, 10, HolidayType.National),
        };

        h["TL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Restoration Day", 5, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Sovereignty and Children's Day", 4, 23, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Commemoration of Ataturk, Youth and Sports Day", 5, 19, HolidayType.National),
            new Holiday("Democracy and National Unity Day", 7, 15, HolidayType.National),
            new Holiday("Victory Day", 8, 30, HolidayType.National),
            new Holiday("Republic Day", 10, 29, HolidayType.National),
        };

        h["TM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Nowruz", 3, 21, HolidayType.Public),
            new Holiday("Independence Day", 10, 27, HolidayType.National),
        };

        h["AE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Commemoration Day", 11, 30, HolidayType.National),
            new Holiday("National Day", 12, 2, HolidayType.National),
        };

        h["UZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Nowruz", 3, 21, HolidayType.Public),
            new Holiday("Memorial Day", 5, 9, HolidayType.Observance),
            new Holiday("Independence Day", 9, 1, HolidayType.National),
            new Holiday("Constitution Day", 12, 8, HolidayType.National),
        };

        h["VN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Reunification Day", 4, 30, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 9, 2, HolidayType.National),
        };

        h["YE"] = new List<Holiday>
        {
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Unification Day", 5, 22, HolidayType.National),
            new Holiday("Revolution Day", 9, 26, HolidayType.National),
            new Holiday("Revolution Day (November)", 10, 14, HolidayType.National),
        };

        // ══════════════════════════════════════════════════════════════
        //  EUROPE
        // ══════════════════════════════════════════════════════════════

        h["AL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Summer Day", 3, 14, HolidayType.Public),
            new Holiday("Nowruz", 3, 22, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 28, HolidayType.National),
            new Holiday("Liberation Day", 11, 29, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["AD"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 3, 14, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 9, 8, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["AT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("National Day", 10, 26, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("St. Stephen's Day", 12, 26, HolidayType.Religious),
        };

        h["BY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory Day", 5, 9, HolidayType.National),
            new Holiday("Independence Day", 7, 3, HolidayType.National),
            new Holiday("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
        };

        h["BE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 7, 21, HolidayType.National),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Armistice Day", 11, 11, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 3, 1, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Statehood Day", 11, 25, HolidayType.National),
        };

        h["BG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Liberation Day", 3, 3, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("St. George's Day", 5, 6, HolidayType.National),
            new Holiday("Education Day", 5, 24, HolidayType.Public),
            new Holiday("Unification Day", 9, 6, HolidayType.National),
            new Holiday("Independence Day", 9, 22, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["HR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Statehood Day", 5, 30, HolidayType.National),
            new Holiday("Anti-Fascist Struggle Day", 6, 22, HolidayType.National),
            new Holiday("Victory Day", 8, 5, HolidayType.National),
            new Holiday("Independence Day", 10, 8, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Liberation Day", 5, 8, HolidayType.National),
            new Holiday("Saints Cyril and Methodius Day", 7, 5, HolidayType.Religious),
            new Holiday("Jan Hus Day", 7, 6, HolidayType.National),
            new Holiday("Statehood Day", 9, 28, HolidayType.National),
            new Holiday("Independence Day", 10, 28, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["DK"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 6, 5, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Second Christmas Day", 12, 26, HolidayType.Religious),
        };

        h["EE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 2, 24, HolidayType.National),
            new Holiday("Victory Day", 6, 23, HolidayType.National),
            new Holiday("Midsummer Day", 6, 24, HolidayType.Public),
            new Holiday("Independence Restoration Day", 8, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["FI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 12, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("St. Stephen's Day", 12, 26, HolidayType.Religious),
        };

        h["FR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory in Europe Day", 5, 8, HolidayType.National),
            new Holiday("Bastille Day", 7, 14, HolidayType.National),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Armistice Day", 11, 11, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["DE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("German Unity Day", 10, 3, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("St. Stephen's Day", 12, 26, HolidayType.Religious),
        };

        h["GR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Independence Day", 3, 25, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Ohi Day", 10, 28, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["HU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 3, 15, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("St. Stephen's Day", 8, 20, HolidayType.National),
            new Holiday("National Day (1956 Revolution)", 10, 23, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["IS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 6, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["IE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("St. Brigid's Day", 2, 1, HolidayType.Public),
            new Holiday("St. Patrick's Day", 3, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("St. Stephen's Day", 12, 26, HolidayType.Religious),
        };

        h["IT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Liberation Day", 4, 25, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Republic Day", 6, 2, HolidayType.National),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Immaculate Conception", 12, 8, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("St. Stephen's Day", 12, 26, HolidayType.Religious),
        };

        h["LV"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Declaration Day", 5, 4, HolidayType.National),
            new Holiday("Midsummer Eve", 6, 23, HolidayType.Public),
            new Holiday("Midsummer Day", 6, 24, HolidayType.Public),
            new Holiday("Independence Day", 11, 18, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Candlemas", 2, 2, HolidayType.Religious),
            new Holiday("National Day", 8, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Restoration Day", 2, 16, HolidayType.National),
            new Holiday("Independence Day", 3, 11, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Statehood Day", 7, 6, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Europe Day", 5, 9, HolidayType.Public),
            new Holiday("National Day", 6, 23, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Feast of St. Paul's Shipwreck", 2, 10, HolidayType.Religious),
            new Holiday("Freedom Day", 3, 31, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Sette Giugno", 6, 7, HolidayType.National),
            new Holiday("Feast of the Assumption", 8, 15, HolidayType.Religious),
            new Holiday("Independence Day", 9, 21, HolidayType.National),
            new Holiday("Republic Day", 12, 13, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MD"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory Day", 5, 9, HolidayType.National),
            new Holiday("Independence Day", 8, 27, HolidayType.National),
            new Holiday("Romanian Language Day", 8, 31, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MC"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 11, 19, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ME"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 5, 21, HolidayType.National),
            new Holiday("Statehood Day", 7, 13, HolidayType.National),
        };

        h["NL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("King's Day", 4, 27, HolidayType.National),
            new Holiday("Liberation Day", 5, 5, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Second Christmas Day", 12, 26, HolidayType.Religious),
        };

        h["MK"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Saints Cyril and Methodius Day", 5, 24, HolidayType.Religious),
            new Holiday("Republic Day", 8, 2, HolidayType.National),
            new Holiday("Independence Day", 9, 8, HolidayType.National),
            new Holiday("Revolution Day", 10, 11, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Constitution Day", 5, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Second Christmas Day", 12, 26, HolidayType.Religious),
        };

        h["PL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 5, 3, HolidayType.National),
            new Holiday("Independence Day", 11, 11, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Second Christmas Day", 12, 26, HolidayType.Religious),
        };

        h["PT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Freedom Day", 4, 25, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Portugal Day", 6, 10, HolidayType.National),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("Republic Day", 10, 5, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Restoration of Independence Day", 12, 1, HolidayType.National),
            new Holiday("Immaculate Conception", 12, 8, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["RO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Unification Day", 1, 24, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Children's Day", 6, 1, HolidayType.Public),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("St. Andrew's Day", 11, 30, HolidayType.Religious),
            new Holiday("Great Union Day", 12, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["RU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
            new Holiday("Defender of the Fatherland Day", 2, 23, HolidayType.National),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory Day", 5, 9, HolidayType.National),
            new Holiday("Russia Day", 6, 12, HolidayType.National),
            new Holiday("Unity Day", 11, 4, HolidayType.National),
        };

        h["SM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Feast of St. Agatha", 2, 5, HolidayType.Religious),
            new Holiday("Anniversary of the Arengo", 3, 25, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Foundation Day", 9, 3, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["RS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Statehood Day", 2, 15, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Armistice Day", 11, 11, HolidayType.National),
            new Holiday("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
        };

        h["SK"] = new List<Holiday>
        {
            new Holiday("New Year's/Republic Day", 1, 1, HolidayType.National),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory Day", 5, 8, HolidayType.National),
            new Holiday("Saints Cyril and Methodius Day", 7, 5, HolidayType.Religious),
            new Holiday("Constitution Day", 9, 1, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Freedom and Democracy Day", 11, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Culture Day", 2, 8, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Statehood Day", 6, 25, HolidayType.National),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("Reformation Day", 10, 31, HolidayType.Religious),
            new Holiday("Independence Day", 12, 26, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ES"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("National Day", 10, 12, HolidayType.National),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Constitution Day", 12, 6, HolidayType.National),
            new Holiday("Immaculate Conception", 12, 8, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 6, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Second Christmas Day", 12, 26, HolidayType.Religious),
        };

        h["CH"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 8, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["UA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Christmas Day (Orthodox)", 1, 7, HolidayType.Religious),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Victory Day", 5, 9, HolidayType.National),
            new Holiday("Constitution Day", 6, 28, HolidayType.National),
            new Holiday("Independence Day", 8, 24, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GB"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Bank),
            new Holiday("St. Patrick's Day", 3, 17, HolidayType.Bank),
            new Holiday("Christmas Day", 12, 25, HolidayType.Public),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["VA"] = new List<Holiday>
        {
            new Holiday("Solemnity of Mary", 1, 1, HolidayType.Religious),
            new Holiday("Epiphany", 1, 6, HolidayType.Religious),
            new Holiday("Anniversary of the Foundation of Vatican City", 2, 11, HolidayType.National),
            new Holiday("Assumption Day", 8, 15, HolidayType.Religious),
            new Holiday("All Saints' Day", 11, 1, HolidayType.Religious),
            new Holiday("Immaculate Conception", 12, 8, HolidayType.Religious),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        // ══════════════════════════════════════════════════════════════
        //  AFRICA
        // ══════════════════════════════════════════════════════════════

        h["DZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 5, HolidayType.National),
            new Holiday("Revolution Day", 11, 1, HolidayType.National),
        };

        h["AO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Liberation Day", 2, 4, HolidayType.National),
            new Holiday("Peace Day", 4, 4, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 11, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BJ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Sir Seretse Khama Day", 7, 1, HolidayType.National),
            new Holiday("Independence Day", 9, 30, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["BF"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 5, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Unity Day", 2, 5, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CV"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Heroes' Day", 1, 20, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 5, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Youth Day", 2, 11, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Day", 5, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CF"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Boganda Day", 3, 29, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 13, HolidayType.National),
            new Holiday("Republic Day", 12, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TD"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 11, HolidayType.National),
            new Holiday("Republic Day", 11, 28, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["KM"] = new List<Holiday>
        {
            new Holiday("Independence Day", 7, 6, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
        };

        h["CG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CD"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Martyrs' Day", 1, 4, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 6, 30, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 7, HolidayType.National),
            new Holiday("National Peace Day", 11, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["DJ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 6, 27, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["EG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Revolution Day", 1, 25, HolidayType.National),
            new Holiday("Sinai Liberation Day", 4, 25, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Revolution Day (July)", 7, 23, HolidayType.National),
            new Holiday("Armed Forces Day", 10, 6, HolidayType.National),
        };

        h["GQ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 10, 12, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ER"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 5, 24, HolidayType.National),
            new Holiday("Martyrs' Day", 6, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("King's Birthday", 4, 19, HolidayType.National),
            new Holiday("Independence Day", 9, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ET"] = new List<Holiday>
        {
            new Holiday("Christmas (Genna)", 1, 7, HolidayType.Religious),
            new Holiday("Adwa Victory Day", 3, 2, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Patriots' Day", 5, 5, HolidayType.National),
            new Holiday("Ethiopian New Year", 9, 11, HolidayType.Public),
        };

        h["GA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 2, 18, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GH"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 3, 6, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Republic Day", 7, 1, HolidayType.National),
            new Holiday("Founders' Day", 9, 21, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 10, 2, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Heroes' Day", 1, 20, HolidayType.National),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 24, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["KE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Madaraka Day", 6, 1, HolidayType.National),
            new Holiday("Mashujaa Day", 10, 20, HolidayType.National),
            new Holiday("Jamhuri Day", 12, 12, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Moshoeshoe's Day", 3, 11, HolidayType.National),
            new Holiday("Independence Day", 10, 4, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Armed Forces Day", 2, 11, HolidayType.National),
            new Holiday("Independence Day", 7, 26, HolidayType.National),
            new Holiday("Thanksgiving Day", 11, 7, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LY"] = new List<Holiday>
        {
            new Holiday("Revolution Day", 2, 17, HolidayType.National),
            new Holiday("Independence Day", 12, 24, HolidayType.National),
        };

        h["MG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 6, 26, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("John Chilembwe Day", 1, 15, HolidayType.National),
            new Holiday("Martyrs' Day", 3, 3, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ML"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Army Day", 1, 20, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 22, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 28, HolidayType.National),
        };

        h["MU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Abolition of Slavery Day", 2, 1, HolidayType.National),
            new Holiday("Independence Day", 3, 12, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Manifesto Day", 1, 11, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Throne Day", 7, 30, HolidayType.National),
            new Holiday("Revolution Day", 8, 20, HolidayType.National),
            new Holiday("Independence Day", 11, 18, HolidayType.National),
        };

        h["MZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Heroes' Day", 2, 3, HolidayType.National),
            new Holiday("Women's Day", 4, 7, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 6, 25, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 3, 21, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Africa Day", 5, 25, HolidayType.Public),
            new Holiday("Heroes' Day", 8, 26, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 3, HolidayType.National),
            new Holiday("Republic Day", 12, 18, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Democracy Day", 6, 12, HolidayType.National),
            new Holiday("Independence Day", 10, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["RW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Heroes' Day", 2, 1, HolidayType.National),
            new Holiday("Genocide Memorial Day", 4, 7, HolidayType.Observance),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 1, HolidayType.National),
            new Holiday("Liberation Day", 7, 4, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ST"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 12, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 4, 4, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SC"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Liberation Day", 6, 5, HolidayType.National),
            new Holiday("Constitution Day", 6, 18, HolidayType.National),
            new Holiday("Independence Day", 6, 29, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 4, 27, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 1, HolidayType.National),
        };

        h["ZA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Human Rights Day", 3, 21, HolidayType.National),
            new Holiday("Freedom Day", 4, 27, HolidayType.National),
            new Holiday("Workers' Day", 5, 1, HolidayType.Public),
            new Holiday("Youth Day", 6, 16, HolidayType.National),
            new Holiday("National Women's Day", 8, 9, HolidayType.National),
            new Holiday("Heritage Day", 9, 24, HolidayType.National),
            new Holiday("Day of Reconciliation", 12, 16, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Day of Goodwill", 12, 26, HolidayType.Public),
        };

        h["SS"] = new List<Holiday>
        {
            new Holiday("Independence Day", 7, 9, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SD"] = new List<Holiday>
        {
            new Holiday("Independence Day", 1, 1, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
        };

        h["TZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Zanzibar Revolution Day", 1, 12, HolidayType.National),
            new Holiday("Union Day", 4, 26, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Saba Saba Day", 7, 7, HolidayType.Public),
            new Holiday("Nane Nane Day", 8, 8, HolidayType.Public),
            new Holiday("Independence Day", 12, 9, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 4, 27, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Revolution Day", 1, 14, HolidayType.National),
            new Holiday("Independence Day", 3, 20, HolidayType.National),
            new Holiday("Martyrs' Day", 4, 9, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Republic Day", 7, 25, HolidayType.National),
        };

        h["UG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Liberation Day", 1, 26, HolidayType.National),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Martyrs' Day", 6, 3, HolidayType.Religious),
            new Holiday("Heroes' Day", 6, 9, HolidayType.National),
            new Holiday("Independence Day", 10, 9, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ZM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Women's Day", 3, 8, HolidayType.Public),
            new Holiday("Youth Day", 3, 12, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Africa Day", 5, 25, HolidayType.Public),
            new Holiday("Heroes' Day", 7, 7, HolidayType.National),
            new Holiday("Unity Day", 7, 8, HolidayType.National),
            new Holiday("Farmers' Day", 8, 5, HolidayType.Public),
            new Holiday("Independence Day", 10, 24, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["ZW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 4, 18, HolidayType.National),
            new Holiday("Workers' Day", 5, 1, HolidayType.Public),
            new Holiday("Africa Day", 5, 25, HolidayType.Public),
            new Holiday("Heroes' Day", 8, 11, HolidayType.National),
            new Holiday("Defence Forces Day", 8, 12, HolidayType.National),
            new Holiday("Unity Day", 12, 22, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        // ══════════════════════════════════════════════════════════════
        //  AMERICAS
        // ══════════════════════════════════════════════════════════════

        h["AG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["AR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Carnival", 2, 12, HolidayType.Public),
            new Holiday("Memorial Day", 3, 24, HolidayType.Observance),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("May Revolution Day", 5, 25, HolidayType.National),
            new Holiday("Flag Day", 6, 20, HolidayType.National),
            new Holiday("Independence Day", 7, 9, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 6, 6, HolidayType.Public),
            new Holiday("Independence Day", 7, 10, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["BB"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Errol Barrow Day", 1, 21, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Emancipation Day", 8, 1, HolidayType.National),
            new Holiday("Independence Day", 11, 30, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Heroes Day", 3, 10, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("St. George's Caye Day", 9, 10, HolidayType.National),
            new Holiday("Independence Day", 9, 21, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Plurinational State Day", 1, 22, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 8, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Tiradentes Day", 4, 21, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 7, HolidayType.National),
            new Holiday("Our Lady of Aparecida", 10, 12, HolidayType.Religious),
            new Holiday("All Souls' Day", 11, 2, HolidayType.Religious),
            new Holiday("Republic Day", 11, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Canada Day", 7, 1, HolidayType.National),
            new Holiday("Labour Day", 9, 1, HolidayType.Public),
            new Holiday("National Day for Truth and Reconciliation", 9, 30, HolidayType.Public),
            new Holiday("Remembrance Day", 11, 11, HolidayType.Observance),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Navy Day", 5, 21, HolidayType.National),
            new Holiday("National Day", 9, 18, HolidayType.National),
            new Holiday("Army Day", 9, 19, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 20, HolidayType.National),
            new Holiday("Battle of Boyaca", 8, 7, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Juan Santamaria Day", 4, 11, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CU"] = new List<Holiday>
        {
            new Holiday("Liberation Day", 1, 1, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("National Rebellion Day", 7, 26, HolidayType.National),
            new Holiday("Independence Day", 10, 10, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["DM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 3, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["DO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Duarte Day", 1, 26, HolidayType.National),
            new Holiday("Independence Day", 2, 27, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Restoration Day", 8, 16, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["EC"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Battle of Pichincha", 5, 24, HolidayType.National),
            new Holiday("Independence Day", 8, 10, HolidayType.National),
            new Holiday("Independence of Guayaquil", 10, 9, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SV"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GD"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 2, 7, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Army Day", 6, 30, HolidayType.National),
            new Holiday("Independence Day", 9, 15, HolidayType.National),
            new Holiday("Revolution Day", 10, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Republic Day", 2, 23, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 5, 26, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["HT"] = new List<Holiday>
        {
            new Holiday("Independence Day", 1, 1, HolidayType.National),
            new Holiday("Ancestors' Day", 1, 2, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Flag Day", 5, 18, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["HN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["JM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 23, HolidayType.Public),
            new Holiday("Emancipation Day", 8, 1, HolidayType.National),
            new Holiday("Independence Day", 8, 6, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["MX"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 2, 5, HolidayType.National),
            new Holiday("Benito Juárez's Birthday", 3, 21, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 16, HolidayType.National),
            new Holiday("Revolution Day", 11, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Revolution Day", 7, 19, HolidayType.National),
            new Holiday("Independence Day", 9, 15, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["PA"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Martyrs' Day", 1, 9, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Separation Day", 11, 3, HolidayType.National),
            new Holiday("Flag Day", 11, 4, HolidayType.National),
            new Holiday("Independence Day", 11, 28, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["PY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Heroes' Day", 3, 1, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 5, 14, HolidayType.National),
            new Holiday("Chaco Armistice Day", 6, 12, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["PE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 28, HolidayType.National),
            new Holiday("Santa Rosa de Lima Day", 8, 30, HolidayType.Religious),
            new Holiday("Battle of Angamos", 10, 8, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["KN"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 19, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["LC"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 2, 22, HolidayType.National),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["VC"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 10, 27, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 11, 25, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TT"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 6, 19, HolidayType.Public),
            new Holiday("Emancipation Day", 8, 1, HolidayType.National),
            new Holiday("Independence Day", 8, 31, HolidayType.National),
            new Holiday("Republic Day", 9, 24, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["US"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Martin Luther King Jr. Day", 1, 20, HolidayType.Public),
            new Holiday("Presidents' Day", 2, 17, HolidayType.Public),
            new Holiday("Memorial Day", 5, 26, HolidayType.Public),
            new Holiday("Independence Day", 7, 4, HolidayType.National),
            new Holiday("Labor Day", 9, 1, HolidayType.Public),
            new Holiday("Columbus Day", 10, 13, HolidayType.Public),
            new Holiday("Veterans Day", 11, 11, HolidayType.Public),
            new Holiday("Thanksgiving Day", 11, 27, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["UY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Battle of Las Piedras", 5, 18, HolidayType.National),
            new Holiday("Independence Day", 8, 25, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["VE"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 5, HolidayType.National),
            new Holiday("Simón Bolívar's Birthday", 7, 24, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        // ══════════════════════════════════════════════════════════════
        //  OCEANIA
        // ══════════════════════════════════════════════════════════════

        h["AU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Australia Day", 1, 26, HolidayType.National),
            new Holiday("Anzac Day", 4, 25, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["FJ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Fiji Day", 10, 10, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["KI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 12, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MH"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 5, 1, HolidayType.National),
            new Holiday("Independence Day", 10, 21, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["FM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 5, 10, HolidayType.National),
            new Holiday("Independence Day", 11, 3, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 1, 31, HolidayType.National),
            new Holiday("Constitution Day", 5, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["NZ"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Day after New Year's Day", 1, 2, HolidayType.Public),
            new Holiday("Waitangi Day", 2, 6, HolidayType.National),
            new Holiday("Anzac Day", 4, 25, HolidayType.National),
            new Holiday("Matariki", 6, 20, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["PW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 7, 9, HolidayType.National),
            new Holiday("Independence Day", 10, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["PG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 9, 16, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["WS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 6, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["SB"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 7, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Emancipation Day", 6, 4, HolidayType.National),
            new Holiday("Independence Day", 11, 4, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["TV"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 10, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["VU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Independence Day", 7, 30, HolidayType.National),
            new Holiday("Unity Day", 11, 29, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        // ══════════════════════════════════════════════════════════════
        //  TERRITORIES & DEPENDENCIES
        // ══════════════════════════════════════════════════════════════

        h["AS"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Flag Day", 4, 17, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["AI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Anguilla Day", 5, 30, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["AW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Flag Day", 3, 18, HolidayType.National),
            new Holiday("King's Day", 4, 27, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["BM"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Bermuda Day", 5, 24, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
            new Holiday("Boxing Day", 12, 26, HolidayType.Public),
        };

        h["VG"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Territory Day", 7, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["KY"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Constitution Day", 7, 7, HolidayType.National),
            new Holiday("Remembrance Day", 11, 11, HolidayType.Observance),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CK"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Anzac Day", 4, 25, HolidayType.Observance),
            new Holiday("Constitution Day", 8, 4, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["CW"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Flag Day", 7, 2, HolidayType.National),
            new Holiday("King's Day", 4, 27, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["FK"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Liberation Day", 6, 14, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["FO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Olavsoka", 7, 29, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 9, 10, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GL"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("National Day", 6, 21, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["GU"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Guam Discovery Day", 3, 3, HolidayType.National),
            new Holiday("Liberation Day", 7, 21, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["HK"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("HKSAR Establishment Day", 7, 1, HolidayType.National),
            new Holiday("National Day", 10, 1, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["MO"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Labour Day", 5, 1, HolidayType.Public),
            new Holiday("MSAR Establishment Day", 12, 20, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["PR"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Three Kings Day", 1, 6, HolidayType.Religious),
            new Holiday("Independence Day", 7, 4, HolidayType.National),
            new Holiday("Constitution Day", 7, 25, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        h["VI"] = new List<Holiday>
        {
            new Holiday("New Year's Day", 1, 1, HolidayType.Public),
            new Holiday("Three Kings Day", 1, 6, HolidayType.Religious),
            new Holiday("Transfer Day", 3, 31, HolidayType.National),
            new Holiday("Independence Day", 7, 4, HolidayType.National),
            new Holiday("Christmas Day", 12, 25, HolidayType.Religious),
        };

        return h;
    }
}
