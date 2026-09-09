using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Represents locale and formatting conventions for a country,
/// including date format, number format, measurement system, and more.
/// </summary>
public sealed class CountryLocale
{
    /// <summary>Guards against catastrophic backtracking in postal-code patterns.</summary>
    private static readonly TimeSpan RegexTimeout = TimeSpan.FromMilliseconds(250);

    private const string FallbackAddressFormat = "{street}\n{city} {state} {postalCode}\n{country}";

    internal CountryLocale(
        string dateFormat,
        string numberDecimalSeparator,
        string numberGroupSeparator,
        MeasurementSystem measurementSystem,
        DayOfWeek weekStartDay,
        string postalCodeFormat,
        string addressFormat)
    {
        DateFormat = dateFormat;
        NumberDecimalSeparator = numberDecimalSeparator;
        NumberGroupSeparator = numberGroupSeparator;
        MeasurementSystem = measurementSystem;
        WeekStartDay = weekStartDay;
        PostalCodeFormat = postalCodeFormat;
        AddressFormat = addressFormat;
    }

    /// <summary>Primary date format string, e.g. "MM/dd/yyyy", "dd/MM/yyyy", "yyyy-MM-dd".</summary>
    public string DateFormat { get; }

    /// <summary>Decimal separator used in numbers, e.g. "." or ",".</summary>
    public string NumberDecimalSeparator { get; }

    /// <summary>Thousands/group separator used in numbers, e.g. "," or ".".</summary>
    public string NumberGroupSeparator { get; }

    /// <summary>Measurement system used in the country.</summary>
    public MeasurementSystem MeasurementSystem { get; }

    /// <summary>Day the week starts on in this country.</summary>
    public DayOfWeek WeekStartDay { get; }

    /// <summary>
    /// Regex pattern for validating postal/ZIP codes, e.g. @"^\d{5}(-\d{4})?$" for US.
    /// Empty string if the country does not use postal codes.
    /// </summary>
    public string PostalCodeFormat { get; }

    /// <summary>
    /// Address format template. Placeholders: {street}, {city}, {state}, {postalCode}, {country}.
    /// </summary>
    public string AddressFormat { get; }

    // ── Postal Codes ────────────────────────────────────────────────

    /// <summary>
    /// Whether this country operates a postal code system, i.e. whether
    /// <see cref="PostalCodeFormat"/> carries a pattern to validate against.
    /// </summary>
    public bool HasPostalCodes => PostalCodeFormat.Length > 0;

    /// <summary>
    /// Validates a postal/ZIP code against <see cref="PostalCodeFormat"/>.
    /// <para>
    /// For countries with no postal code system (<see cref="HasPostalCodes"/> is <c>false</c>)
    /// only a null/blank value is considered valid, since any entered code would be meaningless.
    /// Branch on <see cref="HasPostalCodes"/> if your form needs different handling.
    /// </para>
    /// </summary>
    /// <param name="postalCode">The postal code to validate. Surrounding whitespace is ignored.</param>
    /// <returns><c>true</c> when the code matches the country's pattern.</returns>
    public bool IsValidPostalCode(string? postalCode)
    {
        var trimmed = postalCode?.Trim() ?? string.Empty;

        if (!HasPostalCodes)
            return trimmed.Length == 0;

        if (trimmed.Length == 0)
            return false;

        try
        {
            return PostalCodeRegex.IsMatch(trimmed);
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

    private Regex PostalCodeRegex =>
        field ??= new Regex(
            PostalCodeFormat,
            RegexOptions.CultureInvariant,
            RegexTimeout);

    // ── Numbers ─────────────────────────────────────────────────────

    /// <summary>
    /// Formats a number using this country's decimal and group separators,
    /// e.g. <c>1234.5</c> renders as "1,234.50" for the US and "1.234,50" for Germany.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="decimalPlaces">Number of decimal places to render (0–28).</param>
    public string FormatNumber(decimal value, int decimalPlaces = 2)
    {
        if (decimalPlaces < 0 || decimalPlaces > 28)
            throw new ArgumentOutOfRangeException(nameof(decimalPlaces), "Decimal places must be between 0 and 28.");

        var rounded = Math.Round(value, decimalPlaces, MidpointRounding.AwayFromZero);

        return rounded.ToString(
            "N" + decimalPlaces.ToString(CultureInfo.InvariantCulture),
            NumberFormat);
    }

    /// <summary>
    /// This country's separators projected onto a <see cref="NumberFormatInfo"/>, so number
    /// rendering goes through the BCL formatter rather than string surgery on an invariant result.
    /// </summary>
    private NumberFormatInfo NumberFormat =>
        field ??= new NumberFormatInfo
        {
            NumberDecimalSeparator = NumberDecimalSeparator,
            NumberGroupSeparator = NumberGroupSeparator,
            NumberGroupSizes = [3]
        };

    // ── Addresses ───────────────────────────────────────────────────

    /// <summary>
    /// Renders a postal address using this country's <see cref="AddressFormat"/> template.
    /// Omitted or blank components are dropped along with the separators and blank lines
    /// they would otherwise leave behind.
    /// </summary>
    /// <param name="street">Street line, e.g. "1600 Amphitheatre Parkway".</param>
    /// <param name="city">City or town.</param>
    /// <param name="state">State, province, or region.</param>
    /// <param name="postalCode">Postal/ZIP code.</param>
    /// <param name="country">Country name. Pass null to omit the country line for domestic mail.</param>
    /// <returns>The formatted address, lines separated by <c>\n</c>.</returns>
    public string FormatAddress(
        string? street = null,
        string? city = null,
        string? state = null,
        string? postalCode = null,
        string? country = null)
    {
        var template = AddressFormat.Length > 0 ? AddressFormat : FallbackAddressFormat;

        var rendered = template
            .Replace("{street}", street ?? string.Empty)
            .Replace("{city}", city ?? string.Empty)
            .Replace("{state}", state ?? string.Empty)
            .Replace("{postalCode}", postalCode ?? string.Empty)
            .Replace("{country}", country ?? string.Empty);

        var lines = rendered
            .Replace("\r\n", "\n")
            .Split('\n')
            .Select(CleanAddressLine)
            .Where(line => line.Length > 0);

        return string.Join("\n", lines);
    }

    /// <summary>
    /// Collapses the whitespace and dangling separators left behind by an omitted component,
    /// turning "Austin,  78701" into "Austin, 78701" and ", , 78701" into "78701".
    /// </summary>
    private static string CleanAddressLine(string line)
    {
        var builder = new StringBuilder(line.Length);
        var pendingSpace = false;

        foreach (var c in line)
        {
            if (char.IsWhiteSpace(c))
            {
                pendingSpace = builder.Length > 0;
                continue;
            }

            var isSeparator = c == ',' || c == '-';

            // Collapse a separator that now sits at the start of the line or next to another
            // separator, which is what an omitted component leaves behind.
            if (isSeparator && (builder.Length == 0 || builder[builder.Length - 1] == c))
            {
                pendingSpace = false;
                continue;
            }

            // A separator hugs the text before it; anything else takes the pending space.
            if (pendingSpace && !isSeparator)
                builder.Append(' ');

            builder.Append(c);
            pendingSpace = false;
        }

        return builder.ToString().Trim().Trim(',', '-').Trim();
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"Date: {DateFormat}, Decimal: '{NumberDecimalSeparator}', System: {MeasurementSystem}";
    }
}
