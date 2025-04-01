using System.Collections.Generic;

namespace Multiverse.Globalization.Countries;

public static class CountryHelper
{
    public static readonly Country None = new Country ("", "", "", "");
    public static readonly Country Afghanistan = new Country(CountryNames.Afghanistan, "004", "AF", "AFG");
    public static readonly Country AlandIslands = new Country(CountryNames.AlandIslands, "248", "AX", "ALA");
    public static readonly Country Albania = new Country(CountryNames.Albania, "008", "AL", "ALB");
    public static readonly Country Algeria = new Country(CountryNames.Algeria, "012", "DZ", "DZA");
    public static readonly Country AmericanSamoa = new Country(CountryNames.AmericanSamoa, "016", "AS", "ASM");
    public static readonly Country Andorra = new Country(CountryNames.Andorra, "020", "AD", "AND");
    public static readonly Country Angola = new Country(CountryNames.Angola, "024", "AO", "AGO");
    public static readonly Country Anguilla = new Country(CountryNames.Anguilla, "660", "AI", "AIA");
    public static readonly Country Antarctica = new Country(CountryNames.Antarctica, "010", "AQ", "ATA");
    public static readonly Country AntiguaAndBarbuda = new Country(CountryNames.AntiguaAndBarbuda, "028", "AG", "ATG");
    public static readonly Country Argentina = new Country(CountryNames.Argentina, "032", "AR", "ARG");
    public static readonly Country Armenia = new Country(CountryNames.Armenia, "051", "AM", "ARM");
    public static readonly Country Aruba = new Country(CountryNames.Aruba, "533", "AW", "ABW");
    public static readonly Country Australia = new Country(CountryNames.Australia, "036", "AU", "AUS");
    public static readonly Country Austria = new Country(CountryNames.Austria, "040", "AT", "AUT");
    public static readonly Country Azerbaijan = new Country(CountryNames.Azerbaijan, "031", "AZ", "AZE");
    public static readonly Country Bahamas = new Country(CountryNames.Bahamas, "044", "BS", "BHS");
    public static readonly Country Bahrain = new Country(CountryNames.Bahrain, "048", "BH", "BHR");
    public static readonly Country Bangladesh = new Country(CountryNames.Bangladesh, "050", "BD", "BGD");
    public static readonly Country Barbados = new Country(CountryNames.Barbados, "052", "BB", "BRB");
    public static readonly Country Belarus = new Country(CountryNames.Belarus, "112", "BY", "BLR");
    public static readonly Country Belgium = new Country(CountryNames.Belgium, "056", "BE", "BEL");
    public static readonly Country Belize = new Country(CountryNames.Belize, "084", "BZ", "BLZ");
    public static readonly Country Benin = new Country(CountryNames.Benin, "204", "BJ", "BEN");
    public static readonly Country Bermuda = new Country(CountryNames.Bermuda, "060", "BM", "BMU");
    public static readonly Country Bhutan = new Country(CountryNames.Bhutan, "064", "BT", "BTN");
    public static readonly Country Bolivia = new Country(CountryNames.Bolivia, "068", "BO", "BOL");

    public static readonly Country BonaireSintEustatiusandSaba =
        new Country(CountryNames.BonaireSintEustatiusandSaba, "535", "BQ", "BES");

    public static readonly Country BosniaAndHerzegovina = new Country(CountryNames.BosniaAndHerzegovina, "070", "BA", "BIH");
    public static readonly Country Botswana = new Country(CountryNames.Botswana, "072", "BW", "BWA");
    public static readonly Country BouvetIsland = new Country(CountryNames.BouvetIsland, "074", "BV", "BVT");
    public static readonly Country Brazil = new Country(CountryNames.Brazil, "076", "BR", "BRA");
    public static readonly Country BritishVirginIslands = new Country(CountryNames.BritishVirginIslands, "092", "VG", "VGB");

    public static readonly Country BritishIndianOceanTerritory =
        new Country(CountryNames.BritishIndianOceanTerritory, "086", "IO", "IOT");

    public static readonly Country BruneiDarussalam = new Country(CountryNames.BruneiDarussalam, "096", "BN", "BRN");
    public static readonly Country Bulgaria = new Country(CountryNames.Bulgaria, "100", "BG", "BGR");
    public static readonly Country BurkinaFaso = new Country(CountryNames.BurkinaFaso, "854", "BF", "BFA");
    public static readonly Country Burundi = new Country(CountryNames.Burundi, "108", "BI", "BDI");

    public static readonly Country Cambodia = new Country(CountryNames.Cambodia, "116", "KH", "KHM");
    public static readonly Country Cameroon = new Country(CountryNames.Cameroon, "120", "CM", "CMR");
    public static readonly Country Canada = new Country(CountryNames.Canada, "124", "CA", "CAN");
    public static readonly Country CapeVerde = new Country(CountryNames.CapeVerde, "132", "CV", "CPV");
    public static readonly Country CaymanIslands = new Country(CountryNames.CaymanIslands, "136", "KY", "CYM");
    public static readonly Country CentralAfricanRepublic = new Country(CountryNames.CentralAfricanRepublic, "140", "CF", "CAF");
    public static readonly Country Chad = new Country(CountryNames.Chad, "148", "TD", "TCD");
    public static readonly Country Chile = new Country(CountryNames.Chile, "152", "CL", "CHL");
    public static readonly Country China = new Country(CountryNames.China, "156", "CN", "CHN");
    public static readonly Country HongKong = new Country(CountryNames.HongKong, "344", "HK", "HKG");
    public static readonly Country Macao = new Country(CountryNames.Macao, "446", "MO", "MAC");
    public static readonly Country ChristmasIsland = new Country(CountryNames.ChristmasIsland, "162", "CX", "CXR");
    public static readonly Country CocosIslands = new Country(CountryNames.CocosIslands, "166", "CC", "CCK");
    public static readonly Country Colombia = new Country(CountryNames.Colombia, "170", "CO", "COL");
    public static readonly Country Comoros = new Country(CountryNames.Comoros, "174", "KM", "COM");
    public static readonly Country CongoBrazzaville = new Country(CountryNames.CongoBrazzaville, "178", "CG", "COG");
    public static readonly Country CongoKinshasa = new Country(CountryNames.CongoKinshasa, "180", "CD", "COD");
    public static readonly Country CookIslands = new Country(CountryNames.CookIslands, "184", "CK", "COK");
    public static readonly Country CostaRica = new Country(CountryNames.CostaRica, "188", "CR", "CRI");
    public static readonly Country CoteDIvoire = new Country(CountryNames.CoteDIvoire, "384", "CI", "CIV");
    public static readonly Country Croatia = new Country(CountryNames.Croatia, "191", "HR", "HRV");
    public static readonly Country Cuba = new Country(CountryNames.Cuba, "192", "CU", "CUB");
    public static readonly Country Cyprus = new Country(CountryNames.Cyprus, "196", "CY", "CYP");
    public static readonly Country Curacao = new Country(CountryNames.Curacao, "531", "CW", "CUW");

    public static readonly Country CzechRepublic = new Country(CountryNames.CzechRepublic, "203", "CZ", "CZE");

    public static readonly Country Denmark = new Country(CountryNames.Denmark, "208", "DK", "DNK");
    public static readonly Country Djibouti = new Country(CountryNames.Djibouti, "262", "DJ", "DJI");
    public static readonly Country Dominica = new Country(CountryNames.Dominica, "212", "DM", "DMA");
    public static readonly Country DominicanRepublic = new Country(CountryNames.DominicanRepublic, "214", "DO", "DOM");

    public static readonly Country Ecuador = new Country(CountryNames.Ecuador, "218", "EC", "ECU");
    public static readonly Country Egypt = new Country(CountryNames.Egypt, "818", "EG", "EGY");
    public static readonly Country ElSalvador = new Country(CountryNames.ElSalvador, "222", "SV", "SLV");
    public static readonly Country EquatorialGuinea = new Country(CountryNames.EquatorialGuinea, "226", "GQ", "GNQ");
    public static readonly Country Eritrea = new Country(CountryNames.Eritrea, "232", "ER", "ERI");
    public static readonly Country Estonia = new Country(CountryNames.Estonia, "233", "EE", "EST");
    public static readonly Country Ethiopia = new Country(CountryNames.Ethiopia, "231", "ET", "ETH");

    public static readonly Country FalklandIslands = new Country(CountryNames.FalklandIslands, "238", "FK", "FLK");
    public static readonly Country FaroeIslands = new Country(CountryNames.FaroeIslands, "234", "FO", "FRO");
    public static readonly Country Fiji = new Country(CountryNames.Fiji, "242", "FJ", "FJI");
    public static readonly Country Finland = new Country(CountryNames.Finland, "246", "FI", "FIN");
    public static readonly Country France = new Country(CountryNames.France, "250", "FR", "FRA");
    public static readonly Country FrenchGuiana = new Country(CountryNames.FrenchGuiana, "254", "GF", "GUF");
    public static readonly Country FrenchPolynesia = new Country(CountryNames.FrenchPolynesia, "258", "PF", "PYF");

    public static readonly Country FrenchSouthernTerritories =
        new Country(CountryNames.FrenchSouthernTerritories, "260", "TF", "ATF");

    public static readonly Country Gabon = new Country(CountryNames.Gabon, "266", "GA", "GAB");
    public static readonly Country Gambia = new Country(CountryNames.Gambia, "270", "GM", "GMB");
    public static readonly Country Georgia = new Country(CountryNames.Georgia, "268", "GE", "GEO");
    public static readonly Country Germany = new Country(CountryNames.Germany, "276", "DE", "DEU");
    public static readonly Country Ghana = new Country(CountryNames.Ghana, "288", "GH", "GHA");
    public static readonly Country Gibraltar = new Country(CountryNames.Gibraltar, "292", "GI", "GIB");
    public static readonly Country Greece = new Country(CountryNames.Greece, "300", "GR", "GRC");
    public static readonly Country Greenland = new Country(CountryNames.Greenland, "304", "GL", "GRL");
    public static readonly Country Grenada = new Country(CountryNames.Grenada, "308", "GD", "GRD");
    public static readonly Country Guadeloupe = new Country(CountryNames.Guadeloupe, "312", "GP", "GLP");
    public static readonly Country Guam = new Country(CountryNames.Guam, "316", "GU", "GUM");
    public static readonly Country Guatemala = new Country(CountryNames.Guatemala, "320", "GT", "GTM");
    public static readonly Country Guernsey = new Country(CountryNames.Guernsey, "831", "GG", "GGY");
    public static readonly Country Guinea = new Country(CountryNames.Guinea, "324", "GN", "GIN");
    public static readonly Country GuineaBissau = new Country(CountryNames.GuineaBissau, "624", "GW", "GNB");
    public static readonly Country Guyana = new Country(CountryNames.Guyana, "328", "GY", "GUY");

    public static readonly Country Haiti = new Country(CountryNames.Haiti, "332", "HT", "HTI");

    public static readonly Country HeardAndMcdonaldIslands =
        new Country(CountryNames.HeardAndMcdonaldIslands, "334", "HM", "HMD");

