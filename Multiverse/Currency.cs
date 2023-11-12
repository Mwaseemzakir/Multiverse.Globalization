using System.Runtime.CompilerServices;

namespace Multiverse;
public record Currency
{
	public static readonly Currency None = new(string.Empty, string.Empty);

	#region Currencies
	public static readonly Currency Afn = new Currency("971", "AFN");
	public static readonly Currency All = new Currency("008", "ALL");
	public static readonly Currency Amd = new Currency("051", "AMD");
	public static readonly Currency Ars = new Currency("032", "ARS");
	public static readonly Currency Aud = new Currency("036", "AUD");
	public static readonly Currency Azn = new Currency("944", "AZN");
	public static readonly Currency Bam = new Currency("977", "BAM");
	public static readonly Currency Bdt = new Currency("050", "BDT");
	public static readonly Currency Bgn = new Currency("975", "BGN");
	public static readonly Currency Bhd = new Currency("048", "BHD");
	public static readonly Currency Bnd = new Currency("096", "BND");
	public static readonly Currency Bob = new Currency("068", "BOB");
	public static readonly Currency Brl = new Currency("986", "BRL");
	public static readonly Currency Bzd = new Currency("084", "BZD");

	public static readonly Currency Cad = new Currency("124", "CAD");
	public static readonly Currency Chf = new Currency("947", "CHF");
	public static readonly Currency Clp = new Currency("152", "CLP");
	public static readonly Currency Cny = new Currency("156", "CNY");
	public static readonly Currency Cop = new Currency("170", "COP");
	public static readonly Currency Crc = new Currency("188", "CRC");
	public static readonly Currency Czk = new Currency("203", "CZK");
	public static readonly Currency Dkk = new Currency("208", "DKK");
	public static readonly Currency Dop = new Currency("214", "DOP");

	public static readonly Currency Dzd = new Currency("012", "DZD");
	public static readonly Currency Egp = new Currency("818", "EGP");
	public static readonly Currency Etb = new Currency("230", "ETB");
	public static readonly Currency Gbp = new Currency("826", "GBP");
	public static readonly Currency Gel = new Currency("981", "GEL");
	public static readonly Currency Gtq = new Currency("320", "GTQ");
	public static readonly Currency Hkd = new Currency("344", "HKD");
	public static readonly Currency Hnl = new Currency("340", "HNL");
	public static readonly Currency Hrk = new Currency("191", "HRK");
	public static readonly Currency Huf = new Currency("348", "HUF");

	public static readonly Currency Idr = new Currency("360", "IDR");
	public static readonly Currency Ils = new Currency("376", "ILS");
	public static readonly Currency Inr = new Currency("356", "INR");
	public static readonly Currency Iqd = new Currency("368", "IQD");
	public static readonly Currency Irr = new Currency("364", "IRR");
	public static readonly Currency Isk = new Currency("352", "ISK");
	public static readonly Currency Jmd = new Currency("388", "JMD");
	public static readonly Currency Jod = new Currency("400", "JOD");
	public static readonly Currency Jpy = new Currency("392", "JPY");
	public static readonly Currency Kes = new Currency("404", "KES");

	public static readonly Currency Kgs = new Currency("417", "KGS");
	public static readonly Currency Khr = new Currency("116", "KHR");
	public static readonly Currency Krw = new Currency("410", "KRW");
	public static readonly Currency Kwd = new Currency("414", "KWD");
	public static readonly Currency Kzt = new Currency("398", "KZT");
	public static readonly Currency Lak = new Currency("418", "LAK");
	public static readonly Currency Lbp = new Currency("422", "LBP");
	public static readonly Currency Lkr = new Currency("144", "LKR");
	public static readonly Currency Lyd = new Currency("434", "LYD");

	public static readonly Currency Mad = new Currency("504", "MAD");
	public static readonly Currency Mkd = new Currency("807", "MKD");
	public static readonly Currency Mnt = new Currency("496", "MNT");
	public static readonly Currency Mop = new Currency("446", "MOP");
	public static readonly Currency Mvr = new Currency("462", "MVR");
	public static readonly Currency Mxn = new Currency("484", "MXN");
	public static readonly Currency Myr = new Currency("458", "MYR");
	public static readonly Currency Nio = new Currency("558", "NIO");

