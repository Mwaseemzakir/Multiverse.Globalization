using System;

namespace Multiverse.Globalization.Languages;

[Serializable]
public class LanguageNotFoundException : Exception
{
    public LanguageNotFoundException()
    {
    }

    public LanguageNotFoundException(string? message) : base(message)
    {
    }

    public LanguageNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}