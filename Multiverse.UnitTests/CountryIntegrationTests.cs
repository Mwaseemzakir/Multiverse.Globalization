using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CountryIntegrationTests
{
    #region Alternative TLDs

    [Fact]
    public void GB_Should_HaveAlternativeTld()
    {
        var gb = Country.GetCountry("GB");
        Assert.NotEmpty(gb.AlternativeTlds);
        Assert.Contains(".gb", gb.AlternativeTlds);
    }

    [Fact]
    public void US_Should_HaveAlternativeTlds()
    {
        var us = Country.GetCountry("US");
        Assert.NotEmpty(us.AlternativeTlds);
    }

    [Fact]
    public void CountryWithoutAlternativeTlds_Should_HaveEmptyList()
    {
        var de = Country.GetCountry("DE");
        Assert.NotNull(de.AlternativeTlds);
        Assert.Empty(de.AlternativeTlds);
    }

    #endregion

    #region Integration Tests

    [Fact]
    public void US_AllNewProperties_ShouldBePopulated()
    {
        var us = Country.GetCountry("US");

        // Geographic
        Assert.True(us.Population > 0);
        Assert.True(us.AreaInSquareKilometers > 0);
        Assert.NotNull(us.CapitalCoordinates);
        Assert.NotEmpty(us.BorderingCountries);
        Assert.False(us.IsLandlocked);

        // Political
        Assert.True(us.IsUnMember);
        Assert.NotNull(us.IndependenceDate);

        // Transport
        Assert.Equal(DrivingSide.Right, us.DrivingSide);
        Assert.Equal("mph", us.SpeedUnit);

        // Locale
        Assert.NotNull(us.Locale);

        // Electrical
        Assert.NotNull(us.ElectricalSystem);

        // Emergency Numbers
        Assert.NotEmpty(us.EmergencyNumbers);

        // Phone Format
        Assert.NotNull(us.PhoneFormat);

        // Translations
        Assert.NotEmpty(us.Translations);

        // Subdivisions
        Assert.NotEmpty(us.Subdivisions);

        // Movable Holidays
        Assert.NotEmpty(us.MovableHolidays);

        // Alternative TLDs
        Assert.NotEmpty(us.AlternativeTlds);
    }

    [Fact]
    public void Pakistan_AllNewProperties_ShouldBePopulated()
    {
        var pk = Country.GetCountry("PK");

        Assert.True(pk.Population > 200_000_000);
        Assert.True(pk.AreaInSquareKilometers > 800_000);
        Assert.NotNull(pk.CapitalCoordinates);
        Assert.Contains("CN", pk.BorderingCountries);
        Assert.Contains("IN", pk.BorderingCountries);
        Assert.Contains("AF", pk.BorderingCountries);
        Assert.Contains("IR", pk.BorderingCountries);
        Assert.False(pk.IsLandlocked);
        Assert.True(pk.IsUnMember);
        Assert.NotNull(pk.IndependenceDate);
        Assert.Equal(DrivingSide.Left, pk.DrivingSide);
        Assert.Equal("km/h", pk.SpeedUnit);
    }

    [Fact]
    public void AllCountries_ExistingPropertiesUnchanged()
    {
        // Verify that existing properties still work correctly
        var us = Country.GetCountry("US");
        Assert.Equal("United States of America", us.Name);
        Assert.Equal("US", us.Alpha2Code);
        Assert.Equal("USA", us.Alpha3Code);
        Assert.Equal("+1", us.CallingCode);
        Assert.Equal("Washington, D.C.", us.Capital);
        Assert.Equal("Americas", us.Region);
        Assert.Equal("Northern America", us.SubRegion);
        Assert.Equal("American", us.Demonym);
        Assert.Equal(".us", us.TLD);
        Assert.NotNull(us.Currency);
        Assert.Equal("USD", us.CurrencyCode);
    }

    [Fact]
    public void AllCountries_ShouldHaveNonNullCollections()
    {
        foreach (var country in Country.GetAll())
        {
            Assert.NotNull(country.BorderingCountries);
            Assert.NotNull(country.AlternativeTlds);
            Assert.NotNull(country.EmergencyNumbers);
            Assert.NotNull(country.Subdivisions);
            Assert.NotNull(country.Translations);
            Assert.NotNull(country.MovableHolidays);
        }
    }

    [Fact]
    public void GettingLazyPropertiesMultipleTimes_ShouldReturnSameInstance()
    {
        var us = Country.GetCountry("US");

        var subdivisions1 = us.Subdivisions;
        var subdivisions2 = us.Subdivisions;
        Assert.Same(subdivisions1, subdivisions2);

        var translations1 = us.Translations;
        var translations2 = us.Translations;
        Assert.Same(translations1, translations2);

        var movable1 = us.MovableHolidays;
        var movable2 = us.MovableHolidays;
        Assert.Same(movable1, movable2);

        var emergency1 = us.EmergencyNumbers;
        var emergency2 = us.EmergencyNumbers;
        Assert.Same(emergency1, emergency2);
    }

    #endregion
}
