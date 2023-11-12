using System.Runtime.CompilerServices;

namespace Multiverse;
public record Country
{
	#region Countries

	public static readonly Country None = new Country(string.Empty, string.Empty, string.Empty, string.Empty);

	public static readonly Country Afghanistan = new Country("Afghanistan", "004", "AF", "AFG");
	public static readonly Country AlandIslands = new Country("Aland Islands", "248", "AX", "ALA");
	public static readonly Country Albania = new Country("Albania", "008", "AL", "ALB");
	public static readonly Country Algeria = new Country("Algeria", "012", "DZ", "DZA");
	public static readonly Country AmericanSamoa = new Country("American Samoa", "016", "AS", "ASM");
	public static readonly Country Andorra = new Country("Andorra", "020", "AD", "AND");
	public static readonly Country Angola = new Country("Angola", "024", "AO", "AGO");
	public static readonly Country Anguilla = new Country("Anguilla", "660", "AI", "AIA");
	public static readonly Country Antarctica = new Country("Antarctica", "010", "AQ", "ATA");
	public static readonly Country AntiguaAndBarbuda = new Country("Antigua and Barbuda", "028", "AG", "ATG");
	public static readonly Country Argentina = new Country("Argentina", "032", "AR", "ARG");
	public static readonly Country Armenia = new Country("Armenia", "051", "AM", "ARM");
	public static readonly Country Aruba = new Country("Aruba", "533", "AW", "ABW");
	public static readonly Country Australia = new Country("Australia", "036", "AU", "AUS");
	public static readonly Country Austria = new Country("Austria", "040", "AT", "AUT");
	public static readonly Country Azerbaijan = new Country("Azerbaijan", "031", "AZ", "AZE");

	public static readonly Country Bahamas = new Country("Bahamas", "044", "BS", "BHS");
	public static readonly Country Bahrain = new Country("Bahrain", "048", "BH", "BHR");
	public static readonly Country Bangladesh = new Country("Bangladesh", "050", "BD", "BGD");
	public static readonly Country Barbados = new Country("Barbados", "052", "BB", "BRB");
	public static readonly Country Belarus = new Country("Belarus", "112", "BY", "BLR");
	public static readonly Country Belgium = new Country("Belgium", "056", "BE", "BEL");
	public static readonly Country Belize = new Country("Belize", "084", "BZ", "BLZ");
	public static readonly Country Benin = new Country("Benin", "204", "BJ", "BEN");
	public static readonly Country Bermuda = new Country("Bermuda", "060", "BM", "BMU");
	public static readonly Country Bhutan = new Country("Bhutan", "064", "BT", "BTN");
	public static readonly Country Bolivia = new Country("Bolivia", "068", "BO", "BOL");

	public static readonly Country BonaireSintEustatiusandSaba =
		new Country("Bonaire, Sint Eustatius and Saba", "535", "BQ", "BES");

	public static readonly Country BosniaAndHerzegovina = new Country("Bosnia and Herzegovina", "070", "BA", "BIH");
	public static readonly Country Botswana = new Country("Botswana", "072", "BW", "BWA");
	public static readonly Country BouvetIsland = new Country("Bouvet Island", "074", "BV", "BVT");
	public static readonly Country Brazil = new Country("Brazil", "076", "BR", "BRA");
	public static readonly Country BritishVirginIslands = new Country("British Virgin Islands", "092", "VG", "VGB");

	public static readonly Country BritishIndianOceanTerritory =
		new Country("British Indian Ocean Territory", "086", "IO", "IOT");

	public static readonly Country BruneiDarussalam = new Country("Brunei Darussalam", "096", "BN", "BRN");
	public static readonly Country Bulgaria = new Country("Bulgaria", "100", "BG", "BGR");
	public static readonly Country BurkinaFaso = new Country("Burkina Faso", "854", "BF", "BFA");
	public static readonly Country Burundi = new Country("Burundi", "108", "BI", "BDI");

	public static readonly Country Cambodia = new Country("Cambodia", "116", "KH", "KHM");
	public static readonly Country Cameroon = new Country("Cameroon", "120", "CM", "CMR");
	public static readonly Country Canada = new Country("Canada", "124", "CA", "CAN");
	public static readonly Country CapeVerde = new Country("Cape Verde", "132", "CV", "CPV");
	public static readonly Country CaymanIslands = new Country("Cayman Islands", "136", "KY", "CYM");
	public static readonly Country CentralAfricanRepublic = new Country("Central African Republic", "140", "CF", "CAF");
	public static readonly Country Chad = new Country("Chad", "148", "TD", "TCD");
	public static readonly Country Chile = new Country("Chile", "152", "CL", "CHL");
	public static readonly Country China = new Country("China", "156", "CN", "CHN");
	public static readonly Country HongKong = new Country("Hong Kong, SAR China", "344", "HK", "HKG");
	public static readonly Country Macao = new Country("Macao, SAR China", "446", "MO", "MAC");
	public static readonly Country ChristmasIsland = new Country("Christmas Island", "162", "CX", "CXR");
	public static readonly Country CocosIslands = new Country("Cocos (Keeling) Islands", "166", "CC", "CCK");
	public static readonly Country Colombia = new Country("Colombia", "170", "CO", "COL");
	public static readonly Country Comoros = new Country("Comoros", "174", "KM", "COM");
	public static readonly Country CongoBrazzaville = new Country("Congo (Brazzaville)", "178", "CG", "COG");
	public static readonly Country CongoKinshasa = new Country("Congo, (Kinshasa)", "180", "CD", "COD");
	public static readonly Country CookIslands = new Country("Cook Islands", "184", "CK", "COK");
	public static readonly Country CostaRica = new Country("Costa Rica", "188", "CR", "CRI");
	public static readonly Country CoteDIvoire = new Country("Côte d'Ivoire", "384", "CI", "CIV");
	public static readonly Country Croatia = new Country("Croatia", "191", "HR", "HRV");
	public static readonly Country Cuba = new Country("Cuba", "192", "CU", "CUB");
	public static readonly Country Cyprus = new Country("Cyprus", "196", "CY", "CYP");
	public static readonly Country Curacao = new Country(" Curaçao", "531", "CW", "CUW");

	public static readonly Country CzechRepublic = new Country("Czech Republic", "203", "CZ", "CZE");

	public static readonly Country Denmark = new Country("Denmark", "208", "DK", "DNK");
	public static readonly Country Djibouti = new Country("Djibouti", "262", "DJ", "DJI");
	public static readonly Country Dominica = new Country("Dominica", "212", "DM", "DMA");
	public static readonly Country DominicanRepublic = new Country("Dominican Republic", "214", "DO", "DOM");

