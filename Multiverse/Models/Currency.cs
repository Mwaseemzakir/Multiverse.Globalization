using Multiverse.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiverse.Models
{
    public class Currency
    {
        public static readonly Currency None = new Currency(string.Empty, 0, string.Empty);

        #region Currencies
        public static readonly Currency AFN = new Currency("Afghani", 971, "AFN");
        public static readonly Currency EUR = new Currency("Euro", 978, "EUR");
        public static readonly Currency USD = new Currency("US Dollar", 840, "USD");
        public static readonly Currency GBP = new Currency("Pound Sterling", 826, "GBP");
        public static readonly Currency JPY = new Currency("Yen", 392, "JPY");
        public static readonly Currency CNY = new Currency("Yuan Renminbi", 156, "CNY");
        public static readonly Currency INR = new Currency("Indian Rupee", 356, "INR");
        public static readonly Currency AUD = new Currency("Australian Dollar", 036, "AUD");
        public static readonly Currency CAD = new Currency("Canadian Dollar", 124, "CAD");
        public static readonly Currency CHF = new Currency("Swiss Franc", 756, "CHF");
        public static readonly Currency SEK = new Currency("Swedish Krona", 752, "SEK");
        public static readonly Currency NOK = new Currency("Norwegian Krone", 578, "NOK");
        public static readonly Currency DKK = new Currency("Danish Krone", 208, "DKK");
        public static readonly Currency NZD = new Currency("new Currency Zealand Dollar", 554, "NZD");
        public static readonly Currency ZAR = new Currency("Rand", 710, "ZAR");
        public static readonly Currency BRL = new Currency("Brazilian Real", 986, "BRL");
        public static readonly Currency RUB = new Currency("Russian Ruble", 643, "RUB");
        public static readonly Currency MXN = new Currency("Mexican Peso", 484, "MXN");
        public static readonly Currency SGD = new Currency("Singapore Dollar", 702, "SGD");
        public static readonly Currency HKD = new Currency("Hong Kong Dollar", 344, "HKD");
        public static readonly Currency KRW = new Currency("Won", 410, "KRW");
        public static readonly Currency TRY = new Currency("Turkish Lira", 949, "TRY");
        public static readonly Currency SAR = new Currency("Saudi Riyal", 682, "SAR");
        public static readonly Currency AED = new Currency("UAE Dirham", 784, "AED");
        public static readonly Currency THB = new Currency("Baht", 764, "THB");
        public static readonly Currency MYR = new Currency("Malaysian Ringgit", 458, "MYR");
        public static readonly Currency IDR = new Currency("Rupiah", 360, "IDR");
        public static readonly Currency PHP = new Currency("Philippine Peso", 608, "PHP");
        public static readonly Currency VND = new Currency("Dong", 704, "VND");
        public static readonly Currency PKR = new Currency("Pakistan Rupee", 586, "PKR");
        public static readonly Currency BDT = new Currency("Taka", 050, "BDT");
        public static readonly Currency LKR = new Currency("Sri Lanka Rupee", 144, "LKR");
        public static readonly Currency NPR = new Currency("Nepalese Rupee", 524, "NPR");
        public static readonly Currency IQD = new Currency("Iraqi Dinar", 368, "IQD");
        public static readonly Currency IRR = new Currency("Iranian Rial", 364, "IRR");
        public static readonly Currency EGP = new Currency("Egyptian Pound", 818, "EGP");
        public static readonly Currency NGN = new Currency("Naira", 566, "NGN");
        public static readonly Currency KES = new Currency("Kenyan Shilling", 404, "KES");
        public static readonly Currency GHS = new Currency("Ghana Cedi", 936, "GHS");
        public static readonly Currency XOF = new Currency("CFA Franc BCEAO", 952, "XOF");
        public static readonly Currency XAF = new Currency("CFA Franc BEAC", 950, "XAF");
        public static readonly Currency ARS = new Currency("Argentine Peso", 032, "ARS");
        public static readonly Currency CLP = new Currency("Chilean Peso", 152, "CLP");
        public static readonly Currency COP = new Currency("Colombian Peso", 170, "COP");
        public static readonly Currency PEN = new Currency("Sol", 604, "PEN");
        public static readonly Currency UAH = new Currency("Hryvnia", 980, "UAH");
        public static readonly Currency PLN = new Currency("Zloty", 985, "PLN");
        public static readonly Currency CZK = new Currency("Czech Koruna", 203, "CZK");
        public static readonly Currency HUF = new Currency("Forint", 348, "HUF");
        public static readonly Currency RON = new Currency("Romanian Leu", 946, "RON");
        public static readonly Currency ILS = new Currency("new Currency Israeli Sheqel", 376, "ILS");
        public static readonly Currency QAR = new Currency("Qatari Rial", 634, "QAR");
        public static readonly Currency KWD = new Currency("Kuwaiti Dinar", 414, "KWD");
        public static readonly Currency OMR = new Currency("Rial Omani", 512, "OMR");
        public static readonly Currency BHD = new Currency("Bahraini Dinar", 048, "BHD");
        public static readonly Currency ISK = new Currency("Iceland Krona", 352, "ISK");
        public static readonly Currency CRC = new Currency("Costa Rican Colon", 188, "CRC");
        public static readonly Currency DOP = new Currency("Dominican Peso", 214, "DOP");
        public static readonly Currency GTQ = new Currency("Quetzal", 320, "GTQ");
        public static readonly Currency HNL = new Currency("Lempira", 340, "HNL");
        public static readonly Currency PAB = new Currency("Balboa", 590, "PAB");
        public static readonly Currency UYU = new Currency("Peso Uruguayo", 858, "UYU");
        public static readonly Currency BOB = new Currency("Boliviano", 068, "BOB");
        public static readonly Currency PYG = new Currency("Guarani", 600, "PYG");
        public static readonly Currency UZS = new Currency("Uzbekistan Sum", 860, "UZS");
        public static readonly Currency KZT = new Currency("Tenge", 398, "KZT");
        public static readonly Currency TJS = new Currency("Somoni", 972, "TJS");
        public static readonly Currency KGS = new Currency("Som", 417, "KGS");
        public static readonly Currency TMT = new Currency("Turkmenistan new Currency Manat", 934, "TMT");
        public static readonly Currency AZN = new Currency("Azerbaijan Manat", 944, "AZN");
        public static readonly Currency GEL = new Currency("Lari", 981, "GEL");
        public static readonly Currency AMD = new Currency("Armenian Dram", 051, "AMD");
        public static readonly Currency BYN = new Currency("Belarusian Ruble", 933, "BYN");
        public static readonly Currency TND = new Currency("Tunisian Dinar", 788, "TND");
        public static readonly Currency MAD = new Currency("Moroccan Dirham", 504, "MAD");
        public static readonly Currency XPF = new Currency("CFP Franc", 953, "XPF");
        public static readonly Currency XCD = new Currency("East Caribbean Dollar", 951, "XCD");
        public static readonly Currency XDR = new Currency("SDR (Special Drawing Right)", 960, "XDR");
        #endregion

        private Currency(string currencyName, int number, string code)
        {
            Code = code;
            Number = number;
            CurrencyName = currencyName;
        }
        public string Code { get; private set; } = string.Empty;
        public int Number { get; private set; }
        public string Country { get; private set; } = string.Empty;
        public string CurrencyName { get; private set; } = string.Empty;

        public static readonly IReadOnlyDictionary<string, Currency> CodeCurrencies = CreateCodeCurrencies();

        public static readonly IReadOnlyDictionary<int, Currency> NumberCurrencies = CreateNumberCurrencies();
        
        /// <summary>
        /// Checks whether the provided numeric code corresponds to a valid currency.
        /// </summary>
        /// <param name="number">The numeric code of the currency.</param>
        /// <returns>
        /// True if the numeric code is greater than zero and exists in the lookup dictionary; otherwise, false.
        /// </returns>
        public static bool ValidNumberCode(int number)
        {
            if(number > 0)
                return NumberCurrencies.ContainsKey(number);
            return false;
        }

        /// <summary>
        /// Checks whether the provided ISO code (3-letter code) corresponds to a valid currency.
        /// </summary>
        /// <param name="code">The ISO code of the currency.</param>
        /// <returns>
        /// True if the ISO code is non-null, has exactly 3 characters, and exists in the lookup dictionary; otherwise, false.
        /// </returns>
        public static bool ValidIsoCode(string code)
        {
            if(!string.IsNullOrWhiteSpace(code) && code.Length == 3)
            {
                // Convert to uppercase for consistency.
                string upperVariant = code.ToUpperInvariant();

                if(code != upperVariant)
                    code = upperVariant;

                return CodeCurrencies.ContainsKey(code);
            }
            return false;
        }

        /// <summary>
        /// Retrieves the currency instance corresponding to the specified ISO code.
        /// </summary>
        /// <param name="code">The 3-letter ISO code of the currency.</param>
        /// <returns>The Currency instance associated with the provided ISO code.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the ISO code is not found.</exception>
        public static Currency GetCurrencyByIsoCode(string code)
        {
            if(ValidIsoCode(code))
            {
                string upperCode = code.ToUpperInvariant();
                return CodeCurrencies[upperCode];
            }
            throw new KeyNotFoundException($"Currency with ISO code '{code}' not found.");
        }

        /// <summary>
        /// Retrieves the currency instance corresponding to the specified numeric code.
        /// </summary>
        /// <param name="number">The numeric code of the currency.</param>
        /// <returns>The Currency instance associated with the provided numeric code.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the numeric code is not found.</exception>
        public static Currency GetCurrencyByNumber(int number)
        {
            if(ValidNumberCode(number))
                return NumberCurrencies[number];
            throw new KeyNotFoundException($"Currency with number code '{number}' not found.");
        }

        /// <summary>
        /// Attempts to retrieve the currency instance corresponding to the specified ISO code.
        /// </summary>
        /// <param name="code">The 3-letter ISO code of the currency.</param>
        /// <param name="currency">
        /// When this method returns, contains the Currency instance associated with the specified ISO code if it is found; otherwise, null.
        /// </param>
        /// <returns>
        /// True if a currency with the specified ISO code is found; otherwise, false.
        /// </returns>
        public static bool TryGetCurrencyByIsoCode(string code, out Currency currency)
        {
            currency = None;

            if(ValidIsoCode(code))
            {
                string upperCode = code.ToUpperInvariant();

                return CodeCurrencies.TryGetValue(upperCode, out currency);
            }
            return false;
        }

        /// <summary>
        /// Attempts to retrieve the currency instance corresponding to the specified numeric code.
        /// </summary>
        /// <param name="number">The numeric code of the currency.</param>
        /// <param name="currency">
        /// When this method returns, contains the Currency instance associated with the specified numeric code if it is found; otherwise, null.
        /// </param>
        /// <returns>
        /// True if a currency with the specified numeric code is found; otherwise, false.
        /// </returns>
        public static bool TryGetCurrencyByNumber(int number, out Currency currency)
        {
            currency = None;

            if(ValidNumberCode(number))
                return NumberCurrencies.TryGetValue(number, out currency);
            return false;
        }

        /// <summary>
        /// Retrieves all defined currency instances.
        /// </summary>
        /// <returns>
        /// An enumerable collection of all available Currency instances.
        /// </returns>
        public static IEnumerable<Currency> GetAllCurrencies()
        {
            return ReflectionHelper.GetStaticFieldsOfType<Currency>();
        }

        /// <summary>
        /// Gets the total number of defined currencies.
        /// </summary>
        public static int CurrencyCount => CodeCurrencies.Count;

        /// <summary>
        /// Retrieves all available ISO currency codes.
        /// </summary>
        /// <returns>
        /// An enumerable collection of 3-letter ISO currency codes.
        /// </returns>
        public static IEnumerable<string> GetAllIsoCodes()
        {
            return CodeCurrencies.Keys;
        }

        /// <summary>
        /// Retrieves all available numeric currency codes.
        /// </summary>
        /// <returns>
        /// An enumerable collection of numeric currency codes.
        /// </returns>
        public static IEnumerable<int> GetAllNumberCodes()
        {
            return NumberCurrencies.Keys;
        }

        /// <summary>
        /// Parses an input object to retrieve a corresponding Currency instance.
        /// The input can be either a 3-letter ISO code (string) or a numeric code (int).
        /// </summary>
        /// <param name="input">A currency identifier, either as a string (ISO code) or int (numeric code).</param>
        /// <returns>
        /// The Currency instance associated with the input.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the input is neither a valid ISO code nor a numeric code.
        /// </exception>
        public static Currency ParseCurrency(object input)
        {
            if(input is int number)
                return GetCurrencyByNumber(number);
            if(input is string code)
                return GetCurrencyByIsoCode(code);
            throw new ArgumentException("Input must be a valid 3-letter ISO code or numeric currency code.");
        }

        /// <summary>
        /// Creates a read-only dictionary that maps ISO currency codes to Currency instances.
        /// This method uses reflection to retrieve all static Currency fields.
        /// </summary>
        /// <returns>
        /// An IReadOnlyDictionary where the key is the ISO code and the value is the Currency instance.
        /// </returns>
        private static IReadOnlyDictionary<string, Currency> CreateCodeCurrencies()
        {
            IEnumerable<Currency>? fields = ReflectionHelper.GetStaticFieldsOfType<Currency>();

            return fields.ToDictionary(f => f.Code);
        }

        /// <summary>
        /// Creates a read-only dictionary that maps numeric currency codes to Currency instances.
        /// This method uses reflection to retrieve all static Currency fields.
        /// </summary>
        /// <returns>
        /// An IReadOnlyDictionary where the key is the numeric code and the value is the Currency instance.
        /// </returns>
        private static IReadOnlyDictionary<int, Currency> CreateNumberCurrencies()
        {
            IEnumerable<Currency>? fields = ReflectionHelper.GetStaticFieldsOfType<Currency>();

            return fields.ToDictionary(f => f.Number);
        }
    }
}
