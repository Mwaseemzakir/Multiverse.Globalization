using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CountryTests
{
    #region GetAll

    [Fact]
    public void GetAll_Should_ReturnAllCountries()
    {
        IReadOnlyList<Country> countries = Country.GetAll();

        Assert.NotNull(countries);
        Assert.NotEmpty(countries);
        Assert.Contains(CountryHelper.None, countries);
        Assert.Contains(countries, c => c.Alpha2Code == "US" && c.Alpha3Code == "USA" && c.Name == "United States of America");
        Assert.Contains(countries, c => c.Alpha2Code == "GB" && c.Alpha3Code == "GBR" && c.Name == "United Kingdom");
        Assert.Contains(countries, c => c.Alpha2Code == "FR" && c.Alpha3Code == "FRA" && c.Name == "France");
    }

    [Fact]
    public void GetAll_Should_ReturnSameCachedInstance()
    {
        var list1 = Country.GetAll();
        var list2 = Country.GetAll();

        Assert.Same(list1, list2);
        Assert.Equal(list1.Count, list2.Count);
    }

    [Fact]
    public void GetAll_Should_BeOrderedByName()
    {
        var countries = Country.GetAll();
        var names = countries.Select(c => c.Name).ToList();
        var sorted = names.OrderBy(n => n).ToList();

        Assert.Equal(sorted, names);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateAlpha2Codes()
    {
        var countries = Country.GetAll();
        var alpha2Codes = countries
            .Select(c => c.Alpha2Code.ToLowerInvariant())
            .Where(code => !string.IsNullOrEmpty(code))
            .ToList();

        Assert.Equal(alpha2Codes.Count, alpha2Codes.Distinct().Count());
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateAlpha3Codes()
    {
        var countries = Country.GetAll();
        var alpha3Codes = countries
            .Select(c => c.Alpha3Code.ToLowerInvariant())
            .Where(code => !string.IsNullOrEmpty(code))
            .ToList();

        Assert.Equal(alpha3Codes.Count, alpha3Codes.Distinct().Count());
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateNumericCodes()
    {
        var countries = Country.GetAll();
        var numericCodes = countries
            .Select(c => c.NumericCode)
            .Where(code => !string.IsNullOrEmpty(code))
            .ToList();

        Assert.Equal(numericCodes.Count, numericCodes.Distinct().Count());
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateNames()
    {
        var countries = Country.GetAll();
        var names = countries
            .Select(c => c.Name.ToLowerInvariant())
            .Where(n => !string.IsNullOrEmpty(n))
            .ToList();

        Assert.Equal(names.Count, names.Distinct().Count());
    }

    #endregion

    #region IsValid

    [Fact]
    public void IsValid_Should_ReturnTrueForValidAlpha2Code()
    {
        Assert.True(Country.IsValid("US"));
        Assert.True(Country.IsValid("GB"));
        Assert.True(Country.IsValid("FR"));
        Assert.True(Country.IsValid("PK"));
        Assert.True(Country.IsValid("JP"));
        Assert.True(Country.IsValid("DE"));
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidAlpha3Code()
    {
        Assert.True(Country.IsValid("USA"));
        Assert.True(Country.IsValid("GBR"));
        Assert.True(Country.IsValid("FRA"));
        Assert.True(Country.IsValid("PAK"));
        Assert.True(Country.IsValid("JPN"));
        Assert.True(Country.IsValid("DEU"));
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidNumericCode()
    {
        Assert.True(Country.IsValid("840")); // US
        Assert.True(Country.IsValid("826")); // UK
        Assert.True(Country.IsValid("250")); // France
        Assert.True(Country.IsValid("586")); // Pakistan
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidName()
    {
        Assert.True(Country.IsValid("United States of America"));
        Assert.True(Country.IsValid("United Kingdom"));
        Assert.True(Country.IsValid("France"));
        Assert.True(Country.IsValid("Pakistan"));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Country.IsValid("XX"));
        Assert.False(Country.IsValid("XXX"));
        Assert.False(Country.IsValid(""));
        Assert.False(Country.IsValid("12"));
        Assert.False(Country.IsValid("!@"));
        Assert.False(Country.IsValid("ABCD"));
        Assert.False(Country.IsValid("Nonexistentland"));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForNullOrWhitespace()
    {
        Assert.False(Country.IsValid(null!));
        Assert.False(Country.IsValid(""));
        Assert.False(Country.IsValid(" "));
        Assert.False(Country.IsValid("  "));
        Assert.False(Country.IsValid("\t"));
        Assert.False(Country.IsValid("\n"));
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        // Alpha2
        Assert.True(Country.IsValid("us"));
        Assert.True(Country.IsValid("US"));
        Assert.True(Country.IsValid("Us"));

        // Alpha3
        Assert.True(Country.IsValid("usa"));
        Assert.True(Country.IsValid("USA"));
        Assert.True(Country.IsValid("Usa"));

        // Name
        Assert.True(Country.IsValid("united states of america"));
        Assert.True(Country.IsValid("UNITED STATES OF AMERICA"));
        Assert.True(Country.IsValid("united kingdom"));
    }

    #endregion

    #region GetCountry

    [Fact]
    public void GetCountry_Should_ReturnByAlpha2Code()
    {
        var country = Country.GetCountry("US");
        Assert.Equal("United States of America", country.Name);
        Assert.Same(CountryHelper.UnitedStatesOfAmerica, country);
    }

    [Fact]
    public void GetCountry_Should_ReturnByAlpha3Code()
    {
        var country = Country.GetCountry("GBR");
        Assert.Equal("United Kingdom", country.Name);
        Assert.Same(CountryHelper.UnitedKingdom, country);
    }

    [Fact]
    public void GetCountry_Should_ReturnByNumericCode()
    {
        var country = Country.GetCountry("250");
        Assert.Equal("France", country.Name);
        Assert.Same(CountryHelper.France, country);
    }

    [Fact]
    public void GetCountry_Should_ReturnByName()
    {
        var country = Country.GetCountry("Pakistan");
        Assert.Equal("PK", country.Alpha2Code);
        Assert.Same(CountryHelper.Pakistan, country);
    }

    [Fact]
    public void GetCountry_Should_BeCaseInsensitive()
    {
        var c1 = Country.GetCountry("us");
        var c2 = Country.GetCountry("US");
        var c3 = Country.GetCountry("Us");

        Assert.Same(c1, c2);
        Assert.Same(c2, c3);
    }

    [Fact]
    public void GetCountry_Should_ThrowForNullOrWhitespace()
    {
        Assert.Throws<ArgumentNullException>(() => Country.GetCountry(null!));
        Assert.Throws<ArgumentNullException>(() => Country.GetCountry(""));
        Assert.Throws<ArgumentNullException>(() => Country.GetCountry(" "));
        Assert.Throws<ArgumentNullException>(() => Country.GetCountry("\t"));
    }

    [Fact]
    public void GetCountry_Should_ThrowCountryNotFoundForInvalidIdentifier()
    {
        Assert.Throws<CountryNotFoundException>(() => Country.GetCountry("XX"));
        Assert.Throws<CountryNotFoundException>(() => Country.GetCountry("XXX"));
        Assert.Throws<CountryNotFoundException>(() => Country.GetCountry("Narnia"));
        Assert.Throws<CountryNotFoundException>(() => Country.GetCountry("999"));
    }

    [Theory]
    [InlineData("US", "United States of America")]
    [InlineData("GB", "United Kingdom")]
    [InlineData("JP", "Japan")]
    [InlineData("IN", "India")]
    [InlineData("BR", "Brazil")]
    [InlineData("AU", "Australia")]
    [InlineData("CA", "Canada")]
    [InlineData("DE", "Germany")]
    public void GetCountry_Should_ReturnCorrectCountryByAlpha2(string alpha2, string expectedName)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expectedName, country.Name);
    }

    #endregion

    #region GetCountryOrDefault

    [Fact]
    public void GetCountryOrDefault_Should_ReturnCountryForValidAlpha2()
    {
        var country = Country.GetCountryOrDefault("US");
        Assert.NotNull(country);
        Assert.Equal("United States of America", country!.Name);
    }

    [Fact]
    public void GetCountryOrDefault_Should_ReturnCountryForValidAlpha3()
    {
        var country = Country.GetCountryOrDefault("GBR");
        Assert.NotNull(country);
        Assert.Equal("United Kingdom", country!.Name);
    }

    [Fact]
    public void GetCountryOrDefault_Should_ReturnCountryForValidNumericCode()
    {
        var country = Country.GetCountryOrDefault("586");
        Assert.NotNull(country);
        Assert.Equal("Pakistan", country!.Name);
    }

    [Fact]
    public void GetCountryOrDefault_Should_ReturnCountryForValidName()
    {
        var country = Country.GetCountryOrDefault("France");
        Assert.NotNull(country);
        Assert.Equal("FR", country!.Alpha2Code);
    }

    [Fact]
    public void GetCountryOrDefault_Should_ReturnNullForInvalidIdentifier()
    {
        Assert.Null(Country.GetCountryOrDefault("XX"));
        Assert.Null(Country.GetCountryOrDefault("XXX"));
        Assert.Null(Country.GetCountryOrDefault("Narnia"));
        Assert.Null(Country.GetCountryOrDefault("999"));
    }

    [Fact]
    public void GetCountryOrDefault_Should_ReturnNullForNullOrWhitespace()
    {
        Assert.Null(Country.GetCountryOrDefault(null!));
        Assert.Null(Country.GetCountryOrDefault(""));
        Assert.Null(Country.GetCountryOrDefault(" "));
        Assert.Null(Country.GetCountryOrDefault("\t"));
    }

    [Fact]
    public void GetCountryOrDefault_Should_BeCaseInsensitive()
    {
        var c1 = Country.GetCountryOrDefault("gb");
        var c2 = Country.GetCountryOrDefault("GB");
        var c3 = Country.GetCountryOrDefault("Gb");

        Assert.NotNull(c1);
        Assert.Same(c1, c2);
        Assert.Same(c2, c3);
    }

    #endregion

    #region Country Properties

    [Fact]
    public void Country_Properties_Should_BeCorrectForUS()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.Equal("US", us.Alpha2Code);
        Assert.Equal("USA", us.Alpha3Code);
        Assert.Equal("840", us.NumericCode);
        Assert.Equal("United States of America", us.Name);
        Assert.Equal("+1", us.CallingCode);
        Assert.Equal("Washington, D.C.", us.Capital);
        Assert.Equal("Americas", us.Region);
        Assert.Equal("USD", us.CurrencyCode);
        Assert.NotNull(us.Currency);
        Assert.Same(CurrencyHelper.UsDollar, us.Currency);
        Assert.NotNull(us.OfficialLanguages);
        Assert.NotEmpty(us.OfficialLanguages);
    }

    [Fact]
    public void Country_Properties_Should_BeCorrectForUK()
    {
        var uk = CountryHelper.UnitedKingdom;
        Assert.Equal("GB", uk.Alpha2Code);
        Assert.Equal("GBR", uk.Alpha3Code);
        Assert.Equal("826", uk.NumericCode);
        Assert.Equal("United Kingdom", uk.Name);
        Assert.Equal("+44", uk.CallingCode);
        Assert.Equal("London", uk.Capital);
        Assert.Equal("Europe", uk.Region);
        Assert.Equal("GBP", uk.CurrencyCode);
        Assert.NotNull(uk.Currency);
        Assert.Same(CurrencyHelper.PoundSterling, uk.Currency);
    }

    [Fact]
    public void Country_None_Should_HaveEmptyProperties()
    {
        var none = CountryHelper.None;
        Assert.Equal(string.Empty, none.Alpha2Code);
        Assert.Equal(string.Empty, none.Alpha3Code);
        Assert.Equal(string.Empty, none.NumericCode);
        Assert.Equal(string.Empty, none.Name);
        Assert.Equal(string.Empty, none.CallingCode);
        Assert.Equal(string.Empty, none.Capital);
        Assert.Equal(string.Empty, none.Region);
        Assert.Equal(string.Empty, none.CurrencyCode);
        Assert.Equal(string.Empty, none.Flag);
        Assert.Null(none.Currency);
        Assert.NotNull(none.OfficialLanguages);
        Assert.Empty(none.OfficialLanguages);
    }

    [Theory]
    [InlineData("Pakistan", "+92", "Islamabad", "Asia", "PKR")]
    [InlineData("France", "+33", "Paris", "Europe", "EUR")]
    [InlineData("Australia", "+61", "Canberra", "Oceania", "AUD")]
    [InlineData("Nigeria", "+234", "Abuja", "Africa", "NGN")]
    [InlineData("Japan", "+81", "Tokyo", "Asia", "JPY")]
    [InlineData("Brazil", "+55", "Brasilia", "Americas", "BRL")]
    [InlineData("Germany", "+49", "Berlin", "Europe", "EUR")]
    [InlineData("India", "+91", "New Delhi", "Asia", "INR")]
    public void Country_ExtendedProperties_Should_BeCorrect(
        string countryName, string expectedCallingCode, string expectedCapital, string expectedRegion, string expectedCurrencyCode)
    {
        var country = Country.GetCountry(countryName);

        Assert.Equal(expectedCallingCode, country.CallingCode);
        Assert.Equal(expectedCapital, country.Capital);
        Assert.Equal(expectedRegion, country.Region);
        Assert.Equal(expectedCurrencyCode, country.CurrencyCode);
    }

    #endregion

    #region Flag

    [Fact]
    public void Country_Flag_Should_BeDerivedFromAlpha2Code()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.NotNull(us.Flag);
        Assert.NotEqual(string.Empty, us.Flag);
        // Flag emoji should be two Unicode regional indicator characters
        Assert.Equal(4, us.Flag.Length); // Each regional indicator is 2 chars in UTF-16

        var jp = CountryHelper.Japan;
        Assert.NotNull(jp.Flag);
        Assert.NotEqual(string.Empty, jp.Flag);
    }

    [Fact]
    public void Country_Flag_Should_BeEmptyForNone()
    {
        Assert.Equal(string.Empty, CountryHelper.None.Flag);
    }

    [Fact]
    public void Country_Flag_Should_BeConsistentAcrossAccesses()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        var flag1 = us.Flag;
        var flag2 = us.Flag;
        Assert.Equal(flag1, flag2);
    }

    [Fact]
    public void Country_Flag_Should_NotBeEmptyForCountriesWithAlpha2Code()
    {
        var countries = Country.GetAll().Where(c => !string.IsNullOrEmpty(c.Alpha2Code));
        foreach (var country in countries)
        {
            Assert.NotEqual(string.Empty, country.Flag);
        }
    }

    #endregion

    #region Currency Relationship

    [Fact]
    public void Country_Currency_Should_ReturnCurrencyObject()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.NotNull(us.Currency);
        Assert.Equal("USD", us.Currency!.Code);
        Assert.Equal("US Dollar", us.Currency.Name);
        Assert.Same(CurrencyHelper.UsDollar, us.Currency);

        var uk = CountryHelper.UnitedKingdom;
        Assert.NotNull(uk.Currency);
        Assert.Equal("GBP", uk.Currency!.Code);
        Assert.Same(CurrencyHelper.PoundSterling, uk.Currency);

        var pk = CountryHelper.Pakistan;
        Assert.NotNull(pk.Currency);
        Assert.Equal("PKR", pk.Currency!.Code);
        Assert.Same(CurrencyHelper.PakistanRupee, pk.Currency);
    }

    [Fact]
    public void Country_CurrencyCode_Should_BeDerivedFromCurrency()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.Equal(us.Currency!.Code, us.CurrencyCode);

        // Country with null currency should return empty string
        var aq = CountryHelper.Antarctica;
        Assert.Null(aq.Currency);
        Assert.Equal(string.Empty, aq.CurrencyCode);
    }

    [Theory]
    [InlineData("US", "USD")]
    [InlineData("GB", "GBP")]
    [InlineData("JP", "JPY")]
    [InlineData("IN", "INR")]
    [InlineData("PK", "PKR")]
    [InlineData("DE", "EUR")]
    [InlineData("FR", "EUR")]
    [InlineData("CH", "CHF")]
    [InlineData("AU", "AUD")]
    [InlineData("CA", "CAD")]
    [InlineData("CN", "CNY")]
    [InlineData("BR", "BRL")]
    [InlineData("SA", "SAR")]
    [InlineData("KR", "KRW")]
    public void Country_CurrencyShouldMatchCode(string alpha2, string expectedCurrencyCode)
    {
        var country = Country.GetCountry(alpha2);
        Assert.NotNull(country.Currency);
        Assert.Equal(expectedCurrencyCode, country.Currency!.Code);
        Assert.Equal(expectedCurrencyCode, country.CurrencyCode);
    }

    #endregion

    #region OfficialLanguages

    [Fact]
    public void Country_OfficialLanguages_Should_ReturnLanguages()
    {
        // Pakistan - Urdu + English
        var pk = CountryHelper.Pakistan;
        Assert.NotNull(pk.OfficialLanguages);
        Assert.Equal(2, pk.OfficialLanguages.Count);
        Assert.Contains(pk.OfficialLanguages, l => l.Alpha2Code == "ur");
        Assert.Contains(pk.OfficialLanguages, l => l.Alpha2Code == "en");

        // France - French only
        var fr = CountryHelper.France;
        Assert.Single(fr.OfficialLanguages);
        Assert.Equal("fr", fr.OfficialLanguages[0].Alpha2Code);

        // Switzerland - German, French, Italian
        var ch = CountryHelper.Switzerland;
        Assert.Equal(3, ch.OfficialLanguages.Count);
    }

    [Fact]
    public void Country_OfficialLanguages_Should_BeEmptyForAntarctica()
    {
        var aq = CountryHelper.Antarctica;
        Assert.NotNull(aq.OfficialLanguages);
        Assert.Empty(aq.OfficialLanguages);
    }

    [Fact]
    public void Country_OfficialLanguages_Should_BeEmptyForNone()
    {
        Assert.NotNull(CountryHelper.None.OfficialLanguages);
        Assert.Empty(CountryHelper.None.OfficialLanguages);
    }

    [Fact]
    public void Country_OfficialLanguages_Should_BeReadOnly()
    {
        var pk = CountryHelper.Pakistan;
        Assert.IsAssignableFrom<IReadOnlyList<Language>>(pk.OfficialLanguages);
    }

    #endregion

    #region CountryHelper Maps

    [Fact]
    public void CountryHelper_Alpha2CodeMap_Should_ContainAllCountriesWithAlpha2()
    {
        var map = CountryHelper.Alpha2CodeMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("us"));
        Assert.True(map.ContainsKey("gb"));
        Assert.Same(CountryHelper.UnitedStatesOfAmerica, map["us"]);
    }

    [Fact]
    public void CountryHelper_Alpha3CodeMap_Should_ContainAllCountriesWithAlpha3()
    {
        var map = CountryHelper.Alpha3CodeMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("usa"));
        Assert.True(map.ContainsKey("gbr"));
        Assert.Same(CountryHelper.UnitedStatesOfAmerica, map["usa"]);
    }

    [Fact]
    public void CountryHelper_NameMap_Should_ContainAllCountries()
    {
        var map = CountryHelper.NameMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("united states of america"));
        Assert.True(map.ContainsKey("united kingdom"));
        Assert.Same(CountryHelper.UnitedStatesOfAmerica, map["united states of america"]);
    }

    [Fact]
    public void CountryHelper_NumericCodeMap_Should_ContainAllCountries()
    {
        var map = CountryHelper.NumericCodeMap;
        Assert.NotNull(map);
        Assert.True(map.Count > 0);
        Assert.True(map.ContainsKey("840"));
        Assert.True(map.ContainsKey("826"));
        Assert.Same(CountryHelper.UnitedStatesOfAmerica, map["840"]);
    }

    #endregion

    #region Data Integrity

    [Fact]
    public void AllCountries_Should_HaveNonNullOfficialLanguages()
    {
        var countries = Country.GetAll();
        foreach (var country in countries)
        {
            Assert.NotNull(country.OfficialLanguages);
        }
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptyName()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.Name), $"Country with Alpha2={country.Alpha2Code} has empty name");
        }
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptyAlpha2Code()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.Alpha2Code), $"Country '{country.Name}' has empty Alpha2Code");
            Assert.Equal(2, country.Alpha2Code.Length);
        }
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptyAlpha3Code()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.Alpha3Code), $"Country '{country.Name}' has empty Alpha3Code");
            Assert.Equal(3, country.Alpha3Code.Length);
        }
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptyNumericCode()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.NumericCode), $"Country '{country.Name}' has empty NumericCode");
            Assert.Equal(3, country.NumericCode.Length);
        }
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptyRegion()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.Region), $"Country '{country.Name}' has empty Region");
        }
    }

    [Fact]
    public void AllCountries_Regions_Should_BeFromKnownSet()
    {
        var validRegions = new HashSet<string> { "Asia", "Europe", "Americas", "Africa", "Oceania", "Antarctic", "" };
        var countries = Country.GetAll();
        foreach (var country in countries)
        {
            Assert.Contains(country.Region, validRegions);
        }
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveCallingCode()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.CallingCode), $"Country '{country.Name}' has empty CallingCode");
            Assert.StartsWith("+", country.CallingCode);
        }
    }

    [Fact]
    public void AllCountries_WithCurrency_Should_HaveCurrencyCodeMatchingCurrency()
    {
        var countries = Country.GetAll().Where(c => c.Currency != null);
        foreach (var country in countries)
        {
            Assert.Equal(country.Currency!.Code, country.CurrencyCode);
        }
    }

    [Fact]
    public void AllCountries_WithoutCurrency_Should_HaveEmptyCurrencyCode()
    {
        var countries = Country.GetAll().Where(c => c.Currency == null);
        foreach (var country in countries)
        {
            Assert.Equal(string.Empty, country.CurrencyCode);
        }
    }

    #endregion

    #region SubRegion

    [Theory]
    [InlineData("US", "Northern America")]
    [InlineData("PK", "Southern Asia")]
    [InlineData("JP", "Eastern Asia")]
    [InlineData("GB", "Northern Europe")]
    [InlineData("BR", "South America")]
    [InlineData("AU", "Australia and New Zealand")]
    [InlineData("DE", "Western Europe")]
    [InlineData("NG", "Western Africa")]
    public void Country_SubRegion_Should_BeCorrect(string alpha2, string expectedSubRegion)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expectedSubRegion, country.SubRegion);
    }

    [Fact]
    public void Country_SubRegion_Should_BeEmptyForNone()
    {
        Assert.Equal(string.Empty, CountryHelper.None.SubRegion);
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptySubRegion()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.SubRegion), $"Country '{country.Name}' has empty SubRegion");
        }
    }

    #endregion

    #region Demonym

    [Theory]
    [InlineData("US", "American")]
    [InlineData("PK", "Pakistani")]
    [InlineData("JP", "Japanese")]
    [InlineData("GB", "British")]
    [InlineData("BR", "Brazilian")]
    [InlineData("AU", "Australian")]
    [InlineData("DE", "German")]
    [InlineData("NG", "Nigerian")]
    public void Country_Demonym_Should_BeCorrect(string alpha2, string expectedDemonym)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expectedDemonym, country.Demonym);
    }

    [Fact]
    public void Country_Demonym_Should_BeEmptyForNone()
    {
        Assert.Equal(string.Empty, CountryHelper.None.Demonym);
    }

    [Fact]
    public void AllCountries_ExceptNoneAndAntarctica_Should_HaveNonEmptyDemonym()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None && c != CountryHelper.Antarctica);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.Demonym), $"Country '{country.Name}' has empty Demonym");
        }
    }

    #endregion

    #region TLD

    [Theory]
    [InlineData("US", ".us")]
    [InlineData("PK", ".pk")]
    [InlineData("JP", ".jp")]
    [InlineData("GB", ".uk")]
    [InlineData("BR", ".br")]
    [InlineData("AU", ".au")]
    [InlineData("DE", ".de")]
    [InlineData("NG", ".ng")]
    public void Country_TLD_Should_BeCorrect(string alpha2, string expectedTld)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expectedTld, country.TLD);
    }

    [Fact]
    public void Country_TLD_Should_BeEmptyForNone()
    {
        Assert.Equal(string.Empty, CountryHelper.None.TLD);
    }

    [Fact]
    public void AllCountries_ExceptNone_Should_HaveNonEmptyTLD()
    {
        var countries = Country.GetAll().Where(c => c != CountryHelper.None);
        foreach (var country in countries)
        {
            Assert.False(string.IsNullOrEmpty(country.TLD), $"Country '{country.Name}' has empty TLD");
        }
    }

    [Fact]
    public void AllCountries_TLD_Should_StartWithDot()
    {
        var countries = Country.GetAll().Where(c => !string.IsNullOrEmpty(c.TLD));
        foreach (var country in countries)
        {
            Assert.StartsWith(".", country.TLD);
        }
    }

    #endregion

    #region SetExtendedData Properties on Known Countries

    [Fact]
    public void Country_Properties_Should_IncludeExtendedDataForUS()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.Equal("Northern America", us.SubRegion);
        Assert.Equal("American", us.Demonym);
        Assert.Equal(".us", us.TLD);
    }

    [Fact]
    public void Country_Properties_Should_IncludeExtendedDataForUK()
    {
        var uk = CountryHelper.UnitedKingdom;
        Assert.Equal("Northern Europe", uk.SubRegion);
        Assert.Equal("British", uk.Demonym);
        Assert.Equal(".uk", uk.TLD);
    }

    [Fact]
    public void Country_None_Should_HaveEmptyExtendedProperties()
    {
        var none = CountryHelper.None;
        Assert.Equal(string.Empty, none.SubRegion);
        Assert.Equal(string.Empty, none.Demonym);
        Assert.Equal(string.Empty, none.TLD);
    }

    #endregion

    #region ToString

    [Fact]
    public void ToString_Should_ReturnNameAndAlpha2Code()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.Equal("United States of America (US)", us.ToString());
    }

    [Fact]
    public void ToString_Should_ReturnNameAndAlpha2CodeForUK()
    {
        var uk = CountryHelper.UnitedKingdom;
        Assert.Equal("United Kingdom (GB)", uk.ToString());
    }

    [Fact]
    public void ToString_None_Should_ReturnEmptyParens()
    {
        var none = CountryHelper.None;
        Assert.Equal(" ()", none.ToString());
    }

    [Theory]
    [InlineData("PK", "Pakistan (PK)")]
    [InlineData("JP", "Japan (JP)")]
    [InlineData("DE", "Germany (DE)")]
    [InlineData("FR", "France (FR)")]
    [InlineData("BR", "Brazil (BR)")]
    public void ToString_Should_FormatCorrectly(string alpha2, string expected)
    {
        var country = Country.GetCountry(alpha2);
        Assert.Equal(expected, country.ToString());
    }

    #endregion

    #region Equals and GetHashCode

    [Fact]
    public void Equals_SameCountry_Should_ReturnTrue()
    {
        var us1 = Country.GetCountry("US");
        var us2 = Country.GetCountry("USA");

        Assert.Equal(us1, us2);
        Assert.True(us1.Equals(us2));
    }

    [Fact]
    public void Equals_DifferentCountry_Should_ReturnFalse()
    {
        var us = Country.GetCountry("US");
        var uk = Country.GetCountry("GB");

        Assert.NotEqual(us, uk);
        Assert.False(us.Equals(uk));
    }

    [Fact]
    public void Equals_Null_Should_ReturnFalse()
    {
        var us = Country.GetCountry("US");
        Assert.False(us.Equals(null));
    }

    [Fact]
    public void Equals_NonCountryObject_Should_ReturnFalse()
    {
        var us = Country.GetCountry("US");
        Assert.False(us.Equals("US"));
    }

    [Fact]
    public void GetHashCode_SameCountry_Should_ReturnSameHash()
    {
        var us1 = Country.GetCountry("US");
        var us2 = Country.GetCountry("USA");

        Assert.Equal(us1.GetHashCode(), us2.GetHashCode());
    }

    [Fact]
    public void GetHashCode_DifferentCountries_Should_ReturnDifferentHash()
    {
        var us = Country.GetCountry("US");
        var uk = Country.GetCountry("GB");

        Assert.NotEqual(us.GetHashCode(), uk.GetHashCode());
    }

    [Fact]
    public void Countries_Should_WorkInHashSet()
    {
        var set = new HashSet<Country>
        {
            Country.GetCountry("US"),
            Country.GetCountry("USA"),
            Country.GetCountry("United States of America")
        };

        Assert.Single(set);
    }

    [Fact]
    public void Countries_Should_WorkAsDictionaryKeys()
    {
        var dict = new Dictionary<Country, string>
        {
            { Country.GetCountry("US"), "United States" }
        };

        Assert.True(dict.ContainsKey(Country.GetCountry("USA")));
        Assert.Equal("United States", dict[Country.GetCountry("840")]);
    }

    #endregion

    #region Cached Properties

    [Fact]
    public void Holidays_Should_ReturnSameCachedInstance()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        var holidays1 = us.Holidays;
        var holidays2 = us.Holidays;

        Assert.Same(holidays1, holidays2);
    }

    [Fact]
    public void TimeZones_Should_ReturnSameCachedInstance()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        var tz1 = us.TimeZones;
        var tz2 = us.TimeZones;

        Assert.Same(tz1, tz2);
    }

    [Fact]
    public void Flag_Should_ReturnSameCachedInstance()
    {
        var us = CountryHelper.UnitedStatesOfAmerica;
        var flag1 = us.Flag;
        var flag2 = us.Flag;

        Assert.Same(flag1, flag2);
    }

    #endregion
}
