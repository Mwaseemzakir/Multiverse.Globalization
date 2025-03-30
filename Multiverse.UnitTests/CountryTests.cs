using Multiverse.Models;
using Xunit;

namespace Multiverse.UnitTests;

public class CountryTests
{
    [Fact]
    public void GetAllCountries_Should_ReturnAllCountries()
    {
        List<Country>? countries = Country
            .GetAllCountries()
            .ToList();

        Assert.NotNull(countries);
        Assert.Contains(Country.None, countries);
        Assert.Contains(Country.Pakistan, countries);
        Assert.Contains(Country.UnitedKingdom, countries);
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

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("A")] // Too short
    [InlineData("ABC")] // Too long
    [InlineData("XX")] // Non-existent code
    public void IsValidAlpha2Code_Should_ReturnFalseForInvalidCodes(string code)
    {
        bool isValid = Country.IsValidAlpha2Code(code);
        Assert.False(isValid);
    }

    [Fact]
    public void IsValidAlpha3Code_Should_ReturnTrueForValidCode()
    {
        string pakAlpha3Code = Country.Pakistan.Alpha3Code;
        bool isValid = Country.IsValidAlpha3Code(pakAlpha3Code);
        Assert.True(isValid);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("AB")] // Too short
    [InlineData("ABCD")] // Too long
    [InlineData("XYZ")] // Non-existent code
    public void IsValidAlpha3Code_Should_ReturnFalseForInvalidCodes(string code)
    {
        bool isValid = Country.IsValidAlpha3Code(code);
        Assert.False(isValid);
    }

    [Fact]
    public void GetCountryByAlpha2Code_Should_ReturnCorrectCountry()
    {
        Country country = Country.GetCountryByAlpha2Code("PK");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void GetCountryByAlpha2Code_Should_ThrowForNullOrEmpty(string? code)
    {
        Assert.Throws<KeyNotFoundException>(() => Country.GetCountryByAlpha2Code(code));
    }

    [Fact]
    public void GetCountryByAlpha3Code_Should_ReturnCorrectCountry()
    {
        Country country = Country.GetCountryByAlpha3Code("PAK");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void GetCountryByAlpha3Code_Should_ThrowForNullOrEmpty(string? code)
    {
        Assert.Throws<KeyNotFoundException>(() => Country.GetCountryByAlpha3Code(code));
    }

    [Fact]
    public void GetCountryByNumericCode_Should_ReturnCorrectCountry()
    {
        Country country = Country.GetCountryByNumericCode("586");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Fact]
    public void GetCountryByNumericCode_Should_ThrowForInvalidCode()
    {
        Assert.Throws<KeyNotFoundException>(() => Country.GetCountryByNumericCode("999"));
    }

    [Fact]
    public void TryGetCountryByAlpha2Code_Should_ReturnTrueForValidCode()
    {
        bool success = Country.TryGetCountryByAlpha2Code("PK", out Country country);
        Assert.True(success);
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Fact]
    public void TryGetCountryByAlpha2Code_Should_ReturnFalseForInvalidCode()
    {
        bool success = Country.TryGetCountryByAlpha2Code("XX", out Country country);
        Assert.False(success);
        Assert.Equal(Country.None, country);
    }

    [Fact]
    public void TryGetCountryByAlpha3Code_Should_ReturnTrueForValidCode()
    {
        bool success = Country.TryGetCountryByAlpha3Code("PAK", out Country country);
        Assert.True(success);
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Fact]
    public void TryGetCountryByAlpha3Code_Should_ReturnFalseForInvalidCode()
    {
        bool success = Country.TryGetCountryByAlpha3Code("XYZ", out Country country);
        Assert.False(success);
        Assert.Equal(Country.None, country);
    }

    [Fact]
    public void TryGetCountryByNumericCode_Should_ReturnTrueForValidCode()
    {
        bool success = Country.TryGetCountryByNumericCode("586", out Country country);
        Assert.True(success);
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Fact]
    public void TryGetCountryByNumericCode_Should_ReturnFalseForInvalidCode()
    {
        bool success = Country.TryGetCountryByNumericCode("999", out Country country);
        Assert.False(success);
        Assert.Equal(Country.None, country);
    }

    [Fact]
    public void ParseCountry_Should_HandleAlpha2Input()
    {
        Country country = Country.ParseCountry("PK");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Fact]
    public void ParseCountry_Should_HandleAlpha3Input()
    {
        Country country = Country.ParseCountry("PAK");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Fact]
    public void ParseCountry_Should_HandleNumericInput()
    {
        Country country = Country.ParseCountry("586");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Equal("PAK", country.Alpha3Code);
        Assert.Equal("586", country.NumericCode);
        Assert.Equal("Pakistan", country.Name);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ParseCountry_Should_ThrowForInvalidInput(string code)
    {
        Assert.Throws<ArgumentException>(() => Country.ParseCountry(code));
    }

    [Fact]
    public void GetAllAlpha2Codes_Should_ReturnAllCodes()
    {
        var codes = Country.GetAllAlpha2Codes().ToList();
        Assert.Contains("PK", codes);
        Assert.Contains("GB", codes);
        Assert.Contains("DE", codes);
        Assert.DoesNotContain("XX", codes);
    }

    [Fact]
    public void GetAllAlpha3Codes_Should_ReturnAllCodes()
    {
        var codes = Country.GetAllAlpha3Codes().ToList();
        Assert.Contains("PAK", codes);
        Assert.Contains("GBR", codes);
        Assert.Contains("DEU", codes);
        Assert.DoesNotContain("XYZ", codes);
    }

    [Fact]
    public void GetAllNumericCodes_Should_ReturnAllCodes()
    {
        var codes = Country.GetAllNumericCodes().ToList();
        Assert.Contains("586", codes); // Pakistan
        Assert.Contains("826", codes); // GBR
        Assert.Contains("276", codes); // DEU
        Assert.DoesNotContain("999", codes);
    }

    [Fact]
    public void CountryCount_Should_ReturnCorrectCount()
    {
        int count = Country.CountryCount;
        Assert.Equal(Country.GetAllCountries().Count(), count);
        Assert.Equal(Country.GetAllAlpha2Codes().Count(), count);
        Assert.Equal(Country.GetAllAlpha3Codes().Count(), count);
        Assert.Equal(Country.GetAllNumericCodes().Count(), count);
    }

    [Fact]
    public void None_Should_HaveEmptyProperties()
    {
        Assert.Equal(string.Empty, Country.None.Alpha2Code);
        Assert.Equal(string.Empty, Country.None.Alpha3Code);
        Assert.Equal(string.Empty, Country.None.NumericCode);
        Assert.Equal(string.Empty, Country.None.Name);
    }

    [Fact]
    public void GetCurrencyByNumber_Should_ReturnCorrectCurrency()
    {
        Currency currency = Currency.GetCurrencyByNumber(978);
        Assert.Equal("EUR", currency.Code);
        Assert.Equal(978, currency.Number);
        Assert.Equal("Euro", currency.CurrencyName);
    }
}
