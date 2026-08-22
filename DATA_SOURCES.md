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

Missing data is returned as an empty collection or `null`, depending on the API. A missing record
must not be interpreted as proof that a country has no holidays, phone service, subdivisions, or
electrical system.

## Time-zone accuracy

`CountryTimeZone.UtcOffset` and `ObservesDst` are bundled standard-offset/support snapshots. They
are not a replacement for IANA transition rules. Use `GetUtcOffset(instant)` and
`IsDaylightSavingTime(instant)` for date-aware results; those methods resolve the time-zone rules
installed on the host operating system.

Future data imports should record, at minimum, source URL, source version, retrieval date,
effective date, transformation version, and per-record review status.
