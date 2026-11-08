namespace Multiverse.Globalization.UnitTests.Holidays;

public class BusinessDayTests
{
    // ── GetHolidays(year) ───────────────────────────────────────────

    [Fact]
    public void GetHolidays_Should_ResolveMovableHolidaysToConcreteDates()
    {
        var us = Country.GetCountry("US");

        var thanksgiving = us.GetHolidays(2026).Single(h => h.Name == "Thanksgiving Day");

        // Fourth Thursday of November 2026.
        Assert.Equal(new DateTime(2026, 11, 26), thanksgiving.Date);
        Assert.True(thanksgiving.IsMovable);
    }

    [Fact]
    public void GetHolidays_Should_PreferTheMovableRuleOverAStaleFixedDate()
    {
        // US data lists Thanksgiving both as a fixed 27 November entry and as a movable rule.
        // The rule is the accurate one, so only one occurrence should be reported.
        var us = Country.GetCountry("US");

        var thanksgivings = us.GetHolidays(2026).Where(h => h.Name == "Thanksgiving Day").ToList();

        Assert.Single(thanksgivings);
        Assert.True(thanksgivings[0].IsMovable);
    }

    [Fact]
    public void GetHolidays_Should_NotReportDuplicateNamesForAnyCountry()
    {
        foreach (var country in Country.GetCurrent())
        {
            var duplicates = country.GetHolidays(2026)
                .GroupBy(h => h.Name, StringComparer.OrdinalIgnoreCase)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            Assert.True(
                duplicates.Count == 0,
                $"{country.Alpha2Code} reports duplicates: {string.Join(", ", duplicates)}");
        }
    }

    [Fact]
    public void GetHolidays_Should_ReturnOccurrencesInChronologicalOrder()
    {
        var gb = Country.GetCountry("GB");
        var holidays = gb.GetHolidays(2026);

        for (var i = 1; i < holidays.Count; i++)
            Assert.True(holidays[i].ObservedDate >= holidays[i - 1].ObservedDate);
    }

    [Fact]
    public void GetHolidays_Should_ResolveEveryOccurrenceIntoTheRequestedYear()
    {
        var us = Country.GetCountry("US");

        foreach (var holiday in us.GetHolidays(2026))
            Assert.Equal(2026, holiday.Date.Year);
    }

    [Theory]
    [InlineData(1582)]
    [InlineData(10000)]
    public void GetHolidays_Should_ThrowForYearsOutsideTheComputableRange(int year)
    {
        var us = Country.GetCountry("US");

        Assert.Throws<ArgumentOutOfRangeException>(() => us.GetHolidays(year));
    }

    [Fact]
    public void GetHolidays_Should_BeStableAcrossRepeatedCalls()
    {
        var us = Country.GetCountry("US");

        Assert.Same(us.GetHolidays(2026), us.GetHolidays(2026));
    }

    [Fact]
    public void GetHolidays_Should_HandleLeapDayEntriesWithoutThrowing()
    {
        // 2027 is not a leap year; any 29 February entry must simply not occur.
        foreach (var country in Country.GetCurrent())
        {
            var holidays = country.GetHolidays(2027);

            Assert.DoesNotContain(holidays, h => h.Date.Month == 2 && h.Date.Day == 29);
        }
    }

    // ── GetHolidays(range) ──────────────────────────────────────────

    [Fact]
    public void GetHolidays_Should_SpanAYearBoundary()
    {
        var us = Country.GetCountry("US");

        var holidays = us.GetHolidays(new DateTime(2026, 12, 20), new DateTime(2027, 1, 5));

        Assert.Contains(holidays, h => h.Name == "Christmas Day");
        Assert.Contains(holidays, h => h.Name == "New Year's Day" && h.Date.Year == 2027);
    }

    [Fact]
    public void GetHolidays_Should_ThrowWhenTheRangeIsReversed()
    {
        var us = Country.GetCountry("US");

        Assert.Throws<ArgumentException>(() => us.GetHolidays(new DateTime(2026, 12, 31), new DateTime(2026, 1, 1)));
    }

    [Fact]
    public void GetHolidays_Should_ReturnEmptyForAQuietRange()
    {
        var us = Country.GetCountry("US");

        Assert.Empty(us.GetHolidays(new DateTime(2026, 3, 10), new DateTime(2026, 3, 14)));
    }

    // ── IsHoliday / IsWorkingDay ────────────────────────────────────