	public static readonly Currency Nok = new Currency("578", "NOK");
	public static readonly Currency Npr = new Currency("524", "NPR");
	public static readonly Currency Nzd = new Currency("554", "NZD");
	public static readonly Currency Omr = new Currency("512", "OMR");
	public static readonly Currency Pab = new Currency("590", "PAB");
	public static readonly Currency Pen = new Currency("604", "PEN");
	public static readonly Currency Php = new Currency("608", "PHP");
	public static readonly Currency Pkr = new Currency("586", "PKR");
	public static readonly Currency Pln = new Currency("985", "PLN");
	public static readonly Currency Pyg = new Currency("600", "PYG");
	public static readonly Currency Qar = new Currency("634", "QAR");
	public static readonly Currency Ron = new Currency("946", "RON");
	public static readonly Currency Rsd = new Currency("941", "RSD");
	public static readonly Currency Rub = new Currency("643", "RUB");
	public static readonly Currency Rwf = new Currency("646", "RWF");
	public static readonly Currency Sar = new Currency("682", "SAR");
	public static readonly Currency Sek = new Currency("752", "SEK");
	public static readonly Currency Sgd = new Currency("702", "SGD");
	public static readonly Currency Syp = new Currency("760", "SYP");

	public static readonly Currency Thb = new Currency("764", "THB");
	public static readonly Currency Tjs = new Currency("972", "TJS");
	public static readonly Currency Tmt = new Currency("934", "TMT");
	public static readonly Currency Tnd = new Currency("788", "TND");
	public static readonly Currency Try = new Currency("949", "TRY");
	public static readonly Currency Ttd = new Currency("780", "TTD");
	public static readonly Currency Twd = new Currency("901", "TWD");
	public static readonly Currency Uah = new Currency("980", "UAH");
	public static readonly Currency Usd = new Currency("840", "USD");
	public static readonly Currency Uyu = new Currency("858", "UYU");
	public static readonly Currency Uzs = new Currency("860", "UZS");
	public static readonly Currency Vnd = new Currency("704", "VND");
	public static readonly Currency Xof = new Currency("952", "XOF");
	public static readonly Currency Yer = new Currency("886", "YER");
	public static readonly Currency Zar = new Currency("710", "ZAR");
	public static readonly Currency Zwl = new Currency("932", "ZWL");

	#endregion
	private Currency(string numericCode, string alpha3Code)
	{
		NumericCode = numericCode;
		Alpha3Code = alpha3Code;
	}
	public string NumericCode { get; private set; } = string.Empty;
	public string? Alpha3Code { get; private set; } = string.Empty;

	public static readonly IReadOnlyDictionary<string, Currency> AlphabeticCodeCurrencyMap = new Dictionary<string, Currency>
	{
		{ "AFN", Afn },
		{ "ALL", All },
		{ "AMD", Amd },
		{ "ARS", Ars },
		{ "AUD", Aud },
		{ "AZN", Azn },
		{ "BAM", Bam },
		{ "BDT", Bdt },
		{ "BGN", Bgn },
		{ "BHD", Bhd },
		{ "BND", Bnd },
		{ "BOB", Bob },
		{ "BRL", Brl },
		{ "BZD", Bzd },
		{ "CAD", Cad },
		{ "CHF", Chf },
		{ "CLP", Clp },
		{ "CNY", Cny },
		{ "COP", Cop },
		{ "CRC", Crc },
		{ "CZK", Czk },
		{ "DKK", Dkk },
		{ "DOP", Dop },
		{ "DZD", Dzd },
		{ "EGP", Egp },
		{ "ETB", Etb },
		{ "GBP", Gbp },
		{ "GEL", Gel },
		{ "GTQ", Gtq },
		{ "HKD", Hkd },
		{ "HNL", Hnl },
		{ "HRK", Hrk },
		{ "HUF", Huf },
		{ "IDR", Idr },
		{ "ILS", Ils },
		{ "INR", Inr },
		{ "IQD", Iqd },
		{ "IRR", Irr },
		{ "ISK", Isk },
		{ "JMD", Jmd },
		{ "JOD", Jod },
		{ "JPY", Jpy },
		{ "KES", Kes },
		{ "KGS", Kgs },
		{ "KHR", Khr },
		{ "KRW", Krw },
		{ "KWD", Kwd },
		{ "KZT", Kzt },
		{ "LAK", Lak },
		{ "LBP", Lbp },
		{ "LKR", Lkr },
		{ "LYD", Lyd },
		{ "MAD", Mad },
		{ "MKD", Mkd },
		{ "MNT", Mnt },
		{ "MOP", Mop },
		{ "MVR", Mvr },
		{ "MXN", Mxn },
		{ "MYR", Myr },
		{ "NIO", Nio },
		{ "NOK", Nok },
		{ "NPR", Npr },
		{ "NZD", Nzd },
		{ "OMR", Omr },
		{ "PAB", Pab },
		{ "PEN", Pen },
		{ "PHP", Php },
		{ "PKR", Pkr },
		{ "PLN", Pln },
		{ "PYG", Pyg },
		{ "QAR", Qar },
		{ "RON", Ron },
		{ "RSD", Rsd },
		{ "RUB", Rub },
		{ "RWF", Rwf },
		{ "SAR", Sar },
		{ "SEK", Sek },
		{ "SGD", Sgd },
		{ "SYP", Syp },
		{ "THB", Thb },
		{ "TJS", Tjs },
		{ "TMT", Tmt },
		{ "TND", Tnd },
		{ "TRY", Try },
		{ "TTD", Ttd },
		{ "TWD", Twd },
		{ "UAH", Uah },
		{ "USD", Usd },
		{ "UYU", Uyu },
		{ "UZS", Uzs },
		{ "VND", Vnd },
		{ "XOF", Xof },
		{ "YER", Yer },
		{ "ZAR", Zar },
		{ "ZWL", Zwl }
	};