    public static readonly Country HolySee = new Country(CountryNames.HolySee, "336", "VA", "VAT");
    public static readonly Country Honduras = new Country(CountryNames.Honduras, "340", "HN", "HND");
    public static readonly Country Hungary = new Country(CountryNames.Hungary, "348", "HU", "HUN");

    public static readonly Country Iceland = new Country(CountryNames.Iceland, "352", "IS", "ISL");
    public static readonly Country India = new Country(CountryNames.India, "356", "IN", "IND");
    public static readonly Country Indonesia = new Country(CountryNames.Indonesia, "360", "ID", "IDN");
    public static readonly Country Iran = new Country(CountryNames.Iran, "364", "IR", "IRN");
    public static readonly Country Iraq = new Country(CountryNames.Iraq, "368", "IQ", "IRQ");
    public static readonly Country Ireland = new Country(CountryNames.Ireland, "372", "IE", "IRL");
    public static readonly Country IsleOfMan = new Country(CountryNames.IsleOfMan, "833", "IM", "IMN");
    public static readonly Country Israel = new Country(CountryNames.Israel, "376", "IL", "ISR");
    public static readonly Country Italy = new Country(CountryNames.Italy, "380", "IT", "ITA");

    public static readonly Country Jamaica = new Country(CountryNames.Jamaica, "388", "JM", "JAM");
    public static readonly Country Japan = new Country(CountryNames.Japan, "392", "JP", "JPN");
    public static readonly Country Jersey = new Country(CountryNames.Jersey, "832", "JE", "JEY");
    public static readonly Country Jordan = new Country(CountryNames.Jordan, "400", "JO", "JOR");

    public static readonly Country Kazakhstan = new Country(CountryNames.Kazakhstan, "398", "KZ", "KAZ");
    public static readonly Country Kenya = new Country(CountryNames.Kenya, "404", "KE", "KEN");
    public static readonly Country Kiribati = new Country(CountryNames.Kiribati, "296", "KI", "KIR");
    public static readonly Country KoreaNorth = new Country(CountryNames.KoreaNorth, "408", "KP", "PRK");
    public static readonly Country KoreaSouth = new Country(CountryNames.KoreaSouth, "410", "KR", "KOR");
    public static readonly Country Kuwait = new Country(CountryNames.Kuwait, "414", "KW", "KWT");
    public static readonly Country Kyrgyzstan = new Country(CountryNames.Kyrgyzstan, "417", "KG", "KGZ");

    public static readonly Country LaoPDR = new Country(CountryNames.LaoPDR, "418", "LA", "LAO");
    public static readonly Country Latvia = new Country(CountryNames.Latvia, "428", "LV", "LVA");
    public static readonly Country Lebanon = new Country(CountryNames.Lebanon, "422", "LB", "LBN");
    public static readonly Country Lesotho = new Country(CountryNames.Lesotho, "426", "LS", "LSO");
    public static readonly Country Liberia = new Country(CountryNames.Liberia, "430", "LR", "LBR");
    public static readonly Country Libya = new Country(CountryNames.Libya, "434", "LY", "LBY");
    public static readonly Country Liechtenstein = new Country(CountryNames.Liechtenstein, "438", "LI", "LIE");
    public static readonly Country Lithuania = new Country(CountryNames.Lithuania, "440", "LT", "LTU");
    public static readonly Country Luxembourg = new Country(CountryNames.Luxembourg, "442", "LU", "LUX");

    public static readonly Country MacedoniaRepublicOf = new Country(CountryNames.MacedoniaRepublicOf, "807", "MK", "MKD");
    public static readonly Country Madagascar = new Country(CountryNames.Madagascar, "450", "MG", "MDG");
    public static readonly Country Malawi = new Country(CountryNames.Malawi, "454", "MW", "MWI");
    public static readonly Country Malaysia = new Country(CountryNames.Malaysia, "458", "MY", "MYS");
    public static readonly Country Maldives = new Country(CountryNames.Maldives, "462", "MV", "MDV");
    public static readonly Country Mali = new Country(CountryNames.Mali, "466", "ML", "MLI");
    public static readonly Country Malta = new Country(CountryNames.Malta, "470", "MT", "MLT");
    public static readonly Country MarshallIslands = new Country(CountryNames.MarshallIslands, "584", "MH", "MHL");
    public static readonly Country Martinique = new Country(CountryNames.Martinique, "474", "MQ", "MTQ");
    public static readonly Country Mauritania = new Country(CountryNames.Mauritania, "478", "MR", "MRT");
    public static readonly Country Mauritius = new Country(CountryNames.Mauritius, "480", "MU", "MUS");
    public static readonly Country Mayotte = new Country(CountryNames.Mayotte, "175", "YT", "MYT");
    public static readonly Country Mexico = new Country(CountryNames.Mexico, "484", "MX", "MEX");

    public static readonly Country MicronesiaFederatedStatesOf =
        new Country(CountryNames.MicronesiaFederatedStatesOf, "583", "FM", "FSM");

    public static readonly Country Moldova = new Country(CountryNames.Moldova, "498", "MD", "MDA");
    public static readonly Country Monaco = new Country(CountryNames.Monaco, "492", "MC", "MCO");
    public static readonly Country Mongolia = new Country(CountryNames.Mongolia, "496", "MN", "MNG");
    public static readonly Country Montenegro = new Country(CountryNames.Montenegro, "499", "ME", "MNE");
    public static readonly Country Montserrat = new Country(CountryNames.Montserrat, "500", "MS", "MSR");
    public static readonly Country Morocco = new Country(CountryNames.Morocco, "504", "MA", "MAR");
    public static readonly Country Mozambique = new Country(CountryNames.Mozambique, "508", "MZ", "MOZ");
    public static readonly Country Myanmar = new Country(CountryNames.Myanmar, "104", "MM", "MMR");

    public static readonly Country Namibia = new Country(CountryNames.Namibia, "516", "NA", "NAM");
    public static readonly Country Nauru = new Country(CountryNames.Nauru, "520", "NR", "NRU");
    public static readonly Country Nepal = new Country(CountryNames.Nepal, "524", "NP", "NPL");
    public static readonly Country Netherlands = new Country(CountryNames.Netherlands, "528", "NL", "NLD");
    public static readonly Country NetherlandsAntilles = new Country(CountryNames.NetherlandsAntilles, "530", "AN", "ANT");
    public static readonly Country NewCaledonia = new Country(CountryNames.NewCaledonia, "540", "NC", "NCL");
    public static readonly Country NewZealand = new Country(CountryNames.NewZealand, "554", "NZ", "NZL");
    public static readonly Country Nicaragua = new Country(CountryNames.Nicaragua, "558", "NI", "NIC");
    public static readonly Country Niger = new Country(CountryNames.Niger, "562", "NE", "NER");
    public static readonly Country Nigeria = new Country(CountryNames.Nigeria, "566", "NG", "NGA");
    public static readonly Country Niue = new Country(CountryNames.Niue, "570", "NU", "NIU");
    public static readonly Country NorfolkIsland = new Country(CountryNames.NorfolkIsland, "574", "NF", "NFK");
    public static readonly Country NorthernMarianaIslands = new Country(CountryNames.NorthernMarianaIslands, "580", "MP", "MNP");
    public static readonly Country Norway = new Country(CountryNames.Norway, "578", "NO", "NOR");

    public static readonly Country Oman = new Country(CountryNames.Oman, "512", "OM", "OMN");

    public static readonly Country Pakistan = new Country(CountryNames.Pakistan, "586", "PK", "PAK");
    public static readonly Country Palau = new Country(CountryNames.Palau, "585", "PW", "PLW");

    public static readonly Country Palestine = new Country(CountryNames.Palestine, "275", "PS", "PSE");
    public static readonly Country Panama = new Country(CountryNames.Panama, "591", "PA", "PAN");
    public static readonly Country PapuaNewGuinea = new Country(CountryNames.PapuaNewGuinea, "598", "PG", "PNG");
    public static readonly Country Paraguay = new Country(CountryNames.Paraguay, "600", "PY", "PRY");
    public static readonly Country Peru = new Country(CountryNames.Peru, "604", "PE", "PER");
    public static readonly Country Philippines = new Country(CountryNames.Philippines, "608", "PH", "PHL");
    public static readonly Country Pitcairn = new Country(CountryNames.Pitcairn, "612", "PN", "PCN");
    public static readonly Country Poland = new Country(CountryNames.Poland, "616", "PL", "POL");
    public static readonly Country Portugal = new Country(CountryNames.Portugal, "620", "PT", "PRT");
    public static readonly Country PuertoRico = new Country(CountryNames.PuertoRico, "630", "PR", "PRI");


    public static readonly Country Qatar = new Country(CountryNames.Qatar, "634", "QA", "QAT");

    public static readonly Country Reunion = new Country(CountryNames.Reunion, "638", "RE", "REU");
    public static readonly Country Romania = new Country(CountryNames.Romania, "642", "RO", "ROU");
    public static readonly Country RussianFederation = new Country(CountryNames.RussianFederation, "643", "RU", "RUS");
    public static readonly Country Rwanda = new Country(CountryNames.Rwanda, "646", "RW", "RWA");

    public static readonly Country SaintBarthelemy = new Country(CountryNames.SaintBarthelemy, "652", "BL", "BLM");
    public static readonly Country SaintHelena = new Country(CountryNames.SaintHelena, "654", "SH", "SHN");
    public static readonly Country SaintKittsAndNevis = new Country(CountryNames.SaintKittsAndNevis, "659", "KN", "KNA");
    public static readonly Country SaintLucia = new Country(CountryNames.SaintLucia, "662", "LC", "LCA");

    public static readonly Country SaintMartinFrenchPart =
        new Country(CountryNames.SaintMartinFrenchPart, "663", "MF", "MAF");

    public static readonly Country SaintPierreAndMiquelon =
        new Country(CountryNames.SaintPierreAndMiquelon, "666", "PM", "SPM");

    public static readonly Country SaintVincentAndGrenadines =
        new Country(CountryNames.SaintVincentAndGrenadines, "670", "VC", "VCT");

    public static readonly Country Samoa = new Country(CountryNames.Samoa, "882", "WS", "WSM");
    public static readonly Country SanMarino = new Country(CountryNames.SanMarino, "674", "SM", "SMR");
    public static readonly Country SaoTomeAndPrincipe = new Country(CountryNames.SaoTomeAndPrincipe, "678", "ST", "STP");
    public static readonly Country SaudiArabia = new Country(CountryNames.SaudiArabia, "682", "SA", "SAU");
    public static readonly Country Senegal = new Country(CountryNames.Senegal, "686", "SN", "SEN");
    public static readonly Country Serbia = new Country(CountryNames.Serbia, "688", "RS", "SRB");
    public static readonly Country Seychelles = new Country(CountryNames.Seychelles, "690", "SC", "SYC");
    public static readonly Country SierraLeone = new Country(CountryNames.SierraLeone, "694", "SL", "SLE");
    public static readonly Country Singapore = new Country(CountryNames.Singapore, "702", "SG", "SGP");
    public static readonly Country SintMaarten = new Country(CountryNames.SintMaarten, "534", "SX", "SXM");
    public static readonly Country Slovakia = new Country(CountryNames.Slovakia, "703", "SK", "SVK");
    public static readonly Country Slovenia = new Country(CountryNames.Slovenia, "705", "SI", "SVN");
    public static readonly Country SolomonIslands = new Country(CountryNames.SolomonIslands, "090", "SB", "SLB");
    public static readonly Country Somalia = new Country(CountryNames.Somalia, "706", "SO", "SOM");
    public static readonly Country SouthAfrica = new Country(CountryNames.SouthAfrica, "710", "ZA", "ZAF");

