using Multiverse.Helpers;
using System.Collections.Generic;

namespace Multiverse.Languages;
public sealed class Language
{
    public static int Count => Alpha2Codes.Count;
    private static readonly IReadOnlyDictionary<string, Language> Alpha2Codes = LanguageHelpers.Alpha2CodeMap;
    private static readonly IReadOnlyDictionary<string, Language> Alpha3Codes = LanguageHelpers.Alpha3CodeMap;

    public string Name { get; private set; }
    public string Alpha2Code { get; private set; } = string.Empty;
    public string Alpha3Code { get; private set; } = string.Empty;

    internal Language(
        string alpha2Code,
        string alpha3Code,
        string name)
    {
        Name = name;
        Alpha2Code = alpha2Code;
        Alpha3Code = alpha3Code;
    }

    public static bool IsValidAlpha2Code(string code)
    {
        return !string.IsNullOrWhiteSpace(code) && Alpha2Codes.ContainsKey(code.ToUpperInvariant());
    }

    public static bool IsValidAlpha3Code(string code)
    {
        return !string.IsNullOrWhiteSpace(code) && Alpha3Codes.ContainsKey(code.ToUpperInvariant());
    }

    public static bool IsValidCode(string code)
    {
        return !string.IsNullOrWhiteSpace(code) &&
              (Alpha2Codes.ContainsKey(code.ToUpperInvariant()) 
              || Alpha3Codes.ContainsKey(code.ToUpperInvariant()) );
    }

    public static bool TryGetByAlpha2CodeOrDefault(
        string code,
        out Language? language)
    {
        if(string.IsNullOrWhiteSpace(code) || !IsValidAlpha2Code(code))
        {
            language = default;
            return false;
        }

        return Alpha2Codes.TryGetValue(code.ToUpperInvariant(), out language);
    }

    public static bool TryGetByAlpha3CodeOrDefault(
          string code,
          out Language? language)
    {
        if(string.IsNullOrWhiteSpace(code) || !IsValidAlpha3Code(code))
        {
            language = default;
            return false;
        }

        return Alpha3Codes.TryGetValue(code.ToUpperInvariant(), out language);
    }

    public static Language? GetByAlpha2CodeOrDefault(string code)
    {
        return IsValidAlpha2Code(code) ? Alpha2Codes[code.ToUpperInvariant()] : default;
    }

    public static Language? GetByAlpha3CodeOrDefault(string code)
    {
        return IsValidAlpha3Code(code) ? Alpha3Codes[code.ToUpperInvariant()] : default;
    }

    public static List<Language> GetAll() => LanguageHelpers.GetAll();

    public static IEnumerable<string> GetAlpha2Codes() => Alpha2Codes.Keys;
    public static IEnumerable<string> GetAlpha3Codes() => Alpha3Codes.Keys;

    public static Language? Parse(string code)
    {
        if(string.IsNullOrWhiteSpace(code) || !IsValidCode(code))
        {
            return default;
        }

        return code.Length switch
        {
            2 => GetByAlpha2CodeOrDefault(code),
            3 => GetByAlpha3CodeOrDefault(code),
            _ => default
        };
    }
}
