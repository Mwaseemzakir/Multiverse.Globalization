namespace Multiverse.Globalization.UnitTests.Holidays;

public class HolidayObservanceTests
{
    // ── Rules ───────────────────────────────────────────────────────

    [Fact]
    public void ObservanceRule_Should_BeNearestWorkingDayForTheUs()
    {
        Assert.Equal(HolidayObservanceRule.NearestWorkingDay, Country.GetCountry("US").ObservanceRule);
    }

    [Theory]
    [InlineData("GB")]
    [InlineData("AU")]
    [InlineData("NZ")]
    [InlineData("SG")]
    public void ObservanceRule_Should_BeNextWorkingDayInCommonLawCountries(string alpha2)
    {
        Assert.Equal(HolidayObservanceRule.NextWorkingDay, Country.GetCountry(alpha2).ObservanceRule);
    }

    [Theory]
    [InlineData("DE")]
    [InlineData("FR")]
    [InlineData("IT")]
    public void ObservanceRule_Should_DefaultToNone(string alpha2)
    {
        Assert.Equal(HolidayObservanceRule.None, Country.GetCountry(alpha2).ObservanceRule);
    }

    // ── US: nearest working day ─────────────────────────────────────

    [Fact]
    public void UsSaturdayHoliday_Should_MoveBackToTheFriday()
    {
        // 4 July 2026 falls on a Saturday, so the federal holiday is taken on Friday 3 July.
        var us = Country.GetCountry("US");

        var independenceDay = us.GetHolidays(2026).Single(h => h.Name == "Independence Day");

        Assert.Equal(new DateTime(2026, 7, 4), independenceDay.Date);
        Assert.Equal(new DateTime(2026, 7, 3), independenceDay.ObservedDate);
        Assert.True(independenceDay.IsSubstituted);
        Assert.True(us.IsHoliday(new DateTime(2026, 7, 3)));
    }

    [Fact]
    public void UsSundayHoliday_Should_MoveForwardToTheMonday()
    {
        // 4 July 2027 falls on a Sunday, so the holiday is taken on Monday 5 July.
        var us = Country.GetCountry("US");

        var independenceDay = us.GetHolidays(2027).Single(h => h.Name == "Independence Day");

        Assert.Equal(new DateTime(2027, 7, 5), independenceDay.ObservedDate);
        Assert.True(us.IsHoliday(new DateTime(2027, 7, 5)));
    }

    [Fact]
    public void UsWeekdayHoliday_Should_NotMove()
    {
        // Christmas Day 2026 is a Friday and stays put.
        var us = Country.GetCountry("US");

        var christmas = us.GetHolidays(2026).Single(h => h.Name == "Christmas Day");

        Assert.Equal(new DateTime(2026, 12, 25), christmas.ObservedDate);
        Assert.False(christmas.IsSubstituted);
    }

    // ── UK: next working day, including the double substitution ─────

    [Fact]
    public void UkChristmasAndBoxingDay_Should_BothGetDistinctSubstituteDays()
    {
        // Christmas Day 2027 is a Saturday and Boxing Day a Sunday, so the substitute days
        // are Monday 27 and Tuesday 28 December — the classic double bank holiday in lieu.
        var gb = Country.GetCountry("GB");
        var holidays = gb.GetHolidays(2027);

        var christmas = holidays.Single(h => h.Name == "Christmas Day");
        var boxingDay = holidays.Single(h => h.Name == "Boxing Day");

        Assert.Equal(new DateTime(2027, 12, 27), christmas.ObservedDate);
        Assert.Equal(new DateTime(2027, 12, 28), boxingDay.ObservedDate);

        Assert.True(gb.IsHoliday(new DateTime(2027, 12, 27)));
        Assert.True(gb.IsHoliday(new DateTime(2027, 12, 28)));
    }

    [Fact]
    public void UkNewYearsDay_Should_MoveToTheMondayWhenItFallsOnASaturday()
    {
        // 1 January 2028 is a Saturday.
        var gb = Country.GetCountry("GB");

        var newYear = gb.GetHolidays(2028).Single(h => h.Name == "New Year's Day");

        Assert.Equal(new DateTime(2028, 1, 3), newYear.ObservedDate);
    }

    // ── No substitution ─────────────────────────────────────────────

    [Fact]
    public void GermanHoliday_Should_StayOnItsCalendarDateOverAWeekend()
    {
        var de = Country.GetCountry("DE");

        var christmas = de.GetHolidays(2027).Single(h => h.Name == "Christmas Day");

        Assert.Equal(new DateTime(2027, 12, 25), christmas.Date);
        Assert.Equal(new DateTime(2027, 12, 25), christmas.ObservedDate);
        Assert.False(christmas.IsSubstituted);
    }

    // ── Observances are not days off ────────────────────────────────

    [Fact]
    public void EasterSunday_Should_NotProduceASubstituteMondayInTheUs()
    {
        // Easter Sunday is an observance in the US, not a federal day off, so the
        // Saturday/Sunday substitution rule must not apply to it.
        var us = Country.GetCountry("US");

        var easter = us.GetHolidays(2026).Single(h => h.Name == "Easter Sunday");

        Assert.Equal(HolidayType.Observance, easter.Type);
        Assert.Equal(easter.Date, easter.ObservedDate);
        Assert.False(easter.IsSubstituted);
        Assert.False(us.IsHoliday(easter.Date));
        Assert.False(us.IsHoliday(easter.Date.AddDays(1)));
    }

    [Fact]
    public void GetHolidaysOn_Should_StillSurfaceObservances()
    {
        var us = Country.GetCountry("US");
        var easter = us.GetHolidays(2026).Single(h => h.Name == "Easter Sunday");

        Assert.Contains(us.GetHolidaysOn(easter.Date), h => h.Name == "Easter Sunday");
    }

    // ── Substituted days never collide ──────────────────────────────

    [Fact]
    public void SubstituteDays_Should_NeverLandOnAWeekendOrACollision()
    {
        foreach (var country in Country.GetCurrent())
        {
            if (country.ObservanceRule == HolidayObservanceRule.None)
                continue;

            var taken = new HashSet<DateTime>();

            foreach (var holiday in country.GetHolidays(2027))
            {
                if (!holiday.IsSubstituted)
                    continue;

                Assert.False(
                    country.IsWeekend(holiday.ObservedDate),
                    $"{country.Alpha2Code}: {holiday.Name} was substituted onto a weekend.");

                Assert.True(
                    taken.Add(holiday.ObservedDate),
                    $"{country.Alpha2Code}: two holidays were substituted onto {holiday.ObservedDate:yyyy-MM-dd}.");
            }
        }
    }
}
