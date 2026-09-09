namespace Multiverse.Globalization.UnitTests.Countries;

public class PhoneNumberTests
{
    // ── Parsing ─────────────────────────────────────────────────────

    [Theory]
    [InlineData("+13125551234")]
    [InlineData("13125551234")]
    [InlineData("3125551234")]
    [InlineData("(312) 555-1234")]
    [InlineData("312.555.1234")]
    [InlineData("312 555 1234")]
    [InlineData("  +1 312 555 1234  ")]
    public void TryParsePhoneNumber_Should_AcceptEveryCommonUsForm(string input)
    {
        var us = Country.GetCountry("US");

        Assert.True(us.TryParsePhoneNumber(input, out var number));
        Assert.Equal("3125551234", number!.NationalNumber);
        Assert.Equal("+13125551234", number.ToE164());
    }

    [Theory]
    [InlineData("+923001234567")]
    [InlineData("00923001234567")]
    [InlineData("03001234567")]
    [InlineData("3001234567")]
    [InlineData("0300-1234567")]
    public void TryParsePhoneNumber_Should_AcceptEveryCommonPakistaniForm(string input)
    {
        var pk = Country.GetCountry("PK");

        Assert.True(pk.TryParsePhoneNumber(input, out var number));
        Assert.Equal("3001234567", number!.NationalNumber);
        Assert.Equal("+923001234567", number.ToE164());
    }

    [Theory]
    [InlineData("12345")]
    [InlineData("312555123456789")]
    [InlineData("abc")]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public void TryParsePhoneNumber_Should_RejectImplausibleInput(string? input)
    {
        var us = Country.GetCountry("US");

        Assert.False(us.TryParsePhoneNumber(input, out var number));
        Assert.Null(number);
    }

    [Fact]
    public void TryParsePhoneNumber_Should_ReturnFalseWhenCountryHasNoPhoneData()
    {
        var none = CountryHelper.None;

        Assert.False(none.TryParsePhoneNumber("3125551234", out var number));
        Assert.Null(number);
    }

    [Fact]
    public void TryParsePhoneNumber_Should_RejectAnotherCountrysCallingCode()
    {
        var us = Country.GetCountry("US");

        // +92 300 1234567 is a Pakistani number; as a US number the digits do not fit.
        Assert.False(us.TryParsePhoneNumber("+923001234567", out _));
    }

    // ── Rendering ───────────────────────────────────────────────────

    [Fact]
    public void ToNational_Should_PrependTheTrunkPrefix()
    {
        var pk = Country.GetCountry("PK");
        var number = pk.ParsePhoneNumber("+923001234567");

        Assert.Equal("03001234567", number.ToNational());
    }

    [Fact]
    public void ToInternational_Should_SeparateTheCallingCode()
    {
        var pk = Country.GetCountry("PK");
        var number = pk.ParsePhoneNumber("03001234567");

        Assert.Equal("+92 3001234567", number.ToInternational());
    }

    [Fact]
    public void PhoneNumber_Should_ExposeItsCountryAndCallingCode()
    {
        var pk = Country.GetCountry("PK");
        var number = pk.ParsePhoneNumber("03001234567");

        Assert.Equal("PK", number.Country.Alpha2Code);
        Assert.Equal("+92", number.CallingCode);
        Assert.Equal("+923001234567", number.ToString());
    }

    [Fact]
    public void PhoneNumber_Should_CompareByValue()
    {
        var pk = Country.GetCountry("PK");

        var fromNational = pk.ParsePhoneNumber("03001234567");
        var fromE164 = pk.ParsePhoneNumber("+923001234567");

        Assert.Equal(fromNational, fromE164);
        Assert.Equal(fromNational.GetHashCode(), fromE164.GetHashCode());
    }

    // ── Parse and validate ──────────────────────────────────────────

    [Fact]
    public void ParsePhoneNumber_Should_ThrowForBlankInput()
    {
        var us = Country.GetCountry("US");

        Assert.Throws<ArgumentNullException>(() => us.ParsePhoneNumber("   "));
    }

    [Fact]
    public void ParsePhoneNumber_Should_ThrowFormatExceptionForInvalidInput()
    {
        var us = Country.GetCountry("US");

        Assert.Throws<FormatException>(() => us.ParsePhoneNumber("12345"));
    }

    [Fact]
    public void ParsePhoneNumber_Should_ThrowFormatExceptionWhenCountryHasNoPhoneData()
    {
        var none = CountryHelper.None;

        Assert.Throws<FormatException>(() => none.ParsePhoneNumber("3125551234"));
    }

    [Fact]
    public void IsValidPhoneNumber_Should_MirrorTryParse()
    {
        var us = Country.GetCountry("US");

        Assert.True(us.IsValidPhoneNumber("+13125551234"));
        Assert.False(us.IsValidPhoneNumber("12345"));
        Assert.False(us.IsValidPhoneNumber(null));
    }

    // ── Round trip across the catalog ───────────────────────────────

    [Fact]
    public void E164_Should_RoundTripForEveryCountryWithPhoneData()
    {
        foreach (var country in Country.GetCurrent())
        {
            if (country.PhoneFormat is null)
                continue;

            // A number of the shortest permitted length must survive an E.164 round trip.
            var national = new string('5', country.PhoneFormat.MinLength);

            Assert.True(
                country.TryParsePhoneNumber(country.CallingCode + national, out var parsed),
                $"{country.Name} ({country.Alpha2Code}) rejected its own minimum-length number.");

            Assert.Equal(national, parsed!.NationalNumber);

            Assert.True(
                country.TryParsePhoneNumber(parsed.ToE164(), out var reparsed),
                $"{country.Name} ({country.Alpha2Code}) failed to re-parse its own E.164 output.");

            Assert.Equal(parsed.ToE164(), reparsed!.ToE164());
        }
    }
}
