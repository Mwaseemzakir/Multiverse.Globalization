using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class PoliticalDataTests
{
    [Theory]
    [InlineData("US")]
    [InlineData("GB")]
    [InlineData("FR")]
    [InlineData("DE")]
    [InlineData("JP")]
    [InlineData("IN")]
    [InlineData("BR")]
    [InlineData("AU")]
    [InlineData("PK")]
    public void MajorCountry_Should_BeUnMember(string alpha2)
    {
        var country = Country.GetCountry(alpha2);
        Assert.True(country.IsUnMember, $"{country.Name} should be a UN member");
    }

    [Theory]
    [InlineData("TW")]  // Taiwan
    [InlineData("HK")]  // Hong Kong
    [InlineData("PR")]  // Puerto Rico
    public void NonUnMemberTerritory_Should_NotBeUnMember(string alpha2)
    {
        var country = Country.GetCountry(alpha2);
        Assert.False(country.IsUnMember, $"{country.Name} should not be a UN member");
    }

    [Fact]
    public void US_IndependenceDate_Should_BeJuly4_1776()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.IndependenceDate);
        Assert.Equal(new DateTime(1776, 7, 4), us.IndependenceDate!.Value);
    }

    [Fact]
    public void Pakistan_IndependenceDate_Should_BeAug14_1947()
    {
        var pk = Country.GetCountry("PK");
        Assert.NotNull(pk.IndependenceDate);
        Assert.Equal(new DateTime(1947, 8, 14), pk.IndependenceDate!.Value);
    }

    [Fact]
    public void India_IndependenceDate_Should_BeAug15_1947()
    {
        var india = Country.GetCountry("IN");
        Assert.NotNull(india.IndependenceDate);
        Assert.Equal(new DateTime(1947, 8, 15), india.IndependenceDate!.Value);
    }

    [Fact]
    public void GB_IndependenceDate_Should_BeNull()
    {
        var gb = Country.GetCountry("GB");
        Assert.Null(gb.IndependenceDate);
    }

    [Fact]
    public void Japan_IndependenceDate_Should_BeNull()
    {
        var jp = Country.GetCountry("JP");
        Assert.Null(jp.IndependenceDate);
    }
}
