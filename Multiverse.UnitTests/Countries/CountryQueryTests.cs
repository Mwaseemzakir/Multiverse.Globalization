namespace Multiverse.Globalization.UnitTests.Countries;

public class CountryQueryTests
{
    // ── Region filters ──────────────────────────────────────────────

    [Fact]
    public void InRegion_Should_ReturnOnlyCountriesInThatRegion()
    {
        var europe = Country.InRegion("Europe");

        Assert.NotEmpty(europe);
        Assert.All(europe, c => Assert.Equal("Europe", c.Region));
        Assert.Contains(europe, c => c.Alpha2Code == "DE");
        Assert.DoesNotContain(europe, c => c.Alpha2Code == "US");
    }

    [Fact]
    public void InRegion_Should_BeCaseInsensitiveAndTrimmed()
    {
        Assert.Equal(Country.InRegion("Europe").Count, Country.InRegion("  eURoPe  ").Count);
    }

    [Fact]
    public void InRegion_Should_ReturnEmptyForUnknownOrBlankInput()
    {
        Assert.Empty(Country.InRegion("Atlantis"));
        Assert.Empty(Country.InRegion(""));
        Assert.Empty(Country.InRegion("   "));
    }

    [Fact]
    public void InSubRegion_Should_ReturnOnlyCountriesInThatSubRegion()
    {
        var southernAsia = Country.InSubRegion("Southern Asia");

        Assert.NotEmpty(southernAsia);
        Assert.Contains(southernAsia, c => c.Alpha2Code == "PK");
        Assert.All(southernAsia, c => Assert.Equal("Southern Asia", c.SubRegion));
    }

    // ── Currency and language filters ───────────────────────────────

    [Fact]
    public void UsingCurrency_Should_FindTheEurozone()
    {
        var eurozone = Country.UsingCurrency("EUR");

        Assert.Contains(eurozone, c => c.Alpha2Code == "DE");
        Assert.Contains(eurozone, c => c.Alpha2Code == "FR");
        Assert.All(eurozone, c => Assert.Equal("EUR", c.Currency!.Code));
    }

    [Fact]
    public void UsingCurrency_Should_AcceptACurrencyName()
    {
        Assert.Equal(Country.UsingCurrency("EUR").Count, Country.UsingCurrency("Euro").Count);
    }

    [Fact]
    public void UsingCurrency_Should_ReturnEmptyForAnUnknownCurrency()
    {
        Assert.Empty(Country.UsingCurrency("XYZ"));
        Assert.Empty(Country.UsingCurrency(""));
    }

    [Fact]
    public void SpeakingLanguage_Should_FindCountriesByAnyLanguageIdentifier()
    {
        var byName = Country.SpeakingLanguage("French");
        var byAlpha2 = Country.SpeakingLanguage("fr");

        Assert.Contains(byName, c => c.Alpha2Code == "FR");
        Assert.Equal(byName.Count, byAlpha2.Count);
    }

    [Fact]
    public void SpeakingLanguage_Should_ReturnEmptyForAnUnknownLanguage()
    {
        Assert.Empty(Country.SpeakingLanguage("Klingon"));
    }

    // ── Calling code ────────────────────────────────────────────────

    [Fact]
    public void WithCallingCode_Should_ReturnTheWholeNumberingPlan()
    {
        var nanp = Country.WithCallingCode("+1");

        Assert.Contains(nanp, c => c.Alpha2Code == "US");
        Assert.Contains(nanp, c => c.Alpha2Code == "CA");
    }

    [Fact]
    public void WithCallingCode_Should_AcceptTheCodeWithoutAPlus()
    {
        Assert.Equal(Country.WithCallingCode("+92").Count, Country.WithCallingCode("92").Count);
        Assert.Contains(Country.WithCallingCode("92"), c => c.Alpha2Code == "PK");
    }

    [Fact]
    public void WithCallingCode_Should_ReturnEmptyForBlankInput()
    {
        Assert.Empty(Country.WithCallingCode(""));
    }

    // ── Search ──────────────────────────────────────────────────────

    [Fact]
    public void Search_Should_RankAnExactCodeFirst()
    {
        Assert.Equal("US", Country.Search("USA")[0].Alpha2Code);
        Assert.Equal("DE", Country.Search("DE")[0].Alpha2Code);
    }

    [Fact]
    public void Search_Should_FindByExactName()
    {
        Assert.Equal("DE", Country.Search("Germany")[0].Alpha2Code);
    }

    [Fact]
    public void Search_Should_FindByAlias()
    {
        Assert.Equal("GB", Country.Search("Britain")[0].Alpha2Code);
        Assert.Equal("US", Country.Search("united states")[0].Alpha2Code);
    }

    [Fact]
    public void Search_Should_FindByPrefix()
    {
        Assert.Contains(Country.Search("Paki"), c => c.Alpha2Code == "PK");
    }

    [Fact]
    public void Search_Should_FindByCapitalCity()
    {
        Assert.Contains(Country.Search("Tokyo"), c => c.Alpha2Code == "JP");
    }