	public static readonly Country Ecuador = new Country("Ecuador", "218", "EC", "ECU");
	public static readonly Country Egypt = new Country("Egypt", "818", "EG", "EGY");
	public static readonly Country ElSalvador = new Country("El Salvador", "222", "SV", "SLV");
	public static readonly Country EquatorialGuinea = new Country("Equatorial Guinea", "226", "GQ", "GNQ");
	public static readonly Country Eritrea = new Country("Eritrea", "232", "ER", "ERI");
	public static readonly Country Estonia = new Country("Estonia", "233", "EE", "EST");
	public static readonly Country Ethiopia = new Country("Ethiopia", "231", "ET", "ETH");

	public static readonly Country FalklandIslands = new Country("Falkland Islands (Malvinas)", "238", "FK", "FLK");
	public static readonly Country FaroeIslands = new Country("Faroe Islands", "234", "FO", "FRO");
	public static readonly Country Fiji = new Country("Fiji", "242", "FJ", "FJI");
	public static readonly Country Finland = new Country("Finland", "246", "FI", "FIN");
	public static readonly Country France = new Country("France", "250", "FR", "FRA");
	public static readonly Country FrenchGuiana = new Country("French Guiana", "254", "GF", "GUF");
	public static readonly Country FrenchPolynesia = new Country("French Polynesia", "258", "PF", "PYF");

	public static readonly Country FrenchSouthernTerritories =
		new Country("French Southern Territories", "260", "TF", "ATF");

	public static readonly Country Gabon = new Country("Gabon", "266", "GA", "GAB");
	public static readonly Country Gambia = new Country("Gambia", "270", "GM", "GMB");
	public static readonly Country Georgia = new Country("Georgia", "268", "GE", "GEO");
	public static readonly Country Germany = new Country("Germany", "276", "DE", "DEU");
	public static readonly Country Ghana = new Country("Ghana", "288", "GH", "GHA");
	public static readonly Country Gibraltar = new Country("Gibraltar", "292", "GI", "GIB");
	public static readonly Country Greece = new Country("Greece", "300", "GR", "GRC");
	public static readonly Country Greenland = new Country("Greenland", "304", "GL", "GRL");
	public static readonly Country Grenada = new Country("Grenada", "308", "GD", "GRD");
	public static readonly Country Guadeloupe = new Country("Guadeloupe", "312", "GP", "GLP");
	public static readonly Country Guam = new Country("Guam", "316", "GU", "GUM");
	public static readonly Country Guatemala = new Country("Guatemala", "320", "GT", "GTM");
	public static readonly Country Guernsey = new Country("Guernsey", "831", "GG", "GGY");
	public static readonly Country Guinea = new Country("Guinea", "324", "GN", "GIN");
	public static readonly Country GuineaBissau = new Country("Guinea-Bissau", "624", "GW", "GNB");
	public static readonly Country Guyana = new Country("Guyana", "328", "GY", "GUY");

	public static readonly Country Haiti = new Country("Haiti", "332", "HT", "HTI");

	public static readonly Country HeardAndMcdonaldIslands =
		new Country("Heard and McDonald Islands", "334", "HM", "HMD");

	public static readonly Country HolySee = new Country("Holy See (Vatican City State)", "336", "VA", "VAT");
	public static readonly Country Honduras = new Country("Honduras", "340", "HN", "HND");
	public static readonly Country Hungary = new Country("Hungary", "348", "HU", "HUN");

	public static readonly Country Iceland = new Country("Iceland", "352", "IS", "ISL");
	public static readonly Country India = new Country("India", "356", "IN", "IND");
	public static readonly Country Indonesia = new Country("Indonesia", "360", "ID", "IDN");
	public static readonly Country Iran = new Country("Iran, Islamic Republic of", "364", "IR", "IRN");
	public static readonly Country Iraq = new Country("Iraq", "368", "IQ", "IRQ");
	public static readonly Country Ireland = new Country("Ireland", "372", "IE", "IRL");
	public static readonly Country IsleOfMan = new Country("Isle of Man", "833", "IM", "IMN");
	public static readonly Country Israel = new Country("Israel", "376", "IL", "ISR");
	public static readonly Country Italy = new Country("Italy", "380", "IT", "ITA");

	public static readonly Country Jamaica = new Country("Jamaica", "388", "JM", "JAM");
	public static readonly Country Japan = new Country("Japan", "392", "JP", "JPN");
	public static readonly Country Jersey = new Country("Jersey", "832", "JE", "JEY");
	public static readonly Country Jordan = new Country("Jordan", "400", "JO", "JOR");

	public static readonly Country Kazakhstan = new Country("Kazakhstan", "398", "KZ", "KAZ");
	public static readonly Country Kenya = new Country("Kenya", "404", "KE", "KEN");
	public static readonly Country Kiribati = new Country("Kiribati", "296", "KI", "KIR");
	public static readonly Country KoreaNorth = new Country("Korea (North)", "408", "KP", "PRK");
	public static readonly Country KoreaSouth = new Country("Korea (South)", "410", "KR", "KOR");
	public static readonly Country Kuwait = new Country("Kuwait", "414", "KW", "KWT");
	public static readonly Country Kyrgyzstan = new Country("Kyrgyzstan", "417", "KG", "KGZ");

	public static readonly Country LaoPDR = new Country("Lao PDR", "418", "LA", "LAO");
	public static readonly Country Latvia = new Country("Latvia", "428", "LV", "LVA");
	public static readonly Country Lebanon = new Country("Lebanon", "422", "LB", "LBN");
	public static readonly Country Lesotho = new Country("Lesotho", "426", "LS", "LSO");
	public static readonly Country Liberia = new Country("Liberia", "430", "LR", "LBR");
	public static readonly Country Libya = new Country("Libya", "434", "LY", "LBY");
	public static readonly Country Liechtenstein = new Country("Liechtenstein", "438", "LI", "LIE");
	public static readonly Country Lithuania = new Country("Lithuania", "440", "LT", "LTU");
	public static readonly Country Luxembourg = new Country("Luxembourg", "442", "LU", "LUX");

	public static readonly Country MacedoniaRepublicOf = new Country("Macedonia, Republic of", "807", "MK", "MKD");
	public static readonly Country Madagascar = new Country("Madagascar", "450", "MG", "MDG");
	public static readonly Country Malawi = new Country("Malawi", "454", "MW", "MWI");
	public static readonly Country Malaysia = new Country("Malaysia", "458", "MY", "MYS");
	public static readonly Country Maldives = new Country("Maldives", "462", "MV", "MDV");
	public static readonly Country Mali = new Country("Mali", "466", "ML", "MLI");
	public static readonly Country Malta = new Country("Malta", "470", "MT", "MLT");
	public static readonly Country MarshallIslands = new Country("Marshall Islands", "584", "MH", "MHL");
	public static readonly Country Martinique = new Country("Martinique", "474", "MQ", "MTQ");
	public static readonly Country Mauritania = new Country("Mauritania", "478", "MR", "MRT");
	public static readonly Country Mauritius = new Country("Mauritius", "480", "MU", "MUS");
	public static readonly Country Mayotte = new Country("Mayotte", "175", "YT", "MYT");
	public static readonly Country Mexico = new Country("Mexico", "484", "MX", "MEX");

