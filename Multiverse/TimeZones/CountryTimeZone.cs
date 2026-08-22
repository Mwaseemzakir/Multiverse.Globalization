namespace Multiverse.Globalization.TimeZones;

/// <summary>
/// Represents an IANA time zone associated with a country.
/// Contains the IANA identifier plus a standard-offset snapshot. For date-aware offsets and DST,
/// use <see cref="GetUtcOffset(DateTimeOffset)"/> and <see cref="IsDaylightSavingTime(DateTimeOffset)"/>,
/// which resolve the rules installed on the operating system.
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

    /// <summary>
    /// Standard UTC-offset snapshot in hours, e.g. -5.0 for EST, +5.0 for PKT, +5.75 for NPT.
    /// This value does not apply daylight-saving or historical rules.
    /// </summary>
    public double UtcOffsetHours { get; }

    /// <summary>
    /// Whether the bundled snapshot identifies this zone as observing daylight saving time.
    /// Use <see cref="IsDaylightSavingTime(DateTimeOffset)"/> for a particular instant.
    /// </summary>
    public bool ObservesDst { get; }

    /// <summary>
    /// Returns the standard UTC offset as a <see cref="TimeSpan"/>.
    /// </summary>
    public TimeSpan UtcOffset => TimeSpan.FromHours(UtcOffsetHours);

    /// <summary>
    /// Attempts to resolve this IANA identifier to the operating system's current
    /// <see cref="TimeZoneInfo"/> rules. On Windows, modern .NET targets also try the
    /// corresponding Windows time-zone identifier.
    /// </summary>
    public bool TryGetSystemTimeZone(out TimeZoneInfo? timeZone)
    {
        if (TryFindSystemTimeZone(IanaId, out timeZone))
            return true;

#if NET6_0_OR_GREATER
        if (TimeZoneInfo.TryConvertIanaIdToWindowsId(IanaId, out var windowsId)
            && TryFindSystemTimeZone(windowsId, out timeZone))
        {
            return true;
        }
#endif

        timeZone = null;
        return false;
    }

    /// <summary>
    /// Returns the UTC offset at a particular instant using the operating system's time-zone rules.
    /// </summary>
    /// <exception cref="TimeZoneNotFoundException">
    /// The IANA identifier cannot be resolved on the current operating system.
    /// </exception>
    public TimeSpan GetUtcOffset(DateTimeOffset instant)
    {
        if (!TryGetSystemTimeZone(out var timeZone))
            throw new TimeZoneNotFoundException($"Time zone '{IanaId}' is not available on this system.");

        return timeZone!.GetUtcOffset(instant.UtcDateTime);
    }

    /// <summary>
    /// Determines whether daylight saving time applies at a particular instant using the
    /// operating system's time-zone rules.
    /// </summary>
    /// <exception cref="TimeZoneNotFoundException">
    /// The IANA identifier cannot be resolved on the current operating system.
    /// </exception>
    public bool IsDaylightSavingTime(DateTimeOffset instant)
    {
        if (!TryGetSystemTimeZone(out var timeZone))
            throw new TimeZoneNotFoundException($"Time zone '{IanaId}' is not available on this system.");

        return timeZone!.IsDaylightSavingTime(instant.UtcDateTime);
    }

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

    private static bool TryFindSystemTimeZone(string id, out TimeZoneInfo? timeZone)
    {
        try
        {
            timeZone = TimeZoneInfo.FindSystemTimeZoneById(id);
            return true;
        }
        catch (TimeZoneNotFoundException)
        {
            timeZone = null;
            return false;
        }
        catch (InvalidTimeZoneException)
        {
            timeZone = null;
            return false;
        }
    }

    /// <inheritdoc/>
    public override string ToString() => $"{IanaId} ({UtcOffsetString}{(ObservesDst ? ", DST" : "")})";
}
