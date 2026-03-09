using System;
using System.Collections.Generic;
using System.Linq;
using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Electrical;
using Multiverse.Globalization.Holidays;
using Multiverse.Globalization.Languages;
using Multiverse.Globalization.Subdivisions;
using Multiverse.Globalization.TimeZones;
using static Multiverse.Globalization.Countries.CountryHelper;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Represents a country with its ISO 3166 codes, geographic, political, and cultural data.
/// </summary>
public sealed class Country
{
    private IReadOnlyList<Holiday>? _holidays;
    private IReadOnlyList<MovableHoliday>? _movableHolidays;
    private IReadOnlyList<CountryTimeZone>? _timeZones;
    private IReadOnlyList<Subdivision>? _subdivisions;
    private ElectricalSystem? _electricalSystem;
    private IReadOnlyList<string>? _emergencyNumbers;
    private PhoneFormat? _phoneFormat;
    private CountryLocale? _locale;
    private IReadOnlyDictionary<string, string>? _translations;
    private string? _flag;

    internal Country(
        string name,
        string numericCode,
        string alpha2Code,
        string alpha3Code,
        string callingCode,
        string capital,
        string region,
        Currency? currency,
        params Language[] officialLanguages)
    {
        Name = name;
        NumericCode = numericCode;
        Alpha2Code = alpha2Code;
        Alpha3Code = alpha3Code;
        CallingCode = callingCode;
        Capital = capital;
        Region = region;
        Currency = currency;
        OfficialLanguages = officialLanguages ?? Array.Empty<Language>();
    }

    /// <summary>Country name.</summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>ISO 3166-1 alpha-3 code (3-letter).</summary>
    public string Alpha3Code { get; private set; } = string.Empty;

    /// <summary>ISO 3166-1 alpha-2 code (2-letter).</summary>
    public string Alpha2Code { get; private set; } = string.Empty;

    /// <summary>ISO 3166-1 numeric code (3-digit).</summary>
    public string NumericCode { get; private set; } = string.Empty;

    /// <summary>International dialing code (E.164), e.g. "+1", "+44".</summary>
    public string CallingCode { get; private set; } = string.Empty;

    /// <summary>Capital city name.</summary>
    public string Capital { get; private set; } = string.Empty;

    /// <summary>Geographic region/continent, e.g. "Asia", "Europe", "Americas", "Africa", "Oceania", "Antarctic".</summary>
    public string Region { get; private set; } = string.Empty;

    /// <summary>UN M49 sub-region, e.g. "Southern Asia", "Western Europe", "Caribbean".</summary>
    public string SubRegion { get; private set; } = string.Empty;

    /// <summary>Demonym — what residents of the country are called, e.g. "American", "Pakistani", "Japanese".</summary>
    public string Demonym { get; private set; } = string.Empty;

    /// <summary>Country-code top-level domain, e.g. ".us", ".pk", ".jp".</summary>
    public string TLD { get; private set; } = string.Empty;

    // ── New High-Value Country Properties ────────────────────────

    /// <summary>Approximate population count.</summary>
    public long Population { get; private set; }

    /// <summary>Total area in square kilometers.</summary>
    public double AreaInSquareKilometers { get; private set; }

    /// <summary>Geographic coordinates (latitude, longitude) of the capital city.</summary>
    public GeoCoordinate? CapitalCoordinates { get; private set; }

    /// <summary>ISO 3166-1 alpha-2 codes of bordering (neighboring) countries.</summary>
    public IReadOnlyList<string> BorderingCountries { get; private set; } = Array.Empty<string>();

    /// <summary>Which side of the road vehicles drive on.</summary>
    public DrivingSide DrivingSide { get; private set; } = DrivingSide.Right;

    /// <summary>Date of independence, or null if not applicable (e.g. for territories).</summary>
    public DateTime? IndependenceDate { get; private set; }

    /// <summary>Whether the country is a member of the United Nations.</summary>
    public bool IsUnMember { get; private set; }

    /// <summary>Whether the country is landlocked (has no coastline).</summary>
    public bool IsLandlocked { get; private set; }

    /// <summary>Speed unit used in the country, e.g. "km/h" or "mph".</summary>
    public string SpeedUnit { get; private set; } = "km/h";

    /// <summary>Alternative country-code top-level domains, e.g. ".uk" for GB alongside ".gb".</summary>
    public IReadOnlyList<string> AlternativeTlds { get; private set; } = Array.Empty<string>();

    /// <summary>Primary currency used in this country.</summary>
    public Currency? Currency { get; private set; }

    /// <summary>Primary ISO 4217 currency code derived from the Currency property, e.g. "USD", "EUR".</summary>
    public string CurrencyCode => Currency?.Code ?? string.Empty;

