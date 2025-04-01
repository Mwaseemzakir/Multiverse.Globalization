using Multiverse.Models;
using Xunit;

namespace Multiverse.UnitTests;

public class CountryTests
{
    [Fact]
    public void GetAllLanguages_Should_ReturnAllLanguages()
    {
        List<Country>? countries = Country
            .GetAll()
            .ToList();

        Assert.NotNull(countries);

        Assert.Contains(Country.None, countries);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_ReturnTrueForValidCode()
    {
        string pakAlpha2Code = Country.Pakistan.Alpha2Code;

        bool isValid = Country.IsValidAlpha2Code(pakAlpha2Code);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_IgnoreCaseSensitivity()
    {
        string pakAlpha2Code = Country.Pakistan.Alpha2Code.ToLower();

        bool isValid = Country.IsValidAlpha2Code(pakAlpha2Code);

        Assert.True(isValid);
    }
}
