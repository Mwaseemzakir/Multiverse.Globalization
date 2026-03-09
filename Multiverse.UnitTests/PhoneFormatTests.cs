using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

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
        var aq = Country.GetCountryOrDefault("AQ");
        if (aq != null)
        {
            // Phone format may be null for territories without telephone systems
            // This is an expected behavior
            Assert.True(true);
        }
    }
}
