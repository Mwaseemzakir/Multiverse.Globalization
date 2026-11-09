namespace Multiverse.Globalization.UnitTests.Countries;

public class LocaleFormattingTests
{
    // ── Numbers ─────────────────────────────────────────────────────

    [Fact]
    public void FormatNumber_Should_UseUsSeparators()
    {
        var us = Country.GetCountry("US");

        Assert.Equal("1,234.50", us.Locale!.FormatNumber(1234.5m));
    }

    [Fact]
    public void FormatNumber_Should_UseGermanSeparators()
    {
        var de = Country.GetCountry("DE");

        Assert.Equal("1.234,50", de.Locale!.FormatNumber(1234.5m));
    }

    [Fact]
    public void FormatNumber_Should_GroupLargeValues()
    {
        var us = Country.GetCountry("US");

        Assert.Equal("1,234,567.89", us.Locale!.FormatNumber(1234567.89m));
    }

    [Fact]
    public void FormatNumber_Should_RoundAwayFromZero()
    {
        var us = Country.GetCountry("US");

        Assert.Equal("1,235", us.Locale!.FormatNumber(1234.5m, decimalPlaces: 0));
        Assert.Equal("2.35", us.Locale.FormatNumber(2.345m));
    }

    [Fact]
    public void FormatNumber_Should_HandleNegativeValues()
    {
        var de = Country.GetCountry("DE");

        Assert.Equal("-1.234,50", de.Locale!.FormatNumber(-1234.5m));
    }

    [Fact]
    public void FormatNumber_Should_HandleZero()
    {
        var us = Country.GetCountry("US");

        Assert.Equal("0.00", us.Locale!.FormatNumber(0m));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(29)]
    public void FormatNumber_Should_ThrowForOutOfRangeDecimalPlaces(int decimalPlaces)
    {
        var us = Country.GetCountry("US");

        Assert.Throws<ArgumentOutOfRangeException>(() => us.Locale!.FormatNumber(1m, decimalPlaces));
    }

    [Fact]
    public void FormatNumber_Should_NotBeAffectedByAmbientCulture()
    {
        var original = System.Globalization.CultureInfo.CurrentCulture;

        try
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("de-DE");

            var us = Country.GetCountry("US");

            Assert.Equal("1,234.50", us.Locale!.FormatNumber(1234.5m));
        }
        finally
        {
            System.Globalization.CultureInfo.CurrentCulture = original;
        }
    }

    // ── Addresses ───────────────────────────────────────────────────

    [Fact]
    public void FormatAddress_Should_RenderCompleteUsAddress()
    {
        var us = Country.GetCountry("US");

        var address = us.Locale!.FormatAddress(
            street: "1600 Pennsylvania Avenue NW",
            city: "Washington",
            state: "DC",
            postalCode: "20500",
            country: "United States");

        Assert.Equal(
            "1600 Pennsylvania Avenue NW\nWashington, DC 20500\nUnited States",
            address);
    }

    [Fact]
    public void FormatAddress_Should_RenderGermanAddressWithPostalCodeBeforeCity()
    {
        var de = Country.GetCountry("DE");

        var address = de.Locale!.FormatAddress(
            street: "Unter den Linden 77",
            city: "Berlin",
            postalCode: "10117",
            country: "Germany");

        Assert.Equal("Unter den Linden 77\n10117 Berlin\nGermany", address);
    }

    [Fact]
    public void FormatAddress_Should_DropOmittedComponentsAndTheirSeparators()
    {
        var us = Country.GetCountry("US");

        var address = us.Locale!.FormatAddress(
            street: "500 Main St",
            city: "Austin",
            postalCode: "78701");

        // No state and no country: the comma before the state and the country line both go.
        Assert.Equal("500 Main St\nAustin, 78701", address);
    }

    [Fact]
    public void FormatAddress_Should_DropLeadingSeparatorWhenCityIsOmitted()
    {
        var us = Country.GetCountry("US");

        var address = us.Locale!.FormatAddress(street: "500 Main St", postalCode: "78701");

        Assert.Equal("500 Main St\n78701", address);
    }

    [Fact]
    public void FormatAddress_Should_ReturnEmptyWhenNothingIsSupplied()
    {
        var us = Country.GetCountry("US");

        Assert.Equal(string.Empty, us.Locale!.FormatAddress());
    }

    [Fact]
    public void FormatAddress_Should_NeverLeaveBlankLinesOrDanglingSeparators()
    {
        foreach (var country in Country.GetAll())
        {
            if (country.Locale is null)
                continue;

            var address = country.Locale.FormatAddress(city: "Springfield");

            Assert.DoesNotContain("\n\n", address);
            Assert.False(address.StartsWith("\n", StringComparison.Ordinal));
            Assert.False(address.EndsWith("\n", StringComparison.Ordinal));

            foreach (var line in address.Split('\n'))
            {
                Assert.Equal(line.Trim(), line);
                Assert.False(line.StartsWith(",", StringComparison.Ordinal), $"{country.Alpha2Code}: '{line}'");
                Assert.False(line.EndsWith(",", StringComparison.Ordinal), $"{country.Alpha2Code}: '{line}'");
            }
        }
    }
}
