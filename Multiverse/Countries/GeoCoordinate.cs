using System;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Represents a geographic coordinate with latitude and longitude.
/// </summary>
public sealed class GeoCoordinate
{
    internal GeoCoordinate(double latitude, double longitude)
    {
        if (latitude < -90 || latitude > 90)
            throw new ArgumentOutOfRangeException(nameof(latitude), "Latitude must be between -90 and 90.");
        if (longitude < -180 || longitude > 180)
            throw new ArgumentOutOfRangeException(nameof(longitude), "Longitude must be between -180 and 180.");

        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>Latitude in decimal degrees (-90 to 90). Positive = North, Negative = South.</summary>
    public double Latitude { get; }

    /// <summary>Longitude in decimal degrees (-180 to 180). Positive = East, Negative = West.</summary>
    public double Longitude { get; }

    /// <inheritdoc/>
    public override string ToString() => $"{Latitude:F4}, {Longitude:F4}";

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        obj is GeoCoordinate other &&
        Math.Abs(Latitude - other.Latitude) < 0.0001 &&
        Math.Abs(Longitude - other.Longitude) < 0.0001;

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 31 + Latitude.GetHashCode();
            hash = hash * 31 + Longitude.GetHashCode();
            return hash;
        }
    }
}
