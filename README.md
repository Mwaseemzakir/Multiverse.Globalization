# Multiverse

[![NuGet Version](https://img.shields.io/nuget/v/Multiverse.svg?logo=nuget&color=blue)](https://www.nuget.org/packages/Multiverse/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Multiverse.svg?logo=nuget&color=green)](https://www.nuget.org/packages/Multiverse/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Build](https://github.com/Mwaseemzakir/Multiverse.Globalization/actions/workflows/nuget-publish.yml/badge.svg)](https://github.com/Mwaseemzakir/Multiverse.Globalization/actions)

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
  - [Lookup by Identifier](#lookup-country-by-identifier)
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
- [Exception Handling](#exception-handling)
- [Best Practices](#best-practices)
- [API Reference Summary](#api-reference-summary)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

---

## Features

| Capability | Standard | Coverage |
|---|---|---|
| **Countries** | ISO 3166-1 (alpha-2, alpha-3, numeric) + E.164 calling codes | 250 countries & territories with capitals, regions, sub-regions, demonyms, TLDs, currencies, official languages, holidays & flag emojis |
| **Currencies** | ISO 4217 (code, numeric) | 150+ world currencies |
| **Languages** | ISO 639-1 & ISO 639-2 (alpha-2, alpha-3) | 475+ languages |
| **Holidays** | Fixed-date public holidays | Public, national, religious, bank & observance holidays for 190+ countries |

- **Country-centric design** — each `Country` carries its `Currency` and `OfficialLanguages`; one lookup gives you everything
- **Fast lookups** — pre-built dictionary maps for O(1) retrieval by code, name, or number
- **Case-insensitive** — all lookups normalize input automatically
- **Null-safe** — `OrDefault` variants return `null` instead of throwing
- **Zero dependencies** — no third-party packages required
- **Immutable data** — all entries are `readonly` singletons; thread-safe by design
- **Cross-platform** — targets `net8.0`, `netstandard2.0`, and `net462`

---

## Supported Frameworks

| Target | Minimum Version |
|---|---|
| .NET | 8.0 |
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
<PackageReference Include="Multiverse" Version="2.0.40" />
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

The `Country` class is the **central entity** of Multiverse. Each country object provides access to **250 countries and territories** based on **ISO 3166-1**, and carries its own `Currency` and `OfficialLanguages` — so a single lookup gives you everything about a country.

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
| `SubRegion` | `string` | UN M49 sub-region | `"Southern Asia"` |
| `Demonym` | `string` | What residents of the country are called | `"Pakistani"` |
| `TLD` | `string` | Country-code top-level domain | `".pk"` |
| `Currency` | `Currency?` | Full currency object (nullable for territories with no currency) | `CurrencyHelper.PakistanRupee` |
| `CurrencyCode` | `string` | ISO 4217 code derived from `Currency` (empty if no currency) | `"PKR"` |
| `OfficialLanguages` | `IReadOnlyList<Language>` | Official languages of the country | `[Urdu, English]` |
| `Holidays` | `IReadOnlyList<Holiday>` | Public holidays observed in the country | `[Pakistan Day, Independence Day, ...]` |
| `Flag` | `string` | Unicode flag emoji (computed from Alpha2Code) | 🇵🇰 |

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

// Check if a date is a holiday
bool isHoliday = usa.IsPublicHoliday(new DateTime(2026, 7, 4)); // true
bool isNotHoliday = usa.IsPublicHoliday(new DateTime(2026, 3, 15)); // false

// Get the holiday on a given date
var holiday = usa.GetHolidayOnDate(new DateTime(2026, 7, 4));
Console.WriteLine(holiday?.Name); // Independence Day

// Countries with no holiday data return an empty list
var none = CountryHelper.None;
Console.WriteLine(none.Holidays.Count); // 0
```

### Lookup Country by Identifier

An **identifier** can be any of: alpha-2 code, alpha-3 code, numeric code, or the full country name.

```csharp
// Strict lookup — throws CountryNotFoundException if not found
Country usa = Country.GetCountry("US");
Country uk  = Country.GetCountry("GBR");
Country pk  = Country.GetCountry("586");
Country fr  = Country.GetCountry("France");

// Safe lookup — returns null if not found
Country? country = Country.GetCountryOrDefault("XX"); // null
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

The `Holiday` class provides access to **fixed-date public holidays** for **190+ countries** around the world. Holidays are accessed directly through the `Country` object — each country carries its own holidays.

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

// Check if a date falls on a holiday
bool isHoliday = india.IsPublicHoliday(new DateTime(2026, 1, 26)); // true (Republic Day)
bool isNot = india.IsPublicHoliday(new DateTime(2026, 3, 15));     // false

// Get the specific holiday on a date
var holiday = india.GetHolidayOnDate(new DateTime(2026, 8, 15));
Console.WriteLine(holiday?.Name); // Independence Day

// Get the date of a holiday in a specific year
var republicDay = india.Holidays.First(h => h.Name == "Republic Day");
Console.WriteLine(republicDay.GetDate(2026)); // 2026-01-26

// Check using Holiday.IsOnDate()
Console.WriteLine(republicDay.IsOnDate(new DateTime(2026, 1, 26))); // true
```

### Holiday Types

| Type | Description |
|---|---|
| `Public` | A national public holiday observed across the entire country |
| `Bank` | A bank/government holiday — offices close, but not all businesses |
| `Religious` | A religious or observance-based holiday |
| `National` | A national/independence/republic day |
| `Observance` | A commemoration or remembrance day |

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
| `SubRegion` | `string` | UN M49 sub-region (e.g. "Southern Asia", "Western Europe") |
| `Demonym` | `string` | Demonym — what residents are called (e.g. "Pakistani", "American") |
| `TLD` | `string` | Country-code top-level domain (e.g. ".pk", ".us") |
| `Currency` | `Currency?` | Full currency object (null for territories with no currency) |
| `CurrencyCode` | `string` | ISO 4217 code derived from `Currency` |
| `OfficialLanguages` | `IReadOnlyList<Language>` | Official languages of the country |
| `Holidays` | `IReadOnlyList<Holiday>` | Public holidays observed in this country |
| `Flag` | `string` | Unicode flag emoji |

| Method | Returns | Throws | Description |
|---|---|---|---|
| `GetCountry(string)` | `Country` | `CountryNotFoundException`, `ArgumentNullException` | Strict lookup by alpha-2, alpha-3, numeric code, or name |
| `GetCountryOrDefault(string)` | `Country?` | — | Safe lookup; returns `null` if not found |
| `IsValid(string)` | `bool` | — | Check if identifier maps to a known country |
| `GetAll()` | `List<Country>` | — | All 250 countries |

| Method | Returns | Description |
|---|---|---|
| `GetHolidaysByType(HolidayType)` | `IReadOnlyList<Holiday>` | Filter holidays by type |
| `IsPublicHoliday(DateTime)` | `bool` | Check if date falls on any holiday |
| `GetHolidayOnDate(DateTime)` | `Holiday?` | Get the holiday on a given date, or null |

### Currency

| Property / Method | Returns | Description |
|---|---|---|
| `Name` | `string` | Currency name |
| `Code` | `string` | ISO 4217 alphabetic code |
| `Number` | `int` | ISO 4217 numeric code |
| `Symbol` | `string` | Currency symbol |

| Method | Returns | Throws | Description |
|---|---|---|---|
| `GetCurrency(string)` | `Currency` | `CurrencyNotFoundException`, `ArgumentNullException` | Strict lookup by code or name |
| `GetCurrency(int)` | `Currency` | `CurrencyNotFoundException` | Strict lookup by ISO numeric code |
| `GetCurrencyOrDefault(string)` | `Currency?` | — | Safe lookup by code or name |
| `GetCurrencyOrDefault(int)` | `Currency?` | — | Safe lookup by numeric code |
| `IsValid(string)` | `bool` | — | Check if code/name maps to a known currency |
| `IsValid(int)` | `bool` | — | Check if numeric code maps to a known currency |
| `GetAll()` | `List<Currency>` | — | All 150+ currencies |

### Language

| Property / Method | Returns | Description |
|---|---|---|
| `Name` | `string` | Language name (may include alternates) |
| `Alpha2Code` | `string` | ISO 639-1 code (2-letter, may be empty) |
| `Alpha3Code` | `string` | ISO 639-2 code (3-letter) |

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
| `GetAll()` | `List<Country>` | Returns a new list of all 250 countries, ordered by name |
| `Alpha2CodeMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by ISO 3166-1 alpha-2 code (case-insensitive keys) |
| `Alpha3CodeMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by ISO 3166-1 alpha-3 code (case-insensitive keys) |
| `NumericCodeMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by ISO 3166-1 numeric code |
| `NameMap` | `IReadOnlyDictionary<string, Country>` | O(1) lookup by country name (case-insensitive keys) |
| `Pakistan`, `France`, ... | `Country` | 250 static readonly fields — one per country |

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

---

## Testing

The project includes a comprehensive test suite with **312 unit tests** covering every public API, edge case, and data integrity check across the entire library.

### Running Tests

```bash
dotnet test
```

### Test Structure

| Test Class | Tests | Covers |
|---|---|---|
| `CountryTests` | 119 | `Country` API, `CountryHelper` maps, SubRegion, Demonym, TLD, data integrity across all 250 countries |
| `CurrencyTests` | 56 | `Currency` API (string & int overloads), `CurrencyHelper` maps, data integrity |
| `LanguageTests` | 42 | `Language` API, `LanguageHelper` maps, data integrity |
| `ExceptionTests` | 19 | All three custom exception types — constructors, inheritance, and throw behavior |
| `HolidayTests` | 76 | `Holiday` model, `HolidayType` enum, `Country.Holidays`, filtering, date checks, data integrity |

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

### Test Dependencies

| Package | Purpose |
|---|---|
| [xUnit](https://xunit.net/) | Test framework |
| [FluentAssertions](https://fluentassertions.com/) | Assertion library |
| [NSubstitute](https://nsubstitute.github.io/) | Mocking framework |

---

## Contributing

Contributions, issues, and feature requests are welcome! Feel free to open an issue or submit a pull request on the [GitHub repository](https://github.com/Mwaseemzakir/Multiverse.Globalization).

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/my-feature`)
3. Commit your changes (`git commit -m "Add my feature"`)
4. Push to the branch (`git push origin feature/my-feature`)
5. Open a Pull Request

---

## License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

Copyright &copy; 2023 Muhammad Waseem


