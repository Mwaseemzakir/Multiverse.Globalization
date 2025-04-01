using Multiverse.Countries;
using Xunit;

namespace Multiverse.UnitTests;

public class CountryTests
{
    [Fact]
    public void GetAll_Should_ReturnAllCountries()
    {
        List<Country>? countries = Country
            .GetAll();

        Assert.NotNull(countries);

        Assert.Contains(CountryHelper.None, countries);
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        string pakAlpha2Code = CountryHelper.Pakistan.Alpha2Code;

        bool isValid = Country.IsValid(pakAlpha2Code);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        string pakAlpha2Code = CountryHelper.Pakistan.Alpha2Code.ToLower();

        bool isValid = Country.IsValid(pakAlpha2Code);

        Assert.True(isValid);
    }
}
