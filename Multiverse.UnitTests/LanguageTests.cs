using Multiverse.Languages;
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
    }

    [Fact]
    public void IsValidAlpha2Code_Should_ReturnTrueForValidCode()
    {
        string pakAlpha2Code = Language.Urd.Alpha2Code;

        bool isValid = Language.IsValidAlpha2Code(pakAlpha2Code);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValidAlpha2Code_Should_IgnoreCaseSensitivity()
    {
        string pakAlpha2Code = Language.Urd.Alpha2Code.ToLower();

        bool isValid = Language.IsValidAlpha2Code(pakAlpha2Code);

        Assert.True(isValid);
    }
}
