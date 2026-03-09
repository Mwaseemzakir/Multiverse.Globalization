using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

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
}
