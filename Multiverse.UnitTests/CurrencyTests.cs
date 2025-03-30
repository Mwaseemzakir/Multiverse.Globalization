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
}