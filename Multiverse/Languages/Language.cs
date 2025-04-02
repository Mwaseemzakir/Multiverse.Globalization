using System;
using System.Collections.Generic;

using static Multiverse.Globalization.Languages.LanguageHelper;

namespace Multiverse.Globalization.Languages;

public sealed class Language
{
    public string Name { get; private set; }
    public string Alpha2Code { get; private set; } = string.Empty;
    public string Alpha3Code { get; private set; } = string.Empty;

    internal Language(
        string alpha2Code,
        string alpha3Code,
        string name)
    {
        Name = name;
        Alpha2Code = alpha2Code ?? string.Empty;
        Alpha3Code = alpha3Code ?? string.Empty;
    }

    /// <summary>
    /// Retrieves a Language object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, or the name of the language. Returns null if not found.
    /// </summary>
    public static Language? GetLanguageOrDefault(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier))
            return default;

        identifier = identifier.ToUpperInvariant();

        if(Alpha2CodeMap.ContainsKey(identifier))
            return Alpha2CodeMap[identifier];

        if(Alpha3CodeMap.ContainsKey(identifier))
            return Alpha3CodeMap[identifier];

        if(NameMap.ContainsKey(identifier))
            return NameMap[identifier];

        return default;
    }

    /// <summary>
    /// Retrieves a Language object based on the provided identifier, which can be an Alpha-2 code, 
    /// Alpha-3 code, or the name of the language. Throws an exception if not found.
    /// </summary>
    public static Language GetLanguage(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentNullException("Must provide the identifier value");

        if(!IsValid(identifier))
            throw new LanguageNotFoundException($"Language with identifier '{identifier}' was not found.");

        identifier = identifier.ToUpperInvariant();

        return identifier switch
        {
            _ when Alpha2CodeMap.ContainsKey(identifier) => Alpha2CodeMap[identifier],
            _ when Alpha3CodeMap.ContainsKey(identifier) => Alpha3CodeMap[identifier],
            _ when NameMap.ContainsKey(identifier) => NameMap[identifier],
            _ => throw new LanguageNotFoundException($"Language with identifier '{identifier}' was not found.")
        };
    }

    /// <summary>
    /// Validates if the provided identifier corresponds to a known language, which can be an Alpha-2 code, 
    /// Alpha-3 code, or the name of the language.
    /// </summary>
    public static bool IsValid(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier))
            return false;

        identifier = identifier.ToUpperInvariant();
        return Alpha2CodeMap.ContainsKey(identifier) ||
               Alpha3CodeMap.ContainsKey(identifier) ||
               NameMap.ContainsKey(identifier);
    }

    /// <summary>
    /// Retrieves a list of all available Language objects.
    /// </summary>
    public static List<Language> GetAll() => LanguageHelper.GetAll();

    public override bool Equals(object? obj)
    {
        if(obj is not Language other)
            return false;

        return Alpha2Code == other.Alpha2Code &&
               Alpha3Code == other.Alpha3Code &&
               Name == other.Name;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Alpha2Code?.GetHashCode() ?? 0);
            hash = hash * 23 + (Alpha3Code?.GetHashCode() ?? 0);
            hash = hash * 23 + (Name?.GetHashCode() ?? 0);
            return hash;
        }
    }
}