	public static readonly Country MicronesiaFederatedStatesOf =
		new Country("Micronesia, Federated States of", "583", "FM", "FSM");

	public static readonly Country Moldova = new Country("Moldova", "498", "MD", "MDA");
	public static readonly Country Monaco = new Country("Monaco", "492", "MC", "MCO");
	public static readonly Country Mongolia = new Country("Mongolia", "496", "MN", "MNG");
	public static readonly Country Montenegro = new Country("Montenegro", "499", "ME", "MNE");
	public static readonly Country Montserrat = new Country("Montserrat", "500", "MS", "MSR");
	public static readonly Country Morocco = new Country("Morocco", "504", "MA", "MAR");
	public static readonly Country Mozambique = new Country("Mozambique", "508", "MZ", "MOZ");
	public static readonly Country Myanmar = new Country("Myanmar", "104", "MM", "MMR");

	public static readonly Country Namibia = new Country("Namibia", "516", "NA", "NAM");
	public static readonly Country Nauru = new Country("Nauru", "520", "NR", "NRU");
	public static readonly Country Nepal = new Country("Nepal", "524", "NP", "NPL");
	public static readonly Country Netherlands = new Country("Netherlands", "528", "NL", "NLD");
	public static readonly Country NetherlandsAntilles = new Country("Netherlands Antilles", "530", "AN", "ANT");
	public static readonly Country NewCaledonia = new Country("New Caledonia", "540", "NC", "NCL");
	public static readonly Country NewZealand = new Country("New Zealand", "554", "NZ", "NZL");
	public static readonly Country Nicaragua = new Country("Nicaragua", "558", "NI", "NIC");
	public static readonly Country Niger = new Country("Niger", "562", "NE", "NER");
	public static readonly Country Nigeria = new Country("Nigeria", "566", "NG", "NGA");
	public static readonly Country Niue = new Country("Niue", "570", "NU", "NIU");
	public static readonly Country NorfolkIsland = new Country("Norfolk Island", "574", "NF", "NFK");
	public static readonly Country NorthernMarianaIslands = new Country("Northern Mariana Islands", "580", "MP", "MNP");
	public static readonly Country Norway = new Country("Norway", "578", "NO", "NOR");

	public static readonly Country Oman = new Country("Oman", "512", "OM", "OMN");

	public static readonly Country Pakistan = new Country("Pakistan", "586", "PK", "PAK");
	public static readonly Country Palau = new Country("Palau", "585", "PW", "PLW");

	public static readonly Country PalestinianTerritory = new Country("Palestinian Territory", "275", "PS", "PSE");
	public static readonly Country Panama = new Country("Panama", "591", "PA", "PAN");
	public static readonly Country PapuaNewGuinea = new Country("Papua New Guinea", "598", "PG", "PNG");
	public static readonly Country Paraguay = new Country("Paraguay", "600", "PY", "PRY");
	public static readonly Country Peru = new Country("Peru", "604", "PE", "PER");
	public static readonly Country Philippines = new Country("Philippines", "608", "PH", "PHL");
	public static readonly Country Pitcairn = new Country("Pitcairn", "612", "PN", "PCN");
	public static readonly Country Poland = new Country("Poland", "616", "PL", "POL");
	public static readonly Country Portugal = new Country("Portugal", "620", "PT", "PRT");
	public static readonly Country PuertoRico = new Country("Puerto Rico", "630", "PR", "PRI");

	public static readonly Country Qatar = new Country("Qatar", "634", "QA", "QAT");

	public static readonly Country Reunion = new Country("Réunion", "638", "RE", "REU");
	public static readonly Country Romania = new Country("Romania", "642", "RO", "ROU");
	public static readonly Country RussianFederation = new Country("Russian Federation", "643", "RU", "RUS");
	public static readonly Country Rwanda = new Country("Rwanda", "646", "RW", "RWA");

	public static readonly Country SaintBarthelemy = new Country("Saint-Barthélemy", "652", "BL", "BLM");
	public static readonly Country SaintHelena = new Country("Saint Helena", "654", "SH", "SHN");
	public static readonly Country SaintKittsAndNevis = new Country("Saint Kitts and Nevis", "659", "KN", "KNA");
	public static readonly Country SaintLucia = new Country("Saint Lucia", "662", "LC", "LCA");

	public static readonly Country SaintMartinFrenchPart =
		new Country("Saint-Martin (French part)", "663", "MF", "MAF");

	public static readonly Country SaintPierreAndMiquelon =
		new Country("Saint Pierre and Miquelon", "666", "PM", "SPM");

	public static readonly Country SaintVincentAndGrenadines =
		new Country("Saint Vincent and Grenadines", "670", "VC", "VCT");

	public static readonly Country Samoa = new Country("Samoa", "882", "WS", "WSM");
	public static readonly Country SanMarino = new Country("San Marino", "674", "SM", "SMR");
	public static readonly Country SaoTomeAndPrincipe = new Country("Sao Tome and Principe", "678", "ST", "STP");
	public static readonly Country SaudiArabia = new Country("Saudi Arabia", "682", "SA", "SAU");
	public static readonly Country Senegal = new Country("Senegal", "686", "SN", "SEN");
	public static readonly Country Serbia = new Country("Serbia", "688", "RS", "SRB");
	public static readonly Country Seychelles = new Country("Seychelles", "690", "SC", "SYC");
	public static readonly Country SierraLeone = new Country("Sierra Leone", "694", "SL", "SLE");
	public static readonly Country Singapore = new Country("Singapore", "702", "SG", "SGP");
	public static readonly Country SintMaarten = new Country("Sint Maarten (Dutch Part)", "534", "SX", "SXM");
	public static readonly Country Slovakia = new Country("Slovakia", "703", "SK", "SVK");
	public static readonly Country Slovenia = new Country("Slovenia", "705", "SI", "SVN");
	public static readonly Country SolomonIslands = new Country("Solomon Islands", "090", "SB", "SLB");
	public static readonly Country Somalia = new Country("Somalia", "706", "SO", "SOM");
	public static readonly Country SouthAfrica = new Country("South Africa", "710", "ZA", "ZAF");

	public static readonly Country SouthGeorgiaAndSouthSandwichIslands =
		new Country("South Georgia and the South Sandwich Islands", "239", "GS", "SGS");

	public static readonly Country SouthSudan = new Country("South Sudan", "728", "SS", "SSD");
	public static readonly Country Spain = new Country("Spain", "724", "ES", "ESP");
	public static readonly Country SriLanka = new Country("Sri Lanka", "144", "LK", "LKA");
	public static readonly Country Sudan = new Country("Sudan", "736", "SD", "SDN");
	public static readonly Country Suriname = new Country("Suriname", "740", "SR", "SUR");

