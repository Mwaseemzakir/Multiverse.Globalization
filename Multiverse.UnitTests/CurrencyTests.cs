﻿using Multiverse.Helpers;
using Multiverse.Models;
using Xunit;

namespace Multiverse.UnitTests;

public class CurrencyTests
{
    [Fact]
    public void GetAllCurrencies_Should_ReturnAllCurrencies()
    {
        List<Currency>? currencies = Currency
            .GetAll();

        Assert.NotNull(currencies);

        Assert.Contains(CurrencyHelpers.None, currencies);
    }

    [Fact]
    public void IsValidIsoCode_Should_ReturnTrueForValidCode()
    {
        //string pakCurrencyCode = Currency.PKR.Code;

        string pakCurrencyCode = "dsfsdfdsf";

        bool isValid = Currency.IsValidIsoCode(pakCurrencyCode);

        Assert.True(isValid);
    }

    [Fact]
    public void IsValidIsoCode_Should_IgnoreCaseSensitivity()
    {
        string pakCurrencyCode = CurrencyHelpers.PKR.Code.ToLower();

        bool isValid = Currency.IsValidIsoCode(pakCurrencyCode);

        Assert.True(isValid);
    }
}