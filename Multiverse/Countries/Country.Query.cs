namespace Multiverse.Globalization.Countries;

/// <summary>
/// Filtering, searching, and geographic queries over the country catalog.
/// </summary>
/// <remarks>
/// Every static query here runs over <see cref="GetCurrent"/> — the 249 currently assigned
/// ISO 3166-1 records — so the <c>None</c> sentinel and formerly assigned codes never turn up
/// in results. Query <see cref="GetAll"/> directly if you need those.
/// </remarks>
public sealed partial class Country
{
    /// <summary>Mean radius of the Earth in kilometres, used for great-circle distances.</summary>
    private const double EarthRadiusKm = 6371.0088;

    /// <summary>Edit distance still treated as a plausible typo when searching by name.</summary>
    private const int MaxSearchEditDistance = 2;

    // ── Filters ─────────────────────────────────────────────────────

    /// <summary>
    /// Returns every country in the given region, e.g. "Europe", "Asia", "Americas",
    /// "Africa", "Oceania". Matching is case-insensitive.
    /// </summary>
    public static IReadOnlyList<Country> InRegion(string region)
    {
        if (string.IsNullOrWhiteSpace(region))
            return [];

        return GetCurrent()
            .Where(c => string.Equals(c.Region, region.Trim(), StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Returns every country in the given sub-region, e.g. "Western Europe", "Southern Asia".
    /// Matching is case-insensitive.
    /// </summary>
    public static IReadOnlyList<Country> InSubRegion(string subRegion)
    {
        if (string.IsNullOrWhiteSpace(subRegion))
            return [];

        return GetCurrent()
            .Where(c => string.Equals(c.SubRegion, subRegion.Trim(), StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Returns every country whose primary currency is the given one, identified by
    /// ISO 4217 code or name, e.g. "EUR" or "Euro".
    /// </summary>
    public static IReadOnlyList<Country> UsingCurrency(string currencyIdentifier)
    {
        if (string.IsNullOrWhiteSpace(currencyIdentifier))
            return [];

        var currency = Currency.GetCurrencyOrDefault(currencyIdentifier);

        if (currency is null)
            return [];

        return GetCurrent()
            .Where(c => c.Currency != null && c.Currency.Code == currency.Code)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Returns every country that has the given language among its official languages,
    /// identified by ISO 639 alpha-2 code, alpha-3 code, or name, e.g. "fr", "fra", "French".
    /// </summary>
    public static IReadOnlyList<Country> SpeakingLanguage(string languageIdentifier)
    {
        if (string.IsNullOrWhiteSpace(languageIdentifier))
            return [];

        var language = Language.GetLanguageOrDefault(languageIdentifier);

        if (language is null)
            return [];

        return GetCurrent()
            .Where(c => c.OfficialLanguages.Any(l => l.Alpha3Code == language.Alpha3Code))
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Returns every country sharing the given E.164 calling code, with or without the leading
    /// plus, e.g. "+1" or "1" returns the whole North American Numbering Plan.
    /// </summary>
    public static IReadOnlyList<Country> WithCallingCode(string callingCode)
    {
        if (string.IsNullOrWhiteSpace(callingCode))
            return [];

        var normalized = callingCode.Trim().TrimStart('+');

        return GetCurrent()
            .Where(c => c.CallingCode.TrimStart('+') == normalized)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Returns every country that observes the given day as part of its weekend.
    /// </summary>
    public static IReadOnlyList<Country> WithWeekendDay(DayOfWeek day)
    {
        return GetCurrent()
            .Where(c => c.WeekendDays.Contains(day))
            .ToList()
            .AsReadOnly();
    }

    // ── Search ──────────────────────────────────────────────────────

    /// <summary>
    /// Searches the catalog by name, ISO code, alias, or capital city, tolerating minor
    /// misspellings — "USA" and "united states" both find the US, "germny" still finds Germany,
    /// and "Tokyo" finds Japan. Results are ordered best match first.
    /// </summary>
    /// <param name="term">The search term. Case and surrounding whitespace are ignored.</param>
    /// <param name="maxResults">Maximum number of results to return.</param>
    public static IReadOnlyList<Country> Search(string term, int maxResults = 10)
    {
        if (maxResults < 1)
            throw new ArgumentOutOfRangeException(nameof(maxResults), "Maximum results must be at least 1.");

        if (string.IsNullOrWhiteSpace(term))
            return [];

        var needle = term.Trim().ToLowerInvariant();

        var scored = new List<(Country Country, int Score)>();

        foreach (var country in GetCurrent())
        {
            var score = ScoreMatch(country, needle);

            if (score < int.MaxValue)
                scored.Add((country, score));
        }

        return scored
            .OrderBy(x => x.Score)
            .ThenBy(x => x.Country.Name, StringComparer.OrdinalIgnoreCase)
            .Take(maxResults)
            .Select(x => x.Country)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Ranks how well a country answers a search term: lower is better, and
    /// <see cref="int.MaxValue"/> means no match at all.
    /// </summary>
    private static int ScoreMatch(Country country, string needle)
    {
        var name = country.Name.ToLowerInvariant();

        // An exact code or name is unambiguous and always wins.
        if (name == needle ||
            country.Alpha2Code.ToLowerInvariant() == needle ||
            country.Alpha3Code.ToLowerInvariant() == needle ||
            country.NumericCode == needle)
            return 0;

        if (CountryHelper.NameAliases.TryGetValue(needle, out var aliasAlpha2) &&
            string.Equals(aliasAlpha2, country.Alpha2Code, StringComparison.OrdinalIgnoreCase))
            return 1;

        if (name.StartsWith(needle, StringComparison.Ordinal))
            return 2;

        if (name.IndexOf(needle, StringComparison.Ordinal) >= 0)
            return 3;

        if (country.Capital.Length > 0 &&
            country.Capital.ToLowerInvariant().IndexOf(needle, StringComparison.Ordinal) >= 0)
            return 4;

        // Fall back to edit distance so a typo still lands on the right country.
        var distance = EditDistance(name, needle);

        return distance <= MaxSearchEditDistance
            ? 5 + distance
            : int.MaxValue;
    }

    /// <summary>
    /// Levenshtein distance between two strings, computed with a rolling pair of rows so the
    /// whole catalog can be scored without allocating a full matrix per comparison.
    /// </summary>
    private static int EditDistance(string source, string target)
    {
        if (source.Length == 0)
            return target.Length;

        if (target.Length == 0)
            return source.Length;

        var previous = new int[target.Length + 1];
        var current = new int[target.Length + 1];

        for (var j = 0; j <= target.Length; j++)
            previous[j] = j;

        for (var i = 1; i <= source.Length; i++)
        {
            current[0] = i;

            for (var j = 1; j <= target.Length; j++)
            {
                var substitutionCost = source[i - 1] == target[j - 1] ? 0 : 1;

                current[j] = Math.Min(
                    Math.Min(current[j - 1] + 1, previous[j] + 1),
                    previous[j - 1] + substitutionCost);
            }

            (current, previous) = (previous, current);
        }

        return previous[target.Length];
    }

    // ── Geography ───────────────────────────────────────────────────

    /// <summary>
    /// Resolves <see cref="BorderingCountries"/> from alpha-2 codes into the countries themselves.
    /// Returns an empty list for island nations.
    /// </summary>
    public IReadOnlyList<Country> GetBorderingCountries()
    {
        if (BorderingCountries.Count == 0)
            return [];

        var neighbours = new List<Country>(BorderingCountries.Count);

        foreach (var code in BorderingCountries)
        {
            var neighbour = GetCountryOrDefault(code);

            if (neighbour != null)
                neighbours.Add(neighbour);
        }

        return neighbours.AsReadOnly();
    }

    /// <summary>
    /// Great-circle distance in kilometres between this country's capital and another's.
    /// Returns null when either capital has no coordinates on record.
    /// </summary>
    public double? DistanceTo(Country other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        if (CapitalCoordinates is null || other.CapitalCoordinates is null)
            return null;

        return HaversineKm(
            CapitalCoordinates.Latitude, CapitalCoordinates.Longitude,
            other.CapitalCoordinates.Latitude, other.CapitalCoordinates.Longitude);
    }

    /// <summary>
    /// Returns the countries whose capitals lie closest to the given coordinates, nearest first.
    /// Countries with no capital coordinates on record are skipped.
    /// </summary>
    /// <param name="latitude">Latitude in decimal degrees (-90 to 90).</param>
    /// <param name="longitude">Longitude in decimal degrees (-180 to 180).</param>
    /// <param name="count">How many countries to return.</param>
    public static IReadOnlyList<Country> NearestTo(double latitude, double longitude, int count = 1)
    {
        if (latitude < -90 || latitude > 90)
            throw new ArgumentOutOfRangeException(nameof(latitude), "Latitude must be between -90 and 90.");

        if (longitude < -180 || longitude > 180)
            throw new ArgumentOutOfRangeException(nameof(longitude), "Longitude must be between -180 and 180.");

        if (count < 1)
            throw new ArgumentOutOfRangeException(nameof(count), "Count must be at least 1.");

        return GetCurrent()
            .Where(c => c.CapitalCoordinates != null)
            .OrderBy(c => HaversineKm(
                latitude, longitude,
                c.CapitalCoordinates!.Latitude, c.CapitalCoordinates.Longitude))
            .Take(count)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>Great-circle distance in kilometres between two points on the Earth.</summary>
    private static double HaversineKm(double lat1, double lon1, double lat2, double lon2)
    {
        var dLat = ToRadians(lat2 - lat1);
        var dLon = ToRadians(lon2 - lon1);

        var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        return EarthRadiusKm * 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
    }

    private static double ToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }
}