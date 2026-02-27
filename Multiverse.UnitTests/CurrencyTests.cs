using Multiverse.Globalization.Currencies;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CurrencyTests
{
    #region GetAll

    [Fact]
    public void GetAll_Should_ReturnAllCurrencies()
    {
        IReadOnlyList<Currency> currencies = Currency.GetAll();

        Assert.NotNull(currencies);
        Assert.NotEmpty(currencies);
        Assert.Contains(currencies, c => c.Code == "USD" && c.Name == "US Dollar");
        Assert.Contains(currencies, c => c.Code == "EUR" && c.Name == "Euro");
        Assert.Contains(currencies, c => c.Code == "GBP" && c.Name == "Pound Sterling");
        Assert.Contains(currencies, c => c.Code == "PKR" && c.Name == "Pakistan Rupee");
    }

    [Fact]
    public void GetAll_Should_ReturnSameCachedInstance()
    {
        var list1 = Currency.GetAll();
        var list2 = Currency.GetAll();

        Assert.Same(list1, list2);
        Assert.Equal(list1.Count, list2.Count);
    }

    [Fact]
    public void GetAll_Should_BeOrderedByName()
    {
        var currencies = Currency.GetAll();
        var names = currencies.Select(c => c.Name).ToList();
        var sorted = names.OrderBy(n => n).ToList();

        Assert.Equal(sorted, names);
    }

    [Fact]
    public void GetAll_Should_NotContainNone()
    {
        var currencies = Currency.GetAll();
        Assert.DoesNotContain(currencies, c => c.Code == string.Empty && c.Name == string.Empty && c.Number == 0);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateCodes()
    {
        var currencies = Currency.GetAll();
        var codes = currencies
            .Select(c => c.Code.ToLowerInvariant())
            .Where(code => !string.IsNullOrEmpty(code))
            .ToList();

        Assert.Equal(codes.Count, codes.Distinct().Count());
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateNames()
    {
        var currencies = Currency.GetAll();
        var names = currencies
            .Select(c => c.Name.ToLowerInvariant())
            .Where(n => !string.IsNullOrEmpty(n))
            .ToList();

        Assert.Equal(names.Count, names.Distinct().Count());
    }

    #endregion

    #region IsValid (string)

    [Fact]
    public void IsValid_String_Should_ReturnTrueForValidCode()
    {
        Assert.True(Currency.IsValid("USD"));
        Assert.True(Currency.IsValid("EUR"));
        Assert.True(Currency.IsValid("GBP"));
        Assert.True(Currency.IsValid("PKR"));
        Assert.True(Currency.IsValid("JPY"));
        Assert.True(Currency.IsValid("CHF"));
    }

    [Fact]
    public void IsValid_String_Should_ReturnTrueForValidName()
    {
        Assert.True(Currency.IsValid("US Dollar"));
        Assert.True(Currency.IsValid("Euro"));
        Assert.True(Currency.IsValid("Pound Sterling"));
        Assert.True(Currency.IsValid("Pakistan Rupee"));
    }

    [Fact]
    public void IsValid_String_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Currency.IsValid("XXX"));
        Assert.False(Currency.IsValid("XX"));
        Assert.False(Currency.IsValid("USDD"));
        Assert.False(Currency.IsValid(""));
        Assert.False(Currency.IsValid("123"));
        Assert.False(Currency.IsValid("!@#"));
        Assert.False(Currency.IsValid("Nonexistent Currency"));
    }

    [Fact]
    public void IsValid_String_Should_ReturnFalseForNullOrWhitespace()
    {
        Assert.False(Currency.IsValid((string)null!));
        Assert.False(Currency.IsValid(""));
        Assert.False(Currency.IsValid(" "));
        Assert.False(Currency.IsValid("  "));
        Assert.False(Currency.IsValid("\t"));
    }

    [Fact]
    public void IsValid_String_Should_IgnoreCaseSensitivity()
    {
        Assert.True(Currency.IsValid("usd"));
        Assert.True(Currency.IsValid("USD"));
        Assert.True(Currency.IsValid("uSd"));
        Assert.True(Currency.IsValid("eUr"));
        Assert.True(Currency.IsValid("us dollar"));
        Assert.True(Currency.IsValid("US DOLLAR"));
    }

    #endregion

    #region IsValid (int)

    [Fact]
    public void IsValid_Int_Should_ReturnTrueForValidNumber()
    {
        Assert.True(Currency.IsValid(840)); // USD
        Assert.True(Currency.IsValid(978)); // EUR
        Assert.True(Currency.IsValid(826)); // GBP
        Assert.True(Currency.IsValid(586)); // PKR
        Assert.True(Currency.IsValid(392)); // JPY
        Assert.True(Currency.IsValid(0));   // None
    }

    [Fact]
    public void IsValid_Int_Should_ReturnFalseForInvalidNumber()
    {
        Assert.False(Currency.IsValid(-1));
        Assert.False(Currency.IsValid(99999));
        Assert.False(Currency.IsValid(1));
        Assert.False(Currency.IsValid(int.MaxValue));
    }

    #endregion

    #region GetCurrency (string)

    [Fact]
    public void GetCurrency_String_Should_ReturnByCode()
    {
        var currency = Currency.GetCurrency("USD");
        Assert.Equal("US Dollar", currency.Name);
        Assert.Same(CurrencyHelper.UsDollar, currency);
    }

    [Fact]
    public void GetCurrency_String_Should_ReturnByName()
    {
        var currency = Currency.GetCurrency("Euro");
        Assert.Equal("EUR", currency.Code);
        Assert.Same(CurrencyHelper.Euro, currency);
    }

    [Fact]
    public void GetCurrency_String_Should_BeCaseInsensitive()
    {
        var c1 = Currency.GetCurrency("usd");
        var c2 = Currency.GetCurrency("USD");
        var c3 = Currency.GetCurrency("Usd");

        Assert.Same(c1, c2);
        Assert.Same(c2, c3);
    }

    [Fact]
    public void GetCurrency_String_Should_ThrowForNull()
    {
        Assert.Throws<ArgumentNullException>(() => Currency.GetCurrency((string)null!));
    }

    [Fact]
    public void GetCurrency_String_Should_ThrowForInvalidIdentifier()
    {
        Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency("XXX"));
        Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency("Nonexistent"));
    }

    [Theory]
    [InlineData("USD", "US Dollar", 840)]
    [InlineData("EUR", "Euro", 978)]
    [InlineData("GBP", "Pound Sterling", 826)]
    [InlineData("JPY", "Yen", 392)]
    [InlineData("PKR", "Pakistan Rupee", 586)]
    [InlineData("INR", "Indian Rupee", 356)]
    [InlineData("AUD", "Australian Dollar", 36)]
    [InlineData("CAD", "Canadian Dollar", 124)]
    public void GetCurrency_String_Should_ReturnCorrectProperties(string code, string expectedName, int expectedNumber)
    {
        var currency = Currency.GetCurrency(code);
        Assert.Equal(code, currency.Code);
        Assert.Equal(expectedName, currency.Name);
        Assert.Equal(expectedNumber, currency.Number);
    }

    #endregion

    #region GetCurrency (int)

    [Fact]
    public void GetCurrency_Int_Should_ReturnByNumber()
    {
        var currency = Currency.GetCurrency(840);
        Assert.Equal("USD", currency.Code);
        Assert.Equal("US Dollar", currency.Name);
        Assert.Same(CurrencyHelper.UsDollar, currency);
    }

    [Fact]
    public void GetCurrency_Int_Should_ReturnNoneForZero()
    {
        var currency = Currency.GetCurrency(0);
        Assert.Same(CurrencyHelper.None, currency);
    }

    [Fact]
    public void GetCurrency_Int_Should_ThrowForInvalidNumber()
    {
        Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency(-1));
        Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency(99999));
        Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency(1));
    }

    [Theory]
    [InlineData(840, "USD")]
    [InlineData(978, "EUR")]
    [InlineData(826, "GBP")]
    [InlineData(392, "JPY")]
    [InlineData(586, "PKR")]
    [InlineData(356, "INR")]
    public void GetCurrency_Int_Should_ReturnCorrectCurrency(int number, string expectedCode)
    {
        var currency = Currency.GetCurrency(number);
        Assert.Equal(expectedCode, currency.Code);
        Assert.Equal(number, currency.Number);
    }

    #endregion

    #region GetCurrencyOrDefault (string)

    [Fact]
    public void GetCurrencyOrDefault_String_Should_ReturnCurrencyForValidCode()
    {
        var currency = Currency.GetCurrencyOrDefault("USD");
        Assert.NotNull(currency);
        Assert.Equal("US Dollar", currency!.Name);
    }

    [Fact]
    public void GetCurrencyOrDefault_String_Should_ReturnCurrencyForValidName()
    {
        var currency = Currency.GetCurrencyOrDefault("Euro");
        Assert.NotNull(currency);
        Assert.Equal("EUR", currency!.Code);
    }

    [Fact]
    public void GetCurrencyOrDefault_String_Should_ReturnNullForInvalid()
    {
        Assert.Null(Currency.GetCurrencyOrDefault("XXX"));
        Assert.Null(Currency.GetCurrencyOrDefault("Nonexistent"));
    }

    [Fact]
    public void GetCurrencyOrDefault_String_Should_ReturnNullForNullOrWhitespace()
    {
        Assert.Null(Currency.GetCurrencyOrDefault(null!));
        Assert.Null(Currency.GetCurrencyOrDefault(""));
        Assert.Null(Currency.GetCurrencyOrDefault(" "));
    }

    [Fact]
    public void GetCurrencyOrDefault_String_Should_BeCaseInsensitive()
    {
        var c1 = Currency.GetCurrencyOrDefault("usd");
        var c2 = Currency.GetCurrencyOrDefault("USD");

        Assert.NotNull(c1);
        Assert.Same(c1, c2);
    }

    #endregion

    #region GetCurrencyOrDefault (int)

    [Fact]
    public void GetCurrencyOrDefault_Int_Should_ReturnCurrencyForValidNumber()
    {
        var currency = Currency.GetCurrencyOrDefault(840);
        Assert.NotNull(currency);
        Assert.Equal("USD", currency!.Code);
    }

    [Fact]
    public void GetCurrencyOrDefault_Int_Should_ReturnNoneForZero()
    {
        var currency = Currency.GetCurrencyOrDefault(0);
        Assert.NotNull(currency);
        Assert.Same(CurrencyHelper.None, currency);
    }

    [Fact]
    public void GetCurrencyOrDefault_Int_Should_ReturnNullForInvalidNumber()
    {
        Assert.Null(Currency.GetCurrencyOrDefault(-1));
        Assert.Null(Currency.GetCurrencyOrDefault(99999));
        Assert.Null(Currency.GetCurrencyOrDefault(1));
    }

    #endregion

    #region Currency Properties

    [Fact]
    public void Currency_Properties_Should_BeCorrectForUSD()
    {
        var usd = CurrencyHelper.UsDollar;
        Assert.Equal("USD", usd.Code);
        Assert.Equal("US Dollar", usd.Name);
        Assert.Equal("$", usd.Symbol);
        Assert.Equal(840, usd.Number);
    }

    [Fact]
    public void Currency_Properties_Should_BeCorrectForEUR()
    {
        var eur = CurrencyHelper.Euro;
        Assert.Equal("EUR", eur.Code);
        Assert.Equal("Euro", eur.Name);
        Assert.Equal("€", eur.Symbol);
        Assert.Equal(978, eur.Number);
    }

    [Fact]
    public void Currency_Properties_Should_BeCorrectForGBP()
    {
        var gbp = CurrencyHelper.PoundSterling;
        Assert.Equal("GBP", gbp.Code);
        Assert.Equal("Pound Sterling", gbp.Name);
        Assert.Equal("£", gbp.Symbol);
        Assert.Equal(826, gbp.Number);
    }

    [Fact]
    public void Currency_None_Should_HaveEmptyProperties()
    {
        var none = CurrencyHelper.None;
        Assert.Equal(string.Empty, none.Code);
        Assert.Equal(string.Empty, none.Name);
        Assert.Equal(string.Empty, none.Symbol);
        Assert.Equal(0, none.Number);
    }

    #endregion

    #region CurrencyHelper Maps

    [Fact]
    public void CurrencyHelper_CodeMap_Should_ContainValidCurrencies()
    {
        var map = CurrencyHelper.CodeMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("usd"));
        Assert.True(map.ContainsKey("eur"));
        Assert.Same(CurrencyHelper.UsDollar, map["usd"]);
    }

    [Fact]
    public void CurrencyHelper_CodeMap_Should_ContainNoneAsEmptyKey()
    {
        var map = CurrencyHelper.CodeMap;
        Assert.True(map.ContainsKey(string.Empty));
        Assert.Same(CurrencyHelper.None, map[string.Empty]);
    }

    [Fact]
    public void CurrencyHelper_NameMap_Should_ContainValidCurrencies()
    {
        var map = CurrencyHelper.NameMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("us dollar"));
        Assert.True(map.ContainsKey("euro"));
        Assert.Same(CurrencyHelper.UsDollar, map["us dollar"]);
    }

    [Fact]
    public void CurrencyHelper_NumberMap_Should_ContainValidCurrencies()
    {
        var map = CurrencyHelper.NumberMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey(840));
        Assert.True(map.ContainsKey(978));
        Assert.True(map.ContainsKey(0)); // None
        Assert.Same(CurrencyHelper.UsDollar, map[840]);
        Assert.Same(CurrencyHelper.None, map[0]);
    }

    #endregion

    #region Data Integrity

    [Fact]
    public void AllCurrencies_Should_HaveNonEmptyCode()
    {
        var currencies = Currency.GetAll();
        foreach (var currency in currencies)
        {
            Assert.False(string.IsNullOrEmpty(currency.Code), $"Currency '{currency.Name}' has empty Code");
            Assert.Equal(3, currency.Code.Length);
        }
    }

    [Fact]
    public void AllCurrencies_Should_HaveNonEmptyName()
    {
        var currencies = Currency.GetAll();
        foreach (var currency in currencies)
        {
            Assert.False(string.IsNullOrEmpty(currency.Name), $"Currency with code '{currency.Code}' has empty Name");
        }
    }

    [Fact]
    public void AllCurrencies_Should_HaveNonEmptySymbol()
    {
        var currencies = Currency.GetAll();
        foreach (var currency in currencies)
        {
            Assert.False(string.IsNullOrEmpty(currency.Symbol), $"Currency '{currency.Name}' has empty Symbol");
        }
    }

    [Fact]
    public void AllCurrencies_Should_HavePositiveNumber()
    {
        var currencies = Currency.GetAll();
        foreach (var currency in currencies)
        {
            Assert.True(currency.Number > 0, $"Currency '{currency.Name}' has non-positive Number: {currency.Number}");
        }
    }

    [Fact]
    public void AllCurrencies_Should_HaveUppercaseCode()
    {
        var currencies = Currency.GetAll();
        foreach (var currency in currencies)
        {
            Assert.Equal(currency.Code, currency.Code.ToUpperInvariant());
        }
    }

    #endregion

    #region ToString

    [Fact]
    public void ToString_Should_ReturnNameAndCode()
    {
        var usd = CurrencyHelper.UsDollar;
        Assert.Equal("US Dollar (USD)", usd.ToString());
    }

    [Fact]
    public void ToString_Should_ReturnNameAndCodeForEuro()
    {
        var eur = CurrencyHelper.Euro;
        Assert.Equal("Euro (EUR)", eur.ToString());
    }

    [Fact]
    public void ToString_None_Should_ReturnEmptyParens()
    {
        var none = CurrencyHelper.None;
        Assert.Equal(" ()", none.ToString());
    }

    [Theory]
    [InlineData("GBP", "Pound Sterling (GBP)")]
    [InlineData("JPY", "Yen (JPY)")]
    [InlineData("PKR", "Pakistan Rupee (PKR)")]
    [InlineData("CHF", "Swiss Franc (CHF)")]
    public void ToString_Should_FormatCorrectly(string code, string expected)
    {
        var currency = Currency.GetCurrency(code);
        Assert.Equal(expected, currency.ToString());
    }

    #endregion

    #region Equals and GetHashCode

    [Fact]
    public void Equals_SameCurrency_Should_ReturnTrue()
    {
        var usd1 = Currency.GetCurrency("USD");
        var usd2 = Currency.GetCurrency(840);

        Assert.Equal(usd1, usd2);
        Assert.True(usd1.Equals(usd2));
    }

    [Fact]
    public void Equals_DifferentCurrency_Should_ReturnFalse()
    {
        var usd = Currency.GetCurrency("USD");
        var eur = Currency.GetCurrency("EUR");

        Assert.NotEqual(usd, eur);
        Assert.False(usd.Equals(eur));
    }

    [Fact]
    public void Equals_Null_Should_ReturnFalse()
    {
        var usd = Currency.GetCurrency("USD");
        Assert.False(usd.Equals(null));
    }

    [Fact]
    public void Equals_NonCurrencyObject_Should_ReturnFalse()
    {
        var usd = Currency.GetCurrency("USD");
        Assert.False(usd.Equals("USD"));
    }

    [Fact]
    public void GetHashCode_SameCurrency_Should_ReturnSameHash()
    {
        var usd1 = Currency.GetCurrency("USD");
        var usd2 = Currency.GetCurrency(840);

        Assert.Equal(usd1.GetHashCode(), usd2.GetHashCode());
    }

    [Fact]
    public void GetHashCode_DifferentCurrencies_Should_ReturnDifferentHash()
    {
        var usd = Currency.GetCurrency("USD");
        var eur = Currency.GetCurrency("EUR");

        Assert.NotEqual(usd.GetHashCode(), eur.GetHashCode());
    }

    [Fact]
    public void Currencies_Should_WorkInHashSet()
    {
        var set = new HashSet<Currency>
        {
            Currency.GetCurrency("USD"),
            Currency.GetCurrency("US Dollar"),
            Currency.GetCurrency(840)
        };

        Assert.Single(set);
    }

    [Fact]
    public void Currencies_Should_WorkAsDictionaryKeys()
    {
        var dict = new Dictionary<Currency, string>
        {
            { Currency.GetCurrency("USD"), "Dollar" }
        };

        Assert.True(dict.ContainsKey(Currency.GetCurrency(840)));
        Assert.Equal("Dollar", dict[Currency.GetCurrency("US Dollar")]);
    }

    #endregion
}