    [Fact]
    public void IsHoliday_Should_RecogniseMovableHolidays()
    {
        var gb = Country.GetCountry("GB");

        // Good Friday 2026 is 3 April; the old fixed-date check could never see it.
        Assert.True(gb.IsHoliday(new DateTime(2026, 4, 3)));
    }

    [Fact]
    public void IsHoliday_Should_ReturnFalseForAnOrdinaryDay()
    {
        var us = Country.GetCountry("US");

        Assert.False(us.IsHoliday(new DateTime(2026, 3, 12)));
    }

    [Fact]
    public void IsWorkingDay_Should_ExcludeWeekendsAndHolidays()
    {
        var us = Country.GetCountry("US");

        Assert.True(us.IsWorkingDay(new DateTime(2026, 3, 12))); // ordinary Thursday
        Assert.False(us.IsWorkingDay(new DateTime(2026, 3, 14))); // Saturday
        Assert.False(us.IsWorkingDay(new DateTime(2026, 12, 25))); // Christmas Day
        Assert.False(us.IsWorkingDay(new DateTime(2026, 7, 3))); // substituted Independence Day
    }

    [Fact]
    public void IsWorkingDay_Should_TreatSundayAsAWorkingDayInNepal()
    {
        var nepal = Country.GetCountry("NP");

        var sunday = new DateTime(2026, 3, 15);

        Assert.False(nepal.IsWeekend(sunday));
        Assert.Equal(!nepal.IsHoliday(sunday), nepal.IsWorkingDay(sunday));
    }

    // ── AddBusinessDays ─────────────────────────────────────────────

    [Fact]
    public void AddBusinessDays_Should_SkipTheWeekend()
    {
        var us = Country.GetCountry("US");

        // Thursday 12 March 2026 + 1 working day = Friday 13 March.
        Assert.Equal(new DateTime(2026, 3, 13), us.AddBusinessDays(new DateTime(2026, 3, 12), 1));

        // Friday 13 March + 1 = Monday 16 March.
        Assert.Equal(new DateTime(2026, 3, 16), us.AddBusinessDays(new DateTime(2026, 3, 13), 1));
    }

    [Fact]
    public void AddBusinessDays_Should_SkipASubstitutedHoliday()
    {
        var us = Country.GetCountry("US");

        // Thursday 2 July 2026 + 1: Friday 3 July is the substituted Independence Day and the
        // 4th and 5th are the weekend, so the next working day is Monday 6 July.
        Assert.Equal(new DateTime(2026, 7, 6), us.AddBusinessDays(new DateTime(2026, 7, 2), 1));
    }

    [Fact]
    public void AddBusinessDays_Should_WalkBackwardsForNegativeCounts()
    {
        var us = Country.GetCountry("US");

        // Monday 6 July 2026 - 1 working day = Thursday 2 July.
        Assert.Equal(new DateTime(2026, 7, 2), us.AddBusinessDays(new DateTime(2026, 7, 6), -1));
    }

    [Fact]
    public void AddBusinessDays_Should_ReturnTheSameDateForZero()
    {
        var us = Country.GetCountry("US");

        var saturday = new DateTime(2026, 3, 14);

        Assert.Equal(saturday, us.AddBusinessDays(saturday, 0));
    }

    [Fact]
    public void AddBusinessDays_Should_StripTheTimeComponent()
    {
        var us = Country.GetCountry("US");

        var result = us.AddBusinessDays(new DateTime(2026, 3, 12, 14, 30, 0), 1);

        Assert.Equal(new DateTime(2026, 3, 13), result);
        Assert.Equal(TimeSpan.Zero, result.TimeOfDay);
    }

    [Fact]
    public void AddBusinessDays_Should_RoundTripInBothDirections()
    {
        var gb = Country.GetCountry("GB");
        var start = new DateTime(2026, 3, 12);

        var forward = gb.AddBusinessDays(start, 20);

        Assert.Equal(start, gb.AddBusinessDays(forward, -20));
    }

    [Fact]
    public void AddBusinessDays_Should_UseTheSaudiWeekend()
    {
        var saudi = Country.GetCountry("SA");

        // Thursday 5 March 2026 + 1: Friday and Saturday are the Saudi weekend,
        // so the next working day is Sunday 8 March.
        var result = saudi.AddBusinessDays(new DateTime(2026, 3, 5), 1);

        Assert.Equal(DayOfWeek.Sunday, result.DayOfWeek);
        Assert.Equal(new DateTime(2026, 3, 8), result);
    }

