namespace Multiverse.Globalization.UnitTests.Currencies;

public class CurrencyFormattingTests
{
    // ── Format ──────────────────────────────────────────────────────

    [Fact]
    public void Format_Should_PrefixTheSymbolUsingUsSeparators()
    {
        var usd = Currency.GetCurrency("USD");
        var us = Country.GetCountry("US");

        Assert.Equal("$1,234.50", usd.Format(1234.5m, us.Locale));
    }

    [Fact]
    public void Format_Should_SuffixTheSymbolUsingGermanSeparators()
    {
        var eur = Currency.GetCurrency("EUR");
        var de = Country.GetCountry("DE");

        Assert.Equal("1.234,50 €", eur.Format(1234.5m, de.Locale, CurrencySymbolPosition.Suffix));
    }

    [Fact]
    public void Format_Should_PrefixTheSymbolByDefault()
    {
        var eur = Currency.GetCurrency("EUR");
        var de = Country.GetCountry("DE");

        Assert.Equal("€1.234,50", eur.Format(1234.5m, de.Locale));
    }

    [Fact]
    public void Format_Should_UseInvariantSeparatorsWithoutALocale()
    {
        var usd = Currency.GetCurrency("USD");

        Assert.Equal("$1,234.50", usd.Format(1234.5m));
    }

    [Fact]
    public void Format_Should_HonourZeroDecimalCurrencies()
    {
        var jpy = Currency.GetCurrency("JPY");

        Assert.Equal(0, jpy.DecimalPlaces);
        Assert.Equal("¥1,235", jpy.Format(1234.5m));
    }

    [Fact]
    public void Format_Should_HonourThreeDecimalCurrencies()
    {
        var kwd = Currency.GetCurrency("KWD");

        Assert.Equal(3, kwd.DecimalPlaces);
        Assert.Equal("1,234.568", kwd.Format(1234.5678m, null, CurrencySymbolPosition.None));

        // The same amount takes Kuwait's own separators when its locale is supplied.
        var kuwait = Country.GetCountry("KW");
        Assert.Equal("1,234.568", kwd.Format(1234.5678m, kuwait.Locale, CurrencySymbolPosition.None));
    }

    [Fact]
    public void Format_Should_OmitTheSymbolWhenAsked()
    {
        var usd = Currency.GetCurrency("USD");

        Assert.Equal("1,234.50", usd.Format(1234.5m, null, CurrencySymbolPosition.None));
    }

    [Fact]
    public void Format_Should_HandleNegativeAmounts()
    {
        var usd = Currency.GetCurrency("USD");

        Assert.Equal("$-1,234.50", usd.Format(-1234.5m));
    }

    // ── Rounding and minor units ────────────────────────────────────

    [Fact]
    public void Round_Should_UseTheCurrencysMinorUnit()
    {
        Assert.Equal(1234.57m, Currency.GetCurrency("USD").Round(1234.567m));
        Assert.Equal(1235m, Currency.GetCurrency("JPY").Round(1234.5m));
        Assert.Equal(1234.568m, Currency.GetCurrency("KWD").Round(1234.5678m));
    }

    [Fact]
    public void Round_Should_GoAwayFromZeroAtTheMidpoint()
    {
        var usd = Currency.GetCurrency("USD");

        Assert.Equal(2.35m, usd.Round(2.345m));
        Assert.Equal(-2.35m, usd.Round(-2.345m));
    }

    [Fact]
    public void ToMinorUnits_Should_ScaleByTheMinorUnit()
    {
        Assert.Equal(123450L, Currency.GetCurrency("USD").ToMinorUnits(1234.50m));
        Assert.Equal(1235L, Currency.GetCurrency("JPY").ToMinorUnits(1234.5m));
        Assert.Equal(1234568L, Currency.GetCurrency("KWD").ToMinorUnits(1234.5678m));
    }

    [Fact]
    public void FromMinorUnits_Should_InvertToMinorUnits()
    {
        var usd = Currency.GetCurrency("USD");

        Assert.Equal(1234.50m, usd.FromMinorUnits(123450L));
        Assert.Equal(1234m, Currency.GetCurrency("JPY").FromMinorUnits(1234L));
    }

    [Fact]
    public void MinorUnits_Should_RoundTripForEveryCurrency()
    {
        foreach (var currency in Currency.GetAll())
        {
            var amount = currency.Round(1234.5678m);

            Assert.Equal(amount, currency.FromMinorUnits(currency.ToMinorUnits(amount)));
        }
    }

    [Fact]
    public void Format_Should_NotThrowForAnyCurrencyAndCountryPair()
    {
        var us = Country.GetCountry("US");

        foreach (var currency in Currency.GetAll())
        {
            var formatted = currency.Format(1234.5m, us.Locale);

            Assert.False(string.IsNullOrWhiteSpace(formatted));
        }
    }
}
