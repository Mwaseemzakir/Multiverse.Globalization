using System;

namespace Multiverse.Globalization.Subdivisions;

/// <summary>
/// Represents a first-level administrative subdivision of a country (ISO 3166-2),
/// such as a state, province, region, or territory.
/// </summary>
public sealed class Subdivision
{
    internal Subdivision(string code, string name, string type)
    {
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentNullException(nameof(code));
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        Code = code;
        Name = name;
        Type = type ?? string.Empty;
    }

    /// <summary>ISO 3166-2 code, e.g. "US-CA", "PK-PB", "GB-ENG".</summary>
    public string Code { get; }

    /// <summary>Full name of the subdivision, e.g. "California", "Punjab", "England".</summary>
    public string Name { get; }

    /// <summary>Type of subdivision, e.g. "State", "Province", "Region", "Territory".</summary>
    public string Type { get; }

    /// <inheritdoc/>
    public override string ToString() => $"{Name} ({Code})";

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        obj is Subdivision other && Code == other.Code;

    /// <inheritdoc/>
    public override int GetHashCode() => Code.GetHashCode();
}
