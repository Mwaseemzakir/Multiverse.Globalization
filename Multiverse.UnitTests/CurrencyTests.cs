using Multiverse.Globalization.Currencies;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CurrencyTests
{
    [Fact]
    public void GetAll_Should_ReturnAllCurrencies()
    {
        List<Currency>? currencies = Currency.GetAll();

        Assert.NotNull(currencies);
        Assert.NotEmpty(currencies);
        Assert.Contains(currencies, c => c.Code == "USD" && c.Name == "US Dollar");
        Assert.Contains(currencies, c => c.Code == "EUR" && c.Name == "Euro");
        Assert.Contains(currencies, c => c.Code == "GBP" && c.Name == "Pound Sterling");
        Assert.Contains(currencies, c => c.Code == "PKR" && c.Name == "Pakistan Rupee");
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        // Test major currencies
        Assert.True(Currency.IsValid(CurrencyHelper.UsDollar.Code));
        Assert.True(Currency.IsValid(CurrencyHelper.Euro.Code));
        Assert.True(Currency.IsValid(CurrencyHelper.PoundSterling.Code));
        Assert.True(Currency.IsValid(CurrencyHelper.PakistanRupee.Code));
        Assert.True(Currency.IsValid(CurrencyHelper.Yen.Code));
        Assert.True(Currency.IsValid(CurrencyHelper.SwissFranc.Code));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Currency.IsValid("XXX")); // Invalid 3-letter code
        Assert.False(Currency.IsValid("XX")); // Too short
        Assert.False(Currency.IsValid("USDD")); // Too long
        Assert.False(Currency.IsValid("")); // Empty string
        Assert.False(Currency.IsValid(null)); // Null
        Assert.False(Currency.IsValid("123")); // Numeric code
        Assert.False(Currency.IsValid("!@#")); // Special characters
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        // Test with different cases
        Assert.True(Currency.IsValid(CurrencyHelper.UsDollar.Code.ToLower()));
        Assert.True(Currency.IsValid(CurrencyHelper.UsDollar.Code.ToUpper()));
        Assert.True(Currency.IsValid("uSd"));
        Assert.True(Currency.IsValid("eUr"));
    }

    [Fact]
    public void Currency_Properties_Should_BeCorrect()
    {
        // Test USD properties
        var usd = CurrencyHelper.UsDollar;
        Assert.Equal("USD", usd.Code);
        Assert.Equal("US Dollar", usd.Name);
        Assert.Equal("$", usd.Symbol);
        Assert.Equal(840, usd.Number);

        // Test EUR properties
        var eur = CurrencyHelper.Euro;
        Assert.Equal("EUR", eur.Code);
        Assert.Equal("Euro", eur.Name);
        Assert.Equal("€", eur.Symbol);
        Assert.Equal(978, eur.Number);

        // Test GBP properties
        var gbp = CurrencyHelper.PoundSterling;
        Assert.Equal("GBP", gbp.Code);
        Assert.Equal("Pound Sterling", gbp.Name);
        Assert.Equal("£", gbp.Symbol);
        Assert.Equal(826, gbp.Number);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateCodes()
    {
        var currencies = Currency.GetAll();
        
        // Check for duplicate codes
        var codes = currencies.Select(c => c.Code.ToUpperInvariant())
                            .Where(code => !string.IsNullOrEmpty(code))
                            .ToList();
        Assert.Equal(codes.Count, codes.Distinct().Count());
    }

    [Fact]
    public void Currency_Equality_Should_Work()
    {
        var usd1 = CurrencyHelper.UsDollar;
        var usd2 = new Currency(840, "US Dollar", "USD", "$");
        var eur = CurrencyHelper.Euro;

        // Test equality
        Assert.Equal(usd1.Code, usd2.Code);
        Assert.Equal(usd1.Name, usd2.Name);
        Assert.Equal(usd1.Symbol, usd2.Symbol);
        Assert.Equal(usd1.Number, usd2.Number);

        // Test inequality
        Assert.NotEqual(usd1.Code, eur.Code);
        Assert.NotEqual(usd1.Name, eur.Name);
        Assert.NotEqual(usd1.Symbol, eur.Symbol);
        Assert.NotEqual(usd1.Number, eur.Number);
    }
}