# Multiverse.Globalization

[![NuGet](https://img.shields.io/nuget/v/Multiverse.svg)](https://www.nuget.org/packages/Multiverse/)
[![NuGet](https://img.shields.io/nuget/dt/Multiverse.svg)](https://www.nuget.org/packages/Multiverse/)

**Multiverse.Globalization** is a powerful and comprehensive .NET library designed to simplify internationalization. It provides robust support for **languages, countries, and currencies**, making it an essential tool for any globalized application.

With **Multiverse.Globalization**, you gain access to:
- **ISO 639-1 & ISO 639-2 language codes**
- **ISO 3166-1 country codes**
- **ISO 4217 currency codes**
- **Seamless validation, lookup, and retrieval**
- **A complete set of global language, country, and currency data**

## 🚀 Features

- 🔹 **Comprehensive ISO support** for Language, Country, and Currency standards
- 🔹 **Case-insensitive validation** for better usability
- 🔹 **Effortless lookup** of codes, names, and symbols
- 🔹 **Retrieve full lists** of world languages, countries, and currencies
- 🔹 **Support for localization and internationalization** in .NET applications

## 📦 Installation

To install via NuGet Package Manager:

```bash
dotnet add package Multiverse.Globalization
```

## 🔧 Usage

### 🌎 Language Handling

Easily work with **language codes and names**:

```csharp
using Multiverse.Globalization.Languages;

// Get language details by its Alpha-2 code
var english = Language.GetLanguage("en");
Console.WriteLine(english.Name); // Output: English
Console.WriteLine(english.Alpha3Code); // Output: eng

// Validate language codes
bool isValid = Language.IsValid("fr"); // Returns true (French)
bool isInvalid = Language.IsValid("xx"); // Returns false

// Retrieve all available languages
var allLanguages = Language.GetAll();
foreach (var lang in allLanguages)
{
    Console.WriteLine($"{lang.Name} ({lang.Alpha2Code})");
}
```

### 🏳️ Country Handling

Effortlessly manage **country codes and information**:

```csharp
using Multiverse.Globalization.Countries;

// Retrieve country details using Alpha-2 code
var usa = Country.GetCountry("US");
Console.WriteLine(usa.Name); // Output: United States
Console.WriteLine(usa.Alpha3Code); // Output: USA

// Validate country codes
bool isValid = Country.IsValid("GB"); // Returns true (United Kingdom)
bool isInvalid = Country.IsValid("XX"); // Returns false

// Get all countries
var allCountries = Country.GetAll();
foreach (var country in allCountries)
{
    Console.WriteLine($"{country.Name} ({country.Alpha2Code})");
}
```

### 💰 Currency Handling

Seamlessly integrate **currency codes and symbols**:

```csharp
using Multiverse.Globalization.Currencies;

// Retrieve currency details using currency code
var usd = Currency.GetCurrency("USD");
Console.WriteLine(usd.Name); // Output: US Dollar
Console.WriteLine(usd.Symbol); // Output: $

// Validate currency codes
bool isValid = Currency.IsValid("EUR"); // Returns true (Euro)
bool isInvalid = Currency.IsValid("XXX"); // Returns false

// Get all currencies
var allCurrencies = Currency.GetAll();
foreach (var currency in allCurrencies)
{
    Console.WriteLine($"{currency.Name} ({currency.Code})");
}
```

## 🔑 Key Features Breakdown

### 🌍 Language Features
- ✅ Supports **ISO 639-1 & ISO 639-2 codes**
- ✅ Case-insensitive language validation
- ✅ Lookup by **code or name**
- ✅ Comprehensive list of world languages

### 🏴 Country Features
- ✅ Supports **ISO 3166-1 Alpha-2 & Alpha-3 codes**
- ✅ Country **name validation & lookup**
- ✅ Retrieve the **complete list of recognized countries**

### 💲 Currency Features
- ✅ Supports **ISO 4217 currency codes**
- ✅ Retrieve **currency symbols & names**
- ✅ Currency code **validation & lookup**
- ✅ Get the **full list of global currencies**

## 📌 Best Practices

### 1️⃣ Always Validate Before Use
```csharp
if (Language.IsValid(code))
{
    var language = Language.GetLanguage(code);
    // Process language
}
```

### 2️⃣ Safe Lookups with Defaults
```csharp
var language = Language.GetLanguageOrDefault(code);
if (language != null)
{
    // Process language
}
```

### 3️⃣ Handle Exceptions Gracefully
```csharp
try
{
    var language = Language.GetLanguage(code);
    // Process language
}
catch (LanguageNotFoundException)
{
    // Handle missing language
}
```

## 📜 Requirements

- ✅ **.NET Standard 2.0+**
- ✅ **.NET Framework 4.6.2+**
- ✅ **.NET Core 2.0+**
- ✅ **.NET 5.0+**

## 📄 License

This project is licensed under the **MIT License**. See the LICENSE file for details.

## 🤝 Contributing

🚀 We welcome contributions! Feel free to **submit a pull request** or open an issue to help improve **Multiverse.Globalization**.

---

🔥 **Multiverse.Globalization - The Ultimate Globalization Toolkit for .NET Developers!**

