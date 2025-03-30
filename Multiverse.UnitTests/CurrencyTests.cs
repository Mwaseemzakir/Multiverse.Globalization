using Multiverse.Models;
using Xunit;

namespace Multiverse.UnitTests;

public class CurrencyTests
{
    [Fact]
    public void GetAllCurrencies_Should_ReturnAllCurrencies()
    {
        List<Currency>? currencies = Currency
            .GetAllCurrencies()
            .ToList();

        Assert.NotNull(currencies);
        Assert.Contains(Currency.None, currencies);
        Assert.Contains(Currency.PKR, currencies);
        Assert.Contains(Currency.EUR, currencies);
    }

    [Fact]
    public void ValidIsoCode_Should_ReturnTrueForValidCode()
    {
        string pakCurrencyCode = Currency.PKR.Code;
        bool isValid = Currency.ValidIsoCode(pakCurrencyCode);
        Assert.True(isValid);
    }

    [Fact]
    public void ValidIsoCode_Should_IgnoreCaseSensitivity()
    {
        string pakCurrencyCode = Currency.PKR.Code.ToLower();
        bool isValid = Currency.ValidIsoCode(pakCurrencyCode);
        Assert.True(isValid);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("AB")] // Too short
    [InlineData("ABCD")] // Too long
    [InlineData("XYZ")] // Non-existent code
    public void ValidIsoCode_Should_ReturnFalseForInvalidCodes(string code)
    {
        bool isValid = Currency.ValidIsoCode(code);
        Assert.False(isValid);
    }

    [Fact]
    public void GetCurrencyByIsoCode_Should_ReturnCorrectCurrency()
    {
        Currency currency = Currency.GetCurrencyByIsoCode("PKR");
        Assert.Equal("PKR", currency.Code);
        Assert.Equal(586, currency.Number);
        Assert.Equal("Pakistan Rupee", currency.CurrencyName);
    }

    [Fact]
    public void GetCurrencyByIsoCode_Should_ThrowForInvalidCode()
    {
        Assert.Throws<KeyNotFoundException>(() => Currency.GetCurrencyByIsoCode("XYZ"));
    }

    [Fact]
    public void GetCurrencyByNumber_Should_ReturnCorrectCurrency()
    {
        Currency currency = Currency.GetCurrencyByNumber(978);
        Assert.Equal("EUR", currency.Code);
        Assert.Equal(978, currency.Number);
        Assert.Equal("Euro", currency.CurrencyName);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(999999)]
    public void GetCurrencyByNumber_Should_ThrowForInvalidNumber(int number)
    {
        Assert.Throws<KeyNotFoundException>(() => Currency.GetCurrencyByNumber(number));
    }

    [Fact]
    public void TryGetCurrencyByIsoCode_Should_ReturnTrueForValidCode()
    {
        bool success = Currency.TryGetCurrencyByIsoCode("PKR", out Currency currency);
        Assert.True(success);
        Assert.Equal("PKR", currency.Code);
        Assert.Equal("Pakistan Rupee", currency.CurrencyName);
    }

    [Fact]
    public void TryGetCurrencyByIsoCode_Should_ReturnFalseForInvalidCode()
    {
        bool success = Currency.TryGetCurrencyByIsoCode("XYZ", out Currency currency);
        Assert.False(success);
        Assert.Equal(Currency.None, currency);
    }

    [Fact]
    public void ParseCurrency_Should_HandleStringInput()
    {
        Currency currency = Currency.ParseCurrency("PKR");
        Assert.Equal("PKR", currency.Code);
        Assert.Equal("Pakistan Rupee", currency.CurrencyName);
    }

    [Fact]
    public void ParseCurrency_Should_HandleNumberInput()
    {
        Currency currency = Currency.ParseCurrency(586);
        Assert.Equal("PKR", currency.Code);
        Assert.Equal("Pakistan Rupee", currency.CurrencyName);
    }

    [Fact]
    public void ParseCurrency_Should_ThrowForInvalidInput()
    {
        Assert.Throws<ArgumentException>(() => Currency.ParseCurrency(new object()));
    }

    [Fact]
    public void GetAllIsoCodes_Should_ReturnAllCodes()
    {
        var codes = Currency.GetAllIsoCodes().ToList();
        Assert.Contains("PKR", codes);
        Assert.Contains("EUR", codes);
        Assert.Contains("GBP", codes);
        Assert.DoesNotContain("XYZ", codes);
    }

    [Fact]
    public void GetAllNumberCodes_Should_ReturnAllNumbers()
    {
        var numbers = Currency.GetAllNumberCodes().ToList();
        Assert.Contains(586, numbers); // PKR
        Assert.Contains(978, numbers); // EUR
        Assert.Contains(826, numbers); // GBP
        Assert.DoesNotContain(999999, numbers);
    }

    [Fact]
    public void CurrencyCount_Should_ReturnCorrectCount()
    {
        int count = Currency.CurrencyCount;
        Assert.Equal(Currency.GetAllCurrencies().Count(), count);
        Assert.Equal(Currency.GetAllIsoCodes().Count(), count);
        Assert.Equal(Currency.GetAllNumberCodes().Count(), count);
    }

    [Fact]
    public void None_Should_HaveEmptyProperties()
    {
        Assert.Equal(string.Empty, Currency.None.Code);
        Assert.Equal(0, Currency.None.Number);
        Assert.Equal(string.Empty, Currency.None.CurrencyName);
    }
}