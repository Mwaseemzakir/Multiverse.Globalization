# Data sources and coverage

Multiverse is an offline, hand-maintained reference-data library. Code and data are reviewed
against authoritative or primary sources where practical, but the current dataset does not yet
retain row-level provenance or an independently verified “accurate as of” date. Consumers should
therefore treat changing values such as population, holiday observance, UTC offsets, political
status, and phone numbering rules as reference data rather than real-time authority.

## Reference sources

| Dataset | Primary reference |
|---|---|
| Country/area names, numeric codes and regions | [United Nations M49](https://unstats.un.org/unsd/methodology/m49/) |
| ISO alpha codes and assignment status | [ISO 3166](https://www.iso.org/iso-3166-country-codes.html) |
| Time-zone identifiers and rules | [IANA Time Zone Database](https://www.iana.org/time-zones) |
| International calling and numbering information | [ITU-T E.164](https://www.itu.int/rec/T-REC-E.164/) |
| Locale conventions and translated territory names | [Unicode CLDR](https://cldr.unicode.org/) |

These links identify the standards used for review; they do not imply endorsement. Source
licenses and terms must be checked before importing or redistributing source datasets verbatim.

## Catalog scope

- 249 current ISO 3166-1 country/area records.
- 1 formerly assigned compatibility record: Netherlands Antilles (`AN`/`ANT`).
- `Country.GetAll()` also includes the `CountryHelper.None` sentinel for backward compatibility.
- `XK` is a widely used user-assigned code for Kosovo. It is supplemental data in selected maps
  (time zones, locales, and translations), not an ISO 3166-1 `Country` record.

## Current keyed coverage

| Dataset | Codes with explicit records |
|---|---:|
| Fixed-date holidays | 213 |
| Movable holidays | 48 |
| Time zones | 251, including supplemental `XK` |
| Electrical systems | 247 |
| Emergency numbers | 250 |
| Phone formats | 233 |
| Locales | 251, including supplemental `XK` |
| Country-name translations | 251, including supplemental `XK` |
| First-level subdivisions | 59 |
| Weekend deviations | 22 (all other countries default to Saturday–Sunday) |
| Substitute-day rules | 13 (all other countries observe holidays on their calendar date) |

Missing data is returned as an empty collection or `null`, depending on the API. A missing record
must not be interpreted as proof that a country has no holidays, phone service, subdivisions, or
electrical system.

## Time-zone accuracy

`CountryTimeZone.UtcOffset` and `ObservesDst` are bundled standard-offset/support snapshots. They
are not a replacement for IANA transition rules. Use `GetUtcOffset(instant)` and
`IsDaylightSavingTime(instant)` for date-aware results; those methods resolve the time-zone rules
installed on the host operating system.

## Weekends

`Country.WeekendDays` defaults to Saturday–Sunday and stores only the countries that deviate, in
`WeekendHelper.Exceptions`. Coverage is the well-established national conventions: the
Friday–Saturday weekend across much of the Middle East and North Africa, Friday-only in Iran,
Saturday-only in Nepal, and Brunei's split Friday-and-Sunday weekend.

Known limitations:

- The UAE moved to a Saturday–Sunday weekend in January 2022 and therefore carries no exception
  entry. Countries that change their working week will lag until the dataset is refreshed.
- Sub-national variation is not modelled. Four Malaysian states keep a Friday–Saturday weekend
  while the federal weekend is Saturday–Sunday, and India's public sector observes a Sunday-only
  weekend against a private-sector norm of Saturday–Sunday. Both take the national default.
- Half-days (Friday in the UAE, Saturday in Hong Kong) are not represented; a day is either a
  working day or it is not.

## Substitute days

`Country.ObservanceRule` records how a country moves a public holiday that lands on a weekend, and
defaults to `None`. `NearestWorkingDay` (Saturday back to Friday, Sunday forward to Monday) is the
US federal rule; `NextWorkingDay` covers the "bank holiday in lieu" convention in the UK, Ireland,
Australia, New Zealand, Canada, Japan, Singapore, Hong Kong, Malaysia, South Africa, Kenya, and
Nigeria.

Known limitations:

- The rule is applied uniformly to every holiday in a country. Real substitution law is often
  per-holiday — not every US federal holiday shifts identically at state level.
- Ad-hoc bridge days and one-off government proclamations (common in the Philippines, Indonesia,
  and India) are not modelled.
- `HolidayType.Observance` entries are treated as commemorations rather than days off, so they
  neither shift nor count against working-day arithmetic.

## Holiday name collisions

Several countries list the same holiday both as a fixed date — a snapshot of one particular year —
and as a movable rule. `Country.GetHolidays(int)` resolves this by dropping the fixed entry when a
movable holiday of the same name exists, since the rule reproduces the correct date in any year.
The raw `Country.Holidays` and `Country.MovableHolidays` collections are unaffected.

Future data imports should record, at minimum, source URL, source version, retrieval date,
effective date, transformation version, and per-record review status.
