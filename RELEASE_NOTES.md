## Extended Country Data, Multi-Framework Support & Test Reorganization

### Multi-Framework Support
- Added .NET 6.0, .NET 7.0, and .NET 9.0 targets alongside existing .NET 8.0, .NET Standard 2.0, and .NET Framework 4.6.2
- Now targets: `net9.0`, `net8.0`, `net7.0`, `net6.0`, `netstandard2.0`, `net462`
- FrozenDictionary optimization on .NET 8+ with automatic fallback to Dictionary on earlier frameworks

### Geographic Data (250 countries)
- Country.Population — approximate population count
- Country.AreaInSquareKilometers — total area in km²
- Country.CapitalCoordinates — latitude/longitude of the capital city (GeoCoordinate model)
- Country.BorderingCountries — ISO alpha-2 codes of neighboring countries
- Country.IsLandlocked — whether the country has no coastline

### Political Data (250 countries)
- Country.IsUnMember — whether the country is a United Nations member
- Country.IndependenceDate — date of independence (null for territories)

### Transport Data (250 countries)
- Country.DrivingSide — Left or Right (DrivingSide enum)
- Country.SpeedUnit — "km/h" or "mph"

### Electrical Systems (250 countries)
- Country.ElectricalSystem — voltage, frequency & plug types
- ElectricalSystem model with Voltage, Frequency, PlugTypes
- PlugType enum covering all international plug standards (A through O)

### Emergency Numbers (250 countries)
- Country.EmergencyNumbers — emergency telephone numbers (e.g. 911, 112, 999)

### Phone Formats (250 countries)
- Country.PhoneFormat — phone number format information
- PhoneFormat model with CallingCode, TrunkPrefix, PhoneNumberLengths

### Locale & Formatting (250 countries)
- Country.Locale — locale and formatting conventions
- CountryLocale model with DateFormat, NumberDecimalSeparator, NumberGroupSeparator, MeasurementSystem, PostalCodeFormat
- MeasurementSystem enum (Metric, Imperial, USCustomary)

### Country Translations (250 countries)
- Country.Translations — country name in 10+ languages (fr, es, de, ar, zh, ja, ru, pt, it, ko, hi)
- Country.GetNameInLanguage(string) — get country name in a specific language

### Subdivisions (50+ countries)
- Country.Subdivisions — ISO 3166-2 first-level administrative subdivisions
- Subdivision model with Code, Name, Type
- SubdivisionHelper with data for 50+ countries (states, provinces, regions, cantons, etc.)

### Movable Holidays (40+ countries)
- Country.MovableHolidays — holidays with dates that vary by year (Easter, Thanksgiving, etc.)
- MovableHoliday model with Name, GetDate(year), IsOnDate(date)
- Country.GetAllHolidaysOnDate(date) — combined check for fixed + movable holidays
- Easter computation via Computus algorithm
- NthWeekdayOfMonth, LastWeekdayOfMonth, LastWeekdayBefore helper methods

### Currency Extensions
- Currency.DecimalPlaces — minor units (0 for JPY, 2 for USD/EUR, 3 for KWD/BHD)
- Currency.GetCountriesUsingCurrency() — reverse lookup of all countries using this currency

### Language Extensions
- Language.NativeName — native name of the language (e.g. "Deutsch", "العربية", "中文")
- Language.Script — primary writing script (e.g. "Latin", "Arabic", "Cyrillic", "Han")
- Language.TextDirection — LeftToRight or RightToLeft (TextDirection enum)

### Alternative TLDs
- Country.AlternativeTlds — additional country-code TLDs (e.g. ".uk" for GB alongside ".gb")

### Test Reorganization (SRP)
- Split monolithic ExtendedFeaturesTests.cs into 13 focused test files following Single Responsibility Principle
- GeographicDataTests, PoliticalDataTests, TransportDataTests, ElectricalSystemTests, EmergencyNumberTests, PhoneFormatTests, LocaleTests, TranslationTests, SubdivisionTests, MovableHolidayTests, CurrencyExtendedTests, LanguageExtendedTests, CountryIntegrationTests
- 692 total unit tests, 0 failures, 0 warnings

---

## Time Zones

- Time Zones — IANA Time Zone Database support for all 250 countries & territories
- CountryTimeZone model with IanaId, UtcOffsetHours, ObservesDst, UtcOffset, UtcOffsetString, ToString()
- TimeZoneHelper.All — complete dictionary of alpha-2 codes to time zone lists
- Country.TimeZones — IANA time zones for the country, accessed directly from the Country object
- Country.HasMultipleTimeZones — whether the country spans more than one time zone
- Country.GetPrimaryTimeZone() — capital-city / primary time zone
- Country.GetTimeZonesWithDst() — filter to DST-observing zones
- Country.GetUtcOffsets() — distinct UTC offsets across all zones
- Fractional UTC offsets supported (e.g. +5:30 India, +5:45 Nepal, -3:30 Newfoundland)
- DST flagged per zone (e.g. US Eastern = DST, Hawaii = no DST)
- Multi-zone countries: US (7), Russia (11), Canada (7), Australia (8), Brazil (8), Antarctica (10), and more

## Time Zones, Holidays, SubRegion, Demonym & TLD

- Holidays support — fixed-date public holidays for 190+ countries, accessible via Country.Holidays
- Holiday model with Name, Month, Day, Type, Date, GetDate(), IsOnDate(), ToString()
- HolidayType enum: Public, Bank, Religious, National, Observance
- HolidayHelper.All — complete dictionary of alpha-2 codes to holiday lists
- Country methods: GetHolidaysByType(), IsPublicHoliday(), GetHolidayOnDate()
- SubRegion — UN M49 sub-region for every country (e.g. Southern Asia, Western Europe)
- Demonym — what residents of each country are called (e.g. Pakistani, American)
- TLD — country-code top-level domain for every country (e.g. .pk, .us, .jp)
- 312 unit tests covering holidays, SubRegion, Demonym, TLD, and all existing APIs
- 98 additional unit tests for time zones (410 total)

## Country-Centric Architecture

- Country-centric design — Country is now the central entity carrying Currency and OfficialLanguages
- Official Languages — each country carries its official languages
- Flag emoji — Country.Flag property returns the Unicode flag emoji
- Dictionary maps — pre-built Alpha2CodeMap, Alpha3CodeMap, NumericCodeMap, NameMap for O(1) lookups
- OrDefault variants — GetCountryOrDefault(), GetCurrencyOrDefault(), GetLanguageOrDefault()
- Validation methods — IsValid() on Country, Currency, and Language
- Multi-targeting — supports net9.0, net8.0, net7.0, net6.0, netstandard2.0, and net462

## Initial Release

- 250 countries and territories — ISO 3166-1 (alpha-2, alpha-3, numeric) with capitals, regions, and E.164 calling codes
- 150+ currencies — ISO 4217 (code, numeric, symbol)
- 475+ languages — ISO 639-1 (alpha-2) and ISO 639-2 (alpha-3)
- Static helper classes — CountryHelper, CurrencyHelper, LanguageHelper with compile-time access
- Custom exceptions — CountryNotFoundException, CurrencyNotFoundException, LanguageNotFoundException
- Zero dependencies — no third-party packages required
- Immutable and thread-safe — all data is readonly singletons
