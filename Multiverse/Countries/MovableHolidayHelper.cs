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
            return [];
        return _data.TryGetValue(alpha2Code.ToUpperInvariant(), out var list)
            ? list.AsReadOnly()
            : new List<MovableHoliday>();
    }

    /// <summary>All movable-holiday rules keyed by country alpha-2 code.</summary>
    public static IReadOnlyDictionary<string, List<MovableHoliday>> All => _data;

    private static Dictionary<string, List<MovableHoliday>> InitializeData()
    {
        var d = new Dictionary<string, List<MovableHoliday>>
        {
            // ---------- United States ----------
            ["US"] =
        [
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
        ],

            // ---------- Canada ----------
            ["CA"] =
        [
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
        ],

            // ---------- United Kingdom ----------
            ["GB"] =
        [
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
        ],

            // ---------- Germany ----------
            ["DE"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- France ----------
            ["FR"] =
        [
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Italy ----------
            ["IT"] =
        [
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Spain ----------
            ["ES"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.Observance,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Australia ----------
            ["AU"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Saturday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-1); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Queen's Birthday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 6, DayOfWeek.Monday, 2)),
        ],

            // ---------- New Zealand ----------
            ["NZ"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Queen's Birthday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 6, DayOfWeek.Monday, 1)),
            new("Labour Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 10, DayOfWeek.Monday, 4)),
        ],

            // ---------- Brazil ----------
            ["BR"] =
        [
            new("Carnival", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        ],

            // ---------- India ----------
            ["IN"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        ],

            // ---------- Mexico ----------
            ["MX"] =
        [
            new("Benito Juárez's Birthday", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 3, DayOfWeek.Monday, 3)),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Revolution Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 11, DayOfWeek.Monday, 3)),
        ],

            // ---------- South Korea ----------
            ["KR"] =
        [
            new("Buddha's Birthday", HolidayType.National,
                _ => null), // Requires lunar calendar, date varies
        ],

            // ---------- South Africa ----------
            ["ZA"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Family Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Poland ----------
            ["PL"] =
        [
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        ],

            // ---------- Netherlands ----------
            ["NL"] =
        [
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
        ],

            // ---------- Switzerland ----------
            ["CH"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Pakistan ----------
            ["PK"] = [],

            // ---------- Ireland ----------
            ["IE"] =
        [
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
        ],

            // ---------- Austria ----------
            ["AT"] =
        [
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        ],

            // ---------- Belgium ----------
            ["BE"] =
        [
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Portugal ----------
            ["PT"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        ],

            // ---------- Sweden ----------
            ["SE"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
        ],

            // ---------- Norway ----------
            ["NO"] =
        [
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
        ],

            // ---------- Denmark ----------
            ["DK"] =
        [
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
        ],

            // ---------- Finland ----------
            ["FI"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Midsummer Eve", HolidayType.National,
                year => MovableHoliday.LastWeekdayBefore(year, 6, 26, DayOfWeek.Friday)),
        ],

            // ---------- Czech Republic ----------
            ["CZ"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Hungary ----------
            ["HU"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Romania ----------
            ["RO"] =
        [
            // Romanian Orthodox Easter uses Julian calendar calculation, dates differ from Western Easter
            new("Good Friday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Greece ----------
            ["GR"] =
        [
            new("Clean Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-48); }),
            new("Good Friday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday (Orthodox)", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Colombia ----------
            ["CO"] =
        [
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
        ],

            // ---------- Argentina ----------
            ["AR"] =
        [
            new("Carnival Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-48); }),
            new("Carnival Tuesday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        ],

            // ---------- Chile ----------
            ["CL"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Holy Saturday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-1); }),
        ],

            // ---------- Peru ----------
            ["PE"] =
        [
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        ],

            // ---------- Philippines ----------
            ["PH"] =
        [
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Black Saturday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-1); }),
        ],

            // ---------- Indonesia ----------
            ["ID"] =
        [
            new("Good Friday", HolidayType.Religious,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Ascension Day", HolidayType.Religious,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
        ],

            // ---------- Japan ----------
            ["JP"] =
        [
            new("Coming of Age Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 1, DayOfWeek.Monday, 2)),
            new("Marine Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 7, DayOfWeek.Monday, 3)),
            new("Respect for the Aged Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 9, DayOfWeek.Monday, 3)),
            new("Sports Day", HolidayType.National,
                year => MovableHoliday.NthWeekdayOfMonth(year, 10, DayOfWeek.Monday, 2)),
        ],

            // ---------- Thailand ----------
            ["TH"] = [],

            // ---------- Turkey ----------
            ["TR"] = [],

            // ---------- Kenya ----------
            ["KE"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Nigeria ----------
            ["NG"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Ghana ----------
            ["GH"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Singapore ----------
            ["SG"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        ],

            // ---------- Croatia ----------
            ["HR"] =
        [
            new("Easter Sunday", HolidayType.National,
                year => MovableHoliday.ComputeEasterSunday(year)),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Corpus Christi", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(60); }),
        ],

            // ---------- Slovakia ----------
            ["SK"] =
        [
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
        ],

            // ---------- Luxembourg ----------
            ["LU"] =
        [
            new("Easter Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(1); }),
            new("Ascension Day", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(39); }),
            new("Whit Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(50); }),
        ],

            // ---------- Ecuador ----------
            ["EC"] =
        [
            new("Carnival", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        ],

            // ---------- Venezuela ----------
            ["VE"] =
        [
            new("Carnival Monday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-48); }),
            new("Carnival Tuesday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-47); }),
            new("Maundy Thursday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-3); }),
            new("Good Friday", HolidayType.National,
                year => { var e = MovableHoliday.ComputeEasterSunday(year); return e.AddDays(-2); }),
        ]
        };

        return d;
    }
}
