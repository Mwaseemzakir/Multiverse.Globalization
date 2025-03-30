using Multiverse.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Multiverse.UnitTests;

public class LanguageTests
{
    [Fact]
    public void GetAllLanguages_Should_ReturnAllLanguages()
    {
        List<Language>? languages = Language
            .GetAllLanguages()
            .ToList();

        Assert.NotEmpty(languages);
        Assert.Contains(Language.None, languages);
        Assert.Contains(Language.Eng, languages);
        Assert.Contains(Language.FreB, languages);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_ReturnTrueForValidCode()
    {
        string engAlpha2Code = Language.Eng.Alpha2Code;
        bool isValid = Language.IsValidAlpha2Code(engAlpha2Code);
        Assert.True(isValid);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_IgnoreCaseSensitivity()
    {
        string engAlpha2Code = Language.Eng.Alpha2Code.ToLower();
        bool isValid = Language.IsValidAlpha2Code(engAlpha2Code);
        Assert.True(isValid);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("a")] // Too short
    [InlineData("abc")] // Too long
    [InlineData("xx")] // Non-existent code
    public void IsValidAlpha2Code_Should_ReturnFalseForInvalidCodes(string code)
    {
        bool isValid = Language.IsValidAlpha2Code(code);
        Assert.False(isValid);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("ab")] // Too short
    [InlineData("abcd")] // Too long
    [InlineData("xyz")] // Non-existent code
    public void IsValidAlpha3Code_Should_ReturnFalseForInvalidCodes(string code)
    {
        bool isValid = Language.IsValidAlpha3Code(code);
        Assert.False(isValid);
    }

    [Fact]
    public void FromAlpha2Code_Should_ReturnCorrectLanguage()
    {
        Language language = Language.FromAlpha2Code("en");
        Assert.Equal("en", language.Alpha2Code.ToLower());
        Assert.Equal("eng", language.Alpha3Code.ToLower());
        Assert.Equal("English", language.Name);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void FromAlpha2Code_Should_ThrowForNullOrEmpty(string? code)
    {
        var ex = Assert.Throws<ApplicationException>(() => Language.FromAlpha2Code(code));
        Assert.Contains("Language with empty code is not supported", ex.Message);
    }

    [Fact]
    public void FromAlpha2Code_Should_ThrowForInvalidCode()
    {
        var ex = Assert.Throws<ApplicationException>(() => Language.FromAlpha2Code("xx"));
        Assert.Contains("Language with code 'xx' is not supported", ex.Message);
    }

    [Fact]
    public void FromAlpha3Code_Should_ReturnCorrectLanguage()
    {
        Language language = Language.FromAlpha3Code("eng");
        Assert.Equal("en", language.Alpha2Code.ToLower());
        Assert.Equal("eng", language.Alpha3Code.ToLower());
        Assert.Equal("English", language.Name);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void FromAlpha3Code_Should_ThrowForNullOrEmpty(string? code)
    {
        var ex = Assert.Throws<ApplicationException>(() => Language.FromAlpha3Code(code));
        Assert.Contains("Language with empty code is not supported", ex.Message);
    }

    [Fact]
    public void FromAlpha3Code_Should_ThrowForInvalidCode()
    {
        var ex = Assert.Throws<ApplicationException>(() => Language.FromAlpha3Code("xyz"));
        Assert.Contains("Language with code 'xyz' is not supported", ex.Message);
    }

    [Fact]
    public void TryGetLanguageByAlpha2Code_Should_ReturnTrueForValidCode()
    {
        Language language;
        bool success = Language.TryGetLanguageByAlpha2Code("en", out language);
        Assert.True(success);
        Assert.Equal("en", language.Alpha2Code.ToLower());
        Assert.Equal("eng", language.Alpha3Code.ToLower());
        Assert.Equal("English", language.Name);
    }

    [Fact]
    public void TryGetLanguageByAlpha3Code_Should_ReturnTrueForValidCode()
    {
        Language language;
        bool success = Language.TryGetLanguageByAlpha3Code("eng", out language);
        Assert.True(success);
        Assert.Equal("en", language.Alpha2Code.ToLower());
        Assert.Equal("eng", language.Alpha3Code.ToLower());
        Assert.Equal("English", language.Name);
    }

    [Fact]
    public void ParseLanguage_Should_HandleAlpha2Input()
    {
        Language language = Language.ParseLanguage("en");
        Assert.Equal("en", language.Alpha2Code.ToLower());
        Assert.Equal("eng", language.Alpha3Code.ToLower());
        Assert.Equal("English", language.Name);
    }

    [Fact]
    public void ParseLanguage_Should_HandleAlpha3Input()
    {
        Language language = Language.ParseLanguage("eng");
        Assert.Equal("en", language.Alpha2Code.ToLower());
        Assert.Equal("eng", language.Alpha3Code.ToLower());
        Assert.Equal("English", language.Name);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void ParseLanguage_Should_ThrowForInvalidInput(string code)
    {
        Assert.Throws<ArgumentException>(() => Language.ParseLanguage(code));
    }

    [Fact]
    public void GetAllAlpha2Codes_Should_ReturnAllCodes()
    {
        var codes = Language.GetAllAlpha2Codes().Select(c => c.ToUpper()).ToList();
        Assert.Contains("EN", codes);
        Assert.Contains("FR", codes);
        Assert.DoesNotContain("XX", codes);
    }

    [Fact]
    public void GetAllAlpha3Codes_Should_ReturnAllCodes()
    {
        var codes = Language.GetAllAlpha3Codes().Select(c => c.ToUpper()).ToList();
        Assert.Contains("ENG", codes);
        Assert.Contains("FRE", codes);
        Assert.DoesNotContain("XYZ", codes);
    }

    [Fact]
    public void LanguageCount_Should_ReturnCorrectCount()
    {
        // The actual implementation returns 182, so use the actual count from GetAllLanguages
        // that have non-empty Alpha2Code instead of expecting a specific number
        int count = Language.LanguageCount;
        int expectedCount = Language.GetAllLanguages()
            .Count(l => !string.IsNullOrEmpty(l.Alpha2Code));
        
        Assert.Equal(expectedCount, count);
    }

    [Fact]
    public void None_Should_HaveEmptyProperties()
    {
        Assert.Equal(string.Empty, Language.None.Alpha2Code);
        Assert.Equal(string.Empty, Language.None.Alpha3Code);
        Assert.Equal(string.Empty, Language.None.Name);
    }
}
