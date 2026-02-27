using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class LanguageTests
{
    #region GetAll

    [Fact]
    public void GetAll_Should_ReturnAllLanguages()
    {
        IReadOnlyList<Language> languages = Language.GetAll();

        Assert.NotNull(languages);
        Assert.NotEmpty(languages);
        Assert.Contains(languages, l => l.Alpha2Code == "en" && l.Alpha3Code == "eng" && l.Name == "English");
        Assert.Contains(languages, l => l.Alpha2Code == "es" && l.Alpha3Code == "spa" && l.Name == "Spanish; Castilian");
        Assert.Contains(languages, l => l.Alpha2Code == "fr" && l.Alpha3Code == "fre" && l.Name == "French");
        Assert.Contains(languages, l => l.Alpha2Code == "ur" && l.Alpha3Code == "urd" && l.Name == "Urdu");
    }

    [Fact]
    public void GetAll_Should_ReturnSameCachedInstance()
    {
        var list1 = Language.GetAll();
        var list2 = Language.GetAll();

        Assert.Same(list1, list2);
        Assert.Equal(list1.Count, list2.Count);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateAlpha2Codes()
    {
        var languages = Language.GetAll();
        var alpha2Codes = languages
            .Select(l => l.Alpha2Code.ToLowerInvariant())
            .Where(code => !string.IsNullOrEmpty(code))
            .ToList();

        Assert.Equal(alpha2Codes.Count, alpha2Codes.Distinct().Count());
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateAlpha3Codes()
    {
        var languages = Language.GetAll();
        var alpha3Codes = languages
            .Select(l => l.Alpha3Code.ToLowerInvariant())
            .Where(code => !string.IsNullOrEmpty(code))
            .ToList();

        Assert.Equal(alpha3Codes.Count, alpha3Codes.Distinct().Count());
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateNames()
    {
        var languages = Language.GetAll();
        var names = languages
            .Select(l => l.Name.ToLowerInvariant())
            .Where(n => !string.IsNullOrEmpty(n))
            .ToList();

        Assert.Equal(names.Count, names.Distinct().Count());
    }

    #endregion

    #region IsValid

    [Fact]
    public void IsValid_Should_ReturnTrueForValidAlpha2Code()
    {
        Assert.True(Language.IsValid("en"));
        Assert.True(Language.IsValid("es"));
        Assert.True(Language.IsValid("fr"));
        Assert.True(Language.IsValid("ur"));
        Assert.True(Language.IsValid("de"));
        Assert.True(Language.IsValid("zh"));
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidAlpha3Code()
    {
        Assert.True(Language.IsValid("eng"));
        Assert.True(Language.IsValid("spa"));
        Assert.True(Language.IsValid("fre"));
        Assert.True(Language.IsValid("urd"));
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidName()
    {
        Assert.True(Language.IsValid("English"));
        Assert.True(Language.IsValid("French"));
        Assert.True(Language.IsValid("Urdu"));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Language.IsValid("xx"));
        Assert.False(Language.IsValid("xxx"));
        Assert.False(Language.IsValid(""));
        Assert.False(Language.IsValid("12"));
        Assert.False(Language.IsValid("!@"));
        Assert.False(Language.IsValid("Nonexistent Language"));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForNullOrWhitespace()
    {
        Assert.False(Language.IsValid(null!));
        Assert.False(Language.IsValid(""));
        Assert.False(Language.IsValid(" "));
        Assert.False(Language.IsValid("  "));
        Assert.False(Language.IsValid("\t"));
        Assert.False(Language.IsValid("\n"));
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        // Alpha2
        Assert.True(Language.IsValid("EN"));
        Assert.True(Language.IsValid("en"));
        Assert.True(Language.IsValid("En"));

        // Alpha3
        Assert.True(Language.IsValid("ENG"));
        Assert.True(Language.IsValid("eng"));
        Assert.True(Language.IsValid("Eng"));

        // Name
        Assert.True(Language.IsValid("english"));
        Assert.True(Language.IsValid("ENGLISH"));
        Assert.True(Language.IsValid("English"));
    }

    #endregion

    #region GetLanguage

    [Fact]
    public void GetLanguage_Should_ReturnByAlpha2Code()
    {
        var language = Language.GetLanguage("en");
        Assert.Equal("English", language.Name);
        Assert.Same(LanguageHelper.English, language);
    }

    [Fact]
    public void GetLanguage_Should_ReturnByAlpha3Code()
    {
        var language = Language.GetLanguage("fre");
        Assert.Equal("French", language.Name);
        Assert.Same(LanguageHelper.French, language);
    }

    [Fact]
    public void GetLanguage_Should_ReturnByName()
    {
        var language = Language.GetLanguage("Urdu");
        Assert.Equal("ur", language.Alpha2Code);
        Assert.Same(LanguageHelper.Urdu, language);
    }

    [Fact]
    public void GetLanguage_Should_BeCaseInsensitive()
    {
        var l1 = Language.GetLanguage("en");
        var l2 = Language.GetLanguage("EN");
        var l3 = Language.GetLanguage("En");

        Assert.Same(l1, l2);
        Assert.Same(l2, l3);
    }

    [Fact]
    public void GetLanguage_Should_ThrowForNullOrWhitespace()
    {
        Assert.Throws<ArgumentNullException>(() => Language.GetLanguage(null!));
        Assert.Throws<ArgumentNullException>(() => Language.GetLanguage(""));
        Assert.Throws<ArgumentNullException>(() => Language.GetLanguage(" "));
        Assert.Throws<ArgumentNullException>(() => Language.GetLanguage("\t"));
    }

    [Fact]
    public void GetLanguage_Should_ThrowLanguageNotFoundForInvalidIdentifier()
    {
        Assert.Throws<LanguageNotFoundException>(() => Language.GetLanguage("xx"));
        Assert.Throws<LanguageNotFoundException>(() => Language.GetLanguage("xxx"));
        Assert.Throws<LanguageNotFoundException>(() => Language.GetLanguage("Klingon"));
    }

    [Theory]
    [InlineData("en", "eng", "English")]
    [InlineData("fr", "fre", "French")]
    [InlineData("es", "spa", "Spanish; Castilian")]
    [InlineData("ur", "urd", "Urdu")]
    [InlineData("ar", "ara", "Arabic")]
    [InlineData("zh", "chi", "Chinese")]
    [InlineData("de", "ger", "German")]
    [InlineData("ja", "jpn", "Japanese")]
    public void GetLanguage_Should_ReturnCorrectProperties(string alpha2, string expectedAlpha3, string expectedName)
    {
        var language = Language.GetLanguage(alpha2);
        Assert.Equal(alpha2, language.Alpha2Code);
        Assert.Equal(expectedAlpha3, language.Alpha3Code);
        Assert.Equal(expectedName, language.Name);
    }

    #endregion

    #region GetLanguageOrDefault

    [Fact]
    public void GetLanguageOrDefault_Should_ReturnLanguageForValidAlpha2()
    {
        var language = Language.GetLanguageOrDefault("en");
        Assert.NotNull(language);
        Assert.Equal("English", language!.Name);
    }

    [Fact]
    public void GetLanguageOrDefault_Should_ReturnLanguageForValidAlpha3()
    {
        var language = Language.GetLanguageOrDefault("eng");
        Assert.NotNull(language);
        Assert.Equal("English", language!.Name);
    }

    [Fact]
    public void GetLanguageOrDefault_Should_ReturnLanguageForValidName()
    {
        var language = Language.GetLanguageOrDefault("French");
        Assert.NotNull(language);
        Assert.Equal("fr", language!.Alpha2Code);
    }

    [Fact]
    public void GetLanguageOrDefault_Should_ReturnNullForInvalidIdentifier()
    {
        Assert.Null(Language.GetLanguageOrDefault("xx"));
        Assert.Null(Language.GetLanguageOrDefault("xxx"));
        Assert.Null(Language.GetLanguageOrDefault("Klingon"));
    }

    [Fact]
    public void GetLanguageOrDefault_Should_ReturnNullForNullOrWhitespace()
    {
        Assert.Null(Language.GetLanguageOrDefault(null!));
        Assert.Null(Language.GetLanguageOrDefault(""));
        Assert.Null(Language.GetLanguageOrDefault(" "));
        Assert.Null(Language.GetLanguageOrDefault("\t"));
    }

    [Fact]
    public void GetLanguageOrDefault_Should_BeCaseInsensitive()
    {
        var l1 = Language.GetLanguageOrDefault("en");
        var l2 = Language.GetLanguageOrDefault("EN");
        var l3 = Language.GetLanguageOrDefault("En");

        Assert.NotNull(l1);
        Assert.Same(l1, l2);
        Assert.Same(l2, l3);
    }

    #endregion

    #region Language Properties

    [Fact]
    public void Language_Properties_Should_BeCorrectForEnglish()
    {
        var english = LanguageHelper.English;
        Assert.Equal("en", english.Alpha2Code);
        Assert.Equal("eng", english.Alpha3Code);
        Assert.Equal("English", english.Name);
    }

    [Fact]
    public void Language_Properties_Should_BeCorrectForSpanish()
    {
        var spanish = LanguageHelper.Spanish;
        Assert.Equal("es", spanish.Alpha2Code);
        Assert.Equal("spa", spanish.Alpha3Code);
        Assert.Equal("Spanish; Castilian", spanish.Name);
    }

    [Fact]
    public void Language_None_Should_HaveEmptyProperties()
    {
        var none = LanguageHelper.None;
        Assert.Equal(string.Empty, none.Alpha2Code);
        Assert.Equal(string.Empty, none.Alpha3Code);
        Assert.Equal(string.Empty, none.Name);
    }

    #endregion

    #region LanguageHelper Maps

    [Fact]
    public void LanguageHelper_Alpha2CodeMap_Should_ContainValidLanguages()
    {
        var map = LanguageHelper.Alpha2CodeMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("en"));
        Assert.True(map.ContainsKey("fr"));
        Assert.Same(LanguageHelper.English, map["en"]);
    }

    [Fact]
    public void LanguageHelper_Alpha3CodeMap_Should_ContainValidLanguages()
    {
        var map = LanguageHelper.Alpha3CodeMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("eng"));
        Assert.True(map.ContainsKey("fre"));
        Assert.Same(LanguageHelper.English, map["eng"]);
    }

    [Fact]
    public void LanguageHelper_NameMap_Should_ContainValidLanguages()
    {
        var map = LanguageHelper.NameMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("english"));
        Assert.True(map.ContainsKey("french"));
        Assert.Same(LanguageHelper.English, map["english"]);
    }

    #endregion

    #region Data Integrity

    [Fact]
    public void AllLanguages_Should_HaveNonEmptyName()
    {
        var languages = Language.GetAll();
        foreach (var language in languages)
        {
            Assert.False(string.IsNullOrEmpty(language.Name), $"Language with Alpha2={language.Alpha2Code}, Alpha3={language.Alpha3Code} has empty Name");
        }
    }

    [Fact]
    public void AllLanguages_Should_HaveNonEmptyAlpha3Code()
    {
        var languages = Language.GetAll();
        foreach (var language in languages)
        {
            Assert.False(string.IsNullOrEmpty(language.Alpha3Code), $"Language '{language.Name}' has empty Alpha3Code");
            // Most alpha3 codes are 3 chars, but reserved ranges like "qaa-qtz" are longer
            Assert.True(language.Alpha3Code.Length >= 3, $"Language '{language.Name}' has Alpha3Code shorter than 3: '{language.Alpha3Code}'");
        }
    }

    [Fact]
    public void AllLanguages_WithAlpha2_Should_HaveTwoLetterCode()
    {
        var languages = Language.GetAll().Where(l => !string.IsNullOrEmpty(l.Alpha2Code));
        foreach (var language in languages)
        {
            Assert.Equal(2, language.Alpha2Code.Length);
        }
    }

    [Fact]
    public void AllLanguages_Alpha3Codes_Should_BeLowercase()
    {
        var languages = Language.GetAll();
        foreach (var language in languages)
        {
            Assert.Equal(language.Alpha3Code, language.Alpha3Code.ToLowerInvariant());
        }
    }

    [Fact]
    public void AllLanguages_Alpha2Codes_Should_BeLowercase()
    {
        var languages = Language.GetAll().Where(l => !string.IsNullOrEmpty(l.Alpha2Code));
        foreach (var language in languages)
        {
            Assert.Equal(language.Alpha2Code, language.Alpha2Code.ToLowerInvariant());
        }
    }

    #endregion

    #region ToString

    [Fact]
    public void ToString_Should_ReturnNameAndAlpha3Code()
    {
        var english = LanguageHelper.English;
        Assert.Equal("English (eng)", english.ToString());
    }

    [Fact]
    public void ToString_Should_ReturnNameAndAlpha3CodeForFrench()
    {
        var french = LanguageHelper.French;
        Assert.Equal("French (fre)", french.ToString());
    }

    [Fact]
    public void ToString_None_Should_ReturnEmptyParens()
    {
        var none = LanguageHelper.None;
        Assert.Equal(" ()", none.ToString());
    }

    [Theory]
    [InlineData("es", "Spanish; Castilian (spa)")]
    [InlineData("ur", "Urdu (urd)")]
    [InlineData("de", "German (ger)")]
    [InlineData("ja", "Japanese (jpn)")]
    public void ToString_Should_FormatCorrectly(string alpha2, string expected)
    {
        var language = Language.GetLanguage(alpha2);
        Assert.Equal(expected, language.ToString());
    }

    #endregion

    #region Equals and GetHashCode

    [Fact]
    public void Equals_SameLanguage_Should_ReturnTrue()
    {
        var eng1 = Language.GetLanguage("en");
        var eng2 = Language.GetLanguage("eng");

        Assert.Equal(eng1, eng2);
        Assert.True(eng1.Equals(eng2));
    }

    [Fact]
    public void Equals_DifferentLanguage_Should_ReturnFalse()
    {
        var eng = Language.GetLanguage("en");
        var fre = Language.GetLanguage("fr");

        Assert.NotEqual(eng, fre);
        Assert.False(eng.Equals(fre));
    }

    [Fact]
    public void Equals_Null_Should_ReturnFalse()
    {
        var eng = Language.GetLanguage("en");
        Assert.False(eng.Equals(null));
    }

    [Fact]
    public void Equals_NonLanguageObject_Should_ReturnFalse()
    {
        var eng = Language.GetLanguage("en");
        Assert.False(eng.Equals("en"));
    }

    [Fact]
    public void GetHashCode_SameLanguage_Should_ReturnSameHash()
    {
        var eng1 = Language.GetLanguage("en");
        var eng2 = Language.GetLanguage("eng");

        Assert.Equal(eng1.GetHashCode(), eng2.GetHashCode());
    }

    [Fact]
    public void GetHashCode_DifferentLanguages_Should_ReturnDifferentHash()
    {
        var eng = Language.GetLanguage("en");
        var fre = Language.GetLanguage("fr");

        Assert.NotEqual(eng.GetHashCode(), fre.GetHashCode());
    }

    [Fact]
    public void Languages_Should_WorkInHashSet()
    {
        var set = new HashSet<Language>
        {
            Language.GetLanguage("en"),
            Language.GetLanguage("eng"),
            Language.GetLanguage("English")
        };

        Assert.Single(set);
    }

    [Fact]
    public void Languages_Should_WorkAsDictionaryKeys()
    {
        var dict = new Dictionary<Language, string>
        {
            { Language.GetLanguage("en"), "English Language" }
        };

        Assert.True(dict.ContainsKey(Language.GetLanguage("eng")));
        Assert.Equal("English Language", dict[Language.GetLanguage("English")]);
    }

    #endregion
}
