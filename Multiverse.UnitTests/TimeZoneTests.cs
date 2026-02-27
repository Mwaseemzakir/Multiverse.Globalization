using System;
using System.Collections.Generic;
using System.Linq;
using Multiverse.Globalization.Countries;
using Multiverse.Globalization.TimeZones;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class TimeZoneTests
{
    #region CountryTimeZone Model — Constructor

    [Fact]
    public void CountryTimeZone_Should_SetProperties()
    {
        var tz = new CountryTimeZone("Asia/Karachi", 5, false);

        Assert.Equal("Asia/Karachi", tz.IanaId);
        Assert.Equal(5, tz.UtcOffsetHours);
        Assert.False(tz.ObservesDst);
    }

    [Fact]
    public void CountryTimeZone_WithDst_Should_SetObservesDstTrue()
    {
        var tz = new CountryTimeZone("America/New_York", -5, true);

        Assert.True(tz.ObservesDst);
    }

    [Fact]
    public void CountryTimeZone_NullIanaId_Should_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new CountryTimeZone(null!, 0, false));
    }

    [Fact]
    public void CountryTimeZone_EmptyIanaId_Should_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new CountryTimeZone("", 0, false));
    }

    [Fact]
    public void CountryTimeZone_WhitespaceIanaId_Should_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new CountryTimeZone("   ", 0, false));
    }

    #endregion

    #region CountryTimeZone Model — UtcOffset

    [Fact]
    public void UtcOffset_PositiveHours_Should_ReturnCorrectTimeSpan()
    {
        var tz = new CountryTimeZone("Asia/Karachi", 5, false);

        Assert.Equal(TimeSpan.FromHours(5), tz.UtcOffset);
    }

    [Fact]
    public void UtcOffset_NegativeHours_Should_ReturnCorrectTimeSpan()
    {
        var tz = new CountryTimeZone("America/New_York", -5, true);

        Assert.Equal(TimeSpan.FromHours(-5), tz.UtcOffset);
    }

    [Fact]
    public void UtcOffset_Zero_Should_ReturnZeroTimeSpan()
    {
        var tz = new CountryTimeZone("Europe/London", 0, true);

        Assert.Equal(TimeSpan.Zero, tz.UtcOffset);
    }

    [Fact]
    public void UtcOffset_FractionalHalf_Should_ReturnCorrectTimeSpan()
    {
        var tz = new CountryTimeZone("Asia/Kolkata", 5.5, false);

        Assert.Equal(TimeSpan.FromHours(5.5), tz.UtcOffset);
    }

    [Fact]
    public void UtcOffset_FractionalThreeQuarter_Should_ReturnCorrectTimeSpan()
    {
        var tz = new CountryTimeZone("Asia/Kathmandu", 5.75, false);

        Assert.Equal(TimeSpan.FromHours(5.75), tz.UtcOffset);
    }

    [Fact]
    public void UtcOffset_NegativeFractional_Should_ReturnCorrectTimeSpan()
    {
        var tz = new CountryTimeZone("America/St_Johns", -3.5, true);

        Assert.Equal(TimeSpan.FromHours(-3.5), tz.UtcOffset);
    }

    #endregion

    #region CountryTimeZone Model — UtcOffsetString

    [Fact]
    public void UtcOffsetString_Positive_Should_FormatCorrectly()
    {
        var tz = new CountryTimeZone("Asia/Karachi", 5, false);

        Assert.Equal("UTC+05:00", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_Negative_Should_FormatCorrectly()
    {
        var tz = new CountryTimeZone("America/New_York", -5, true);

        Assert.Equal("UTC-05:00", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_Zero_Should_FormatAsPositiveZero()
    {
        var tz = new CountryTimeZone("Europe/London", 0, true);

        Assert.Equal("UTC+00:00", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_FractionalHalf_Should_ShowMinutes()
    {
        var tz = new CountryTimeZone("Asia/Kolkata", 5.5, false);

        Assert.Equal("UTC+05:30", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_FractionalThreeQuarter_Should_ShowMinutes()
    {
        var tz = new CountryTimeZone("Asia/Kathmandu", 5.75, false);

        Assert.Equal("UTC+05:45", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_NegativeFractional_Should_ShowMinutes()
    {
        var tz = new CountryTimeZone("America/St_Johns", -3.5, true);

        Assert.Equal("UTC-03:30", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_LargePositive_Should_FormatCorrectly()
    {
        var tz = new CountryTimeZone("Pacific/Kiritimati", 14, false);

        Assert.Equal("UTC+14:00", tz.UtcOffsetString);
    }

    [Fact]
    public void UtcOffsetString_LargeNegative_Should_FormatCorrectly()
    {
        var tz = new CountryTimeZone("Pacific/Pago_Pago", -11, false);

        Assert.Equal("UTC-11:00", tz.UtcOffsetString);
    }

    #endregion

    #region CountryTimeZone Model — ToString

    [Fact]
    public void ToString_WithoutDst_Should_ShowIanaIdAndOffset()
    {
        var tz = new CountryTimeZone("Asia/Karachi", 5, false);

        Assert.Equal("Asia/Karachi (UTC+05:00)", tz.ToString());
    }

    [Fact]
    public void ToString_WithDst_Should_IncludeDstLabel()
    {
        var tz = new CountryTimeZone("America/New_York", -5, true);

        Assert.Equal("America/New_York (UTC-05:00, DST)", tz.ToString());
    }

    [Fact]
    public void ToString_FractionalOffset_Should_FormatCorrectly()
    {
        var tz = new CountryTimeZone("Asia/Kathmandu", 5.75, false);

        Assert.Equal("Asia/Kathmandu (UTC+05:45)", tz.ToString());
    }

    [Fact]
    public void ToString_ZeroOffsetWithDst_Should_FormatCorrectly()
    {
        var tz = new CountryTimeZone("Europe/London", 0, true);

        Assert.Equal("Europe/London (UTC+00:00, DST)", tz.ToString());
    }

    #endregion

    #region Country.TimeZones Property

    [Fact]
    public void Country_TimeZones_UnitedStates_Should_HaveSevenZones()
    {
        var us = Country.GetCountry("US");

        Assert.Equal(7, us.TimeZones.Count);
    }

    [Fact]
    public void Country_TimeZones_Pakistan_Should_HaveOneZone()
    {
        var pk = Country.GetCountry("PK");

        Assert.Single(pk.TimeZones);
        Assert.Equal("Asia/Karachi", pk.TimeZones[0].IanaId);
    }

    [Fact]
    public void Country_TimeZones_Russia_Should_HaveElevenZones()
    {
        var ru = Country.GetCountry("RU");

        Assert.Equal(11, ru.TimeZones.Count);
    }

    [Fact]
    public void Country_TimeZones_None_Should_ReturnEmptyList()
    {
        var none = CountryHelper.None;

        Assert.NotNull(none.TimeZones);
        Assert.Empty(none.TimeZones);
    }

    [Fact]
    public void Country_TimeZones_ShouldBeConsistentAcrossAccesses()
    {
        var country = Country.GetCountry("US");

        var first = country.TimeZones;
        var second = country.TimeZones;

        Assert.Equal(first.Count, second.Count);
        for (int i = 0; i < first.Count; i++)
        {
            Assert.Equal(first[i].IanaId, second[i].IanaId);
            Assert.Equal(first[i].UtcOffsetHours, second[i].UtcOffsetHours);
            Assert.Equal(first[i].ObservesDst, second[i].ObservesDst);
        }
    }

    [Fact]
    public void Country_TimeZones_Japan_Should_HaveSingleNonDstZone()
    {
        var jp = Country.GetCountry("JP");

        Assert.Single(jp.TimeZones);
        Assert.Equal("Asia/Tokyo", jp.TimeZones[0].IanaId);
        Assert.Equal(9, jp.TimeZones[0].UtcOffsetHours);
        Assert.False(jp.TimeZones[0].ObservesDst);
    }

    [Fact]
    public void Country_TimeZones_Australia_Should_HaveEightZones()
    {
        var au = Country.GetCountry("AU");

        Assert.Equal(8, au.TimeZones.Count);
    }

    [Fact]
    public void Country_TimeZones_Canada_Should_HaveSevenZones()
    {
        var ca = Country.GetCountry("CA");

        Assert.Equal(7, ca.TimeZones.Count);
    }

    [Fact]
    public void Country_TimeZones_India_Should_HaveSingleFractionalOffset()
    {
        var india = Country.GetCountry("IN");

        Assert.Single(india.TimeZones);
        Assert.Equal("Asia/Kolkata", india.TimeZones[0].IanaId);
        Assert.Equal(5.5, india.TimeZones[0].UtcOffsetHours);
    }

    [Fact]
    public void Country_TimeZones_Nepal_Should_HaveFractionalThreeQuarterOffset()
    {
        var nepal = Country.GetCountry("NP");

        Assert.Single(nepal.TimeZones);
        Assert.Equal(5.75, nepal.TimeZones[0].UtcOffsetHours);
    }

    [Fact]
    public void Country_TimeZones_UnitedKingdom_Should_HaveDst()
    {
        var uk = Country.GetCountry("GB");

        Assert.Single(uk.TimeZones);
        Assert.Equal("Europe/London", uk.TimeZones[0].IanaId);
        Assert.Equal(0, uk.TimeZones[0].UtcOffsetHours);
        Assert.True(uk.TimeZones[0].ObservesDst);
    }

    [Fact]
    public void Country_TimeZones_Antarctica_Should_HaveTenZones()
    {
        var aq = Country.GetCountry("AQ");

        Assert.Equal(10, aq.TimeZones.Count);
    }

    [Fact]
    public void Country_TimeZones_Brazil_Should_HaveEightZones()
    {
        var br = Country.GetCountry("BR");

        Assert.Equal(8, br.TimeZones.Count);
    }

    #endregion

    #region Country.HasMultipleTimeZones

    [Fact]
    public void HasMultipleTimeZones_UnitedStates_Should_BeTrue()
    {
        var us = Country.GetCountry("US");

        Assert.True(us.HasMultipleTimeZones);
    }

    [Fact]
    public void HasMultipleTimeZones_Russia_Should_BeTrue()
    {
        var ru = Country.GetCountry("RU");

        Assert.True(ru.HasMultipleTimeZones);
    }

    [Fact]
    public void HasMultipleTimeZones_Pakistan_Should_BeFalse()
    {
        var pk = Country.GetCountry("PK");

        Assert.False(pk.HasMultipleTimeZones);
    }

    [Fact]
    public void HasMultipleTimeZones_Japan_Should_BeFalse()
    {
        var jp = Country.GetCountry("JP");

        Assert.False(jp.HasMultipleTimeZones);
    }

    [Fact]
    public void HasMultipleTimeZones_None_Should_BeFalse()
    {
        Assert.False(CountryHelper.None.HasMultipleTimeZones);
    }

    [Fact]
    public void HasMultipleTimeZones_Australia_Should_BeTrue()
    {
        var au = Country.GetCountry("AU");

        Assert.True(au.HasMultipleTimeZones);
    }

    #endregion

    #region Country.GetPrimaryTimeZone

    [Fact]
    public void GetPrimaryTimeZone_UnitedStates_Should_ReturnNewYork()
    {
        var us = Country.GetCountry("US");

        var primary = us.GetPrimaryTimeZone();

        Assert.NotNull(primary);
        Assert.Equal("America/New_York", primary!.IanaId);
    }

    [Fact]
    public void GetPrimaryTimeZone_Pakistan_Should_ReturnKarachi()
    {
        var pk = Country.GetCountry("PK");

        var primary = pk.GetPrimaryTimeZone();

        Assert.NotNull(primary);
        Assert.Equal("Asia/Karachi", primary!.IanaId);
        Assert.Equal(5, primary.UtcOffsetHours);
    }

    [Fact]
    public void GetPrimaryTimeZone_Russia_Should_ReturnMoscow()
    {
        var ru = Country.GetCountry("RU");

        var primary = ru.GetPrimaryTimeZone();

        Assert.NotNull(primary);
        Assert.Equal("Europe/Moscow", primary!.IanaId);
        Assert.Equal(3, primary.UtcOffsetHours);
    }

    [Fact]
    public void GetPrimaryTimeZone_None_Should_ReturnNull()
    {
        var primary = CountryHelper.None.GetPrimaryTimeZone();

        Assert.Null(primary);
    }

    [Fact]
    public void GetPrimaryTimeZone_UnitedKingdom_Should_ReturnLondon()
    {
        var uk = Country.GetCountry("GB");

        var primary = uk.GetPrimaryTimeZone();

        Assert.NotNull(primary);
        Assert.Equal("Europe/London", primary!.IanaId);
    }

    [Fact]
    public void GetPrimaryTimeZone_Japan_Should_ReturnTokyo()
    {
        var jp = Country.GetCountry("JP");

        var primary = jp.GetPrimaryTimeZone();

        Assert.NotNull(primary);
        Assert.Equal("Asia/Tokyo", primary!.IanaId);
    }

    #endregion

    #region Country.GetTimeZonesWithDst

    [Fact]
    public void GetTimeZonesWithDst_UnitedStates_Should_ReturnFiveZones()
    {
        var us = Country.GetCountry("US");

        var dstZones = us.GetTimeZonesWithDst();

        // NY, Chicago, Denver, LA, Anchorage observe DST; Honolulu & Phoenix do not
        Assert.Equal(5, dstZones.Count);
        Assert.All(dstZones, tz => Assert.True(tz.ObservesDst));
    }

    [Fact]
    public void GetTimeZonesWithDst_UnitedStates_Should_ContainExpectedZones()
    {
        var us = Country.GetCountry("US");

        var dstZoneIds = us.GetTimeZonesWithDst().Select(tz => tz.IanaId).ToList();

        Assert.Contains("America/New_York", dstZoneIds);
        Assert.Contains("America/Chicago", dstZoneIds);
        Assert.Contains("America/Denver", dstZoneIds);
        Assert.Contains("America/Los_Angeles", dstZoneIds);
        Assert.Contains("America/Anchorage", dstZoneIds);
        Assert.DoesNotContain("Pacific/Honolulu", dstZoneIds);
        Assert.DoesNotContain("America/Phoenix", dstZoneIds);
    }

    [Fact]
    public void GetTimeZonesWithDst_Japan_Should_ReturnEmpty()
    {
        var jp = Country.GetCountry("JP");

        Assert.Empty(jp.GetTimeZonesWithDst());
    }

    [Fact]
    public void GetTimeZonesWithDst_Pakistan_Should_ReturnEmpty()
    {
        var pk = Country.GetCountry("PK");

        Assert.Empty(pk.GetTimeZonesWithDst());
    }

    [Fact]
    public void GetTimeZonesWithDst_UnitedKingdom_Should_ReturnOneZone()
    {
        var uk = Country.GetCountry("GB");

        var dstZones = uk.GetTimeZonesWithDst();

        Assert.Single(dstZones);
        Assert.Equal("Europe/London", dstZones[0].IanaId);
    }

    [Fact]
    public void GetTimeZonesWithDst_Canada_Should_ReturnDstZones()
    {
        var ca = Country.GetCountry("CA");

        var dstZones = ca.GetTimeZonesWithDst();

        // Toronto, Vancouver, Edmonton, Winnipeg, Halifax, St_Johns observe DST; Regina does not
        Assert.Equal(6, dstZones.Count);
        Assert.DoesNotContain(dstZones, tz => tz.IanaId == "America/Regina");
    }

    [Fact]
    public void GetTimeZonesWithDst_Russia_Should_ReturnEmpty()
    {
        // Russia abolished DST in 2011
        var ru = Country.GetCountry("RU");

        Assert.Empty(ru.GetTimeZonesWithDst());
    }

    [Fact]
    public void GetTimeZonesWithDst_None_Should_ReturnEmpty()
    {
        Assert.Empty(CountryHelper.None.GetTimeZonesWithDst());
    }

    #endregion

    #region Country.GetUtcOffsets

    [Fact]
    public void GetUtcOffsets_Pakistan_Should_ReturnSingleOffset()
    {
        var pk = Country.GetCountry("PK");

        var offsets = pk.GetUtcOffsets();

        Assert.Single(offsets);
        Assert.Equal(TimeSpan.FromHours(5), offsets[0]);
    }

    [Fact]
    public void GetUtcOffsets_UnitedStates_Should_ReturnDistinctOffsets()
    {
        var us = Country.GetCountry("US");

        var offsets = us.GetUtcOffsets();

        // -5, -6, -7, -8, -9, -10 (Phoenix and Denver share -7)
        Assert.Equal(6, offsets.Count);
        Assert.Contains(TimeSpan.FromHours(-5), offsets);
        Assert.Contains(TimeSpan.FromHours(-6), offsets);
        Assert.Contains(TimeSpan.FromHours(-7), offsets);
        Assert.Contains(TimeSpan.FromHours(-8), offsets);
        Assert.Contains(TimeSpan.FromHours(-9), offsets);
        Assert.Contains(TimeSpan.FromHours(-10), offsets);
    }

    [Fact]
    public void GetUtcOffsets_Russia_Should_SpanManyOffsets()
    {
        var ru = Country.GetCountry("RU");

        var offsets = ru.GetUtcOffsets();

        // Kaliningrad(+2), Moscow(+3), Samara(+4), Yekaterinburg(+5), Omsk(+6),
        // Krasnoyarsk(+7), Irkutsk(+8), Yakutsk(+9), Vladivostok(+10), Magadan(+11), Kamchatka(+12)
        Assert.Equal(11, offsets.Count);
    }

    [Fact]
    public void GetUtcOffsets_None_Should_ReturnEmpty()
    {
        Assert.Empty(CountryHelper.None.GetUtcOffsets());
    }

    [Fact]
    public void GetUtcOffsets_India_Should_ReturnFractionalOffset()
    {
        var india = Country.GetCountry("IN");

        var offsets = india.GetUtcOffsets();

        Assert.Single(offsets);
        Assert.Equal(TimeSpan.FromHours(5.5), offsets[0]);
    }

    #endregion

    #region TimeZoneHelper.All

    [Fact]
    public void TimeZoneHelper_All_Should_NotBeNull()
    {
        Assert.NotNull(TimeZoneHelper.All);
    }

    [Fact]
    public void TimeZoneHelper_All_Should_NotBeEmpty()
    {
        Assert.NotEmpty(TimeZoneHelper.All);
    }

    [Fact]
    public void TimeZoneHelper_All_Should_ContainKnownCountries()
    {
        Assert.True(TimeZoneHelper.All.ContainsKey("US"));
        Assert.True(TimeZoneHelper.All.ContainsKey("PK"));
        Assert.True(TimeZoneHelper.All.ContainsKey("GB"));
        Assert.True(TimeZoneHelper.All.ContainsKey("JP"));
        Assert.True(TimeZoneHelper.All.ContainsKey("AU"));
        Assert.True(TimeZoneHelper.All.ContainsKey("RU"));
        Assert.True(TimeZoneHelper.All.ContainsKey("IN"));
        Assert.True(TimeZoneHelper.All.ContainsKey("DE"));
        Assert.True(TimeZoneHelper.All.ContainsKey("FR"));
        Assert.True(TimeZoneHelper.All.ContainsKey("BR"));
        Assert.True(TimeZoneHelper.All.ContainsKey("CA"));
    }

    [Fact]
    public void TimeZoneHelper_All_ShouldHaveAtLeastOneZonePerEntry()
    {
        foreach (var entry in TimeZoneHelper.All)
        {
            Assert.NotEmpty(entry.Value);
        }
    }

    [Fact]
    public void TimeZoneHelper_All_KeysShouldBeUppercaseAlpha2()
    {
        foreach (var key in TimeZoneHelper.All.Keys)
        {
            Assert.Equal(2, key.Length);
            Assert.Equal(key.ToUpperInvariant(), key);
        }
    }

    #endregion

    #region Data Integrity

    [Fact]
    public void AllTimeZones_IanaIds_Should_NotBeNullOrEmpty()
    {
        foreach (var entry in TimeZoneHelper.All)
        {
            foreach (var tz in entry.Value)
            {
                Assert.False(string.IsNullOrWhiteSpace(tz.IanaId),
                    $"Country {entry.Key} has a time zone with null/empty IANA ID");
            }
        }
    }

    [Fact]
    public void AllTimeZones_IanaIds_Should_ContainSlashOrPrefix()
    {
        // IANA IDs are in "Area/Location" format (e.g. "Asia/Karachi", "Pacific/Auckland")
        foreach (var entry in TimeZoneHelper.All)
        {
            foreach (var tz in entry.Value)
            {
                Assert.Contains("/", tz.IanaId);
            }
        }
    }

    [Fact]
    public void AllTimeZones_UtcOffsets_Should_BeInValidRange()
    {
        // UTC offsets range from -12 to +14 hours
        foreach (var entry in TimeZoneHelper.All)
        {
            foreach (var tz in entry.Value)
            {
                Assert.True(tz.UtcOffsetHours >= -12 && tz.UtcOffsetHours <= 14,
                    $"Country {entry.Key}, zone {tz.IanaId}: offset {tz.UtcOffsetHours} is out of range [-12, +14]");
            }
        }
    }

    [Fact]
    public void AllTimeZones_NoDuplicateIanaIdsPerCountry()
    {
        foreach (var entry in TimeZoneHelper.All)
        {
            var ids = entry.Value.Select(tz => tz.IanaId).ToList();
            Assert.Equal(ids.Count, ids.Distinct().Count());
        }
    }

    [Fact]
    public void AllTimeZones_CountryCodes_ShouldExistInCountryHelper()
    {
        // XK (Kosovo) is a user-assigned code not in ISO 3166-1, but is widely used and included in IANA data
        var excludedCodes = new HashSet<string> { "XK" };

        var allCountryCodes = Country.GetAll()
            .Select(c => c.Alpha2Code.ToUpperInvariant())
            .Where(c => !string.IsNullOrEmpty(c))
            .ToHashSet();

        foreach (var key in TimeZoneHelper.All.Keys)
        {
            if (excludedCodes.Contains(key)) continue;

            Assert.True(allCountryCodes.Contains(key),
                $"TimeZoneHelper contains code '{key}' which does not exist in CountryHelper");
        }
    }

    [Fact]
    public void AllTimeZones_UtcOffsetString_ShouldStartWithUtc()
    {
        foreach (var entry in TimeZoneHelper.All)
        {
            foreach (var tz in entry.Value)
            {
                Assert.StartsWith("UTC", tz.UtcOffsetString);
            }
        }
    }

    [Fact]
    public void AllTimeZones_UtcOffset_ShouldMatchUtcOffsetHours()
    {
        foreach (var entry in TimeZoneHelper.All)
        {
            foreach (var tz in entry.Value)
            {
                Assert.Equal(TimeSpan.FromHours(tz.UtcOffsetHours), tz.UtcOffset);
            }
        }
    }

    #endregion

    #region Specific Country Time Zone Data

    [Fact]
    public void US_TimeZones_Should_ContainExpectedZoneIds()
    {
        var us = Country.GetCountry("US");
        var zoneIds = us.TimeZones.Select(tz => tz.IanaId).ToList();

        Assert.Contains("America/New_York", zoneIds);
        Assert.Contains("America/Chicago", zoneIds);
        Assert.Contains("America/Denver", zoneIds);
        Assert.Contains("America/Los_Angeles", zoneIds);
        Assert.Contains("America/Anchorage", zoneIds);
        Assert.Contains("Pacific/Honolulu", zoneIds);
        Assert.Contains("America/Phoenix", zoneIds);
    }

    [Fact]
    public void Russia_TimeZones_Should_ContainMoscowAndKamchatka()
    {
        var ru = Country.GetCountry("RU");
        var zoneIds = ru.TimeZones.Select(tz => tz.IanaId).ToList();

        Assert.Contains("Europe/Moscow", zoneIds);
        Assert.Contains("Asia/Kamchatka", zoneIds);
        Assert.Contains("Europe/Kaliningrad", zoneIds);
    }

    [Fact]
    public void Australia_TimeZones_Should_ContainSydneyAndPerth()
    {
        var au = Country.GetCountry("AU");
        var zoneIds = au.TimeZones.Select(tz => tz.IanaId).ToList();

        Assert.Contains("Australia/Sydney", zoneIds);
        Assert.Contains("Australia/Perth", zoneIds);
        Assert.Contains("Australia/Adelaide", zoneIds);
        Assert.Contains("Australia/Darwin", zoneIds);
    }

    [Fact]
    public void Canada_TimeZones_Should_ContainTorontoAndStJohns()
    {
        var ca = Country.GetCountry("CA");
        var zoneIds = ca.TimeZones.Select(tz => tz.IanaId).ToList();

        Assert.Contains("America/Toronto", zoneIds);
        Assert.Contains("America/Vancouver", zoneIds);
        Assert.Contains("America/St_Johns", zoneIds);
    }

    [Fact]
    public void Canada_StJohns_Should_HaveFractionalOffset()
    {
        var ca = Country.GetCountry("CA");
        var stJohns = ca.TimeZones.First(tz => tz.IanaId == "America/St_Johns");

        Assert.Equal(-3.5, stJohns.UtcOffsetHours);
        Assert.True(stJohns.ObservesDst);
    }

    [Fact]
    public void Germany_Should_HaveSingleZoneWithDst()
    {
        var de = Country.GetCountry("DE");

        Assert.Single(de.TimeZones);
        Assert.Equal("Europe/Berlin", de.TimeZones[0].IanaId);
        Assert.Equal(1, de.TimeZones[0].UtcOffsetHours);
        Assert.True(de.TimeZones[0].ObservesDst);
    }

    [Fact]
    public void France_Should_HaveParisZoneWithDst()
    {
        var fr = Country.GetCountry("FR");

        Assert.Single(fr.TimeZones);
        Assert.Equal("Europe/Paris", fr.TimeZones[0].IanaId);
        Assert.True(fr.TimeZones[0].ObservesDst);
    }

    [Fact]
    public void China_Should_HaveTwoZones()
    {
        var cn = Country.GetCountry("CN");

        Assert.Equal(2, cn.TimeZones.Count);
        var zoneIds = cn.TimeZones.Select(tz => tz.IanaId).ToList();
        Assert.Contains("Asia/Shanghai", zoneIds);
        Assert.Contains("Asia/Urumqi", zoneIds);
    }

    [Fact]
    public void Iceland_Should_HaveZeroUtcOffsetWithoutDst()
    {
        var iceland = Country.GetCountry("IS");

        Assert.Single(iceland.TimeZones);
        Assert.Equal("Atlantic/Reykjavik", iceland.TimeZones[0].IanaId);
        Assert.Equal(0, iceland.TimeZones[0].UtcOffsetHours);
        Assert.False(iceland.TimeZones[0].ObservesDst);
    }

    [Fact]
    public void Iran_Should_HaveFractionalOffsetWithDst()
    {
        var iran = Country.GetCountry("IR");

        Assert.Single(iran.TimeZones);
        Assert.Equal("Asia/Tehran", iran.TimeZones[0].IanaId);
        Assert.Equal(3.5, iran.TimeZones[0].UtcOffsetHours);
        Assert.True(iran.TimeZones[0].ObservesDst);
    }

    [Fact]
    public void NewZealand_Should_HaveTwoZonesWithDst()
    {
        var nz = Country.GetCountry("NZ");

        Assert.Equal(2, nz.TimeZones.Count);
        Assert.All(nz.TimeZones, tz => Assert.True(tz.ObservesDst));
    }

    [Fact]
    public void NewZealand_Chatham_Should_HaveFractionalOffset()
    {
        var nz = Country.GetCountry("NZ");
        var chatham = nz.TimeZones.First(tz => tz.IanaId == "Pacific/Chatham");

        Assert.Equal(13.75, chatham.UtcOffsetHours);
    }

    [Fact]
    public void Kiribati_Should_HaveHighestOffset()
    {
        var ki = Country.GetCountry("KI");
        var maxOffset = ki.TimeZones.Max(tz => tz.UtcOffsetHours);

        Assert.Equal(14, maxOffset);
    }

    [Fact]
    public void AmericanSamoa_Should_HaveLowestOffset()
    {
        var asCountry = Country.GetCountry("AS");

        Assert.Single(asCountry.TimeZones);
        Assert.Equal(-11, asCountry.TimeZones[0].UtcOffsetHours);
    }

    [Fact]
    public void Mexico_Should_HaveSixZones()
    {
        var mx = Country.GetCountry("MX");

        Assert.Equal(6, mx.TimeZones.Count);
    }

    [Fact]
    public void Indonesia_Should_HaveThreeZones()
    {
        var id = Country.GetCountry("ID");

        Assert.Equal(3, id.TimeZones.Count);
    }

    [Fact]
    public void Myanmar_Should_HaveFractionalOffset()
    {
        var mm = Country.GetCountry("MM");

        Assert.Single(mm.TimeZones);
        Assert.Equal(6.5, mm.TimeZones[0].UtcOffsetHours);
    }

    [Fact]
    public void CocosIslands_Should_HaveFractionalOffset()
    {
        var cc = Country.GetCountry("CC");

        Assert.Single(cc.TimeZones);
        Assert.Equal(6.5, cc.TimeZones[0].UtcOffsetHours);
    }

    [Fact]
    public void FrenchPolynesia_Should_HaveThreeZonesIncludingFractional()
    {
        var pf = Country.GetCountry("PF");

        Assert.Equal(3, pf.TimeZones.Count);
        var marquesas = pf.TimeZones.First(tz => tz.IanaId == "Pacific/Marquesas");
        Assert.Equal(-9.5, marquesas.UtcOffsetHours);
    }

    [Fact]
    public void Portugal_Should_HaveThreeZonesAllWithDst()
    {
        var pt = Country.GetCountry("PT");

        Assert.Equal(3, pt.TimeZones.Count);
        Assert.All(pt.TimeZones, tz => Assert.True(tz.ObservesDst));
    }

    #endregion

    #region Edge Cases

    [Fact]
    public void TimeZoneHelper_GetTimeZonesForCountry_NullCode_ReturnsEmpty()
    {
        var result = TimeZoneHelper.GetTimeZonesForCountry(null!);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void TimeZoneHelper_GetTimeZonesForCountry_EmptyCode_ReturnsEmpty()
    {
        var result = TimeZoneHelper.GetTimeZonesForCountry("");

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void TimeZoneHelper_GetTimeZonesForCountry_InvalidCode_ReturnsEmpty()
    {
        var result = TimeZoneHelper.GetTimeZonesForCountry("XX");

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void TimeZoneHelper_GetTimeZonesForCountry_LowercaseCode_ShouldStillWork()
    {
        var result = TimeZoneHelper.GetTimeZonesForCountry("us");

        Assert.NotEmpty(result);
        Assert.Equal(7, result.Count);
    }

    [Fact]
    public void Country_TimeZones_AllCountries_ShouldNotThrow()
    {
        var countries = Country.GetAll();

        foreach (var country in countries)
        {
            var exception = Record.Exception(() =>
            {
                var _ = country.TimeZones;
                var __ = country.HasMultipleTimeZones;
                var ___ = country.GetPrimaryTimeZone();
                var ____ = country.GetTimeZonesWithDst();
                var _____ = country.GetUtcOffsets();
            });

            Assert.Null(exception);
        }
    }

    #endregion
}
