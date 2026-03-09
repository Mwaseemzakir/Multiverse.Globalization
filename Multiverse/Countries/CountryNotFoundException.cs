using System;

namespace Multiverse.Globalization.Countries;

/// <summary>Exception thrown when a country cannot be found by its identifier.</summary>
[Serializable]
public class CountryNotFoundException : Exception
{
    /// <summary>Initializes a new instance of the <see cref="CountryNotFoundException"/> class.</summary>
    public CountryNotFoundException()
    {
    }

    /// <summary>Initializes a new instance with a specified error message.</summary>
    public CountryNotFoundException(string? message) : base(message)
    {
    }

    /// <summary>Initializes a new instance with a specified error message and inner exception.</summary>
    public CountryNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}