    /// <summary>Official languages of this country.</summary>
    public IReadOnlyList<Language> OfficialLanguages { get; private set; } = Array.Empty<Language>();

    /// <summary>
    /// Public holidays observed in this country (fixed-date holidays only).
    /// Movable holidays (e.g. Easter, Eid, Diwali, Thanksgiving) are not included.
    /// </summary>
    public IReadOnlyList<Holiday> Holidays => _holidays ??= HolidayHelper.GetHolidaysForCountry(Alpha2Code);

    /// <summary>
    /// Returns holidays filtered by the specified <see cref="HolidayType"/>.
    /// </summary>
    public IReadOnlyList<Holiday> GetHolidaysByType(HolidayType type)
        => Holidays.Where(h => h.Type == type).ToList().AsReadOnly();

    /// <summary>
    /// Checks whether the given date falls on any public holiday in this country (month and day match, ignoring year).
    /// </summary>
    public bool IsPublicHoliday(DateTime date)
        => Holidays.Any(h => h.IsOnDate(date));

    /// <summary>
    /// Returns the holiday that falls on the given date, or null if no holiday matches.
    /// </summary>
    public Holiday? GetHolidayOnDate(DateTime date)
        => Holidays.FirstOrDefault(h => h.IsOnDate(date));

    // ── Movable Holidays ────────────────────────────────────────────

    /// <summary>
    /// Movable holidays observed in this country (dates vary by year, e.g. Easter, Thanksgiving).
    /// </summary>
    public IReadOnlyList<MovableHoliday> MovableHolidays
        => _movableHolidays ??= MovableHolidayHelper.GetMovableHolidaysForCountry(Alpha2Code);

    /// <summary>
    /// Returns all holidays (both fixed and movable) that fall on the given date.
    /// </summary>
    public IReadOnlyList<string> GetAllHolidaysOnDate(DateTime date)
    {
        var result = new List<string>();
        var fixedMatch = Holidays.Where(h => h.IsOnDate(date)).Select(h => h.Name);
        var movableMatch = MovableHolidays.Where(h => h.IsOnDate(date)).Select(h => h.Name);
        result.AddRange(fixedMatch);
        result.AddRange(movableMatch);
        return result.AsReadOnly();
    }

    // ── Time Zones ──────────────────────────────────────────────────

    /// <summary>IANA time zones observed in this country.</summary>
    public IReadOnlyList<CountryTimeZone> TimeZones => _timeZones ??= TimeZoneHelper.GetTimeZonesForCountry(Alpha2Code);

    /// <summary>Whether this country spans more than one time zone.</summary>
    public bool HasMultipleTimeZones => TimeZones.Count > 1;

    /// <summary>
    /// Returns the primary (first-listed / capital-city) time zone, or null if none defined.
    /// </summary>
    public CountryTimeZone? GetPrimaryTimeZone()
        => TimeZones.Count > 0 ? TimeZones[0] : null;

    /// <summary>
    /// Returns all time zones in this country that observe Daylight Saving Time.
    /// </summary>
    public IReadOnlyList<CountryTimeZone> GetTimeZonesWithDst()
        => TimeZones.Where(tz => tz.ObservesDst).ToList().AsReadOnly();

    /// <summary>
    /// Returns the distinct UTC offsets observed in this country.
    /// </summary>
    public IReadOnlyList<TimeSpan> GetUtcOffsets()
        => TimeZones.Select(tz => tz.UtcOffset).Distinct().ToList().AsReadOnly();

    // ── Subdivisions ────────────────────────────────────────────────

    /// <summary>
    /// First-level administrative subdivisions (ISO 3166-2) of this country,
    /// such as states, provinces, regions, or territories.
    /// </summary>
    public IReadOnlyList<Subdivision> Subdivisions
        => _subdivisions ??= SubdivisionHelper.GetSubdivisionsForCountry(Alpha2Code);

    // ── Electrical System ───────────────────────────────────────────

    /// <summary>
    /// Electrical system specifications (plug types, voltage, frequency) for this country.
    /// </summary>
    public ElectricalSystem? ElectricalSystem
        => _electricalSystem ??= ElectricalSystemHelper.GetElectricalSystemForCountry(Alpha2Code);

    // ── Emergency Numbers ───────────────────────────────────────────

    /// <summary>
    /// Emergency telephone numbers for this country, e.g. "911", "112", "999".
    /// </summary>
    public IReadOnlyList<string> EmergencyNumbers
        => _emergencyNumbers ??= EmergencyNumberHelper.GetEmergencyNumbersForCountry(Alpha2Code);

    // ── Phone Format ────────────────────────────────────────────────

    /// <summary>
    /// Phone number format information for this country.
    /// </summary>
    public PhoneFormat? PhoneFormat
        => _phoneFormat ??= PhoneFormatHelper.GetPhoneFormatForCountry(Alpha2Code);