	public static readonly Country SvalbardAndJanMayenIslands =
		new Country("Svalbard and Jan Mayen Islands", "744", "SJ", "SJM");

	public static readonly Country Swaziland_Eswatini = new Country("Swaziland (Eswatini)", "748", "SZ", "SWZ");
	public static readonly Country Sweden = new Country("Sweden", "752", "SE", "SWE");
	public static readonly Country Switzerland = new Country("Switzerland", "756", "CH", "CHE");
	public static readonly Country SyrianArabRepublic = new Country("Syrian Arab Republic (Syria)", "760", "SY", "SYR");

	public static readonly Country Taiwan = new Country("Taiwan, Republic of China", "158", "TW", "TWN");
	public static readonly Country Tajikistan = new Country("Tajikistan", "762", "TJ", "TJK");

	public static readonly Country TanzaniaUnitedRepublicOf =
		new Country("Tanzania, United Republic of", "834", "TZ", "TZA");

	public static readonly Country Thailand = new Country("Thailand", "764", "TH", "THA");
	public static readonly Country TimorLeste = new Country("Timor-Leste", "626", "TL", "TLS");
	public static readonly Country Togo = new Country("Togo", "768", "TG", "TGO");
	public static readonly Country Tokelau = new Country("Tokelau", "772", "TK", "TKL");
	public static readonly Country Tonga = new Country("Tonga", "776", "TO", "TON");
	public static readonly Country TrinidadAndTobago = new Country("Trinidad and Tobago", "780", "TT", "TTO");
	public static readonly Country Tunisia = new Country("Tunisia", "788", "TN", "TUN");
	public static readonly Country Turkey = new Country("Turkey", "792", "TR", "TUR");
	public static readonly Country Turkmenistan = new Country("Turkmenistan", "795", "TM", "TKM");
	public static readonly Country TurksAndCaicosIslands = new Country("Turks and Caicos Islands", "796", "TC", "TCA");
	public static readonly Country Tuvalu = new Country("Tuvalu", "798", "TV", "TUV");

	public static readonly Country Uganda = new Country("Uganda", "800", "UG", "UGA");
	public static readonly Country Ukraine = new Country("Ukraine", "804", "UA", "UKR");
	public static readonly Country UnitedArabEmirates = new Country("United Arab Emirates", "784", "AE", "ARE");
	public static readonly Country UnitedKingdom = new Country("United Kingdom", "826", "GB", "GBR");
	public static readonly Country UnitedStatesOfAmerica = new Country("United States of America", "840", "US", "USA");

	public static readonly Country USMinorOutlyingIslands =
		new Country("US Minor Outlying Islands", "581", "UM", "UMI");

	public static readonly Country Uruguay = new Country("Uruguay", "858", "UY", "URY");
	public static readonly Country Uzbekistan = new Country("Uzbekistan", "860", "UZ", "UZB");

	public static readonly Country Vanuatu = new Country("Vanuatu", "548", "VU", "VUT");

	public static readonly Country VenezuelaBolivarianRepublic =
		new Country("Venezuela (Bolivarian Republic)", "862", "VE", "VEN");

	public static readonly Country VietNam = new Country("Viet Nam", "704", "VN", "VNM");
	public static readonly Country VirginIslandsUS = new Country("Virgin Islands, US", "850", "VI", "VIR");

	public static readonly Country WallisAndFutunaIslands =
		new Country("Wallis and Futuna Islands", "876", "WF", "WLF");

	public static readonly Country WesternSahara = new Country("Western Sahara", "732", "EH", "ESH");

	public static readonly Country Yemen = new Country("Yemen", "887", "YE", "YEM");
	public static readonly Country Zambia = new Country("Zambia", "894", "ZM", "ZMB");
	public static readonly Country Zimbabwe = new Country("Zimbabwe", "716", "ZW", "ZWE");

	#endregion

	private Country(string name, string numericCode, string alpha2Code, string alpha3Code)
	{
		Name = name;
		NumericCode = numericCode;
		Alpha2Code = alpha2Code;
		Alpha3Code = alpha3Code;
	}
	public string Name { get; private set; } = string.Empty;
	public string Alpha3Code { get; private set; } = string.Empty;
	public string Alpha2Code { get; private set; } = string.Empty;
	public string NumericCode { get; private set; } = string.Empty;

