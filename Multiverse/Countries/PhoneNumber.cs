namespace Multiverse.Globalization.Countries;

/// <summary>
/// A phone number that has been parsed against a country's <see cref="PhoneFormat"/>,
/// holding the subscriber digits separately from the country calling code so the number
/// can be re-rendered in national or international form.
/// </summary>
/// <remarks>
/// Parsing validates the digit count against the country's known number lengths. It does not
/// verify that the number is assigned, reachable, or of a particular line type — for carrier-level
/// validation you still want a lookup service.
/// </remarks>
public sealed class PhoneNumber
{
    internal PhoneNumber(Country country, string nationalNumber)
    {
        Country = country ?? throw new ArgumentNullException(nameof(country));
        NationalNumber = nationalNumber ?? throw new ArgumentNullException(nameof(nationalNumber));
    }

    /// <summary>The country this number was parsed against.</summary>
    public Country Country { get; }

    /// <summary>
    /// The national (subscriber) number, digits only — no country calling code and no trunk prefix.
    /// </summary>
    public string NationalNumber { get; }

    /// <summary>Country calling code including the leading plus, e.g. "+92".</summary>
    public string CallingCode => Country.CallingCode;

    /// <summary>
    /// Renders the number in E.164 form, e.g. "+923001234567" — the form to store in a database
    /// and to hand to SMS and telephony providers.
    /// </summary>
    public string ToE164() => CallingCode + NationalNumber;

    /// <summary>
    /// Renders the number as dialled domestically, prepending the country's trunk prefix
    /// where it has one, e.g. "03001234567" for Pakistan or "3125551234" for the US.
    /// </summary>
    public string ToNational()
    {
        var trunkPrefix = Country.PhoneFormat?.TrunkPrefix ?? string.Empty;
        return trunkPrefix + NationalNumber;
    }

    /// <summary>
    /// Renders the number in readable international form with the calling code separated,
    /// e.g. "+92 3001234567".
    /// </summary>
    public string ToInternational() => CallingCode + " " + NationalNumber;

    /// <inheritdoc/>
    public override string ToString() => ToE164();

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        obj is PhoneNumber other &&
        NationalNumber == other.NationalNumber &&
        CallingCode == other.CallingCode;

    /// <inheritdoc/>
    public override int GetHashCode() => ToE164().GetHashCode();
}
