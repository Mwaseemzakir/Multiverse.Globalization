using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Multiverse.Globalization.Currencies;

public static class CurrencyHelper
{
    // ===== EXISTING currencies =====
    public static readonly Currency None = new Currency(0, string.Empty, string.Empty, string.Empty);
    public static readonly Currency Afghani = new Currency(971, "Afghani", "AFN", "؋");
    public static readonly Currency Euro = new Currency(978, "Euro", "EUR", "€");
    public static readonly Currency UsDollar = new Currency(840, "US Dollar", "USD", "$");
    public static readonly Currency PoundSterling = new Currency(826, "Pound Sterling", "GBP", "£");
    public static readonly Currency Yen = new Currency(392, "Yen", "JPY", "¥");
    public static readonly Currency YuanRenminbi = new Currency(156, "Yuan Renminbi", "CNY", "¥");
    public static readonly Currency IndianRupee = new Currency(356, "Indian Rupee", "INR", "₹");
    public static readonly Currency AustralianDollar = new Currency(036, "Australian Dollar", "AUD", "$");
    public static readonly Currency CanadianDollar = new Currency(124, "Canadian Dollar", "CAD", "$");
    public static readonly Currency SwissFranc = new Currency(756, "Swiss Franc", "CHF", "CHF");
    public static readonly Currency SwedishKrona = new Currency(752, "Swedish Krona", "SEK", "kr");
    public static readonly Currency NorwegianKrone = new Currency(578, "Norwegian Krone", "NOK", "kr");
    public static readonly Currency DanishKrone = new Currency(208, "Danish Krone", "DKK", "kr");
    public static readonly Currency NewZealandDollar = new Currency(554, "New Zealand Dollar", "NZD", "$");
    public static readonly Currency Rand = new Currency(710, "Rand", "ZAR", "R");
    public static readonly Currency BrazilianReal = new Currency(986, "Brazilian Real", "BRL", "R$");
    public static readonly Currency RussianRuble = new Currency(643, "Russian Ruble", "RUB", "₽");
    public static readonly Currency MexicanPeso = new Currency(484, "Mexican Peso", "MXN", "$");
    public static readonly Currency SingaporeDollar = new Currency(702, "Singapore Dollar", "SGD", "$");
    public static readonly Currency HongKongDollar = new Currency(344, "Hong Kong Dollar", "HKD", "$");
    public static readonly Currency Won = new Currency(410, "Won", "KRW", "₩");
    public static readonly Currency TurkishLira = new Currency(949, "Turkish Lira", "TRY", "₺");
    public static readonly Currency SaudiRiyal = new Currency(682, "Saudi Riyal", "SAR", "﷼");
    public static readonly Currency UaeDirham = new Currency(784, "UAE Dirham", "AED", "د.إ");
    public static readonly Currency Baht = new Currency(764, "Baht", "THB", "฿");
    public static readonly Currency MalaysianRinggit = new Currency(458, "Malaysian Ringgit", "MYR", "RM");
    public static readonly Currency Rupiah = new Currency(360, "Rupiah", "IDR", "Rp");
    public static readonly Currency PhilippinePeso = new Currency(608, "Philippine Peso", "PHP", "₱");
    public static readonly Currency Dong = new Currency(704, "Dong", "VND", "₫");
    public static readonly Currency PakistanRupee = new Currency(586, "Pakistan Rupee", "PKR", "₨");
    public static readonly Currency Taka = new Currency(050, "Taka", "BDT", "৳");
    public static readonly Currency SriLankaRupee = new Currency(144, "Sri Lanka Rupee", "LKR", "Rs");
    public static readonly Currency NepaleseRupee = new Currency(524, "Nepalese Rupee", "NPR", "Rs");
    public static readonly Currency IraqiDinar = new Currency(368, "Iraqi Dinar", "IQD", "ع.د");
    public static readonly Currency IranianRial = new Currency(364, "Iranian Rial", "IRR", "﷼");
    public static readonly Currency EgyptianPound = new Currency(818, "Egyptian Pound", "EGP", "£");
    public static readonly Currency Naira = new Currency(566, "Naira", "NGN", "₦");
    public static readonly Currency KenyanShilling = new Currency(404, "Kenyan Shilling", "KES", "KSh");
    public static readonly Currency GhanaCedi = new Currency(936, "Ghana Cedi", "GHS", "₵");
    public static readonly Currency CfaFrancBceao = new Currency(952, "CFA Franc BCEAO", "XOF", "CFA");
    public static readonly Currency CfaFrancBeac = new Currency(950, "CFA Franc BEAC", "XAF", "CFA");
    public static readonly Currency ArgentinePeso = new Currency(032, "Argentine Peso", "ARS", "$");
    public static readonly Currency ChileanPeso = new Currency(152, "Chilean Peso", "CLP", "$");
    public static readonly Currency ColombianPeso = new Currency(170, "Colombian Peso", "COP", "$");
    public static readonly Currency Sol = new Currency(604, "Sol", "PEN", "S/");
    public static readonly Currency Hryvnia = new Currency(980, "Hryvnia", "UAH", "₴");
    public static readonly Currency Zloty = new Currency(985, "Zloty", "PLN", "zł");
    public static readonly Currency CzechKoruna = new Currency(203, "Czech Koruna", "CZK", "Kč");
    public static readonly Currency Forint = new Currency(348, "Forint", "HUF", "Ft");
    public static readonly Currency RomanianLeu = new Currency(946, "Romanian Leu", "RON", "lei");
    public static readonly Currency NewIsraeliSheqel = new Currency(376, "New Israeli Sheqel", "ILS", "₪");
    public static readonly Currency QatariRial = new Currency(634, "Qatari Rial", "QAR", "﷼");
    public static readonly Currency KuwaitiDinar = new Currency(414, "Kuwaiti Dinar", "KWD", "د.ك");
    public static readonly Currency RialOmani = new Currency(512, "Rial Omani", "OMR", "﷼");
    public static readonly Currency BahrainiDinar = new Currency(048, "Bahraini Dinar", "BHD", "ب.د");
    public static readonly Currency IcelandKrona = new Currency(352, "Iceland Krona", "ISK", "kr");
    public static readonly Currency CostaRicanColon = new Currency(188, "Costa Rican Colon", "CRC", "₡");
    public static readonly Currency DominicanPeso = new Currency(214, "Dominican Peso", "DOP", "RD$");
    public static readonly Currency Quetzal = new Currency(320, "Quetzal", "GTQ", "Q");
    public static readonly Currency Lempira = new Currency(340, "Lempira", "HNL", "L");
    public static readonly Currency Balboa = new Currency(590, "Balboa", "PAB", "B/.");
    public static readonly Currency PesoUruguayo = new Currency(858, "Peso Uruguayo", "UYU", "$U");
    public static readonly Currency Boliviano = new Currency(068, "Boliviano", "BOB", "Bs.");
    public static readonly Currency Guarani = new Currency(600, "Guarani", "PYG", "₲");
    public static readonly Currency UzbekistanSum = new Currency(860, "Uzbekistan Sum", "UZS", "лв");
    public static readonly Currency Tenge = new Currency(398, "Tenge", "KZT", "₸");
    public static readonly Currency Somoni = new Currency(972, "Somoni", "TJS", "ЅМ");
    public static readonly Currency Som = new Currency(417, "Som", "KGS", "лв");
    public static readonly Currency TurkmenistanNewManat = new Currency(934, "Turkmenistan New Manat", "TMT", "m");
    public static readonly Currency AzerbaijanManat = new Currency(944, "Azerbaijan Manat", "AZN", "₼");
    public static readonly Currency Lari = new Currency(981, "Lari", "GEL", "₾");
    public static readonly Currency ArmenianDram = new Currency(051, "Armenian Dram", "AMD", "֏");
    public static readonly Currency BelarusianRuble = new Currency(933, "Belarusian Ruble", "BYN", "Br");
    public static readonly Currency TunisianDinar = new Currency(788, "Tunisian Dinar", "TND", "د.ت");
    public static readonly Currency MoroccanDirham = new Currency(504, "Moroccan Dirham", "MAD", "د.م.");
    public static readonly Currency CfpFranc = new Currency(953, "CFP Franc", "XPF", "₣");
    public static readonly Currency EastCaribbeanDollar = new Currency(951, "East Caribbean Dollar", "XCD", "$");
    public static readonly Currency Sdr = new Currency(960, "SDR (Special Drawing Right)", "XDR", "XDR");

