using System;
using System.Collections.Generic;

namespace Multiverse.Globalization.Electrical;

/// <summary>
/// Represents the electrical system specifications of a country,
/// including plug types, voltage, and frequency.
/// </summary>
public sealed class ElectricalSystem
{
    internal ElectricalSystem(int voltage, int frequency, params PlugType[] plugTypes)
    {
        if (voltage <= 0)
            throw new ArgumentOutOfRangeException(nameof(voltage), "Voltage must be positive.");
        if (frequency <= 0)
            throw new ArgumentOutOfRangeException(nameof(frequency), "Frequency must be positive.");

        Voltage = voltage;
        Frequency = frequency;
        PlugTypes = plugTypes ?? Array.Empty<PlugType>();
    }

    /// <summary>Standard mains voltage in volts (e.g. 120, 220, 230, 240).</summary>
    public int Voltage { get; }

    /// <summary>Standard mains frequency in hertz (typically 50 or 60).</summary>
    public int Frequency { get; }

    /// <summary>Electrical plug/socket types used in the country.</summary>
    public IReadOnlyList<PlugType> PlugTypes { get; }

    /// <inheritdoc/>
    public override string ToString() => $"{Voltage}V / {Frequency}Hz";
}