	private static readonly IReadOnlyDictionary<string, Country> Alpha2CodeMap = new Dictionary<string, Country>()
	{
		{ "AW", Aruba },
		{ "AF", Afghanistan },
		{ "AO", Angola },
		{ "AI", Anguilla },
		{ "AX", AlandIslands },
		{ "AL", Albania },
		{ "AD", Andorra },
		{ "AE", UnitedArabEmirates },
		{ "AR", Argentina },
		{ "AM", Armenia },
		{ "AS", AmericanSamoa },
		{ "AQ", Antarctica },
		{ "TF", FrenchSouthernTerritories },
		{ "AG", AntiguaAndBarbuda },
		{ "AU", Australia },
		{ "AT", Austria },
		{ "AZ", Azerbaijan },
		{ "BI", Burundi },
		{ "BE", Belgium },
		{ "BJ", Benin },
		{ "BQ", BonaireSintEustatiusandSaba },
		{ "BF", BurkinaFaso },
		{ "BD", Bangladesh },
		{ "BG", Bulgaria },
		{ "BH", Bahrain },
		{ "BS", Bahamas },
		{ "BA", BosniaAndHerzegovina },
		{ "BL", SaintBarthelemy },
		{ "BY", Belarus },
		{ "BZ", Belize },
		{ "BM", Bermuda },
		{ "BO", Bolivia },
		{ "BR", Brazil },
		{ "BB", Barbados },
		{ "BN", BruneiDarussalam },
		{ "BT", Bhutan },
		{ "BV", BouvetIsland },
		{ "BW", Botswana },
		{ "CF", CentralAfricanRepublic },
		{ "CA", Canada },
		{ "CC", CocosIslands },
		{ "CH", Switzerland },
		{ "CL", Chile },
		{ "CN", China },
		{ "CI", CoteDIvoire },
		{ "CM", Cameroon },
		{ "CD", CongoKinshasa },
		{ "CG", CongoBrazzaville },
		{ "CK", CookIslands },
		{ "CO", Colombia },
		{ "KM", Comoros },
		{ "CV", CapeVerde },
		{ "CR", CostaRica },
		{ "CU", Cuba },
		{ "CW", Curacao },
		{ "CX", ChristmasIsland },
		{ "KY", CaymanIslands },
		{ "CY", Cyprus },
		{ "CZ", CzechRepublic },
		{ "DE", Germany },
		{ "DJ", Djibouti },
		{ "DM", Dominica },
		{ "DK", Denmark },
		{ "DO", DominicanRepublic },
		{ "DZ", Algeria },
		{ "EC", Ecuador },
		{ "EG", Egypt },
		{ "ER", Eritrea },
		{ "EH", WesternSahara },
		{ "ES", Spain },
		{ "EE", Estonia },
		{ "ET", Ethiopia },
		{ "FI", Finland },
		{ "FJ", Fiji },
		{ "FK", FalklandIslands },
		{ "FR", France },
		{ "FO", FaroeIslands },
		{ "FM", MicronesiaFederatedStatesOf },
		{ "GA", Gabon },
		{ "GB", UnitedKingdom },
		{ "GE", Georgia },
		{ "GG", Guernsey },
		{ "GH", Ghana },
		{ "GI", Gibraltar },
		{ "GN", Guinea },
		{ "GP", Guadeloupe },
		{ "GM", Gambia },
		{ "GW", GuineaBissau },
		{ "GQ", EquatorialGuinea },
		{ "GR", Greece },
		{ "GD", Grenada },
		{ "GL", Greenland },
		{ "GT", Guatemala },
		{ "GF", FrenchGuiana },
		{ "GU", Guam },
		{ "GY", Guyana },
		{ "HK", HongKong },
		{ "HM", HeardAndMcdonaldIslands },
		{ "HN", Honduras },
		{ "HR", Croatia },
		{ "HT", Haiti },
		{ "HU", Hungary },
		{ "ID", Indonesia },
		{ "IM", IsleOfMan },
		{ "IN", India },
		{ "IO", BritishIndianOceanTerritory },
		{ "IE", Ireland },
		{ "IR", Iran },
		{ "IQ", Iraq },
		{ "IS", Iceland },
		{ "IL", Israel },
		{ "IT", Italy },
		{ "JM", Jamaica },
		{ "JE", Jersey },
		{ "JO", Jordan },
		{ "JP", Japan },
		{ "KZ", Kazakhstan },
		{ "KE", Kenya },
		{ "KG", Kyrgyzstan },
		{ "KH", Cambodia },
		{ "KI", Kiribati },
		{ "KN", SaintKittsAndNevis },
		{ "KR", KoreaSouth },
		{ "KW", Kuwait },
		{ "LA", LaoPDR },
		{ "LB", Lebanon },
		{ "LR", Liberia },
		{ "LY", Libya },
		{ "LC", SaintLucia },
		{ "LI", Liechtenstein },
		{ "LK", SriLanka },
		{ "LS", Lesotho },
		{ "LT", Lithuania },
		{ "LU", Luxembourg },
		{ "LV", Latvia },
		{ "MO", Macao },
		{ "MF", SaintMartinFrenchPart },
		{ "MA", Morocco },
		{ "MC", Monaco },
		{ "MD", Moldova },
		{ "MG", Madagascar },
		{ "MV", Maldives },
		{ "MX", Mexico },
		{ "MH", MarshallIslands },
		{ "MK", MacedoniaRepublicOf },
		{ "ML", Mali },
		{ "MT", Malta },
		{ "MM", Myanmar },
		{ "ME", Montenegro },
		{ "MN", Mongolia },
		{ "MP", NorthernMarianaIslands },
		{ "MZ", Mozambique },
		{ "MR", Mauritania },
		{ "MS", Montserrat },
		{ "MQ", Martinique },
		{ "MU", Mauritius },
		{ "MW", Malawi },
		{ "MY", Malaysia },
		{ "YT", Mayotte },
		{ "NA", Namibia },
		{ "NC", NewCaledonia },
		{ "NE", Niger },
		{ "NF", NorfolkIsland },
		{ "NG", Nigeria },
		{ "NI", Nicaragua },
		{ "NU", Niue },
		{ "NL", Netherlands },
		{ "NO", Norway },
		{ "NP", Nepal },
		{ "NR", Nauru },
		{ "NZ", NewZealand },
		{ "OM", Oman },
		{ "PK", Pakistan },
		{ "PA", Panama },
		{ "PN", Pitcairn },
		{ "PE", Peru },
		{ "PH", Philippines },
		{ "PW", Palau },
		{ "PG", PapuaNewGuinea },
		{ "PL", Poland },
		{ "PR", PuertoRico },
		{ "KP", KoreaNorth },
		{ "PT", Portugal },
		{ "PY", Paraguay },
		{ "PS", PalestinianTerritory },
		{ "PF", FrenchPolynesia },
		{ "QA", Qatar },
		{ "RE", Reunion },
		{ "RO", Romania },
		{ "RU", RussianFederation },
		{ "RW", Rwanda },
		{ "SA", SaudiArabia },
		{ "SD", Sudan },
		{ "SN", Senegal },
		{ "SG", Singapore },
		{ "GS", SouthGeorgiaAndSouthSandwichIslands },
		{ "SH", SaintHelena },
		{ "SJ", SvalbardAndJanMayenIslands },
		{ "SB", SolomonIslands },
		{ "SL", SierraLeone },
		{ "SV", ElSalvador },
		{ "SM", SanMarino },
		{ "SO", Somalia },
		{ "PM", SaintPierreAndMiquelon },
		{ "RS", Serbia },
		{ "SS", SouthSudan },
		{ "ST", SaoTomeAndPrincipe },
		{ "SR", Suriname },
		{ "SK", Slovakia },
		{ "SI", Slovenia },
		{ "SE", Sweden },
		{ "SZ", Swaziland_Eswatini },
		{ "SX", SintMaarten },
		{ "SC", Seychelles },
		{ "SY", SyrianArabRepublic },
		{ "TC", TurksAndCaicosIslands },
		{ "TD", Chad },
		{ "TG", Togo },
		{ "TH", Thailand },
		{ "TJ", Tajikistan },
		{ "TK", Tokelau },
		{ "TM", Turkmenistan },
		{ "TL", TimorLeste },
		{ "TO", Tonga },
		{ "TT", TrinidadAndTobago },
		{ "TN", Tunisia },
		{ "TR", Turkey },
		{ "TV", Tuvalu },
		{ "TW", Taiwan },
		{ "TZ", TanzaniaUnitedRepublicOf },
		{ "UG", Uganda },
		{ "UA", Ukraine },
		{ "UM", USMinorOutlyingIslands },
		{ "UY", Uruguay },
		{ "US", UnitedStatesOfAmerica },
		{ "UZ", Uzbekistan },
		{ "VA", HolySee },
		{ "VC", SaintVincentAndGrenadines },
		{ "VE", VenezuelaBolivarianRepublic },
		{ "VG", BritishVirginIslands },
		{ "VI", VirginIslandsUS },
		{ "VN", VietNam },
		{ "VU", Vanuatu },
		{ "WF", WallisAndFutunaIslands },
		{ "WS", Samoa },
		{ "YE", Yemen },
		{ "ZA", SouthAfrica },
		{ "ZM", Zambia },
		{ "ZW", Zimbabwe }
	};