    // ===== NEW currencies =====
    public static readonly Currency AlbanianLek = new Currency(008, "Albanian Lek", "ALL", "L");
    public static readonly Currency AlgerianDinar = new Currency(012, "Algerian Dinar", "DZD", "د.ج");
    public static readonly Currency AngolanKwanza = new Currency(973, "Angolan Kwanza", "AOA", "Kz");
    public static readonly Currency ArubanFlorin = new Currency(533, "Aruban Florin", "AWG", "ƒ");
    public static readonly Currency BahamianDollar = new Currency(044, "Bahamian Dollar", "BSD", "$");
    public static readonly Currency BarbadosDollar = new Currency(052, "Barbados Dollar", "BBD", "$");
    public static readonly Currency BelizeDollar = new Currency(084, "Belize Dollar", "BZD", "BZ$");
    public static readonly Currency BermudianDollar = new Currency(060, "Bermudian Dollar", "BMD", "$");
    public static readonly Currency BhutaneseNgultrum = new Currency(064, "Bhutanese Ngultrum", "BTN", "Nu");
    public static readonly Currency BosniaConvertibleMark = new Currency(977, "Bosnia Convertible Mark", "BAM", "KM");
    public static readonly Currency BotswanaPula = new Currency(072, "Botswana Pula", "BWP", "P");
    public static readonly Currency BruneiDollar = new Currency(096, "Brunei Dollar", "BND", "$");
    public static readonly Currency BulgarianLev = new Currency(975, "Bulgarian Lev", "BGN", "лв");
    public static readonly Currency BurundianFranc = new Currency(108, "Burundian Franc", "BIF", "FBu");
    public static readonly Currency CambodianRiel = new Currency(116, "Cambodian Riel", "KHR", "៛");
    public static readonly Currency CapeVerdeanEscudo = new Currency(132, "Cape Verdean Escudo", "CVE", "$");
    public static readonly Currency CaymanIslandsDollar = new Currency(136, "Cayman Islands Dollar", "KYD", "$");
    public static readonly Currency CongoleseFranc = new Currency(976, "Congolese Franc", "CDF", "FC");
    public static readonly Currency CubanPeso = new Currency(192, "Cuban Peso", "CUP", "$");
    public static readonly Currency DjiboutianFranc = new Currency(262, "Djiboutian Franc", "DJF", "Fdj");
    public static readonly Currency EritreanNakfa = new Currency(232, "Eritrean Nakfa", "ERN", "Nfk");
    public static readonly Currency EthiopianBirr = new Currency(230, "Ethiopian Birr", "ETB", "Br");
    public static readonly Currency FalklandIslandsPound = new Currency(238, "Falkland Islands Pound", "FKP", "£");
    public static readonly Currency FijianDollar = new Currency(242, "Fijian Dollar", "FJD", "$");
    public static readonly Currency GibraltarPound = new Currency(292, "Gibraltar Pound", "GIP", "£");
    public static readonly Currency GuineanFranc = new Currency(324, "Guinean Franc", "GNF", "FG");
    public static readonly Currency GuyaneseDollar = new Currency(328, "Guyanese Dollar", "GYD", "$");
    public static readonly Currency HaitianGourde = new Currency(332, "Haitian Gourde", "HTG", "G");
    public static readonly Currency JamaicanDollar = new Currency(388, "Jamaican Dollar", "JMD", "J$");
    public static readonly Currency JordanianDinar = new Currency(400, "Jordanian Dinar", "JOD", "د.ا");
    public static readonly Currency NorthKoreanWon = new Currency(408, "North Korean Won", "KPW", "₩");
    public static readonly Currency LaoKip = new Currency(418, "Lao Kip", "LAK", "₭");
    public static readonly Currency LebanesePound = new Currency(422, "Lebanese Pound", "LBP", "ل.ل");
    public static readonly Currency LesothoLoti = new Currency(426, "Lesotho Loti", "LSL", "L");
    public static readonly Currency LiberianDollar = new Currency(430, "Liberian Dollar", "LRD", "$");
    public static readonly Currency LibyanDinar = new Currency(434, "Libyan Dinar", "LYD", "ل.د");
    public static readonly Currency MacanesePataca = new Currency(446, "Macanese Pataca", "MOP", "MOP$");
    public static readonly Currency MacedonianDenar = new Currency(807, "Macedonian Denar", "MKD", "ден");
    public static readonly Currency MalagasyAriary = new Currency(969, "Malagasy Ariary", "MGA", "Ar");
    public static readonly Currency MalawianKwacha = new Currency(454, "Malawian Kwacha", "MWK", "MK");
    public static readonly Currency MaldivianRufiyaa = new Currency(462, "Maldivian Rufiyaa", "MVR", "Rf");
    public static readonly Currency MauritanianOuguiya = new Currency(929, "Mauritanian Ouguiya", "MRU", "UM");
    public static readonly Currency MauritianRupee = new Currency(480, "Mauritian Rupee", "MUR", "₨");
    public static readonly Currency MoldovanLeu = new Currency(498, "Moldovan Leu", "MDL", "L");
    public static readonly Currency MongolianTugrik = new Currency(496, "Mongolian Tugrik", "MNT", "₮");
    public static readonly Currency MozambicanMetical = new Currency(943, "Mozambican Metical", "MZN", "MT");
    public static readonly Currency MyanmarKyat = new Currency(104, "Myanmar Kyat", "MMK", "K");
    public static readonly Currency NamibianDollar = new Currency(516, "Namibian Dollar", "NAD", "$");
    public static readonly Currency NetherlandsAntilleanGuilder = new Currency(532, "Netherlands Antillean Guilder", "ANG", "ƒ");
    public static readonly Currency NicaraguanCordoba = new Currency(558, "Nicaraguan Cordoba", "NIO", "C$");
    public static readonly Currency PapuaNewGuineanKina = new Currency(598, "Papua New Guinean Kina", "PGK", "K");
    public static readonly Currency ComorianFranc = new Currency(174, "Comorian Franc", "KMF", "CF");
    public static readonly Currency SaintHelenaPound = new Currency(654, "Saint Helena Pound", "SHP", "£");
    public static readonly Currency SamoanTala = new Currency(882, "Samoan Tala", "WST", "T");
    public static readonly Currency SaoTomeDobra = new Currency(930, "Sao Tome Dobra", "STN", "Db");
    public static readonly Currency SerbianDinar = new Currency(941, "Serbian Dinar", "RSD", "din");
    public static readonly Currency SeychelloisRupee = new Currency(690, "Seychellois Rupee", "SCR", "₨");
    public static readonly Currency SierraLeoneanLeone = new Currency(925, "Sierra Leonean Leone", "SLE", "Le");
    public static readonly Currency SolomonIslandsDollar = new Currency(090, "Solomon Islands Dollar", "SBD", "$");
    public static readonly Currency SomaliShilling = new Currency(706, "Somali Shilling", "SOS", "Sh");
    public static readonly Currency SouthSudanesePound = new Currency(728, "South Sudanese Pound", "SSP", "£");
    public static readonly Currency SudanesePound = new Currency(938, "Sudanese Pound", "SDG", "ج.س");
    public static readonly Currency SurinameseDollar = new Currency(968, "Surinamese Dollar", "SRD", "$");
    public static readonly Currency SwaziLilangeni = new Currency(748, "Swazi Lilangeni", "SZL", "L");
    public static readonly Currency SyrianPound = new Currency(760, "Syrian Pound", "SYP", "£");
    public static readonly Currency NewTaiwanDollar = new Currency(901, "New Taiwan Dollar", "TWD", "NT$");
    public static readonly Currency TanzanianShilling = new Currency(834, "Tanzanian Shilling", "TZS", "TSh");
    public static readonly Currency TonganPaanga = new Currency(776, "Tongan Paanga", "TOP", "T$");
    public static readonly Currency TrinidadDollar = new Currency(780, "Trinidad and Tobago Dollar", "TTD", "TT$");
    public static readonly Currency UgandanShilling = new Currency(800, "Ugandan Shilling", "UGX", "USh");
    public static readonly Currency VanuatuVatu = new Currency(548, "Vanuatu Vatu", "VUV", "VT");
    public static readonly Currency VenezuelanBolivar = new Currency(928, "Venezuelan Bolivar Soberano", "VES", "Bs.S");
    public static readonly Currency YemeniRial = new Currency(886, "Yemeni Rial", "YER", "﷼");
    public static readonly Currency ZambianKwacha = new Currency(967, "Zambian Kwacha", "ZMW", "ZK");
    public static readonly Currency ZimbabweanDollar = new Currency(932, "Zimbabwean Dollar", "ZWL", "Z$");
    public static readonly Currency RwandanFranc = new Currency(646, "Rwandan Franc", "RWF", "RF");
    public static readonly Currency GambianDalasi = new Currency(270, "Gambian Dalasi", "GMD", "D");

