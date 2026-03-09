using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Subdivisions;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class SubdivisionTests
{
    [Fact]
    public void US_Should_Have51Subdivisions() // 50 states + DC
    {
        var us = Country.GetCountry("US");
        Assert.Equal(51, us.Subdivisions.Count);
    }

    [Fact]
    public void US_Subdivisions_Should_ContainCalifornia()
    {
        var us = Country.GetCountry("US");
        Assert.Contains(us.Subdivisions, s => s.Name == "California" && s.Code == "US-CA" && s.Type == "State");
    }

    [Fact]
    public void US_Subdivisions_Should_ContainDC()
    {
        var us = Country.GetCountry("US");
        Assert.Contains(us.Subdivisions, s => s.Name == "District of Columbia" && s.Type == "District");
    }

    [Fact]
    public void Canada_Should_Have13Subdivisions()
    {
        var ca = Country.GetCountry("CA");
        Assert.Equal(13, ca.Subdivisions.Count);
    }

    [Fact]
    public void Canada_Subdivisions_Should_ContainOntario()
    {
        var ca = Country.GetCountry("CA");
        Assert.Contains(ca.Subdivisions, s => s.Name == "Ontario" && s.Type == "Province");
    }

    [Fact]
    public void GB_Should_Have4Subdivisions()
    {
        var gb = Country.GetCountry("GB");
        Assert.Equal(4, gb.Subdivisions.Count);
    }

    [Fact]
    public void Germany_Should_Have16States()
    {
        var de = Country.GetCountry("DE");
        Assert.Equal(16, de.Subdivisions.Count);
    }

    [Fact]
    public void Pakistan_Should_Have7Subdivisions()
    {
        var pk = Country.GetCountry("PK");
        Assert.Equal(7, pk.Subdivisions.Count);
    }

    [Fact]
    public void Pakistan_Subdivisions_Should_ContainPunjab()
    {
        var pk = Country.GetCountry("PK");
        Assert.Contains(pk.Subdivisions, s => s.Name == "Punjab" && s.Type == "Province");
    }

    [Fact]
    public void India_Subdivisions_Should_ContainDelhi()
    {
        var india = Country.GetCountry("IN");
        Assert.Contains(india.Subdivisions, s => s.Name == "Delhi");
    }

    [Fact]
    public void Subdivision_Should_HaveUniqueCodesPerCountry()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.Subdivisions.Count > 0)
            {
                var codes = country.Subdivisions.Select(s => s.Code).ToList();
                Assert.Equal(codes.Count, codes.Distinct().Count());
            }
        }
    }

    [Fact]
    public void CountryWithoutSubdivisions_Should_HaveEmptyList()
    {
        var aq = Country.GetCountry("AQ");
        Assert.NotNull(aq.Subdivisions);
        Assert.Empty(aq.Subdivisions);
    }

    [Fact]
    public void Subdivision_Validation_ShouldRejectNullCode()
    {
        Assert.Throws<ArgumentNullException>(() => new Subdivision(null!, "Test", "State"));
    }

    [Fact]
    public void Subdivision_Validation_ShouldRejectNullName()
    {
        Assert.Throws<ArgumentNullException>(() => new Subdivision("US-CA", null!, "State"));
    }

    [Fact]
    public void Subdivision_NullType_ShouldDefaultToEmpty()
    {
        // Subdivision constructor uses null-coalescing for Type
        var sub = new Subdivision("US-CA", "California", null!);
        Assert.Equal(string.Empty, sub.Type);
    }

    [Fact]
    public void Subdivision_ToString_ShouldReturnNameAndType()
    {
        var sub = new Subdivision("US-CA", "California", "State");
        var str = sub.ToString();
        Assert.Contains("California", str);
    }
}
