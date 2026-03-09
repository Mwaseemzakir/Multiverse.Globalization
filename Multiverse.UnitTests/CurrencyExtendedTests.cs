using Multiverse.Globalization.Currencies;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CurrencyExtendedTests
{
    #region Currency DecimalPlaces

    [Fact]
    public void USD_Should_Have2DecimalPlaces()
    {
        var usd = Currency.GetCurrency("USD");
        Assert.Equal(2, usd.DecimalPlaces);
    }

    [Fact]
    public void EUR_Should_Have2DecimalPlaces()
    {
        var eur = Currency.GetCurrency("EUR");
        Assert.Equal(2, eur.DecimalPlaces);
    }

    [Fact]
    public void GBP_Should_Have2DecimalPlaces()
    {
        var gbp = Currency.GetCurrency("GBP");
        Assert.Equal(2, gbp.DecimalPlaces);
    }

    [Fact]
    public void JPY_Should_Have0DecimalPlaces()
    {
        var jpy = Currency.GetCurrency("JPY");
        Assert.Equal(0, jpy.DecimalPlaces);
    }

    [Fact]
    public void KRW_Should_Have0DecimalPlaces()
    {
        var krw = Currency.GetCurrency("KRW");
        Assert.Equal(0, krw.DecimalPlaces);
    }

    [Theory]
    [InlineData("VND")]
    [InlineData("CLP")]
    [InlineData("PYG")]
    [InlineData("ISK")]
    [InlineData("HUF")]
    [InlineData("UGX")]
    [InlineData("BIF")]
    [InlineData("GNF")]
    [InlineData("RWF")]
    [InlineData("VUV")]
    [InlineData("XOF")]
    [InlineData("XAF")]
    [InlineData("XPF")]
    [InlineData("DJF")]
    public void ZeroDecimalCurrency_Should_Have0DecimalPlaces(string code)
    {
        var currency = Currency.GetCurrency(code);
        Assert.Equal(0, currency.DecimalPlaces);
    }

    [Theory]
    [InlineData("BHD")]
    [InlineData("KWD")]
    [InlineData("OMR")]
    [InlineData("TND")]
    [InlineData("LYD")]
    [InlineData("IQD")]
    [InlineData("JOD")]
    public void ThreeDecimalCurrency_Should_Have3DecimalPlaces(string code)
    {
        var currency = Currency.GetCurrency(code);
        Assert.Equal(3, currency.DecimalPlaces);
    }

    [Fact]
    public void MostCurrencies_Should_Have2DecimalPlaces()
    {
        var all = Currency.GetAll();
        var with2 = all.Count(c => c.DecimalPlaces == 2);
        // Most currencies have 2 decimal places
        Assert.True(with2 > all.Count / 2, "More than half of currencies should have 2 decimal places");
    }

    [Fact]
    public void AllCurrencies_Should_HaveValidDecimalPlaces()
    {
        var validValues = new[] { 0, 2, 3, 4 };
        foreach (var currency in Currency.GetAll())
        {
            Assert.Contains(currency.DecimalPlaces, validValues);
        }
    }

    #endregion

    #region Currency Reverse Lookup

    [Fact]
    public void USD_GetCountriesUsingCurrency_ShouldIncludeUS()
    {
        var usd = Currency.GetCurrency("USD");
        var countries = usd.GetCountriesUsingCurrency();
        Assert.Contains(countries, c => c.Alpha2Code == "US");
    }

    [Fact]
    public void EUR_GetCountriesUsingCurrency_ShouldIncludeMultipleCountries()
    {
        var eur = Currency.GetCurrency("EUR");
        var countries = eur.GetCountriesUsingCurrency();
        Assert.True(countries.Count > 1, "EUR should be used by multiple countries");
        Assert.Contains(countries, c => c.Alpha2Code == "DE");
        Assert.Contains(countries, c => c.Alpha2Code == "FR");
    }

    [Fact]
    public void GBP_GetCountriesUsingCurrency_ShouldIncludeGB()
    {
        var gbp = Currency.GetCurrency("GBP");
        var countries = gbp.GetCountriesUsingCurrency();
        Assert.Contains(countries, c => c.Alpha2Code == "GB");
    }

    [Fact]
    public void PKR_GetCountriesUsingCurrency_ShouldIncludePK()
    {
        var pkr = Currency.GetCurrency("PKR");
        var countries = pkr.GetCountriesUsingCurrency();
        Assert.Contains(countries, c => c.Alpha2Code == "PK");
    }

    #endregion
}