    public static readonly Country SouthGeorgiaAndSouthSandwichIslands =
        new Country(CountryNames.SouthGeorgiaAndSouthSandwichIslands, "239", "GS", "SGS");

    public static readonly Country SouthSudan = new Country(CountryNames.SouthSudan, "728", "SS", "SSD");
    public static readonly Country Spain = new Country(CountryNames.Spain, "724", "ES", "ESP");
    public static readonly Country SriLanka = new Country(CountryNames.SriLanka, "144", "LK", "LKA");
    public static readonly Country Sudan = new Country(CountryNames.Sudan, "736", "SD", "SDN");
    public static readonly Country Suriname = new Country(CountryNames.Suriname, "740", "SR", "SUR");

    public static readonly Country SvalbardAndJanMayenIslands =
        new Country(CountryNames.SvalbardAndJanMayenIslands, "744", "SJ", "SJM");

    public static readonly Country Swaziland_Eswatini = new Country(CountryNames.Swaziland_Eswatini, "748", "SZ", "SWZ");
    public static readonly Country Sweden = new Country(CountryNames.Sweden, "752", "SE", "SWE");
    public static readonly Country Switzerland = new Country(CountryNames.Switzerland, "756", "CH", "CHE");
    public static readonly Country SyrianArabRepublic = new Country(CountryNames.SyrianArabRepublic, "760", "SY", "SYR");

    public static readonly Country Taiwan = new Country(CountryNames.Taiwan, "158", "TW", "TWN");
    public static readonly Country Tajikistan = new Country(CountryNames.Tajikistan, "762", "TJ", "TJK");

    public static readonly Country TanzaniaUnitedRepublicOf =
        new Country(CountryNames.TanzaniaUnitedRepublicOf, "834", "TZ", "TZA");

    public static readonly Country Thailand = new Country(CountryNames.Thailand, "764", "TH", "THA");
    public static readonly Country TimorLeste = new Country(CountryNames.TimorLeste, "626", "TL", "TLS");
    public static readonly Country Togo = new Country(CountryNames.Togo, "768", "TG", "TGO");
    public static readonly Country Tokelau = new Country(CountryNames.Tokelau, "772", "TK", "TKL");
    public static readonly Country Tonga = new Country(CountryNames.Tonga, "776", "TO", "TON");
    public static readonly Country TrinidadAndTobago = new Country(CountryNames.TrinidadAndTobago, "780", "TT", "TTO");
    public static readonly Country Tunisia = new Country(CountryNames.Tunisia, "788", "TN", "TUN");
    public static readonly Country Turkey = new Country(CountryNames.Turkey, "792", "TR", "TUR");
    public static readonly Country Turkmenistan = new Country(CountryNames.Turkmenistan, "795", "TM", "TKM");
    public static readonly Country TurksAndCaicosIslands = new Country(CountryNames.TurksAndCaicosIslands, "796", "TC", "TCA");
    public static readonly Country Tuvalu = new Country(CountryNames.Tuvalu, "798", "TV", "TUV");

    public static readonly Country Uganda = new Country(CountryNames.Uganda, "800", "UG", "UGA");
    public static readonly Country Ukraine = new Country(CountryNames.Ukraine, "804", "UA", "UKR");
    public static readonly Country UnitedArabEmirates = new Country(CountryNames.UnitedArabEmirates, "784", "AE", "ARE");
    public static readonly Country UnitedKingdom = new Country(CountryNames.UnitedKingdom, "826", "GB", "GBR");
    public static readonly Country UnitedStatesOfAmerica = new Country(CountryNames.UnitedStatesOfAmerica, "840", "US", "USA");

    public static readonly Country USMinorOutlyingIslands =
        new Country(CountryNames.USMinorOutlyingIslands, "581", "UM", "UMI");

    public static readonly Country Uruguay = new Country(CountryNames.Uruguay, "858", "UY", "URY");
    public static readonly Country Uzbekistan = new Country(CountryNames.Uzbekistan, "860", "UZ", "UZB");

    public static readonly Country Vanuatu = new Country(CountryNames.Vanuatu, "548", "VU", "VUT");

    public static readonly Country VenezuelaBolivarianRepublic =
        new Country(CountryNames.VenezuelaBolivarianRepublic, "862", "VE", "VEN");

    public static readonly Country VietNam = new Country(CountryNames.VietNam, "704", "VN", "VNM");
    public static readonly Country VirginIslandsUS = new Country(CountryNames.VirginIslandsUS, "850", "VI", "VIR");

    public static readonly Country WallisAndFutunaIslands =
        new Country(CountryNames.WallisAndFutunaIslands, "876", "WF", "WLF");

    public static readonly Country WesternSahara = new Country(CountryNames.WesternSahara, "732", "EH", "ESH");

    public static readonly Country Yemen = new Country(CountryNames.Yemen, "887", "YE", "YEM");
    public static readonly Country Zambia = new Country(CountryNames.Zambia, "894", "ZM", "ZMB");
    public static readonly Country Zimbabwe = new Country(CountryNames.Zimbabwe, "716", "ZW", "ZWE");

    public static List<Country> GetAll()
    {
        return new List<Country>
        {
            None,
            Afghanistan,
            AlandIslands,
            Albania,
            Algeria,
            AmericanSamoa,
            Andorra,
            Angola,
            Anguilla,
            Antarctica,
            AntiguaAndBarbuda,
            Argentina,
            Armenia,
            Aruba,
            Australia,
            Austria,
            Azerbaijan,
            Bahamas,
            Bahrain,
            Bangladesh,
            Barbados,
            Belarus,
            Belgium,
            Belize,
            Benin,
            Bermuda,
            Bhutan,
            Bolivia,
            BonaireSintEustatiusandSaba,
            BosniaAndHerzegovina,
            Botswana,
            BouvetIsland,
            Brazil,
            BritishVirginIslands,
            BritishIndianOceanTerritory,
            BruneiDarussalam,
            Bulgaria,
            BurkinaFaso,
            Burundi,
            Cambodia,
            Cameroon,
            Canada,
            CapeVerde,
            CaymanIslands,
            CentralAfricanRepublic,
            Chad,
            Chile,
            China,
            HongKong,
            Macao,
            ChristmasIsland,
            CocosIslands,
            Colombia,
            Comoros,
            CongoBrazzaville,
            CongoKinshasa,
            CookIslands,
            CostaRica,
            CoteDIvoire,
            Croatia,
            Cuba,
            Cyprus,
            Curacao,
            CzechRepublic,
            Denmark,
            Djibouti,
            Dominica,
            DominicanRepublic,
            Ecuador,
            Egypt,
            ElSalvador,
            EquatorialGuinea,
            Eritrea,
            Estonia,
            Ethiopia,
            FalklandIslands,
            FaroeIslands,
            Fiji,
            Finland,
            France,
            FrenchGuiana,
            FrenchPolynesia,
            FrenchSouthernTerritories,
            Gabon,
            Gambia,
            Georgia,
            Germany,
            Ghana,
            Gibraltar,
            Greece,
            Greenland,
            Grenada,
            Guadeloupe,
            Guam,
            Guatemala,
            Guernsey,
            Guinea,
            GuineaBissau,
            Guyana,
            Haiti,
            HeardAndMcdonaldIslands,
            HolySee,
            Honduras,
            Hungary,
            Iceland,
            India,
            Indonesia,
            Iran,
            Iraq,
            Ireland,
            IsleOfMan,
            Israel,
            Italy,
            Jamaica,
            Japan,
            Jersey,
            Jordan,
            Kazakhstan,
            Kenya,
            Kiribati,
            KoreaNorth,
            KoreaSouth,
            Kuwait,
            Kyrgyzstan,
            LaoPDR,
            Latvia,
            Lebanon,
            Lesotho,
            Liberia,
            Libya,
            Liechtenstein,
            Lithuania,
            Luxembourg,
            MacedoniaRepublicOf,
            Madagascar,
            Malawi,
            Malaysia,
            Maldives,
            Mali,
            Malta,
            MarshallIslands,
            Martinique,
            Mauritania,
            Mauritius,
            Mayotte,
            Mexico,
            MicronesiaFederatedStatesOf,
            Moldova,
            Monaco,
            Mongolia,
            Montenegro,
            Montserrat,
            Morocco,
            Mozambique,
            Myanmar,
            Namibia,
            Nauru,
            Nepal,
            Netherlands,
            NetherlandsAntilles,
            NewCaledonia,
            NewZealand,
            Nicaragua,
            Niger,
            Nigeria,
            Niue,
            NorfolkIsland,
            NorthernMarianaIslands,
            Norway,
            Oman,
            Pakistan,
            Palau,
            Palestine,
            Panama,
            PapuaNewGuinea,
            Paraguay,
            Peru,
            Philippines,
            Pitcairn,
            Poland,
            Portugal,
            PuertoRico,
            Qatar,
            Reunion,
            Romania,
            RussianFederation,
            Rwanda,
            SaintBarthelemy,
            SaintHelena,
            SaintKittsAndNevis,
            SaintLucia,
            SaintMartinFrenchPart,
            SaintPierreAndMiquelon,
            SaintVincentAndGrenadines,
            Samoa,
            SanMarino,
            SaoTomeAndPrincipe,
            SaudiArabia,
            Senegal,
            Serbia,
            Seychelles,
            SierraLeone,
            Singapore,
            SintMaarten,
            Slovakia,
            Slovenia,
            SolomonIslands,
            Somalia,
            SouthAfrica,
            SouthGeorgiaAndSouthSandwichIslands,
            SouthSudan,
            Spain,
            SriLanka,
            Sudan,
            Suriname,
            SvalbardAndJanMayenIslands,
            Swaziland_Eswatini,
            Sweden,
            Switzerland,
            SyrianArabRepublic,
            Taiwan,
            Tajikistan,
            TanzaniaUnitedRepublicOf,
            Thailand,
            TimorLeste,
            Togo,
            Tokelau,
            Tonga,
            TrinidadAndTobago,
            Tunisia,
            Turkey,
            Turkmenistan,
            TurksAndCaicosIslands,
            Tuvalu,
            Uganda,
            Ukraine,
            UnitedArabEmirates,
            UnitedKingdom,
            UnitedStatesOfAmerica,
            USMinorOutlyingIslands,
            Uruguay,
            Uzbekistan,
            Vanuatu,
            VenezuelaBolivarianRepublic,
            VietNam,
            VirginIslandsUS,
            WallisAndFutunaIslands,
            WesternSahara,
            Yemen,
            Zambia,
            Zimbabwe
        };
    }

