using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class LanguageExtendedTests
{
    [Fact]
    public void English_NativeName_ShouldBeEnglish()
    {
        var en = Language.GetLanguage("en");
        Assert.Equal("English", en.NativeName);
    }

    [Fact]
    public void English_Script_ShouldBeLatin()
    {
        var en = Language.GetLanguage("en");
        Assert.Equal("Latin", en.Script);
    }

    [Fact]
    public void English_TextDirection_ShouldBeLTR()
    {
        var en = Language.GetLanguage("en");
        Assert.Equal(TextDirection.LeftToRight, en.TextDirection);
    }

    [Fact]
    public void Arabic_NativeName_ShouldBeArabic()
    {
        var ar = Language.GetLanguage("ar");
        Assert.Equal("العربية", ar.NativeName);
    }

    [Fact]
    public void Arabic_TextDirection_ShouldBeRTL()
    {
        var ar = Language.GetLanguage("ar");
        Assert.Equal(TextDirection.RightToLeft, ar.TextDirection);
    }

    [Fact]
    public void Arabic_Script_ShouldBeArabic()
    {
        var ar = Language.GetLanguage("ar");
        Assert.Equal("Arabic", ar.Script);
    }

    [Theory]
    [InlineData("ar")]
    [InlineData("he")]
    [InlineData("fa")]
    [InlineData("ur")]
    [InlineData("yi")]
    [InlineData("sd")]
    public void RTLLanguage_Should_HaveRTLDirection(string alpha2)
    {
        var lang = Language.GetLanguage(alpha2);
        Assert.Equal(TextDirection.RightToLeft, lang.TextDirection);
    }

    [Theory]
    [InlineData("en", "English", "Latin")]
    [InlineData("de", "Deutsch", "Latin")]
    [InlineData("fr", "français", "Latin")]
    [InlineData("es", "Español", "Latin")]
    [InlineData("ja", "日本語", "Japanese")]
    [InlineData("zh", "中文", "Han")]
    [InlineData("ko", "한국어", "Hangul")]
    [InlineData("hi", "हिन्दी", "Devanagari")]
    [InlineData("ru", "русский", "Cyrillic")]
    public void Language_Should_HaveCorrectNativeNameAndScript(string alpha2, string expectedNativeName, string expectedScript)
    {
        var lang = Language.GetLanguage(alpha2);
        Assert.Equal(expectedNativeName, lang.NativeName);
        Assert.Equal(expectedScript, lang.Script);
    }

    [Fact]
    public void Chinese_NativeName_ShouldBe中文()
    {
        var zh = Language.GetLanguage("zh");
        Assert.Equal("中文", zh.NativeName);
    }

    [Fact]
    public void Urdu_TextDirection_ShouldBeRTL()
    {
        var ur = Language.GetLanguage("ur");
        Assert.Equal(TextDirection.RightToLeft, ur.TextDirection);
        Assert.Equal("Arabic", ur.Script);
    }

    [Fact]
    public void LanguageWithoutExtendedData_Should_HaveDefaults()
    {
        // Languages without alpha2 codes (like obscure ones) might not have extended data set
        var all = Language.GetAll();
        foreach (var lang in all)
        {
            // Should never throw; defaults are empty string and LTR
            Assert.NotNull(lang.NativeName);
            Assert.NotNull(lang.Script);
            Assert.True(lang.TextDirection == TextDirection.LeftToRight || lang.TextDirection == TextDirection.RightToLeft);
        }
    }

    [Fact]
    public void TextDirection_Should_HaveTwoValues()
    {
        var values = Enum.GetValues(typeof(TextDirection));
        Assert.Equal(2, values.Length);
    }
}