	private static readonly IReadOnlyDictionary<string, Country> Alpha3CodeMap = new Dictionary<string, Country>()
	{
		{ "ABW", Aruba },
		{ "AFG", Afghanistan },
		{ "AGO", Angola },
		{ "AIA", Anguilla },
		{ "ALA", AlandIslands },
		{ "ALB", Albania },
		{ "AND", Andorra },
		{ "ARE", UnitedArabEmirates },
		{ "ARG", Argentina },
		{ "ARM", Armenia },
		{ "ASM", AmericanSamoa },
		{ "ATA", Antarctica },
		{ "ATF", FrenchSouthernTerritories },
		{ "ATG", AntiguaAndBarbuda },
		{ "AUS", Australia },
		{ "AUT", Austria },
		{ "AZE", Azerbaijan },
		{ "BDI", Burundi },
		{ "BEL", Belgium },
		{ "BEN", Benin },
		{ "BES", BonaireSintEustatiusandSaba },
		{ "BFA", BurkinaFaso },
		{ "BGD", Bangladesh },
		{ "BGR", Bulgaria },
		{ "BHR", Bahrain },
		{ "BHS", Bahamas },
		{ "BIH", BosniaAndHerzegovina },
		{ "BLM", SaintBarthelemy },
		{ "BLR", Belarus },
		{ "BLZ", Belize },
		{ "BMU", Bermuda },
		{ "BOL", Bolivia },
		{ "BRA", Brazil },
		{ "BRB", Barbados },
		{ "BRN", BruneiDarussalam },
		{ "BTN", Bhutan },
		{ "BVT", BouvetIsland },
		{ "BWA", Botswana },
		{ "CAF", CentralAfricanRepublic },
		{ "CAN", Canada },
		{ "CCK", CocosIslands },
		{ "CHE", Switzerland },
		{ "CHL", Chile },
		{ "CHN", China },
		{ "CIV", CoteDIvoire },
		{ "CMR", Cameroon },
		{ "COD", CongoKinshasa },
		{ "COG", CongoBrazzaville },
		{ "COK", CookIslands },
		{ "COL", Colombia },
		{ "COM", Comoros },
		{ "CPV", CapeVerde },
		{ "CRI", CostaRica },
		{ "CUB", Cuba },
		{ "CUW", Curacao },
		{ "CXR", ChristmasIsland },
		{ "CYM", CaymanIslands },
		{ "CYP", Cyprus },
		{ "CZE", CzechRepublic },
		{ "DEU", Germany },
		{ "DJI", Djibouti },
		{ "DMA", Dominica },
		{ "DNK", Denmark },
		{ "DOM", DominicanRepublic },
		{ "DZA", Algeria },
		{ "ECU", Ecuador },
		{ "EGY", Egypt },
		{ "ERI", Eritrea },
		{ "ESH", WesternSahara },
		{ "ESP", Spain },
		{ "EST", Estonia },
		{ "ETH", Ethiopia },
		{ "FIN", Finland },
		{ "FJI", Fiji },
		{ "FLK", FalklandIslands },
		{ "FRA", France },
		{ "FRO", FaroeIslands },
		{ "FSM", MicronesiaFederatedStatesOf },
		{ "GAB", Gabon },
		{ "GBR", UnitedKingdom },
		{ "GEO", Georgia },
		{ "GGY", Guernsey },
		{ "GHA", Ghana },
		{ "GIB", Gibraltar },
		{ "GIN", Guinea },
		{ "GLP", Guadeloupe },
		{ "GMB", Gambia },
		{ "GNB", GuineaBissau },
		{ "GNQ", EquatorialGuinea },
		{ "GRC", Greece },
		{ "GRD", Grenada },
		{ "GRL", Greenland },
		{ "GTM", Guatemala },
		{ "GUF", FrenchGuiana },
		{ "GUM", Guam },
		{ "GUY", Guyana },
		{ "HKG", HongKong },
		{ "HMD", HeardAndMcdonaldIslands },
		{ "HND", Honduras },
		{ "HRV", Croatia },
		{ "HTI", Haiti },
		{ "HUN", Hungary },
		{ "IDN", Indonesia },
		{ "IMN", IsleOfMan },
		{ "IND", India },
		{ "IOT", BritishIndianOceanTerritory },
		{ "IRL", Ireland },
		{ "IRN", Iran },
		{ "IRQ", Iraq },
		{ "ISL", Iceland },
		{ "ISR", Israel },
		{ "ITA", Italy },
		{ "JAM", Jamaica },
		{ "JEY", Jersey },
		{ "JOR", Jordan },
		{ "JPN", Japan },
		{ "KAZ", Kazakhstan },
		{ "KEN", Kenya },
		{ "KGZ", Kyrgyzstan },
		{ "KHM", Cambodia },
		{ "KIR", Kiribati },
		{ "KNA", SaintKittsAndNevis },
		{ "KOR", KoreaSouth },
		{ "KWT", Kuwait },
		{ "LAO", LaoPDR },
		{ "LBN", Lebanon },
		{ "LBR", Liberia },
		{ "LBY", Libya },
		{ "LCA", SaintLucia },
		{ "LIE", Liechtenstein },
		{ "LKA", SriLanka },
		{ "LSO", Lesotho },
		{ "LTU", Lithuania },
		{ "LUX", Luxembourg },
		{ "LVA", Latvia },
		{ "MAC", Macao },
		{ "MAF", SaintMartinFrenchPart },
		{ "MAR", Morocco },
		{ "MCO", Monaco },
		{ "MDA", Moldova },
		{ "MDG", Madagascar },
		{ "MDV", Maldives },
		{ "MEX", Mexico },
		{ "MHL", MarshallIslands },
		{ "MKD", MacedoniaRepublicOf },
		{ "MLI", Mali },
		{ "MLT", Malta },
		{ "MMR", Myanmar },
		{ "MNE", Montenegro },
		{ "MNG", Mongolia },
		{ "MNP", NorthernMarianaIslands },
		{ "MOZ", Mozambique },
		{ "MRT", Mauritania },
		{ "MSR", Montserrat },
		{ "MTQ", Martinique },
		{ "MUS", Mauritius },
		{ "MWI", Malawi },
		{ "MYS", Malaysia },
		{ "MYT", Mayotte },
		{ "NAM", Namibia },
		{ "NCL", NewCaledonia },
		{ "NER", Niger },
		{ "NFK", NorfolkIsland },
		{ "NGA", Nigeria },
		{ "NIC", Nicaragua },
		{ "NIU", Niue },
		{ "NLD", Netherlands },
		{ "NOR", Norway },
		{ "NPL", Nepal },
		{ "NRU", Nauru },
		{ "NZL", NewZealand },
		{ "OMN", Oman },
		{ "PAK", Pakistan },
		{ "PAN", Panama },
		{ "PCN", Pitcairn },
		{ "PER", Peru },
		{ "PHL", Philippines },
		{ "PLW", Palau },
		{ "PNG", PapuaNewGuinea },
		{ "POL", Poland },
		{ "PRI", PuertoRico },
		{ "PRK", KoreaNorth },
		{ "PRT", Portugal },
		{ "PRY", Paraguay },
		{ "PSE", PalestinianTerritory },
		{ "PYF", FrenchPolynesia },
		{ "QAT", Qatar },
		{ "REU", Reunion },
		{ "ROU", Romania },
		{ "RUS", RussianFederation },
		{ "RWA", Rwanda },
		{ "SAU", SaudiArabia },
		{ "SDN", Sudan },
		{ "SEN", Senegal },
		{ "SGP", Singapore },
		{ "SGS", SouthGeorgiaAndSouthSandwichIslands },
		{ "SHN", SaintHelena },
		{ "SJM", SvalbardAndJanMayenIslands },
		{ "SLB", SolomonIslands },
		{ "SLE", SierraLeone },
		{ "SLV", ElSalvador },
		{ "SMR", SanMarino },
		{ "SOM", Somalia },
		{ "SPM", SaintPierreAndMiquelon },
		{ "SRB", Serbia },
		{ "SSD", SouthSudan },
		{ "STP", SaoTomeAndPrincipe },
		{ "SUR", Suriname },
		{ "SVK", Slovakia },
		{ "SVN", Slovenia },
		{ "SWE", Sweden },
		{ "SWZ", Swaziland_Eswatini },
		{ "SXM", SintMaarten },
		{ "SYC", Seychelles },
		{ "SYR", SyrianArabRepublic },
		{ "TCA", TurksAndCaicosIslands },
		{ "TCD", Chad },
		{ "TGO", Togo },
		{ "THA", Thailand },
		{ "TJK", Tajikistan },
		{ "TKL", Tokelau },
		{ "TKM", Turkmenistan },
		{ "TLS", TimorLeste },
		{ "TON", Tonga },
		{ "TTO", TrinidadAndTobago },
		{ "TUN", Tunisia },
		{ "TUR", Turkey },
		{ "TUV", Tuvalu },
		{ "TWN", Taiwan },
		{ "TZA", TanzaniaUnitedRepublicOf },
		{ "UGA", Uganda },
		{ "UKR", Ukraine },
		{ "UMI", USMinorOutlyingIslands },
		{ "URY", Uruguay },
		{ "USA", UnitedStatesOfAmerica },
		{ "UZB", Uzbekistan },
		{ "VAT", HolySee },
		{ "VCT", SaintVincentAndGrenadines },
		{ "VEN", VenezuelaBolivarianRepublic },
		{ "VGB", BritishVirginIslands },
		{ "VIR", VirginIslandsUS },
		{ "VNM", VietNam },
		{ "VUT", Vanuatu },
		{ "WLF", WallisAndFutunaIslands },
		{ "WSM", Samoa },
		{ "YEM", Yemen },
		{ "ZAF", SouthAfrica },
		{ "ZMB", Zambia },
		{ "ZWE", Zimbabwe }
	};