    public static readonly IReadOnlyDictionary<string, Country> Alpha2CodeMap = new Dictionary<string, Country>
    {
        { None.Alpha2Code, None },
        { Afghanistan.Alpha2Code, Afghanistan },
        { AlandIslands.Alpha2Code, AlandIslands },
        { Albania.Alpha2Code, Albania },
        { Algeria.Alpha2Code, Algeria },
        { AmericanSamoa.Alpha2Code, AmericanSamoa },
        { Andorra.Alpha2Code, Andorra },
        { Angola.Alpha2Code, Angola },
        { Anguilla.Alpha2Code, Anguilla },
        { Antarctica.Alpha2Code, Antarctica },
        { AntiguaAndBarbuda.Alpha2Code, AntiguaAndBarbuda },
        { Argentina.Alpha2Code, Argentina },
        { Armenia.Alpha2Code, Armenia },
        { Aruba.Alpha2Code, Aruba },
        { Australia.Alpha2Code, Australia },
        { Austria.Alpha2Code, Austria },
        { Azerbaijan.Alpha2Code, Azerbaijan },
        { Bahamas.Alpha2Code, Bahamas },
        { Bahrain.Alpha2Code, Bahrain },
        { Bangladesh.Alpha2Code, Bangladesh },
        { Barbados.Alpha2Code, Barbados },
        { Belarus.Alpha2Code, Belarus },
        { Belgium.Alpha2Code, Belgium },
        { Belize.Alpha2Code, Belize },
        { Benin.Alpha2Code, Benin },
        { Bermuda.Alpha2Code, Bermuda },
        { Bhutan.Alpha2Code, Bhutan },
        { Bolivia.Alpha2Code, Bolivia },
        { BonaireSintEustatiusandSaba.Alpha2Code, BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.Alpha2Code, BosniaAndHerzegovina },
        { Botswana.Alpha2Code, Botswana },
        { BouvetIsland.Alpha2Code, BouvetIsland },
        { Brazil.Alpha2Code, Brazil },
        { BritishVirginIslands.Alpha2Code, BritishVirginIslands },
        { BritishIndianOceanTerritory.Alpha2Code, BritishIndianOceanTerritory },
        { BruneiDarussalam.Alpha2Code, BruneiDarussalam },
        { Bulgaria.Alpha2Code, Bulgaria },
        { BurkinaFaso.Alpha2Code, BurkinaFaso },
        { Burundi.Alpha2Code, Burundi },
        { Cambodia.Alpha2Code, Cambodia },
        { Cameroon.Alpha2Code, Cameroon },
        { Canada.Alpha2Code, Canada },
        { CapeVerde.Alpha2Code, CapeVerde },
        { CaymanIslands.Alpha2Code, CaymanIslands },
        { CentralAfricanRepublic.Alpha2Code, CentralAfricanRepublic },
        { Chad.Alpha2Code, Chad },
        { Chile.Alpha2Code, Chile },
        { China.Alpha2Code, China },
        { HongKong.Alpha2Code, HongKong },
        { Macao.Alpha2Code, Macao },
        { ChristmasIsland.Alpha2Code, ChristmasIsland },
        { CocosIslands.Alpha2Code, CocosIslands },
        { Colombia.Alpha2Code, Colombia },
        { Comoros.Alpha2Code, Comoros },
        { CongoBrazzaville.Alpha2Code, CongoBrazzaville },
        { CongoKinshasa.Alpha2Code, CongoKinshasa },
        { CookIslands.Alpha2Code, CookIslands },
        { CostaRica.Alpha2Code, CostaRica },
        { CoteDIvoire.Alpha2Code, CoteDIvoire },
        { Croatia.Alpha2Code, Croatia },
        { Cuba.Alpha2Code, Cuba },
        { Cyprus.Alpha2Code, Cyprus },
        { Curacao.Alpha2Code, Curacao },
        { CzechRepublic.Alpha2Code, CzechRepublic },
        { Denmark.Alpha2Code, Denmark },
        { Djibouti.Alpha2Code, Djibouti },
        { Dominica.Alpha2Code, Dominica },
        { DominicanRepublic.Alpha2Code, DominicanRepublic },
        { Ecuador.Alpha2Code, Ecuador },
        { Egypt.Alpha2Code, Egypt },
        { ElSalvador.Alpha2Code, ElSalvador },
        { EquatorialGuinea.Alpha2Code, EquatorialGuinea },
        { Eritrea.Alpha2Code, Eritrea },
        { Estonia.Alpha2Code, Estonia },
        { Ethiopia.Alpha2Code, Ethiopia },
        { FalklandIslands.Alpha2Code, FalklandIslands },
        { FaroeIslands.Alpha2Code, FaroeIslands },
        { Fiji.Alpha2Code, Fiji },
        { Finland.Alpha2Code, Finland },
        { France.Alpha2Code, France },
        { FrenchGuiana.Alpha2Code, FrenchGuiana },
        { FrenchPolynesia.Alpha2Code, FrenchPolynesia },
        { FrenchSouthernTerritories.Alpha2Code, FrenchSouthernTerritories },
        { Gabon.Alpha2Code, Gabon },
        { Gambia.Alpha2Code, Gambia },
        { Georgia.Alpha2Code, Georgia },
        { Germany.Alpha2Code, Germany },
        { Ghana.Alpha2Code, Ghana },
        { Gibraltar.Alpha2Code, Gibraltar },
        { Greece.Alpha2Code, Greece },
        { Greenland.Alpha2Code, Greenland },
        { Grenada.Alpha2Code, Grenada },
        { Guadeloupe.Alpha2Code, Guadeloupe },
        { Guam.Alpha2Code, Guam },
        { Guatemala.Alpha2Code, Guatemala },
        { Guernsey.Alpha2Code, Guernsey },
        { Guinea.Alpha2Code, Guinea },
        { GuineaBissau.Alpha2Code, GuineaBissau },
        { Guyana.Alpha2Code, Guyana },
        { Haiti.Alpha2Code, Haiti },
        { HeardAndMcdonaldIslands.Alpha2Code, HeardAndMcdonaldIslands },
        { HolySee.Alpha2Code, HolySee },
        { Honduras.Alpha2Code, Honduras },
        { Hungary.Alpha2Code, Hungary },
        { Iceland.Alpha2Code, Iceland },
        { India.Alpha2Code, India },
        { Indonesia.Alpha2Code, Indonesia },
        { Iran.Alpha2Code, Iran },
        { Iraq.Alpha2Code, Iraq },
        { Ireland.Alpha2Code, Ireland },
        { IsleOfMan.Alpha2Code, IsleOfMan },
        { Israel.Alpha2Code, Israel },
        { Italy.Alpha2Code, Italy },
        { Jamaica.Alpha2Code, Jamaica },
        { Japan.Alpha2Code, Japan },
        { Jersey.Alpha2Code, Jersey },
        { Jordan.Alpha2Code, Jordan },
        { Kazakhstan.Alpha2Code, Kazakhstan },
        { Kenya.Alpha2Code, Kenya },
        { Kiribati.Alpha2Code, Kiribati },
        { KoreaNorth.Alpha2Code, KoreaNorth },
        { KoreaSouth.Alpha2Code, KoreaSouth },
        { Kuwait.Alpha2Code, Kuwait },
        { Kyrgyzstan.Alpha2Code, Kyrgyzstan },
        { LaoPDR.Alpha2Code, LaoPDR },
        { Latvia.Alpha2Code, Latvia },
        { Lebanon.Alpha2Code, Lebanon },
        { Lesotho.Alpha2Code, Lesotho },
        { Liberia.Alpha2Code, Liberia },
        { Libya.Alpha2Code, Libya },
        { Liechtenstein.Alpha2Code, Liechtenstein },
        { Lithuania.Alpha2Code, Lithuania },
        { Luxembourg.Alpha2Code, Luxembourg },
        { MacedoniaRepublicOf.Alpha2Code, MacedoniaRepublicOf },
        { Madagascar.Alpha2Code, Madagascar },
        { Malawi.Alpha2Code, Malawi },
        { Malaysia.Alpha2Code, Malaysia },
        { Maldives.Alpha2Code, Maldives },
        { Mali.Alpha2Code, Mali },
        { Malta.Alpha2Code, Malta },
        { MarshallIslands.Alpha2Code, MarshallIslands },
        { Martinique.Alpha2Code, Martinique },
        { Mauritania.Alpha2Code, Mauritania },
        { Mauritius.Alpha2Code, Mauritius },
        { Mayotte.Alpha2Code, Mayotte },
        { Mexico.Alpha2Code, Mexico },
        { MicronesiaFederatedStatesOf.Alpha2Code, MicronesiaFederatedStatesOf },
        { Moldova.Alpha2Code, Moldova },
        { Monaco.Alpha2Code, Monaco },
        { Mongolia.Alpha2Code, Mongolia },
        { Montenegro.Alpha2Code, Montenegro },
        { Montserrat.Alpha2Code, Montserrat },
        { Morocco.Alpha2Code, Morocco },
        { Mozambique.Alpha2Code, Mozambique },
        { Myanmar.Alpha2Code, Myanmar },
        { Namibia.Alpha2Code, Namibia },
        { Nauru.Alpha2Code, Nauru },
        { Nepal.Alpha2Code, Nepal },
        { Netherlands.Alpha2Code, Netherlands },
        { NetherlandsAntilles.Alpha2Code, NetherlandsAntilles },
        { NewCaledonia.Alpha2Code, NewCaledonia },
        { NewZealand.Alpha2Code, NewZealand },
        { Nicaragua.Alpha2Code, Nicaragua },
        { Niger.Alpha2Code, Niger },
        { Nigeria.Alpha2Code, Nigeria },
        { Niue.Alpha2Code, Niue },
        { NorfolkIsland.Alpha2Code, NorfolkIsland },
        { NorthernMarianaIslands.Alpha2Code, NorthernMarianaIslands },
        { Norway.Alpha2Code, Norway },
        { Oman.Alpha2Code, Oman },
        { Pakistan.Alpha2Code, Pakistan },
        { Palau.Alpha2Code, Palau },
        { Palestine.Alpha2Code, Palestine },
        { Panama.Alpha2Code, Panama },
        { PapuaNewGuinea.Alpha2Code, PapuaNewGuinea },
        { Paraguay.Alpha2Code, Paraguay },
        { Peru.Alpha2Code, Peru },
        { Philippines.Alpha2Code, Philippines },
        { Pitcairn.Alpha2Code, Pitcairn },
        { Poland.Alpha2Code, Poland },
        { Portugal.Alpha2Code, Portugal },
        { PuertoRico.Alpha2Code, PuertoRico },
        { Qatar.Alpha2Code, Qatar },
        { Reunion.Alpha2Code, Reunion },
        { Romania.Alpha2Code, Romania },
        { RussianFederation.Alpha2Code, RussianFederation },
        { Rwanda.Alpha2Code, Rwanda },
        { SaintBarthelemy.Alpha2Code, SaintBarthelemy },
        { SaintHelena.Alpha2Code, SaintHelena },
        { SaintKittsAndNevis.Alpha2Code, SaintKittsAndNevis },
        { SaintLucia.Alpha2Code, SaintLucia },
        { SaintMartinFrenchPart.Alpha2Code, SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.Alpha2Code, SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.Alpha2Code, SaintVincentAndGrenadines },
        { Samoa.Alpha2Code, Samoa },
        { SanMarino.Alpha2Code, SanMarino },
        { SaoTomeAndPrincipe.Alpha2Code, SaoTomeAndPrincipe },
        { SaudiArabia.Alpha2Code, SaudiArabia },
        { Senegal.Alpha2Code, Senegal },
        { Serbia.Alpha2Code, Serbia },
        { Seychelles.Alpha2Code, Seychelles },
        { SierraLeone.Alpha2Code, SierraLeone },
        { Singapore.Alpha2Code, Singapore },
        { SintMaarten.Alpha2Code, SintMaarten },
        { Slovakia.Alpha2Code, Slovakia },
        { Slovenia.Alpha2Code, Slovenia },
        { SolomonIslands.Alpha2Code, SolomonIslands },
        { Somalia.Alpha2Code, Somalia },
        { SouthAfrica.Alpha2Code, SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.Alpha2Code, SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.Alpha2Code, SouthSudan },
        { Spain.Alpha2Code, Spain },
        { SriLanka.Alpha2Code, SriLanka },
        { Sudan.Alpha2Code, Sudan },
        { Suriname.Alpha2Code, Suriname },
        { SvalbardAndJanMayenIslands.Alpha2Code, SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.Alpha2Code, Swaziland_Eswatini },
        { Sweden.Alpha2Code, Sweden },
        { Switzerland.Alpha2Code, Switzerland },
        { SyrianArabRepublic.Alpha2Code, SyrianArabRepublic },
        { Taiwan.Alpha2Code, Taiwan },
        { Tajikistan.Alpha2Code, Tajikistan },
        { TanzaniaUnitedRepublicOf.Alpha2Code, TanzaniaUnitedRepublicOf },
        { Thailand.Alpha2Code, Thailand },
        { TimorLeste.Alpha2Code, TimorLeste },
        { Togo.Alpha2Code, Togo },
        { Tokelau.Alpha2Code, Tokelau },
        { Tonga.Alpha2Code, Tonga },
        { TrinidadAndTobago.Alpha2Code, TrinidadAndTobago },
        { Tunisia.Alpha2Code, Tunisia },
        { Turkey.Alpha2Code, Turkey },
        { Turkmenistan.Alpha2Code, Turkmenistan },
        { TurksAndCaicosIslands.Alpha2Code, TurksAndCaicosIslands },
        { Tuvalu.Alpha2Code, Tuvalu },
        { Uganda.Alpha2Code, Uganda },
        { Ukraine.Alpha2Code, Ukraine },
        { UnitedArabEmirates.Alpha2Code, UnitedArabEmirates },
        { UnitedKingdom.Alpha2Code, UnitedKingdom },
        { UnitedStatesOfAmerica.Alpha2Code, UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.Alpha2Code, USMinorOutlyingIslands },
        { Uruguay.Alpha2Code, Uruguay },
        { Uzbekistan.Alpha2Code, Uzbekistan },
        { Vanuatu.Alpha2Code, Vanuatu },
        { VenezuelaBolivarianRepublic.Alpha2Code, VenezuelaBolivarianRepublic },
        { VietNam.Alpha2Code, VietNam },
        { VirginIslandsUS.Alpha2Code, VirginIslandsUS },
        { WallisAndFutunaIslands.Alpha2Code, WallisAndFutunaIslands },
        { WesternSahara.Alpha2Code, WesternSahara },
        { Yemen.Alpha2Code, Yemen },
        { Zambia.Alpha2Code, Zambia },
        { Zimbabwe.Alpha2Code, Zimbabwe }
    };

