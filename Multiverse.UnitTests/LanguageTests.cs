using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class LanguageTests
{
    [Fact]
    public void GetAll_Should_ReturnAllLanguages()
    {
        List<Language>? languages = Language
            .GetAll();

        Assert.NotEmpty(languages);
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        string pakAlpha2Code = LanguageHelper.Urdu.Alpha2Code;

        bool isValid = Language.IsValid(pakAlpha2Code);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        string pakAlpha2Code = LanguageHelper.Urdu.Alpha2Code.ToLower();

        bool isValid = Language.IsValid(pakAlpha2Code);

        Assert.True(isValid);
    }
}
