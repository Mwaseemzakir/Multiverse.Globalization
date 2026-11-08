namespace Multiverse.Globalization.Currencies;

/// <summary>
/// Provides access to all ISO 4217 currencies as static readonly fields and lookup maps.
/// </summary>
public static class CurrencyHelper
{
    // ===== EXISTING currencies =====
    /// <summary>The None currency.</summary>
    public static readonly Currency None = new(0, string.Empty, string.Empty, string.Empty);
    /// <summary>The Afghani currency.</summary>
    public static readonly Currency Afghani = new(971, "Afghani", "AFN", "؋");
    /// <summary>The Euro currency.</summary>
    public static readonly Currency Euro = new(978, "Euro", "EUR", "€");
    /// <summary>The Us Dollar currency.</summary>
    public static readonly Currency UsDollar = new(840, "US Dollar", "USD", "$");
    /// <summary>The Pound Sterling currency.</summary>
    public static readonly Currency PoundSterling = new(826, "Pound Sterling", "GBP", "£");
    /// <summary>The Yen currency.</summary>
    public static readonly Currency Yen = new(392, "Yen", "JPY", "¥");
    /// <summary>The Yuan Renminbi currency.</summary>
    public static readonly Currency YuanRenminbi = new(156, "Yuan Renminbi", "CNY", "¥");
    /// <summary>The Indian Rupee currency.</summary>
    public static readonly Currency IndianRupee = new(356, "Indian Rupee", "INR", "₹");
    /// <summary>The Australian Dollar currency.</summary>
    public static readonly Currency AustralianDollar = new(036, "Australian Dollar", "AUD", "$");
    /// <summary>The Canadian Dollar currency.</summary>
    public static readonly Currency CanadianDollar = new(124, "Canadian Dollar", "CAD", "$");
    /// <summary>The Swiss Franc currency.</summary>
    public static readonly Currency SwissFranc = new(756, "Swiss Franc", "CHF", "CHF");
    /// <summary>The Swedish Krona currency.</summary>
    public static readonly Currency SwedishKrona = new(752, "Swedish Krona", "SEK", "kr");
    /// <summary>The Norwegian Krone currency.</summary>
    public static readonly Currency NorwegianKrone = new(578, "Norwegian Krone", "NOK", "kr");
    /// <summary>The Danish Krone currency.</summary>
    public static readonly Currency DanishKrone = new(208, "Danish Krone", "DKK", "kr");
    /// <summary>The New Zealand Dollar currency.</summary>
    public static readonly Currency NewZealandDollar = new(554, "New Zealand Dollar", "NZD", "$");
    /// <summary>The Rand currency.</summary>
    public static readonly Currency Rand = new(710, "Rand", "ZAR", "R");
    /// <summary>The Brazilian Real currency.</summary>
    public static readonly Currency BrazilianReal = new(986, "Brazilian Real", "BRL", "R$");
    /// <summary>The Russian Ruble currency.</summary>
    public static readonly Currency RussianRuble = new(643, "Russian Ruble", "RUB", "₽");
    /// <summary>The Mexican Peso currency.</summary>
    public static readonly Currency MexicanPeso = new(484, "Mexican Peso", "MXN", "$");
    /// <summary>The Singapore Dollar currency.</summary>
    public static readonly Currency SingaporeDollar = new(702, "Singapore Dollar", "SGD", "$");
    /// <summary>The Hong Kong Dollar currency.</summary>
    public static readonly Currency HongKongDollar = new(344, "Hong Kong Dollar", "HKD", "$");
    /// <summary>The Won currency.</summary>
    public static readonly Currency Won = new(410, "Won", "KRW", "₩");
    /// <summary>The Turkish Lira currency.</summary>
    public static readonly Currency TurkishLira = new(949, "Turkish Lira", "TRY", "₺");
    /// <summary>The Saudi Riyal currency.</summary>
    public static readonly Currency SaudiRiyal = new(682, "Saudi Riyal", "SAR", "﷼");
    /// <summary>The Uae Dirham currency.</summary>
    public static readonly Currency UaeDirham = new(784, "UAE Dirham", "AED", "د.إ");
    /// <summary>The Baht currency.</summary>
    public static readonly Currency Baht = new(764, "Baht", "THB", "฿");
    /// <summary>The Malaysian Ringgit currency.</summary>
    public static readonly Currency MalaysianRinggit = new(458, "Malaysian Ringgit", "MYR", "RM");
    /// <summary>The Rupiah currency.</summary>
    public static readonly Currency Rupiah = new(360, "Rupiah", "IDR", "Rp");
    /// <summary>The Philippine Peso currency.</summary>
    public static readonly Currency PhilippinePeso = new(608, "Philippine Peso", "PHP", "₱");
    /// <summary>The Dong currency.</summary>
    public static readonly Currency Dong = new(704, "Dong", "VND", "₫");
    /// <summary>The Pakistan Rupee currency.</summary>
    public static readonly Currency PakistanRupee = new(586, "Pakistan Rupee", "PKR", "₨");
    /// <summary>The Taka currency.</summary>
    public static readonly Currency Taka = new(050, "Taka", "BDT", "৳");
    /// <summary>The Sri Lanka Rupee currency.</summary>
    public static readonly Currency SriLankaRupee = new(144, "Sri Lanka Rupee", "LKR", "Rs");
    /// <summary>The Nepalese Rupee currency.</summary>
    public static readonly Currency NepaleseRupee = new(524, "Nepalese Rupee", "NPR", "Rs");
    /// <summary>The Iraqi Dinar currency.</summary>
    public static readonly Currency IraqiDinar = new(368, "Iraqi Dinar", "IQD", "ع.د");
    /// <summary>The Iranian Rial currency.</summary>
    public static readonly Currency IranianRial = new(364, "Iranian Rial", "IRR", "﷼");
    /// <summary>The Egyptian Pound currency.</summary>
    public static readonly Currency EgyptianPound = new(818, "Egyptian Pound", "EGP", "£");
    /// <summary>The Naira currency.</summary>
    public static readonly Currency Naira = new(566, "Naira", "NGN", "₦");
    /// <summary>The Kenyan Shilling currency.</summary>
    public static readonly Currency KenyanShilling = new(404, "Kenyan Shilling", "KES", "KSh");
    /// <summary>The Ghana Cedi currency.</summary>
    public static readonly Currency GhanaCedi = new(936, "Ghana Cedi", "GHS", "₵");
    /// <summary>The Cfa Franc Bceao currency.</summary>
    public static readonly Currency CfaFrancBceao = new(952, "CFA Franc BCEAO", "XOF", "CFA");
    /// <summary>The Cfa Franc Beac currency.</summary>
    public static readonly Currency CfaFrancBeac = new(950, "CFA Franc BEAC", "XAF", "CFA");
    /// <summary>The Argentine Peso currency.</summary>
    public static readonly Currency ArgentinePeso = new(032, "Argentine Peso", "ARS", "$");
    /// <summary>The Chilean Peso currency.</summary>
    public static readonly Currency ChileanPeso = new(152, "Chilean Peso", "CLP", "$");
    /// <summary>The Colombian Peso currency.</summary>
    public static readonly Currency ColombianPeso = new(170, "Colombian Peso", "COP", "$");
    /// <summary>The Sol currency.</summary>
    public static readonly Currency Sol = new(604, "Sol", "PEN", "S/");
    /// <summary>The Hryvnia currency.</summary>
    public static readonly Currency Hryvnia = new(980, "Hryvnia", "UAH", "₴");
    /// <summary>The Zloty currency.</summary>
    public static readonly Currency Zloty = new(985, "Zloty", "PLN", "zł");
    /// <summary>The Czech Koruna currency.</summary>
    public static readonly Currency CzechKoruna = new(203, "Czech Koruna", "CZK", "Kč");
    /// <summary>The Forint currency.</summary>
    public static readonly Currency Forint = new(348, "Forint", "HUF", "Ft");
    /// <summary>The Romanian Leu currency.</summary>
    public static readonly Currency RomanianLeu = new(946, "Romanian Leu", "RON", "lei");
    /// <summary>The New Israeli Sheqel currency.</summary>
    public static readonly Currency NewIsraeliSheqel = new(376, "New Israeli Sheqel", "ILS", "₪");
    /// <summary>The Qatari Rial currency.</summary>
    public static readonly Currency QatariRial = new(634, "Qatari Rial", "QAR", "﷼");
    /// <summary>The Kuwaiti Dinar currency.</summary>
    public static readonly Currency KuwaitiDinar = new(414, "Kuwaiti Dinar", "KWD", "د.ك");
    /// <summary>The Rial Omani currency.</summary>
    public static readonly Currency RialOmani = new(512, "Rial Omani", "OMR", "﷼");
    /// <summary>The Bahraini Dinar currency.</summary>
    public static readonly Currency BahrainiDinar = new(048, "Bahraini Dinar", "BHD", "ب.د");
    /// <summary>The Iceland Krona currency.</summary>
    public static readonly Currency IcelandKrona = new(352, "Iceland Krona", "ISK", "kr");
    /// <summary>The Costa Rican Colon currency.</summary>
    public static readonly Currency CostaRicanColon = new(188, "Costa Rican Colon", "CRC", "₡");
    /// <summary>The Dominican Peso currency.</summary>
    public static readonly Currency DominicanPeso = new(214, "Dominican Peso", "DOP", "RD$");
    /// <summary>The Quetzal currency.</summary>
    public static readonly Currency Quetzal = new(320, "Quetzal", "GTQ", "Q");
    /// <summary>The Lempira currency.</summary>
    public static readonly Currency Lempira = new(340, "Lempira", "HNL", "L");
    /// <summary>The Balboa currency.</summary>
    public static readonly Currency Balboa = new(590, "Balboa", "PAB", "B/.");
    /// <summary>The Peso Uruguayo currency.</summary>
    public static readonly Currency PesoUruguayo = new(858, "Peso Uruguayo", "UYU", "$U");
    /// <summary>The Boliviano currency.</summary>
    public static readonly Currency Boliviano = new(068, "Boliviano", "BOB", "Bs.");
    /// <summary>The Guarani currency.</summary>
    public static readonly Currency Guarani = new(600, "Guarani", "PYG", "₲");
    /// <summary>The Uzbekistan Sum currency.</summary>
    public static readonly Currency UzbekistanSum = new(860, "Uzbekistan Sum", "UZS", "лв");
    /// <summary>The Tenge currency.</summary>
    public static readonly Currency Tenge = new(398, "Tenge", "KZT", "₸");
    /// <summary>The Somoni currency.</summary>
    public static readonly Currency Somoni = new(972, "Somoni", "TJS", "ЅМ");
    /// <summary>The Som currency.</summary>
    public static readonly Currency Som = new(417, "Som", "KGS", "лв");
    /// <summary>The Turkmenistan New Manat currency.</summary>
    public static readonly Currency TurkmenistanNewManat = new(934, "Turkmenistan New Manat", "TMT", "m");
    /// <summary>The Azerbaijan Manat currency.</summary>
    public static readonly Currency AzerbaijanManat = new(944, "Azerbaijan Manat", "AZN", "₼");
    /// <summary>The Lari currency.</summary>
    public static readonly Currency Lari = new(981, "Lari", "GEL", "₾");
    /// <summary>The Armenian Dram currency.</summary>
    public static readonly Currency ArmenianDram = new(051, "Armenian Dram", "AMD", "֏");
    /// <summary>The Belarusian Ruble currency.</summary>
    public static readonly Currency BelarusianRuble = new(933, "Belarusian Ruble", "BYN", "Br");
    /// <summary>The Tunisian Dinar currency.</summary>
    public static readonly Currency TunisianDinar = new(788, "Tunisian Dinar", "TND", "د.ت");
    /// <summary>The Moroccan Dirham currency.</summary>
    public static readonly Currency MoroccanDirham = new(504, "Moroccan Dirham", "MAD", "د.م.");
    /// <summary>The Cfp Franc currency.</summary>
    public static readonly Currency CfpFranc = new(953, "CFP Franc", "XPF", "₣");
    /// <summary>The East Caribbean Dollar currency.</summary>
    public static readonly Currency EastCaribbeanDollar = new(951, "East Caribbean Dollar", "XCD", "$");
    /// <summary>The Sdr currency.</summary>
    public static readonly Currency Sdr = new(960, "SDR (Special Drawing Right)", "XDR", "XDR");

