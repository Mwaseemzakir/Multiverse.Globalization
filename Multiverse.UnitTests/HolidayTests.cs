using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Holidays;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class HolidayTests
{
    #region Holiday Model

    [Fact]
    public void Holiday_Should_HaveCorrectProperties()
    {
        var holiday = new Holiday("Independence Day", 7, 4, HolidayType.National);

        Assert.Equal("Independence Day", holiday.Name);
        Assert.Equal(7, holiday.Month);
        Assert.Equal(4, holiday.Day);
        Assert.Equal(HolidayType.National, holiday.Type);
    }

    [Fact]
    public void Holiday_GetDate_Should_ReturnDateForGivenYear()
    {
        var holiday = new Holiday("New Year's Day", 1, 1, HolidayType.Public);

        var date = holiday.GetDate(2026);

        Assert.Equal(new DateTime(2026, 1, 1), date);
    }

    [Fact]
    public void Holiday_Date_Should_ReturnDateForCurrentYear()
    {
        var holiday = new Holiday("Christmas Day", 12, 25, HolidayType.Religious);

        var date = holiday.Date;

        Assert.Equal(DateTime.Today.Year, date.Year);
        Assert.Equal(12, date.Month);
        Assert.Equal(25, date.Day);
    }

    [Fact]
    public void Holiday_IsOnDate_Should_ReturnTrueWhenMatches()
    {
        var holiday = new Holiday("Independence Day", 7, 4, HolidayType.National);

        Assert.True(holiday.IsOnDate(new DateTime(2026, 7, 4)));
        Assert.True(holiday.IsOnDate(new DateTime(2000, 7, 4)));
        Assert.True(holiday.IsOnDate(new DateTime(1776, 7, 4)));
    }

    [Fact]
    public void Holiday_IsOnDate_Should_ReturnFalseWhenDoesNotMatch()
    {
        var holiday = new Holiday("Independence Day", 7, 4, HolidayType.National);

        Assert.False(holiday.IsOnDate(new DateTime(2026, 7, 5)));
        Assert.False(holiday.IsOnDate(new DateTime(2026, 6, 4)));
        Assert.False(holiday.IsOnDate(new DateTime(2026, 1, 1)));
    }

    [Fact]
    public void Holiday_ToString_Should_ReturnFormattedString()
    {
        var holiday = new Holiday("Christmas Day", 12, 25, HolidayType.Religious);

        Assert.Equal("Christmas Day (12/25)", holiday.ToString());
    }

    [Fact]
    public void Holiday_ToString_Should_PadSingleDigitMonthAndDay()
    {
        var holiday = new Holiday("New Year's Day", 1, 1, HolidayType.Public);

        Assert.Equal("New Year's Day (01/01)", holiday.ToString());
    }

    [Fact]
    public void Holiday_Constructor_Should_ThrowForNullName()
    {
        Assert.Throws<ArgumentNullException>(() => new Holiday(null!, 1, 1, HolidayType.Public));
        Assert.Throws<ArgumentNullException>(() => new Holiday("", 1, 1, HolidayType.Public));
        Assert.Throws<ArgumentNullException>(() => new Holiday("  ", 1, 1, HolidayType.Public));
    }

    [Fact]
    public void Holiday_Constructor_Should_ThrowForInvalidMonth()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Holiday("Test", 0, 1, HolidayType.Public));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Holiday("Test", 13, 1, HolidayType.Public));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Holiday("Test", -1, 1, HolidayType.Public));
    }

    [Fact]
    public void Holiday_Constructor_Should_ThrowForInvalidDay()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Holiday("Test", 1, 0, HolidayType.Public));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Holiday("Test", 1, 32, HolidayType.Public));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Holiday("Test", 1, -1, HolidayType.Public));
    }

    #endregion

    #region HolidayType Enum

    [Fact]
    public void HolidayType_Should_HaveExpectedValues()
    {
        Assert.Equal(0, (int)HolidayType.Public);
        Assert.Equal(1, (int)HolidayType.Bank);
        Assert.Equal(2, (int)HolidayType.Religious);
        Assert.Equal(3, (int)HolidayType.National);
        Assert.Equal(4, (int)HolidayType.Observance);
    }

    [Fact]
    public void HolidayType_Should_HaveFiveValues()
    {
        var values = Enum.GetValues(typeof(HolidayType));
        Assert.Equal(5, values.Length);
    }

    #endregion

    #region Country.Holidays Property

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForUS()
    {
        var us = Country.GetCountry("US");

        Assert.NotNull(us.Holidays);
        Assert.NotEmpty(us.Holidays);
        Assert.Contains(us.Holidays, h => h.Name == "Independence Day" && h.Month == 7 && h.Day == 4);
        Assert.Contains(us.Holidays, h => h.Name == "Christmas Day" && h.Month == 12 && h.Day == 25);
        Assert.Contains(us.Holidays, h => h.Name == "New Year's Day" && h.Month == 1 && h.Day == 1);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForPakistan()
    {
        var pk = Country.GetCountry("PK");

        Assert.NotNull(pk.Holidays);
        Assert.NotEmpty(pk.Holidays);
        Assert.Contains(pk.Holidays, h => h.Name == "Pakistan Day" && h.Month == 3 && h.Day == 23);
        Assert.Contains(pk.Holidays, h => h.Name == "Independence Day" && h.Month == 8 && h.Day == 14);
        Assert.Contains(pk.Holidays, h => h.Name == "Quaid-e-Azam Day" && h.Month == 12 && h.Day == 25);
        Assert.Contains(pk.Holidays, h => h.Name == "Labour Day" && h.Month == 5 && h.Day == 1);
        Assert.Contains(pk.Holidays, h => h.Name == "Iqbal Day" && h.Month == 11 && h.Day == 9);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForJapan()
    {
        var jp = Country.GetCountry("JP");

        Assert.NotNull(jp.Holidays);
        Assert.True(jp.Holidays.Count >= 10, "Japan should have at least 10 holidays");
        Assert.Contains(jp.Holidays, h => h.Name == "New Year's Day");
        Assert.Contains(jp.Holidays, h => h.Name == "National Foundation Day");
        Assert.Contains(jp.Holidays, h => h.Name == "Emperor's Birthday");
        Assert.Contains(jp.Holidays, h => h.Name == "Constitution Memorial Day");
        Assert.Contains(jp.Holidays, h => h.Name == "Culture Day");
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForUK()
    {
        var uk = Country.GetCountry("GB");

        Assert.NotNull(uk.Holidays);
        Assert.NotEmpty(uk.Holidays);
        Assert.Contains(uk.Holidays, h => h.Name == "Christmas Day");
        Assert.Contains(uk.Holidays, h => h.Name == "Boxing Day");
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForFrance()
    {
        var fr = Country.GetCountry("FR");

        Assert.NotNull(fr.Holidays);
        Assert.NotEmpty(fr.Holidays);
        Assert.Contains(fr.Holidays, h => h.Name == "Bastille Day" && h.Month == 7 && h.Day == 14);
        Assert.Contains(fr.Holidays, h => h.Name == "Labour Day" && h.Month == 5 && h.Day == 1);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForGermany()
    {
        var de = Country.GetCountry("DE");

        Assert.NotNull(de.Holidays);
        Assert.NotEmpty(de.Holidays);
        Assert.Contains(de.Holidays, h => h.Name == "German Unity Day" && h.Month == 10 && h.Day == 3);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForIndia()
    {
        var india = Country.GetCountry("IN");

        Assert.NotNull(india.Holidays);
        Assert.NotEmpty(india.Holidays);
        Assert.Contains(india.Holidays, h => h.Name == "Republic Day" && h.Month == 1 && h.Day == 26);
        Assert.Contains(india.Holidays, h => h.Name == "Independence Day" && h.Month == 8 && h.Day == 15);
        Assert.Contains(india.Holidays, h => h.Name == "Gandhi Jayanti" && h.Month == 10 && h.Day == 2);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForBrazil()
    {
        var br = Country.GetCountry("BR");

        Assert.NotNull(br.Holidays);
        Assert.NotEmpty(br.Holidays);
        Assert.Contains(br.Holidays, h => h.Name == "Independence Day" && h.Month == 9 && h.Day == 7);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForAustralia()
    {
        var au = Country.GetCountry("AU");

        Assert.NotNull(au.Holidays);
        Assert.NotEmpty(au.Holidays);
        Assert.Contains(au.Holidays, h => h.Name == "Australia Day" && h.Month == 1 && h.Day == 26);
        Assert.Contains(au.Holidays, h => h.Name == "Anzac Day" && h.Month == 4 && h.Day == 25);
    }

    [Fact]
    public void Country_Holidays_Should_ReturnHolidaysForSouthAfrica()
    {
        var za = Country.GetCountry("ZA");

        Assert.NotNull(za.Holidays);
        Assert.True(za.Holidays.Count >= 8, "South Africa should have at least 8 holidays");
        Assert.Contains(za.Holidays, h => h.Name == "Freedom Day" && h.Month == 4 && h.Day == 27);
        Assert.Contains(za.Holidays, h => h.Name == "Heritage Day" && h.Month == 9 && h.Day == 24);
    }

    [Theory]
    [InlineData("US", "Independence Day", 7, 4)]
    [InlineData("PK", "Pakistan Day", 3, 23)]
    [InlineData("JP", "National Foundation Day", 2, 11)]
    [InlineData("FR", "Bastille Day", 7, 14)]
    [InlineData("DE", "German Unity Day", 10, 3)]
    [InlineData("IN", "Republic Day", 1, 26)]
    [InlineData("BR", "Independence Day", 9, 7)]
    [InlineData("AU", "Australia Day", 1, 26)]
    [InlineData("CA", "Canada Day", 7, 1)]
    [InlineData("MX", "Independence Day", 9, 16)]
    [InlineData("KR", "Liberation Day", 8, 15)]
    [InlineData("TR", "Republic Day", 10, 29)]
    [InlineData("NG", "Independence Day", 10, 1)]
    [InlineData("ZA", "Freedom Day", 4, 27)]
    public void Country_Holidays_Should_ContainExpectedHoliday(string alpha2, string holidayName, int month, int day)
    {
        var country = Country.GetCountry(alpha2);

        Assert.Contains(country.Holidays, h => h.Name == holidayName && h.Month == month && h.Day == day);
    }

    [Fact]
    public void Country_Holidays_Should_BeEmptyForNone()
    {
        var none = CountryHelper.None;

        Assert.NotNull(none.Holidays);
        Assert.Empty(none.Holidays);
    }

    [Fact]
    public void Country_Holidays_Should_BeReadOnly()
    {
        var us = Country.GetCountry("US");
        Assert.IsAssignableFrom<IReadOnlyList<Holiday>>(us.Holidays);
    }

    [Fact]
    public void Country_Holidays_Should_AllHaveNonEmptyNames()
    {
        var countries = Country.GetAll();

        foreach (var country in countries)
        {
            foreach (var holiday in country.Holidays)
            {
                Assert.False(string.IsNullOrEmpty(holiday.Name),
                    $"Country '{country.Name}' has a holiday with an empty name");
            }
        }
    }

    [Fact]
    public void Country_Holidays_Should_AllHaveValidMonthAndDay()
    {
        var countries = Country.GetAll();

        foreach (var country in countries)
        {
            foreach (var holiday in country.Holidays)
            {
                Assert.InRange(holiday.Month, 1, 12);
                Assert.InRange(holiday.Day, 1, 31);
            }
        }
    }

    [Fact]
    public void Country_Holidays_Should_AllHaveValidDates()
    {
        var countries = Country.GetAll();

        foreach (var country in countries)
        {
            foreach (var holiday in country.Holidays)
            {
                // Ensure the month/day combination is a valid date
                var ex = Record.Exception(() => holiday.GetDate(2024)); // 2024 is a leap year
                Assert.Null(ex);
            }
        }
    }

    #endregion

    #region Country.GetHolidaysByType

    [Fact]
    public void GetHolidaysByType_Should_FilterNationalHolidays()
    {
        var us = Country.GetCountry("US");

        var national = us.GetHolidaysByType(HolidayType.National);

        Assert.NotEmpty(national);
        Assert.All(national, h => Assert.Equal(HolidayType.National, h.Type));
        Assert.Contains(national, h => h.Name == "Independence Day");
    }

    [Fact]
    public void GetHolidaysByType_Should_FilterReligiousHolidays()
    {
        var us = Country.GetCountry("US");

        var religious = us.GetHolidaysByType(HolidayType.Religious);

        Assert.NotEmpty(religious);
        Assert.All(religious, h => Assert.Equal(HolidayType.Religious, h.Type));
        Assert.Contains(religious, h => h.Name == "Christmas Day");
    }

    [Fact]
    public void GetHolidaysByType_Should_FilterPublicHolidays()
    {
        var us = Country.GetCountry("US");

        var publicHolidays = us.GetHolidaysByType(HolidayType.Public);

        Assert.NotEmpty(publicHolidays);
        Assert.All(publicHolidays, h => Assert.Equal(HolidayType.Public, h.Type));
    }

    [Fact]
    public void GetHolidaysByType_Should_FilterBankHolidays()
    {
        var uk = Country.GetCountry("GB");

        var bankHolidays = uk.GetHolidaysByType(HolidayType.Bank);

        Assert.NotEmpty(bankHolidays);
        Assert.All(bankHolidays, h => Assert.Equal(HolidayType.Bank, h.Type));
    }

    [Fact]
    public void GetHolidaysByType_Should_FilterObservanceHolidays()
    {
        var pk = Country.GetCountry("PK");

        var observance = pk.GetHolidaysByType(HolidayType.Observance);

        Assert.NotEmpty(observance);
        Assert.All(observance, h => Assert.Equal(HolidayType.Observance, h.Type));
        Assert.Contains(observance, h => h.Name == "Kashmir Day");
    }

    [Fact]
    public void GetHolidaysByType_Should_ReturnEmptyForCountryWithNoMatchingType()
    {
        var none = CountryHelper.None;

        var national = none.GetHolidaysByType(HolidayType.National);

        Assert.NotNull(national);
        Assert.Empty(national);
    }

    [Fact]
    public void GetHolidaysByType_Should_ReturnReadOnlyList()
    {
        var us = Country.GetCountry("US");

        var national = us.GetHolidaysByType(HolidayType.National);

        Assert.IsAssignableFrom<IReadOnlyList<Holiday>>(national);
    }

    #endregion

    #region Country.IsPublicHoliday

    [Fact]
    public void IsPublicHoliday_Should_ReturnTrueForKnownHoliday()
    {
        var us = Country.GetCountry("US");

        // Independence Day — July 4
        Assert.True(us.IsPublicHoliday(new DateTime(2026, 7, 4)));

        // Christmas Day — Dec 25
        Assert.True(us.IsPublicHoliday(new DateTime(2026, 12, 25)));

        // New Year's Day — Jan 1
        Assert.True(us.IsPublicHoliday(new DateTime(2026, 1, 1)));
    }

    [Fact]
    public void IsPublicHoliday_Should_ReturnFalseForNonHoliday()
    {
        var us = Country.GetCountry("US");

        Assert.False(us.IsPublicHoliday(new DateTime(2026, 3, 15)));
        Assert.False(us.IsPublicHoliday(new DateTime(2026, 6, 10)));
    }

    [Fact]
    public void IsPublicHoliday_Should_IgnoreYear()
    {
        var pk = Country.GetCountry("PK");

        // Pakistan Day is March 23 — should match regardless of year
        Assert.True(pk.IsPublicHoliday(new DateTime(2020, 3, 23)));
        Assert.True(pk.IsPublicHoliday(new DateTime(2026, 3, 23)));
        Assert.True(pk.IsPublicHoliday(new DateTime(1947, 3, 23)));
    }

    [Fact]
    public void IsPublicHoliday_Should_ReturnFalseForNone()
    {
        var none = CountryHelper.None;

        Assert.False(none.IsPublicHoliday(new DateTime(2026, 1, 1)));
        Assert.False(none.IsPublicHoliday(new DateTime(2026, 12, 25)));
    }

    #endregion

    #region Country.GetHolidayOnDate

    [Fact]
    public void GetHolidayOnDate_Should_ReturnHolidayWhenMatch()
    {
        var us = Country.GetCountry("US");

        var holiday = us.GetHolidayOnDate(new DateTime(2026, 7, 4));

        Assert.NotNull(holiday);
        Assert.Equal("Independence Day", holiday!.Name);
        Assert.Equal(HolidayType.National, holiday.Type);
    }

    [Fact]
    public void GetHolidayOnDate_Should_ReturnNullWhenNoMatch()
    {
        var us = Country.GetCountry("US");

        var holiday = us.GetHolidayOnDate(new DateTime(2026, 6, 15));

        Assert.Null(holiday);
    }

    [Fact]
    public void GetHolidayOnDate_Should_ReturnNullForNone()
    {
        var none = CountryHelper.None;

        Assert.Null(none.GetHolidayOnDate(new DateTime(2026, 1, 1)));
    }

    [Theory]
    [InlineData("US", 7, 4, "Independence Day")]
    [InlineData("PK", 8, 14, "Independence Day")]
    [InlineData("FR", 7, 14, "Bastille Day")]
    [InlineData("DE", 10, 3, "German Unity Day")]
    [InlineData("JP", 2, 11, "National Foundation Day")]
    [InlineData("IN", 1, 26, "Republic Day")]
    public void GetHolidayOnDate_Should_ReturnCorrectHoliday(string alpha2, int month, int day, string expectedName)
    {
        var country = Country.GetCountry(alpha2);

        var holiday = country.GetHolidayOnDate(new DateTime(2026, month, day));

        Assert.NotNull(holiday);
        Assert.Equal(expectedName, holiday!.Name);
    }

    #endregion

    #region HolidayHelper

    [Fact]
    public void HolidayHelper_All_Should_NotBeEmpty()
    {
        var all = HolidayHelper.All;

        Assert.NotNull(all);
        Assert.NotEmpty(all);
    }

    [Fact]
    public void HolidayHelper_All_Should_ContainMajorCountries()
    {
        var all = HolidayHelper.All;

        Assert.True(all.ContainsKey("US"));
        Assert.True(all.ContainsKey("GB"));
        Assert.True(all.ContainsKey("FR"));
        Assert.True(all.ContainsKey("DE"));
        Assert.True(all.ContainsKey("JP"));
        Assert.True(all.ContainsKey("IN"));
        Assert.True(all.ContainsKey("PK"));
        Assert.True(all.ContainsKey("BR"));
        Assert.True(all.ContainsKey("AU"));
        Assert.True(all.ContainsKey("CA"));
        Assert.True(all.ContainsKey("NG"));
        Assert.True(all.ContainsKey("ZA"));
    }

    [Fact]
    public void HolidayHelper_All_Should_HaveAtLeastOneHolidayPerEntry()
    {
        foreach (var kvp in HolidayHelper.All)
        {
            Assert.NotEmpty(kvp.Value);
        }
    }

    [Fact]
    public void HolidayHelper_All_Keys_Should_BeUppercaseAlpha2()
    {
        foreach (var key in HolidayHelper.All.Keys)
        {
            Assert.Equal(2, key.Length);
            Assert.Equal(key.ToUpperInvariant(), key);
        }
    }

    #endregion

    #region Data Integrity

    [Fact]
    public void AllHolidays_Should_HaveValidHolidayType()
    {
        var validTypes = new HashSet<HolidayType>
        {
            HolidayType.Public,
            HolidayType.Bank,
            HolidayType.Religious,
            HolidayType.National,
            HolidayType.Observance
        };

        foreach (var kvp in HolidayHelper.All)
        {
            foreach (var holiday in kvp.Value)
            {
                Assert.Contains(holiday.Type, validTypes);
            }
        }
    }

    [Theory]
    [InlineData("US", 10)]
    [InlineData("JP", 12)]
    [InlineData("PK", 6)]
    [InlineData("FR", 8)]
    [InlineData("DE", 5)]
    [InlineData("GB", 4)]
    [InlineData("IT", 10)]
    [InlineData("ZA", 10)]
    public void Country_Should_HaveExpectedHolidayCount(string alpha2, int expectedCount)
    {
        var country = Country.GetCountry(alpha2);

        Assert.Equal(expectedCount, country.Holidays.Count);
    }

    [Fact]
    public void Country_Holidays_Should_NotContainDuplicateNamesPerCountry()
    {
        foreach (var kvp in HolidayHelper.All)
        {
            var names = kvp.Value.Select(h => h.Name).ToList();
            var distinct = names.Distinct().ToList();

            Assert.True(names.Count == distinct.Count,
                $"Country '{kvp.Key}' has duplicate holiday names: {string.Join(", ", names.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key))}");
        }
    }

    [Fact]
    public void Country_Holidays_Should_BeConsistentAcrossAccesses()
    {
        var us = Country.GetCountry("US");

        var holidays1 = us.Holidays;
        var holidays2 = us.Holidays;

        Assert.Equal(holidays1.Count, holidays2.Count);
        for (int i = 0; i < holidays1.Count; i++)
        {
            Assert.Equal(holidays1[i].Name, holidays2[i].Name);
            Assert.Equal(holidays1[i].Month, holidays2[i].Month);
            Assert.Equal(holidays1[i].Day, holidays2[i].Day);
            Assert.Equal(holidays1[i].Type, holidays2[i].Type);
        }
    }

    #endregion
}
