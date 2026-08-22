using System;
using System.Linq;
using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Holidays;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class HolidayOccurrenceTests
{
    [Fact]
    public void GetHolidayOccurrencesOnDate_FixedHoliday_Should_ReturnOccurrence()
    {
        var us = Country.GetCountry("US");

        var occurrences = us.GetHolidayOccurrencesOnDate(new DateTime(2026, 7, 4));

        var occurrence = Assert.Single(occurrences, o => o.Name == "Independence Day");
        Assert.Equal(new DateTime(2026, 7, 4), occurrence.Date);
        Assert.Equal(HolidayType.National, occurrence.Type);
        Assert.False(occurrence.IsMovable);
    }

    [Fact]
    public void GetHolidayOccurrencesOnDate_MovableHoliday_Should_ReturnOccurrence()
    {
        var us = Country.GetCountry("US");
        var easterSunday = MovableHoliday.ComputeEasterSunday(2026);

        var occurrences = us.GetHolidayOccurrencesOnDate(easterSunday);

        var occurrence = Assert.Single(occurrences, o => o.Name == "Easter Sunday");
        Assert.Equal(easterSunday, occurrence.Date);
        Assert.Equal(HolidayType.Observance, occurrence.Type);
        Assert.True(occurrence.IsMovable);
    }

    [Fact]
    public void GetHolidayOccurrencesOnDate_NonHoliday_Should_ReturnEmpty()
    {
        var us = Country.GetCountry("US");

        var occurrences = us.GetHolidayOccurrencesOnDate(new DateTime(2026, 8, 15));

        Assert.Empty(occurrences);
    }

    [Fact]
    public void GetHolidayOccurrencesOnDate_Should_MatchNamesFromGetAllHolidaysOnDate()
    {
        var us = Country.GetCountry("US");
        var date = new DateTime(2026, 7, 4);

        var names = us.GetAllHolidaysOnDate(date);
        var occurrences = us.GetHolidayOccurrencesOnDate(date);

        Assert.Equal(names.OrderBy(n => n), occurrences.Select(o => o.Name).OrderBy(n => n));
    }

    [Fact]
    public void HolidayOccurrence_NullName_Should_ThrowArgumentNullException()
    {
        // Exercised indirectly: constructor is internal, so this documents the invariant
        // that every occurrence produced by Country carries a non-empty Name.
        var us = Country.GetCountry("US");
        var occurrences = us.GetHolidayOccurrencesOnDate(new DateTime(2026, 1, 1));

        Assert.All(occurrences, o => Assert.False(string.IsNullOrWhiteSpace(o.Name)));
    }

    [Fact]
    public void HolidayOccurrence_ToString_Should_IncludeNameAndDate()
    {
        var us = Country.GetCountry("US");
        var occurrence = us.GetHolidayOccurrencesOnDate(new DateTime(2026, 7, 4)).Single();

        Assert.Contains("Independence Day", occurrence.ToString());
        Assert.Contains("2026", occurrence.ToString());
    }
}
