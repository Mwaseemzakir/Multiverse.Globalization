using System;

namespace Multiverse.Globalization.TimeZones;

/// <summary>
/// Represents an IANA time zone associated with a country.
/// Contains the IANA identifier, UTC offset, and DST support information.
/// </summary>
public sealed class CountryTimeZone
{
    internal CountryTimeZone(string ianaId, double utcOffsetHours, bool observesDst)
    {
        if (string.IsNullOrWhiteSpace(ianaId))
            throw new ArgumentNullException(nameof(ianaId));

        IanaId = ianaId;
        UtcOffsetHours = utcOffsetHours;
        ObservesDst = observesDst;
    }

    /// <summary>IANA time zone identifier, e.g. "America/New_York", "Asia/Karachi".</summary>
    public string IanaId { get; }

    /// <summary>Standard UTC offset in hours, e.g. -5.0 for EST, +5.0 for PKT, +5.75 for NPT.</summary>
    public double UtcOffsetHours { get; }

    /// <summary>Whether this time zone observes Daylight Saving Time.</summary>
    public bool ObservesDst { get; }

    /// <summary>
    /// Returns the standard UTC offset as a <see cref="TimeSpan"/>.
    /// </summary>
    public TimeSpan UtcOffset => TimeSpan.FromHours(UtcOffsetHours);

    /// <summary>
    /// Returns the UTC offset formatted as a string, e.g. "UTC+05:00", "UTC-05:00", "UTC+05:45".
    /// </summary>
    public string UtcOffsetString
    {
        get
        {
            var offset = UtcOffset;
            var sign = offset < TimeSpan.Zero ? "-" : "+";
            var abs = offset < TimeSpan.Zero ? offset.Negate() : offset;
            return $"UTC{sign}{abs.Hours:D2}:{abs.Minutes:D2}";
        }
    }

    public override string ToString() => $"{IanaId} ({UtcOffsetString}{(ObservesDst ? ", DST" : "")})";
}
