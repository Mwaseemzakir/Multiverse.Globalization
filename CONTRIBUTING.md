# Contributing to Multiverse

Thanks for your interest in improving Multiverse! Contributions of all sizes are welcome — from fixing a typo in the README to adding a new data field for all 250 countries.

## Getting Started

1. Fork the repository and clone your fork.
2. Open `Multiverse.sln` (Visual Studio, VS Code, or Rider all work) or build from the CLI:
   ```powershell
   dotnet restore
   dotnet build
   ```
3. Create a branch for your change:
   ```powershell
   git checkout -b feature/short-description
   ```

## Making Changes

- **Data changes** (countries, currencies, languages, holidays, etc.) live under `Multiverse/`. Keep entries alphabetically ordered where the surrounding code already does so.
- **Every change must include tests.** This project has 690+ unit tests in `Multiverse.UnitTests/` — new fields, lookups, or bug fixes should be covered there. PRs without test coverage for the behavior they change will be asked to add it.
- Keep the public API `Nullable`-clean and immutable (`readonly` singletons) — this is a core design principle of the library.
- If you add a new capability (e.g. a new data category), please also update the corresponding section of `README.md` so the docs stay in sync with the API.

## Running Tests

```powershell
dotnet test
```

## Submitting a Pull Request

1. Make sure `dotnet build` and `dotnet test` both pass locally.
2. Describe **what** changed and **why** in the PR description — for data corrections, please link a source (ISO standard, government publication, Wikipedia, etc.).
3. Add a short entry to `RELEASE_NOTES.md` under an "Unreleased" heading if one doesn't already exist.

## Reporting Bugs / Requesting Data

Found an incorrect value (wrong currency, missing holiday, outdated ISO code) or want a new field added? Please [open an issue](https://github.com/Mwaseemzakir/Multiverse/issues/new/choose) — data-accuracy reports are just as valuable as code contributions.

## Questions

Feel free to open an issue with the `question` label if anything here is unclear.
