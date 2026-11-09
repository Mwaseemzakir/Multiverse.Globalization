namespace Multiverse.Globalization.Countries;

/// <summary>
/// Provides the days that make up the weekend in each country.
/// <para>
/// Saturday and Sunday are the default and are stored implicitly; only countries that deviate
/// carry an explicit entry. See DATA_SOURCES.md for the coverage and caveats of this dataset.
/// </para>
/// </summary>
public static class WeekendHelper
{
    private static readonly DayOfWeek[] SaturdaySunday = [DayOfWeek.Saturday, DayOfWeek.Sunday];
    private static readonly DayOfWeek[] FridaySaturday = [DayOfWeek.Friday, DayOfWeek.Saturday];
    private static readonly DayOfWeek[] FridayOnly = [DayOfWeek.Friday];
    private static readonly DayOfWeek[] SaturdayOnly = [DayOfWeek.Saturday];
    private static readonly DayOfWeek[] FridaySunday = [DayOfWeek.Friday, DayOfWeek.Sunday];

    private static readonly Dictionary<string, IReadOnlyList<DayOfWeek>> _data = InitializeData();

    /// <summary>The weekend observed in most of the world: Saturday and Sunday.</summary>
    public static IReadOnlyList<DayOfWeek> Default => SaturdaySunday;

    internal static IReadOnlyList<DayOfWeek> GetWeekendDaysForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return SaturdaySunday;

        return _data.TryGetValue(alpha2Code.ToUpperInvariant(), out var days)
            ? days
            : SaturdaySunday;
    }

    /// <summary>
    /// Countries whose weekend differs from Saturday–Sunday, keyed by alpha-2 code.
    /// Countries absent from this map observe <see cref="Default"/>.
    /// </summary>
    public static IReadOnlyDictionary<string, IReadOnlyList<DayOfWeek>> Exceptions => _data;

    private static Dictionary<string, IReadOnlyList<DayOfWeek>> InitializeData()
    {
        return new Dictionary<string, IReadOnlyList<DayOfWeek>>(StringComparer.OrdinalIgnoreCase)
        {
            // ── Friday–Saturday weekend ───────────────────────────────────
            ["BD"] = FridaySaturday, // Bangladesh
            ["BH"] = FridaySaturday, // Bahrain
            ["DJ"] = FridaySaturday, // Djibouti
            ["DZ"] = FridaySaturday, // Algeria
            ["EG"] = FridaySaturday, // Egypt
            ["IL"] = FridaySaturday, // Israel — Shabbat
            ["IQ"] = FridaySaturday, // Iraq
            ["JO"] = FridaySaturday, // Jordan
            ["KW"] = FridaySaturday, // Kuwait
            ["LY"] = FridaySaturday, // Libya
            ["MV"] = FridaySaturday, // Maldives
            ["OM"] = FridaySaturday, // Oman
            ["PS"] = FridaySaturday, // Palestine
            ["QA"] = FridaySaturday, // Qatar
            ["SA"] = FridaySaturday, // Saudi Arabia
            ["SD"] = FridaySaturday, // Sudan
            ["SO"] = FridaySaturday, // Somalia
            ["SY"] = FridaySaturday, // Syria
            ["YE"] = FridaySaturday, // Yemen

            // ── Single-day weekends ───────────────────────────────────────
            ["IR"] = FridayOnly,   // Iran — Thursday is a half day in some sectors
            ["NP"] = SaturdayOnly, // Nepal

            // ── Split weekend ─────────────────────────────────────────────
            ["BN"] = FridaySunday, // Brunei — Saturday is a working day
        };
    }
}