	public static readonly IReadOnlyDictionary<string, Currency> NumericCodeCurrencyMap = new Dictionary<string, Currency>
	{
		{ "971", Afn },
		{ "008", All },
		{ "051", Amd },
		{ "032", Ars },
		{ "036", Aud },
		{ "944", Azn },
		{ "977", Bam },
		{ "050", Bdt },
		{ "975", Bgn },
		{ "048", Bhd },
		{ "096", Bnd },
		{ "068", Bob },
		{ "986", Brl },
		{ "084", Bzd },
		{ "124", Cad },
		{ "947", Chf },
		{ "152", Clp },
		{ "156", Cny },
		{ "170", Cop },
		{ "188", Crc },
		{ "203", Czk },
		{ "208", Dkk },
		{ "214", Dop },
		{ "012", Dzd },
		{ "818", Egp },
		{ "230", Etb },
		{ "826", Gbp },
		{ "981", Gel },
		{ "320", Gtq },
		{ "344", Hkd },
		{ "340", Hnl },
		{ "191", Hrk},
		{ "348", Huf },
		{ "360", Idr },
		{ "376", Ils },
		{ "356", Inr },
		{ "368", Iqd },
		{ "364", Irr },
		{ "352", Isk },
		{ "388", Jmd },
		{ "400", Jod },
		{ "392", Jpy },
		{ "404", Kes },
		{ "417", Kgs },
		{ "116", Khr },
		{ "410", Krw },
		{ "414", Kwd },
		{ "398", Kzt },
		{ "418", Lak },
		{ "422", Lbp },
		{ "144", Lkr },
		{ "434", Lyd },
		{ "504", Mad },
		{ "807", Mkd },
		{ "496", Mnt },
		{ "446", Mop },
		{ "462", Mvr },
		{ "484", Mxn },
		{ "458", Myr },
		{ "558", Nio },
		{ "578", Nok },
		{ "524", Npr },
		{ "554", Nzd },
		{ "512", Omr },
		{ "590", Pab },
		{ "604", Pen },
		{ "608", Php },
		{ "586", Pkr },
		{ "985", Pln },
		{ "600", Pyg },
		{ "634", Qar },
		{ "946", Ron },
		{ "941", Rsd },
		{ "643", Rub },
		{ "646", Rwf },
		{ "682", Sar },
		{ "752", Sek },
		{ "702", Sgd },
		{ "760", Syp },
		{ "764", Thb },
		{ "972", Tjs },
		{ "934", Tmt },
		{ "788", Tnd },
		{ "949", Try },
		{ "780", Ttd },
		{ "901", Twd },
		{ "980", Uah },
		{ "840", Usd },
		{ "858", Uyu },
		{ "860", Uzs },
		{ "704", Vnd },
		{ "952", Xof },
		{ "886", Yer },
		{ "710", Zar },
		{ "932", Zwl }
	};
	public static bool IsValidNumericCode(string? code)
	{
		if(!string.IsNullOrWhiteSpace(code))
		{
			return NumericCodeCurrencyMap.ContainsKey(code);
		}
		return false;
	}
	public static bool IsValidAlpha3Code(string code)
	{
		if(!string.IsNullOrWhiteSpace(code))
		{
			return AlphabeticCodeCurrencyMap.ContainsKey(code);
		}
		return false;
	}
	public static Currency FromAlpha3Code(
		string? code,
		[CallerArgumentExpression("code")] string? paramName = null
	)
	{
		if(!string.IsNullOrWhiteSpace(code))
		{
			code = code.ToUpperInvariant();

			AlphabeticCodeCurrencyMap.TryGetValue(code, out Currency? currency);

			if(currency != null) return currency;

			throw new ApplicationException($"Currency with alpha3 code : {code} is not supported for param : {paramName}");

		}
		throw new ApplicationException($"Currency with empty alpha3 code is not supported for : {paramName}");

	}
	public static Currency FromNumber(
		string? code,
		[CallerArgumentExpression("code")] string? paramName = null
	)
	{
		if(!string.IsNullOrWhiteSpace(code))
		{
			NumericCodeCurrencyMap.TryGetValue(code, out Currency? currency);

			if(currency != null) return currency;

			return currency == null ? throw new ApplicationException($"Currency with numeric code : {code} is not supported for : {paramName}") : currency;
		}

		throw new ApplicationException($"Currency with empty numeric code : {code} is not supported for {paramName}");
	}
}