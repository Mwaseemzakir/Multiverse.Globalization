using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class LanguageTests
{
    [Fact]
    public void GetAll_Should_ReturnAllLanguages()
    {
        List<Language>? languages = Language.GetAll();

        Assert.NotNull(languages);
        Assert.NotEmpty(languages);
        Assert.Contains(languages, l => l.Alpha2Code == "en" && l.Alpha3Code == "eng" && l.Name == "English");
        Assert.Contains(languages, l => l.Alpha2Code == "es" && l.Alpha3Code == "spa" && l.Name == "Spanish; Castilian");
        Assert.Contains(languages, l => l.Alpha2Code == "fr" && l.Alpha3Code == "fre" && l.Name == "French");
        Assert.Contains(languages, l => l.Alpha2Code == "ur" && l.Alpha3Code == "urd" && l.Name == "Urdu");
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        // Test with Alpha2 codes
        Assert.True(Language.IsValid(LanguageHelper.English.Alpha2Code));
        Assert.True(Language.IsValid(LanguageHelper.Spanish.Alpha2Code));
        Assert.True(Language.IsValid(LanguageHelper.French.Alpha2Code));
        Assert.True(Language.IsValid(LanguageHelper.Urdu.Alpha2Code));

        // Test with Alpha3 codes
        Assert.True(Language.IsValid(LanguageHelper.English.Alpha3Code));
        Assert.True(Language.IsValid(LanguageHelper.Spanish.Alpha3Code));
        Assert.True(Language.IsValid(LanguageHelper.French.Alpha3Code));
        Assert.True(Language.IsValid(LanguageHelper.Urdu.Alpha3Code));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Language.IsValid("xx")); // Invalid 2-letter code
        Assert.False(Language.IsValid("xxx")); // Invalid 3-letter code
        Assert.False(Language.IsValid("")); // Empty string
        Assert.False(Language.IsValid("12")); // Numeric code
        Assert.False(Language.IsValid("!@")); // Special characters
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        // Test with Alpha2 codes
        Assert.True(Language.IsValid(LanguageHelper.English.Alpha2Code.ToLower()));
        Assert.True(Language.IsValid(LanguageHelper.English.Alpha2Code.ToUpper()));
        
        // Test with Alpha3 codes
        Assert.True(Language.IsValid(LanguageHelper.English.Alpha3Code.ToLower()));
        Assert.True(Language.IsValid(LanguageHelper.English.Alpha3Code.ToUpper()));
    }

    [Fact]
    public void Language_Properties_Should_BeCorrect()
    {
        // Test English language properties
        var english = LanguageHelper.English;
        Assert.Equal("en", english.Alpha2Code);
        Assert.Equal("eng", english.Alpha3Code);
        Assert.Equal("English", english.Name);

        // Test Spanish language properties
        var spanish = LanguageHelper.Spanish;
        Assert.Equal("es", spanish.Alpha2Code);
        Assert.Equal("spa", spanish.Alpha3Code);
        Assert.Equal("Spanish; Castilian", spanish.Name);

        // Test None language properties
        var none = LanguageHelper.None;
        Assert.Equal(string.Empty, none.Alpha2Code);
        Assert.Equal(string.Empty, none.Alpha3Code);
        Assert.Equal(string.Empty, none.Name);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateCodes()
    {
        var languages = Language.GetAll();
        
        // Check for duplicate Alpha2 codes
        var alpha2Codes = languages.Select(l => l.Alpha2Code.ToLowerInvariant())
                                 .Where(code => !string.IsNullOrEmpty(code))
                                 .ToList();
        Assert.Equal(alpha2Codes.Count, alpha2Codes.Distinct().Count());

        // Check for duplicate Alpha3 codes
        var alpha3Codes = languages.Select(l => l.Alpha3Code.ToLowerInvariant())
                                 .Where(code => !string.IsNullOrEmpty(code))
                                 .ToList();
        Assert.Equal(alpha3Codes.Count, alpha3Codes.Distinct().Count());
    }
}