    public static readonly IReadOnlyDictionary<string, Country> Alpha3CodeMap = new Dictionary<string, Country>
    {
        { None.Alpha3Code, None },
        { Afghanistan.Alpha3Code, Afghanistan },
        { AlandIslands.Alpha3Code, AlandIslands },
        { Albania.Alpha3Code, Albania },
        { Algeria.Alpha3Code, Algeria },
        { AmericanSamoa.Alpha3Code, AmericanSamoa },
        { Andorra.Alpha3Code, Andorra },
        { Angola.Alpha3Code, Angola },
        { Anguilla.Alpha3Code, Anguilla },
        { Antarctica.Alpha3Code, Antarctica },
        { AntiguaAndBarbuda.Alpha3Code, AntiguaAndBarbuda },
        { Argentina.Alpha3Code, Argentina },
        { Armenia.Alpha3Code, Armenia },
        { Aruba.Alpha3Code, Aruba },
        { Australia.Alpha3Code, Australia },
        { Austria.Alpha3Code, Austria },
        { Azerbaijan.Alpha3Code, Azerbaijan },
        { Bahamas.Alpha3Code, Bahamas },
        { Bahrain.Alpha3Code, Bahrain },
        { Bangladesh.Alpha3Code, Bangladesh },
        { Barbados.Alpha3Code, Barbados },
        { Belarus.Alpha3Code, Belarus },
        { Belgium.Alpha3Code, Belgium },
        { Belize.Alpha3Code, Belize },
        { Benin.Alpha3Code, Benin },
        { Bermuda.Alpha3Code, Bermuda },
        { Bhutan.Alpha3Code, Bhutan },
        { Bolivia.Alpha3Code, Bolivia },
        { BonaireSintEustatiusandSaba.Alpha3Code, BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.Alpha3Code, BosniaAndHerzegovina },
        { Botswana.Alpha3Code, Botswana },
        { BouvetIsland.Alpha3Code, BouvetIsland },
        { Brazil.Alpha3Code, Brazil },
        { BritishVirginIslands.Alpha3Code, BritishVirginIslands },
        { BritishIndianOceanTerritory.Alpha3Code, BritishIndianOceanTerritory },
        { BruneiDarussalam.Alpha3Code, BruneiDarussalam },
        { Bulgaria.Alpha3Code, Bulgaria },
        { BurkinaFaso.Alpha3Code, BurkinaFaso },
        { Burundi.Alpha3Code, Burundi },
        { Cambodia.Alpha3Code, Cambodia },
        { Cameroon.Alpha3Code, Cameroon },
        { Canada.Alpha3Code, Canada },
        { CapeVerde.Alpha3Code, CapeVerde },
        { CaymanIslands.Alpha3Code, CaymanIslands },
        { CentralAfricanRepublic.Alpha3Code, CentralAfricanRepublic },
        { Chad.Alpha3Code, Chad },
        { Chile.Alpha3Code, Chile },
        { China.Alpha3Code, China },
        { HongKong.Alpha3Code, HongKong },
        { Macao.Alpha3Code, Macao },
        { ChristmasIsland.Alpha3Code, ChristmasIsland },
        { CocosIslands.Alpha3Code, CocosIslands },
        { Colombia.Alpha3Code, Colombia },
        { Comoros.Alpha3Code, Comoros },
        { CongoBrazzaville.Alpha3Code, CongoBrazzaville },
        { CongoKinshasa.Alpha3Code, CongoKinshasa },
        { CookIslands.Alpha3Code, CookIslands },
        { CostaRica.Alpha3Code, CostaRica },
        { CoteDIvoire.Alpha3Code, CoteDIvoire },
        { Croatia.Alpha3Code, Croatia },
        { Cuba.Alpha3Code, Cuba },
        { Cyprus.Alpha3Code, Cyprus },
        { Curacao.Alpha3Code, Curacao },
        { CzechRepublic.Alpha3Code, CzechRepublic },
        { Denmark.Alpha3Code, Denmark },
        { Djibouti.Alpha3Code, Djibouti },
        { Dominica.Alpha3Code, Dominica },
        { DominicanRepublic.Alpha3Code, DominicanRepublic },
        { Ecuador.Alpha3Code, Ecuador },
        { Egypt.Alpha3Code, Egypt },
        { ElSalvador.Alpha3Code, ElSalvador },
        { EquatorialGuinea.Alpha3Code, EquatorialGuinea },
        { Eritrea.Alpha3Code, Eritrea },
        { Estonia.Alpha3Code, Estonia },
        { Ethiopia.Alpha3Code, Ethiopia },
        { FalklandIslands.Alpha3Code, FalklandIslands },
        { FaroeIslands.Alpha3Code, FaroeIslands },
        { Fiji.Alpha3Code, Fiji },
        { Finland.Alpha3Code, Finland },
        { France.Alpha3Code, France },
        { FrenchGuiana.Alpha3Code, FrenchGuiana },
        { FrenchPolynesia.Alpha3Code, FrenchPolynesia },
        { FrenchSouthernTerritories.Alpha3Code, FrenchSouthernTerritories },
        { Gabon.Alpha3Code, Gabon },
        { Gambia.Alpha3Code, Gambia },
        { Georgia.Alpha3Code, Georgia },
        { Germany.Alpha3Code, Germany },
        { Ghana.Alpha3Code, Ghana },
        { Gibraltar.Alpha3Code, Gibraltar },
        { Greece.Alpha3Code, Greece },
        { Greenland.Alpha3Code, Greenland },
        { Grenada.Alpha3Code, Grenada },
        { Guadeloupe.Alpha3Code, Guadeloupe },
        { Guam.Alpha3Code, Guam },
        { Guatemala.Alpha3Code, Guatemala },
        { Guernsey.Alpha3Code, Guernsey },
        { Guinea.Alpha3Code, Guinea },
        { GuineaBissau.Alpha3Code, GuineaBissau },
        { Guyana.Alpha3Code, Guyana },
        { Haiti.Alpha3Code, Haiti },
        { HeardAndMcdonaldIslands.Alpha3Code, HeardAndMcdonaldIslands },
        { HolySee.Alpha3Code, HolySee },
        { Honduras.Alpha3Code, Honduras },
        { Hungary.Alpha3Code, Hungary },
        { Iceland.Alpha3Code, Iceland },
        { India.Alpha3Code, India },
        { Indonesia.Alpha3Code, Indonesia },
        { Iran.Alpha3Code, Iran },
        { Iraq.Alpha3Code, Iraq },
        { Ireland.Alpha3Code, Ireland },
        { IsleOfMan.Alpha3Code, IsleOfMan },
        { Israel.Alpha3Code, Israel },
        { Italy.Alpha3Code, Italy },
        { Jamaica.Alpha3Code, Jamaica },
        { Japan.Alpha3Code, Japan },
        { Jersey.Alpha3Code, Jersey },
        { Jordan.Alpha3Code, Jordan },
        { Kazakhstan.Alpha3Code, Kazakhstan },
        { Kenya.Alpha3Code, Kenya },
        { Kiribati.Alpha3Code, Kiribati },
        { KoreaNorth.Alpha3Code, KoreaNorth },
        { KoreaSouth.Alpha3Code, KoreaSouth },
        { Kuwait.Alpha3Code, Kuwait },
        { Kyrgyzstan.Alpha3Code, Kyrgyzstan },
        { LaoPDR.Alpha3Code, LaoPDR },
        { Latvia.Alpha3Code, Latvia },
        { Lebanon.Alpha3Code, Lebanon },
        { Lesotho.Alpha3Code, Lesotho },
        { Liberia.Alpha3Code, Liberia },
        { Libya.Alpha3Code, Libya },
        { Liechtenstein.Alpha3Code, Liechtenstein },
        { Lithuania.Alpha3Code, Lithuania },
        { Luxembourg.Alpha3Code, Luxembourg },
        { MacedoniaRepublicOf.Alpha3Code, MacedoniaRepublicOf },
        { Madagascar.Alpha3Code, Madagascar },
        { Malawi.Alpha3Code, Malawi },
        { Malaysia.Alpha3Code, Malaysia },
        { Maldives.Alpha3Code, Maldives },
        { Mali.Alpha3Code, Mali },
        { Malta.Alpha3Code, Malta },
        { MarshallIslands.Alpha3Code, MarshallIslands },
        { Martinique.Alpha3Code, Martinique },
        { Mauritania.Alpha3Code, Mauritania },
        { Mauritius.Alpha3Code, Mauritius },
        { Mayotte.Alpha3Code, Mayotte },
        { Mexico.Alpha3Code, Mexico },
        { MicronesiaFederatedStatesOf.Alpha3Code, MicronesiaFederatedStatesOf },
        { Moldova.Alpha3Code, Moldova },
        { Monaco.Alpha3Code, Monaco },
        { Mongolia.Alpha3Code, Mongolia },
        { Montenegro.Alpha3Code, Montenegro },
        { Montserrat.Alpha3Code, Montserrat },
        { Morocco.Alpha3Code, Morocco },
        { Mozambique.Alpha3Code, Mozambique },
        { Myanmar.Alpha3Code, Myanmar },
        { Namibia.Alpha3Code, Namibia },
        { Nauru.Alpha3Code, Nauru },
        { Nepal.Alpha3Code, Nepal },
        { Netherlands.Alpha3Code, Netherlands },
        { NetherlandsAntilles.Alpha3Code, NetherlandsAntilles },
        { NewCaledonia.Alpha3Code, NewCaledonia },
        { NewZealand.Alpha3Code, NewZealand },
        { Nicaragua.Alpha3Code, Nicaragua },
        { Niger.Alpha3Code, Niger },
        { Nigeria.Alpha3Code, Nigeria },
        { Niue.Alpha3Code, Niue },
        { NorfolkIsland.Alpha3Code, NorfolkIsland },
        { NorthernMarianaIslands.Alpha3Code, NorthernMarianaIslands },
        { Norway.Alpha3Code, Norway },
        { Oman.Alpha3Code, Oman },
        { Pakistan.Alpha3Code, Pakistan },
        { Palau.Alpha3Code, Palau },
        { Palestine.Alpha3Code, Palestine },
        { Panama.Alpha3Code, Panama },
        { PapuaNewGuinea.Alpha3Code, PapuaNewGuinea },
        { Paraguay.Alpha3Code, Paraguay },
        { Peru.Alpha3Code, Peru },
        { Philippines.Alpha3Code, Philippines },
        { Pitcairn.Alpha3Code, Pitcairn },
        { Poland.Alpha3Code, Poland },
        { Portugal.Alpha3Code, Portugal },
        { PuertoRico.Alpha3Code, PuertoRico },
        { Qatar.Alpha3Code, Qatar },
        { Reunion.Alpha3Code, Reunion },
        { Romania.Alpha3Code, Romania },
        { RussianFederation.Alpha3Code, RussianFederation },
        { Rwanda.Alpha3Code, Rwanda },
        { SaintBarthelemy.Alpha3Code, SaintBarthelemy },
        { SaintHelena.Alpha3Code, SaintHelena },
        { SaintKittsAndNevis.Alpha3Code, SaintKittsAndNevis },
        { SaintLucia.Alpha3Code, SaintLucia },
        { SaintMartinFrenchPart.Alpha3Code, SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.Alpha3Code, SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.Alpha3Code, SaintVincentAndGrenadines },
        { Samoa.Alpha3Code, Samoa },
        { SanMarino.Alpha3Code, SanMarino },
        { SaoTomeAndPrincipe.Alpha3Code, SaoTomeAndPrincipe },
        { SaudiArabia.Alpha3Code, SaudiArabia },
        { Senegal.Alpha3Code, Senegal },
        { Serbia.Alpha3Code, Serbia },
        { Seychelles.Alpha3Code, Seychelles },
        { SierraLeone.Alpha3Code, SierraLeone },
        { Singapore.Alpha3Code, Singapore },
        { SintMaarten.Alpha3Code, SintMaarten },
        { Slovakia.Alpha3Code, Slovakia },
        { Slovenia.Alpha3Code, Slovenia },
        { SolomonIslands.Alpha3Code, SolomonIslands },
        { Somalia.Alpha3Code, Somalia },
        { SouthAfrica.Alpha3Code, SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.Alpha3Code, SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.Alpha3Code, SouthSudan },
        { Spain.Alpha3Code, Spain },
        { SriLanka.Alpha3Code, SriLanka },
        { Sudan.Alpha3Code, Sudan },
        { Suriname.Alpha3Code, Suriname },
        { SvalbardAndJanMayenIslands.Alpha3Code, SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.Alpha3Code, Swaziland_Eswatini },
        { Sweden.Alpha3Code, Sweden },
        { Switzerland.Alpha3Code, Switzerland },
        { SyrianArabRepublic.Alpha3Code, SyrianArabRepublic },
        { Taiwan.Alpha3Code, Taiwan },
        { Tajikistan.Alpha3Code, Tajikistan },
        { TanzaniaUnitedRepublicOf.Alpha3Code, TanzaniaUnitedRepublicOf },
        { Thailand.Alpha3Code, Thailand },
        { TimorLeste.Alpha3Code, TimorLeste },
        { Togo.Alpha3Code, Togo },
        { Tokelau.Alpha3Code, Tokelau },
        { Tonga.Alpha3Code, Tonga },
        { TrinidadAndTobago.Alpha3Code, TrinidadAndTobago },
        { Tunisia.Alpha3Code, Tunisia },
        { Turkey.Alpha3Code, Turkey },
        { Turkmenistan.Alpha3Code, Turkmenistan },
        { TurksAndCaicosIslands.Alpha3Code, TurksAndCaicosIslands },
        { Tuvalu.Alpha3Code, Tuvalu },
        { Uganda.Alpha3Code, Uganda },
        { Ukraine.Alpha3Code, Ukraine },
        { UnitedArabEmirates.Alpha3Code, UnitedArabEmirates },
        { UnitedKingdom.Alpha3Code, UnitedKingdom },
        { UnitedStatesOfAmerica.Alpha3Code, UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.Alpha3Code, USMinorOutlyingIslands },
        { Uruguay.Alpha3Code, Uruguay },
        { Uzbekistan.Alpha3Code, Uzbekistan },
        { Vanuatu.Alpha3Code, Vanuatu },
        { VenezuelaBolivarianRepublic.Alpha3Code, VenezuelaBolivarianRepublic },
        { VietNam.Alpha3Code, VietNam },
        { VirginIslandsUS.Alpha3Code, VirginIslandsUS },
        { WallisAndFutunaIslands.Alpha3Code, WallisAndFutunaIslands },
        { WesternSahara.Alpha3Code, WesternSahara },
        { Yemen.Alpha3Code, Yemen },
        { Zambia.Alpha3Code, Zambia },
        { Zimbabwe.Alpha3Code, Zimbabwe }
    };

