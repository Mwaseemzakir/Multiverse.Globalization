using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class ExceptionTests
{
    #region CountryNotFoundException

    [Fact]
    public void CountryNotFoundException_Should_BeException()
    {
        var ex = new CountryNotFoundException();
        Assert.IsAssignableFrom<Exception>(ex);
    }

    [Fact]
    public void CountryNotFoundException_DefaultConstructor_Should_Work()
    {
        var ex = new CountryNotFoundException();
        Assert.NotNull(ex);
        Assert.Null(ex.InnerException);
    }

    [Fact]
    public void CountryNotFoundException_MessageConstructor_Should_SetMessage()
    {
        var ex = new CountryNotFoundException("Country not found");
        Assert.Equal("Country not found", ex.Message);
        Assert.Null(ex.InnerException);
    }

    [Fact]
    public void CountryNotFoundException_MessageAndInnerException_Should_SetBoth()
    {
        var inner = new InvalidOperationException("Inner error");
        var ex = new CountryNotFoundException("Country not found", inner);
        Assert.Equal("Country not found", ex.Message);
        Assert.Same(inner, ex.InnerException);
    }

    [Fact]
    public void CountryNotFoundException_NullMessage_Should_Work()
    {
        var ex = new CountryNotFoundException(null);
        Assert.NotNull(ex);
    }

    [Fact]
    public void CountryNotFoundException_Should_BeThrownByGetCountry()
    {
        var ex = Assert.Throws<CountryNotFoundException>(() => Country.GetCountry("XX"));
        Assert.Contains("XX", ex.Message, StringComparison.OrdinalIgnoreCase);
    }

    #endregion

    #region CurrencyNotFoundException

    [Fact]
    public void CurrencyNotFoundException_Should_BeException()
    {
        var ex = new CurrencyNotFoundException();
        Assert.IsAssignableFrom<Exception>(ex);
    }

    [Fact]
    public void CurrencyNotFoundException_DefaultConstructor_Should_Work()
    {
        var ex = new CurrencyNotFoundException();
        Assert.NotNull(ex);
        Assert.Null(ex.InnerException);
    }

    [Fact]
    public void CurrencyNotFoundException_MessageConstructor_Should_SetMessage()
    {
        var ex = new CurrencyNotFoundException("Currency not found");
        Assert.Equal("Currency not found", ex.Message);
        Assert.Null(ex.InnerException);
    }

    [Fact]
    public void CurrencyNotFoundException_MessageAndInnerException_Should_SetBoth()
    {
        var inner = new InvalidOperationException("Inner error");
        var ex = new CurrencyNotFoundException("Currency not found", inner);
        Assert.Equal("Currency not found", ex.Message);
        Assert.Same(inner, ex.InnerException);
    }

    [Fact]
    public void CurrencyNotFoundException_NullMessage_Should_Work()
    {
        var ex = new CurrencyNotFoundException(null);
        Assert.NotNull(ex);
    }

    [Fact]
    public void CurrencyNotFoundException_Should_BeThrownByGetCurrency_String()
    {
        var ex = Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency("XXX"));
        Assert.Contains("XXX", ex.Message);
    }

    [Fact]
    public void CurrencyNotFoundException_Should_BeThrownByGetCurrency_Int()
    {
        var ex = Assert.Throws<CurrencyNotFoundException>(() => Currency.GetCurrency(-1));
        Assert.Contains("-1", ex.Message);
    }

    #endregion

    #region LanguageNotFoundException

    [Fact]
    public void LanguageNotFoundException_Should_BeException()
    {
        var ex = new LanguageNotFoundException();
        Assert.IsAssignableFrom<Exception>(ex);
    }

    [Fact]
    public void LanguageNotFoundException_DefaultConstructor_Should_Work()
    {
        var ex = new LanguageNotFoundException();
        Assert.NotNull(ex);
        Assert.Null(ex.InnerException);
    }

    [Fact]
    public void LanguageNotFoundException_MessageConstructor_Should_SetMessage()
    {
        var ex = new LanguageNotFoundException("Language not found");
        Assert.Equal("Language not found", ex.Message);
        Assert.Null(ex.InnerException);
    }

    [Fact]
    public void LanguageNotFoundException_MessageAndInnerException_Should_SetBoth()
    {
        var inner = new InvalidOperationException("Inner error");
        var ex = new LanguageNotFoundException("Language not found", inner);
        Assert.Equal("Language not found", ex.Message);
        Assert.Same(inner, ex.InnerException);
    }

    [Fact]
    public void LanguageNotFoundException_NullMessage_Should_Work()
    {
        var ex = new LanguageNotFoundException(null);
        Assert.NotNull(ex);
    }

    [Fact]
    public void LanguageNotFoundException_Should_BeThrownByGetLanguage()
    {
        var ex = Assert.Throws<LanguageNotFoundException>(() => Language.GetLanguage("xx"));
        Assert.Contains("xx", ex.Message, StringComparison.OrdinalIgnoreCase);
    }

    #endregion
}
