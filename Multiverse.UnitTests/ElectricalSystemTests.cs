using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Electrical;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class ElectricalSystemTests
{
    [Fact]
    public void US_ElectricalSystem_Should_Be120V_60Hz()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.ElectricalSystem);
        Assert.Equal(120, us.ElectricalSystem!.Voltage);
        Assert.Equal(60, us.ElectricalSystem.Frequency);
    }

    [Fact]
    public void US_ElectricalSystem_Should_HavePlugTypesAandB()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.ElectricalSystem);
        Assert.Contains(PlugType.A, us.ElectricalSystem!.PlugTypes);
        Assert.Contains(PlugType.B, us.ElectricalSystem.PlugTypes);
    }

    [Fact]
    public void GB_ElectricalSystem_Should_Be230V_50Hz()
    {
        var gb = Country.GetCountry("GB");
        Assert.NotNull(gb.ElectricalSystem);
        Assert.Equal(230, gb.ElectricalSystem!.Voltage);
        Assert.Equal(50, gb.ElectricalSystem.Frequency);
    }

    [Fact]
    public void GB_ElectricalSystem_Should_HavePlugTypeG()
    {
        var gb = Country.GetCountry("GB");
        Assert.NotNull(gb.ElectricalSystem);
        Assert.Contains(PlugType.G, gb.ElectricalSystem!.PlugTypes);
    }

    [Fact]
    public void Japan_ElectricalSystem_Should_Be100V()
    {
        var jp = Country.GetCountry("JP");
        Assert.NotNull(jp.ElectricalSystem);
        Assert.Equal(100, jp.ElectricalSystem!.Voltage);
    }

    [Fact]
    public void ElectricalSystem_Should_HaveValidVoltage()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.ElectricalSystem != null)
            {
                Assert.True(country.ElectricalSystem.Voltage > 0 && country.ElectricalSystem.Voltage <= 250,
                    $"{country.Name} has invalid voltage: {country.ElectricalSystem.Voltage}");
            }
        }
    }

    [Fact]
    public void ElectricalSystem_Should_HaveValidFrequency()
    {
        var validFreqs = new[] { 50, 60 };
        foreach (var country in Country.GetAll())
        {
            if (country.ElectricalSystem != null)
            {
                Assert.Contains(country.ElectricalSystem.Frequency, validFreqs);
            }
        }
    }

    [Fact]
    public void ElectricalSystem_Should_HaveAtLeastOnePlugType()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.ElectricalSystem != null)
            {
                Assert.NotEmpty(country.ElectricalSystem.PlugTypes);
            }
        }
    }

    [Fact]
    public void ElectricalSystem_Validation_ShouldRejectInvalidVoltage()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectricalSystem(0, 50, PlugType.A));
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectricalSystem(-1, 50, PlugType.A));
    }

    [Fact]
    public void ElectricalSystem_Validation_ShouldRejectInvalidFrequency()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectricalSystem(230, 0, PlugType.A));
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectricalSystem(230, -1, PlugType.A));
    }

    [Fact]
    public void ElectricalSystem_NoPlugTypes_ShouldCreateEmptyList()
    {
        var es = new ElectricalSystem(230, 50);
        Assert.Empty(es.PlugTypes);
    }

    [Fact]
    public void PlugType_Should_HaveAtLeast13Values()
    {
        var values = Enum.GetValues(typeof(PlugType));
        Assert.True(values.Length >= 13, "There should be at least 13 plug types (A through O)");
    }
}
