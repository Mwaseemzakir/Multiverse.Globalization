using System;

namespace Multiverse.Globalization.Languages;

/// <summary>Exception thrown when a language cannot be found by its identifier.</summary>
[Serializable]
public class LanguageNotFoundException : Exception
{
    /// <summary>Initializes a new instance of the <see cref="LanguageNotFoundException"/> class.</summary>
    public LanguageNotFoundException()
    {
    }

    /// <summary>Initializes a new instance with a specified error message.</summary>
    public LanguageNotFoundException(string? message) : base(message)
    {
    }

    /// <summary>Initializes a new instance with a specified error message and inner exception.</summary>
    public LanguageNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}