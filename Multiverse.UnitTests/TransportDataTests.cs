using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class TransportDataTests
{
    [Theory]
    [InlineData("US", DrivingSide.Right)]
    [InlineData("DE", DrivingSide.Right)]
    [InlineData("FR", DrivingSide.Right)]
    [InlineData("CN", DrivingSide.Right)]
    [InlineData("BR", DrivingSide.Right)]
    [InlineData("RU", DrivingSide.Right)]
    public void RightDrivingCountry_Should_HaveRightDrivingSide(string alpha2, DrivingSide expected)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expected, country.DrivingSide);
    }

    [Theory]
    [InlineData("GB", DrivingSide.Left)]
    [InlineData("JP", DrivingSide.Left)]
    [InlineData("AU", DrivingSide.Left)]
    [InlineData("IN", DrivingSide.Left)]
    [InlineData("PK", DrivingSide.Left)]
    [InlineData("TH", DrivingSide.Left)]
    [InlineData("ZA", DrivingSide.Left)]
    [InlineData("NZ", DrivingSide.Left)]
    [InlineData("SG", DrivingSide.Left)]
    [InlineData("MY", DrivingSide.Left)]
    public void LeftDrivingCountry_Should_HaveLeftDrivingSide(string alpha2, DrivingSide expected)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expected, country.DrivingSide);
    }

    [Theory]
    [InlineData("US", "mph")]
    [InlineData("GB", "mph")]
    public void US_And_GB_Should_HaveMphSpeedUnit(string alpha2, string expected)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expected, country.SpeedUnit);
    }

    [Theory]
    [InlineData("DE")]
    [InlineData("FR")]
    [InlineData("JP")]
    [InlineData("IN")]
    [InlineData("BR")]
    [InlineData("PK")]
    public void MetricCountry_Should_HaveKmhSpeedUnit(string alpha2)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal("km/h", country.SpeedUnit);
    }

    [Fact]
    public void AllCountries_Should_HaveValidSpeedUnit()
    {
        var validUnits = new[] { "km/h", "mph" };
        foreach (var country in Country.GetAll())
        {
            Assert.Contains(country.SpeedUnit, validUnits);
        }
    }

    [Fact]
    public void AllCountries_Should_HaveValidDrivingSide()
    {
        foreach (var country in Country.GetAll())
        {
            Assert.True(
                country.DrivingSide == DrivingSide.Left || country.DrivingSide == DrivingSide.Right,
                $"{country.Name} has invalid driving side");
        }
    }

    [Fact]
    public void DrivingSide_Should_HaveTwoValues()
    {
        var values = Enum.GetValues(typeof(DrivingSide));
        Assert.Equal(2, values.Length);
    }
}