    // ── Locale ──────────────────────────────────────────────────────

    /// <summary>
    /// Locale and formatting conventions for this country
    /// (date format, number format, measurement system, postal code format, etc.).
    /// </summary>
    public CountryLocale? Locale
        => _locale ??= CountryLocaleHelper.GetLocaleForCountry(Alpha2Code);

    // ── Translations ────────────────────────────────────────────────

    /// <summary>
    /// Country name translated into multiple languages.
    /// Keys are ISO 639-1 alpha-2 language codes (e.g. "fr", "es", "de", "ar", "zh", "ja").
    /// </summary>
    public IReadOnlyDictionary<string, string> Translations
        => _translations ??= CountryTranslationHelper.GetTranslationsForCountry(Alpha2Code);

    /// <summary>
    /// Gets the country name in the specified language, or null if no translation is available.
    /// </summary>
    public string? GetNameInLanguage(string languageAlpha2Code)
    {
        if (string.IsNullOrWhiteSpace(languageAlpha2Code))
            return null;
        return Translations.TryGetValue(languageAlpha2Code.ToLowerInvariant(), out var name) ? name : null;
    }

    // ── Internal Setters ────────────────────────────────────────────

    internal void SetExtendedData(string subRegion, string demonym, string tld)
    {
        SubRegion = subRegion;
        Demonym = demonym;
        TLD = tld;
    }

    internal void SetGeographicData(
        long population, double area,
        GeoCoordinate? capitalCoordinates,
        string[]? borderingCountries,
        bool isLandlocked)
    {
        Population = population;
        AreaInSquareKilometers = area;
        CapitalCoordinates = capitalCoordinates;
        BorderingCountries = borderingCountries ?? Array.Empty<string>();
        IsLandlocked = isLandlocked;
    }

    internal void SetPoliticalData(
        bool isUnMember,
        DateTime? independenceDate)
    {
        IsUnMember = isUnMember;
        IndependenceDate = independenceDate;
    }

    internal void SetTransportData(DrivingSide drivingSide, string speedUnit)
    {
        DrivingSide = drivingSide;
        SpeedUnit = speedUnit ?? "km/h";
    }

    internal void SetAlternativeTlds(params string[] tlds)
    {
        AlternativeTlds = tlds ?? Array.Empty<string>();
    }

    /// <summary>Unicode flag emoji derived from the Alpha-2 code.</summary>
    public string Flag => _flag ??= string.IsNullOrEmpty(Alpha2Code)
        ? string.Empty
        : string.Concat(Alpha2Code.ToUpperInvariant().Select(c => char.ConvertFromUtf32(c - 'A' + 0x1F1E6)));

    /// <summary>
    /// Retrieves a Country object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, numeric code, or the name of the country. Returns null if not found.
    /// </summary>
    public static Country? GetCountryOrDefault(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return default;

        identifier = identifier.ToLowerInvariant();

        if (Alpha2CodeMap.TryGetValue(identifier, out var byAlpha2))
            return byAlpha2;

        if (identifier.All(char.IsDigit) && NumericCodeMap.TryGetValue(identifier, out var byNumeric))
            return byNumeric;

        if (Alpha3CodeMap.TryGetValue(identifier, out var byAlpha3))
            return byAlpha3;

        if (NameMap.TryGetValue(identifier, out var byName))
            return byName;

        return default;
    }

    /// <summary>
    /// Retrieves a Country object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, numeric code, or the name of the country. Throws an exception if not found.
    /// </summary>
    public static Country GetCountry(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentNullException(nameof(identifier));

        return GetCountryOrDefault(identifier)
            ?? throw new CountryNotFoundException($"Country with identifier '{identifier}' was not found.");
    }

    /// <summary>
    /// Checks if the provided identifier is valid. The identifier can be an Alpha-2 code, 
    /// Alpha-3 code, numeric code, or the name of the country.
    /// </summary>
    public static bool IsValid(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return false;

        identifier = identifier.ToLowerInvariant();

        return Alpha2CodeMap.ContainsKey(identifier) ||
            Alpha3CodeMap.ContainsKey(identifier) ||
            NumericCodeMap.ContainsKey(identifier) ||
            NameMap.ContainsKey(identifier);
    }

    /// <summary>
    /// Retrieves a list of all available Country objects.
    /// </summary>
    public static IReadOnlyList<Country> GetAll() => CountryHelper.GetAll();

    /// <inheritdoc />
    public override string ToString() => $"{Name} ({Alpha2Code})";

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Country other && Alpha2Code == other.Alpha2Code;

    /// <inheritdoc />
    public override int GetHashCode() => Alpha2Code.GetHashCode();
}
