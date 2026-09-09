namespace Multiverse.Globalization.UnitTests.Countries;

public class EmergencyNumberTests
{
    [Fact]
    public void US_EmergencyNumbers_Should_Include911()
    {
        var us = Country.GetCountry("US");
        Assert.NotEmpty(us.EmergencyNumbers);
        Assert.Contains("911", us.EmergencyNumbers);
    }

    [Fact]
    public void GB_EmergencyNumbers_Should_Include999_And_112()
    {
        var gb = Country.GetCountry("GB");
        Assert.NotEmpty(gb.EmergencyNumbers);
        Assert.Contains("999", gb.EmergencyNumbers);
        Assert.Contains("112", gb.EmergencyNumbers);
    }

    [Fact]
    public void Germany_EmergencyNumbers_Should_Include112()
    {
        var de = Country.GetCountry("DE");
        Assert.NotEmpty(de.EmergencyNumbers);
        Assert.Contains("112", de.EmergencyNumbers);
    }

    [Fact]
    public void Pakistan_EmergencyNumbers_Should_Include115()
    {
        var pk = Country.GetCountry("PK");
        Assert.NotEmpty(pk.EmergencyNumbers);
        Assert.Contains("115", pk.EmergencyNumbers);
    }

    [Fact]
    public void AllCountriesWithEmergencyNumbers_Should_HaveNonEmptyEntries()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.EmergencyNumbers.Count > 0)
            {
                Assert.All(country.EmergencyNumbers, num =>
                    Assert.False(string.IsNullOrWhiteSpace(num), $"{country.Name} has empty emergency number"));
            }
        }
    }

    [Fact]
    public void CountryWithoutEmergencyNumbers_Should_ReturnEmptyList()
    {
        // The sentinel "no country" record has an empty Alpha2Code and no emergency number data
        var none = CountryHelper.None;
        Assert.NotNull(none.EmergencyNumbers);
        Assert.Empty(none.EmergencyNumbers);
    }

    [Fact]
    public void AllCountries_Should_HaveEmergencyNumberData()
    {
        // Every current/legacy country record has at least one emergency number defined
        var missing = Country.GetAll()
            .Where(c => !c.Equals(CountryHelper.None) && c.EmergencyNumbers.Count == 0)
            .Select(c => c.Alpha2Code)
            .ToList();

        Assert.Empty(missing);
    }

    #region EmergencyNumberHelper.GetEmergencyNumbersForCountry Edge Cases

    [Fact]
    public void GetEmergencyNumbersForCountry_NullCode_ReturnsEmpty()
    {
        var result = EmergencyNumberHelper.GetEmergencyNumbersForCountry(null!);
        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void GetEmergencyNumbersForCountry_EmptyCode_ReturnsEmpty()
    {
        var result = EmergencyNumberHelper.GetEmergencyNumbersForCountry("");
        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void GetEmergencyNumbersForCountry_InvalidCode_ReturnsEmpty()
    {
        var result = EmergencyNumberHelper.GetEmergencyNumbersForCountry("XX");
        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public void GetEmergencyNumbersForCountry_LowercaseCode_ShouldStillWork()
    {
        var result = EmergencyNumberHelper.GetEmergencyNumbersForCountry("us");
        Assert.Contains("911", result);
    }

    #endregion

    #region EmergencyNumberHelper.All

    [Fact]
    public void EmergencyNumberHelper_All_Should_NotBeEmpty()
    {
        Assert.NotEmpty(EmergencyNumberHelper.All);
    }

    [Fact]
    public void EmergencyNumberHelper_All_Should_ContainKnownCountries()
    {
        Assert.True(EmergencyNumberHelper.All.ContainsKey("US"));
        Assert.True(EmergencyNumberHelper.All.ContainsKey("GB"));
        Assert.True(EmergencyNumberHelper.All.ContainsKey("PK"));
    }

    [Fact]
    public void EmergencyNumberHelper_All_KeysShouldBeUppercaseAlpha2()
    {
        foreach (var key in EmergencyNumberHelper.All.Keys)
        {
            Assert.Equal(2, key.Length);
            Assert.Equal(key.ToUpperInvariant(), key);
        }
    }

    #endregion
}
