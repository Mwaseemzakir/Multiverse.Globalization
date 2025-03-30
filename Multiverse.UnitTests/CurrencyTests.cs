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
}