	private static readonly IReadOnlyDictionary<string, Country> NumricCodeMap = new Dictionary<string, Country>()
	{
		{ "533", Aruba },
		{ "004", Afghanistan },
		{ "024", Angola },
		{ "660", Anguilla },
		{ "248", AlandIslands },
		{ "008", Albania },
		{ "020", Andorra },
		{ "784", UnitedArabEmirates },
		{ "032", Argentina },
		{ "051", Armenia },
		{ "016", AmericanSamoa },
		{ "010", Antarctica },
		{ "260", FrenchSouthernTerritories },
		{ "028", AntiguaAndBarbuda },
		{ "036", Australia },
		{ "040", Austria },
		{ "031", Azerbaijan },
		{ "108", Burundi },
		{ "056", Belgium },
		{ "204", Benin },
		{ "535", BonaireSintEustatiusandSaba },
		{ "854", BurkinaFaso },
		{ "050", Bangladesh },
		{ "100", Bulgaria },
		{ "048", Bahrain },
		{ "044", Bahamas },
		{ "070", BosniaAndHerzegovina },
		{ "652", SaintBarthelemy },
		{ "112", Belarus },
		{ "084", Belize },
		{ "060", Bermuda },
		{ "068", Bolivia },
		{ "076", Brazil },
		{ "052", Barbados },
		{ "096", BruneiDarussalam },
		{ "064", Bhutan },
		{ "074", BouvetIsland },
		{ "072", Botswana },
		{ "140", CentralAfricanRepublic },
		{ "124", Canada },
		{ "166", CocosIslands },
		{ "756", Switzerland },
		{ "152", Chile },
		{ "156", China },
		{ "384", CoteDIvoire },
		{ "120", Cameroon },
		{ "180", CongoKinshasa },
		{ "178", CongoBrazzaville },
		{ "184", CookIslands },
		{ "170", Colombia },
		{ "174", Comoros },
		{ "132", CapeVerde },
		{ "188", CostaRica },
		{ "192", Cuba },
		{ "531", Curacao },
		{ "162", ChristmasIsland },
		{ "136", CaymanIslands },
		{ "196", Cyprus },
		{ "203", CzechRepublic },
		{ "276", Germany },
		{ "262", Djibouti },
		{ "212", Dominica },
		{ "208", Denmark },
		{ "214", DominicanRepublic },
		{ "012", Algeria },
		{ "218", Ecuador },
		{ "818", Egypt },
		{ "232", Eritrea },
		{ "732", WesternSahara },
		{ "724", Spain },
		{ "233", Estonia },
		{ "231", Ethiopia },
		{ "246", Finland },
		{ "242", Fiji },
		{ "238", FalklandIslands },
		{ "250", France },
		{ "234", FaroeIslands },
		{ "583", MicronesiaFederatedStatesOf },
		{ "266", Gabon },
		{ "826", UnitedKingdom },
		{ "268", Georgia },
		{ "831", Guernsey },
		{ "288", Ghana },
		{ "292", Gibraltar },
		{ "324", Guinea },
		{ "312", Guadeloupe },
		{ "270", Gambia },
		{ "624", GuineaBissau },
		{ "226", EquatorialGuinea },
		{ "300", Greece },
		{ "308", Grenada },
		{ "304", Greenland },
		{ "320", Guatemala },
		{ "254", FrenchGuiana },
		{ "316", Guam },
		{ "328", Guyana },
		{ "344", HongKong },
		{ "334", HeardAndMcdonaldIslands },
		{ "340", Honduras },
		{ "191", Croatia },
		{ "332", Haiti },
		{ "348", Hungary },
		{ "360", Indonesia },
		{ "833", IsleOfMan },
		{ "356", India },
		{ "086", BritishIndianOceanTerritory },
		{ "372", Ireland },
		{ "364", Iran },
		{ "368", Iraq },
		{ "352", Iceland },
		{ "376", Israel },
		{ "380", Italy },
		{ "388", Jamaica },
		{ "832", Jersey },
		{ "400", Jordan },
		{ "392", Japan },
		{ "398", Kazakhstan },
		{ "404", Kenya },
		{ "417", Kyrgyzstan },
		{ "116", Cambodia },
		{ "296", Kiribati },
		{ "659", SaintKittsAndNevis },
		{ "410", KoreaSouth },
		{ "414", Kuwait },
		{ "418", LaoPDR },
		{ "422", Lebanon },
		{ "430", Liberia },
		{ "434", Libya },
		{ "662", SaintLucia },
		{ "438", Liechtenstein },
		{ "144", SriLanka },
		{ "426", Lesotho },
		{ "440", Lithuania },
		{ "442", Luxembourg },
		{ "428", Latvia },
		{ "446", Macao },
		{ "663", SaintMartinFrenchPart },
		{ "504", Morocco },
		{ "492", Monaco },
		{ "498", Moldova },
		{ "450", Madagascar },
		{ "462", Maldives },
		{ "484", Mexico },
		{ "584", MarshallIslands },
		{ "807", MacedoniaRepublicOf },
		{ "466", Mali },
		{ "470", Malta },
		{ "104", Myanmar },
		{ "499", Montenegro },
		{ "496", Mongolia },
		{ "580", NorthernMarianaIslands },
		{ "508", Mozambique },
		{ "478", Mauritania },
		{ "500", Montserrat },
		{ "474", Martinique },
		{ "480", Mauritius },
		{ "454", Malawi },
		{ "458", Malaysia },
		{ "175", Mayotte },
		{ "516", Namibia },
		{ "540", NewCaledonia },
		{ "562", Niger },
		{ "574", NorfolkIsland },
		{ "566", Nigeria },
		{ "558", Nicaragua },
		{ "570", Niue },
		{ "528", Netherlands },
		{ "578", Norway },
		{ "524", Nepal },
		{ "520", Nauru },
		{ "554", NewZealand },
		{ "512", Oman },
		{ "586", Pakistan },
		{ "591", Panama },
		{ "612", Pitcairn },
		{ "604", Peru },
		{ "608", Philippines },
		{ "585", Palau },
		{ "598", PapuaNewGuinea },
		{ "616", Poland },
		{ "630", PuertoRico },
		{ "408", KoreaNorth },
		{ "620", Portugal },
		{ "600", Paraguay },
		{ "275", PalestinianTerritory },
		{ "258", FrenchPolynesia },
		{ "634", Qatar },
		{ "638", Reunion },
		{ "642", Romania },
		{ "643", RussianFederation },
		{ "646", Rwanda },
		{ "682", SaudiArabia },
		{ "729", Sudan },
		{ "686", Senegal },
		{ "702", Singapore },
		{ "239", SouthGeorgiaAndSouthSandwichIslands },
		{ "654", SaintHelena },
		{ "744", SvalbardAndJanMayenIslands },
		{ "090", SolomonIslands },
		{ "694", SierraLeone },
		{ "222", ElSalvador },
		{ "674", SanMarino },
		{ "706", Somalia },
		{ "666", SaintPierreAndMiquelon },
		{ "688", Serbia },
		{ "728", SouthSudan },
		{ "678", SaoTomeAndPrincipe },
		{ "740", Suriname },
		{ "703", Slovakia },
		{ "705", Slovenia },
		{ "752", Sweden },
		{ "748", Swaziland_Eswatini },
		{ "534", SintMaarten },
		{ "690", Seychelles },
		{ "760", SyrianArabRepublic },
		{ "796", TurksAndCaicosIslands },
		{ "148", Chad },
		{ "768", Togo },
		{ "764", Thailand },
		{ "762", Tajikistan },
		{ "772", Tokelau },
		{ "795", Turkmenistan },
		{ "626", TimorLeste },
		{ "776", Tonga },
		{ "780", TrinidadAndTobago },
		{ "788", Tunisia },
		{ "792", Turkey },
		{ "798", Tuvalu },
		{ "158", Taiwan },
		{ "834", TanzaniaUnitedRepublicOf },
		{ "800", Uganda },
		{ "804", Ukraine },
		{ "581", USMinorOutlyingIslands },
		{ "858", Uruguay },
		{ "840", UnitedStatesOfAmerica },
		{ "860", Uzbekistan },
		{ "336", HolySee },
		{ "670", SaintVincentAndGrenadines },
		{ "862", VenezuelaBolivarianRepublic },
		{ "092", BritishVirginIslands },
		{ "850", VirginIslandsUS },
		{ "704", VietNam },
		{ "548", Vanuatu },
		{ "876", WallisAndFutunaIslands },
		{ "882", Samoa },
		{ "887", Yemen },
		{ "710", SouthAfrica },
		{ "894", Zambia },
		{ "716", Zimbabwe }
	};

