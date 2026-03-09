using System;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Represents locale and formatting conventions for a country,
/// including date format, number format, measurement system, and more.
/// </summary>
public sealed class CountryLocale
{
    internal CountryLocale(
        string dateFormat,
        string numberDecimalSeparator,
        string numberGroupSeparator,
        MeasurementSystem measurementSystem,
        DayOfWeek weekStartDay,
        string postalCodeFormat,
        string addressFormat)
    {
        DateFormat = dateFormat ?? string.Empty;
        NumberDecimalSeparator = numberDecimalSeparator ?? ".";
        NumberGroupSeparator = numberGroupSeparator ?? ",";
        MeasurementSystem = measurementSystem;
        WeekStartDay = weekStartDay;
        PostalCodeFormat = postalCodeFormat ?? string.Empty;
        AddressFormat = addressFormat ?? string.Empty;
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

    /// <inheritdoc/>
    public override string ToString() => $"Date: {DateFormat}, Decimal: '{NumberDecimalSeparator}', System: {MeasurementSystem}";
}
