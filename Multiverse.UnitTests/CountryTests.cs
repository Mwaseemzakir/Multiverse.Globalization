using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CountryTests
{
    [Fact]
    public void GetAll_Should_ReturnAllCountries()
    {
        List<Country>? countries = Country.GetAll();

        Assert.NotNull(countries);
        Assert.NotEmpty(countries);
        Assert.Contains(CountryHelper.None, countries);
        Assert.Contains(countries, c => c.Alpha2Code == "US" && c.Alpha3Code == "USA" && c.Name == "United States of America");
        Assert.Contains(countries, c => c.Alpha2Code == "GB" && c.Alpha3Code == "GBR" && c.Name == "United Kingdom");
        Assert.Contains(countries, c => c.Alpha2Code == "FR" && c.Alpha3Code == "FRA" && c.Name == "France");
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        // Test with Alpha2 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha2Code));
        Assert.True(Country.IsValid(CountryHelper.UnitedKingdom.Alpha2Code));
        Assert.True(Country.IsValid(CountryHelper.France.Alpha2Code));
        Assert.True(Country.IsValid(CountryHelper.Pakistan.Alpha2Code));

        // Test with Alpha3 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha3Code));
        Assert.True(Country.IsValid(CountryHelper.UnitedKingdom.Alpha3Code));
        Assert.True(Country.IsValid(CountryHelper.France.Alpha3Code));
        Assert.True(Country.IsValid(CountryHelper.Pakistan.Alpha3Code));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Country.IsValid("XX")); // Invalid 2-letter code
        Assert.False(Country.IsValid("XXX")); // Invalid 3-letter code
        Assert.False(Country.IsValid("")); // Empty string
        Assert.False(Country.IsValid(null)); // Null
        Assert.False(Country.IsValid("12")); // Numeric code
        Assert.False(Country.IsValid("!@")); // Special characters
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        // Test with Alpha2 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha2Code.ToLower()));
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha2Code.ToUpper()));
        
        // Test with Alpha3 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha3Code.ToLower()));
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha3Code.ToUpper()));
    }

    [Fact]
    public void Country_Properties_Should_BeCorrect()
    {
        // Test US properties
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.Equal("US", us.Alpha2Code);
        Assert.Equal("USA", us.Alpha3Code);
        Assert.Equal("840", us.NumericCode);
        Assert.Equal("United States of America", us.Name);

        // Test UK properties
        var uk = CountryHelper.UnitedKingdom;
        Assert.Equal("GB", uk.Alpha2Code);
        Assert.Equal("GBR", uk.Alpha3Code);
        Assert.Equal("826", uk.NumericCode);
        Assert.Equal("United Kingdom", uk.Name);

        // Test None properties
        var none = CountryHelper.None;
        Assert.Equal(string.Empty, none.Alpha2Code);
        Assert.Equal(string.Empty, none.Alpha3Code);
        Assert.Equal(string.Empty, none.NumericCode);
        Assert.Equal(string.Empty, none.Name);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateCodes()
    {
        var countries = Country.GetAll();
        
        // Check for duplicate Alpha2 codes
        var alpha2Codes = countries.Select(c => c.Alpha2Code.ToUpperInvariant())
                                 .Where(code => !string.IsNullOrEmpty(code))
                                 .ToList();
        Assert.Equal(alpha2Codes.Count, alpha2Codes.Distinct().Count());

        // Check for duplicate Alpha3 codes
        var alpha3Codes = countries.Select(c => c.Alpha3Code.ToUpperInvariant())
                                 .Where(code => !string.IsNullOrEmpty(code))
                                 .ToList();
        Assert.Equal(alpha3Codes.Count, alpha3Codes.Distinct().Count());

        // Check for duplicate numeric codes
        var numericCodes = countries.Select(c => c.NumericCode)
                                  .Where(code => !string.IsNullOrEmpty(code))
                                  .ToList();
        Assert.Equal(numericCodes.Count, numericCodes.Distinct().Count());
    }

    [Fact]
    public void Country_Equality_Should_Work()
    {
        var us1 = CountryHelper.UnitedStatesOfAmerica;
        var us2 = new Country("United States of America", "840", "US", "USA");
        var uk = CountryHelper.UnitedKingdom;

        // Test equality
        Assert.Equal(us1.Alpha2Code, us2.Alpha2Code);
        Assert.Equal(us1.Alpha3Code, us2.Alpha3Code);
        Assert.Equal(us1.NumericCode, us2.NumericCode);
        Assert.Equal(us1.Name, us2.Name);

        // Test inequality
        Assert.NotEqual(us1.Alpha2Code, uk.Alpha2Code);
        Assert.NotEqual(us1.Alpha3Code, uk.Alpha3Code);
        Assert.NotEqual(us1.NumericCode, uk.NumericCode);
        Assert.NotEqual(us1.Name, uk.Name);
    }
}
