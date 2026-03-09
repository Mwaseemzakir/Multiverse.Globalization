namespace Multiverse.Globalization.Countries;

/// <summary>
/// Represents phone number formatting rules for a country.
/// </summary>
public sealed class PhoneFormat
{
    internal PhoneFormat(int minLength, int maxLength, string trunkPrefix, string internationalPrefix)
    {
        MinLength = minLength;
        MaxLength = maxLength;
        TrunkPrefix = trunkPrefix ?? string.Empty;
        InternationalPrefix = internationalPrefix ?? string.Empty;
    }

    /// <summary>Minimum number of digits in a local phone number (excluding country code).</summary>
    public int MinLength { get; }

    /// <summary>Maximum number of digits in a local phone number (excluding country code).</summary>
    public int MaxLength { get; }

    /// <summary>Trunk prefix used for domestic calls, e.g. "0" or "1".</summary>
    public string TrunkPrefix { get; }

    /// <summary>International dialing prefix, e.g. "00" or "011".</summary>
    public string InternationalPrefix { get; }

    /// <inheritdoc/>
    public override string ToString() => $"Digits: {MinLength}-{MaxLength}, Trunk: {TrunkPrefix}";
}