    // ===== NEW currencies =====
    /// <summary>The Albanian Lek currency.</summary>
    public static readonly Currency AlbanianLek = new(008, "Albanian Lek", "ALL", "L");
    /// <summary>The Algerian Dinar currency.</summary>
    public static readonly Currency AlgerianDinar = new(012, "Algerian Dinar", "DZD", "د.ج");
    /// <summary>The Angolan Kwanza currency.</summary>
    public static readonly Currency AngolanKwanza = new(973, "Angolan Kwanza", "AOA", "Kz");
    /// <summary>The Aruban Florin currency.</summary>
    public static readonly Currency ArubanFlorin = new(533, "Aruban Florin", "AWG", "ƒ");
    /// <summary>The Bahamian Dollar currency.</summary>
    public static readonly Currency BahamianDollar = new(044, "Bahamian Dollar", "BSD", "$");
    /// <summary>The Barbados Dollar currency.</summary>
    public static readonly Currency BarbadosDollar = new(052, "Barbados Dollar", "BBD", "$");
    /// <summary>The Belize Dollar currency.</summary>
    public static readonly Currency BelizeDollar = new(084, "Belize Dollar", "BZD", "BZ$");
    /// <summary>The Bermudian Dollar currency.</summary>
    public static readonly Currency BermudianDollar = new(060, "Bermudian Dollar", "BMD", "$");
    /// <summary>The Bhutanese Ngultrum currency.</summary>
    public static readonly Currency BhutaneseNgultrum = new(064, "Bhutanese Ngultrum", "BTN", "Nu");
    /// <summary>The Bosnia Convertible Mark currency.</summary>
    public static readonly Currency BosniaConvertibleMark = new(977, "Bosnia Convertible Mark", "BAM", "KM");
    /// <summary>The Botswana Pula currency.</summary>
    public static readonly Currency BotswanaPula = new(072, "Botswana Pula", "BWP", "P");
    /// <summary>The Brunei Dollar currency.</summary>
    public static readonly Currency BruneiDollar = new(096, "Brunei Dollar", "BND", "$");
    /// <summary>The Bulgarian Lev currency.</summary>
    public static readonly Currency BulgarianLev = new(975, "Bulgarian Lev", "BGN", "лв");
    /// <summary>The Burundian Franc currency.</summary>
    public static readonly Currency BurundianFranc = new(108, "Burundian Franc", "BIF", "FBu");
    /// <summary>The Cambodian Riel currency.</summary>
    public static readonly Currency CambodianRiel = new(116, "Cambodian Riel", "KHR", "៛");
    /// <summary>The Cape Verdean Escudo currency.</summary>
    public static readonly Currency CapeVerdeanEscudo = new(132, "Cape Verdean Escudo", "CVE", "$");
    /// <summary>The Cayman Islands Dollar currency.</summary>
    public static readonly Currency CaymanIslandsDollar = new(136, "Cayman Islands Dollar", "KYD", "$");
    /// <summary>The Congolese Franc currency.</summary>
    public static readonly Currency CongoleseFranc = new(976, "Congolese Franc", "CDF", "FC");
    /// <summary>The Cuban Peso currency.</summary>
    public static readonly Currency CubanPeso = new(192, "Cuban Peso", "CUP", "$");
    /// <summary>The Djiboutian Franc currency.</summary>
    public static readonly Currency DjiboutianFranc = new(262, "Djiboutian Franc", "DJF", "Fdj");
    /// <summary>The Eritrean Nakfa currency.</summary>
    public static readonly Currency EritreanNakfa = new(232, "Eritrean Nakfa", "ERN", "Nfk");
    /// <summary>The Ethiopian Birr currency.</summary>
    public static readonly Currency EthiopianBirr = new(230, "Ethiopian Birr", "ETB", "Br");
    /// <summary>The Falkland Islands Pound currency.</summary>
    public static readonly Currency FalklandIslandsPound = new(238, "Falkland Islands Pound", "FKP", "£");
    /// <summary>The Fijian Dollar currency.</summary>
    public static readonly Currency FijianDollar = new(242, "Fijian Dollar", "FJD", "$");
    /// <summary>The Gibraltar Pound currency.</summary>
    public static readonly Currency GibraltarPound = new(292, "Gibraltar Pound", "GIP", "£");
    /// <summary>The Guinean Franc currency.</summary>
    public static readonly Currency GuineanFranc = new(324, "Guinean Franc", "GNF", "FG");
    /// <summary>The Guyanese Dollar currency.</summary>
    public static readonly Currency GuyaneseDollar = new(328, "Guyanese Dollar", "GYD", "$");
    /// <summary>The Haitian Gourde currency.</summary>
    public static readonly Currency HaitianGourde = new(332, "Haitian Gourde", "HTG", "G");
    /// <summary>The Jamaican Dollar currency.</summary>
    public static readonly Currency JamaicanDollar = new(388, "Jamaican Dollar", "JMD", "J$");
    /// <summary>The Jordanian Dinar currency.</summary>
    public static readonly Currency JordanianDinar = new(400, "Jordanian Dinar", "JOD", "د.ا");
    /// <summary>The North Korean Won currency.</summary>
    public static readonly Currency NorthKoreanWon = new(408, "North Korean Won", "KPW", "₩");
    /// <summary>The Lao Kip currency.</summary>
    public static readonly Currency LaoKip = new(418, "Lao Kip", "LAK", "₭");
    /// <summary>The Lebanese Pound currency.</summary>
    public static readonly Currency LebanesePound = new(422, "Lebanese Pound", "LBP", "ل.ل");
    /// <summary>The Lesotho Loti currency.</summary>
    public static readonly Currency LesothoLoti = new(426, "Lesotho Loti", "LSL", "L");
    /// <summary>The Liberian Dollar currency.</summary>
    public static readonly Currency LiberianDollar = new(430, "Liberian Dollar", "LRD", "$");
    /// <summary>The Libyan Dinar currency.</summary>
    public static readonly Currency LibyanDinar = new(434, "Libyan Dinar", "LYD", "ل.د");
    /// <summary>The Macanese Pataca currency.</summary>
    public static readonly Currency MacanesePataca = new(446, "Macanese Pataca", "MOP", "MOP$");
    /// <summary>The Macedonian Denar currency.</summary>
    public static readonly Currency MacedonianDenar = new(807, "Macedonian Denar", "MKD", "ден");
    /// <summary>The Malagasy Ariary currency.</summary>
    public static readonly Currency MalagasyAriary = new(969, "Malagasy Ariary", "MGA", "Ar");
    /// <summary>The Malawian Kwacha currency.</summary>
    public static readonly Currency MalawianKwacha = new(454, "Malawian Kwacha", "MWK", "MK");
    /// <summary>The Maldivian Rufiyaa currency.</summary>
    public static readonly Currency MaldivianRufiyaa = new(462, "Maldivian Rufiyaa", "MVR", "Rf");
    /// <summary>The Mauritanian Ouguiya currency.</summary>
    public static readonly Currency MauritanianOuguiya = new(929, "Mauritanian Ouguiya", "MRU", "UM");
    /// <summary>The Mauritian Rupee currency.</summary>
    public static readonly Currency MauritianRupee = new(480, "Mauritian Rupee", "MUR", "₨");
    /// <summary>The Moldovan Leu currency.</summary>
    public static readonly Currency MoldovanLeu = new(498, "Moldovan Leu", "MDL", "L");
    /// <summary>The Mongolian Tugrik currency.</summary>
    public static readonly Currency MongolianTugrik = new(496, "Mongolian Tugrik", "MNT", "₮");
    /// <summary>The Mozambican Metical currency.</summary>
    public static readonly Currency MozambicanMetical = new(943, "Mozambican Metical", "MZN", "MT");
    /// <summary>The Myanmar Kyat currency.</summary>
    public static readonly Currency MyanmarKyat = new(104, "Myanmar Kyat", "MMK", "K");
    /// <summary>The Namibian Dollar currency.</summary>
    public static readonly Currency NamibianDollar = new(516, "Namibian Dollar", "NAD", "$");
    /// <summary>The Netherlands Antillean Guilder currency.</summary>
    public static readonly Currency NetherlandsAntilleanGuilder = new(532, "Netherlands Antillean Guilder", "ANG", "ƒ");
    /// <summary>The Nicaraguan Cordoba currency.</summary>
    public static readonly Currency NicaraguanCordoba = new(558, "Nicaraguan Cordoba", "NIO", "C$");
    /// <summary>The Papua New Guinean Kina currency.</summary>
    public static readonly Currency PapuaNewGuineanKina = new(598, "Papua New Guinean Kina", "PGK", "K");
    /// <summary>The Comorian Franc currency.</summary>
    public static readonly Currency ComorianFranc = new(174, "Comorian Franc", "KMF", "CF");
    /// <summary>The Saint Helena Pound currency.</summary>
    public static readonly Currency SaintHelenaPound = new(654, "Saint Helena Pound", "SHP", "£");
    /// <summary>The Samoan Tala currency.</summary>
    public static readonly Currency SamoanTala = new(882, "Samoan Tala", "WST", "T");
    /// <summary>The Sao Tome Dobra currency.</summary>
    public static readonly Currency SaoTomeDobra = new(930, "Sao Tome Dobra", "STN", "Db");
    /// <summary>The Serbian Dinar currency.</summary>
    public static readonly Currency SerbianDinar = new(941, "Serbian Dinar", "RSD", "din");
    /// <summary>The Seychellois Rupee currency.</summary>
    public static readonly Currency SeychelloisRupee = new(690, "Seychellois Rupee", "SCR", "₨");
    /// <summary>The Sierra Leonean Leone currency.</summary>
    public static readonly Currency SierraLeoneanLeone = new(925, "Sierra Leonean Leone", "SLE", "Le");
    /// <summary>The Solomon Islands Dollar currency.</summary>
    public static readonly Currency SolomonIslandsDollar = new(090, "Solomon Islands Dollar", "SBD", "$");
    /// <summary>The Somali Shilling currency.</summary>
    public static readonly Currency SomaliShilling = new(706, "Somali Shilling", "SOS", "Sh");
    /// <summary>The South Sudanese Pound currency.</summary>
    public static readonly Currency SouthSudanesePound = new(728, "South Sudanese Pound", "SSP", "£");
    /// <summary>The Sudanese Pound currency.</summary>
    public static readonly Currency SudanesePound = new(938, "Sudanese Pound", "SDG", "ج.س");
    /// <summary>The Surinamese Dollar currency.</summary>
    public static readonly Currency SurinameseDollar = new(968, "Surinamese Dollar", "SRD", "$");
    /// <summary>The Swazi Lilangeni currency.</summary>
    public static readonly Currency SwaziLilangeni = new(748, "Swazi Lilangeni", "SZL", "L");
    /// <summary>The Syrian Pound currency.</summary>
    public static readonly Currency SyrianPound = new(760, "Syrian Pound", "SYP", "£");
    /// <summary>The New Taiwan Dollar currency.</summary>
    public static readonly Currency NewTaiwanDollar = new(901, "New Taiwan Dollar", "TWD", "NT$");
    /// <summary>The Tanzanian Shilling currency.</summary>
    public static readonly Currency TanzanianShilling = new(834, "Tanzanian Shilling", "TZS", "TSh");
    /// <summary>The Tongan Paanga currency.</summary>
    public static readonly Currency TonganPaanga = new(776, "Tongan Paanga", "TOP", "T$");
    /// <summary>The Trinidad Dollar currency.</summary>
    public static readonly Currency TrinidadDollar = new(780, "Trinidad and Tobago Dollar", "TTD", "TT$");
    /// <summary>The Ugandan Shilling currency.</summary>
    public static readonly Currency UgandanShilling = new(800, "Ugandan Shilling", "UGX", "USh");
    /// <summary>The Vanuatu Vatu currency.</summary>
    public static readonly Currency VanuatuVatu = new(548, "Vanuatu Vatu", "VUV", "VT");
    /// <summary>The Venezuelan Bolivar currency.</summary>
    public static readonly Currency VenezuelanBolivar = new(928, "Venezuelan Bolivar Soberano", "VES", "Bs.S");
    /// <summary>The Yemeni Rial currency.</summary>
    public static readonly Currency YemeniRial = new(886, "Yemeni Rial", "YER", "﷼");
    /// <summary>The Zambian Kwacha currency.</summary>
    public static readonly Currency ZambianKwacha = new(967, "Zambian Kwacha", "ZMW", "ZK");
    /// <summary>The Zimbabwean Dollar currency.</summary>
    public static readonly Currency ZimbabweanDollar = new(932, "Zimbabwean Dollar", "ZWL", "Z$");
    /// <summary>The Rwandan Franc currency.</summary>
    public static readonly Currency RwandanFranc = new(646, "Rwandan Franc", "RWF", "RF");
    /// <summary>The Gambian Dalasi currency.</summary>
    public static readonly Currency GambianDalasi = new(270, "Gambian Dalasi", "GMD", "D");

