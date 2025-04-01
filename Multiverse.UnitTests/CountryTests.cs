using Multiverse.Models;
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

        Assert.Contains(CountryHelpers.None, countries);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_ReturnTrueForValidCode()
    {
        string pakAlpha2Code = CountryHelpers.Pakistan.Alpha2Code;

        bool isValid = Country.IsValidAlpha2Code(pakAlpha2Code);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_IgnoreCaseSensitivity()
    {
        string pakAlpha2Code = CountryHelpers.Pakistan.Alpha2Code.ToLower();

        bool isValid = Country.IsValidAlpha2Code(pakAlpha2Code);

        Assert.True(isValid);
    }
}
