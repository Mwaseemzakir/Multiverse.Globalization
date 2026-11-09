namespace Multiverse.Globalization.Holidays;

/// <summary>
/// Provides the substitute-holiday rule each country applies when a public holiday
/// falls on a weekend.
/// <para>
/// <see cref="HolidayObservanceRule.None"/> is the default and is stored implicitly;
/// only countries that shift holidays carry an explicit entry.
/// </para>
/// </summary>
public static class HolidayObservanceHelper
{
    private static readonly Dictionary<string, HolidayObservanceRule> _data = InitializeData();

    internal static HolidayObservanceRule GetRuleForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return HolidayObservanceRule.None;

        return _data.TryGetValue(alpha2Code, out var rule)
            ? rule
            : HolidayObservanceRule.None;
    }

    /// <summary>
    /// Countries that shift weekend holidays, keyed by alpha-2 code.
    /// Countries absent from this map observe holidays on their calendar date.
    /// </summary>
    public static IReadOnlyDictionary<string, HolidayObservanceRule> Rules => _data;

    private static Dictionary<string, HolidayObservanceRule> InitializeData()
    {
        return new Dictionary<string, HolidayObservanceRule>(StringComparer.OrdinalIgnoreCase)
        {
            // Saturday moves back to Friday, Sunday moves forward to Monday.
            ["US"] = HolidayObservanceRule.NearestWorkingDay,

            // A weekend holiday is picked up on the next working day.
            ["AU"] = HolidayObservanceRule.NextWorkingDay,
            ["CA"] = HolidayObservanceRule.NextWorkingDay,
            ["GB"] = HolidayObservanceRule.NextWorkingDay,
            ["HK"] = HolidayObservanceRule.NextWorkingDay,
            ["IE"] = HolidayObservanceRule.NextWorkingDay,
            ["JP"] = HolidayObservanceRule.NextWorkingDay,
            ["KE"] = HolidayObservanceRule.NextWorkingDay,
            ["MY"] = HolidayObservanceRule.NextWorkingDay,
            ["NG"] = HolidayObservanceRule.NextWorkingDay,
            ["NZ"] = HolidayObservanceRule.NextWorkingDay,
            ["SG"] = HolidayObservanceRule.NextWorkingDay,
            ["ZA"] = HolidayObservanceRule.NextWorkingDay,
        };
    }
}
