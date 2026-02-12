using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;
using Xunit;

namespace Multiverse.Globalization.UnitTests;

public class CountryTests
{
    [Fact]
    public void GetAll_Should_ReturnAllCountries()
    {
        List<Country>? countries = Country.GetAll();

        Assert.NotNull(countries);
        Assert.NotEmpty(countries);
        Assert.Contains(CountryHelper.None, countries);
        Assert.Contains(countries, c => c.Alpha2Code == "US" && c.Alpha3Code == "USA" && c.Name == "United States of America");
        Assert.Contains(countries, c => c.Alpha2Code == "GB" && c.Alpha3Code == "GBR" && c.Name == "United Kingdom");
        Assert.Contains(countries, c => c.Alpha2Code == "FR" && c.Alpha3Code == "FRA" && c.Name == "France");
    }

    [Fact]
    public void IsValid_Should_ReturnTrueForValidCode()
    {
        // Test with Alpha2 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha2Code));
        Assert.True(Country.IsValid(CountryHelper.UnitedKingdom.Alpha2Code));
        Assert.True(Country.IsValid(CountryHelper.France.Alpha2Code));
        Assert.True(Country.IsValid(CountryHelper.Pakistan.Alpha2Code));

        // Test with Alpha3 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha3Code));
        Assert.True(Country.IsValid(CountryHelper.UnitedKingdom.Alpha3Code));
        Assert.True(Country.IsValid(CountryHelper.France.Alpha3Code));
        Assert.True(Country.IsValid(CountryHelper.Pakistan.Alpha3Code));

        // Test with Numeric codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.NumericCode));
        Assert.True(Country.IsValid(CountryHelper.UnitedKingdom.NumericCode));
        Assert.True(Country.IsValid(CountryHelper.France.NumericCode));
        Assert.True(Country.IsValid(CountryHelper.Pakistan.NumericCode));

        // Test with Names
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Name));
        Assert.True(Country.IsValid(CountryHelper.UnitedKingdom.Name));
        Assert.True(Country.IsValid(CountryHelper.France.Name));
        Assert.True(Country.IsValid(CountryHelper.Pakistan.Name));
    }

    [Fact]
    public void IsValid_Should_ReturnFalseForInvalidCode()
    {
        Assert.False(Country.IsValid("XX")); // Invalid 2-letter code
        Assert.False(Country.IsValid("XXX")); // Invalid 3-letter code
        Assert.False(Country.IsValid("")); // Empty string
        Assert.False(Country.IsValid("12")); // Numeric code
        Assert.False(Country.IsValid("!@")); // Special characters
    }

    [Fact]
    public void IsValid_Should_IgnoreCaseSensitivity()
    {
        // Test with Alpha2 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha2Code.ToLower()));
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha2Code.ToUpper()));
        
        // Test with Alpha3 codes
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha3Code.ToLower()));
        Assert.True(Country.IsValid(CountryHelper.UnitedStatesOfAmerica.Alpha3Code.ToUpper()));
    }

    [Fact]
    public void Country_Properties_Should_BeCorrect()
    {
        // Test US properties
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.Equal("US", us.Alpha2Code);
        Assert.Equal("USA", us.Alpha3Code);
        Assert.Equal("840", us.NumericCode);
        Assert.Equal("United States of America", us.Name);
        Assert.Equal("+1", us.CallingCode);
        Assert.Equal("Washington, D.C.", us.Capital);
        Assert.Equal("Americas", us.Region);
        Assert.Equal("USD", us.CurrencyCode);
        Assert.False(string.IsNullOrEmpty(us.Flag));

        // Test UK properties
        var uk = CountryHelper.UnitedKingdom;
        Assert.Equal("GB", uk.Alpha2Code);
        Assert.Equal("GBR", uk.Alpha3Code);
        Assert.Equal("826", uk.NumericCode);
        Assert.Equal("United Kingdom", uk.Name);
        Assert.Equal("+44", uk.CallingCode);
        Assert.Equal("London", uk.Capital);
        Assert.Equal("Europe", uk.Region);
        Assert.Equal("GBP", uk.CurrencyCode);
        Assert.False(string.IsNullOrEmpty(uk.Flag));

        // Test None properties
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
    }

    [Fact]
    public void Country_Flag_Should_BeDerivedFromAlpha2Code()
    {
        // Flag emoji is derived from the alpha-2 code using Unicode regional indicators
        var us = CountryHelper.UnitedStatesOfAmerica;
        Assert.NotNull(us.Flag);
        Assert.NotEqual(string.Empty, us.Flag);

        var jp = CountryHelper.Japan;
        Assert.NotNull(jp.Flag);
        Assert.NotEqual(string.Empty, jp.Flag);

        // None should have empty flag
        Assert.Equal(string.Empty, CountryHelper.None.Flag);
    }

    [Theory]
    [InlineData("Pakistan", "+92", "Islamabad", "Asia", "PKR")]
    [InlineData("France", "+33", "Paris", "Europe", "EUR")]
    [InlineData("Australia", "+61", "Canberra", "Oceania", "AUD")]
    [InlineData("Nigeria", "+234", "Abuja", "Africa", "NGN")]
    public void Country_ExtendedProperties_Should_BeCorrect(
        string countryName, string expectedCallingCode, string expectedCapital, string expectedRegion, string expectedCurrencyCode)
    {
        var country = Country.GetCountry(countryName);

        Assert.Equal(expectedCallingCode, country.CallingCode);
        Assert.Equal(expectedCapital, country.Capital);
        Assert.Equal(expectedRegion, country.Region);
        Assert.Equal(expectedCurrencyCode, country.CurrencyCode);
    }

    [Fact]
    public void GetAll_Should_NotContainDuplicateCodes()
    {
        var countries = Country.GetAll();
        
        // Check for duplicate Alpha2 codes
        var alpha2Codes = countries.Select(c => c.Alpha2Code.ToLowerInvariant())
                                 .Where(code => !string.IsNullOrEmpty(code))
                                 .ToList();
        Assert.Equal(alpha2Codes.Count, alpha2Codes.Distinct().Count());

        // Check for duplicate Alpha3 codes
        var alpha3Codes = countries.Select(c => c.Alpha3Code.ToLowerInvariant())
                                 .Where(code => !string.IsNullOrEmpty(code))
                                 .ToList();
        Assert.Equal(alpha3Codes.Count, alpha3Codes.Distinct().Count());

        // Check for duplicate numeric codes
        var numericCodes = countries.Select(c => c.NumericCode)
                                  .Where(code => !string.IsNullOrEmpty(code))
                                  .ToList();
        Assert.Equal(numericCodes.Count, numericCodes.Distinct().Count());
    }

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

        // None should have null currency
        Assert.Null(CountryHelper.None.Currency);
        Assert.Equal(string.Empty, CountryHelper.None.CurrencyCode);
    }

    [Fact]
    public void Country_OfficialLanguages_Should_ReturnLanguages()
    {
        // Pakistan - Urdu + English
        var pk = CountryHelper.Pakistan;
        Assert.NotNull(pk.OfficialLanguages);
        Assert.Equal(2, pk.OfficialLanguages.Count);
        Assert.Contains(pk.OfficialLanguages, l => l.Alpha2Code == "ur"); // Urdu
        Assert.Contains(pk.OfficialLanguages, l => l.Alpha2Code == "en"); // English

        // France - French only
        var fr = CountryHelper.France;
        Assert.Single(fr.OfficialLanguages);
        Assert.Equal("fr", fr.OfficialLanguages[0].Alpha2Code);

        // Switzerland - German, French, Italian
        var ch = CountryHelper.Switzerland;
        Assert.Equal(3, ch.OfficialLanguages.Count);

        // Antarctica - no official languages
        var aq = CountryHelper.Antarctica;
        Assert.NotNull(aq.OfficialLanguages);
        Assert.Empty(aq.OfficialLanguages);

        // None - no official languages
        Assert.NotNull(CountryHelper.None.OfficialLanguages);
        Assert.Empty(CountryHelper.None.OfficialLanguages);
    }

    [Fact]
    public void Country_CurrencyCode_Should_BeDerivedFromCurrency()
    {
        // CurrencyCode is a computed property from Currency?.Code
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
    public void Country_CurrencyShouldMatchCode(string alpha2, string expectedCurrencyCode)
    {
        var country = Country.GetCountry(alpha2);
        Assert.NotNull(country.Currency);
        Assert.Equal(expectedCurrencyCode, country.Currency!.Code);
        Assert.Equal(expectedCurrencyCode, country.CurrencyCode);
    }
}
