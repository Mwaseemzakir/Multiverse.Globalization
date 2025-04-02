# Multiverse

[![NuGet](https://img.shields.io/nuget/v/Multiverse.svg)](https://www.nuget.org/packages/Multiverse/)
[![NuGet](https://img.shields.io/nuget/dt/Multiverse.svg)](https://www.nuget.org/packages/Multiverse/)

**Multiverse.Globalization** is a .NET library for internationalization, providing support for **languages, countries, and currencies**.

## Features
- **ISO 639-1 & ISO 639-2** language codes
- **ISO 3166-1** country codes
- **ISO 4217** currency codes
- **Validation, lookup, and retrieval**
- **Complete global dataset**

## Installation
```bash
dotnet add package Multiverse
```

## Usage

### 🌎 Language Handling
```csharp
using Multiverse.Globalization.Languages;

// Get by identifier (e.g. "en", "eng", or "English")
var english = Language.GetLanguage("en");

// Validate identifier
bool isValid = Language.IsValid("fr"); // true

// Get all languages
var allLanguages = Language.GetAll();
```

**Identifier**: `Name`, `Alpha2Code`, `Alpha3Code`

### 🏳️ Country Handling
```csharp
using Multiverse.Globalization.Countries;

// Get by identifier (e.g. "US", "USA", or "United States")
var usa = Country.GetCountry("US");

// Validate identifier
bool isValid = Country.IsValid("GB"); // true

// Get all countries
var allCountries = Country.GetAll();
```

**Identifier**: `Name`, `Alpha2Code`, `Alpha3Code`, `NumericCode`

### 💰 Currency Handling
```csharp
using Multiverse.Globalization.Currencies;

// Get by identifier (e.g. "USD", 840, or "US Dollar")
var usd = Currency.GetCurrency("USD");
Console.WriteLine(usd.Name); // US Dollar
Console.WriteLine(usd.Symbol); // $

// Validate identifier
bool isValid = Currency.IsValid("EUR"); // true

// Get all currencies
var allCurrencies = Currency.GetAll();
```

**Identifier**: `Name`, `Code`, `Number`

## Best Practices

### Validate Before Use
```csharp
if (Language.IsValid(identifier))
{
    var language = Language.GetLanguage(identifier);
}
```

### Safe Lookups
```csharp
var language = Language.GetLanguageOrDefault(identifier);

if (language != null)
{
    // Process language
}
```

### Exception Handling
```csharp
try
{
    var language = Language.GetLanguage(identifier);
}
catch (LanguageNotFoundException)
{
    // Handle missing language
}
```