    // ===== Reflection-based lookup =====
    private static readonly Lazy<List<Currency>> _all = new(() =>
        typeof(CurrencyHelper)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Currency) && f.Name != "None")
            .Select(f => (Currency)f.GetValue(null)!)
            .OrderBy(c => c.Name)
            .ToList());

    private static readonly Lazy<IReadOnlyDictionary<string, Currency>> _codeMap = new(() =>
    {
        var map = new Dictionary<string, Currency> { { string.Empty, None } };
        foreach (var c in _all.Value)
            map[c.Code.ToLowerInvariant()] = c;
        return map;
    });

    private static readonly Lazy<IReadOnlyDictionary<string, Currency>> _nameMap = new(() =>
    {
        var map = new Dictionary<string, Currency> { { string.Empty, None } };
        foreach (var c in _all.Value)
            map[c.Name.ToLowerInvariant()] = c;
        return map;
    });

    private static readonly Lazy<IReadOnlyDictionary<int, Currency>> _numberMap = new(() =>
    {
        var map = new Dictionary<int, Currency> { { 0, None } };
        foreach (var c in _all.Value)
            map[c.Number] = c;
        return map;
    });

    public static List<Currency> GetAll() => new(_all.Value);
    public static IReadOnlyDictionary<string, Currency> CodeMap => _codeMap.Value;
    public static IReadOnlyDictionary<string, Currency> NameMap => _nameMap.Value;
    public static IReadOnlyDictionary<int, Currency> NumberMap => _numberMap.Value;
}
