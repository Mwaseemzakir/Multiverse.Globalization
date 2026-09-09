namespace Multiverse.Globalization.Holidays;

/// <summary>
/// How a country moves a public holiday that lands on a weekend.
/// </summary>
public enum HolidayObservanceRule
{
    /// <summary>
    /// The holiday is taken on its calendar date and is simply lost when it falls on a weekend.
    /// The common rule across continental Europe and much of Latin America.
    /// </summary>
    None,

    /// <summary>
    /// A holiday falling on a weekend is observed on the next working day — the "substitute day"
    /// or "bank holiday in lieu" rule used in the UK, Ireland, Australia, New Zealand, Canada,
    /// Japan, Singapore, and Hong Kong.
    /// </summary>
    NextWorkingDay,

    /// <summary>
    /// A Saturday holiday moves back to the preceding Friday and a Sunday holiday moves forward
    /// to the following Monday — the US federal rule.
    /// </summary>
    NearestWorkingDay
}
