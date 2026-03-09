using System;
using System.Collections.Generic;
using Multiverse.Globalization.Holidays;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Provides movable (date-varies-by-year) holiday data for countries.
/// </summary>
public static class MovableHolidayHelper
{
    private static readonly Dictionary<string, List<MovableHoliday>> _data = InitializeData();

    internal static IReadOnlyList<MovableHoliday> GetMovableHolidaysForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return new List<MovableHoliday>();
        return _data.TryGetValue(alpha2Code.ToUpperInvariant(), out var list)
            ? list.AsReadOnly()
            : new List<MovableHoliday>();
    }

    private static Dictionary<string, List<MovableHoliday>> InitializeData()
    {
        var d = new Dictionary<string, List<MovableHoliday>>();

        // ---------- United States ----------
        d["US"] = new List<MovableHoliday>
        {
            new("Martin Luther King Jr. Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 1, DayOfWeek.Monday, 3)),
            new("Presidents' Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 2, DayOfWeek.Monday, 3)),
            new("Memorial Day", HolidayType.National,
                year => MovableHoliday.LastWeekdayOfMonth(year, 5, DayOfWeek.Monday)),
            new("Labor Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 9, DayOfWeek.Monday, 1)),
            new("Columbus Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 10, DayOfWeek.Monday, 2)),
            new("Thanksgiving Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 11, DayOfWeek.Thursday, 4)),
            new("Easter Sunday", HolidayType.Observance,
                year => MovableHoliday.ComputeEasterSunday(year)),
        };

        // ---------- Canada ----------
        d["CA"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Victoria Day", HolidayType.National,
                year => MovableHoliday.LastWeekdayBefore(year, 5, 25, DayOfWeek.Monday)),
            new("Labour Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 9, DayOfWeek.Monday, 1)),
            new("Thanksgiving Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 10, DayOfWeek.Monday, 2)),
        };

        // ---------- United Kingdom ----------
        d["GB"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Early May Bank Holiday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 5, DayOfWeek.Monday, 1)),
            new("Spring Bank Holiday", HolidayType.National,
                year => MovableHoliday.LastWeekdayOfMonth(year, 5, DayOfWeek.Monday)),
            new("Summer Bank Holiday", HolidayType.National,
                year => MovableHoliday.LastWeekdayOfMonth(year, 8, DayOfWeek.Monday)),
        };

        // ---------- Germany ----------
        d["DE"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- France ----------
        d["FR"] = new List<MovableHoliday>
        {
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Italy ----------
        d["IT"] = new List<MovableHoliday>
        {
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Spain ----------
        d["ES"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.Observance,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Australia ----------
        d["AU"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Saturday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-1); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Queen's Birthday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 6, DayOfWeek.Monday, 2)),
        };

        // ---------- New Zealand ----------
        d["NZ"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Queen's Birthday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 6, DayOfWeek.Monday, 1)),
            new("Labour Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 10, DayOfWeek.Monday, 4)),
        };

        // ---------- Brazil ----------
        d["BR"] = new List<MovableHoliday>
        {
            new("Carnival", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        };

        // ---------- India ----------
        d["IN"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        };

        // ---------- Mexico ----------
        d["MX"] = new List<MovableHoliday>
        {
            new("Benito Juárez's Birthday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 3, DayOfWeek.Monday, 3)),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Revolution Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 11, DayOfWeek.Monday, 3)),
        };

        // ---------- South Korea ----------
        d["KR"] = new List<MovableHoliday>
        {
            new("Buddha's Birthday", HolidayType.National,
                year => null), // Requires lunar calendar, date varies
        };

        // ---------- South Africa ----------
        d["ZA"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Family Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Poland ----------
        d["PL"] = new List<MovableHoliday>
        {
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        };

        // ---------- Netherlands ----------
        d["NL"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Sunday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(49); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Switzerland ----------
        d["CH"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Pakistan ----------
        d["PK"] = new List<MovableHoliday>
        {
            // Islamic holidays: approximate dates, not computable with simple algorithm
            // Users should check actual published dates for each year
        };

        // ---------- Ireland ----------
        d["IE"] = new List<MovableHoliday>
        {
            new("St. Patrick's Day (observed)", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 3, DayOfWeek.Monday, 3)), // Closest Monday
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("May Bank Holiday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 5, DayOfWeek.Monday, 1)),
            new("June Bank Holiday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 6, DayOfWeek.Monday, 1)),
            new("August Bank Holiday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 8, DayOfWeek.Monday, 1)),
            new("October Bank Holiday", HolidayType.National,
                year => MovableHoliday.LastWeekdayOfMonth(year, 10, DayOfWeek.Monday)),
        };

        // ---------- Austria ----------
        d["AT"] = new List<MovableHoliday>
        {
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        };

        // ---------- Belgium ----------
        d["BE"] = new List<MovableHoliday>
        {
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Portugal ----------
        d["PT"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        };

        // ---------- Sweden ----------
        d["SE"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
        };

        // ---------- Norway ----------
        d["NO"] = new List<MovableHoliday>
        {
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Denmark ----------
        d["DK"] = new List<MovableHoliday>
        {
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("General Prayer Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(26); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Finland ----------
        d["FI"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Midsummer Eve", HolidayType.National,
                year => MovableHoliday.LastWeekdayBefore(year, 6, 26, DayOfWeek.Friday)),
        };

        // ---------- Czech Republic ----------
        d["CZ"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Hungary ----------
        d["HU"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Romania ----------
        d["RO"] = new List<MovableHoliday>
        {
            // Romanian Orthodox Easter uses Julian calendar calculation, dates differ from Western Easter
            new("Good Friday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Greece ----------
        d["GR"] = new List<MovableHoliday>
        {
            new("Clean Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-48); }),
            new("Good Friday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Colombia ----------
        d["CO"] = new List<MovableHoliday>
        {
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(43); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(64); }),
            new("Sacred Heart", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(71); }),
        };

        // ---------- Argentina ----------
        d["AR"] = new List<MovableHoliday>
        {
            new("Carnival Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-48); }),
            new("Carnival Tuesday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        };

        // ---------- Chile ----------
        d["CL"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Holy Saturday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-1); }),
        };

        // ---------- Peru ----------
        d["PE"] = new List<MovableHoliday>
        {
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        };

        // ---------- Philippines ----------
        d["PH"] = new List<MovableHoliday>
        {
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Black Saturday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-1); }),
        };

        // ---------- Indonesia ----------
        d["ID"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.Religious,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Ascension Day", HolidayType.Religious,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
        };

        // ---------- Japan ----------
        d["JP"] = new List<MovableHoliday>
        {
            new("Coming of Age Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 1, DayOfWeek.Monday, 2)),
            new("Marine Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 7, DayOfWeek.Monday, 3)),
            new("Respect for the Aged Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 9, DayOfWeek.Monday, 3)),
            new("Sports Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 10, DayOfWeek.Monday, 2)),
        };

        // ---------- Thailand ----------
        d["TH"] = new List<MovableHoliday>
        {
            // Buddhist holidays follow lunar calendar; not easily computable
        };

        // ---------- Turkey ----------
        d["TR"] = new List<MovableHoliday>
        {
            // Islamic holidays (Eid al-Fitr, Eid al-Adha) follow the Hijri calendar
            // and cannot be computed with a simple Gregorian algorithm
        };

        // ---------- Kenya ----------
        d["KE"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Nigeria ----------
        d["NG"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Ghana ----------
        d["GH"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Singapore ----------
        d["SG"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        };

        // ---------- Croatia ----------
        d["HR"] = new List<MovableHoliday>
        {
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        };

        // ---------- Slovakia ----------
        d["SK"] = new List<MovableHoliday>
        {
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        };

        // ---------- Luxembourg ----------
        d["LU"] = new List<MovableHoliday>
        {
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        };

        // ---------- Ecuador ----------
        d["EC"] = new List<MovableHoliday>
        {
            new("Carnival", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        };

        // ---------- Venezuela ----------
        d["VE"] = new List<MovableHoliday>
        {
            new("Carnival Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-48); }),
            new("Carnival Tuesday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        };

        return d;
    }
}
