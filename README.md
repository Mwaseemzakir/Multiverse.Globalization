# Multiverse

[![NuGet Version](https://img.shields.io/nuget/v/Multiverse.svg?logo=nuget&color=blue)](https://www.nuget.org/packages/Multiverse/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Multiverse.svg?logo=nuget&color=green)](https://www.nuget.org/packages/Multiverse/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Build](https://github.com/Mwaseemzakir/Multiverse/actions/workflows/nuget-publish.yml/badge.svg)](https://github.com/Mwaseemzakir/Multiverse/actions)

**Multiverse** is a lightweight, zero-dependency .NET library that provides a comprehensive, standards-compliant dataset of **countries**, **currencies**, and **languages** from around the globe — making it an essential building block for internationalization (i18n) and localization (l10n) in any .NET application.

**Country is the central entity.** Each country carries its own `Currency` object and `OfficialLanguages` list, so a single lookup gives you everything you need — no cross-referencing required.

---

## Table of Contents

- [Features](#features)
- [Supported Frameworks](#supported-frameworks)
- [Installation](#installation)
- [Quick Start](#quick-start)
- [Countries](#countries)
  - [Country Properties](#country-properties)
  - [Accessing a Country's Currency](#accessing-a-countrys-currency)
  - [Accessing a Country's Official Languages](#accessing-a-countrys-official-languages)
  - [Accessing a Country's Holidays](#accessing-a-countrys-holidays)
  - [Accessing a Country's Time Zones](#accessing-a-countrys-time-zones)
  - [Lookup by Identifier](#lookup-country-by-identifier)
    - [Country Name Aliases](#country-name-aliases)
  - [Validation](#validate-a-country-identifier)
  - [Get All Countries](#get-all-countries)
  - [Direct Access via CountryHelper](#direct-access-via-countryhelper)
- [Currencies](#currencies)
  - [Currency Properties](#currency-properties)
  - [Lookup by Identifier](#lookup-currency-by-identifier)
  - [Lookup by Numeric Code](#lookup-currency-by-numeric-code)
  - [Validation](#validate-a-currency-identifier)
  - [Get All Currencies](#get-all-currencies)
  - [Direct Access via CurrencyHelper](#direct-access-via-currencyhelper)
- [Languages](#languages)
  - [Language Properties](#language-properties)
  - [Lookup by Identifier](#lookup-language-by-identifier)
  - [Validation](#validate-a-language-identifier)
  - [Get All Languages](#get-all-languages)
  - [Direct Access via LanguageHelper](#direct-access-via-languagehelper)
- [Holidays](#holidays)
  - [Holiday Properties](#holiday-properties)
  - [Accessing Holidays from a Country](#accessing-holidays-from-a-country)
  - [Filtering Holidays by Type](#filtering-holidays-by-type)
  - [Checking if a Date is a Holiday](#checking-if-a-date-is-a-holiday)
  - [Holiday Types](#holiday-types)
- [Time Zones](#time-zones)
  - [Time Zone Properties](#time-zone-properties)
  - [Accessing Time Zones from a Country](#accessing-time-zones-from-a-country)
  - [Multi-Zone Countries](#multi-zone-countries)
  - [DST Support](#dst-support)
  - [UTC Offsets](#utc-offsets)
- [Extended Country Data](#extended-country-data)
  - [Geographic Data](#geographic-data)
  - [Political Data](#political-data)
  - [Transport Data](#transport-data)
  - [Electrical Systems](#electrical-systems)
  - [Emergency Numbers](#emergency-numbers)
  - [Phone Formats](#phone-formats)
  - [Locale & Formatting](#locale--formatting)
  - [Translations](#translations)
  - [Subdivisions](#subdivisions)
  - [Movable Holidays](#movable-holidays)
- [Validation & Formatting](#validation--formatting)
  - [Postal Codes](#postal-codes)
  - [Phone Numbers](#phone-numbers)
  - [Numbers & Addresses](#numbers--addresses)
  - [Money](#money)
- [Business Days](#business-days)
  - [Weekends](#weekends)
  - [Holidays for a Year](#holidays-for-a-year)
  - [Substitute Days](#substitute-days)
  - [Working-Day Arithmetic](#working-day-arithmetic)
- [Querying & Search](#querying--search)
  - [Filters](#filters)
  - [Search](#search)
  - [Geographic Queries](#geographic-queries)
- [Exception Handling](#exception-handling)
- [Best Practices](#best-practices)
- [API Reference Summary](#api-reference-summary)
- [Testing](#testing)
- [Release Notes](RELEASE_NOTES.md)
- [Data Sources and Coverage](DATA_SOURCES.md)
- [Contributing](#contributing)
- [License](#license)

---

## Features

| Capability | Standard | Coverage |
|---|---|---|
| **Countries** | ISO 3166-1 (alpha-2, alpha-3, numeric) + E.164 calling codes | 249 current country/area records plus the formerly assigned `AN` compatibility record |
| **Extended Country Data** | Geographic, political & transport metadata | Population, area, capital coordinates, bordering countries, driving side, speed units, independence dates, UN membership & landlocked status |
| **Currencies** | ISO 4217 (code, numeric) | 150+ world currencies with decimal places (minor units) and reverse country lookup |
| **Languages** | ISO 639-1 & ISO 639-2 (alpha-2, alpha-3) | 475+ languages with native names, scripts & text direction (LTR/RTL) |
| **Holidays** | Fixed-date public holidays | Explicit records for 213 country/area codes |
| **Movable Holidays** | Date-varies-by-year holidays | Explicit rules for 48 country/area codes |
| **Time Zones** | IANA Time Zone Database | IANA identifiers for all 250 compatibility records plus supplemental `XK`; date-aware rules use the host OS |
| **Electrical Systems** | Plug types, voltage & frequency | Explicit records for 247 country/area codes |
| **Emergency Numbers** | Emergency telephone numbers | Police, fire, ambulance numbers for all 250 countries |
| **Phone Formats** | International phone formatting | Explicit records for 233 country/area codes |
| **Locale & Formatting** | Date, number & measurement formats | All 250 compatibility records plus supplemental `XK` |
| **Translations** | Country name translations | All 250 compatibility records plus supplemental `XK` |
| **Subdivisions** | ISO 3166-2 | Explicit records for 59 country/area codes |
| **Weekends** | Working-week conventions | Saturday–Sunday by default, with 22 explicit deviations (Friday–Saturday, Friday-only, Saturday-only, split) |
| **Substitute Days** | Holiday-in-lieu rules | Explicit rules for 13 country codes; no substitution elsewhere |

- **Country-centric design** — each `Country` carries its `Currency` and `OfficialLanguages`; one lookup gives you everything
- **Not just data** — validate postal codes and phone numbers, format money and addresses, and do working-day arithmetic straight off the country
- **Fast lookups** — pre-built dictionary maps for O(1) retrieval by code, name, or number
- **Case-insensitive** — all lookups normalize input automatically
- **Null-safe** — `OrDefault` variants return `null` instead of throwing
- **Zero dependencies** — no third-party packages required
- **Immutable data** — all entries are `readonly` singletons; thread-safe by design
- **Cross-platform** — targets `net9.0`, `net8.0`, `net7.0`, `net6.0`, `netstandard2.0`, and `net462`

---

## Supported Frameworks

| Target | Supported Versions |
|---|---|
| .NET | 6.0, 7.0, 8.0, 9.0 |
| .NET Standard | 2.0 |
| .NET Framework | 4.6.2 |

> Any runtime that implements .NET Standard 2.0 or higher is supported (including .NET Core 2.0+, Mono 5.4+, Xamarin, Unity, and MAUI).

---

## Installation

### Package Manager Console
```powershell
Install-Package Multiverse
```

### .NET CLI
```bash
dotnet add package Multiverse
```

### PackageReference
```xml
<PackageReference Include="Multiverse" Version="2.0.47" />
```

---

## Quick Start

```csharp
using Multiverse.Globalization.Countries;
using Multiverse.Globalization.Currencies;
using Multiverse.Globalization.Languages;

// Country — the single source of truth
var pakistan = Country.GetCountry("PK");
Console.WriteLine($"{pakistan.Flag} {pakistan.Name}");          // 🇵🇰 Pakistan
Console.WriteLine($"Capital: {pakistan.Capital}");              // Capital: Islamabad
Console.WriteLine($"Region: {pakistan.Region}");                // Region: Asia
Console.WriteLine($"Sub-Region: {pakistan.SubRegion}");         // Sub-Region: Southern Asia
Console.WriteLine($"Demonym: {pakistan.Demonym}");              // Demonym: Pakistani
Console.WriteLine($"TLD: {pakistan.TLD}");                      // TLD: .pk
Console.WriteLine($"Calling Code: {pakistan.CallingCode}");     // Calling Code: +92

// Extended data — geographic, political, transport
Console.WriteLine($"Population: {pakistan.Population:N0}");     // Population: 231,402,117
Console.WriteLine($"UN Member: {pakistan.IsUnMember}");          // UN Member: True
Console.WriteLine($"Drives on: {pakistan.DrivingSide}");         // Drives on: Left

// Currency — accessed directly from the country
Console.WriteLine($"Currency: {pakistan.Currency!.Name}");      // Currency: Pakistan Rupee
Console.WriteLine($"  Code: {pakistan.CurrencyCode}");          // Code: PKR
Console.WriteLine($"  Symbol: {pakistan.Currency.Symbol}");     // Symbol: ₨

// Official Languages — accessed directly from the country
foreach (var lang in pakistan.OfficialLanguages)
    Console.WriteLine($"  Language: {lang.Name} ({lang.Alpha2Code})");
// Language: Urdu (ur)
// Language: English (en)

// Standalone currency & language lookups still work
var eur = Currency.GetCurrency("EUR");
Console.WriteLine($"{eur.Name} {eur.Symbol}");                 // Euro €

var french = Language.GetLanguage("fr");
Console.WriteLine($"{french.Name} ({french.Alpha2Code})");     // French (fr)
```

---

## Countries

Namespace: `Multiverse.Globalization.Countries`

The `Country` class is the **central entity** of Multiverse. The catalog contains **249 current ISO 3166-1 countries/areas** and one formerly assigned Netherlands Antilles (`AN`) compatibility record. Each object carries its own `Currency` and `OfficialLanguages`.

Use `Country.GetCurrent()` for the current ISO catalog. `Country.GetAll()` preserves the historical behavior of also returning `CountryHelper.None` and the legacy `AN` record. See [Data sources and coverage](DATA_SOURCES.md) for the exact scope and limitations.

### Country Properties

| Property | Type | Description | Example |
|---|---|---|---|
| `Name` | `string` | Official country name | `"Pakistan"` |
| `Alpha2Code` | `string` | ISO 3166-1 alpha-2 (2-letter code) | `"PK"` |
| `Alpha3Code` | `string` | ISO 3166-1 alpha-3 (3-letter code) | `"PAK"` |
| `NumericCode` | `string` | ISO 3166-1 numeric (3-digit code) | `"586"` |
| `CallingCode` | `string` | International dialing code (E.164) | `"+92"` |
| `Capital` | `string` | Capital city name | `"Islamabad"` |
| `Region` | `string` | Geographic region / continent | `"Asia"` |
| `CodeStatus` | `CountryCodeStatus` | Current, former, or unspecified ISO-code status | `OfficiallyAssigned` |
| `IsCurrent` | `bool` | Whether the ISO 3166-1 code is currently assigned | `true` |
| `SubRegion` | `string` | UN M49 sub-region | `"Southern Asia"` |
| `Demonym` | `string` | What residents of the country are called | `"Pakistani"` |
| `TLD` | `string` | Country-code top-level domain | `".pk"` |
| `Currency` | `Currency?` | Full currency object (nullable for territories with no currency) | `CurrencyHelper.PakistanRupee` |
| `CurrencyCode` | `string` | ISO 4217 code derived from `Currency` (empty if no currency) | `"PKR"` |
| `OfficialLanguages` | `IReadOnlyList<Language>` | Official languages of the country | `[Urdu, English]` |
| `Holidays` | `IReadOnlyList<Holiday>` | Public holidays observed in the country | `[Pakistan Day, Independence Day, ...]` |
| `TimeZones` | `IReadOnlyList<CountryTimeZone>` | IANA time zones observed in the country | `[Asia/Karachi (UTC+05:00)]` |
| `HasMultipleTimeZones` | `bool` | Whether the country spans more than one time zone | `false` |
| `Flag` | `string` | Unicode flag emoji (computed from Alpha2Code) | 🇵🇰 |
| `Population` | `long` | Approximate population count | `231402117` |
| `AreaInSquareKilometers` | `double` | Total area in square kilometers | `881912.0` |
| `CapitalCoordinates` | `GeoCoordinate?` | Latitude/longitude of the capital city | `(33.6844, 73.0479)` |
| `BorderingCountries` | `IReadOnlyList<string>` | Alpha-2 codes of bordering countries | `["AF","CN","IN","IR"]` |
| `IsLandlocked` | `bool` | Whether the country has no coastline | `false` |
| `IsUnMember` | `bool` | Whether the country is a UN member | `true` |
| `IndependenceDate` | `DateTime?` | Date of independence (null for territories) | `1947-08-14` |
| `DrivingSide` | `DrivingSide` | Which side of the road vehicles drive on | `DrivingSide.Left` |
| `SpeedUnit` | `string` | Speed unit used in the country | `"km/h"` |
| `AlternativeTlds` | `IReadOnlyList<string>` | Alternative country-code TLDs | `[".uk"]` (for GB) |
| `ElectricalSystem` | `ElectricalSystem?` | Plug types, voltage & frequency | `230V, 50Hz, [C, D]` |
| `EmergencyNumbers` | `IReadOnlyList<string>` | Emergency telephone numbers | `["15","115","1122"]` |
| `PhoneFormat` | `PhoneFormat?` | Phone number format information | `+92, 0, [10]` |
| `Locale` | `CountryLocale?` | Locale & formatting conventions | `dd/MM/yyyy, Metric` |
| `Translations` | `IReadOnlyDictionary<string, string>` | Country name in multiple languages | `{"fr":"Pakistan","es":"Pakistán"}` |
| `Subdivisions` | `IReadOnlyList<Subdivision>` | ISO 3166-2 administrative subdivisions | `[Punjab, Sindh, ...]` |
| `MovableHolidays` | `IReadOnlyList<MovableHoliday>` | Movable holidays (dates vary by year) | `[Shab-e-Meraj, ...]` |

### Accessing a Country's Currency

Every country carries a full `Currency` object — no need for a separate lookup:

```csharp
var japan = Country.GetCountry("JP");

// Access the Currency object directly
Currency yen = japan.Currency!;
Console.WriteLine(yen.Name);    // Yen
Console.WriteLine(yen.Code);    // JPY
Console.WriteLine(yen.Symbol);  // ¥
Console.WriteLine(yen.Number);  // 392

// Or use the convenience CurrencyCode property
Console.WriteLine(japan.CurrencyCode); // JPY

// Some territories have no official currency
var antarctica = CountryHelper.Antarctica;
Console.WriteLine(antarctica.Currency is null);  // True
Console.WriteLine(antarctica.CurrencyCode);      // (empty string)
```

### Accessing a Country's Official Languages

Each country carries its official languages as a `IReadOnlyList<Language>`:

```csharp
var switzerland = Country.GetCountry("CH");

Console.WriteLine($"{switzerland.Name} has {switzerland.OfficialLanguages.Count} languages:");
foreach (var lang in switzerland.OfficialLanguages)
    Console.WriteLine($"  {lang.Name} ({lang.Alpha2Code}/{lang.Alpha3Code})");
// Switzerland has 3 languages:
//   German (de/ger)
//   French (fr/fre)
//   Italian (it/ita)

// Countries with one official language
var france = Country.GetCountry("FR");
Console.WriteLine($"{france.Name}: {france.OfficialLanguages[0].Name}"); // France: French

// Antarctica has no official languages
var aq = CountryHelper.Antarctica;
Console.WriteLine(aq.OfficialLanguages.Count); // 0
```

### Accessing a Country's Holidays

Each country carries its public holidays as an `IReadOnlyList<Holiday>`:

```csharp
var usa = Country.GetCountry("US");

Console.WriteLine($"{usa.Name} has {usa.Holidays.Count} holidays:");
foreach (var holiday in usa.Holidays)
    Console.WriteLine($"  {holiday.Name} — {holiday.Month:D2}/{holiday.Day:D2} ({holiday.Type})");
// United States of America has 10 holidays:
//   New Year's Day — 01/01 (Public)
//   Martin Luther King Jr. Day — 01/20 (Public)
//   ...
//   Independence Day — 07/04 (National)
//   Christmas Day — 12/25 (Religious)

// Filter by type
var nationalHolidays = usa.GetHolidaysByType(HolidayType.National);
Console.WriteLine($"National holidays: {nationalHolidays.Count}"); // 1 (Independence Day)

// Check if a date is a day off (year-aware; includes movable holidays and substitute days)
bool isHoliday = usa.IsHoliday(new DateTime(2026, 7, 3));    // true — 4 July 2026 is a Saturday
bool isNotHoliday = usa.IsHoliday(new DateTime(2026, 3, 15)); // false

// Get the holiday on a given date
var holiday = usa.GetHolidayOnDate(new DateTime(2026, 7, 4));
Console.WriteLine(holiday?.Name); // Independence Day

// Countries with no holiday data return an empty list
var none = CountryHelper.None;
Console.WriteLine(none.Holidays.Count); // 0
```

### Accessing a Country's Time Zones

Each country carries its IANA time zones as an `IReadOnlyList<CountryTimeZone>`:

```csharp
var usa = Country.GetCountry("US");

Console.WriteLine($"{usa.Name} has {usa.TimeZones.Count} time zones:");
foreach (var tz in usa.TimeZones)
    Console.WriteLine($"  {tz.IanaId} — {tz.UtcOffsetString}{(tz.ObservesDst ? " (DST)" : "")}");
// United States of America has 7 time zones:
//   America/New_York — UTC-05:00 (DST)
//   America/Chicago — UTC-06:00 (DST)
//   America/Denver — UTC-07:00 (DST)
//   America/Los_Angeles — UTC-08:00 (DST)
//   America/Anchorage — UTC-09:00 (DST)
//   Pacific/Honolulu — UTC-10:00
//   America/Phoenix — UTC-07:00

// Single-zone countries
var pakistan = Country.GetCountry("PK");
Console.WriteLine($"{pakistan.Name}: {pakistan.GetPrimaryTimeZone()}");
// Pakistan: Asia/Karachi (UTC+05:00)

// Check if country spans multiple zones
Console.WriteLine(usa.HasMultipleTimeZones);     // True
Console.WriteLine(pakistan.HasMultipleTimeZones); // False

// Get zones that observe DST
var dstZones = usa.GetTimeZonesWithDst();
Console.WriteLine($"{dstZones.Count} zones observe DST"); // 5 zones observe DST

// Get distinct UTC offsets
var offsets = usa.GetUtcOffsets();
Console.WriteLine($"{offsets.Count} distinct offsets"); // 6 distinct offsets
```

### Lookup Country by Identifier

An **identifier** can be any of: alpha-2 code, alpha-3 code, numeric code, the full country name, or a common alternate name (see [`CountryHelper.NameAliases`](#country-name-aliases)).

```csharp
// Strict lookup — throws CountryNotFoundException if not found
Country usa = Country.GetCountry("US");
Country uk  = Country.GetCountry("GBR");
Country pk  = Country.GetCountry("586");
Country fr  = Country.GetCountry("France");
Country ru  = Country.GetCountry("Russia");  // alternate name, resolves to Russian Federation

// Safe lookup — returns null if not found
Country? country = Country.GetCountryOrDefault("XX"); // null
```

#### Country Name Aliases

Some countries are far more commonly referred to by a colloquial name than by their canonical ISO name (e.g. "Russian Federation" vs. "Russia"). `CountryHelper.NameAliases` maps ~30 such common alternate names to their alpha-2 code, and is consulted automatically by `GetCountry`, `GetCountryOrDefault`, and `IsValid` whenever an exact code/name match fails:

```csharp
Country.GetCountry("USA");           // United States of America
Country.GetCountry("South Korea");   // Korea (South)
Country.GetCountry("Ivory Coast");   // Côte d'Ivoire
Country.GetCountry("DR Congo");      // Congo, (Kinshasa)
Country.IsValid("UK");               // true

// See the full list:
foreach (var (alias, alpha2) in CountryHelper.NameAliases)
    Console.WriteLine($"{alias} -> {alpha2}");
```

### Validate a Country Identifier

```csharp
bool valid   = Country.IsValid("US");       // true
bool valid2  = Country.IsValid("USA");      // true
bool valid3  = Country.IsValid("840");      // true
bool invalid = Country.IsValid("XYZ");      // false
bool empty   = Country.IsValid("");         // false
bool caseOk  = Country.IsValid("us");       // true (case-insensitive)
```

### Get All Countries

```csharp
List<Country> countries = Country.GetAll();

foreach (var c in countries)
{
    Console.WriteLine($"{c.Flag} {c.Alpha2Code} - {c.Name} ({c.CurrencyCode})");
}
```

### Direct Access via CountryHelper

For compile-time access without string lookups, use `CountryHelper` fields directly:

```csharp
var pakistan = CountryHelper.Pakistan;
Console.WriteLine(pakistan.Alpha2Code);                   // PK
Console.WriteLine(pakistan.Alpha3Code);                   // PAK
Console.WriteLine(pakistan.NumericCode);                  // 586
Console.WriteLine(pakistan.CallingCode);                  // +92
Console.WriteLine(pakistan.Capital);                      // Islamabad
Console.WriteLine(pakistan.Region);                       // Asia
Console.WriteLine(pakistan.SubRegion);                    // Southern Asia
Console.WriteLine(pakistan.Demonym);                      // Pakistani
Console.WriteLine(pakistan.TLD);                          // .pk
Console.WriteLine(pakistan.CurrencyCode);                 // PKR
Console.WriteLine(pakistan.Currency!.Name);               // Pakistan Rupee
Console.WriteLine(pakistan.Currency.Symbol);              // ₨
Console.WriteLine(pakistan.OfficialLanguages[0].Name);    // Urdu
Console.WriteLine(pakistan.OfficialLanguages[1].Name);    // English
Console.WriteLine(pakistan.Holidays.Count);                // 6
Console.WriteLine(pakistan.TimeZones[0].IanaId);           // Asia/Karachi
Console.WriteLine(pakistan.TimeZones[0].UtcOffsetString);  // UTC+05:00
Console.WriteLine(pakistan.HasMultipleTimeZones);          // False
Console.WriteLine(pakistan.Flag);                         // 🇵🇰

var none = CountryHelper.None; // Empty sentinel value
```

---

## Currencies

Namespace: `Multiverse.Globalization.Currencies`

The `Currency` class provides access to **150+ world currencies** based on the **ISO 4217** standard.

> **Tip:** You can also reach a country's currency directly via `Country.Currency` — see [Accessing a Country's Currency](#accessing-a-countrys-currency).

### Currency Properties

| Property | Type | Description | Example |
|---|---|---|---|
| `Name` | `string` | Currency name | `"US Dollar"` |
| `Code` | `string` | ISO 4217 alphabetic code | `"USD"` |
| `Number` | `int` | ISO 4217 numeric code | `840` |
| `Symbol` | `string` | Currency symbol | `"$"` |
| `DecimalPlaces` | `int` | Minor units (decimal places) | `2` (most currencies), `0` (JPY), `3` (KWD) |

### Lookup Currency by Identifier

An **identifier** (string) can be the ISO code or the full currency name.

```csharp
// Strict lookup — throws CurrencyNotFoundException if not found
Currency usd = Currency.GetCurrency("USD");
Currency eur = Currency.GetCurrency("Euro");

Console.WriteLine($"{usd.Code} - {usd.Name} ({usd.Symbol})"); // USD - US Dollar ($)

// Safe lookup — returns null if not found
Currency? unknown = Currency.GetCurrencyOrDefault("XYZ"); // null
```

### Lookup Currency by Numeric Code

```csharp
// Strict lookup
Currency gbp = Currency.GetCurrency(826);
Console.WriteLine(gbp.Name); // Pound Sterling

// Safe lookup
Currency? missing = Currency.GetCurrencyOrDefault(9999); // null
```

### Validate a Currency Identifier

```csharp
// By code or name
bool valid   = Currency.IsValid("USD");         // true
bool valid2  = Currency.IsValid("Euro");        // true
bool valid3  = Currency.IsValid("usd");         // true (case-insensitive)
bool invalid = Currency.IsValid("FAKE");        // false

// By numeric code
bool validNum   = Currency.IsValid(840);        // true
bool invalidNum = Currency.IsValid(9999);       // false
```

### Get All Currencies

```csharp
List<Currency> currencies = Currency.GetAll();

foreach (var c in currencies)
{
    Console.WriteLine($"{c.Code} ({c.Number}) - {c.Name} {c.Symbol}");
}
```

### Direct Access via CurrencyHelper

```csharp
var pkr = CurrencyHelper.PakistanRupee;
Console.WriteLine($"{pkr.Code} - {pkr.Symbol}"); // PKR - ₨

var inr = CurrencyHelper.IndianRupee;
Console.WriteLine($"{inr.Code} - {inr.Symbol}"); // INR - ₹
```

---

## Languages

Namespace: `Multiverse.Globalization.Languages`

The `Language` class provides access to **475+ languages** based on the **ISO 639-1** (alpha-2) and **ISO 639-2** (alpha-3) standards.

> **Tip:** You can also reach a country's official languages directly via `Country.OfficialLanguages` — see [Accessing a Country's Official Languages](#accessing-a-countrys-official-languages).

### Language Properties

| Property | Type | Description | Example |
|---|---|---|---|
| `Name` | `string` | Language name (may include alternates) | `"Spanish; Castilian"` |
| `Alpha2Code` | `string` | ISO 639-1 code (2-letter, may be empty) | `"es"` |
| `Alpha3Code` | `string` | ISO 639-2 code (3-letter) | `"spa"` |
| `NativeName` | `string` | Native name of the language | `"Español"` |
| `Script` | `string` | Primary writing script | `"Latin"`, `"Arabic"`, `"Cyrillic"` |
| `TextDirection` | `TextDirection` | Text direction (LTR or RTL) | `TextDirection.LeftToRight` |

> **Note:** Not all languages have an alpha-2 code. Languages that only exist in ISO 639-2 will have an empty `Alpha2Code`.

### Lookup Language by Identifier

An **identifier** can be the alpha-2 code, alpha-3 code, or the full language name.

```csharp
// Strict lookup — throws LanguageNotFoundException if not found
Language english = Language.GetLanguage("en");
Language arabic  = Language.GetLanguage("ara");
Language hindi   = Language.GetLanguage("Hindi");

Console.WriteLine($"{english.Name} ({english.Alpha2Code}/{english.Alpha3Code})");
// English (en/eng)

// Safe lookup — returns null if not found
Language? unknown = Language.GetLanguageOrDefault("xyz"); // null
```

### Validate a Language Identifier

```csharp
bool valid   = Language.IsValid("en");       // true
bool valid2  = Language.IsValid("eng");      // true
bool valid3  = Language.IsValid("English");  // true
bool caseOk  = Language.IsValid("EN");       // true (case-insensitive)
bool invalid = Language.IsValid("xx");       // false
bool empty   = Language.IsValid("");         // false
```

### Get All Languages

```csharp
List<Language> languages = Language.GetAll();

foreach (var l in languages)
{
    Console.WriteLine($"{l.Alpha2Code,-4} {l.Alpha3Code,-5} {l.Name}");
}
```

### Direct Access via LanguageHelper

```csharp
var urdu = LanguageHelper.Urdu;
Console.WriteLine($"{urdu.Alpha2Code} / {urdu.Alpha3Code} – {urdu.Name}");
// ur / urd – Urdu

var none = LanguageHelper.None; // Empty sentinel value
```

---

## Holidays

Namespace: `Multiverse.Globalization.Holidays`

The `Holiday` class provides fixed-date public-holiday records for **213 country/area codes**. Holidays are accessed directly through the `Country` object; missing data returns an empty list.

> **Tip:** You can reach a country's holidays directly via `Country.Holidays` — see [Accessing a Country's Holidays](#accessing-a-countrys-holidays).

### Holiday Properties

| Property | Type | Description | Example |
|---|---|---|---|
| `Name` | `string` | Holiday name | `"Independence Day"` |
| `Month` | `int` | Month of the holiday (1–12) | `7` |
| `Day` | `int` | Day of the holiday (1–31) | `4` |
| `Type` | `HolidayType` | Category of the holiday | `HolidayType.National` |
| `Date` | `DateTime` | The holiday date in the current year | `2026-07-04` |

### Accessing Holidays from a Country

```csharp
var pakistan = Country.GetCountry("PK");

foreach (var holiday in pakistan.Holidays)
    Console.WriteLine($"{holiday.Name} — {holiday.Month:D2}/{holiday.Day:D2} ({holiday.Type})");
// Kashmir Day — 02/05 (Observance)
// Pakistan Day — 03/23 (National)
// Labour Day — 05/01 (Public)
// Independence Day — 08/14 (National)
// Iqbal Day — 11/09 (National)
// Quaid-e-Azam Day — 12/25 (National)

var japan = Country.GetCountry("JP");
Console.WriteLine($"Japan has {japan.Holidays.Count} holidays"); // Japan has 12 holidays
```

### Filtering Holidays by Type

```csharp
var france = Country.GetCountry("FR");

// Get only national holidays
var national = france.GetHolidaysByType(HolidayType.National);
foreach (var h in national)
    Console.WriteLine($"{h.Name} — {h.Month:D2}/{h.Day:D2}");
// Victory in Europe Day — 05/08
// Bastille Day — 07/14
// Armistice Day — 11/11

// Get religious holidays
var religious = france.GetHolidaysByType(HolidayType.Religious);
Console.WriteLine(religious.Count); // 3 (Assumption, All Saints', Christmas)
```

### Checking if a Date is a Holiday

```csharp
var india = Country.GetCountry("IN");

// Year-aware check covering fixed holidays, movable holidays, and substitute days
bool isHoliday = india.IsHoliday(new DateTime(2026, 1, 26)); // true (Republic Day)
bool isNot = india.IsHoliday(new DateTime(2026, 3, 15));     // false

// Everything observed on a date, with type and movable/fixed detail
foreach (var occurrence in india.GetHolidaysOn(new DateTime(2026, 8, 15)))
    Console.WriteLine($"{occurrence.Name} ({occurrence.Type})"); // Independence Day (National)

// Get the specific holiday on a date
var holiday = india.GetHolidayOnDate(new DateTime(2026, 8, 15));
Console.WriteLine(holiday?.Name); // Independence Day

// Get the date of a holiday in a specific year
var republicDay = india.Holidays.First(h => h.Name == "Republic Day");
Console.WriteLine(republicDay.GetDate(2026)); // 2026-01-26

// Check using Holiday.IsOnDate()
Console.WriteLine(republicDay.IsOnDate(new DateTime(2026, 1, 26))); // true
```

> **Note:** `IsPublicHoliday(DateTime)` is obsolete. It matched only fixed-date holidays and
> ignored the year entirely, so movable holidays such as Easter Monday and Thanksgiving were
> never reported. Use `IsHoliday(DateTime)` instead — see [Business Days](#business-days).

### Holiday Types

| Type | Description |
|---|---|
| `Public` | A national public holiday observed across the entire country |
| `Bank` | A bank/government holiday — offices close, but not all businesses |
| `Religious` | A religious or observance-based holiday |
| `National` | A national/independence/republic day |
| `Observance` | A commemoration or remembrance day |

---

## Time Zones

Namespace: `Multiverse.Globalization.TimeZones`

The `CountryTimeZone` class provides IANA time-zone identifiers for all 250 compatibility records, plus supplemental `XK` data. Time zones are accessed directly through the `Country` object.

> **Accuracy:** `UtcOffset` and `ObservesDst` are bundled standard-offset/support snapshots. Use `GetUtcOffset(instant)` and `IsDaylightSavingTime(instant)` for date-aware answers based on the host operating system's current rules.

> **Tip:** You can reach a country's time zones directly via `Country.TimeZones` — see [Accessing a Country's Time Zones](#accessing-a-countrys-time-zones).

### Time Zone Properties

| Property | Type | Description | Example |
|---|---|---|---|
| `IanaId` | `string` | IANA time zone identifier | `"America/New_York"` |
| `UtcOffsetHours` | `double` | Bundled standard-offset snapshot in hours | `-5.0` |
| `ObservesDst` | `bool` | Bundled DST-support snapshot | `true` |
| `UtcOffset` | `TimeSpan` | Bundled standard-offset snapshot | `-05:00:00` |
| `UtcOffsetString` | `string` | Formatted UTC offset string | `"UTC-05:00"` |
| `GetUtcOffset(DateTimeOffset)` | `TimeSpan` | Date-aware offset from host system rules | `-04:00:00` |
| `IsDaylightSavingTime(DateTimeOffset)` | `bool` | Whether DST applies at the instant | `true` |
| `TryGetSystemTimeZone(out TimeZoneInfo?)` | `bool` | Resolve the installed system rules | `true` |

### Accessing Time Zones from a Country

```csharp
var usa = Country.GetCountry("US");

foreach (var tz in usa.TimeZones)
    Console.WriteLine($"{tz.IanaId} — {tz.UtcOffsetString}{(tz.ObservesDst ? " (DST)" : "")}");
// America/New_York — UTC-05:00 (DST)
// America/Chicago — UTC-06:00 (DST)
// America/Denver — UTC-07:00 (DST)
// America/Los_Angeles — UTC-08:00 (DST)
// America/Anchorage — UTC-09:00 (DST)
// Pacific/Honolulu — UTC-10:00
// America/Phoenix — UTC-07:00

// Get the primary (capital-city) time zone
var primary = usa.GetPrimaryTimeZone();
Console.WriteLine(primary);  // America/New_York (UTC-05:00, DST)

// Date-aware offsets use the rules installed on the host system
var july = new DateTimeOffset(2026, 7, 15, 12, 0, 0, TimeSpan.Zero);
Console.WriteLine(primary!.GetUtcOffset(july));                 // -04:00:00
Console.WriteLine(primary.IsDaylightSavingTime(july));         // True

// Single-zone countries
var japan = Country.GetCountry("JP");
Console.WriteLine(japan.TimeZones[0]); // Asia/Tokyo (UTC+09:00)
```

### Multi-Zone Countries

```csharp
// Check if a country spans multiple time zones
var russia = Country.GetCountry("RU");
Console.WriteLine(russia.HasMultipleTimeZones);  // True
Console.WriteLine($"Russia has {russia.TimeZones.Count} time zones"); // 11

var pakistan = Country.GetCountry("PK");
Console.WriteLine(pakistan.HasMultipleTimeZones); // False

// Countries with no time zone data return an empty list
var none = CountryHelper.None;
Console.WriteLine(none.TimeZones.Count); // 0
```

### DST Support

```csharp
var usa = Country.GetCountry("US");

// Get only time zones that observe DST
var dstZones = usa.GetTimeZonesWithDst();
Console.WriteLine($"{dstZones.Count} zones observe DST"); // 5

foreach (var tz in dstZones)
    Console.WriteLine($"  {tz.IanaId}");
// America/New_York
// America/Chicago
// America/Denver
// America/Los_Angeles
// America/Anchorage

// Honolulu and Phoenix do NOT observe DST
var japan = Country.GetCountry("JP");
Console.WriteLine(japan.GetTimeZonesWithDst().Count); // 0 (Japan doesn't observe DST)
```

### UTC Offsets

```csharp
var usa = Country.GetCountry("US");

// Get distinct UTC offsets across all time zones
var offsets = usa.GetUtcOffsets();
Console.WriteLine($"US has {offsets.Count} distinct UTC offsets"); // 6
// -05:00, -06:00, -07:00, -08:00, -09:00, -10:00

// Fractional offsets
var india = Country.GetCountry("IN");
Console.WriteLine(india.TimeZones[0].UtcOffsetString); // UTC+05:30

var nepal = Country.GetCountry("NP");
Console.WriteLine(nepal.TimeZones[0].UtcOffsetString); // UTC+05:45

// Access the TimeSpan directly
var offset = india.TimeZones[0].UtcOffset;
Console.WriteLine(offset.TotalHours);  // 5.5
Console.WriteLine(offset.TotalMinutes); // 330
```

---

## Extended Country Data

Every `Country` object provides access to rich extended data — geographic, political, transport, electrical, emergency, phone format, locale, translations, subdivisions, and movable holidays. All data is lazily loaded on first access.

### Geographic Data

```csharp
var pakistan = Country.GetCountry("PK");

Console.WriteLine($"Population: {pakistan.Population:N0}");        // Population: 231,402,117
Console.WriteLine($"Area: {pakistan.AreaInSquareKilometers:N0} km²"); // Area: 881,912 km²
Console.WriteLine($"Landlocked: {pakistan.IsLandlocked}");         // Landlocked: False

// Capital coordinates
var coords = pakistan.CapitalCoordinates;
Console.WriteLine($"Capital: {coords?.Latitude}, {coords?.Longitude}"); // Capital: 33.6844, 73.0479

// Bordering countries
Console.WriteLine($"Borders: {string.Join(", ", pakistan.BorderingCountries)}"); // Borders: AF, CN, IN, IR
```

### Political Data

```csharp
var pakistan = Country.GetCountry("PK");

Console.WriteLine($"UN Member: {pakistan.IsUnMember}");             // UN Member: True
Console.WriteLine($"Independence: {pakistan.IndependenceDate:d}");  // Independence: 8/14/1947

// Territories have no independence date
var aq = Country.GetCountry("AQ");
Console.WriteLine(aq.IndependenceDate is null); // True
```

### Transport Data

```csharp
var uk = Country.GetCountry("GB");
Console.WriteLine($"Drives on: {uk.DrivingSide}");  // Drives on: Left
Console.WriteLine($"Speed unit: {uk.SpeedUnit}");    // Speed unit: mph

var germany = Country.GetCountry("DE");
Console.WriteLine($"Drives on: {germany.DrivingSide}"); // Drives on: Right
Console.WriteLine($"Speed unit: {germany.SpeedUnit}");   // Speed unit: km/h
```

### Electrical Systems

```csharp
var pakistan = Country.GetCountry("PK");
var elec = pakistan.ElectricalSystem;

Console.WriteLine($"Voltage: {elec?.Voltage}V");       // Voltage: 230V
Console.WriteLine($"Frequency: {elec?.Frequency}Hz");   // Frequency: 50Hz
Console.WriteLine($"Plugs: {string.Join(", ", elec?.PlugTypes ?? Array.Empty<PlugType>())}");
// Plugs: C, D
```

### Emergency Numbers

```csharp
var pakistan = Country.GetCountry("PK");
Console.WriteLine($"Emergency: {string.Join(", ", pakistan.EmergencyNumbers)}");
// Emergency: 15, 115, 1122

var usa = Country.GetCountry("US");
Console.WriteLine($"Emergency: {string.Join(", ", usa.EmergencyNumbers)}");
// Emergency: 911
```

### Phone Formats

```csharp
var pakistan = Country.GetCountry("PK");
var phone = pakistan.PhoneFormat;

Console.WriteLine($"Calling code: {pakistan.CallingCode}");         // Calling code: +92
Console.WriteLine($"Trunk prefix: {phone?.TrunkPrefix}");           // Trunk prefix: 0
Console.WriteLine($"International prefix: {phone?.InternationalPrefix}"); // International prefix: 00
Console.WriteLine($"Digits: {phone?.MinLength}–{phone?.MaxLength}");     // Digits: 10–10
```

To parse and re-render actual numbers, see [Phone Numbers](#phone-numbers).

### Locale & Formatting

```csharp
var pakistan = Country.GetCountry("PK");
var locale = pakistan.Locale;

Console.WriteLine($"Date format: {locale?.DateFormat}");         // Date format: dd/MM/yyyy
Console.WriteLine($"Measurement: {locale?.MeasurementSystem}");  // Measurement: Metric
Console.WriteLine($"Decimal: '{locale?.NumberDecimalSeparator}'"); // Decimal: '.'
Console.WriteLine($"Grouping: '{locale?.NumberGroupSeparator}'"); // Grouping: ','
Console.WriteLine($"Postal code: {locale?.PostalCodeFormat}");   // Postal code: #####
```

### Translations

```csharp
var pakistan = Country.GetCountry("PK");

// Get all translations
foreach (var (lang, name) in pakistan.Translations)
    Console.WriteLine($"  {lang}: {name}");
// fr: Pakistan
// es: Pakistán
// de: Pakistan
// ar: باكستان
// zh: 巴基斯坦
// ja: パキスタン
// ...

// Get name in a specific language
Console.WriteLine(pakistan.GetNameInLanguage("fr")); // Pakistan
Console.WriteLine(pakistan.GetNameInLanguage("ar")); // باكستان
Console.WriteLine(pakistan.GetNameInLanguage("zh")); // 巴基斯坦
Console.WriteLine(pakistan.GetNameInLanguage("xx")); // (null — not found)
```

### Subdivisions

```csharp
var usa = Country.GetCountry("US");

Console.WriteLine($"{usa.Name} has {usa.Subdivisions.Count} subdivisions:");
foreach (var sub in usa.Subdivisions.Take(5))
    Console.WriteLine($"  {sub.Code}: {sub.Name} ({sub.Type})");
// United States of America has 56 subdivisions:
//   US-AL: Alabama (State)
//   US-AK: Alaska (State)
//   US-AZ: Arizona (State)
//   US-AR: Arkansas (State)
//   US-CA: California (State)

// Countries without subdivision data return an empty list
var mc = Country.GetCountry("MC");
Console.WriteLine(mc.Subdivisions.Count); // 0
```

### Movable Holidays

Movable holidays have dates that vary by year (e.g. Easter, Thanksgiving). Use `GetDate(year)` to compute the actual date:

```csharp
var usa = Country.GetCountry("US");

foreach (var mh in usa.MovableHolidays)
    Console.WriteLine($"  {mh.Name}: {mh.GetDate(2026):yyyy-MM-dd}");
// Martin Luther King Jr. Day: 2026-01-19
// Presidents' Day: 2026-02-16
// Easter Sunday: 2026-04-05
// Memorial Day: 2026-05-25
// Labor Day: 2026-09-07
// Columbus Day: 2026-10-12
// Thanksgiving Day: 2026-11-26

// Check if a specific date is a movable holiday
bool isThanksgiving = usa.MovableHolidays.Any(h => h.IsOnDate(new DateTime(2026, 11, 26))); // true

// Get ALL holidays (fixed + movable) on a date
var allOnDate = usa.GetAllHolidaysOnDate(new DateTime(2026, 11, 26));
Console.WriteLine(string.Join(", ", allOnDate)); // Thanksgiving Day

// Same query, but with full detail (date, HolidayType, fixed vs. movable) instead of bare names
var occurrences = usa.GetHolidayOccurrencesOnDate(new DateTime(2026, 11, 26));
foreach (var occ in occurrences)
    Console.WriteLine($"  {occ.Name}: {occ.Date:yyyy-MM-dd} ({occ.Type}, movable={occ.IsMovable})");
// Thanksgiving Day: 2026-11-26 (National, movable=True)
```

---

## Validation & Formatting

The locale, phone, and currency datasets are wired up to do the work, not just describe it.

### Postal Codes

```csharp
var us = Country.GetCountry("US");

us.Locale!.IsValidPostalCode("94103");      // true
us.Locale.IsValidPostalCode("94103-1234");  // true
us.Locale.IsValidPostalCode("9410");        // false

var canada = Country.GetCountry("CA");
canada.Locale!.IsValidPostalCode("K1A 0B1"); // true
canada.Locale.IsValidPostalCode("K1A0B1");   // true — the space is optional

// Countries with no postal system accept only a blank value
var bolivia = Country.GetCountry("BO");
bolivia.Locale!.HasPostalCodes;              // false
bolivia.Locale.IsValidPostalCode("");        // true
bolivia.Locale.IsValidPostalCode("12345");   // false
```

Branch on `HasPostalCodes` when a form needs to hide the field entirely.

### Phone Numbers

`TryParsePhoneNumber` accepts every form a user is likely to type — E.164, international with a
dialling prefix, national with a trunk prefix, or bare subscriber digits — and normalizes them.

```csharp
var pk = Country.GetCountry("PK");

pk.TryParsePhoneNumber("0300-1234567", out var number); // true
number!.ToE164();          // +923001234567  ← store this
number.ToNational();       // 03001234567
number.ToInternational();  // +92 3001234567
number.NationalNumber;     // 3001234567

// All of these parse to the same number
pk.ParsePhoneNumber("+923001234567");
pk.ParsePhoneNumber("00923001234567");
pk.ParsePhoneNumber("3001234567");

// Validation without the out-parameter
pk.IsValidPhoneNumber("0300-1234567"); // true
pk.IsValidPhoneNumber("12345");        // false
```

`ParsePhoneNumber` throws `FormatException` on invalid input; `TryParsePhoneNumber` returns
`false`. Parsing checks the digit count against the country's known number lengths — it does not
verify that a number is assigned or reachable.

### Numbers & Addresses

```csharp
var us = Country.GetCountry("US");
var de = Country.GetCountry("DE");

us.Locale!.FormatNumber(1234.5m); // 1,234.50
de.Locale!.FormatNumber(1234.5m); // 1.234,50

// Addresses follow the country's own template; omitted parts take their separators with them
us.Locale.FormatAddress(
    street: "1600 Pennsylvania Avenue NW",
    city: "Washington",
    state: "DC",
    postalCode: "20500",
    country: "United States");
// 1600 Pennsylvania Avenue NW
// Washington, DC 20500
// United States

de.Locale.FormatAddress(street: "Unter den Linden 77", city: "Berlin", postalCode: "10117");
// Unter den Linden 77
// 10117 Berlin
```

### Money

```csharp
var usd = Currency.GetCurrency("USD");
var eur = Currency.GetCurrency("EUR");
var jpy = Currency.GetCurrency("JPY");

usd.Format(1234.5m, Country.GetCountry("US").Locale); // $1,234.50
eur.Format(1234.5m, Country.GetCountry("DE").Locale, CurrencySymbolPosition.Suffix); // 1.234,50 €
jpy.Format(1234.5m); // ¥1,235 — the yen has no minor unit

// Minor units and money-safe rounding
usd.Round(2.345m);            // 2.35 (away from zero)
usd.ToMinorUnits(1234.50m);   // 123450
usd.FromMinorUnits(123450L);  // 1234.50
Currency.GetCurrency("KWD").ToMinorUnits(1.5m); // 1500 — the dinar has three
```

---

## Business Days

Working-day arithmetic that respects each country's weekend, its fixed **and** movable holidays,
and its substitute-day rule.

### Weekends

```csharp
Country.GetCountry("US").WeekendDays; // [Saturday, Sunday]
Country.GetCountry("SA").WeekendDays; // [Friday, Saturday]
Country.GetCountry("NP").WeekendDays; // [Saturday]
Country.GetCountry("BN").WeekendDays; // [Friday, Sunday]

var friday = new DateTime(2026, 1, 2);
Country.GetCountry("US").IsWeekend(friday); // false
Country.GetCountry("SA").IsWeekend(friday); // true

// Every country resting on a given day
Country.WithWeekendDay(DayOfWeek.Friday);
```

### Holidays for a Year

`GetHolidays(year)` resolves fixed and movable holidays into concrete dates. Where a country lists
a holiday both as a fixed date and as a movable rule, the rule wins — so you get one Thanksgiving,
on the right day.

```csharp
var us = Country.GetCountry("US");

foreach (var holiday in us.GetHolidays(2026))
    Console.WriteLine($"{holiday.ObservedDate:yyyy-MM-dd}  {holiday.Name}");
// 2026-01-01  New Year's Day
// 2026-01-19  Martin Luther King Jr. Day   ← third Monday, not a stale fixed date
// ...
// 2026-11-26  Thanksgiving Day             ← fourth Thursday

// Ranges span year boundaries
us.GetHolidays(new DateTime(2026, 12, 20), new DateTime(2027, 1, 5));

// Everything observed on one date
us.GetHolidaysOn(new DateTime(2026, 12, 25));
```

### Substitute Days

When a holiday lands on a weekend, most common-law countries move it. `HolidayOccurrence` carries
both the calendar `Date` and the `ObservedDate` actually taken off.

```csharp
var us = Country.GetCountry("US");
var independenceDay = us.GetHolidays(2026).Single(h => h.Name == "Independence Day");

independenceDay.Date;          // 2026-07-04 (a Saturday)
independenceDay.ObservedDate;  // 2026-07-03 — the US moves Saturday holidays back to Friday
independenceDay.IsSubstituted; // true

// The UK pushes forward instead, and never doubles up
var gb = Country.GetCountry("GB");
gb.GetHolidays(2027).Single(h => h.Name == "Christmas Day").ObservedDate; // 2027-12-27 (Mon)
gb.GetHolidays(2027).Single(h => h.Name == "Boxing Day").ObservedDate;    // 2027-12-28 (Tue)

// Most of continental Europe simply loses the day
Country.GetCountry("DE").ObservanceRule; // None
```

`HolidayType.Observance` entries are commemorations rather than days off — they never generate a
substitute day and never count against working-day arithmetic.

### Working-Day Arithmetic

```csharp
var us = Country.GetCountry("US");

us.IsWorkingDay(new DateTime(2026, 7, 3)); // false — substituted Independence Day

// Thursday 2 July + 1 working day: the 3rd is the substitute holiday and the 4th-5th
// are the weekend, so the answer is Monday the 6th
us.AddBusinessDays(new DateTime(2026, 7, 2), 1);  // 2026-07-06
us.AddBusinessDays(new DateTime(2026, 7, 6), -1); // 2026-07-02 — negatives walk backwards

us.NextWorkingDay(new DateTime(2026, 7, 2));      // 2026-07-06
us.PreviousWorkingDay(new DateTime(2026, 7, 6));  // 2026-07-02

// Inclusive of both endpoints
us.CountBusinessDays(new DateTime(2026, 6, 29), new DateTime(2026, 7, 10)); // 9

// The same arithmetic, on a Friday-Saturday weekend
Country.GetCountry("SA").AddBusinessDays(new DateTime(2026, 3, 5), 1); // 2026-03-08 (Sunday)
```

---

## Querying & Search

Filters and search over the catalog. Every static query runs over `GetCurrent()`, so the `None`
sentinel and formerly assigned codes never appear in results.

### Filters

```csharp
Country.InRegion("Europe");            // all European countries
Country.InSubRegion("Southern Asia");  // PK, IN, BD, LK, ...
Country.UsingCurrency("EUR");          // the eurozone
Country.SpeakingLanguage("French");    // FR, BE, CH, CA, SN, ...
Country.WithCallingCode("+1");         // the whole North American Numbering Plan
Country.WithWeekendDay(DayOfWeek.Friday);
```

Currency and language filters accept any identifier the corresponding lookup accepts — `"EUR"` or
`"Euro"`, `"fr"` or `"fra"` or `"French"`.

### Search

```csharp
Country.Search("USA")[0].Name;            // United States of America — exact code
Country.Search("united states")[0].Name;  // United States of America — alias
Country.Search("Paki")[0].Name;           // Pakistan — prefix
Country.Search("Tokyo")[0].Name;          // Japan — capital city
Country.Search("germny")[0].Name;         // Germany — tolerates a typo

Country.Search("a", maxResults: 5);       // capped
Country.Search("zzzzqqqq");               // empty
```

Results are ranked: exact code or name, then alias, prefix, substring, capital, and finally a
Levenshtein match within two edits.

### Geographic Queries

```csharp
var us = Country.GetCountry("US");

// Neighbours as countries, not just codes
foreach (var neighbour in us.GetBorderingCountries())
    Console.WriteLine(neighbour.Name); // Canada, Mexico

// Great-circle distance between capitals, in kilometres
Country.GetCountry("FR").DistanceTo(Country.GetCountry("DE")); // ~878

// Nearest countries to a point
Country.NearestTo(48.8566, 2.3522);             // [France]
Country.NearestTo(35.6762, 139.6503, count: 3); // [Japan, South Korea, ...]
```

`DistanceTo` returns `null` when either capital has no coordinates on record.

---

## Exception Handling

Each domain has a dedicated exception type that inherits from `System.Exception`:

| Exception | Thrown By |
|---|---|
| `CountryNotFoundException` | `Country.GetCountry()` |
| `CurrencyNotFoundException` | `Currency.GetCurrency(string)`, `Currency.GetCurrency(int)` |
| `LanguageNotFoundException` | `Language.GetLanguage()` |

**Example — structured error handling:**

```csharp
try
{
    var country = Country.GetCountry(userInput);
    Console.WriteLine($"Found: {country.Name} — Currency: {country.CurrencyCode}");
}
catch (CountryNotFoundException ex)
{
    Console.WriteLine($"Not found: {ex.Message}");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Input was null or empty.");
}
```

---

## Best Practices

### 1. Use Country as Your Single Source of Truth

A single `Country` lookup gives you the country, its currency, and its official languages — no need to query them separately:

```csharp
var country = Country.GetCountry("PK");

// Everything in one place
var name       = country.Name;                     // Pakistan
var currency   = country.Currency!;                 // CurrencyHelper.PakistanRupee
var code       = country.CurrencyCode;              // PKR
var languages  = country.OfficialLanguages;         // [Urdu, English]
var flag       = country.Flag;                      // 🇵🇰
```

### 2. Prefer Safe Lookups for User Input

Use the `OrDefault` variants when dealing with untrusted or user-provided values to avoid unnecessary exception overhead:

```csharp
var country = Country.GetCountryOrDefault(userInput);
if (country is not null)
{
    Console.WriteLine($"{country.Name} uses {country.Currency?.Name ?? "no official currency"}");
}
```

### 3. Validate Before Processing

Use `IsValid()` as a guard clause before further business logic:

```csharp
if (!Country.IsValid(countryCode))
{
    return BadRequest("Invalid country code.");
}

var country = Country.GetCountry(countryCode);
```

### 4. Use Static Fields for Known Values

When you know the value at compile time, reference `CountryHelper`, `CurrencyHelper`, or `LanguageHelper` fields directly — this avoids string parsing entirely:

```csharp
var defaultCountry  = CountryHelper.UnitedStatesOfAmerica;
var defaultCurrency = CurrencyHelper.UsDollar;
var defaultLanguage = LanguageHelper.English;

// Or reach currency/language through the country
var usCurrency   = CountryHelper.UnitedStatesOfAmerica.Currency;   // CurrencyHelper.UsDollar
var usLanguages  = CountryHelper.UnitedStatesOfAmerica.OfficialLanguages; // [English]
```

### 5. Use Case-Insensitive Input Freely

All lookups normalize to lowercase internally, so you never need to pre-process casing:

```csharp
// All of these return the same result
Country.GetCountry("us");
Country.GetCountry("US");
Country.GetCountry("Us");
```

---

## API Reference Summary

### Country

| Property / Method | Returns | Description |
|---|---|---|
| `Name` | `string` | Official country name |
| `Alpha2Code` | `string` | ISO 3166-1 alpha-2 code |
| `Alpha3Code` | `string` | ISO 3166-1 alpha-3 code |
| `NumericCode` | `string` | ISO 3166-1 numeric code |
| `CallingCode` | `string` | International dialing code (E.164) |
| `Capital` | `string` | Capital city |
| `Region` | `string` | Geographic region / continent |
| `CodeStatus` | `CountryCodeStatus` | Current, former, or unspecified ISO-code status |
| `IsCurrent` | `bool` | Whether the ISO 3166-1 code is currently assigned |
| `SubRegion` | `string` | UN M49 sub-region (e.g. "Southern Asia", "Western Europe") |
| `Demonym` | `string` | Demonym — what residents are called (e.g. "Pakistani", "American") |
| `TLD` | `string` | Country-code top-level domain (e.g. ".pk", ".us") |
| `Currency` | `Currency?` | Full currency object (null for territories with no currency) |
| `CurrencyCode` | `string` | ISO 4217 code derived from `Currency` |
| `OfficialLanguages` | `IReadOnlyList<Language>` | Official languages of the country |
| `Holidays` | `IReadOnlyList<Holiday>` | Public holidays observed in this country |
| `TimeZones` | `IReadOnlyList<CountryTimeZone>` | IANA time zones observed in this country |
| `HasMultipleTimeZones` | `bool` | Whether the country spans more than one time zone |
| `Flag` | `string` | Unicode flag emoji |
| `Population` | `long` | Approximate population count |
| `AreaInSquareKilometers` | `double` | Total area in km² |
| `CapitalCoordinates` | `GeoCoordinate?` | Capital city latitude/longitude |
| `BorderingCountries` | `IReadOnlyList<string>` | Alpha-2 codes of neighboring countries |
| `IsLandlocked` | `bool` | Whether the country has no coastline |
| `IsUnMember` | `bool` | Whether the country is a UN member |
| `IndependenceDate` | `DateTime?` | Date of independence |
| `DrivingSide` | `DrivingSide` | Left or Right driving side |
| `SpeedUnit` | `string` | Speed measurement unit (km/h or mph) |
| `AlternativeTlds` | `IReadOnlyList<string>` | Alternative country-code TLDs |
| `ElectricalSystem` | `ElectricalSystem?` | Voltage, frequency & plug types |
| `EmergencyNumbers` | `IReadOnlyList<string>` | Emergency telephone numbers |
| `PhoneFormat` | `PhoneFormat?` | Phone number format info |
| `Locale` | `CountryLocale?` | Date, number & measurement formats |
| `Translations` | `IReadOnlyDictionary<string, string>` | Country name translations |
| `Subdivisions` | `IReadOnlyList<Subdivision>` | ISO 3166-2 subdivisions |
| `MovableHolidays` | `IReadOnlyList<MovableHoliday>` | Movable holidays |
| `WeekendDays` | `IReadOnlyList<DayOfWeek>` | Days forming the weekend in this country |
| `ObservanceRule` | `HolidayObservanceRule` | How weekend holidays are moved |

| Method | Returns | Throws | Description |
|---|---|---|---|
| `GetCountry(string)` | `Country` | `CountryNotFoundException`, `ArgumentNullException` | Strict lookup by alpha-2, alpha-3, numeric code, name, or common alias |
| `GetCountryOrDefault(string)` | `Country?` | — | Safe lookup; returns `null` if not found |
| `IsValid(string)` | `bool` | — | Check if identifier maps to a known country |
| `GetCurrent()` | `IReadOnlyList<Country>` | — | 249 currently assigned ISO 3166-1 records |
| `GetLegacy()` | `IReadOnlyList<Country>` | — | Formerly assigned compatibility records |
| `GetAll()` | `IReadOnlyList<Country>` | — | Compatibility catalog, including `None` and legacy records |

| Method | Returns | Description |
|---|---|---|
| `GetHolidaysByType(HolidayType)` | `IReadOnlyList<Holiday>` | Filter holidays by type |
| `IsPublicHoliday(DateTime)` | `bool` | **Obsolete.** Fixed-date only, ignores the year — use `IsHoliday` |
| `GetHolidayOnDate(DateTime)` | `Holiday?` | Get the holiday on a given date, or null |
| `GetPrimaryTimeZone()` | `CountryTimeZone?` | Get the primary (capital-city) time zone, or null |
| `GetTimeZonesWithDst()` | `IReadOnlyList<CountryTimeZone>` | Get all time zones that observe DST |
| `GetUtcOffsets()` | `IReadOnlyList<TimeSpan>` | Get distinct UTC offsets across all time zones |
| `GetAllHolidaysOnDate(DateTime)` | `IReadOnlyList<string>` | Get all holiday names (fixed + movable) on a date |
| `GetHolidayOccurrencesOnDate(DateTime)` | `IReadOnlyList<HolidayOccurrence>` | Get all holidays (fixed + movable) on a date, with date/type/movable detail |
| `GetNameInLanguage(string)` | `string?` | Get country name in the specified language |
| `GetHolidays(int)` | `IReadOnlyList<HolidayOccurrence>` | All holidays for a year, fixed and movable, with substitute days |
| `GetHolidays(DateTime, DateTime)` | `IReadOnlyList<HolidayOccurrence>` | All holidays in a date range, spanning years |
| `GetHolidaysOn(DateTime)` | `IReadOnlyList<HolidayOccurrence>` | Holidays observed on a date |
| `IsHoliday(DateTime)` | `bool` | Year-aware day-off check, including movable and substitute days |
| `IsWeekend(DateTime)` | `bool` | Check against this country's weekend |
| `IsWorkingDay(DateTime)` | `bool` | Neither weekend nor holiday |
| `NextWorkingDay(DateTime)` | `DateTime` | First working day after the given date |
| `PreviousWorkingDay(DateTime)` | `DateTime` | Last working day before the given date |
| `AddBusinessDays(DateTime, int)` | `DateTime` | Advance by working days; negative walks backwards |
| `CountBusinessDays(DateTime, DateTime)` | `int` | Working days in an inclusive range |
| `TryParsePhoneNumber(string?, out PhoneNumber?)` | `bool` | Parse a phone number against this country's format |
| `ParsePhoneNumber(string)` | `PhoneNumber` | Strict parse; throws `FormatException` |
| `IsValidPhoneNumber(string?)` | `bool` | Phone number plausibility check |
| `GetBorderingCountries()` | `IReadOnlyList<Country>` | Neighbours resolved from alpha-2 codes |
| `DistanceTo(Country)` | `double?` | Great-circle km between capitals, or null |

| Static query | Returns | Description |
|---|---|---|
| `InRegion(string)` | `IReadOnlyList<Country>` | Countries in a region |
| `InSubRegion(string)` | `IReadOnlyList<Country>` | Countries in a sub-region |
| `UsingCurrency(string)` | `IReadOnlyList<Country>` | Countries using a currency |
| `SpeakingLanguage(string)` | `IReadOnlyList<Country>` | Countries with an official language |
| `WithCallingCode(string)` | `IReadOnlyList<Country>` | Countries sharing a calling code |
| `WithWeekendDay(DayOfWeek)` | `IReadOnlyList<Country>` | Countries resting on a given day |
| `Search(string, int)` | `IReadOnlyList<Country>` | Ranked search by name, code, alias, capital, or near-miss |
| `NearestTo(double, double, int)` | `IReadOnlyList<Country>` | Countries whose capitals are closest to a point |

### Currency

| Property / Method | Returns | Description |
|---|---|---|
| `Name` | `string` | Currency name |
| `Code` | `string` | ISO 4217 alphabetic code |
| `Number` | `int` | ISO 4217 numeric code |
| `Symbol` | `string` | Currency symbol |
| `DecimalPlaces` | `int` | Minor units (decimal places) |
| `Format(decimal, CountryLocale?, CurrencySymbolPosition)` | `string` | Format an amount with a country's separators |
| `Round(decimal)` | `decimal` | Round to the currency's minor unit, away from zero |
| `ToMinorUnits(decimal)` | `long` | Convert to whole minor units (cents, fils) |
| `FromMinorUnits(long)` | `decimal` | Convert minor units back to a major-unit amount |

| Method | Returns | Throws | Description |
|---|---|---|---|
| `GetCurrency(string)` | `Currency` | `CurrencyNotFoundException`, `ArgumentNullException` | Strict lookup by code or name |
| `GetCurrency(int)` | `Currency` | `CurrencyNotFoundException` | Strict lookup by ISO numeric code |
| `GetCurrencyOrDefault(string)` | `Currency?` | — | Safe lookup by code or name |
| `GetCurrencyOrDefault(int)` | `Currency?` | — | Safe lookup by numeric code |
| `IsValid(string)` | `bool` | — | Check if code/name maps to a known currency |
| `IsValid(int)` | `bool` | — | Check if numeric code maps to a known currency |
| `GetAll()` | `List<Currency>` | — | All 150+ currencies |
| `GetCountriesUsingCurrency()` | `IReadOnlyList<Country>` | — | All countries using this currency |

### Language

| Property / Method | Returns | Description |
|---|---|---|
| `Name` | `string` | Language name (may include alternates) |
| `Alpha2Code` | `string` | ISO 639-1 code (2-letter, may be empty) |
| `Alpha3Code` | `string` | ISO 639-2 code (3-letter) |
| `NativeName` | `string` | Native name of the language |
| `Script` | `string` | Primary writing script |
| `TextDirection` | `TextDirection` | Text direction (LeftToRight or RightToLeft) |

| Method | Returns | Throws | Description |
|---|---|---|---|
| `GetLanguage(string)` | `Language` | `LanguageNotFoundException`, `ArgumentNullException` | Strict lookup by alpha-2, alpha-3, or name |
| `GetLanguageOrDefault(string)` | `Language?` | — | Safe lookup; returns `null` if not found |
| `IsValid(string)` | `bool` | — | Check if identifier maps to a known language |
| `GetAll()` | `List<Language>` | — | All 475+ languages |

### CountryHelper

| Member | Type | Description |
|---|---|---|
| `None` | `Country` | Empty sentinel value representing no country |
| `GetCurrent()` | `IReadOnlyList<Country>` | 249 currently assigned ISO 3166-1 records |
| `GetLegacy()` | `IReadOnlyList<Country>` | Formerly assigned compatibility records |
| `GetAll()` | `IReadOnlyList<Country>` | Cached compatibility catalog, including `None` and legacy records |
| `Alpha2CodeMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by ISO 3166-1 alpha-2 code (case-insensitive keys) |
| `Alpha3CodeMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by ISO 3166-1 alpha-3 code (case-insensitive keys) |
| `NumericCodeMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by ISO 3166-1 numeric code |
| `NameMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by country name (case-insensitive keys) |
| `Pakistan`, `France`, ... | `Country` | 249 current fields plus the legacy Netherlands Antilles record |

### CurrencyHelper

| Member | Type | Description |
|---|---|---|
| `None` | `Currency` | Empty sentinel value representing no currency |
| `GetAll()` | `List<Currency>` | Returns a new list of all currencies, ordered by name |
| `CodeMap` | `IReadOnlyDictionary<string, Currency>` | O(1) lookup by ISO 4217 code (case-insensitive keys) |
| `NameMap` | `IReadOnlyDictionary<string, Currency>` | O(1) lookup by currency name (case-insensitive keys) |
| `NumberMap` | `IReadOnlyDictionary<int, Currency>` | O(1) lookup by ISO 4217 numeric code |
| `UsDollar`, `Euro`, ... | `Currency` | 150+ static readonly fields — one per currency |

### LanguageHelper

| Member | Type | Description |
|---|---|---|
| `None` | `Language` | Empty sentinel value representing no language |
| `GetAll()` | `List<Language>` | Returns a new list of all languages |
| `Alpha2CodeMap` | `IReadOnlyDictionary<string, Language>` | O(1) lookup by ISO 639-1 code (lowercase keys) |
| `Alpha3CodeMap` | `IReadOnlyDictionary<string, Language>` | O(1) lookup by ISO 639-2 code (lowercase keys) |
| `NameMap` | `IReadOnlyDictionary<string, Language>` | O(1) lookup by language name (lowercase keys) |
| `English`, `Urdu`, ... | `Language` | 475+ static readonly fields — one per language |

### Holiday

| Property / Method | Returns | Description |
|---|---|---|
| `Name` | `string` | Holiday name |
| `Month` | `int` | Month (1–12) |
| `Day` | `int` | Day (1–31) |
| `Type` | `HolidayType` | Category (Public, Bank, Religious, National, Observance) |
| `Date` | `DateTime` | Date in the current year |
| `GetDate(int)` | `DateTime` | Date in a specific year |
| `IsOnDate(DateTime)` | `bool` | Check if month/day matches a given date |
| `ToString()` | `string` | Formatted string, e.g. `"Christmas Day (12/25)"` |

### HolidayHelper

| Member | Type | Description |
|---|---|---|
| `All` | `IReadOnlyDictionary<string, List<Holiday>>` | Complete mapping of alpha-2 codes to holiday lists |

### CountryLocale

| Property / Method | Returns | Description |
|---|---|---|
| `DateFormat` | `string` | Primary date format string |
| `NumberDecimalSeparator` | `string` | Decimal separator |
| `NumberGroupSeparator` | `string` | Thousands separator |
| `MeasurementSystem` | `MeasurementSystem` | Metric, Imperial, or USCustomary |
| `WeekStartDay` | `DayOfWeek` | Day the week starts on |
| `PostalCodeFormat` | `string` | Regex pattern for postal codes |
| `AddressFormat` | `string` | Address template |
| `HasPostalCodes` | `bool` | Whether the country operates a postal code system |
| `IsValidPostalCode(string?)` | `bool` | Validate a postal code against the country's pattern |
| `FormatNumber(decimal, int)` | `string` | Format a number with the country's separators |
| `FormatAddress(...)` | `string` | Render an address, dropping omitted components |

### PhoneNumber

| Property / Method | Returns | Description |
|---|---|---|
| `Country` | `Country` | The country the number was parsed against |
| `NationalNumber` | `string` | Subscriber digits, no calling code or trunk prefix |
| `CallingCode` | `string` | Country calling code with the leading plus |
| `ToE164()` | `string` | E.164 form, e.g. `+923001234567` |
| `ToNational()` | `string` | National form with the trunk prefix |
| `ToInternational()` | `string` | Calling code separated from the number |

### CountryTimeZone

| Property / Method | Returns | Description |
|---|---|---|
| `IanaId` | `string` | IANA time zone identifier (e.g. "America/New_York") |
| `UtcOffsetHours` | `double` | Bundled standard-offset snapshot in hours (e.g. -5.0, +5.5, +5.75) |
| `ObservesDst` | `bool` | Bundled DST-support snapshot |
| `UtcOffset` | `TimeSpan` | Bundled standard-offset snapshot |
| `UtcOffsetString` | `string` | Formatted offset string (e.g. "UTC-05:00", "UTC+05:45") |
| `GetUtcOffset(DateTimeOffset)` | `TimeSpan` | Date-aware offset using installed system rules |
| `IsDaylightSavingTime(DateTimeOffset)` | `bool` | Date-aware DST state using installed system rules |
| `TryGetSystemTimeZone(out TimeZoneInfo?)` | `bool` | Try to resolve installed system rules |
| `ToString()` | `string` | Formatted string, e.g. `"America/New_York (UTC-05:00, DST)"` |

### TimeZoneHelper

| Member | Type | Description |
|---|---|---|
| `All` | `IReadOnlyDictionary<string, List<CountryTimeZone>>` | Complete mapping of alpha-2 codes to time zone lists |

---

## Testing

The project includes a comprehensive test suite with **745 unit tests** covering every public API, edge case, and data integrity check across the entire library.

### Running Tests

```bash
dotnet test
```

### Test Structure

| Test Class | Tests | Covers |
|---|---|---|
| `CountryTests` | 119+ | `Country` API, current/legacy code status, lookup maps, SubRegion, Demonym, TLD, and catalog integrity |
| `CurrencyTests` | 56 | `Currency` API (string & int overloads), `CurrencyHelper` maps, data integrity |
| `LanguageTests` | 42 | `Language` API, `LanguageHelper` maps, data integrity |
| `ExceptionTests` | 19 | All three custom exception types — constructors, inheritance, and throw behavior |
| `HolidayTests` | 76 | `Holiday` model, `HolidayType` enum, `Country.Holidays`, filtering, date checks, data integrity |
| `TimeZoneTests` | 98 | `CountryTimeZone` model, `Country.TimeZones`, DST support, UTC offsets, multi-zone countries, data integrity |
| `GeographicDataTests` | 49 | Population, area, capital coordinates, bordering countries, landlocked status |
| `PoliticalDataTests` | 14 | UN membership, independence dates |
| `TransportDataTests` | 18 | Driving side, speed units, DrivingSide enum |
| `ElectricalSystemTests` | 24 | Voltage, frequency, plug types, PlugType enum |
| `EmergencyNumberTests` | 10 | Emergency telephone numbers |
| `PhoneFormatTests` | 15 | Phone number formatting, calling codes, trunk prefixes |
| `LocaleTests` | 21 | Date/number formats, measurement systems, postal codes |
| `TranslationTests` | 17 | Country name translations, GetNameInLanguage |
| `SubdivisionTests` | 18 | ISO 3166-2 subdivisions, code uniqueness |
| `MovableHolidayTests` | 26 | Easter calculation, nth-weekday holidays, date computation |
| `CurrencyExtendedTests` | 24 | Decimal places, reverse country lookup |
| `LanguageExtendedTests` | 24 | Native names, scripts, text direction |
| `CountryIntegrationTests` | 22 | Alternative TLDs, full property integration |
| `PostalCodeValidationTests` | 15 | Postal code validation per country, `HasPostalCodes`, whole-catalog pattern safety |
| `LocaleFormattingTests` | 15 | Number formatting, address templating, culture independence |
| `PhoneNumberTests` | 29 | Phone parsing in every common form, E.164 round trip across the catalog |
| `CurrencyFormattingTests` | 14 | Symbol placement, minor units, money-safe rounding |
| `WeekendTests` | 13 | Weekend days per country, `IsWeekend`, exception-map integrity |
| `HolidayObservanceTests` | 17 | Substitute-day rules, double bank holidays, observance exclusion |
| `BusinessDayTests` | 34 | Year-aware holidays, working-day arithmetic, whole-catalog sanity |
| `CountryQueryTests` | 39 | Region/currency/language/calling-code filters, ranked search, geographic queries |

### What's Tested

- **All lookup methods** — `GetCountry`, `GetCurrency`, `GetLanguage` and their `OrDefault` variants, by every supported identifier type (alpha-2, alpha-3, numeric code, name)
- **Validation** — `IsValid()` for valid codes, invalid codes, `null`, empty strings, whitespace, and case variations
- **Exception paths** — `ArgumentNullException` for null/empty input, domain-specific `NotFoundException` for unknown identifiers
- **Case insensitivity** — lookups work with any casing (`"us"`, `"US"`, `"Us"`)
- **Helper maps** — `Alpha2CodeMap`, `Alpha3CodeMap`, `NameMap`, `NumericCodeMap`, `CodeMap`, `NumberMap` all contain expected entries
- **Data integrity** — no duplicate codes/names, all required properties are non-empty, regions come from a known set, calling codes start with `+`, currency codes are uppercase 3-letter, alpha codes have correct lengths, SubRegions/Demonyms/TLDs populated for all countries
- **Relationships** — `Country.Currency` matches `CurrencyCode`, `Country.OfficialLanguages` returns correct languages, `Country.Flag` is derived from `Alpha2Code`, `Country.Holidays` returns correct holidays with filtering and date-check methods
- **Collection behavior** — `GetAll()` returns new list instances each time, lists are ordered, singletons are reference-equal across lookups
- **Holiday data** — all holidays have valid names, months, days, and types; no duplicate names per country; consistent across accesses
- **Time zone data** — all IANA IDs are non-empty and contain "/", UTC offsets in valid range (−12 to +14), no duplicate IANA IDs per country, all country codes exist in CountryHelper, fractional offsets formatted correctly
- **Extended country data** — geographic data (population, area, coordinates, borders, landlocked), political data (UN membership, independence dates), transport data (driving side, speed units), electrical systems (voltage, frequency, plug types), emergency numbers, phone formats, locale/formatting (date/number formats, measurement systems, postal codes), translations (country names in 10+ languages), subdivisions (ISO 3166-2), and movable holidays (Easter, Thanksgiving, etc.)
- **Currency extensions** — decimal places (minor units) for all currencies, reverse lookup via `GetCountriesUsingCurrency()`
- **Language extensions** — native names, scripts, text direction (LTR/RTL) for all languages
- **Validation & formatting** — postal codes against every shipped pattern, phone numbers in E.164/international/national/bare forms with a full-catalog round trip, number and address formatting under a non-invariant ambient culture, currency symbol placement and minor-unit round trips
- **Business days** — weekend data per country, year-aware holiday resolution, substitute-day rules including the UK double bank holiday and the US Saturday-to-Friday shift, forward and backward working-day arithmetic, and a whole-catalog check that every country resolves a full year without throwing
- **Queries** — filters return only current ISO 3166-1 records, search ranking from exact code through typo tolerance, border resolution for every country, and great-circle distances between capitals

### Test Dependencies

| Package | Purpose |
|---|---|
| [xUnit](https://xunit.net/) | Test framework |
| [FluentAssertions](https://fluentassertions.com/) | Assertion library |
| [NSubstitute](https://nsubstitute.github.io/) | Mocking framework |

---

## Contributing

Contributions, issues, and feature requests are welcome! Feel free to open an issue or submit a pull request on the [GitHub repository](https://github.com/Mwaseemzakir/Multiverse).

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/my-feature`)
3. Commit your changes (`git commit -m "Add my feature"`)
4. Push to the branch (`git push origin feature/my-feature`)
5. Open a Pull Request

---

## License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

Copyright &copy; 2023 Muhammad Waseem


