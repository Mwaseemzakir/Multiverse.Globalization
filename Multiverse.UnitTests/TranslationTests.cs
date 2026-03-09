using Multiverse.Globalization.Countries;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class TranslationTests
{
    [Fact]
    public void US_Should_HaveTranslations()
    {
        var us = Country.GetCountry("US");
        Assert.NotEmpty(us.Translations);
    }

    [Fact]
    public void US_FrenchTranslation_Should_BeEtatsUnis()
    {
        var us = Country.GetCountry("US");
        Assert.True(us.Translations.ContainsKey("fr"));
        Assert.Equal("États-Unis", us.Translations["fr"]);
    }

    [Fact]
    public void US_SpanishTranslation_Should_BeEstadosUnidos()
    {
        var us = Country.GetCountry("US");
        Assert.True(us.Translations.ContainsKey("es"));
        Assert.Equal("Estados Unidos", us.Translations["es"]);
    }

    [Fact]
    public void US_GetNameInLanguage_Should_ReturnCorrectTranslation()
    {
        var us = Country.GetCountry("US");
        Assert.Equal("États-Unis", us.GetNameInLanguage("fr"));
        Assert.Equal("Estados Unidos", us.GetNameInLanguage("es"));
        Assert.Equal("Vereinigte Staaten", us.GetNameInLanguage("de"));
    }

    [Fact]
    public void GetNameInLanguage_CaseInsensitive()
    {
        var us = Country.GetCountry("US");
        Assert.Equal(us.GetNameInLanguage("fr"), us.GetNameInLanguage("FR"));
    }

    [Fact]
    public void GetNameInLanguage_NonExistentLanguage_ShouldReturnNull()
    {
        var us = Country.GetCountry("US");
        Assert.Null(us.GetNameInLanguage("xx"));
    }

    [Fact]
    public void GetNameInLanguage_NullInput_ShouldReturnNull()
    {
        var us = Country.GetCountry("US");
        Assert.Null(us.GetNameInLanguage(null!));
    }

    [Fact]
    public void GetNameInLanguage_EmptyInput_ShouldReturnNull()
    {
        var us = Country.GetCountry("US");
        Assert.Null(us.GetNameInLanguage(""));
        Assert.Null(us.GetNameInLanguage("   "));
    }

    [Theory]
    [InlineData("DE", "fr", "Allemagne")]
    [InlineData("JP", "zh", "日本")]
    [InlineData("BR", "de", "Brasilien")]
    [InlineData("PK", "ar", "باكستان")]
    public void Country_Should_HaveCorrectTranslation(string alpha2, string lang, string expected)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expected, country.GetNameInLanguage(lang));
    }

    [Fact]
    public void Antarctica_Should_HaveTranslations()
    {
        // Antarctica now has translation data for all 8 languages
        var aq = Country.GetCountry("AQ");
        Assert.NotNull(aq.Translations);
        Assert.NotEmpty(aq.Translations);
    }
}
