namespace Multiverse.Globalization.UnitTests.Countries;

public class WeekendTests
{
    [Fact]
    public void WeekendDays_Should_DefaultToSaturdayAndSunday()
    {
        var us = Country.GetCountry("US");

        Assert.Equal([DayOfWeek.Saturday, DayOfWeek.Sunday], us.WeekendDays);
    }

    [Theory]
    [InlineData("SA")]
    [InlineData("EG")]
    [InlineData("IL")]
    [InlineData("BD")]
    public void WeekendDays_Should_BeFridayAndSaturdayInTheseCountries(string alpha2)
    {
        var country = Country.GetCountry(alpha2);

        Assert.Equal([DayOfWeek.Friday, DayOfWeek.Saturday], country.WeekendDays);
    }

    [Fact]
    public void WeekendDays_Should_BeSaturdayOnlyInNepal()
    {
        var nepal = Country.GetCountry("NP");

        Assert.Equal([DayOfWeek.Saturday], nepal.WeekendDays);
    }

    [Fact]
    public void WeekendDays_Should_BeFridayAndSundayInBrunei()
    {
        var brunei = Country.GetCountry("BN");

        Assert.Equal([DayOfWeek.Friday, DayOfWeek.Sunday], brunei.WeekendDays);
    }

    [Fact]
    public void WeekendDays_Should_BeSaturdayAndSundayInTheUae()
    {
        // The UAE moved to a Saturday-Sunday weekend in January 2022.
        var uae = Country.GetCountry("AE");

        Assert.Equal([DayOfWeek.Saturday, DayOfWeek.Sunday], uae.WeekendDays);
    }

    [Fact]
    public void IsWeekend_Should_FollowTheCountrysWeekend()
    {
        var us = Country.GetCountry("US");
        var saudi = Country.GetCountry("SA");

        var friday = new DateTime(2026, 1, 2);
        var sunday = new DateTime(2026, 1, 4);

        Assert.False(us.IsWeekend(friday));
        Assert.True(us.IsWeekend(sunday));

        Assert.True(saudi.IsWeekend(friday));
        Assert.False(saudi.IsWeekend(sunday));
    }

    [Fact]
    public void IsWeekend_Should_IgnoreTheTimeComponent()
    {
        var us = Country.GetCountry("US");

        Assert.True(us.IsWeekend(new DateTime(2026, 1, 4, 23, 59, 59)));
    }

    [Fact]
    public void WeekendDays_Should_BeNonEmptyForEveryCountry()
    {
        foreach (var country in Country.GetAll())
        {
            Assert.NotEmpty(country.WeekendDays);
            Assert.True(country.WeekendDays.Count < 7, $"{country.Name} has no working days at all.");
        }
    }

    [Fact]
    public void WithWeekendDay_Should_FindCountriesRestingOnFriday()
    {
        var fridayResting = Country.WithWeekendDay(DayOfWeek.Friday);

        Assert.Contains(fridayResting, c => c.Alpha2Code == "SA");
        Assert.Contains(fridayResting, c => c.Alpha2Code == "EG");
        Assert.DoesNotContain(fridayResting, c => c.Alpha2Code == "US");
    }

    [Fact]
    public void WeekendHelper_Exceptions_Should_OnlyListRealDeviations()
    {
        foreach (var entry in WeekendHelper.Exceptions)
        {
            var isDefault =
                entry.Value.Count == 2 &&
                entry.Value.Contains(DayOfWeek.Saturday) &&
                entry.Value.Contains(DayOfWeek.Sunday);

            Assert.False(isDefault, $"{entry.Key} is listed as an exception but matches the default weekend.");
        }
    }
}