	public static bool IsValidAlpha2Code(string? code)
	{
		if(!string.IsNullOrEmpty(code))
		{
			code = code.ToUpperInvariant();

			return Alpha2CodeMap.ContainsKey(code);
		}

		return false;
	}

	public static bool IsValidAlpha3Code(string? code)
	{
		if(!string.IsNullOrEmpty(code))
		{
			code = code.ToUpperInvariant();

			return Alpha3CodeMap.ContainsKey(code);
		}
		return false;
	}

	public static bool IsValidCode(string code)
	{
		if(!string.IsNullOrEmpty(code))
		{
			code = code.ToUpperInvariant();

			return IsValidAlpha2Code(code) || IsValidAlpha3Code(code);
		}

		return false;
	}

	public static Country FromAlpha2Code(
		string? code,
		[CallerArgumentExpression("code")] string? paramName = null
	)
	{
		if(!string.IsNullOrEmpty(code))
		{
			code = code.ToUpperInvariant();

			if(Alpha2CodeMap.ContainsKey(code))
			{
				return Alpha2CodeMap[code];
			}

			throw new ApplicationException($"Country with alpha2 code : {code} is not supported for : {paramName}");
		}

		throw new ApplicationException($"Country with empty code is not supported for : {paramName}");
	}

	public static Country FromAlpha3Code(
		string? code,
		[CallerArgumentExpression("code")] string? paramName = null
	)
	{
		if(!string.IsNullOrEmpty(code))
		{
			code = code.ToUpperInvariant();

			if(Alpha3CodeMap.ContainsKey(code))
			{
				return Alpha3CodeMap[code];
			}

			throw new ApplicationException($"Country with alpha3 code : {code} is not supported for :  {paramName}	");
		}
		
		throw new ApplicationException($"Country with empty code is not supported for : {paramName}");
	}

	public static Country FromNumericCode(string? code)
	{
		if(!string.IsNullOrEmpty(code))
		{

			if(NumricCodeMap.ContainsKey(code))
			{
				return NumricCodeMap[code];
			}

			throw new ApplicationException($"Country with code : {code} is not supported");
		}

		return None;
	}
}
