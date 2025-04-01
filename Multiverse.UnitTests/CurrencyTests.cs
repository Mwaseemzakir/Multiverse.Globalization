using Multiverse.Globalization.Currencies;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CurrencyTests
{
    [Fact]
    public void GetAll_Should_ReturnAllCurrencies()
    {
        List<Currency>? currencies = Currency
            .GetAll();

        Assert.NotNull(currencies);
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        string pakCurrencyCode = CurrencyHelper.PakistanRupee.Code;

        bool isValid = Currency.IsValid(pakCurrencyCode);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        string pakCurrencyCode = CurrencyHelper.PakistanRupee.Code.ToLower();

        bool isValid = Currency.IsValid(pakCurrencyCode);

        Assert.True(isValid);
    }
}