    [Fact]
    public void Search_Should_TolerateAMinorMisspelling()
    {
        Assert.Contains(Country.Search("germny"), c => c.Alpha2Code == "DE");
    }

    [Fact]
    public void Search_Should_BeCaseInsensitive()
    {
        Assert.Equal(
            Country.Search("GERMANY")[0].Alpha2Code,
            Country.Search("germany")[0].Alpha2Code);
    }

    [Fact]
    public void Search_Should_RespectMaxResults()
    {
        Assert.True(Country.Search("a", maxResults: 3).Count <= 3);
    }

    [Fact]
    public void Search_Should_ReturnEmptyForBlankInput()
    {
        Assert.Empty(Country.Search(""));
        Assert.Empty(Country.Search("   "));
    }

    [Fact]
    public void Search_Should_ReturnEmptyForNonsense()
    {
        Assert.Empty(Country.Search("zzzzqqqqxxxx"));
    }

    [Fact]
    public void Search_Should_ThrowForNonPositiveMaxResults()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Country.Search("US", 0));
    }

    // ── Catalog scope ───────────────────────────────────────────────

    [Fact]
    public void Queries_Should_NeverReturnTheNoneSentinelOrLegacyRecords()
    {
        var results = Country.InRegion("Europe")
            .Concat(Country.UsingCurrency("EUR"))
            .Concat(Country.Search("a", maxResults: 50))
            .Concat(Country.NearestTo(0, 0, 20));

        foreach (var country in results)
        {
            Assert.NotEqual(string.Empty, country.Alpha2Code);
            Assert.True(country.IsCurrent, $"{country.Alpha2Code} is not a current ISO 3166-1 record.");
        }
    }

    // ── Geography ───────────────────────────────────────────────────

    [Fact]
    public void GetBorderingCountries_Should_ResolveCodesIntoCountries()
    {
        var us = Country.GetCountry("US");

        var neighbours = us.GetBorderingCountries();

        Assert.Contains(neighbours, c => c.Alpha2Code == "CA");
        Assert.Contains(neighbours, c => c.Alpha2Code == "MX");
        Assert.Equal(us.BorderingCountries.Count, neighbours.Count);
    }

    [Fact]
    public void GetBorderingCountries_Should_BeEmptyForAnIslandNation()
    {
        var japan = Country.GetCountry("JP");

        Assert.Empty(japan.GetBorderingCountries());
    }

    [Fact]
    public void GetBorderingCountries_Should_ResolveEveryCodeInTheCatalog()
    {
        foreach (var country in Country.GetCurrent())
        {
            Assert.Equal(
                country.BorderingCountries.Count,
                country.GetBorderingCountries().Count);
        }
    }

    [Fact]
    public void NearestTo_Should_FindTheCountryWhoseCapitalIsClosest()
    {
        // The coordinates of Paris.
        var nearest = Country.NearestTo(48.8566, 2.3522);

        Assert.Single(nearest);
        Assert.Equal("FR", nearest[0].Alpha2Code);
    }

    [Fact]
    public void NearestTo_Should_ReturnResultsNearestFirst()
    {
        var nearest = Country.NearestTo(35.6762, 139.6503, count: 3);

        Assert.Equal(3, nearest.Count);
        Assert.Equal("JP", nearest[0].Alpha2Code);
    }

    [Theory]
    [InlineData(91, 0)]
    [InlineData(-91, 0)]
    [InlineData(0, 181)]
    [InlineData(0, -181)]
    public void NearestTo_Should_ThrowForOutOfRangeCoordinates(double latitude, double longitude)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Country.NearestTo(latitude, longitude));
    }

    [Fact]
    public void NearestTo_Should_ThrowForNonPositiveCount()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Country.NearestTo(0, 0, 0));
    }

    [Fact]
    public void DistanceTo_Should_MeasureBetweenCapitals()
    {
        var france = Country.GetCountry("FR");
        var germany = Country.GetCountry("DE");

        var distance = france.DistanceTo(germany);

        // Paris to Berlin is roughly 878 km.
        Assert.NotNull(distance);
        Assert.InRange(distance!.Value, 850, 900);
    }

    [Fact]
    public void DistanceTo_Should_BeZeroForTheSameCountry()
    {
        var france = Country.GetCountry("FR");

        Assert.Equal(0, france.DistanceTo(france)!.Value, 6);
    }

    [Fact]
    public void DistanceTo_Should_BeSymmetric()
    {
        var france = Country.GetCountry("FR");
        var japan = Country.GetCountry("JP");

        Assert.Equal(france.DistanceTo(japan)!.Value, japan.DistanceTo(france)!.Value, 6);
    }

    [Fact]
    public void DistanceTo_Should_ReturnNullWhenCoordinatesAreMissing()
    {
        var france = Country.GetCountry("FR");

        Assert.Null(france.DistanceTo(CountryHelper.None));
    }

    [Fact]
    public void DistanceTo_Should_ThrowForNull()
    {
        var france = Country.GetCountry("FR");

        Assert.Throws<ArgumentNullException>(() => france.DistanceTo(null!));
    }
}
