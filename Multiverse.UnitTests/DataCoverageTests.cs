namespace Multiverse.Globalization.UnitTests;

public class DataCoverageTests
{
    [Fact]
    public void ExplicitDatasetCoverage_ShouldMatchDocumentedCounts()
    {
        Assert.Equal(213, HolidayHelper.All.Count);
        Assert.Equal(48, MovableHolidayHelper.All.Count);
        Assert.Equal(251, TimeZoneHelper.All.Count);
        Assert.Equal(247, ElectricalSystemHelper.All.Count);
        Assert.Equal(250, EmergencyNumberHelper.All.Count);
        Assert.Equal(233, PhoneFormatHelper.All.Count);
        Assert.Equal(251, CountryLocaleHelper.All.Count);
        Assert.Equal(251, CountryTranslationHelper.All.Count);
        Assert.Equal(59, SubdivisionHelper.All.Count);
    }

    [Fact]
    public void SupplementalXk_ShouldBeExplicitAndNotClaimedAsIsoCountryRecord()
    {
        Assert.False(Country.IsValid("XK"));
        Assert.Contains("XK", TimeZoneHelper.All.Keys);
        Assert.Contains("XK", CountryLocaleHelper.All.Keys);
        Assert.Contains("XK", CountryTranslationHelper.All.Keys);
    }

    [Fact]
    public void DatasetCodes_OtherThanSupplementalXk_ShouldBelongToCompatibilityCatalog()
    {
        var catalogCodes = Country.GetAll()
            .Where(country => !string.IsNullOrEmpty(country.Alpha2Code))
            .Select(country => country.Alpha2Code)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        var datasetCodes = HolidayHelper.All.Keys
            .Concat(MovableHolidayHelper.All.Keys)
            .Concat(TimeZoneHelper.All.Keys)
            .Concat(ElectricalSystemHelper.All.Keys)
            .Concat(EmergencyNumberHelper.All.Keys)
            .Concat(PhoneFormatHelper.All.Keys)
            .Concat(CountryLocaleHelper.All.Keys)
            .Concat(CountryTranslationHelper.All.Keys)
            .Concat(SubdivisionHelper.All.Keys)
            .Where(code => !string.Equals(code, "XK", StringComparison.OrdinalIgnoreCase))
            .Distinct(StringComparer.OrdinalIgnoreCase);

        Assert.All(datasetCodes, code => Assert.Contains(code, catalogCodes));
    }
}
