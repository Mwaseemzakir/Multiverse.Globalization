## Holidays, SubRegion, Demonym & TLD

- Holidays support — fixed-date public holidays for 190+ countries, accessible via Country.Holidays
- Holiday model with Name, Month, Day, Type, Date, GetDate(), IsOnDate(), ToString()
- HolidayType enum: Public, Bank, Religious, National, Observance
- HolidayHelper.All — complete dictionary of alpha-2 codes to holiday lists
- Country methods: GetHolidaysByType(), IsPublicHoliday(), GetHolidayOnDate()
- SubRegion — UN M49 sub-region for every country (e.g. Southern Asia, Western Europe)
- Demonym — what residents of each country are called (e.g. Pakistani, American)
- TLD — country-code top-level domain for every country (e.g. .pk, .us, .jp)
- 312 unit tests covering holidays, SubRegion, Demonym, TLD, and all existing APIs

## Country-Centric Architecture

- Country-centric design — Country is now the central entity carrying Currency and OfficialLanguages
- Official Languages — each country carries its official languages
- Flag emoji — Country.Flag property returns the Unicode flag emoji
- Dictionary maps — pre-built Alpha2CodeMap, Alpha3CodeMap, NumericCodeMap, NameMap for O(1) lookups
- OrDefault variants — GetCountryOrDefault(), GetCurrencyOrDefault(), GetLanguageOrDefault()
- Validation methods — IsValid() on Country, Currency, and Language
- Multi-targeting — supports net8.0, netstandard2.0, and net462

## Initial Release

- 250 countries and territories — ISO 3166-1 (alpha-2, alpha-3, numeric) with capitals, regions, and E.164 calling codes
- 150+ currencies — ISO 4217 (code, numeric, symbol)
- 475+ languages — ISO 639-1 (alpha-2) and ISO 639-2 (alpha-3)
- Static helper classes — CountryHelper, CurrencyHelper, LanguageHelper with compile-time access
- Custom exceptions — CountryNotFoundException, CurrencyNotFoundException, LanguageNotFoundException
- Zero dependencies — no third-party packages required
- Immutable and thread-safe — all data is readonly singletons