    // ── Next / previous working day ─────────────────────────────────

    [Fact]
    public void NextWorkingDay_Should_BeStrictlyAfterTheGivenDate()
    {
        var us = Country.GetCountry("US");

        var thursday = new DateTime(2026, 3, 12);

        Assert.Equal(new DateTime(2026, 3, 13), us.NextWorkingDay(thursday));
    }

    [Fact]
    public void PreviousWorkingDay_Should_BeStrictlyBeforeTheGivenDate()
    {
        var us = Country.GetCountry("US");

        var monday = new DateTime(2026, 3, 16);

        Assert.Equal(new DateTime(2026, 3, 13), us.PreviousWorkingDay(monday));
    }

    [Fact]
    public void NextWorkingDay_Should_AlwaysReturnAWorkingDay()
    {
        var gb = Country.GetCountry("GB");
        var date = new DateTime(2026, 1, 1);

        for (var i = 0; i < 60; i++)
        {
            date = gb.NextWorkingDay(date);

            Assert.True(gb.IsWorkingDay(date));
        }
    }

    // ── CountBusinessDays ───────────────────────────────────────────

    [Fact]
    public void CountBusinessDays_Should_CountBothEndpoints()
    {
        var us = Country.GetCountry("US");

        // Monday 9 March to Friday 13 March 2026: five ordinary working days.
        Assert.Equal(5, us.CountBusinessDays(new DateTime(2026, 3, 9), new DateTime(2026, 3, 13)));
    }

    [Fact]
    public void CountBusinessDays_Should_ExcludeWeekendsAndHolidays()
    {
        var us = Country.GetCountry("US");

        // Monday 29 June to Friday 10 July 2026 spans ten weekdays, one of which
        // (Friday 3 July) is the substituted Independence Day.
        Assert.Equal(9, us.CountBusinessDays(new DateTime(2026, 6, 29), new DateTime(2026, 7, 10)));
    }

    [Fact]
    public void CountBusinessDays_Should_ReturnOneForASingleWorkingDay()
    {
        var us = Country.GetCountry("US");

        var thursday = new DateTime(2026, 3, 12);

        Assert.Equal(1, us.CountBusinessDays(thursday, thursday));
    }

    [Fact]
    public void CountBusinessDays_Should_ReturnZeroForASingleWeekendDay()
    {
        var us = Country.GetCountry("US");

        var saturday = new DateTime(2026, 3, 14);

        Assert.Equal(0, us.CountBusinessDays(saturday, saturday));
    }

    [Fact]
    public void CountBusinessDays_Should_ThrowWhenTheRangeIsReversed()
    {
        var us = Country.GetCountry("US");

        Assert.Throws<ArgumentException>(() =>
            us.CountBusinessDays(new DateTime(2026, 3, 13), new DateTime(2026, 3, 9)));
    }

    [Fact]
    public void CountBusinessDays_Should_AgreeWithAddBusinessDays()
    {
        var gb = Country.GetCountry("GB");
        var start = new DateTime(2026, 3, 12);

        var end = gb.AddBusinessDays(start, 10);

        // The start day is itself a working day, so the inclusive count covers it plus the ten steps.
        Assert.True(gb.IsWorkingDay(start));
        Assert.Equal(11, gb.CountBusinessDays(start, end));
    }

    // ── Whole-catalog sanity ────────────────────────────────────────

    [Fact]
    public void EveryCountry_Should_ResolveAFullYearOfHolidaysWithoutThrowing()
    {
        foreach (var country in Country.GetAll())
        {
            var holidays = country.GetHolidays(2026);

            foreach (var holiday in holidays)
            {
                Assert.False(string.IsNullOrWhiteSpace(holiday.Name));
                Assert.Equal(2026, holiday.Date.Year);
            }
        }
    }

    [Fact]
    public void EveryCountry_Should_HaveAWorkingDayWithinTheComingFortnight()
    {
        foreach (var country in Country.GetCurrent())
        {
            var start = new DateTime(2026, 1, 1);
            var found = false;

            for (var i = 0; i < 14 && !found; i++)
                found = country.IsWorkingDay(start.AddDays(i));

            Assert.True(found, $"{country.Name} ({country.Alpha2Code}) has no working day in a fortnight.");
        }
    }
}