    public static readonly IReadOnlyDictionary<string, Country> NumericCodeMap = new Dictionary<string, Country>
    {
        {None.NumericCode, None },
        { Afghanistan.NumericCode, Afghanistan },
        { AlandIslands.NumericCode, AlandIslands },
        { Albania.NumericCode, Albania },
        { Algeria.NumericCode, Algeria },
        { AmericanSamoa.NumericCode, AmericanSamoa },
        { Andorra.NumericCode, Andorra },
        { Angola.NumericCode, Angola },
        { Anguilla.NumericCode, Anguilla },
        { Antarctica.NumericCode, Antarctica },
        { AntiguaAndBarbuda.NumericCode, AntiguaAndBarbuda },
        { Argentina.NumericCode, Argentina },
        { Armenia.NumericCode, Armenia },
        { Aruba.NumericCode, Aruba },
        { Australia.NumericCode, Australia },
        { Austria.NumericCode, Austria },
        { Azerbaijan.NumericCode, Azerbaijan },
        { Bahamas.NumericCode, Bahamas },
        { Bahrain.NumericCode, Bahrain },
        { Bangladesh.NumericCode, Bangladesh },
        { Barbados.NumericCode, Barbados },
        { Belarus.NumericCode, Belarus },
        { Belgium.NumericCode, Belgium },
        { Belize.NumericCode, Belize },
        { Benin.NumericCode, Benin },
        { Bermuda.NumericCode, Bermuda },
        { Bhutan.NumericCode, Bhutan },
        { Bolivia.NumericCode, Bolivia },
        { BonaireSintEustatiusandSaba.NumericCode, BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.NumericCode, BosniaAndHerzegovina },
        { Botswana.NumericCode, Botswana },
        { BouvetIsland.NumericCode, BouvetIsland },
        { Brazil.NumericCode, Brazil },
        { BritishVirginIslands.NumericCode, BritishVirginIslands },
        { BritishIndianOceanTerritory.NumericCode, BritishIndianOceanTerritory },
        { BruneiDarussalam.NumericCode, BruneiDarussalam },
        { Bulgaria.NumericCode, Bulgaria },
        { BurkinaFaso.NumericCode, BurkinaFaso },
        { Burundi.NumericCode, Burundi },
        { Cambodia.NumericCode, Cambodia },
        { Cameroon.NumericCode, Cameroon },
        { Canada.NumericCode, Canada },
        { CapeVerde.NumericCode, CapeVerde },
        { CaymanIslands.NumericCode, CaymanIslands },
        { CentralAfricanRepublic.NumericCode, CentralAfricanRepublic },
        { Chad.NumericCode, Chad },
        { Chile.NumericCode, Chile },
        { China.NumericCode, China },
        { HongKong.NumericCode, HongKong },
        { Macao.NumericCode, Macao },
        { ChristmasIsland.NumericCode, ChristmasIsland },
        { CocosIslands.NumericCode, CocosIslands },
        { Colombia.NumericCode, Colombia },
        { Comoros.NumericCode, Comoros },
        { CongoBrazzaville.NumericCode, CongoBrazzaville },
        { CongoKinshasa.NumericCode, CongoKinshasa },
        { CookIslands.NumericCode, CookIslands },
        { CostaRica.NumericCode, CostaRica },
        { CoteDIvoire.NumericCode, CoteDIvoire },
        { Croatia.NumericCode, Croatia },
        { Cuba.NumericCode, Cuba },
        { Cyprus.NumericCode, Cyprus },
        { Curacao.NumericCode, Curacao },
        { CzechRepublic.NumericCode, CzechRepublic },
        { Denmark.NumericCode, Denmark },
        { Djibouti.NumericCode, Djibouti },
        { Dominica.NumericCode, Dominica },
        { DominicanRepublic.NumericCode, DominicanRepublic },
        { Ecuador.NumericCode, Ecuador },
        { Egypt.NumericCode, Egypt },
        { ElSalvador.NumericCode, ElSalvador },
        { EquatorialGuinea.NumericCode, EquatorialGuinea },
        { Eritrea.NumericCode, Eritrea },
        { Estonia.NumericCode, Estonia },
        { Ethiopia.NumericCode, Ethiopia },
        { FalklandIslands.NumericCode, FalklandIslands },
        { FaroeIslands.NumericCode, FaroeIslands },
        { Fiji.NumericCode, Fiji },
        { Finland.NumericCode, Finland },
        { France.NumericCode, France },
        { FrenchGuiana.NumericCode, FrenchGuiana },
        { FrenchPolynesia.NumericCode, FrenchPolynesia },
        { FrenchSouthernTerritories.NumericCode, FrenchSouthernTerritories },
        { Gabon.NumericCode, Gabon },
        { Gambia.NumericCode, Gambia },
        { Georgia.NumericCode, Georgia },
        { Germany.NumericCode, Germany },
        { Ghana.NumericCode, Ghana },
        { Gibraltar.NumericCode, Gibraltar },
        { Greece.NumericCode, Greece },
        { Greenland.NumericCode, Greenland },
        { Grenada.NumericCode, Grenada },
        { Guadeloupe.NumericCode, Guadeloupe },
        { Guam.NumericCode, Guam },
        { Guatemala.NumericCode, Guatemala },
        { Guernsey.NumericCode, Guernsey },
        { Guinea.NumericCode, Guinea },
        { GuineaBissau.NumericCode, GuineaBissau },
        { Guyana.NumericCode, Guyana },
        { Haiti.NumericCode, Haiti },
        { HeardAndMcdonaldIslands.NumericCode, HeardAndMcdonaldIslands },
        { HolySee.NumericCode, HolySee },
        { Honduras.NumericCode, Honduras },
        { Hungary.NumericCode, Hungary },
        { Iceland.NumericCode, Iceland },
        { India.NumericCode, India },
        { Indonesia.NumericCode, Indonesia },
        { Iran.NumericCode, Iran },
        { Iraq.NumericCode, Iraq },
        { Ireland.NumericCode, Ireland },
        { IsleOfMan.NumericCode, IsleOfMan },
        { Israel.NumericCode, Israel },
        { Italy.NumericCode, Italy },
        { Jamaica.NumericCode, Jamaica },
        { Japan.NumericCode, Japan },
        { Jersey.NumericCode, Jersey },
        { Jordan.NumericCode, Jordan },
        { Kazakhstan.NumericCode, Kazakhstan },
        { Kenya.NumericCode, Kenya },
        { Kiribati.NumericCode, Kiribati },
        { KoreaNorth.NumericCode, KoreaNorth },
        { KoreaSouth.NumericCode, KoreaSouth },
        { Kuwait.NumericCode, Kuwait },
        { Kyrgyzstan.NumericCode, Kyrgyzstan },
        { LaoPDR.NumericCode, LaoPDR },
        { Latvia.NumericCode, Latvia },
        { Lebanon.NumericCode, Lebanon },
        { Lesotho.NumericCode, Lesotho },
        { Liberia.NumericCode, Liberia },
        { Libya.NumericCode, Libya },
        { Liechtenstein.NumericCode, Liechtenstein },
        { Lithuania.NumericCode, Lithuania },
        { Luxembourg.NumericCode, Luxembourg },
        { MacedoniaRepublicOf.NumericCode, MacedoniaRepublicOf },
        { Madagascar.NumericCode, Madagascar },
        { Malawi.NumericCode, Malawi },
        { Malaysia.NumericCode, Malaysia },
        { Maldives.NumericCode, Maldives },
        { Mali.NumericCode, Mali },
        { Malta.NumericCode, Malta },
        { MarshallIslands.NumericCode, MarshallIslands },
        { Martinique.NumericCode, Martinique },
        { Mauritania.NumericCode, Mauritania },
        { Mauritius.NumericCode, Mauritius },
        { Mayotte.NumericCode, Mayotte },
        { Mexico.NumericCode, Mexico },
        { MicronesiaFederatedStatesOf.NumericCode, MicronesiaFederatedStatesOf },
        { Moldova.NumericCode, Moldova },
        { Monaco.NumericCode, Monaco },
        { Mongolia.NumericCode, Mongolia },
        { Montenegro.NumericCode, Montenegro },
        { Montserrat.NumericCode, Montserrat },
        { Morocco.NumericCode, Morocco },
        { Mozambique.NumericCode, Mozambique },
        { Myanmar.NumericCode, Myanmar },
        { Namibia.NumericCode, Namibia },
        { Nauru.NumericCode, Nauru },
        { Nepal.NumericCode, Nepal },
        { Netherlands.NumericCode, Netherlands },
        { NetherlandsAntilles.NumericCode, NetherlandsAntilles },
        { NewCaledonia.NumericCode, NewCaledonia },
        { NewZealand.NumericCode, NewZealand },
        { Nicaragua.NumericCode, Nicaragua },
        { Niger.NumericCode, Niger },
        { Nigeria.NumericCode, Nigeria },
        { Niue.NumericCode, Niue },
        { NorfolkIsland.NumericCode, NorfolkIsland },
        { NorthernMarianaIslands.NumericCode, NorthernMarianaIslands },
        { Norway.NumericCode, Norway },
        { Oman.NumericCode, Oman },
        { Pakistan.NumericCode, Pakistan },
        { Palau.NumericCode, Palau },
        { Palestine.NumericCode, Palestine },
        { Panama.NumericCode, Panama },
        { PapuaNewGuinea.NumericCode, PapuaNewGuinea },
        { Paraguay.NumericCode, Paraguay },
        { Peru.NumericCode, Peru },
        { Philippines.NumericCode, Philippines },
        { Pitcairn.NumericCode, Pitcairn },
        { Poland.NumericCode, Poland },
        { Portugal.NumericCode, Portugal },
        { PuertoRico.NumericCode, PuertoRico },
        { Qatar.NumericCode, Qatar },
        { Reunion.NumericCode, Reunion },
        { Romania.NumericCode, Romania },
        { RussianFederation.NumericCode, RussianFederation },
        { Rwanda.NumericCode, Rwanda },
        { SaintBarthelemy.NumericCode, SaintBarthelemy },
        { SaintHelena.NumericCode, SaintHelena },
        { SaintKittsAndNevis.NumericCode, SaintKittsAndNevis },
        { SaintLucia.NumericCode, SaintLucia },
        { SaintMartinFrenchPart.NumericCode, SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.NumericCode, SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.NumericCode, SaintVincentAndGrenadines },
        { Samoa.NumericCode, Samoa },
        { SanMarino.NumericCode, SanMarino },
        { SaoTomeAndPrincipe.NumericCode, SaoTomeAndPrincipe },
        { SaudiArabia.NumericCode, SaudiArabia },
        { Senegal.NumericCode, Senegal },
        { Serbia.NumericCode, Serbia },
        { Seychelles.NumericCode, Seychelles },
        { SierraLeone.NumericCode, SierraLeone },
        { Singapore.NumericCode, Singapore },
        { SintMaarten.NumericCode, SintMaarten },
        { Slovakia.NumericCode, Slovakia },
        { Slovenia.NumericCode, Slovenia },
        { SolomonIslands.NumericCode, SolomonIslands },
        { Somalia.NumericCode, Somalia },
        { SouthAfrica.NumericCode, SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.NumericCode, SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.NumericCode, SouthSudan },
        { Spain.NumericCode, Spain },
        { SriLanka.NumericCode, SriLanka },
        { Sudan.NumericCode, Sudan },
        { Suriname.NumericCode, Suriname },
        { SvalbardAndJanMayenIslands.NumericCode, SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.NumericCode, Swaziland_Eswatini },
        { Sweden.NumericCode, Sweden },
        { Switzerland.NumericCode, Switzerland },
        { SyrianArabRepublic.NumericCode, SyrianArabRepublic },
        { Taiwan.NumericCode, Taiwan },
        { Tajikistan.NumericCode, Tajikistan },
        { TanzaniaUnitedRepublicOf.NumericCode, TanzaniaUnitedRepublicOf },
        { Thailand.NumericCode, Thailand },
        { TimorLeste.NumericCode, TimorLeste },
        { Togo.NumericCode, Togo },
        { Tokelau.NumericCode, Tokelau },
        { Tonga.NumericCode, Tonga },
        { TrinidadAndTobago.NumericCode, TrinidadAndTobago },
        { Tunisia.NumericCode, Tunisia },
        { Turkey.NumericCode, Turkey },
        { Turkmenistan.NumericCode, Turkmenistan },
        { TurksAndCaicosIslands.NumericCode, TurksAndCaicosIslands },
        { Tuvalu.NumericCode, Tuvalu },
        { Uganda.NumericCode, Uganda },
        { Ukraine.NumericCode, Ukraine },
        { UnitedArabEmirates.NumericCode, UnitedArabEmirates },
        { UnitedKingdom.NumericCode, UnitedKingdom },
        { UnitedStatesOfAmerica.NumericCode, UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.NumericCode, USMinorOutlyingIslands },
        { Uruguay.NumericCode, Uruguay },
        { Uzbekistan.NumericCode, Uzbekistan },
        { Vanuatu.NumericCode, Vanuatu },
        { VenezuelaBolivarianRepublic.NumericCode, VenezuelaBolivarianRepublic },
        { VietNam.NumericCode, VietNam },
        { VirginIslandsUS.NumericCode, VirginIslandsUS },
        { WallisAndFutunaIslands.NumericCode, WallisAndFutunaIslands },
        { WesternSahara.NumericCode, WesternSahara },
        { Yemen.NumericCode, Yemen },
        { Zambia.NumericCode, Zambia },
        { Zimbabwe.NumericCode, Zimbabwe }
    };

