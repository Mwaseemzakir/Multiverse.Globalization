using static Multiverse.Globalization.Languages.LanguageHelper;

namespace Multiverse.Globalization.Languages;

/// <summary>
/// Represents an ISO 639 language with its alpha-2/alpha-3 codes, name, and extended data.
/// </summary>
public sealed class Language
{
    /// <summary>Full English name of the language.</summary>
    public string Name { get; }
    /// <summary>ISO 639-1 two-letter language code, e.g. "en", "fr".</summary>
    public string Alpha2Code { get; }
    /// <summary>ISO 639-2/T three-letter language code, e.g. "eng", "fra".</summary>
    public string Alpha3Code { get; }

    /// <summary>Native name of the language, e.g. "Deutsch" for German, "العربية" for Arabic.</summary>
    public string NativeName { get; private set; } = string.Empty;

    /// <summary>Primary writing script, e.g. "Latin", "Arabic", "Cyrillic", "Devanagari", "Han".</summary>
    public string Script { get; private set; } = string.Empty;

    /// <summary>Text direction of the language (LeftToRight or RightToLeft).</summary>
    public TextDirection TextDirection { get; private set; } = TextDirection.LeftToRight;

    internal void SetExtendedData(string nativeName, string script, TextDirection direction)
    {
        NativeName = nativeName;
        Script = script;
        TextDirection = direction;
    }

    internal Language(
        string alpha2Code,
        string alpha3Code,
        string name)
    {
        Name = name;
        Alpha2Code = alpha2Code;
        Alpha3Code = alpha3Code;
    }

    /// <summary>
    /// Retrieves a Language object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, or the name of the language. Returns null if not found.
    /// </summary>
    public static Language? GetLanguageOrDefault(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return null;

        identifier = identifier.ToLowerInvariant();

        if (Alpha2CodeMap.TryGetValue(identifier, out var byAlpha2))
            return byAlpha2;

        if (Alpha3CodeMap.TryGetValue(identifier, out var byAlpha3))
            return byAlpha3;

        if (NameMap.TryGetValue(identifier, out var byName))
            return byName;

        return null;
    }

    /// <summary>
    /// Retrieves a Language object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, or the name of the language. Throws an exception if not found.
    /// </summary>
    public static Language GetLanguage(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentNullException(nameof(identifier));

        return GetLanguageOrDefault(identifier)
            ?? throw new LanguageNotFoundException($"Language with identifier '{identifier}' was not found.");
    }

    /// <summary>
    /// Validates if the provided identifier corresponds to a known language, which can be an Alpha-2 code, 
    /// Alpha-3 code, or the name of the language.
    /// </summary>
    public static bool IsValid(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return false;

        identifier = identifier.ToLowerInvariant();
        return Alpha2CodeMap.ContainsKey(identifier) ||
               Alpha3CodeMap.ContainsKey(identifier) ||
               NameMap.ContainsKey(identifier);
    }

    /// <summary>
    /// Retrieves a list of all available Language objects.
    /// </summary>
    public static IReadOnlyList<Language> GetAll() => LanguageHelper.GetAll();

    /// <inheritdoc />
    public override string ToString() => $"{Name} ({Alpha3Code})";

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Language other && Alpha3Code == other.Alpha3Code;

    /// <inheritdoc />
    public override int GetHashCode() => Alpha3Code.GetHashCode();
}
