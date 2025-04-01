# [Multiverse]()

[![NuGet](https://img.shields.io/nuget/v/Multiverse.svg)](https://www.nuget.org/packages/Multiverse/)
[![NuGet](https://img.shields.io/nuget/dt/Multiverse.svg)](https://www.nuget.org/packages/Multiverse/)


### About

This NuGet package provides comprehensive language codes, country codes, and currency codes from around the globe, making it an essential tool for internationalization and localization in .NET projects.

### Key Features

- Get the list of all countries, languages, and currencies in the world
- Get the ISO Codes (Alpha2, Alpha3)
- Support for internationalization and localization

### How to use

Get all counries:
```
IEnumerable<Country> countries = Country.GetAll();
```

To check is it valid country code :

```
bool isValidAlpha2Code = Country.IsValidAlpha2Code(code);

bool isValidAlpha3Code = Country.IsValidAlpha3Code(code);

bool isValidNumericCode =Country.IsValidNumericCode(code);
```

Get all languages:
```
IEnumerable<Language> languages = Language.GetAll();
```