    public static readonly IReadOnlyDictionary<string, Country> NameMap = new Dictionary<string, Country>
    {
        {None.Name, None },
        { Afghanistan.Name, Afghanistan },
        { AlandIslands.Name, AlandIslands },
        { Albania.Name, Albania },
        { Algeria.Name, Algeria },
        { AmericanSamoa.Name, AmericanSamoa },
        { Andorra.Name, Andorra },
        { Angola.Name, Angola },
        { Anguilla.Name, Anguilla },
        { Antarctica.Name, Antarctica },
        { AntiguaAndBarbuda.Name, AntiguaAndBarbuda },
        { Argentina.Name, Argentina },
        { Armenia.Name, Armenia },
        { Aruba.Name, Aruba },
        { Australia.Name, Australia },
        { Austria.Name, Austria },
        { Azerbaijan.Name, Azerbaijan },
        { Bahamas.Name, Bahamas },
        { Bahrain.Name, Bahrain },
        { Bangladesh.Name, Bangladesh },
        { Barbados.Name, Barbados },
        { Belarus.Name, Belarus },
        { Belgium.Name, Belgium },
        { Belize.Name, Belize },
        { Benin.Name, Benin },
        { Bermuda.Name, Bermuda },
        { Bhutan.Name, Bhutan },
        { Bolivia.Name, Bolivia },
        { BonaireSintEustatiusandSaba.Name, BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.Name, BosniaAndHerzegovina },
        { Botswana.Name, Botswana },
        { BouvetIsland.Name, BouvetIsland },
        { Brazil.Name, Brazil },
        { BritishVirginIslands.Name, BritishVirginIslands },
        { BritishIndianOceanTerritory.Name, BritishIndianOceanTerritory },
        { BruneiDarussalam.Name, BruneiDarussalam },
        { Bulgaria.Name, Bulgaria },
        { BurkinaFaso.Name, BurkinaFaso },
        { Burundi.Name, Burundi },
        { Cambodia.Name, Cambodia },
        { Cameroon.Name, Cameroon },
        { Canada.Name, Canada },
        { CapeVerde.Name, CapeVerde },
        { CaymanIslands.Name, CaymanIslands },
        { CentralAfricanRepublic.Name, CentralAfricanRepublic },
        { Chad.Name, Chad },
        { Chile.Name, Chile },
        { China.Name, China },
        { HongKong.Name, HongKong },
        { Macao.Name, Macao },
        { ChristmasIsland.Name, ChristmasIsland },
        { CocosIslands.Name, CocosIslands },
        { Colombia.Name, Colombia },
        { Comoros.Name, Comoros },
        { CongoBrazzaville.Name, CongoBrazzaville },
        { CongoKinshasa.Name, CongoKinshasa },
        { CookIslands.Name, CookIslands },
        { CostaRica.Name, CostaRica },
        { CoteDIvoire.Name, CoteDIvoire },
        { Croatia.Name, Croatia },
        { Cuba.Name, Cuba },
        { Cyprus.Name, Cyprus },
        { Curacao.Name, Curacao },
        { CzechRepublic.Name, CzechRepublic },
        { Denmark.Name, Denmark },
        { Djibouti.Name, Djibouti },
        { Dominica.Name, Dominica },
        { DominicanRepublic.Name, DominicanRepublic },
        { Ecuador.Name, Ecuador },
        { Egypt.Name, Egypt },
        { ElSalvador.Name, ElSalvador },
        { EquatorialGuinea.Name, EquatorialGuinea },
        { Eritrea.Name, Eritrea },
        { Estonia.Name, Estonia },
        { Ethiopia.Name, Ethiopia },
        { FalklandIslands.Name, FalklandIslands },
        { FaroeIslands.Name, FaroeIslands },
        { Fiji.Name, Fiji },
        { Finland.Name, Finland },
        { France.Name, France },
        { FrenchGuiana.Name, FrenchGuiana },
        { FrenchPolynesia.Name, FrenchPolynesia },
        { FrenchSouthernTerritories.Name, FrenchSouthernTerritories },
        { Gabon.Name, Gabon },
        { Gambia.Name, Gambia },
        { Georgia.Name, Georgia },
        { Germany.Name, Germany },
        { Ghana.Name, Ghana },
        { Gibraltar.Name, Gibraltar },
        { Greece.Name, Greece },
        { Greenland.Name, Greenland },
        { Grenada.Name, Grenada },
        { Guadeloupe.Name, Guadeloupe },
        { Guam.Name, Guam },
        { Guatemala.Name, Guatemala },
        { Guernsey.Name, Guernsey },
        { Guinea.Name, Guinea },
        { GuineaBissau.Name, GuineaBissau },
        { Guyana.Name, Guyana },
        { Haiti.Name, Haiti },
        { HeardAndMcdonaldIslands.Name, HeardAndMcdonaldIslands },
        { HolySee.Name, HolySee },
        { Honduras.Name, Honduras },
        { Hungary.Name, Hungary },
        { Iceland.Name, Iceland },
        { India.Name, India },
        { Indonesia.Name, Indonesia },
        { Iran.Name, Iran },
        { Iraq.Name, Iraq },
        { Ireland.Name, Ireland },
        { IsleOfMan.Name, IsleOfMan },
        { Israel.Name, Israel },
        { Italy.Name, Italy },
        { Jamaica.Name, Jamaica },
        { Japan.Name, Japan },
        { Jersey.Name, Jersey },
        { Jordan.Name, Jordan },
        { Kazakhstan.Name, Kazakhstan },
        { Kenya.Name, Kenya },
        { Kiribati.Name, Kiribati },
        { KoreaNorth.Name, KoreaNorth },
        { KoreaSouth.Name, KoreaSouth },
        { Kuwait.Name, Kuwait },
        { Kyrgyzstan.Name, Kyrgyzstan },
        { LaoPDR.Name, LaoPDR },
        { Latvia.Name, Latvia },
        { Lebanon.Name, Lebanon },
        { Lesotho.Name, Lesotho },
        { Liberia.Name, Liberia },
        { Libya.Name, Libya },
        { Liechtenstein.Name, Liechtenstein },
        { Lithuania.Name, Lithuania },
        { Luxembourg.Name, Luxembourg },
        { MacedoniaRepublicOf.Name, MacedoniaRepublicOf },
        { Madagascar.Name, Madagascar },
        { Malawi.Name, Malawi },
        { Malaysia.Name, Malaysia },
        { Maldives.Name, Maldives },
        { Mali.Name, Mali },
        { Malta.Name, Malta },
        { MarshallIslands.Name, MarshallIslands },
        { Martinique.Name, Martinique },
        { Mauritania.Name, Mauritania },
        { Mauritius.Name, Mauritius },
        { Mayotte.Name, Mayotte },
        { Mexico.Name, Mexico },
        { MicronesiaFederatedStatesOf.Name, MicronesiaFederatedStatesOf },
        { Moldova.Name, Moldova },
        { Monaco.Name, Monaco },
        { Mongolia.Name, Mongolia },
        { Montenegro.Name, Montenegro },
        { Montserrat.Name, Montserrat },
        { Morocco.Name, Morocco },
        { Mozambique.Name, Mozambique },
        { Myanmar.Name, Myanmar },
        { Namibia.Name, Namibia },
        { Nauru.Name, Nauru },
        { Nepal.Name, Nepal },
        { Netherlands.Name, Netherlands },
        { NetherlandsAntilles.Name, NetherlandsAntilles },
        { NewCaledonia.Name, NewCaledonia },
        { NewZealand.Name, NewZealand },
        { Nicaragua.Name, Nicaragua },
        { Niger.Name, Niger },
        { Nigeria.Name, Nigeria },
        { Niue.Name, Niue },
        { NorfolkIsland.Name, NorfolkIsland },
        { NorthernMarianaIslands.Name, NorthernMarianaIslands },
        { Norway.Name, Norway },
        { Oman.Name, Oman },
        { Pakistan.Name, Pakistan },
        { Palau.Name, Palau },
        { Palestine.Name, Palestine },
        { Panama.Name, Panama },
        { PapuaNewGuinea.Name, PapuaNewGuinea },
        { Paraguay.Name, Paraguay },
        { Peru.Name, Peru },
        { Philippines.Name, Philippines },
        { Pitcairn.Name, Pitcairn },
        { Poland.Name, Poland },
        { Portugal.Name, Portugal },
        { PuertoRico.Name, PuertoRico },
        { Qatar.Name, Qatar },
        { Reunion.Name, Reunion },
        { Romania.Name, Romania },
        { RussianFederation.Name, RussianFederation },
        { Rwanda.Name, Rwanda },
        { SaintBarthelemy.Name, SaintBarthelemy },
        { SaintHelena.Name, SaintHelena },
        { SaintKittsAndNevis.Name, SaintKittsAndNevis },
        { SaintLucia.Name, SaintLucia },
        { SaintMartinFrenchPart.Name, SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.Name, SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.Name, SaintVincentAndGrenadines },
        { Samoa.Name, Samoa },
        { SanMarino.Name, SanMarino },
        { SaoTomeAndPrincipe.Name, SaoTomeAndPrincipe },
        { SaudiArabia.Name, SaudiArabia },
        { Senegal.Name, Senegal },
        { Serbia.Name, Serbia },
        { Seychelles.Name, Seychelles },
        { SierraLeone.Name, SierraLeone },
        { Singapore.Name, Singapore },
        { SintMaarten.Name, SintMaarten },
        { Slovakia.Name, Slovakia },
        { Slovenia.Name, Slovenia },
        { SolomonIslands.Name, SolomonIslands },
        { Somalia.Name, Somalia },
        { SouthAfrica.Name, SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.Name, SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.Name, SouthSudan },
        { Spain.Name, Spain },
        { SriLanka.Name, SriLanka },
        { Sudan.Name, Sudan },
        { Suriname.Name, Suriname },
        { SvalbardAndJanMayenIslands.Name, SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.Name, Swaziland_Eswatini },
        { Sweden.Name, Sweden },
        { Switzerland.Name, Switzerland },
        { SyrianArabRepublic.Name, SyrianArabRepublic },
        { Taiwan.Name, Taiwan },
        { Tajikistan.Name, Tajikistan },
        { TanzaniaUnitedRepublicOf.Name, TanzaniaUnitedRepublicOf },
        { Thailand.Name, Thailand },
        { TimorLeste.Name, TimorLeste },
        { Togo.Name, Togo },
        { Tokelau.Name, Tokelau },
        { Tonga.Name, Tonga },
        { TrinidadAndTobago.Name, TrinidadAndTobago },
        { Tunisia.Name, Tunisia },
        { Turkey.Name, Turkey },
        { Turkmenistan.Name, Turkmenistan },
        { TurksAndCaicosIslands.Name, TurksAndCaicosIslands },
        { Tuvalu.Name, Tuvalu },
        { Uganda.Name, Uganda },
        { Ukraine.Name, Ukraine },
        { UnitedArabEmirates.Name, UnitedArabEmirates },
        { UnitedKingdom.Name, UnitedKingdom },
        { UnitedStatesOfAmerica.Name, UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.Name, USMinorOutlyingIslands },
        { Uruguay.Name, Uruguay },
        { Uzbekistan.Name, Uzbekistan },
        { Vanuatu.Name, Vanuatu },
        { VenezuelaBolivarianRepublic.Name, VenezuelaBolivarianRepublic },
        { VietNam.Name, VietNam },
        { VirginIslandsUS.Name, VirginIslandsUS },
        { WallisAndFutunaIslands.Name, WallisAndFutunaIslands },
        { WesternSahara.Name, WesternSahara },
        { Yemen.Name, Yemen },
        { Zambia.Name, Zambia },
        { Zimbabwe.Name, Zimbabwe }
    };

}