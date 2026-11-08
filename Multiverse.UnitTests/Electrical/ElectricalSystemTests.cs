namespace Multiverse.Globalization.UnitTests.Electrical;

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
            if (country.ElectricalSystem != null)
                Assert.True(country.ElectricalSystem.Voltage > 0 && country.ElectricalSystem.Voltage <= 250,
                    $"{country.Name} has invalid voltage: {country.ElectricalSystem.Voltage}");
    }

    [Fact]
    public void ElectricalSystem_Should_HaveValidFrequency()
    {
        var validFreqs = new[] { 50, 60 };
        foreach (var country in Country.GetAll())
            if (country.ElectricalSystem != null)
                Assert.Contains(country.ElectricalSystem.Frequency, validFreqs);
    }

    [Fact]
    public void ElectricalSystem_Should_HaveAtLeastOnePlugType()
    {
        foreach (var country in Country.GetAll())
            if (country.ElectricalSystem != null)
                Assert.NotEmpty(country.ElectricalSystem.PlugTypes);
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

    [Fact]
    public void PlugType_Should_HaveExactly15Values_AThroughO()
    {
        var values = Enum.GetValues(typeof(PlugType)).Cast<PlugType>().ToList();
        Assert.Equal(15, values.Count);
        Assert.Equal(PlugType.A, values.Min());
        Assert.Equal(PlugType.O, values.Max());
    }

    [Fact]
    public void ToString_Should_ReturnVoltageAndFrequency()
    {
        var es = new ElectricalSystem(230, 50, PlugType.C, PlugType.F);
        Assert.Equal("230V / 50Hz", es.ToString());
    }

    #region ElectricalSystemHelper.GetElectricalSystemForCountry Edge Cases

    [Fact]
    public void GetElectricalSystemForCountry_NullCode_ReturnsNull()
    {
        Assert.Null(ElectricalSystemHelper.GetElectricalSystemForCountry(null!));
    }

    [Fact]
    public void GetElectricalSystemForCountry_EmptyCode_ReturnsNull()
    {
        Assert.Null(ElectricalSystemHelper.GetElectricalSystemForCountry(""));
    }

    [Fact]
    public void GetElectricalSystemForCountry_InvalidCode_ReturnsNull()
    {
        Assert.Null(ElectricalSystemHelper.GetElectricalSystemForCountry("XX"));
    }

    [Fact]
    public void GetElectricalSystemForCountry_LowercaseCode_ShouldStillWork()
    {
        var system = ElectricalSystemHelper.GetElectricalSystemForCountry("us");
        Assert.NotNull(system);
        Assert.Equal(120, system!.Voltage);
    }

    #endregion

    #region ElectricalSystemHelper.All

    [Fact]
    public void ElectricalSystemHelper_All_Should_NotBeEmpty()
    {
        Assert.NotEmpty(ElectricalSystemHelper.All);
    }

    [Fact]
    public void ElectricalSystemHelper_All_Should_ContainKnownCountries()
    {
        Assert.True(ElectricalSystemHelper.All.ContainsKey("US"));
        Assert.True(ElectricalSystemHelper.All.ContainsKey("GB"));
        Assert.True(ElectricalSystemHelper.All.ContainsKey("PK"));
    }

    [Fact]
    public void ElectricalSystemHelper_All_KeysShouldBeUppercaseAlpha2()
    {
        foreach (var key in ElectricalSystemHelper.All.Keys)
        {
            Assert.Equal(2, key.Length);
            Assert.Equal(key.ToUpperInvariant(), key);
        }
    }

    #endregion
}