﻿using System;

namespace Multiverse.Globalization.Countries;

[Serializable]
public class CountryNotFoundException : Exception
{
    public CountryNotFoundException()
    {
    }

    public CountryNotFoundException(string? message) : base(message)
    {
    }

    public CountryNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}