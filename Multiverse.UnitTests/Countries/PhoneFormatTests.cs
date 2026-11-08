namespace Multiverse.Globalization.UnitTests.Countries;

public class PhoneFormatTests
{
    [Fact]
    public void US_PhoneFormat_Should_HaveCorrectData()
    {
        var us = Country.GetCountry("US");
        Assert.NotNull(us.PhoneFormat);
        Assert.True(us.PhoneFormat!.MinLength > 0);
        Assert.True(us.PhoneFormat.MaxLength >= us.PhoneFormat.MinLength);
    }

    [Fact]
    public void UK_PhoneFormat_Should_HaveCorrectData()
    {
        var gb = Country.GetCountry("GB");
        Assert.NotNull(gb.PhoneFormat);
        Assert.True(gb.PhoneFormat!.MinLength > 0);
    }

    [Fact]
    public void PhoneFormat_MaxLength_ShouldBeGreaterOrEqualToMinLength()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.PhoneFormat != null)
            {
                Assert.True(country.PhoneFormat.MaxLength >= country.PhoneFormat.MinLength,
                    $"{country.Name} has PhoneFormat.MaxLength < MinLength");
            }
        }
    }

    [Fact]
    public void PhoneFormat_NullPrefixes_ShouldDefaultToEmpty()
    {
        // PhoneFormat constructor uses null-coalescing
        var pf = new PhoneFormat(7, 10, null!, null!);
        Assert.Equal(string.Empty, pf.TrunkPrefix);
        Assert.Equal(string.Empty, pf.InternationalPrefix);
    }

    [Fact]
    public void PhoneFormat_ShouldStoreValues()
    {
        var pf = new PhoneFormat(7, 10, "0", "00");
        Assert.Equal(7, pf.MinLength);
        Assert.Equal(10, pf.MaxLength);
        Assert.Equal("0", pf.TrunkPrefix);
        Assert.Equal("00", pf.InternationalPrefix);
    }

    [Fact]
    public void CountryWithoutPhoneFormat_Should_ReturnNull()
    {
        // Antarctica doesn't have phone format data
        var aq = Country.GetCountry("AQ");
        Assert.Null(aq.PhoneFormat);
    }

    [Fact]
    public void ToString_Should_IncludeDigitsAndTrunkPrefix()
    {
        var pf = new PhoneFormat(10, 10, "1", "011");
        Assert.Equal("Digits: 10-10, Trunk: 1", pf.ToString());
    }

    #region PhoneFormatHelper.GetPhoneFormatForCountry Edge Cases

    [Fact]
    public void GetPhoneFormatForCountry_NullCode_ReturnsNull()
    {
        Assert.Null(PhoneFormatHelper.GetPhoneFormatForCountry(null!));
    }

    [Fact]
    public void GetPhoneFormatForCountry_EmptyCode_ReturnsNull()
    {
        Assert.Null(PhoneFormatHelper.GetPhoneFormatForCountry(""));
    }

    [Fact]
    public void GetPhoneFormatForCountry_WhitespaceCode_ReturnsNull()
    {
        Assert.Null(PhoneFormatHelper.GetPhoneFormatForCountry("   "));
    }

    [Fact]
    public void GetPhoneFormatForCountry_InvalidCode_ReturnsNull()
    {
        Assert.Null(PhoneFormatHelper.GetPhoneFormatForCountry("XX"));
    }

    [Fact]
    public void GetPhoneFormatForCountry_LowercaseCode_ShouldStillWork()
    {
        var format = PhoneFormatHelper.GetPhoneFormatForCountry("us");
        Assert.NotNull(format);
        Assert.Equal(10, format!.MinLength);
    }

    #endregion

    #region PhoneFormatHelper.All

    [Fact]
    public void PhoneFormatHelper_All_Should_NotBeEmpty()
    {
        Assert.NotEmpty(PhoneFormatHelper.All);
    }

    [Fact]
    public void PhoneFormatHelper_All_Should_ContainKnownCountries()
    {
        Assert.True(PhoneFormatHelper.All.ContainsKey("US"));
        Assert.True(PhoneFormatHelper.All.ContainsKey("GB"));
        Assert.True(PhoneFormatHelper.All.ContainsKey("PK"));
    }

    [Fact]
    public void PhoneFormatHelper_All_KeysShouldBeUppercaseAlpha2()
    {
        foreach (var key in PhoneFormatHelper.All.Keys)
        {
            Assert.Equal(2, key.Length);
            Assert.Equal(key.ToUpperInvariant(), key);
        }
    }

    #endregion
}
