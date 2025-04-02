using System.Collections.Generic;

namespace Multiverse.Globalization.Countries;

public static class CountryHelper
{
    #region List
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

    #endregion 
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
        { None.Alpha2Code.ToLowerInvariant(), None },
        { Afghanistan.Alpha2Code.ToLowerInvariant(), Afghanistan },
        { AlandIslands.Alpha2Code.ToLowerInvariant(), AlandIslands },
        { Albania.Alpha2Code.ToLowerInvariant(), Albania },
        { Algeria.Alpha2Code.ToLowerInvariant(), Algeria },
        { AmericanSamoa.Alpha2Code.ToLowerInvariant(), AmericanSamoa },
        { Andorra.Alpha2Code.ToLowerInvariant(), Andorra },
        { Angola.Alpha2Code.ToLowerInvariant(), Angola },
        { Anguilla.Alpha2Code.ToLowerInvariant(), Anguilla },
        { Antarctica.Alpha2Code.ToLowerInvariant(), Antarctica },
        { AntiguaAndBarbuda.Alpha2Code.ToLowerInvariant(), AntiguaAndBarbuda },
        { Argentina.Alpha2Code.ToLowerInvariant(), Argentina },
        { Armenia.Alpha2Code.ToLowerInvariant(), Armenia },
        { Aruba.Alpha2Code.ToLowerInvariant(), Aruba },
        { Australia.Alpha2Code.ToLowerInvariant(), Australia },
        { Austria.Alpha2Code.ToLowerInvariant(), Austria },
        { Azerbaijan.Alpha2Code.ToLowerInvariant(), Azerbaijan },
        { Bahamas.Alpha2Code.ToLowerInvariant(), Bahamas },
        { Bahrain.Alpha2Code.ToLowerInvariant(), Bahrain },
        { Bangladesh.Alpha2Code.ToLowerInvariant(), Bangladesh },
        { Barbados.Alpha2Code.ToLowerInvariant(), Barbados },
        { Belarus.Alpha2Code.ToLowerInvariant(), Belarus },
        { Belgium.Alpha2Code.ToLowerInvariant(), Belgium },
        { Belize.Alpha2Code.ToLowerInvariant(), Belize },
        { Benin.Alpha2Code.ToLowerInvariant(), Benin },
        { Bermuda.Alpha2Code.ToLowerInvariant(), Bermuda },
        { Bhutan.Alpha2Code.ToLowerInvariant(), Bhutan },
        { Bolivia.Alpha2Code.ToLowerInvariant(), Bolivia },
        { BonaireSintEustatiusandSaba.Alpha2Code.ToLowerInvariant(), BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.Alpha2Code.ToLowerInvariant(), BosniaAndHerzegovina },
        { Botswana.Alpha2Code.ToLowerInvariant(), Botswana },
        { BouvetIsland.Alpha2Code.ToLowerInvariant(), BouvetIsland },
        { Brazil.Alpha2Code.ToLowerInvariant(), Brazil },
        { BritishVirginIslands.Alpha2Code.ToLowerInvariant(), BritishVirginIslands },
        { BritishIndianOceanTerritory.Alpha2Code.ToLowerInvariant(), BritishIndianOceanTerritory },
        { BruneiDarussalam.Alpha2Code.ToLowerInvariant(), BruneiDarussalam },
        { Bulgaria.Alpha2Code.ToLowerInvariant(), Bulgaria },
        { BurkinaFaso.Alpha2Code.ToLowerInvariant(), BurkinaFaso },
        { Burundi.Alpha2Code.ToLowerInvariant(), Burundi },
        { Cambodia.Alpha2Code.ToLowerInvariant(), Cambodia },
        { Cameroon.Alpha2Code.ToLowerInvariant(), Cameroon },
        { Canada.Alpha2Code.ToLowerInvariant(), Canada },
        { CapeVerde.Alpha2Code.ToLowerInvariant(), CapeVerde },
        { CaymanIslands.Alpha2Code.ToLowerInvariant(), CaymanIslands },
        { CentralAfricanRepublic.Alpha2Code.ToLowerInvariant(), CentralAfricanRepublic },
        { Chad.Alpha2Code.ToLowerInvariant(), Chad },
        { Chile.Alpha2Code.ToLowerInvariant(), Chile },
        { China.Alpha2Code.ToLowerInvariant(), China },
        { HongKong.Alpha2Code.ToLowerInvariant(), HongKong },
        { Macao.Alpha2Code.ToLowerInvariant(), Macao },
        { ChristmasIsland.Alpha2Code.ToLowerInvariant(), ChristmasIsland },
        { CocosIslands.Alpha2Code.ToLowerInvariant(), CocosIslands },
        { Colombia.Alpha2Code.ToLowerInvariant(), Colombia },
        { Comoros.Alpha2Code.ToLowerInvariant(), Comoros },
        { CongoBrazzaville.Alpha2Code.ToLowerInvariant(), CongoBrazzaville },
        { CongoKinshasa.Alpha2Code.ToLowerInvariant(), CongoKinshasa },
        { CookIslands.Alpha2Code.ToLowerInvariant(), CookIslands },
        { CostaRica.Alpha2Code.ToLowerInvariant(), CostaRica },
        { CoteDIvoire.Alpha2Code.ToLowerInvariant(), CoteDIvoire },
        { Croatia.Alpha2Code.ToLowerInvariant(), Croatia },
        { Cuba.Alpha2Code.ToLowerInvariant(), Cuba },
        { Cyprus.Alpha2Code.ToLowerInvariant(), Cyprus },
        { Curacao.Alpha2Code.ToLowerInvariant(), Curacao },
        { CzechRepublic.Alpha2Code.ToLowerInvariant(), CzechRepublic },
        { Denmark.Alpha2Code.ToLowerInvariant(), Denmark },
        { Djibouti.Alpha2Code.ToLowerInvariant(), Djibouti },
        { Dominica.Alpha2Code.ToLowerInvariant(), Dominica },
        { DominicanRepublic.Alpha2Code.ToLowerInvariant(), DominicanRepublic },
        { Ecuador.Alpha2Code.ToLowerInvariant(), Ecuador },
        { Egypt.Alpha2Code.ToLowerInvariant(), Egypt },
        { ElSalvador.Alpha2Code.ToLowerInvariant(), ElSalvador },
        { EquatorialGuinea.Alpha2Code.ToLowerInvariant(), EquatorialGuinea },
        { Eritrea.Alpha2Code.ToLowerInvariant(), Eritrea },
        { Estonia.Alpha2Code.ToLowerInvariant(), Estonia },
        { Ethiopia.Alpha2Code.ToLowerInvariant(), Ethiopia },
        { FalklandIslands.Alpha2Code.ToLowerInvariant(), FalklandIslands },
        { FaroeIslands.Alpha2Code.ToLowerInvariant(), FaroeIslands },
        { Fiji.Alpha2Code.ToLowerInvariant(), Fiji },
        { Finland.Alpha2Code.ToLowerInvariant(), Finland },
        { France.Alpha2Code.ToLowerInvariant(), France },
        { FrenchGuiana.Alpha2Code.ToLowerInvariant(), FrenchGuiana },
        { FrenchPolynesia.Alpha2Code.ToLowerInvariant(), FrenchPolynesia },
        { FrenchSouthernTerritories.Alpha2Code.ToLowerInvariant(), FrenchSouthernTerritories },
        { Gabon.Alpha2Code.ToLowerInvariant(), Gabon },
        { Gambia.Alpha2Code.ToLowerInvariant(), Gambia },
        { Georgia.Alpha2Code.ToLowerInvariant(), Georgia },
        { Germany.Alpha2Code.ToLowerInvariant(), Germany },
        { Ghana.Alpha2Code.ToLowerInvariant(), Ghana },
        { Gibraltar.Alpha2Code.ToLowerInvariant(), Gibraltar },
        { Greece.Alpha2Code.ToLowerInvariant(), Greece },
        { Greenland.Alpha2Code.ToLowerInvariant(), Greenland },
        { Grenada.Alpha2Code.ToLowerInvariant(), Grenada },
        { Guadeloupe.Alpha2Code.ToLowerInvariant(), Guadeloupe },
        { Guam.Alpha2Code.ToLowerInvariant(), Guam },
        { Guatemala.Alpha2Code.ToLowerInvariant(), Guatemala },
        { Guernsey.Alpha2Code.ToLowerInvariant(), Guernsey },
        { Guinea.Alpha2Code.ToLowerInvariant(), Guinea },
        { GuineaBissau.Alpha2Code.ToLowerInvariant(), GuineaBissau },
        { Guyana.Alpha2Code.ToLowerInvariant(), Guyana },
        { Haiti.Alpha2Code.ToLowerInvariant(), Haiti },
        { HeardAndMcdonaldIslands.Alpha2Code.ToLowerInvariant(), HeardAndMcdonaldIslands },
        { HolySee.Alpha2Code.ToLowerInvariant(), HolySee },
        { Honduras.Alpha2Code.ToLowerInvariant(), Honduras },
        { Hungary.Alpha2Code.ToLowerInvariant(), Hungary },
        { Iceland.Alpha2Code.ToLowerInvariant(), Iceland },
        { India.Alpha2Code.ToLowerInvariant(), India },
        { Indonesia.Alpha2Code.ToLowerInvariant(), Indonesia },
        { Iran.Alpha2Code.ToLowerInvariant(), Iran },
        { Iraq.Alpha2Code.ToLowerInvariant(), Iraq },
        { Ireland.Alpha2Code.ToLowerInvariant(), Ireland },
        { IsleOfMan.Alpha2Code.ToLowerInvariant(), IsleOfMan },
        { Israel.Alpha2Code.ToLowerInvariant(), Israel },
        { Italy.Alpha2Code.ToLowerInvariant(), Italy },
        { Jamaica.Alpha2Code.ToLowerInvariant(), Jamaica },
        { Japan.Alpha2Code.ToLowerInvariant(), Japan },
        { Jersey.Alpha2Code.ToLowerInvariant(), Jersey },
        { Jordan.Alpha2Code.ToLowerInvariant(), Jordan },
        { Kazakhstan.Alpha2Code.ToLowerInvariant(), Kazakhstan },
        { Kenya.Alpha2Code.ToLowerInvariant(), Kenya },
        { Kiribati.Alpha2Code.ToLowerInvariant(), Kiribati },
        { KoreaNorth.Alpha2Code.ToLowerInvariant(), KoreaNorth },
        { KoreaSouth.Alpha2Code.ToLowerInvariant(), KoreaSouth },
        { Kuwait.Alpha2Code.ToLowerInvariant(), Kuwait },
        { Kyrgyzstan.Alpha2Code.ToLowerInvariant(), Kyrgyzstan },
        { LaoPDR.Alpha2Code.ToLowerInvariant(), LaoPDR },
        { Latvia.Alpha2Code.ToLowerInvariant(), Latvia },
        { Lebanon.Alpha2Code.ToLowerInvariant(), Lebanon },
        { Lesotho.Alpha2Code.ToLowerInvariant(), Lesotho },
        { Liberia.Alpha2Code.ToLowerInvariant(), Liberia },
        { Libya.Alpha2Code.ToLowerInvariant(), Libya },
        { Liechtenstein.Alpha2Code.ToLowerInvariant(), Liechtenstein },
        { Lithuania.Alpha2Code.ToLowerInvariant(), Lithuania },
        { Luxembourg.Alpha2Code.ToLowerInvariant(), Luxembourg },
        { MacedoniaRepublicOf.Alpha2Code.ToLowerInvariant(), MacedoniaRepublicOf },
        { Madagascar.Alpha2Code.ToLowerInvariant(), Madagascar },
        { Malawi.Alpha2Code.ToLowerInvariant(), Malawi },
        { Malaysia.Alpha2Code.ToLowerInvariant(), Malaysia },
        { Maldives.Alpha2Code.ToLowerInvariant(), Maldives },
        { Mali.Alpha2Code.ToLowerInvariant(), Mali },
        { Malta.Alpha2Code.ToLowerInvariant(), Malta },
        { MarshallIslands.Alpha2Code.ToLowerInvariant(), MarshallIslands },
        { Martinique.Alpha2Code.ToLowerInvariant(), Martinique },
        { Mauritania.Alpha2Code.ToLowerInvariant(), Mauritania },
        { Mauritius.Alpha2Code.ToLowerInvariant(), Mauritius },
        { Mayotte.Alpha2Code.ToLowerInvariant(), Mayotte },
        { Mexico.Alpha2Code.ToLowerInvariant(), Mexico },
        { MicronesiaFederatedStatesOf.Alpha2Code.ToLowerInvariant(), MicronesiaFederatedStatesOf },
        { Moldova.Alpha2Code.ToLowerInvariant(), Moldova },
        { Monaco.Alpha2Code.ToLowerInvariant(), Monaco },
        { Mongolia.Alpha2Code.ToLowerInvariant(), Mongolia },
        { Montenegro.Alpha2Code.ToLowerInvariant(), Montenegro },
        { Montserrat.Alpha2Code.ToLowerInvariant(), Montserrat },
        { Morocco.Alpha2Code.ToLowerInvariant(), Morocco },
        { Mozambique.Alpha2Code.ToLowerInvariant(), Mozambique },
        { Myanmar.Alpha2Code.ToLowerInvariant(), Myanmar },
        { Namibia.Alpha2Code.ToLowerInvariant(), Namibia },
        { Nauru.Alpha2Code.ToLowerInvariant(), Nauru },
        { Nepal.Alpha2Code.ToLowerInvariant(), Nepal },
        { Netherlands.Alpha2Code.ToLowerInvariant(), Netherlands },
        { NetherlandsAntilles.Alpha2Code.ToLowerInvariant(), NetherlandsAntilles },
        { NewCaledonia.Alpha2Code.ToLowerInvariant(), NewCaledonia },
        { NewZealand.Alpha2Code.ToLowerInvariant(), NewZealand },
        { Nicaragua.Alpha2Code.ToLowerInvariant(), Nicaragua },
        { Niger.Alpha2Code.ToLowerInvariant(), Niger },
        { Nigeria.Alpha2Code.ToLowerInvariant(), Nigeria },
        { Niue.Alpha2Code.ToLowerInvariant(), Niue },
        { NorfolkIsland.Alpha2Code.ToLowerInvariant(), NorfolkIsland },
        { NorthernMarianaIslands.Alpha2Code.ToLowerInvariant(), NorthernMarianaIslands },
        { Norway.Alpha2Code.ToLowerInvariant(), Norway },
        { Oman.Alpha2Code.ToLowerInvariant(), Oman },
        { Pakistan.Alpha2Code.ToLowerInvariant(), Pakistan },
        { Palau.Alpha2Code.ToLowerInvariant(), Palau },
        { Palestine.Alpha2Code.ToLowerInvariant(), Palestine },
        { Panama.Alpha2Code.ToLowerInvariant(), Panama },
        { PapuaNewGuinea.Alpha2Code.ToLowerInvariant(), PapuaNewGuinea },
        { Paraguay.Alpha2Code.ToLowerInvariant(), Paraguay },
        { Peru.Alpha2Code.ToLowerInvariant(), Peru },
        { Philippines.Alpha2Code.ToLowerInvariant(), Philippines },
        { Pitcairn.Alpha2Code.ToLowerInvariant(), Pitcairn },
        { Poland.Alpha2Code.ToLowerInvariant(), Poland },
        { Portugal.Alpha2Code.ToLowerInvariant(), Portugal },
        { PuertoRico.Alpha2Code.ToLowerInvariant(), PuertoRico },
        { Qatar.Alpha2Code.ToLowerInvariant(), Qatar },
        { Reunion.Alpha2Code.ToLowerInvariant(), Reunion },
        { Romania.Alpha2Code.ToLowerInvariant(), Romania },
        { RussianFederation.Alpha2Code.ToLowerInvariant(), RussianFederation },
        { Rwanda.Alpha2Code.ToLowerInvariant(), Rwanda },
        { SaintBarthelemy.Alpha2Code.ToLowerInvariant(), SaintBarthelemy },
        { SaintHelena.Alpha2Code.ToLowerInvariant(), SaintHelena },
        { SaintKittsAndNevis.Alpha2Code.ToLowerInvariant(), SaintKittsAndNevis },
        { SaintLucia.Alpha2Code.ToLowerInvariant(), SaintLucia },
        { SaintMartinFrenchPart.Alpha2Code.ToLowerInvariant(), SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.Alpha2Code.ToLowerInvariant(), SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.Alpha2Code.ToLowerInvariant(), SaintVincentAndGrenadines },
        { Samoa.Alpha2Code.ToLowerInvariant(), Samoa },
        { SanMarino.Alpha2Code.ToLowerInvariant(), SanMarino },
        { SaoTomeAndPrincipe.Alpha2Code.ToLowerInvariant(), SaoTomeAndPrincipe },
        { SaudiArabia.Alpha2Code.ToLowerInvariant(), SaudiArabia },
        { Senegal.Alpha2Code.ToLowerInvariant(), Senegal },
        { Serbia.Alpha2Code.ToLowerInvariant(), Serbia },
        { Seychelles.Alpha2Code.ToLowerInvariant(), Seychelles },
        { SierraLeone.Alpha2Code.ToLowerInvariant(), SierraLeone },
        { Singapore.Alpha2Code.ToLowerInvariant(), Singapore },
        { SintMaarten.Alpha2Code.ToLowerInvariant(), SintMaarten },
        { Slovakia.Alpha2Code.ToLowerInvariant(), Slovakia },
        { Slovenia.Alpha2Code.ToLowerInvariant(), Slovenia },
        { SolomonIslands.Alpha2Code.ToLowerInvariant(), SolomonIslands },
        { Somalia.Alpha2Code.ToLowerInvariant(), Somalia },
        { SouthAfrica.Alpha2Code.ToLowerInvariant(), SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.Alpha2Code.ToLowerInvariant(), SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.Alpha2Code.ToLowerInvariant(), SouthSudan },
        { Spain.Alpha2Code.ToLowerInvariant(), Spain },
        { SriLanka.Alpha2Code.ToLowerInvariant(), SriLanka },
        { Sudan.Alpha2Code.ToLowerInvariant(), Sudan },
        { Suriname.Alpha2Code.ToLowerInvariant(), Suriname },
        { SvalbardAndJanMayenIslands.Alpha2Code.ToLowerInvariant(), SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.Alpha2Code.ToLowerInvariant(), Swaziland_Eswatini },
        { Sweden.Alpha2Code.ToLowerInvariant(), Sweden },
        { Switzerland.Alpha2Code.ToLowerInvariant(), Switzerland },
        { SyrianArabRepublic.Alpha2Code.ToLowerInvariant(), SyrianArabRepublic },
        { Taiwan.Alpha2Code.ToLowerInvariant(), Taiwan },
        { Tajikistan.Alpha2Code.ToLowerInvariant(), Tajikistan },
        { TanzaniaUnitedRepublicOf.Alpha2Code.ToLowerInvariant(), TanzaniaUnitedRepublicOf },
        { Thailand.Alpha2Code.ToLowerInvariant(), Thailand },
        { TimorLeste.Alpha2Code.ToLowerInvariant(), TimorLeste },
        { Togo.Alpha2Code.ToLowerInvariant(), Togo },
        { Tokelau.Alpha2Code.ToLowerInvariant(), Tokelau },
        { Tonga.Alpha2Code.ToLowerInvariant(), Tonga },
        { TrinidadAndTobago.Alpha2Code.ToLowerInvariant(), TrinidadAndTobago },
        { Tunisia.Alpha2Code.ToLowerInvariant(), Tunisia },
        { Turkey.Alpha2Code.ToLowerInvariant(), Turkey },
        { Turkmenistan.Alpha2Code.ToLowerInvariant(), Turkmenistan },
        { TurksAndCaicosIslands.Alpha2Code.ToLowerInvariant(), TurksAndCaicosIslands },
        { Tuvalu.Alpha2Code.ToLowerInvariant(), Tuvalu },
        { Uganda.Alpha2Code.ToLowerInvariant(), Uganda },
        { Ukraine.Alpha2Code.ToLowerInvariant(), Ukraine },
        { UnitedArabEmirates.Alpha2Code.ToLowerInvariant(), UnitedArabEmirates },
        { UnitedKingdom.Alpha2Code.ToLowerInvariant(), UnitedKingdom },
        { UnitedStatesOfAmerica.Alpha2Code.ToLowerInvariant(), UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.Alpha2Code.ToLowerInvariant(), USMinorOutlyingIslands },
        { Uruguay.Alpha2Code.ToLowerInvariant(), Uruguay },
        { Uzbekistan.Alpha2Code.ToLowerInvariant(), Uzbekistan },
        { Vanuatu.Alpha2Code.ToLowerInvariant(), Vanuatu },
        { VenezuelaBolivarianRepublic.Alpha2Code.ToLowerInvariant(), VenezuelaBolivarianRepublic },
        { VietNam.Alpha2Code.ToLowerInvariant(), VietNam },
        { VirginIslandsUS.Alpha2Code.ToLowerInvariant(), VirginIslandsUS },
        { WallisAndFutunaIslands.Alpha2Code.ToLowerInvariant(), WallisAndFutunaIslands },
        { WesternSahara.Alpha2Code.ToLowerInvariant(), WesternSahara },
        { Yemen.Alpha2Code.ToLowerInvariant(), Yemen },
        { Zambia.Alpha2Code.ToLowerInvariant(), Zambia },
        { Zimbabwe.Alpha2Code.ToLowerInvariant(), Zimbabwe }
    };

    public static readonly IReadOnlyDictionary<string, Country> Alpha3CodeMap = new Dictionary<string, Country>
    {
        { None.Alpha3Code.ToLowerInvariant(), None },
        { Afghanistan.Alpha3Code.ToLowerInvariant(), Afghanistan },
        { AlandIslands.Alpha3Code.ToLowerInvariant(), AlandIslands },
        { Albania.Alpha3Code.ToLowerInvariant(), Albania },
        { Algeria.Alpha3Code.ToLowerInvariant(), Algeria },
        { AmericanSamoa.Alpha3Code.ToLowerInvariant(), AmericanSamoa },
        { Andorra.Alpha3Code.ToLowerInvariant(), Andorra },
        { Angola.Alpha3Code.ToLowerInvariant(), Angola },
        { Anguilla.Alpha3Code.ToLowerInvariant(), Anguilla },
        { Antarctica.Alpha3Code.ToLowerInvariant(), Antarctica },
        { AntiguaAndBarbuda.Alpha3Code.ToLowerInvariant(), AntiguaAndBarbuda },
        { Argentina.Alpha3Code.ToLowerInvariant(), Argentina },
        { Armenia.Alpha3Code.ToLowerInvariant(), Armenia },
        { Aruba.Alpha3Code.ToLowerInvariant(), Aruba },
        { Australia.Alpha3Code.ToLowerInvariant(), Australia },
        { Austria.Alpha3Code.ToLowerInvariant(), Austria },
        { Azerbaijan.Alpha3Code.ToLowerInvariant(), Azerbaijan },
        { Bahamas.Alpha3Code.ToLowerInvariant(), Bahamas },
        { Bahrain.Alpha3Code.ToLowerInvariant(), Bahrain },
        { Bangladesh.Alpha3Code.ToLowerInvariant(), Bangladesh },
        { Barbados.Alpha3Code.ToLowerInvariant(), Barbados },
        { Belarus.Alpha3Code.ToLowerInvariant(), Belarus },
        { Belgium.Alpha3Code.ToLowerInvariant(), Belgium },
        { Belize.Alpha3Code.ToLowerInvariant(), Belize },
        { Benin.Alpha3Code.ToLowerInvariant(), Benin },
        { Bermuda.Alpha3Code.ToLowerInvariant(), Bermuda },
        { Bhutan.Alpha3Code.ToLowerInvariant(), Bhutan },
        { Bolivia.Alpha3Code.ToLowerInvariant(), Bolivia },
        { BonaireSintEustatiusandSaba.Alpha3Code.ToLowerInvariant(), BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.Alpha3Code.ToLowerInvariant(), BosniaAndHerzegovina },
        { Botswana.Alpha3Code.ToLowerInvariant(), Botswana },
        { BouvetIsland.Alpha3Code.ToLowerInvariant(), BouvetIsland },
        { Brazil.Alpha3Code.ToLowerInvariant(), Brazil },
        { BritishVirginIslands.Alpha3Code.ToLowerInvariant(), BritishVirginIslands },
        { BritishIndianOceanTerritory.Alpha3Code.ToLowerInvariant(), BritishIndianOceanTerritory },
        { BruneiDarussalam.Alpha3Code.ToLowerInvariant(), BruneiDarussalam },
        { Bulgaria.Alpha3Code.ToLowerInvariant(), Bulgaria },
        { BurkinaFaso.Alpha3Code.ToLowerInvariant(), BurkinaFaso },
        { Burundi.Alpha3Code.ToLowerInvariant(), Burundi },
        { Cambodia.Alpha3Code.ToLowerInvariant(), Cambodia },
        { Cameroon.Alpha3Code.ToLowerInvariant(), Cameroon },
        { Canada.Alpha3Code.ToLowerInvariant(), Canada },
        { CapeVerde.Alpha3Code.ToLowerInvariant(), CapeVerde },
        { CaymanIslands.Alpha3Code.ToLowerInvariant(), CaymanIslands },
        { CentralAfricanRepublic.Alpha3Code.ToLowerInvariant(), CentralAfricanRepublic },
        { Chad.Alpha3Code.ToLowerInvariant(), Chad },
        { Chile.Alpha3Code.ToLowerInvariant(), Chile },
        { China.Alpha3Code.ToLowerInvariant(), China },
        { HongKong.Alpha3Code.ToLowerInvariant(), HongKong },
        { Macao.Alpha3Code.ToLowerInvariant(), Macao },
        { ChristmasIsland.Alpha3Code.ToLowerInvariant(), ChristmasIsland },
        { CocosIslands.Alpha3Code.ToLowerInvariant(), CocosIslands },
        { Colombia.Alpha3Code.ToLowerInvariant(), Colombia },
        { Comoros.Alpha3Code.ToLowerInvariant(), Comoros },
        { CongoBrazzaville.Alpha3Code.ToLowerInvariant(), CongoBrazzaville },
        { CongoKinshasa.Alpha3Code.ToLowerInvariant(), CongoKinshasa },
        { CookIslands.Alpha3Code.ToLowerInvariant(), CookIslands },
        { CostaRica.Alpha3Code.ToLowerInvariant(), CostaRica },
        { CoteDIvoire.Alpha3Code.ToLowerInvariant(), CoteDIvoire },
        { Croatia.Alpha3Code.ToLowerInvariant(), Croatia },
        { Cuba.Alpha3Code.ToLowerInvariant(), Cuba },
        { Cyprus.Alpha3Code.ToLowerInvariant(), Cyprus },
        { Curacao.Alpha3Code.ToLowerInvariant(), Curacao },
        { CzechRepublic.Alpha3Code.ToLowerInvariant(), CzechRepublic },
        { Denmark.Alpha3Code.ToLowerInvariant(), Denmark },
        { Djibouti.Alpha3Code.ToLowerInvariant(), Djibouti },
        { Dominica.Alpha3Code.ToLowerInvariant(), Dominica },
        { DominicanRepublic.Alpha3Code.ToLowerInvariant(), DominicanRepublic },
        { Ecuador.Alpha3Code.ToLowerInvariant(), Ecuador },
        { Egypt.Alpha3Code.ToLowerInvariant(), Egypt },
        { ElSalvador.Alpha3Code.ToLowerInvariant(), ElSalvador },
        { EquatorialGuinea.Alpha3Code.ToLowerInvariant(), EquatorialGuinea },
        { Eritrea.Alpha3Code.ToLowerInvariant(), Eritrea },
        { Estonia.Alpha3Code.ToLowerInvariant(), Estonia },
        { Ethiopia.Alpha3Code.ToLowerInvariant(), Ethiopia },
        { FalklandIslands.Alpha3Code.ToLowerInvariant(), FalklandIslands },
        { FaroeIslands.Alpha3Code.ToLowerInvariant(), FaroeIslands },
        { Fiji.Alpha3Code.ToLowerInvariant(), Fiji },
        { Finland.Alpha3Code.ToLowerInvariant(), Finland },
        { France.Alpha3Code.ToLowerInvariant(), France },
        { FrenchGuiana.Alpha3Code.ToLowerInvariant(), FrenchGuiana },
        { FrenchPolynesia.Alpha3Code.ToLowerInvariant(), FrenchPolynesia },
        { FrenchSouthernTerritories.Alpha3Code.ToLowerInvariant(), FrenchSouthernTerritories },
        { Gabon.Alpha3Code.ToLowerInvariant(), Gabon },
        { Gambia.Alpha3Code.ToLowerInvariant(), Gambia },
        { Georgia.Alpha3Code.ToLowerInvariant(), Georgia },
        { Germany.Alpha3Code.ToLowerInvariant(), Germany },
        { Ghana.Alpha3Code.ToLowerInvariant(), Ghana },
        { Gibraltar.Alpha3Code.ToLowerInvariant(), Gibraltar },
        { Greece.Alpha3Code.ToLowerInvariant(), Greece },
        { Greenland.Alpha3Code.ToLowerInvariant(), Greenland },
        { Grenada.Alpha3Code.ToLowerInvariant(), Grenada },
        { Guadeloupe.Alpha3Code.ToLowerInvariant(), Guadeloupe },
        { Guam.Alpha3Code.ToLowerInvariant(), Guam },
        { Guatemala.Alpha3Code.ToLowerInvariant(), Guatemala },
        { Guernsey.Alpha3Code.ToLowerInvariant(), Guernsey },
        { Guinea.Alpha3Code.ToLowerInvariant(), Guinea },
        { GuineaBissau.Alpha3Code.ToLowerInvariant(), GuineaBissau },
        { Guyana.Alpha3Code.ToLowerInvariant(), Guyana },
        { Haiti.Alpha3Code.ToLowerInvariant(), Haiti },
        { HeardAndMcdonaldIslands.Alpha3Code.ToLowerInvariant(), HeardAndMcdonaldIslands },
        { HolySee.Alpha3Code.ToLowerInvariant(), HolySee },
        { Honduras.Alpha3Code.ToLowerInvariant(), Honduras },
        { Hungary.Alpha3Code.ToLowerInvariant(), Hungary },
        { Iceland.Alpha3Code.ToLowerInvariant(), Iceland },
        { India.Alpha3Code.ToLowerInvariant(), India },
        { Indonesia.Alpha3Code.ToLowerInvariant(), Indonesia },
        { Iran.Alpha3Code.ToLowerInvariant(), Iran },
        { Iraq.Alpha3Code.ToLowerInvariant(), Iraq },
        { Ireland.Alpha3Code.ToLowerInvariant(), Ireland },
        { IsleOfMan.Alpha3Code.ToLowerInvariant(), IsleOfMan },
        { Israel.Alpha3Code.ToLowerInvariant(), Israel },
        { Italy.Alpha3Code.ToLowerInvariant(), Italy },
        { Jamaica.Alpha3Code.ToLowerInvariant(), Jamaica },
        { Japan.Alpha3Code.ToLowerInvariant(), Japan },
        { Jersey.Alpha3Code.ToLowerInvariant(), Jersey },
        { Jordan.Alpha3Code.ToLowerInvariant(), Jordan },
        { Kazakhstan.Alpha3Code.ToLowerInvariant(), Kazakhstan },
        { Kenya.Alpha3Code.ToLowerInvariant(), Kenya },
        { Kiribati.Alpha3Code.ToLowerInvariant(), Kiribati },
        { KoreaNorth.Alpha3Code.ToLowerInvariant(), KoreaNorth },
        { KoreaSouth.Alpha3Code.ToLowerInvariant(), KoreaSouth },
        { Kuwait.Alpha3Code.ToLowerInvariant(), Kuwait },
        { Kyrgyzstan.Alpha3Code.ToLowerInvariant(), Kyrgyzstan },
        { LaoPDR.Alpha3Code.ToLowerInvariant(), LaoPDR },
        { Latvia.Alpha3Code.ToLowerInvariant(), Latvia },
        { Lebanon.Alpha3Code.ToLowerInvariant(), Lebanon },
        { Lesotho.Alpha3Code.ToLowerInvariant(), Lesotho },
        { Liberia.Alpha3Code.ToLowerInvariant(), Liberia },
        { Libya.Alpha3Code.ToLowerInvariant(), Libya },
        { Liechtenstein.Alpha3Code.ToLowerInvariant(), Liechtenstein },
        { Lithuania.Alpha3Code.ToLowerInvariant(), Lithuania },
        { Luxembourg.Alpha3Code.ToLowerInvariant(), Luxembourg },
        { MacedoniaRepublicOf.Alpha3Code.ToLowerInvariant(), MacedoniaRepublicOf },
        { Madagascar.Alpha3Code.ToLowerInvariant(), Madagascar },
        { Malawi.Alpha3Code.ToLowerInvariant(), Malawi },
        { Malaysia.Alpha3Code.ToLowerInvariant(), Malaysia },
        { Maldives.Alpha3Code.ToLowerInvariant(), Maldives },
        { Mali.Alpha3Code.ToLowerInvariant(), Mali },
        { Malta.Alpha3Code.ToLowerInvariant(), Malta },
        { MarshallIslands.Alpha3Code.ToLowerInvariant(), MarshallIslands },
        { Martinique.Alpha3Code.ToLowerInvariant(), Martinique },
        { Mauritania.Alpha3Code.ToLowerInvariant(), Mauritania },
        { Mauritius.Alpha3Code.ToLowerInvariant(), Mauritius },
        { Mayotte.Alpha3Code.ToLowerInvariant(), Mayotte },
        { Mexico.Alpha3Code.ToLowerInvariant(), Mexico },
        { MicronesiaFederatedStatesOf.Alpha3Code.ToLowerInvariant(), MicronesiaFederatedStatesOf },
        { Moldova.Alpha3Code.ToLowerInvariant(), Moldova },
        { Monaco.Alpha3Code.ToLowerInvariant(), Monaco },
        { Mongolia.Alpha3Code.ToLowerInvariant(), Mongolia },
        { Montenegro.Alpha3Code.ToLowerInvariant(), Montenegro },
        { Montserrat.Alpha3Code.ToLowerInvariant(), Montserrat },
        { Morocco.Alpha3Code.ToLowerInvariant(), Morocco },
        { Mozambique.Alpha3Code.ToLowerInvariant(), Mozambique },
        { Myanmar.Alpha3Code.ToLowerInvariant(), Myanmar },
        { Namibia.Alpha3Code.ToLowerInvariant(), Namibia },
        { Nauru.Alpha3Code.ToLowerInvariant(), Nauru },
        { Nepal.Alpha3Code.ToLowerInvariant(), Nepal },
        { Netherlands.Alpha3Code.ToLowerInvariant(), Netherlands },
        { NetherlandsAntilles.Alpha3Code.ToLowerInvariant(), NetherlandsAntilles },
        { NewCaledonia.Alpha3Code.ToLowerInvariant(), NewCaledonia },
        { NewZealand.Alpha3Code.ToLowerInvariant(), NewZealand },
        { Nicaragua.Alpha3Code.ToLowerInvariant(), Nicaragua },
        { Niger.Alpha3Code.ToLowerInvariant(), Niger },
        { Nigeria.Alpha3Code.ToLowerInvariant(), Nigeria },
        { Niue.Alpha3Code.ToLowerInvariant(), Niue },
        { NorfolkIsland.Alpha3Code.ToLowerInvariant(), NorfolkIsland },
        { NorthernMarianaIslands.Alpha3Code.ToLowerInvariant(), NorthernMarianaIslands },
        { Norway.Alpha3Code.ToLowerInvariant(), Norway },
        { Oman.Alpha3Code.ToLowerInvariant(), Oman },
        { Pakistan.Alpha3Code.ToLowerInvariant(), Pakistan },
        { Palau.Alpha3Code.ToLowerInvariant(), Palau },
        { Palestine.Alpha3Code.ToLowerInvariant(), Palestine },
        { Panama.Alpha3Code.ToLowerInvariant(), Panama },
        { PapuaNewGuinea.Alpha3Code.ToLowerInvariant(), PapuaNewGuinea },
        { Paraguay.Alpha3Code.ToLowerInvariant(), Paraguay },
        { Peru.Alpha3Code.ToLowerInvariant(), Peru },
        { Philippines.Alpha3Code.ToLowerInvariant(), Philippines },
        { Pitcairn.Alpha3Code.ToLowerInvariant(), Pitcairn },
        { Poland.Alpha3Code.ToLowerInvariant(), Poland },
        { Portugal.Alpha3Code.ToLowerInvariant(), Portugal },
        { PuertoRico.Alpha3Code.ToLowerInvariant(), PuertoRico },
        { Qatar.Alpha3Code.ToLowerInvariant(), Qatar },
        { Reunion.Alpha3Code.ToLowerInvariant(), Reunion },
        { Romania.Alpha3Code.ToLowerInvariant(), Romania },
        { RussianFederation.Alpha3Code.ToLowerInvariant(), RussianFederation },
        { Rwanda.Alpha3Code.ToLowerInvariant(), Rwanda },
        { SaintBarthelemy.Alpha3Code.ToLowerInvariant(), SaintBarthelemy },
        { SaintHelena.Alpha3Code.ToLowerInvariant(), SaintHelena },
        { SaintKittsAndNevis.Alpha3Code.ToLowerInvariant(), SaintKittsAndNevis },
        { SaintLucia.Alpha3Code.ToLowerInvariant(), SaintLucia },
        { SaintMartinFrenchPart.Alpha3Code.ToLowerInvariant(), SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.Alpha3Code.ToLowerInvariant(), SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.Alpha3Code.ToLowerInvariant(), SaintVincentAndGrenadines },
        { Samoa.Alpha3Code.ToLowerInvariant(), Samoa },
        { SanMarino.Alpha3Code.ToLowerInvariant(), SanMarino },
        { SaoTomeAndPrincipe.Alpha3Code.ToLowerInvariant(), SaoTomeAndPrincipe },
        { SaudiArabia.Alpha3Code.ToLowerInvariant(), SaudiArabia },
        { Senegal.Alpha3Code.ToLowerInvariant(), Senegal },
        { Serbia.Alpha3Code.ToLowerInvariant(), Serbia },
        { Seychelles.Alpha3Code.ToLowerInvariant(), Seychelles },
        { SierraLeone.Alpha3Code.ToLowerInvariant(), SierraLeone },
        { Singapore.Alpha3Code.ToLowerInvariant(), Singapore },
        { SintMaarten.Alpha3Code.ToLowerInvariant(), SintMaarten },
        { Slovakia.Alpha3Code.ToLowerInvariant(), Slovakia },
        { Slovenia.Alpha3Code.ToLowerInvariant(), Slovenia },
        { SolomonIslands.Alpha3Code.ToLowerInvariant(), SolomonIslands },
        { Somalia.Alpha3Code.ToLowerInvariant(), Somalia },
        { SouthAfrica.Alpha3Code.ToLowerInvariant(), SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.Alpha3Code.ToLowerInvariant(), SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.Alpha3Code.ToLowerInvariant(), SouthSudan },
        { Spain.Alpha3Code.ToLowerInvariant(), Spain },
        { SriLanka.Alpha3Code.ToLowerInvariant(), SriLanka },
        { Sudan.Alpha3Code.ToLowerInvariant(), Sudan },
        { Suriname.Alpha3Code.ToLowerInvariant(), Suriname },
        { SvalbardAndJanMayenIslands.Alpha3Code.ToLowerInvariant(), SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.Alpha3Code.ToLowerInvariant(), Swaziland_Eswatini },
        { Sweden.Alpha3Code.ToLowerInvariant(), Sweden },
        { Switzerland.Alpha3Code.ToLowerInvariant(), Switzerland },
        { SyrianArabRepublic.Alpha3Code.ToLowerInvariant(), SyrianArabRepublic },
        { Taiwan.Alpha3Code.ToLowerInvariant(), Taiwan },
        { Tajikistan.Alpha3Code.ToLowerInvariant(), Tajikistan },
        { TanzaniaUnitedRepublicOf.Alpha3Code.ToLowerInvariant(), TanzaniaUnitedRepublicOf },
        { Thailand.Alpha3Code.ToLowerInvariant(), Thailand },
        { TimorLeste.Alpha3Code.ToLowerInvariant(), TimorLeste },
        { Togo.Alpha3Code.ToLowerInvariant(), Togo },
        { Tokelau.Alpha3Code.ToLowerInvariant(), Tokelau },
        { Tonga.Alpha3Code.ToLowerInvariant(), Tonga },
        { TrinidadAndTobago.Alpha3Code.ToLowerInvariant(), TrinidadAndTobago },
        { Tunisia.Alpha3Code.ToLowerInvariant(), Tunisia },
        { Turkey.Alpha3Code.ToLowerInvariant(), Turkey },
        { Turkmenistan.Alpha3Code.ToLowerInvariant(), Turkmenistan },
        { TurksAndCaicosIslands.Alpha3Code.ToLowerInvariant(), TurksAndCaicosIslands },
        { Tuvalu.Alpha3Code.ToLowerInvariant(), Tuvalu },
        { Uganda.Alpha3Code.ToLowerInvariant(), Uganda },
        { Ukraine.Alpha3Code.ToLowerInvariant(), Ukraine },
        { UnitedArabEmirates.Alpha3Code.ToLowerInvariant(), UnitedArabEmirates },
        { UnitedKingdom.Alpha3Code.ToLowerInvariant(), UnitedKingdom },
        { UnitedStatesOfAmerica.Alpha3Code.ToLowerInvariant(), UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.Alpha3Code.ToLowerInvariant(), USMinorOutlyingIslands },
        { Uruguay.Alpha3Code.ToLowerInvariant(), Uruguay },
        { Uzbekistan.Alpha3Code.ToLowerInvariant(), Uzbekistan },
        { Vanuatu.Alpha3Code.ToLowerInvariant(), Vanuatu },
        { VenezuelaBolivarianRepublic.Alpha3Code.ToLowerInvariant(), VenezuelaBolivarianRepublic },
        { VietNam.Alpha3Code.ToLowerInvariant(), VietNam },
        { VirginIslandsUS.Alpha3Code.ToLowerInvariant(), VirginIslandsUS },
        { WallisAndFutunaIslands.Alpha3Code.ToLowerInvariant(), WallisAndFutunaIslands },
        { WesternSahara.Alpha3Code.ToLowerInvariant(), WesternSahara },
        { Yemen.Alpha3Code.ToLowerInvariant(), Yemen },
        { Zambia.Alpha3Code.ToLowerInvariant(), Zambia },
        { Zimbabwe.Alpha3Code.ToLowerInvariant(), Zimbabwe }
    };

    public static readonly IReadOnlyDictionary<string, Country> NameMap = new Dictionary<string, Country>
    {
        {None.Name.ToLowerInvariant(), None },
        { Afghanistan.Name.ToLowerInvariant(), Afghanistan },
        { AlandIslands.Name.ToLowerInvariant(), AlandIslands },
        { Albania.Name.ToLowerInvariant(), Albania },
        { Algeria.Name.ToLowerInvariant(), Algeria },
        { AmericanSamoa.Name.ToLowerInvariant(), AmericanSamoa },
        { Andorra.Name.ToLowerInvariant(), Andorra },
        { Angola.Name.ToLowerInvariant(), Angola },
        { Anguilla.Name.ToLowerInvariant(), Anguilla },
        { Antarctica.Name.ToLowerInvariant(), Antarctica },
        { AntiguaAndBarbuda.Name.ToLowerInvariant(), AntiguaAndBarbuda },
        { Argentina.Name.ToLowerInvariant(), Argentina },
        { Armenia.Name.ToLowerInvariant(), Armenia },
        { Aruba.Name.ToLowerInvariant(), Aruba },
        { Australia.Name.ToLowerInvariant(), Australia },
        { Austria.Name.ToLowerInvariant(), Austria },
        { Azerbaijan.Name.ToLowerInvariant(), Azerbaijan },
        { Bahamas.Name.ToLowerInvariant(), Bahamas },
        { Bahrain.Name.ToLowerInvariant(), Bahrain },
        { Bangladesh.Name.ToLowerInvariant(), Bangladesh },
        { Barbados.Name.ToLowerInvariant(), Barbados },
        { Belarus.Name.ToLowerInvariant(), Belarus },
        { Belgium.Name.ToLowerInvariant(), Belgium },
        { Belize.Name.ToLowerInvariant(), Belize },
        { Benin.Name.ToLowerInvariant(), Benin },
        { Bermuda.Name.ToLowerInvariant(), Bermuda },
        { Bhutan.Name.ToLowerInvariant(), Bhutan },
        { Bolivia.Name.ToLowerInvariant(), Bolivia },
        { BonaireSintEustatiusandSaba.Name.ToLowerInvariant(), BonaireSintEustatiusandSaba },
        { BosniaAndHerzegovina.Name.ToLowerInvariant(), BosniaAndHerzegovina },
        { Botswana.Name.ToLowerInvariant(), Botswana },
        { BouvetIsland.Name.ToLowerInvariant(), BouvetIsland },
        { Brazil.Name.ToLowerInvariant(), Brazil },
        { BritishVirginIslands.Name.ToLowerInvariant(), BritishVirginIslands },
        { BritishIndianOceanTerritory.Name.ToLowerInvariant(), BritishIndianOceanTerritory },
        { BruneiDarussalam.Name.ToLowerInvariant(), BruneiDarussalam },
        { Bulgaria.Name.ToLowerInvariant(), Bulgaria },
        { BurkinaFaso.Name.ToLowerInvariant(), BurkinaFaso },
        { Burundi.Name.ToLowerInvariant(), Burundi },
        { Cambodia.Name.ToLowerInvariant(), Cambodia },
        { Cameroon.Name.ToLowerInvariant(), Cameroon },
        { Canada.Name.ToLowerInvariant(), Canada },
        { CapeVerde.Name.ToLowerInvariant(), CapeVerde },
        { CaymanIslands.Name.ToLowerInvariant(), CaymanIslands },
        { CentralAfricanRepublic.Name.ToLowerInvariant(), CentralAfricanRepublic },
        { Chad.Name.ToLowerInvariant(), Chad },
        { Chile.Name.ToLowerInvariant(), Chile },
        { China.Name.ToLowerInvariant(), China },
        { HongKong.Name.ToLowerInvariant(), HongKong },
        { Macao.Name.ToLowerInvariant(), Macao },
        { ChristmasIsland.Name.ToLowerInvariant(), ChristmasIsland },
        { CocosIslands.Name.ToLowerInvariant(), CocosIslands },
        { Colombia.Name.ToLowerInvariant(), Colombia },
        { Comoros.Name.ToLowerInvariant(), Comoros },
        { CongoBrazzaville.Name.ToLowerInvariant(), CongoBrazzaville },
        { CongoKinshasa.Name.ToLowerInvariant(), CongoKinshasa },
        { CookIslands.Name.ToLowerInvariant(), CookIslands },
        { CostaRica.Name.ToLowerInvariant(), CostaRica },
        { CoteDIvoire.Name.ToLowerInvariant(), CoteDIvoire },
        { Croatia.Name.ToLowerInvariant(), Croatia },
        { Cuba.Name.ToLowerInvariant(), Cuba },
        { Cyprus.Name.ToLowerInvariant(), Cyprus },
        { Curacao.Name.ToLowerInvariant(), Curacao },
        { CzechRepublic.Name.ToLowerInvariant(), CzechRepublic },
        { Denmark.Name.ToLowerInvariant(), Denmark },
        { Djibouti.Name.ToLowerInvariant(), Djibouti },
        { Dominica.Name.ToLowerInvariant(), Dominica },
        { DominicanRepublic.Name.ToLowerInvariant(), DominicanRepublic },
        { Ecuador.Name.ToLowerInvariant(), Ecuador },
        { Egypt.Name.ToLowerInvariant(), Egypt },
        { ElSalvador.Name.ToLowerInvariant(), ElSalvador },
        { EquatorialGuinea.Name.ToLowerInvariant(), EquatorialGuinea },
        { Eritrea.Name.ToLowerInvariant(), Eritrea },
        { Estonia.Name.ToLowerInvariant(), Estonia },
        { Ethiopia.Name.ToLowerInvariant(), Ethiopia },
        { FalklandIslands.Name.ToLowerInvariant(), FalklandIslands },
        { FaroeIslands.Name.ToLowerInvariant(), FaroeIslands },
        { Fiji.Name.ToLowerInvariant(), Fiji },
        { Finland.Name.ToLowerInvariant(), Finland },
        { France.Name.ToLowerInvariant(), France },
        { FrenchGuiana.Name.ToLowerInvariant(), FrenchGuiana },
        { FrenchPolynesia.Name.ToLowerInvariant(), FrenchPolynesia },
        { FrenchSouthernTerritories.Name.ToLowerInvariant(), FrenchSouthernTerritories },
        { Gabon.Name.ToLowerInvariant(), Gabon },
        { Gambia.Name.ToLowerInvariant(), Gambia },
        { Georgia.Name.ToLowerInvariant(), Georgia },
        { Germany.Name.ToLowerInvariant(), Germany },
        { Ghana.Name.ToLowerInvariant(), Ghana },
        { Gibraltar.Name.ToLowerInvariant(), Gibraltar },
        { Greece.Name.ToLowerInvariant(), Greece },
        { Greenland.Name.ToLowerInvariant(), Greenland },
        { Grenada.Name.ToLowerInvariant(), Grenada },
        { Guadeloupe.Name.ToLowerInvariant(), Guadeloupe },
        { Guam.Name.ToLowerInvariant(), Guam },
        { Guatemala.Name.ToLowerInvariant(), Guatemala },
        { Guernsey.Name.ToLowerInvariant(), Guernsey },
        { Guinea.Name.ToLowerInvariant(), Guinea },
        { GuineaBissau.Name.ToLowerInvariant(), GuineaBissau },
        { Guyana.Name.ToLowerInvariant(), Guyana },
        { Haiti.Name.ToLowerInvariant(), Haiti },
        { HeardAndMcdonaldIslands.Name.ToLowerInvariant(), HeardAndMcdonaldIslands },
        { HolySee.Name.ToLowerInvariant(), HolySee },
        { Honduras.Name.ToLowerInvariant(), Honduras },
        { Hungary.Name.ToLowerInvariant(), Hungary },
        { Iceland.Name.ToLowerInvariant(), Iceland },
        { India.Name.ToLowerInvariant(), India },
        { Indonesia.Name.ToLowerInvariant(), Indonesia },
        { Iran.Name.ToLowerInvariant(), Iran },
        { Iraq.Name.ToLowerInvariant(), Iraq },
        { Ireland.Name.ToLowerInvariant(), Ireland },
        { IsleOfMan.Name.ToLowerInvariant(), IsleOfMan },
        { Israel.Name.ToLowerInvariant(), Israel },
        { Italy.Name.ToLowerInvariant(), Italy },
        { Jamaica.Name.ToLowerInvariant(), Jamaica },
        { Japan.Name.ToLowerInvariant(), Japan },
        { Jersey.Name.ToLowerInvariant(), Jersey },
        { Jordan.Name.ToLowerInvariant(), Jordan },
        { Kazakhstan.Name.ToLowerInvariant(), Kazakhstan },
        { Kenya.Name.ToLowerInvariant(), Kenya },
        { Kiribati.Name.ToLowerInvariant(), Kiribati },
        { KoreaNorth.Name.ToLowerInvariant(), KoreaNorth },
        { KoreaSouth.Name.ToLowerInvariant(), KoreaSouth },
        { Kuwait.Name.ToLowerInvariant(), Kuwait },
        { Kyrgyzstan.Name.ToLowerInvariant(), Kyrgyzstan },
        { LaoPDR.Name.ToLowerInvariant(), LaoPDR },
        { Latvia.Name.ToLowerInvariant(), Latvia },
        { Lebanon.Name.ToLowerInvariant(), Lebanon },
        { Lesotho.Name.ToLowerInvariant(), Lesotho },
        { Liberia.Name.ToLowerInvariant(), Liberia },
        { Libya.Name.ToLowerInvariant(), Libya },
        { Liechtenstein.Name.ToLowerInvariant(), Liechtenstein },
        { Lithuania.Name.ToLowerInvariant(), Lithuania },
        { Luxembourg.Name.ToLowerInvariant(), Luxembourg },
        { MacedoniaRepublicOf.Name.ToLowerInvariant(), MacedoniaRepublicOf },
        { Madagascar.Name.ToLowerInvariant(), Madagascar },
        { Malawi.Name.ToLowerInvariant(), Malawi },
        { Malaysia.Name.ToLowerInvariant(), Malaysia },
        { Maldives.Name.ToLowerInvariant(), Maldives },
        { Mali.Name.ToLowerInvariant(), Mali },
        { Malta.Name.ToLowerInvariant(), Malta },
        { MarshallIslands.Name.ToLowerInvariant(), MarshallIslands },
        { Martinique.Name.ToLowerInvariant(), Martinique },
        { Mauritania.Name.ToLowerInvariant(), Mauritania },
        { Mauritius.Name.ToLowerInvariant(), Mauritius },
        { Mayotte.Name.ToLowerInvariant(), Mayotte },
        { Mexico.Name.ToLowerInvariant(), Mexico },
        { MicronesiaFederatedStatesOf.Name.ToLowerInvariant(), MicronesiaFederatedStatesOf },
        { Moldova.Name.ToLowerInvariant(), Moldova },
        { Monaco.Name.ToLowerInvariant(), Monaco },
        { Mongolia.Name.ToLowerInvariant(), Mongolia },
        { Montenegro.Name.ToLowerInvariant(), Montenegro },
        { Montserrat.Name.ToLowerInvariant(), Montserrat },
        { Morocco.Name.ToLowerInvariant(), Morocco },
        { Mozambique.Name.ToLowerInvariant(), Mozambique },
        { Myanmar.Name.ToLowerInvariant(), Myanmar },
        { Namibia.Name.ToLowerInvariant(), Namibia },
        { Nauru.Name.ToLowerInvariant(), Nauru },
        { Nepal.Name.ToLowerInvariant(), Nepal },
        { Netherlands.Name.ToLowerInvariant(), Netherlands },
        { NetherlandsAntilles.Name.ToLowerInvariant(), NetherlandsAntilles },
        { NewCaledonia.Name.ToLowerInvariant(), NewCaledonia },
        { NewZealand.Name.ToLowerInvariant(), NewZealand },
        { Nicaragua.Name.ToLowerInvariant(), Nicaragua },
        { Niger.Name.ToLowerInvariant(), Niger },
        { Nigeria.Name.ToLowerInvariant(), Nigeria },
        { Niue.Name.ToLowerInvariant(), Niue },
        { NorfolkIsland.Name.ToLowerInvariant(), NorfolkIsland },
        { NorthernMarianaIslands.Name.ToLowerInvariant(), NorthernMarianaIslands },
        { Norway.Name.ToLowerInvariant(), Norway },
        { Oman.Name.ToLowerInvariant(), Oman },
        { Pakistan.Name.ToLowerInvariant(), Pakistan },
        { Palau.Name.ToLowerInvariant(), Palau },
        { Palestine.Name.ToLowerInvariant(), Palestine },
        { Panama.Name.ToLowerInvariant(), Panama },
        { PapuaNewGuinea.Name.ToLowerInvariant(), PapuaNewGuinea },
        { Paraguay.Name.ToLowerInvariant(), Paraguay },
        { Peru.Name.ToLowerInvariant(), Peru },
        { Philippines.Name.ToLowerInvariant(), Philippines },
        { Pitcairn.Name.ToLowerInvariant(), Pitcairn },
        { Poland.Name.ToLowerInvariant(), Poland },
        { Portugal.Name.ToLowerInvariant(), Portugal },
        { PuertoRico.Name.ToLowerInvariant(), PuertoRico },
        { Qatar.Name.ToLowerInvariant(), Qatar },
        { Reunion.Name.ToLowerInvariant(), Reunion },
        { Romania.Name.ToLowerInvariant(), Romania },
        { RussianFederation.Name.ToLowerInvariant(), RussianFederation },
        { Rwanda.Name.ToLowerInvariant(), Rwanda },
        { SaintBarthelemy.Name.ToLowerInvariant(), SaintBarthelemy },
        { SaintHelena.Name.ToLowerInvariant(), SaintHelena },
        { SaintKittsAndNevis.Name.ToLowerInvariant(), SaintKittsAndNevis },
        { SaintLucia.Name.ToLowerInvariant(), SaintLucia },
        { SaintMartinFrenchPart.Name.ToLowerInvariant(), SaintMartinFrenchPart },
        { SaintPierreAndMiquelon.Name.ToLowerInvariant(), SaintPierreAndMiquelon },
        { SaintVincentAndGrenadines.Name.ToLowerInvariant(), SaintVincentAndGrenadines },
        { Samoa.Name.ToLowerInvariant(), Samoa },
        { SanMarino.Name.ToLowerInvariant(), SanMarino },
        { SaoTomeAndPrincipe.Name.ToLowerInvariant(), SaoTomeAndPrincipe },
        { SaudiArabia.Name.ToLowerInvariant(), SaudiArabia },
        { Senegal.Name.ToLowerInvariant(), Senegal },
        { Serbia.Name.ToLowerInvariant(), Serbia },
        { Seychelles.Name.ToLowerInvariant(), Seychelles },
        { SierraLeone.Name.ToLowerInvariant(), SierraLeone },
        { Singapore.Name.ToLowerInvariant(), Singapore },
        { SintMaarten.Name.ToLowerInvariant(), SintMaarten },
        { Slovakia.Name.ToLowerInvariant(), Slovakia },
        { Slovenia.Name.ToLowerInvariant(), Slovenia },
        { SolomonIslands.Name.ToLowerInvariant(), SolomonIslands },
        { Somalia.Name.ToLowerInvariant(), Somalia },
        { SouthAfrica.Name.ToLowerInvariant(), SouthAfrica },
        { SouthGeorgiaAndSouthSandwichIslands.Name.ToLowerInvariant(), SouthGeorgiaAndSouthSandwichIslands },
        { SouthSudan.Name.ToLowerInvariant(), SouthSudan },
        { Spain.Name.ToLowerInvariant(), Spain },
        { SriLanka.Name.ToLowerInvariant(), SriLanka },
        { Sudan.Name.ToLowerInvariant(), Sudan },
        { Suriname.Name.ToLowerInvariant(), Suriname },
        { SvalbardAndJanMayenIslands.Name.ToLowerInvariant(), SvalbardAndJanMayenIslands },
        { Swaziland_Eswatini.Name.ToLowerInvariant(), Swaziland_Eswatini },
        { Sweden.Name.ToLowerInvariant(), Sweden },
        { Switzerland.Name.ToLowerInvariant(), Switzerland },
        { SyrianArabRepublic.Name.ToLowerInvariant(), SyrianArabRepublic },
        { Taiwan.Name.ToLowerInvariant(), Taiwan },
        { Tajikistan.Name.ToLowerInvariant(), Tajikistan },
        { TanzaniaUnitedRepublicOf.Name.ToLowerInvariant(), TanzaniaUnitedRepublicOf },
        { Thailand.Name.ToLowerInvariant(), Thailand },
        { TimorLeste.Name.ToLowerInvariant(), TimorLeste },
        { Togo.Name.ToLowerInvariant(), Togo },
        { Tokelau.Name.ToLowerInvariant(), Tokelau },
        { Tonga.Name.ToLowerInvariant(), Tonga },
        { TrinidadAndTobago.Name.ToLowerInvariant(), TrinidadAndTobago },
        { Tunisia.Name.ToLowerInvariant(), Tunisia },
        { Turkey.Name.ToLowerInvariant(), Turkey },
        { Turkmenistan.Name.ToLowerInvariant(), Turkmenistan },
        { TurksAndCaicosIslands.Name.ToLowerInvariant(), TurksAndCaicosIslands },
        { Tuvalu.Name.ToLowerInvariant(), Tuvalu },
        { Uganda.Name.ToLowerInvariant(), Uganda },
        { Ukraine.Name.ToLowerInvariant(), Ukraine },
        { UnitedArabEmirates.Name.ToLowerInvariant(), UnitedArabEmirates },
        { UnitedKingdom.Name.ToLowerInvariant(), UnitedKingdom },
        { UnitedStatesOfAmerica.Name.ToLowerInvariant(), UnitedStatesOfAmerica },
        { USMinorOutlyingIslands.Name.ToLowerInvariant(), USMinorOutlyingIslands },
        { Uruguay.Name.ToLowerInvariant(), Uruguay },
        { Uzbekistan.Name.ToLowerInvariant(), Uzbekistan },
        { Vanuatu.Name.ToLowerInvariant(), Vanuatu },
        { VenezuelaBolivarianRepublic.Name.ToLowerInvariant(), VenezuelaBolivarianRepublic },
        { VietNam.Name.ToLowerInvariant(), VietNam },
        { VirginIslandsUS.Name.ToLowerInvariant(), VirginIslandsUS },
        { WallisAndFutunaIslands.Name.ToLowerInvariant(), WallisAndFutunaIslands },
        { WesternSahara.Name.ToLowerInvariant(), WesternSahara },
        { Yemen.Name.ToLowerInvariant(), Yemen },
        { Zambia.Name.ToLowerInvariant(), Zambia },
        { Zimbabwe.Name.ToLowerInvariant(), Zimbabwe }
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

}