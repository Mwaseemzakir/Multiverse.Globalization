using System.Text;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Phone number parsing and validation built on the country's <see cref="PhoneFormat"/> data.
/// </summary>
public sealed partial class Country
{
    /// <summary>
    /// Attempts to parse a phone number written in any common form — E.164 ("+923001234567"),
    /// international with a dialling prefix ("00923001234567"), national with a trunk prefix
    /// ("03001234567"), or bare subscriber digits ("3001234567") — against this country's format.
    /// Spaces, hyphens, dots, and parentheses are ignored.
    /// </summary>
    /// <param name="input">The phone number as entered by a user.</param>
    /// <param name="result">The parsed number, or null when parsing fails.</param>
    /// <returns><c>true</c> when the input is a plausible number for this country.</returns>
    public bool TryParsePhoneNumber(string? input, out PhoneNumber? result)
    {
        result = null;

        if (PhoneFormat is null || string.IsNullOrWhiteSpace(input))
            return false;

        var trimmed = input.Trim();
        var hasPlus = trimmed.Length > 0 && trimmed[0] == '+';
        var digits = KeepDigits(trimmed);

        if (digits.Length == 0)
            return false;

        var callingDigits = CallingCode.TrimStart('+');

        foreach (var candidate in EnumerateNationalCandidates(digits, callingDigits, hasPlus))
            if (candidate.Length >= PhoneFormat.MinLength && candidate.Length <= PhoneFormat.MaxLength)
            {
                result = new PhoneNumber(this, candidate);
                return true;
            }

        return false;
    }

    /// <summary>
    /// Parses a phone number against this country's format.
    /// </summary>
    /// <param name="input">The phone number as entered by a user.</param>
    /// <returns>The parsed number.</returns>
    /// <exception cref="ArgumentNullException">The input is null or blank.</exception>
    /// <exception cref="FormatException">
    /// The input is not a plausible number for this country, or the country has no phone format data.
    /// </exception>
    public PhoneNumber ParsePhoneNumber(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(nameof(input));

        if (PhoneFormat is null)
            throw new FormatException($"No phone format data is available for {Name} ({Alpha2Code}).");

        if (!TryParsePhoneNumber(input, out var result))
            throw new FormatException($"'{input}' is not a valid phone number for {Name} ({Alpha2Code}).");

        return result!;
    }

    /// <summary>
    /// Checks whether the input is a plausible phone number for this country.
    /// Returns <c>false</c> when the country has no phone format data.
    /// </summary>
    public bool IsValidPhoneNumber(string? input)
    {
        return TryParsePhoneNumber(input, out _);
    }

    /// <summary>
    /// Yields the possible subscriber numbers hidden in the entered digits, most-specific first,
    /// so an unambiguous reading (an explicit "+", then the calling code, then the trunk prefix)
    /// always wins over treating the digits as a bare subscriber number.
    /// </summary>
    private IEnumerable<string> EnumerateNationalCandidates(string digits, string callingDigits, bool hasPlus)
    {
        var internationalPrefix = PhoneFormat!.InternationalPrefix;
        var trunkPrefix = PhoneFormat.TrunkPrefix;

        // "+92 300..." — the plus makes the calling code unambiguous.
        if (hasPlus && StartsWith(digits, callingDigits))
            yield return digits.Substring(callingDigits.Length);

        // "0092 300..." — an explicit international dialling prefix followed by the calling code.
        if (internationalPrefix.Length > 0 &&
            StartsWith(digits, internationalPrefix) &&
            StartsWith(digits.Substring(internationalPrefix.Length), callingDigits))
            yield return digits.Substring(internationalPrefix.Length + callingDigits.Length);

        // "92300..." — international form with the plus dropped, common in pasted data.
        if (!hasPlus && StartsWith(digits, callingDigits))
            yield return digits.Substring(callingDigits.Length);

        // "0300..." — national form. Only meaningful when the plus was absent.
        if (!hasPlus && trunkPrefix.Length > 0 && StartsWith(digits, trunkPrefix))
            yield return digits.Substring(trunkPrefix.Length);

        // "300..." — bare subscriber digits.
        if (!hasPlus)
            yield return digits;
    }

    private static bool StartsWith(string value, string prefix)
    {
        return prefix.Length > 0 && value.StartsWith(prefix, StringComparison.Ordinal);
    }

    private static string KeepDigits(string value)
    {
        var builder = new StringBuilder(value.Length);

        foreach (var c in value)
            if (c >= '0' && c <= '9')
                builder.Append(c);

        return builder.ToString();
    }
}