    // ===== Static constructor — decimal places initialization =====
    static CurrencyHelper()
    {
        // 0 decimal places (no minor unit)
        foreach (var c in new[] { Yen, Won, Dong, Guarani, Forint, IcelandKrona,
            CfaFrancBceao, CfaFrancBeac, CfpFranc, ChileanPeso, BurundianFranc,
            DjiboutianFranc, GuineanFranc, RwandanFranc, VanuatuVatu, UgandanShilling })
            c.SetDecimalPlaces(0);

        // 3 decimal places
        foreach (var c in new[] { BahrainiDinar, KuwaitiDinar, RialOmani, TunisianDinar,
            LibyanDinar, IraqiDinar, JordanianDinar })
            c.SetDecimalPlaces(3);
    }

    // ===== Reflection-based lookup =====
    private static readonly Lazy<List<Currency>> _all = new(() =>
        [.. typeof(CurrencyHelper)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Currency) && f.Name != "None")
            .Select(f => (Currency)f.GetValue(null)!)
            .OrderBy(c => c.Name)]);

    private static readonly Lazy<IReadOnlyDictionary<string, Currency>> _codeMap = new(() =>
    {
        var map = new Dictionary<string, Currency> { { string.Empty, None } };
        foreach (var c in _all.Value)
            map[c.Code.ToLowerInvariant()] = c;
#if NET8_0_OR_GREATER
        return map.ToFrozenDictionary();
#else
        return map;
#endif
    });

    private static readonly Lazy<IReadOnlyDictionary<string, Currency>> _nameMap = new(() =>
    {
        var map = new Dictionary<string, Currency> { { string.Empty, None } };
        foreach (var c in _all.Value)
            map[c.Name.ToLowerInvariant()] = c;
#if NET8_0_OR_GREATER
        return map.ToFrozenDictionary();
#else
        return map;
#endif
    });

    private static readonly Lazy<IReadOnlyDictionary<int, Currency>> _numberMap = new(() =>
    {
        var map = new Dictionary<int, Currency> { { 0, None } };
        foreach (var c in _all.Value)
            map[c.Number] = c;
#if NET8_0_OR_GREATER
        return map.ToFrozenDictionary();
#else
        return map;
#endif
    });

    /// <summary>Gets all currencies.</summary>
    public static IReadOnlyList<Currency> GetAll() => _all.Value;
    /// <summary>Gets a dictionary mapping currency codes to currencies.</summary>
    public static IReadOnlyDictionary<string, Currency> CodeMap => _codeMap.Value;
    /// <summary>Gets a dictionary mapping currency names to currencies.</summary>
    public static IReadOnlyDictionary<string, Currency> NameMap => _nameMap.Value;
    /// <summary>Gets a dictionary mapping currency numbers to currencies.</summary>
    public static IReadOnlyDictionary<int, Currency> NumberMap => _numberMap.Value;
}
