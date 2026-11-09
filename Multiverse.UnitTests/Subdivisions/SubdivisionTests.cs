namespace Multiverse.Globalization.UnitTests.Subdivisions;

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
            if (country.Subdivisions.Count > 0)
            {
                var codes = country.Subdivisions.Select(s => s.Code).ToList();
                Assert.Equal(codes.Count, codes.Distinct().Count());
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

    #region Equals and GetHashCode

    [Fact]
    public void Equals_SameCode_Should_ReturnTrue()
    {
        var a = new Subdivision("US-CA", "California", "State");
        var b = new Subdivision("US-CA", "California (alt name)", "Province");

        Assert.Equal(a, b);
        Assert.True(a.Equals(b));
    }

    [Fact]
    public void Equals_DifferentCode_Should_ReturnFalse()
    {
        var a = new Subdivision("US-CA", "California", "State");
        var b = new Subdivision("US-NY", "New York", "State");

        Assert.NotEqual(a, b);
    }

    [Fact]
    public void Equals_NonSubdivisionObject_Should_ReturnFalse()
    {
        var a = new Subdivision("US-CA", "California", "State");
        Assert.False(a.Equals((object)"US-CA"));
    }

    [Fact]
    public void Equals_Null_Should_ReturnFalse()
    {
        var a = new Subdivision("US-CA", "California", "State");
        Assert.False(a.Equals(null));
    }

    [Fact]
    public void GetHashCode_SameCode_Should_ReturnSameHash()
    {
        var a = new Subdivision("US-CA", "California", "State");
        var b = new Subdivision("US-CA", "California", "State");

        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    #endregion

    #region SubdivisionHelper.GetSubdivisionsForCountry Edge Cases

    [Fact]
    public void GetSubdivisionsForCountry_NullCode_ReturnsEmpty()
    {
        var result = SubdivisionHelper.GetSubdivisionsForCountry(null!);
        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void GetSubdivisionsForCountry_EmptyCode_ReturnsEmpty()
    {
        var result = SubdivisionHelper.GetSubdivisionsForCountry("");
        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void GetSubdivisionsForCountry_InvalidCode_ReturnsEmpty()
    {
        var result = SubdivisionHelper.GetSubdivisionsForCountry("XX");
        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void GetSubdivisionsForCountry_LowercaseCode_ShouldStillWork()
    {
        var result = SubdivisionHelper.GetSubdivisionsForCountry("us");
        Assert.Equal(51, result.Count);
    }

    #endregion

    #region SubdivisionHelper.All

    [Fact]
    public void SubdivisionHelper_All_Should_NotBeEmpty()
    {
        Assert.NotEmpty(SubdivisionHelper.All);
    }

    [Fact]
    public void SubdivisionHelper_All_Should_ContainKnownCountries()
    {
        Assert.True(SubdivisionHelper.All.ContainsKey("US"));
        Assert.True(SubdivisionHelper.All.ContainsKey("CA"));
        Assert.True(SubdivisionHelper.All.ContainsKey("PK"));
    }

    [Fact]
    public void SubdivisionHelper_All_KeysShouldBeUppercaseAlpha2()
    {
        foreach (var key in SubdivisionHelper.All.Keys)
        {
            Assert.Equal(2, key.Length);
            Assert.Equal(key.ToUpperInvariant(), key);
        }
    }

    #endregion
}
