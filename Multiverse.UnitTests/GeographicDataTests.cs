using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class GeographicDataTests
{
    #region Country Geographic Data

    [Fact]
    public void US_Should_HavePopulationGreaterThanZero()
    {
        var us = Country.GetCountry("US");
        Assert.True(us.Population > 0, "US population should be > 0");
    }

    [Fact]
    public void US_Should_HaveAreaGreaterThanZero()
    {
        var us = Country.GetCountry("US");
        Assert.True(us.AreaInSquareKilometers > 0, "US area should be > 0");
    }

    [Fact]
    public void US_Should_HaveCapitalCoordinates()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.CapitalCoordinates);
        Assert.InRange(us.CapitalCoordinates!.Latitude, 38.0, 40.0); // Washington DC
        Assert.InRange(us.CapitalCoordinates!.Longitude, -78.0, -76.0);
    }

    [Fact]
    public void US_Should_HaveBorderingCountries()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.BorderingCountries);
        Assert.Contains("CA", us.BorderingCountries);
        Assert.Contains("MX", us.BorderingCountries);
        Assert.Equal(2, us.BorderingCountries.Count);
    }

    [Theory]
    [InlineData("JP")]  // Island nation
    [InlineData("AU")]  // Island continent
    [InlineData("NZ")]  // Island nation
    [InlineData("SG")]  // City-state island
    public void IslandNation_Should_HaveNoBorderingCountries(string alpha2)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Empty(country.BorderingCountries);
    }

    [Fact]
    public void US_Should_NotBeLandlocked()
    {
        var us = Country.GetCountry("US");
        Assert.False(us.IsLandlocked);
    }

    [Theory]
    [InlineData("AT")]  // Austria
    [InlineData("CH")]  // Switzerland
    [InlineData("CZ")]  // Czech Republic
    [InlineData("HU")]  // Hungary
    [InlineData("BO")]  // Bolivia
    [InlineData("AF")]  // Afghanistan
    [InlineData("ET")]  // Ethiopia
    [InlineData("NP")]  // Nepal
    [InlineData("LA")]  // Laos
    public void LandlockedCountry_Should_BeMarkedAsLandlocked(string alpha2)
    {
        var country = Country.GetCountry(alpha2);
        Assert.True(country.IsLandlocked, $"{country.Name} should be landlocked");
    }

    [Theory]
    [InlineData("US")]
    [InlineData("GB")]
    [InlineData("JP")]
    [InlineData("AU")]
    [InlineData("BR")]
    [InlineData("IN")]
    public void CoastalCountry_Should_NotBeLandlocked(string alpha2)
    {
        var country = Country.GetCountry(alpha2);
        Assert.False(country.IsLandlocked, $"{country.Name} should not be landlocked");
    }

    [Fact]
    public void Germany_Should_HaveManyBorderingCountries()
    {
        var de = Country.GetCountry("DE");
        Assert.True(de.BorderingCountries.Count >= 9,
            "Germany borders 9 countries");
        Assert.Contains("FR", de.BorderingCountries);
        Assert.Contains("PL", de.BorderingCountries);
        Assert.Contains("AT", de.BorderingCountries);
    }

    [Fact]
    public void Russia_Should_HaveLargestArea()
    {
        var ru = Country.GetCountry("RU");
        Assert.True(ru.AreaInSquareKilometers > 17_000_000);
    }

    [Fact]
    public void India_Should_HaveHighPopulation()
    {
        var india = Country.GetCountry("IN");
        Assert.True(india.Population > 1_000_000_000);
    }

    [Fact]
    public void Singapore_Should_HaveSmallArea()
    {
        var sg = Country.GetCountry("SG");
        Assert.True(sg.AreaInSquareKilometers > 0 && sg.AreaInSquareKilometers < 1000);
    }

    [Fact]
    public void Antarctica_Should_HaveGeographicData()
    {
        // Antarctica now has geographic data populated
        var country = Country.GetCountryOrDefault("AQ"); // Antarctica
        Assert.NotNull(country);
        Assert.True(country!.AreaInSquareKilometers > 0);
    }

    #endregion

    #region GeoCoordinate

    [Fact]
    public void GeoCoordinate_ToString_Should_FormatCorrectly()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.CapitalCoordinates);
        var str = us.CapitalCoordinates!.ToString();
        Assert.Contains(",", str);
    }

    [Fact]
    public void GeoCoordinate_Equality_ShouldWorkCorrectly()
    {
        var a = new GeoCoordinate(38.8951, -77.0364);
        var b = new GeoCoordinate(38.8951, -77.0364);
        var c = new GeoCoordinate(51.5074, -0.1278);

        Assert.Equal(a, b);
        Assert.NotEqual(a, c);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void GeoCoordinate_ShouldValidateLatitudeRange()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new GeoCoordinate(-91, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new GeoCoordinate(91, 0));
    }

    [Fact]
    public void GeoCoordinate_ShouldValidateLongitudeRange()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new GeoCoordinate(0, -181));
        Assert.Throws<ArgumentOutOfRangeException>(() => new GeoCoordinate(0, 181));
    }

    [Fact]
    public void GeoCoordinate_BoundaryValues_ShouldBeValid()
    {
        var north = new GeoCoordinate(90, 0);
        var south = new GeoCoordinate(-90, 0);
        var east = new GeoCoordinate(0, 180);
        var west = new GeoCoordinate(0, -180);

        Assert.Equal(90, north.Latitude);
        Assert.Equal(-90, south.Latitude);
        Assert.Equal(180, east.Longitude);
        Assert.Equal(-180, west.Longitude);
    }

    [Fact]
    public void GeoCoordinate_NotEqualToNull()
    {
        var coord = new GeoCoordinate(0, 0);
        Assert.False(coord.Equals(null));
    }

    [Fact]
    public void GeoCoordinate_NotEqualToDifferentType()
    {
        var coord = new GeoCoordinate(0, 0);
        Assert.False(coord.Equals("not a coordinate"));
    }

    #endregion
}
