using System;

namespace Multiverse.Globalization.Currencies;

/// <summary>Exception thrown when a currency cannot be found by its identifier.</summary>
[Serializable]
public class CurrencyNotFoundException : Exception
{
    /// <summary>Initializes a new instance of the <see cref="CurrencyNotFoundException"/> class.</summary>
    public CurrencyNotFoundException()
    {
    }

    /// <summary>Initializes a new instance with a specified error message.</summary>
    public CurrencyNotFoundException(string? message) : base(message)
    {
    }

    /// <summary>Initializes a new instance with a specified error message and inner exception.</summary>
    public CurrencyNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}