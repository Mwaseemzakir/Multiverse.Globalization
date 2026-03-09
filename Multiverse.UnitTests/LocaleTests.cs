using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class LocaleTests
{
    [Fact]
    public void US_Locale_Should_BeUsCustomary()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.Locale);
        Assert.Equal(MeasurementSystem.USCustomary, us.Locale!.MeasurementSystem);
    }

    [Fact]
    public void US_Locale_Should_HaveCorrectDateFormat()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.Locale);
        Assert.Equal("MM/dd/yyyy", us.Locale!.DateFormat);
    }

    [Fact]
    public void US_Locale_Should_HaveCorrectNumberFormat()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.Locale);
        Assert.Equal(".", us.Locale!.NumberDecimalSeparator);
        Assert.Equal(",", us.Locale.NumberGroupSeparator);
    }

    [Fact]
    public void Germany_Locale_Should_UseMetric()
    {
        var de = Country.GetCountry("DE");
        Assert.NotNull(de.Locale);
        Assert.Equal(MeasurementSystem.Metric, de.Locale!.MeasurementSystem);
    }

    [Fact]
    public void Germany_Locale_Should_UseCommaDecimalSeparator()
    {
        var de = Country.GetCountry("DE");
        Assert.NotNull(de.Locale);
        Assert.Equal(",", de.Locale!.NumberDecimalSeparator);
        Assert.Equal(".", de.Locale.NumberGroupSeparator);
    }

    [Fact]
    public void UK_Locale_Should_UseImperial()
    {
        var gb = Country.GetCountry("GB");
        Assert.NotNull(gb.Locale);
        Assert.Equal(MeasurementSystem.Imperial, gb.Locale!.MeasurementSystem);
    }

    [Fact]
    public void US_Locale_WeekStartDay_Should_BeSunday()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.Locale);
        Assert.Equal(DayOfWeek.Sunday, us.Locale!.WeekStartDay);
    }

    [Fact]
    public void Germany_Locale_WeekStartDay_Should_BeMonday()
    {
        var de = Country.GetCountry("DE");
        Assert.NotNull(de.Locale);
        Assert.Equal(DayOfWeek.Monday, de.Locale!.WeekStartDay);
    }

    [Fact]
    public void SaudiArabia_Locale_WeekStartDay_Should_BeSunday()
    {
        var sa = Country.GetCountry("SA");
        Assert.NotNull(sa.Locale);
        Assert.Equal(DayOfWeek.Sunday, sa.Locale!.WeekStartDay);
    }

    [Fact]
    public void CountryLocale_NullDateFormat_ShouldDefaultToEmpty()
    {
        // CountryLocale constructor uses null-coalescing, so null becomes empty string
        var locale = new CountryLocale(null!, ".", ",", MeasurementSystem.Metric, DayOfWeek.Monday, "", "");
        Assert.Equal(string.Empty, locale.DateFormat);
    }

    [Fact]
    public void MeasurementSystem_Should_HaveThreeValues()
    {
        var values = Enum.GetValues(typeof(MeasurementSystem));
        Assert.Equal(3, values.Length);
    }

    [Fact]
    public void MeasurementSystem_Should_ContainAllExpectedValues()
    {
        Assert.True(Enum.IsDefined(typeof(MeasurementSystem), MeasurementSystem.Metric));
        Assert.True(Enum.IsDefined(typeof(MeasurementSystem), MeasurementSystem.Imperial));
        Assert.True(Enum.IsDefined(typeof(MeasurementSystem), MeasurementSystem.USCustomary));
    }
}
