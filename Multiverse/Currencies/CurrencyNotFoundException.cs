using System;

namespace Multiverse.Globalization.Currencies;

[Serializable]
public class CurrencyNotFoundException : Exception
{
    public CurrencyNotFoundException()
    {
    }

    public CurrencyNotFoundException(string? message) : base(message)
    {
    }

    public CurrencyNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}