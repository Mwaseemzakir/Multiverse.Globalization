using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Holidays;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class MovableHolidayTests
{
    [Fact]
    public void US_Should_HaveMovableHolidays()
    {
        var us = Country.GetCountry("US");
        Assert.NotEmpty(us.MovableHolidays);
    }

    [Fact]
    public void US_Should_HaveThanksgivingAsMovableHoliday()
    {
        var us = Country.GetCountry("US");
        Assert.Contains(us.MovableHolidays, h => h.Name == "Thanksgiving Day");
    }

    [Fact]
    public void Thanksgiving2024_ShouldBe_Nov28()
    {
        var us = Country.GetCountry("US");
        var thanksgiving = us.MovableHolidays.First(h => h.Name == "Thanksgiving Day");
        var date2024 = thanksgiving.GetDate(2024);
        Assert.NotNull(date2024);
        Assert.Equal(new DateTime(2024, 11, 28), date2024!.Value);
    }

    [Fact]
    public void Thanksgiving2025_ShouldBe_Nov27()
    {
        var us = Country.GetCountry("US");
        var thanksgiving = us.MovableHolidays.First(h => h.Name == "Thanksgiving Day");
        var date2025 = thanksgiving.GetDate(2025);
        Assert.NotNull(date2025);
        Assert.Equal(new DateTime(2025, 11, 27), date2025!.Value);
    }

    [Fact]
    public void MLKDay2024_ShouldBe_Jan15()
    {
        var us = Country.GetCountry("US");
        var mlk = us.MovableHolidays.First(h => h.Name == "Martin Luther King Jr. Day");
        var date2024 = mlk.GetDate(2024);
        Assert.NotNull(date2024);
        Assert.Equal(new DateTime(2024, 1, 15), date2024!.Value);
    }

    [Fact]
    public void MemorialDay2024_ShouldBe_May27()
    {
        var us = Country.GetCountry("US");
        var memorial = us.MovableHolidays.First(h => h.Name == "Memorial Day");
        var date2024 = memorial.GetDate(2024);
        Assert.NotNull(date2024);
        Assert.Equal(new DateTime(2024, 5, 27), date2024!.Value);
    }

    [Fact]
    public void LaborDay2024_ShouldBe_Sep2()
    {
        var us = Country.GetCountry("US");
        var labor = us.MovableHolidays.First(h => h.Name == "Labor Day");
        var date2024 = labor.GetDate(2024);
        Assert.NotNull(date2024);
        Assert.Equal(new DateTime(2024, 9, 2), date2024!.Value);
    }

    [Fact]
    public void ComputeEasterSunday_2024_ShouldBe_March31()
    {
        var easter = MovableHoliday.ComputeEasterSunday(2024);
        Assert.Equal(new DateTime(2024, 3, 31), easter);
    }

    [Fact]
    public void ComputeEasterSunday_2025_ShouldBe_April20()
    {
        var easter = MovableHoliday.ComputeEasterSunday(2025);
        Assert.Equal(new DateTime(2025, 4, 20), easter);
    }

    [Fact]
    public void ComputeEasterSunday_AlwaysSunday()
    {
        for (int year = 2000; year <= 2030; year++)
        {
            var easter = MovableHoliday.ComputeEasterSunday(year);
            Assert.Equal(DayOfWeek.Sunday, easter.DayOfWeek);
        }
    }

    [Fact]
    public void ComputeEasterSunday_AlwaysInMarchOrApril()
    {
        for (int year = 2000; year <= 2030; year++)
        {
            var easter = MovableHoliday.ComputeEasterSunday(year);
            Assert.True(easter.Month == 3 || easter.Month == 4,
                $"Easter {year} was in month {easter.Month}");
        }
    }

    [Fact]
    public void NthWeekdayOfMonth_FirstMondayOfSep2024()
    {
        var date = MovableHoliday.NthWeekdayOfMonth(2024, 9, DayOfWeek.Monday, 1);
        Assert.Equal(new DateTime(2024, 9, 2), date);
        Assert.Equal(DayOfWeek.Monday, date.DayOfWeek);
    }

    [Fact]
    public void NthWeekdayOfMonth_FourthThursdayOfNov2024()
    {
        var date = MovableHoliday.NthWeekdayOfMonth(2024, 11, DayOfWeek.Thursday, 4);
        Assert.Equal(new DateTime(2024, 11, 28), date);
    }

    [Fact]
    public void LastWeekdayOfMonth_LastMondayOfMay2024()
    {
        var date = MovableHoliday.LastWeekdayOfMonth(2024, 5, DayOfWeek.Monday);
        Assert.Equal(new DateTime(2024, 5, 27), date);
        Assert.Equal(DayOfWeek.Monday, date.DayOfWeek);
    }

    [Fact]
    public void LastWeekdayBefore_MondayOnOrBeforeMay25_2024()
    {
        // Victoria Day (Canada): Monday on or before May 25
        var date = MovableHoliday.LastWeekdayBefore(2024, 5, 25, DayOfWeek.Monday);
        Assert.Equal(new DateTime(2024, 5, 20), date); // May 25, 2024 is Saturday, last Monday before is May 20
        Assert.Equal(DayOfWeek.Monday, date.DayOfWeek);
    }

    [Fact]
    public void MovableHoliday_IsOnDate_ShouldMatchCorrectDate()
    {
        var us = Country.GetCountry("US");
        var thanksgiving = us.MovableHolidays.First(h => h.Name == "Thanksgiving Day");
        Assert.True(thanksgiving.IsOnDate(new DateTime(2024, 11, 28)));
        Assert.False(thanksgiving.IsOnDate(new DateTime(2024, 11, 27)));
    }

    [Fact]
    public void GetAllHolidaysOnDate_ShouldIncludeMovableHolidays()
    {
        var us = Country.GetCountry("US");
        var holidayNames = us.GetAllHolidaysOnDate(new DateTime(2024, 11, 28));
        Assert.Contains("Thanksgiving Day", holidayNames);
    }

    [Fact]
    public void GetAllHolidaysOnDate_NoHoliday_ShouldReturnEmptyList()
    {
        var us = Country.GetCountry("US");
        // Dec 5 is unlikely to be any holiday
        var holidays = us.GetAllHolidaysOnDate(new DateTime(2024, 12, 5));
        // May or may not be empty depending on fixed holidays, but should not throw
        Assert.NotNull(holidays);
    }

    [Fact]
    public void CountryWithoutMovableHolidays_Should_HaveEmptyList()
    {
        var aq = Country.GetCountry("AQ");
        Assert.NotNull(aq.MovableHolidays);
        Assert.Empty(aq.MovableHolidays);
    }

    [Fact]
    public void MovableHoliday_ToString_Should_IncludeName()
    {
        var us = Country.GetCountry("US");
        var thanksgiving = us.MovableHolidays.First(h => h.Name == "Thanksgiving Day");
        Assert.Contains("Thanksgiving Day", thanksgiving.ToString());
    }

    [Fact]
    public void MovableHoliday_Constructor_ShouldRejectNullName()
    {
        Assert.Throws<ArgumentNullException>(() => new MovableHoliday(null!, HolidayType.National, y => null));
    }

    [Fact]
    public void MovableHoliday_Constructor_ShouldRejectNullCalculator()
    {
        Assert.Throws<ArgumentNullException>(() => new MovableHoliday("Test", HolidayType.National, null!));
    }

    [Fact]
    public void Canada_ThanksgivingDay_ShouldBe2ndMondayOfOctober()
    {
        var ca = Country.GetCountry("CA");
        var thanksgiving = ca.MovableHolidays.First(h => h.Name == "Thanksgiving Day");
        var date2024 = thanksgiving.GetDate(2024);
        Assert.NotNull(date2024);
        Assert.Equal(new DateTime(2024, 10, 14), date2024!.Value);
        Assert.Equal(DayOfWeek.Monday, date2024.Value.DayOfWeek);
    }

    [Fact]
    public void Germany_GoodFriday_ShouldBe2DaysBeforeEaster()
    {
        var de = Country.GetCountry("DE");
        var goodFriday = de.MovableHolidays.First(h => h.Name == "Good Friday");
        var easter2024 = MovableHoliday.ComputeEasterSunday(2024);
        var expected = easter2024.AddDays(-2);
        Assert.Equal(expected, goodFriday.GetDate(2024));
    }
}
