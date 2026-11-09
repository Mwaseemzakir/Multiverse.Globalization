namespace Multiverse.Globalization.UnitTests.Countries;

public class PostalCodeValidationTests
{
    [Theory]
    [InlineData("94103")]
    [InlineData("94103-1234")]
    [InlineData("  90210  ")]
    public void IsValidPostalCode_Should_AcceptValidUsZipCodes(string zip)
    {
        var us = Country.GetCountry("US");

        Assert.True(us.Locale!.IsValidPostalCode(zip));
    }

    [Theory]
    [InlineData("9410")]
    [InlineData("941030")]
    [InlineData("ABCDE")]
    [InlineData("94103-12")]
    public void IsValidPostalCode_Should_RejectInvalidUsZipCodes(string zip)
    {
        var us = Country.GetCountry("US");

        Assert.False(us.Locale!.IsValidPostalCode(zip));
    }

    [Theory]
    [InlineData("K1A 0B1")]
    [InlineData("K1A0B1")]
    public void IsValidPostalCode_Should_AcceptCanadianPostalCodes(string postalCode)
    {
        var ca = Country.GetCountry("CA");

        Assert.True(ca.Locale!.IsValidPostalCode(postalCode));
    }

    [Fact]
    public void IsValidPostalCode_Should_AcceptDutchPostalCode()
    {
        var nl = Country.GetCountry("NL");

        Assert.True(nl.Locale!.IsValidPostalCode("1012 AB"));
        Assert.False(nl.Locale.IsValidPostalCode("1012"));
    }

    [Fact]
    public void IsValidPostalCode_Should_RejectNullAndBlankWhereCodesExist()
    {
        var us = Country.GetCountry("US");

        Assert.False(us.Locale!.IsValidPostalCode(null));
        Assert.False(us.Locale.IsValidPostalCode(string.Empty));
        Assert.False(us.Locale.IsValidPostalCode("   "));
    }

    [Fact]
    public void HasPostalCodes_Should_BeFalseForCountriesWithoutAPostalSystem()
    {
        var bolivia = Country.GetCountry("BO");

        Assert.False(bolivia.Locale!.HasPostalCodes);
    }

    [Fact]
    public void IsValidPostalCode_Should_OnlyAcceptBlankWhereCountryHasNoPostalSystem()
    {
        var bolivia = Country.GetCountry("BO");

        Assert.True(bolivia.Locale!.IsValidPostalCode(null));
        Assert.True(bolivia.Locale.IsValidPostalCode(string.Empty));
        Assert.False(bolivia.Locale.IsValidPostalCode("12345"));
    }

    [Fact]
    public void HasPostalCodes_Should_BeTrueWhereAPatternExists()
    {
        var us = Country.GetCountry("US");

        Assert.True(us.Locale!.HasPostalCodes);
    }

    [Fact]
    public void IsValidPostalCode_Should_NotThrowForAnyCountry()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.Locale is null)
                continue;

            // Every shipped pattern must compile and evaluate rather than throwing.
            country.Locale.IsValidPostalCode("12345");
            country.Locale.IsValidPostalCode("AB1 2CD");
        }
    }
}
