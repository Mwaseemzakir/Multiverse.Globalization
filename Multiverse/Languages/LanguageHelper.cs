using System.Collections.Generic;

namespace Multiverse.Languages;

internal static class LanguageHelper
{
    public static readonly Language Afar = new Language("aa", "aar", "Afar");
    public static readonly Language Abkhazian = new Language("ab", "abk", "Abkhazian");
    public static readonly Language Afrikaans = new Language("af", "afr", "Afrikaans");
    public static readonly Language Akan = new Language("ak", "aka", "Akan");
    public static readonly Language Albanian = new Language("sq", "alb", "Albanian");
    public static readonly Language Amharic = new Language("am", "amh", "Amharic");
    public static readonly Language EnglishOld = new Language("", "ang", "English, Old (ca.450-1100)");
    public static readonly Language Angika = new Language("", "anp", "Angika");
    public static readonly Language ApacheLanguages = new Language("", "apa", "Apache languages");
    public static readonly Language Arabic = new Language("ar", "ara", "Arabic");
    public static readonly Language OfficialAramaic = new Language("", "arc", "Official Aramaic (700-300 BCE); Imperial Aramaic (700-300 BCE)");
    public static readonly Language Aragonese = new Language("an", "arg", "Aragonese");
    public static readonly Language Armenian = new Language("hy", "arm", "Armenian");
    public static readonly Language Hye = new Language("", "hye", "");
    public static readonly Language Mapudungun = new Language("", "arn", "Mapudungun; Mapuche");
    public static readonly Language Arapaho = new Language("", "arp", "Arapaho");
    public static readonly Language ArtificialLanguages = new Language("", "art", "Artificial languages");
    public static readonly Language Arawak = new Language("", "arw", "Arawak");
    public static readonly Language Assamese = new Language("as", "asm", "Assamese");
    public static readonly Language Asturian = new Language("", "ast", "Asturian; Bable; Leonese; Asturleonese");
    public static readonly Language AthapascanLanguages = new Language("", "ath", "Athapascan languages");
    public static readonly Language AustralianLanguages = new Language("", "aus", "Australian languages");
    public static readonly Language Avaric = new Language("av", "ava", "Avaric");
    public static readonly Language Avestan = new Language("ae", "ave", "Avestan");
    public static readonly Language Awadhi = new Language("", "awa", "Awadhi");
    public static readonly Language Aymara = new Language("ay", "aym", "Aymara");
    public static readonly Language Azerbaijani = new Language("az", "aze", "Azerbaijani");

    public static readonly Language BandaLanguages = new Language("", "bad", "Banda languages");
    public static readonly Language BamilekeLanguages = new Language("", "bai", "Bamileke languages");
    public static readonly Language Bashkir = new Language("ba", "bak", "Bashkir");
    public static readonly Language Baluchi = new Language("", "bal", "Baluchi");
    public static readonly Language Bambara = new Language("bm", "bam", "Bambara");
    public static readonly Language Balinese = new Language("", "ban", "Balinese");
    public static readonly Language Basque = new Language("eu", "baq", "Basque");
    public static readonly Language Eus = new Language("", "eus", "");
    public static readonly Language Basa = new Language("", "bas", "Basa");
    public static readonly Language BalticLanguages = new Language("", "bat", "Baltic languages");
    public static readonly Language Beja = new Language("", "bej", "Beja; Bedawiyet");
    public static readonly Language Belarusian = new Language("be", "bel", "Belarusian");
    public static readonly Language Bemba = new Language("", "bem", "Bemba");
    public static readonly Language Bengali = new Language("bn", "ben", "Bengali");
    public static readonly Language BerberLanguages = new Language("", "ber", "Berber languages");
    public static readonly Language Bhojpuri = new Language("", "bho", "Bhojpuri");
    public static readonly Language BihariLanguages = new Language("bh", "bih", "Bihari languages");
    public static readonly Language Bikol = new Language("", "bik", "Bikol");
    public static readonly Language Bini = new Language("", "bin", "Bini; Edo");
    public static readonly Language Bislama = new Language("bi", "bis", "Bislama");
    public static readonly Language Siksika = new Language("", "bla", "Siksika");
    public static readonly Language BantuLanguages = new Language("", "bnt", "Bantu languages");
    public static readonly Language Tibetan = new Language("bo", "tib", "Tibetan");
    public static readonly Language Bod = new Language("", "bod", "");
    public static readonly Language Bosnian = new Language("bs", "bos", "Bosnian");
    public static readonly Language Braj = new Language("", "bra", "Braj");
    public static readonly Language Breton = new Language("br", "bre", "Breton");
    public static readonly Language BatakLanguages = new Language("", "btk", "Batak languages");
    public static readonly Language Buriat = new Language("", "bua", "Buriat");
    public static readonly Language Buginese = new Language("", "bug", "Buginese");
    public static readonly Language Bulgarian = new Language("bg", "bul", "Bulgarian");
    public static readonly Language Burmese = new Language("my", "bur", "Burmese");
    public static readonly Language Blin = new Language("", "byn", "Blin; Bilin");

    public static readonly Language Caddo = new Language("", "cad", "Caddo");
    public static readonly Language CentralAmericanIndianLanguages = new Language("", "cai", "Central American Indian languages");
    public static readonly Language GalibiCarib = new Language("", "car", "Galibi Carib");
    public static readonly Language Catalan = new Language("ca", "cat", "Catalan; Valencian");
    public static readonly Language CaucasianLanguages = new Language("", "cau", "Caucasian languages");
    public static readonly Language Cebuano = new Language("", "ceb", "Cebuano");
    public static readonly Language CelticLanguages = new Language("", "cel", "Celtic languages");
    public static readonly Language Czech = new Language("cs", "cze", "Czech");
    public static readonly Language Ces = new Language("", "ces", "");
    public static readonly Language Chamorro = new Language("ch", "cha", "Chamorro");
    public static readonly Language Chibcha = new Language("", "chb", "Chibcha");
    public static readonly Language Chechen = new Language("ce", "che", "Chechen");
    public static readonly Language Chagatai = new Language("", "chg", "Chagatai");
    public static readonly Language Chinese = new Language("zh", "chi", "Chinese");
    public static readonly Language Zho = new Language("", "zho", "");
    public static readonly Language Chuukese = new Language("", "chk", "Chuukese");
    public static readonly Language Mari = new Language("", "chm", "Mari");
    public static readonly Language ChinookJargon = new Language("", "chn", "Chinook jargon");
    public static readonly Language Choctaw = new Language("", "cho", "Choctaw");
    public static readonly Language Chipewyan = new Language("", "chp", "Chipewyan; Dene Suline");
    public static readonly Language Cherokee = new Language("", "chr", "Cherokee");
    public static readonly Language ChurchSlavic = new Language("cu", "chu", "Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic");
    public static readonly Language Chuvash = new Language("cv", "chv", "Chuvash");
    public static readonly Language Cheyenne = new Language("", "chy", "Cheyenne");
    public static readonly Language ChamicLanguages = new Language("", "cmc", "Chamic languages");
    public static readonly Language Montenegrin = new Language("", "cnr", "Montenegrin");
    public static readonly Language Coptic = new Language("", "cop", "Coptic");
    public static readonly Language Cornish = new Language("kw", "cor", "Cornish");
    public static readonly Language Corsican = new Language("co", "cos", "Corsican");
    public static readonly Language CreolesAndPidginsEnglishBased = new Language("", "cpe", "Creoles and pidgins, English based");
    public static readonly Language CreolesAndPidginsFrenchBased = new Language("", "cpf", "Creoles and pidgins, French-based");
    public static readonly Language CreolesAndPidginsPortugueseBased = new Language("", "cpp", "Creoles and pidgins, Portuguese-based");
    public static readonly Language Cree = new Language("cr", "cre", "Cree");
    public static readonly Language CrimeanTatar = new Language("", "crh", "Crimean Tatar; Crimean Turkish");
    public static readonly Language CreolesAndPidgins = new Language("", "crp", "Creoles and pidgins");
    public static readonly Language Kashubian = new Language("", "csb", "Kashubian");
    public static readonly Language CushiticLanguages = new Language("", "cus", "Cushitic languages");
    public static readonly Language Welsh = new Language("cy", "wel", "Welsh");
    public static readonly Language Cym = new Language("", "cym", "");
    public static readonly Language Dakota = new Language("", "dak", "Dakota");
    public static readonly Language Danish = new Language("da", "dan", "Danish");
    public static readonly Language Dargwa = new Language("", "dar", "Dargwa");
    public static readonly Language LandDayakLanguages = new Language("", "day", "Land Dayak languages");
    public static readonly Language Delaware = new Language("", "del", "Delaware");
    public static readonly Language Slave = new Language("", "den", "Slave (Athapascan)");
    public static readonly Language German = new Language("de", "ger", "German");
    public static readonly Language Deu = new Language("", "deu", "");
    public static readonly Language Dogrib = new Language("", "dgr", "Dogrib");
    public static readonly Language Dinka = new Language("", "din", "Dinka");
    public static readonly Language Divehi = new Language("dv", "div", "Divehi; Dhivehi; Maldivian");
    public static readonly Language Dogri = new Language("", "doi", "Dogri");
    public static readonly Language DravidianLanguages = new Language("", "dra", "Dravidian languages");
    public static readonly Language LowerSorbian = new Language("", "dsb", "Lower Sorbian");
    public static readonly Language Duala = new Language("", "dua", "Duala");
    public static readonly Language DutchMiddle = new Language("", "dum", "Dutch, Middle (ca.1050-1350)");
    public static readonly Language Dutch = new Language("nl", "dut", "Dutch; Flemish");
    public static readonly Language Nld = new Language("", "nld", "");
    public static readonly Language Dyula = new Language("", "dyu", "Dyula");
    public static readonly Language Dzongkha = new Language("dz", "dzo", "Dzongkha");

    public static readonly Language Efik = new Language("", "efi", "Efik");
    public static readonly Language EgyptianAncient = new Language("", "egy", "Egyptian (Ancient)");
    public static readonly Language Ekajuk = new Language("", "eka", "Ekajuk");
    public static readonly Language GreekModern = new Language("el", "gre", "Greek, Modern (1453-)");
    public static readonly Language Ell = new Language("", "ell", "");
    public static readonly Language Elamite = new Language("", "elx", "Elamite");
    public static readonly Language English = new Language("en", "eng", "English");
    public static readonly Language EnglishMiddle = new Language("", "enm", "English, Middle (1100-1500)");
    public static readonly Language Esperanto = new Language("eo", "epo", "Esperanto");
    public static readonly Language Estonian = new Language("et", "est", "Estonian");
    public static readonly Language Ewe = new Language("ee", "ewe", "Ewe");
    public static readonly Language Ewondo = new Language("", "ewo", "Ewondo");

    public static readonly Language Fang = new Language("", "fan", "Fang");
    public static readonly Language Faroese = new Language("fo", "fao", "Faroese");
    public static readonly Language Persian = new Language("fa", "per", "Persian");
    public static readonly Language Fas = new Language("", "fas", "");
    public static readonly Language Fanti = new Language("", "fat", "Fanti");
    public static readonly Language Fijian = new Language("fj", "fij", "Fijian");
    public static readonly Language Filipino = new Language("", "fil", "Filipino; Pilipino");
    public static readonly Language Finnish = new Language("fi", "fin", "Finnish");
    public static readonly Language FinnoUgrianLanguages = new Language("", "fiu", "Finno-Ugrian languages");
    public static readonly Language Fon = new Language("", "fon", "Fon");
    public static readonly Language French = new Language("fr", "fre", "French");
    public static readonly Language Fra = new Language("", "fra", "");
    public static readonly Language FrenchMiddle = new Language("", "frm", "French, Middle (ca.1400-1600)");
    public static readonly Language FrenchOld = new Language("", "fro", "French, Old (842-ca.1400)");
    public static readonly Language NorthernFrisian = new Language("", "frr", "Northern Frisian");
    public static readonly Language EasternFrisian = new Language("", "frs", "Eastern Frisian");
    public static readonly Language WesternFrisian = new Language("fy", "fry", "Western Frisian");
    public static readonly Language Fulah = new Language("ff", "ful", "Fulah");
    public static readonly Language Friulian = new Language("", "fur", "Friulian");

    public static readonly Language Ga = new Language("", "gaa", "Ga");
    public static readonly Language Gayo = new Language("", "gay", "Gayo");
    public static readonly Language Gbaya = new Language("", "gba", "Gbaya");
    public static readonly Language GermanicLanguages = new Language("", "gem", "Germanic languages");
    public static readonly Language Georgian = new Language("ka", "geo", "Georgian");
    public static readonly Language Kat = new Language("", "kat", "");
    public static readonly Language Geez = new Language("", "gez", "Geez");
    public static readonly Language Gilbertese = new Language("", "gil", "Gilbertese");
    public static readonly Language Gaelic = new Language("gd", "gla", "Gaelic; Scottish Gaelic");
    public static readonly Language Irish = new Language("ga", "gle", "Irish");
    public static readonly Language Galician = new Language("gl", "glg", "Galician");
    public static readonly Language Manx = new Language("gv", "glv", "Manx");
    public static readonly Language GermanMiddleHigh = new Language("", "gmh", "German, Middle High (ca.1050-1500)");
    public static readonly Language GermanOldHigh = new Language("", "goh", "German, Old High (ca.750-1050)");
    public static readonly Language Gondi = new Language("", "gon", "Gondi");
    public static readonly Language Gorontalo = new Language("", "gor", "Gorontalo");
    public static readonly Language Gothic = new Language("", "got", "Gothic");
    public static readonly Language Grebo = new Language("", "grb", "Grebo");
    public static readonly Language GreekAncient = new Language("", "grc", "Greek, Ancient (to 1453)");
    public static readonly Language Guarani = new Language("gn", "grn", "Guarani");
    public static readonly Language SwissGerman = new Language("", "gsw", "Swiss German; Alemannic; Alsatian");
    public static readonly Language Gujarati = new Language("gu", "guj", "Gujarati");
    public static readonly Language Gwichin = new Language("", "gwi", "Gwich'in");

    public static readonly Language Haida = new Language("", "hai", "Haida");
    public static readonly Language Haitian = new Language("ht", "hat", "Haitian; Haitian Creole");
    public static readonly Language Hausa = new Language("ha", "hau", "Hausa");
    public static readonly Language Hawaiian = new Language("", "haw", "Hawaiian");
    public static readonly Language Hebrew = new Language("he", "heb", "Hebrew");
    public static readonly Language Herero = new Language("hz", "her", "Herero");
    public static readonly Language Hiligaynon = new Language("", "hil", "Hiligaynon");
    public static readonly Language HimachaliLanguages = new Language("", "him", "Himachali languages; Western Pahari languages");
    public static readonly Language Hindi = new Language("hi", "hin", "Hindi");
    public static readonly Language Hittite = new Language("", "hit", "Hittite");
    public static readonly Language Hmong = new Language("", "hmn", "Hmong; Mong");
    public static readonly Language HiriMotu = new Language("ho", "hmo", "Hiri Motu");
    public static readonly Language Croatian = new Language("hr", "hrv", "Croatian");
    public static readonly Language UpperSorbian = new Language("", "hsb", "Upper Sorbian");
    public static readonly Language Hungarian = new Language("hu", "hun", "Hungarian");
    public static readonly Language Hupa = new Language("", "hup", "Hupa");

    public static readonly Language Iban = new Language("", "iba", "Iban");
    public static readonly Language Igbo = new Language("ig", "ibo", "Igbo");
    public static readonly Language Icelandic = new Language("is", "ice", "Icelandic");
    public static readonly Language IcelandicAlt = new Language("", "isl", "");
    public static readonly Language Ido = new Language("io", "ido", "Ido");
    public static readonly Language SichuanYi = new Language("ii", "iii", "Sichuan Yi; Nuosu");
    public static readonly Language IjoLanguages = new Language("", "ijo", "Ijo languages");
    public static readonly Language Inuktitut = new Language("iu", "iku", "Inuktitut");
    public static readonly Language Interlingue = new Language("ie", "ile", "Interlingue; Occidental");
    public static readonly Language Iloko = new Language("", "ilo", "Iloko");
    public static readonly Language Interlingua = new Language("ia", "ina", "Interlingua (International Auxiliary Language Association)");
    public static readonly Language IndicLanguages = new Language("", "inc", "Indic languages");
    public static readonly Language Indonesian = new Language("id", "ind", "Indonesian");
    public static readonly Language IndoEuropeanLanguages = new Language("", "ine", "Indo-European languages");
    public static readonly Language Ingush = new Language("", "inh", "Ingush");
    public static readonly Language Inupiaq = new Language("ik", "ipk", "Inupiaq");
    public static readonly Language IranianLanguages = new Language("", "ira", "Iranian languages");
    public static readonly Language IroquoianLanguages = new Language("", "iro", "Iroquoian languages");
    public static readonly Language Italian = new Language("it", "ita", "Italian");

    public static readonly Language Javanese = new Language("jv", "jav", "Javanese");
    public static readonly Language Lojban = new Language("", "jbo", "Lojban");
    public static readonly Language Japanese = new Language("ja", "jpn", "Japanese");
    public static readonly Language JudeoPersian = new Language("", "jpr", "Judeo-Persian");
    public static readonly Language JudeoArabic = new Language("", "jrb", "Judeo-Arabic");

    public static readonly Language KaraKalpak = new Language("", "kaa", "Kara-Kalpak");
    public static readonly Language Kabyle = new Language("", "kab", "Kabyle");
    public static readonly Language Kachin = new Language("", "kac", "Kachin; Jingpho");
    public static readonly Language Kalaallisut = new Language("kl", "kal", "Kalaallisut; Greenlandic");
    public static readonly Language Kamba = new Language("", "kam", "Kamba");
    public static readonly Language Kannada = new Language("kn", "kan", "Kannada");
    public static readonly Language KarenLanguages = new Language("", "kar", "Karen languages");
    public static readonly Language Kashmiri = new Language("ks", "kas", "Kashmiri");
    public static readonly Language Kanuri = new Language("kr", "kau", "Kanuri");
    public static readonly Language Kawi = new Language("", "kaw", "Kawi");
    public static readonly Language Kazakh = new Language("kk", "kaz", "Kazakh");
    public static readonly Language Kabardian = new Language("", "kbd", "Kabardian");
    public static readonly Language Khasi = new Language("", "kha", "Khasi");
    public static readonly Language KhoisanLanguages = new Language("", "khi", "Khoisan languages");
    public static readonly Language CentralKhmer = new Language("km", "khm", "Central Khmer");
    public static readonly Language Khotanese = new Language("", "kho", "Khotanese; Sakan");
    public static readonly Language Kikuyu = new Language("ki", "kik", "Kikuyu; Gikuyu");
    public static readonly Language Kinyarwanda = new Language("rw", "kin", "Kinyarwanda");
    public static readonly Language Kirghiz = new Language("ky", "kir", "Kirghiz; Kyrgyz");
    public static readonly Language Kimbundu = new Language("", "kmb", "Kimbundu");
    public static readonly Language Konkani = new Language("", "kok", "Konkani");
    public static readonly Language Komi = new Language("kv", "kom", "Komi");
    public static readonly Language Kongo = new Language("kg", "kon", "Kongo");
    public static readonly Language Korean = new Language("ko", "kor", "Korean");
    public static readonly Language Kosraean = new Language("", "kos", "Kosraean");
    public static readonly Language Kpelle = new Language("", "kpe", "Kpelle");
    public static readonly Language KarachayBalkar = new Language("", "krc", "Karachay-Balkar");
    public static readonly Language Karelian = new Language("", "krl", "Karelian");
    public static readonly Language KruLanguages = new Language("", "kro", "Kru languages");
    public static readonly Language Kurukh = new Language("", "kru", "Kurukh");
    public static readonly Language Kuanyama = new Language("kj", "kua", "Kuanyama; Kwanyama");
    public static readonly Language Kumyk = new Language("", "kum", "Kumyk");
    public static readonly Language Kurdish = new Language("ku", "kur", "Kurdish");
    public static readonly Language Kutenai = new Language("", "kut", "Kutenai");

    public static readonly Language Ladino = new Language("", "lad", "Ladino");
    public static readonly Language Lahnda = new Language("", "lah", "Lahnda");
    public static readonly Language Lamba = new Language("", "lam", "Lamba");
    public static readonly Language Lao = new Language("lo", "lao", "Lao");
    public static readonly Language Latin = new Language("la", "lat", "Latin");
    public static readonly Language Latvian = new Language("lv", "lav", "Latvian");
    public static readonly Language Lezghian = new Language("", "lez", "Lezghian");
    public static readonly Language Limburgan = new Language("li", "lim", "Limburgan; Limburger; Limburgish");
    public static readonly Language Lingala = new Language("ln", "lin", "Lingala");
    public static readonly Language Lithuanian = new Language("lt", "lit", "Lithuanian");
    public static readonly Language Mongo = new Language("", "lol", "Mongo");
    public static readonly Language Lozi = new Language("", "loz", "Lozi");
    public static readonly Language Luxembourgish = new Language("lb", "ltz", "Luxembourgish; Letzeburgesch");
    public static readonly Language LubaLulua = new Language("", "lua", "Luba-Lulua");
    public static readonly Language LubaKatanga = new Language("lu", "lub", "Luba-Katanga");
    public static readonly Language Ganda = new Language("lg", "lug", "Ganda");
    public static readonly Language Luiseno = new Language("", "lui", "Luiseno");
    public static readonly Language Lunda = new Language("", "lun", "Lunda");
    public static readonly Language Luo = new Language("", "luo", "Luo (Kenya and Tanzania)");
    public static readonly Language Lushai = new Language("", "lus", "Lushai");

    public static readonly Language Macedonian = new Language("mk", "mac", "Macedonian");
    public static readonly Language Madurese = new Language("", "mad", "Madurese");
    public static readonly Language Magahi = new Language("", "mag", "Magahi");
    public static readonly Language Marshallese = new Language("mh", "mah", "Marshallese");
    public static readonly Language Maithili = new Language("", "mai", "Maithili");
    public static readonly Language Makasar = new Language("", "mak", "Makasar");
    public static readonly Language Malayalam = new Language("ml", "mal", "Malayalam");
    public static readonly Language Mandingo = new Language("", "man", "Mandingo");
    public static readonly Language AustronesianLanguages = new Language("", "map", "Austronesian languages");
    public static readonly Language Marathi = new Language("mr", "mar", "Marathi");
    public static readonly Language Masai = new Language("", "mas", "Masai");
    public static readonly Language Moksha = new Language("", "mdf", "Moksha");
    public static readonly Language Mandar = new Language("", "mdr", "Mandar");
    public static readonly Language Mende = new Language("", "men", "Mende");
    public static readonly Language IrishMiddle = new Language("", "mga", "Irish, Middle (900-1200)");
    public static readonly Language MiKmaq = new Language("", "mic", "Mi'kmaq; Micmac");
    public static readonly Language Minangkabau = new Language("", "min", "Minangkabau");
    public static readonly Language UncodedLanguages = new Language("", "mis", "Uncoded languages");
    public static readonly Language MonKhmerLanguages = new Language("", "mkh", "Mon-Khmer languages");
    public static readonly Language Malagasy = new Language("mg", "mlg", "Malagasy");
    public static readonly Language Maltese = new Language("mt", "mlt", "Maltese");
    public static readonly Language Manchu = new Language("", "mnc", "Manchu");
    public static readonly Language Manipuri = new Language("", "mni", "Manipuri");
    public static readonly Language ManoboLanguages = new Language("", "mno", "Manobo languages");
    public static readonly Language Mohawk = new Language("", "moh", "Mohawk");
    public static readonly Language Mongolian = new Language("mn", "mon", "Mongolian");
    public static readonly Language Mossi = new Language("", "mos", "Mossi");
    public static readonly Language Maori = new Language("", "mri", "");
    public static readonly Language Malay = new Language("", "msa", "");
    public static readonly Language MultipleLanguages = new Language("", "mul", "Multiple languages");
    public static readonly Language MundaLanguages = new Language("", "mun", "Munda languages");
    public static readonly Language Creek = new Language("", "mus", "Creek");
    public static readonly Language Mirandese = new Language("", "mwl", "Mirandese");
    public static readonly Language Marwari = new Language("", "mwr", "Marwari");
    public static readonly Language MayanLanguages = new Language("", "myn", "Mayan languages");
    public static readonly Language Erzya = new Language("", "myv", "Erzya");

    public static readonly Language NahuatlLanguages = new Language("", "nah", "Nahuatl languages");
    public static readonly Language NorthAmericanIndianLanguages = new Language("", "nai", "North American Indian languages");
    public static readonly Language Neapolitan = new Language("", "nap", "Neapolitan");
    public static readonly Language Nauru = new Language("na", "nau", "Nauru");
    public static readonly Language Navajo = new Language("nv", "nav", "Navajo; Navaho");
    public static readonly Language NdebeleSouth = new Language("nr", "nbl", "Ndebele, South; South Ndebele");
    public static readonly Language NdebeleNorth = new Language("nd", "nde", "Ndebele, North; North Ndebele");
    public static readonly Language Ndonga = new Language("ng", "ndo", "Ndonga");
    public static readonly Language LowGerman = new Language("", "nds", "Low German; Low Saxon; German, Low; Saxon, Low");
    public static readonly Language Nepali = new Language("ne", "nep", "Nepali");
    public static readonly Language NepalBhasa = new Language("", "new", "Nepal Bhasa; Newari");
    public static readonly Language Nias = new Language("", "nia", "Nias");
    public static readonly Language NigerKordofanianLanguages = new Language("", "nic", "Niger-Kordofanian languages");
    public static readonly Language Niuean = new Language("", "niu", "Niuean");
    public static readonly Language NorwegianNynorsk = new Language("nn", "nno", "Norwegian Nynorsk; Nynorsk, Norwegian");
    public static readonly Language NorwegianBokmal = new Language("nb", "nob", "Bokmål, Norwegian; Norwegian Bokmål");
    public static readonly Language Nogai = new Language("", "nog", "Nogai");
    public static readonly Language NorseOld = new Language("", "non", "Norse, Old");
    public static readonly Language Norwegian = new Language("no", "nor", "Norwegian");
    public static readonly Language NKo = new Language("", "nqo", "N'Ko");
    public static readonly Language NorthernSotho = new Language("", "nso", "Pedi; Sepedi; Northern Sotho");
    public static readonly Language NubianLanguages = new Language("", "nub", "Nubian languages");
    public static readonly Language ClassicalNewari = new Language("", "nwc", "Classical Newari; Old Newari; Classical Nepal Bhasa");
    public static readonly Language Chichewa = new Language("ny", "nya", "Chichewa; Chewa; Nyanja");
    public static readonly Language Nyamwezi = new Language("", "nym", "Nyamwezi");
    public static readonly Language Nyankole = new Language("", "nyn", "Nyankole");
    public static readonly Language Nyoro = new Language("", "nyo", "Nyoro");
    public static readonly Language Nzima = new Language("", "nzi", "Nzima");

    public static readonly Language Occitan = new Language("oc", "oci", "Occitan (post 1500)");
    public static readonly Language Ojibwa = new Language("oj", "oji", "Ojibwa");
    public static readonly Language Oriya = new Language("or", "ori", "Oriya");
    public static readonly Language Oromo = new Language("om", "orm", "Oromo");
    public static readonly Language Osage = new Language("", "osa", "Osage");
    public static readonly Language Ossetian = new Language("os", "oss", "Ossetian; Ossetic");
    public static readonly Language TurkishOttoman = new Language("", "ota", "Turkish, Ottoman (1500-1928)");
    public static readonly Language OtomianLanguages = new Language("", "oto", "Otomian languages");

    public static readonly Language PapuanLanguages = new Language("", "paa", "Papuan languages");
    public static readonly Language Pangasinan = new Language("", "pag", "Pangasinan");
    public static readonly Language Pahlavi = new Language("", "pal", "Pahlavi");
    public static readonly Language Pampanga = new Language("", "pam", "Pampanga; Kapampangan");
    public static readonly Language Panjabi = new Language("pa", "pan", "Panjabi; Punjabi");
    public static readonly Language Papiamento = new Language("", "pap", "Papiamento");
    public static readonly Language Palauan = new Language("", "pau", "Palauan");
    public static readonly Language PersianOld = new Language("", "peo", "Persian, Old (ca.600-400 B.C.)");
    public static readonly Language PhilippineLanguages = new Language("", "phi", "Philippine languages");
    public static readonly Language Phoenician = new Language("", "phn", "Phoenician");
    public static readonly Language Pali = new Language("pi", "pli", "Pali");
    public static readonly Language Polish = new Language("pl", "pol", "Polish");
    public static readonly Language Pohnpeian = new Language("", "pon", "Pohnpeian");
    public static readonly Language Portuguese = new Language("pt", "por", "Portuguese");
    public static readonly Language PrakritLanguages = new Language("", "pra", "Prakrit languages");
    public static readonly Language ProvencalOld = new Language("", "pro", "Provençal, Old (to 1500);Occitan, Old (to 1500)");
    public static readonly Language Pushto = new Language("ps", "pus", "Pushto; Pashto");

    public static readonly Language ReservedForLocalUse = new Language("", "qaa-qtz", "Reserved for local use");
    public static readonly Language Quechua = new Language("qu", "que", "Quechua");
    public static readonly Language Rajasthani = new Language("", "raj", "Rajasthani");
    public static readonly Language Rapanui = new Language("", "rap", "Rapanui");
    public static readonly Language Rarotongan = new Language("", "rar", "Rarotongan; Cook Islands Maori");
    public static readonly Language RomanceLanguages = new Language("", "roa", "Romance languages");
    public static readonly Language Romansh = new Language("rm", "roh", "Romansh");
    public static readonly Language Romany = new Language("", "rom", "Romany");
    public static readonly Language Romanian = new Language("ro", "rum", "Romanian; Moldavian; Moldovan");
    public static readonly Language Rundi = new Language("rn", "run", "Rundi");
    public static readonly Language Aromanian = new Language("", "rup", "Aromanian; Arumanian; Macedo-Romanian");
    public static readonly Language Russian = new Language("ru", "rus", "Russian");

    public static readonly Language Sandawe = new Language("", "sad", "Sandawe");
    public static readonly Language Sango = new Language("sg", "sag", "Sango");
    public static readonly Language Yakut = new Language("", "sah", "Yakut");
    public static readonly Language SouthAmericanIndianLanguages = new Language("", "sai", "South American Indian languages");
    public static readonly Language SalishanLanguages = new Language("", "sal", "Salishan languages");
    public static readonly Language SamaritanAramaic = new Language("", "sam", "Samaritan Aramaic");
    public static readonly Language Sanskrit = new Language("sa", "san", "Sanskrit");
    public static readonly Language Sasak = new Language("", "sas", "Sasak");
    public static readonly Language Santali = new Language("", "sat", "Santali");
    public static readonly Language Sicilian = new Language("", "scn", "Sicilian");
    public static readonly Language Scots = new Language("", "sco", "Scots");
    public static readonly Language Selkup = new Language("", "sel", "Selkup");
    public static readonly Language SemiticLanguages = new Language("", "sem", "Semitic languages");
    public static readonly Language IrishOld = new Language("", "sga", "Irish, Old (to 900)");
    public static readonly Language SignLanguages = new Language("", "sgn", "Sign Languages");
    public static readonly Language Shan = new Language("", "shn", "Shan");
    public static readonly Language Sidamo = new Language("", "sid", "Sidamo");
    public static readonly Language Sinhala = new Language("si", "sin", "Sinhala; Sinhalese");
    public static readonly Language SiouanLanguages = new Language("", "sio", "Siouan languages");
    public static readonly Language SinoTibetanLanguages = new Language("", "sit", "Sino-Tibetan languages");
    public static readonly Language SlavicLanguages = new Language("", "sla", "Slavic languages");
    public static readonly Language Slovak = new Language("sk", "slo", "Slovak");
    public static readonly Language Slovenian = new Language("sl", "slv", "Slovenian");
    public static readonly Language SouthernSami = new Language("", "sma", "Southern Sami");
    public static readonly Language NorthernSami = new Language("se", "sme", "Northern Sami");
    public static readonly Language SamiLanguages = new Language("", "smi", "Sami languages");
    public static readonly Language LuleSami = new Language("", "smj", "Lule Sami");
    public static readonly Language InariSami = new Language("", "smn", "Inari Sami");
    public static readonly Language Samoan = new Language("sm", "smo", "Samoan");
    public static readonly Language SkoltSami = new Language("", "sms", "Skolt Sami");
    public static readonly Language Shona = new Language("sn", "sna", "Shona");
    public static readonly Language Sindhi = new Language("sd", "snd", "Sindhi");
    public static readonly Language Soninke = new Language("", "snk", "Soninke");
    public static readonly Language Sogdian = new Language("", "sog", "Sogdian");
    public static readonly Language Somali = new Language("so", "som", "Somali");
    public static readonly Language SonghaiLanguages = new Language("", "son", "Songhai languages");
    public static readonly Language SothoSouthern = new Language("st", "sot", "Sotho, Southern");
    public static readonly Language Spanish = new Language("es", "spa", "Spanish; Castilian");
    public static readonly Language Sardinian = new Language("sc", "srd", "Sardinian");
    public static readonly Language SrananTongo = new Language("", "srn", "Sranan Tongo");
    public static readonly Language Serbian = new Language("sr", "srp", "Serbian");
    public static readonly Language Serer = new Language("", "srr", "Serer");
    public static readonly Language NiloSaharanLanguages = new Language("", "ssa", "Nilo-Saharan languages");
    public static readonly Language Swati = new Language("ss", "ssw", "Swati");
    public static readonly Language Sukuma = new Language("", "suk", "Sukuma");
    public static readonly Language Sundanese = new Language("su", "sun", "Sundanese");
    public static readonly Language Susu = new Language("", "sus", "Susu");
    public static readonly Language Sumerian = new Language("", "sux", "Sumerian");
    public static readonly Language Swahili = new Language("sw", "swa", "Swahili");
    public static readonly Language Swedish = new Language("sv", "swe", "Swedish");
    public static readonly Language ClassicalSyriac = new Language("", "syc", "Classical Syriac");
    public static readonly Language Syriac = new Language("", "syr", "Syriac");

    public static readonly Language Tahitian = new Language("ty", "tah", "Tahitian");
    public static readonly Language TaiLanguages = new Language("", "tai", "Tai languages");
    public static readonly Language Tamil = new Language("ta", "tam", "Tamil");
    public static readonly Language Tatar = new Language("tt", "tat", "Tatar");
    public static readonly Language Telugu = new Language("te", "tel", "Telugu");
    public static readonly Language Timne = new Language("", "tem", "Timne");
    public static readonly Language Tereno = new Language("", "ter", "Tereno");
    public static readonly Language Tetum = new Language("", "tet", "Tetum");
    public static readonly Language Tajik = new Language("tg", "tgk", "Tajik");
    public static readonly Language Tagalog = new Language("tl", "tgl", "Tagalog");
    public static readonly Language Thai = new Language("th", "tha", "Thai");
    public static readonly Language Tigre = new Language("", "tig", "Tigre");
    public static readonly Language Tigrinya = new Language("ti", "tir", "Tigrinya");
    public static readonly Language Tiv = new Language("", "tiv", "Tiv");
    public static readonly Language Tokelau = new Language("", "tkl", "Tokelau");
    public static readonly Language Klingon = new Language("", "tlh", "Klingon; tlhIngan-Hol");
    public static readonly Language Tlingit = new Language("", "tli", "Tlingit");
    public static readonly Language Tamashek = new Language("", "tmh", "Tamashek");
    public static readonly Language TongaNyasa = new Language("", "tog", "Tonga (Nyasa)");
    public static readonly Language TongaIslands = new Language("to", "ton", "Tonga (Tonga Islands)");
    public static readonly Language TokPisin = new Language("", "tpi", "Tok Pisin");
    public static readonly Language Tsimshian = new Language("", "tsi", "Tsimshian");
    public static readonly Language Tswana = new Language("tn", "tsn", "Tswana");
    public static readonly Language Tsonga = new Language("ts", "tso", "Tsonga");
    public static readonly Language Turkmen = new Language("tk", "tuk", "Turkmen");
    public static readonly Language Tumbuka = new Language("", "tum", "Tumbuka");
    public static readonly Language TupiLanguages = new Language("", "tup", "Tupi languages");
    public static readonly Language Turkish = new Language("tr", "tur", "Turkish");
    public static readonly Language AltaicLanguages = new Language("", "tut", "Altaic languages");
    public static readonly Language Tuvalu = new Language("", "tvl", "Tuvalu");
    public static readonly Language Twi = new Language("tw", "twi", "Twi");
    public static readonly Language Tuvinian = new Language("", "tyv", "Tuvinian");

    public static readonly Language Udmurt = new Language("", "udm", "Udmurt");
    public static readonly Language Ugaritic = new Language("", "uga", "Ugaritic");
    public static readonly Language Uighur = new Language("ug", "uig", "Uighur; Uyghur");
    public static readonly Language Ukrainian = new Language("uk", "ukr", "Ukrainian");
    public static readonly Language Umbundu = new Language("", "umb", "Umbundu");
    public static readonly Language Undetermined = new Language("", "und", "Undetermined");
    public static readonly Language Urdu = new Language("ur", "urd", "Urdu");
    public static readonly Language Uzbek = new Language("uz", "uzb", "Uzbek");

    public static readonly Language Vai = new Language("", "vai", "Vai");
    public static readonly Language Venda = new Language("ve", "ven", "Venda");
    public static readonly Language Vietnamese = new Language("vi", "vie", "Vietnamese");
    public static readonly Language Volapuk = new Language("vo", "vol", "Volapük");
    public static readonly Language Votic = new Language("", "vot", "Votic");
    public static readonly Language WakashanLanguages = new Language("", "wak", "Wakashan languages");
    public static readonly Language Wolaitta = new Language("", "wal", "Wolaitta; Wolaytta");
    public static readonly Language Waray = new Language("", "war", "Waray");
    public static readonly Language Washo = new Language("", "was", "Washo");
    public static readonly Language SorbianLanguages = new Language("", "wen", "Sorbian languages");
    public static readonly Language Walloon = new Language("wa", "wln", "Walloon");
    public static readonly Language Wolof = new Language("wo", "wol", "Wolof");

    public static readonly Language Kalmyk = new Language("", "xal", "Kalmyk; Oirat");
    public static readonly Language Xhosa = new Language("xh", "xho", "Xhosa");
    public static readonly Language Yao = new Language("", "yao", "Yao");
    public static readonly Language Yapese = new Language("", "yap", "Yapese");
    public static readonly Language Yiddish = new Language("yi", "yid", "Yiddish");
    public static readonly Language Yoruba = new Language("yo", "yor", "Yoruba");
    public static readonly Language YupikLanguages = new Language("", "ypk", "Yupik languages");
    public static readonly Language Zapotec = new Language("", "zap", "Zapotec");
    public static readonly Language Blissymbols = new Language("", "zbl", "Blissymbols; Blissymbolics; Bliss");
    public static readonly Language Zenaga = new Language("", "zen", "Zenaga");
    public static readonly Language StandardMoroccanTamazight = new Language("", "zgh", "Standard Moroccan Tamazight");
    public static readonly Language Zhuang = new Language("za", "zha", "Zhuang; Chuang");
    public static readonly Language ZandeLanguages = new Language("", "znd", "Zande languages");
    public static readonly Language Zulu = new Language("zu", "zul", "Zulu");
    public static readonly Language Zuni = new Language("", "zun", "Zuni");
    public static readonly Language NoLinguisticContent = new Language("", "zxx", "No linguistic content; Not applicable");
    public static readonly Language Zaza = new Language("", "zza", "Zaza; Dimili; Dimli; Kirdki; Kirmanjki; Zazaki");

    public static readonly Language None = new Language(string.Empty, string.Empty, string.Empty);

    public static List<Language> GetAll()
    {
        return new List<Language>
        {
            Afar,
            Abkhazian,
            Afrikaans,
            Akan,
            Albanian,
            Amharic,
            EnglishOld,
            Angika,
            ApacheLanguages,
            Arabic,
            OfficialAramaic,
            Aragonese,
            Armenian,
            Hye,
            Mapudungun,
            Arapaho,
            ArtificialLanguages,
            Arawak,
            Assamese,
            Asturian,
            AthapascanLanguages,
            AustralianLanguages,
            Avaric,
            Avestan,
            Awadhi,
            Aymara,
            Azerbaijani,
            BandaLanguages,
            BamilekeLanguages,
            Bashkir,
            Baluchi,
            Bambara,
            Balinese,
            Basque,
            Eus,
            Basa,
            BalticLanguages,
            Beja,
            Belarusian,
            Bemba,
            Bengali,
            BerberLanguages,
            Bhojpuri,
            BihariLanguages,
            Bikol,
            Bini,
            Bislama,
            Siksika,
            BantuLanguages,
            Tibetan,
            Bod,
            Bosnian,
            Braj,
            Breton,
            BatakLanguages,
            Buriat,
            Buginese,
            Bulgarian,
            Burmese,
            Blin,
            Caddo,
            CentralAmericanIndianLanguages,
            GalibiCarib,
            Catalan,
            CaucasianLanguages,
            Cebuano,
            CelticLanguages,
            Czech,
            Ces,
            Chamorro,
            Chibcha,
            Chechen,
            Chagatai,
            Chinese,
            Zho,
            Chuukese,
            Mari,
            ChinookJargon,
            Choctaw,
            Chipewyan,
            Cherokee,
            ChurchSlavic,
            Chuvash,
            Cheyenne,
            ChamicLanguages,
            Montenegrin,
            Coptic,
            Cornish,
            Corsican,
            CreolesAndPidginsEnglishBased,
            CreolesAndPidginsFrenchBased,
            CreolesAndPidginsPortugueseBased,
            Cree,
            CrimeanTatar,
            CreolesAndPidgins,
            Kashubian,
            CushiticLanguages,
            Welsh,
            Cym,
            Dakota,
            Danish,
            Dargwa,
            LandDayakLanguages,
            Delaware,
            Slave,
            German,
            Deu,
            Dogrib,
            Dinka,
            Divehi,
            Dogri,
            DravidianLanguages,
            LowerSorbian,
            Duala,
            DutchMiddle,
            Dutch,
            Nld,
            Dyula,
            Dzongkha,
            Efik,
            EgyptianAncient,
            Ekajuk,
            GreekModern,
            Ell,
            Elamite,
            English,
            EnglishMiddle,
            Esperanto,
            Estonian,
            Ewe,
            Ewondo,
            Fang,
            Faroese,
            Persian,
            Fas,
            Fanti,
            Fijian,
            Filipino,
            Finnish,
            FinnoUgrianLanguages,
            Fon,
            French,
            Fra,
            FrenchMiddle,
            FrenchOld,
            NorthernFrisian,
            EasternFrisian,
            WesternFrisian,
            Fulah,
            Friulian,
            Ga,
            Gayo,
            Gbaya,
            GermanicLanguages,
            Georgian,
            Kat,
            Geez,
            Gilbertese,
            Gaelic,
            Irish,
            Galician,
            Manx,
            GermanMiddleHigh,
            GermanOldHigh,
            Gondi,
            Gorontalo,
            Gothic,
            Grebo,
            GreekAncient,
            Guarani,
            SwissGerman,
            Gujarati,
            Gwichin,
            Haida,
            Haitian,
            Hausa,
            Hawaiian,
            Hebrew,
            Herero,
            Hiligaynon,
            HimachaliLanguages,
            Hindi,
            Hittite,
            Hmong,
            HiriMotu,
            Croatian,
            UpperSorbian,
            Hungarian,
            Hupa,
            Iban,
            Igbo,
            Icelandic,
            IcelandicAlt,
            Ido,
            SichuanYi,
            IjoLanguages,
            Inuktitut,
            Interlingue,
            Iloko,
            Interlingua,
            IndicLanguages,
            Indonesian,
            IndoEuropeanLanguages,
            Ingush,
            Inupiaq,
            IranianLanguages,
            IroquoianLanguages,
            Italian,
            Javanese,
            Lojban,
            Japanese,
            JudeoPersian,
            JudeoArabic,
            KaraKalpak,
            Kabyle,
            Kachin,
            Kalaallisut,
            Kamba,
            Kannada,
            KarenLanguages,
            Kashmiri,
            Kanuri,
            Kawi,
            Kazakh,
            Kabardian,
            Khasi,
            KhoisanLanguages,
            CentralKhmer,
            Khotanese,
            Kikuyu,
            Kinyarwanda,
            Kirghiz,
            Kimbundu,
            Konkani,
            Komi,
            Kongo,
            Korean,
            Kosraean,
            Kpelle,
            KarachayBalkar,
            Karelian,
            KruLanguages,
            Kurukh,
            Kuanyama,
            Kumyk,
            Kurdish,
            Kutenai,
            Ladino,
            Lahnda,
            Lamba,
            Lao,
            Latin,
            Latvian,
            Lezghian,
            Limburgan,
            Lingala,
            Lithuanian,
            Mongo,
            Lozi,
            Luxembourgish,
            LubaLulua,
            LubaKatanga,
            Ganda,
            Luiseno,
            Lunda,
            Luo,
            Lushai,
            Macedonian,
            Madurese,
            Magahi,
            Marshallese,
            Maithili,
            Makasar,
            Malayalam,
            Mandingo,
            AustronesianLanguages,
            Marathi,
            Masai,
            Moksha,
            Mandar,
            Mende,
            IrishMiddle,
            MiKmaq,
            Minangkabau,
            UncodedLanguages,
            MonKhmerLanguages,
            Malagasy,
            Maltese,
            Manchu,
            Manipuri,
            ManoboLanguages,
            Mohawk,
            Mongolian,
            Mossi,
            Maori,
            Malay,
            MultipleLanguages,
            MundaLanguages,
            Creek,
            Mirandese,
            Marwari,
            MayanLanguages,
            Erzya,
            NahuatlLanguages,
            NorthAmericanIndianLanguages,
            Neapolitan,
            Nauru,
            Navajo,
            NdebeleSouth,
            NdebeleNorth,
            Ndonga,
            LowGerman,
            Nepali,
            NepalBhasa,
            Nias,
            NigerKordofanianLanguages,
            Niuean,
            NorwegianNynorsk,
            NorwegianBokmal,
            Nogai,
            NorseOld,
            Norwegian,
            NKo,
            NorthernSotho,
            NubianLanguages,
            ClassicalNewari,
            Chichewa,
            Nyamwezi,
            Nyankole,
            Nyoro,
            Nzima,
            Occitan,
            Ojibwa,
            Oriya,
            Oromo,
            Osage,
            Ossetian,
            TurkishOttoman,
            OtomianLanguages,
            PapuanLanguages,
            Pangasinan,
            Pahlavi,
            Pampanga,
            Panjabi,
            Papiamento,
            Palauan,
            PersianOld,
            PhilippineLanguages,
            Phoenician,
            Pali,
            Polish,
            Pohnpeian,
            Portuguese,
            PrakritLanguages,
            ProvencalOld,
            Pushto,
            ReservedForLocalUse,
            Quechua,
            Rajasthani,
            Rapanui,
            Rarotongan,
            RomanceLanguages,
            Romansh,
            Romany,
            Romanian,
            Rundi,
            Aromanian,
            Russian,
            Sandawe,
            Sango,
            Yakut,
            SouthAmericanIndianLanguages,
            SalishanLanguages,
            SamaritanAramaic,
            Sanskrit,
            Sasak,
            Santali,
            Sicilian,
            Scots,
            Selkup,
            SemiticLanguages,
            IrishOld,
            SignLanguages,
            Shan,
            Sidamo,
            Sinhala,
            SiouanLanguages,
            SinoTibetanLanguages,
            SlavicLanguages,
            Slovak,
            Slovenian,
            SouthernSami,
            NorthernSami,
            SamiLanguages,
            LuleSami,
            InariSami,
            Samoan,
            SkoltSami,
            Shona,
            Sindhi,
            Soninke,
            Sogdian,
            Somali,
            SonghaiLanguages,
            SothoSouthern,
            Spanish,
            Sardinian,
            SrananTongo,
            Serbian,
            Serer,
            NiloSaharanLanguages,
            Swati,
            Sukuma,
            Sundanese,
            Susu,
            Sumerian,
            Swahili,
            Swedish,
            ClassicalSyriac,
            Syriac,
            Tahitian,
            TaiLanguages,
            Tamil,
            Tatar,
            Telugu,
            Timne,
            Tereno,
            Tetum,
            Tajik,
            Tagalog,
            Thai,
            Tigre,
            Tigrinya,
            Tiv,
            Tokelau,
            Klingon,
            Tlingit,
            Tamashek,
            TongaNyasa,
            TongaIslands,
            TokPisin,
            Tsimshian,
            Tswana,
            Tsonga,
            Turkmen,
            Tumbuka,
            TupiLanguages,
            Turkish,
            AltaicLanguages,
            Tuvalu,
            Twi,
            Tuvinian,
            Udmurt,
            Ugaritic,
            Uighur,
            Ukrainian,
            Umbundu,
            Undetermined,
            Urdu,
            Uzbek,
            Vai,
            Venda,
            Vietnamese,
            Volapuk,
            Votic,
            WakashanLanguages,
            Wolaitta,
            Waray,
            Washo,
            SorbianLanguages,
            Walloon,
            Wolof,
            Kalmyk,
            Xhosa,
            Yao,
            Yapese,
            Yiddish,
            Yoruba,
            YupikLanguages,
            Zapotec,
            Blissymbols,
            Zenaga,
            StandardMoroccanTamazight,
            Zhuang,
            ZandeLanguages,
            Zulu,
            Zuni,
            NoLinguisticContent,
            Zaza,
        };
    }

    public static readonly IReadOnlyDictionary<string, Language> Alpha3CodeMap = new Dictionary<string, Language>
    {
        { Afar.Alpha3Code, Afar },
        { Abkhazian.Alpha3Code, Abkhazian },
        { Afrikaans.Alpha3Code, Afrikaans },
        { Akan.Alpha3Code, Akan },
        { Albanian.Alpha3Code, Albanian },
        { Amharic.Alpha3Code, Amharic },
        { Arabic.Alpha3Code, Arabic },
        { Aragonese.Alpha3Code, Aragonese },
        { Armenian.Alpha3Code, Armenian },
        { Azerbaijani.Alpha3Code, Azerbaijani },
        { Bashkir.Alpha3Code, Bashkir },
        { Bambara.Alpha3Code, Bambara },
        { Basque.Alpha3Code, Basque },
        { Belarusian.Alpha3Code, Belarusian },
        { Bengali.Alpha3Code, Bengali },
        { BihariLanguages.Alpha3Code, BihariLanguages },
        { Bislama.Alpha3Code, Bislama },
        { Tibetan.Alpha3Code, Tibetan },
        { Bosnian.Alpha3Code, Bosnian },
        { Breton.Alpha3Code, Breton },
        { Bulgarian.Alpha3Code, Bulgarian },
        { Burmese.Alpha3Code, Burmese },
        { Catalan.Alpha3Code, Catalan },
        { Czech.Alpha3Code, Czech },
        { Chamorro.Alpha3Code, Chamorro },
        { Chechen.Alpha3Code, Chechen },
        { Chinese.Alpha3Code, Chinese },
        { ChurchSlavic.Alpha3Code, ChurchSlavic },
        { Chuvash.Alpha3Code, Chuvash },
        { Welsh.Alpha3Code, Welsh },
        { Danish.Alpha3Code, Danish },
        { German.Alpha3Code, German },
        { Divehi.Alpha3Code, Divehi },
        { Dutch.Alpha3Code, Dutch },
        { Dzongkha.Alpha3Code, Dzongkha },
        { GreekModern.Alpha3Code, GreekModern },
        { English.Alpha3Code, English },
        { Esperanto.Alpha3Code, Esperanto },
        { Estonian.Alpha3Code, Estonian },
        { Ewe.Alpha3Code, Ewe },
        { Faroese.Alpha3Code, Faroese },
        { Persian.Alpha3Code, Persian },
        { Fijian.Alpha3Code, Fijian },
        { Finnish.Alpha3Code, Finnish },
        { French.Alpha3Code, French },
        { WesternFrisian.Alpha3Code, WesternFrisian },
        { Fulah.Alpha3Code, Fulah },
        { Georgian.Alpha3Code, Georgian },
        { Gaelic.Alpha3Code, Gaelic },
        { Irish.Alpha3Code, Irish },
        { Galician.Alpha3Code, Galician },
        { Manx.Alpha3Code, Manx },
        { Gujarati.Alpha3Code, Gujarati },
        { Haitian.Alpha3Code, Haitian },
        { Hausa.Alpha3Code, Hausa },
        { Hebrew.Alpha3Code, Hebrew },
        { Herero.Alpha3Code, Herero },
        { Hindi.Alpha3Code, Hindi },
        { HiriMotu.Alpha3Code, HiriMotu },
        { Croatian.Alpha3Code, Croatian },
        { Hungarian.Alpha3Code, Hungarian },
        { Igbo.Alpha3Code, Igbo },
        { Icelandic.Alpha3Code, Icelandic },
        { Ido.Alpha3Code, Ido },
        { SichuanYi.Alpha3Code, SichuanYi },
        { Inuktitut.Alpha3Code, Inuktitut },
        { Interlingue.Alpha3Code, Interlingue },
        { Interlingua.Alpha3Code, Interlingua },
        { Indonesian.Alpha3Code, Indonesian },
        { Inupiaq.Alpha3Code, Inupiaq },
        { Italian.Alpha3Code, Italian },
        { Japanese.Alpha3Code, Japanese },
        { Javanese.Alpha3Code, Javanese },
        { Kalaallisut.Alpha3Code, Kalaallisut },
        { Kannada.Alpha3Code, Kannada },
        { Kashmiri.Alpha3Code, Kashmiri },
        { Kanuri.Alpha3Code, Kanuri },
        { Kazakh.Alpha3Code, Kazakh },
        { Kikuyu.Alpha3Code, Kikuyu },
        { Kinyarwanda.Alpha3Code, Kinyarwanda },
        { Kirghiz.Alpha3Code, Kirghiz },
        { Komi.Alpha3Code, Komi },
        { Kongo.Alpha3Code, Kongo },
        { Korean.Alpha3Code, Korean },
        { Kurdish.Alpha3Code, Kurdish },
        { Lao.Alpha3Code, Lao },
        { Latin.Alpha3Code, Latin },
        { Latvian.Alpha3Code, Latvian },
        { Limburgan.Alpha3Code, Limburgan },
        { Lingala.Alpha3Code, Lingala },
        { Lithuanian.Alpha3Code, Lithuanian },
        { Luxembourgish.Alpha3Code, Luxembourgish },
        { LubaKatanga.Alpha3Code, LubaKatanga },
        { Ganda.Alpha3Code, Ganda },
        { Macedonian.Alpha3Code, Macedonian },
        { Marshallese.Alpha3Code, Marshallese },
        { Malayalam.Alpha3Code, Malayalam },
        { Marathi.Alpha3Code, Marathi },
        { Malay.Alpha3Code, Malay },
        { Maltese.Alpha3Code, Maltese },
        { Mongolian.Alpha3Code, Mongolian },
        { Nauru.Alpha3Code, Nauru },
        { Navajo.Alpha3Code, Navajo },
        { NdebeleSouth.Alpha3Code, NdebeleSouth },
        { NdebeleNorth.Alpha3Code, NdebeleNorth },
        { Ndonga.Alpha3Code, Ndonga },
        { Nepali.Alpha3Code, Nepali },
        { Norwegian.Alpha3Code, Norwegian },
        { NorwegianNynorsk.Alpha3Code, NorwegianNynorsk },
        { NorwegianBokmal.Alpha3Code, NorwegianBokmal },
        { Chichewa.Alpha3Code, Chichewa },
        { Occitan.Alpha3Code, Occitan },
        { Ojibwa.Alpha3Code, Ojibwa },
        { Oriya.Alpha3Code, Oriya },
        { Oromo.Alpha3Code, Oromo },
        { Ossetian.Alpha3Code, Ossetian },
        { Panjabi.Alpha3Code, Panjabi },
        { Pali.Alpha3Code, Pali },
        { Polish.Alpha3Code, Polish },
        { Portuguese.Alpha3Code, Portuguese },
        { Pushto.Alpha3Code, Pushto },
        { Quechua.Alpha3Code, Quechua },
        { Romansh.Alpha3Code, Romansh },
        { Romanian.Alpha3Code, Romanian },
        { Rundi.Alpha3Code, Rundi },
        { Russian.Alpha3Code, Russian },
        { Sango.Alpha3Code, Sango },
        { Sanskrit.Alpha3Code, Sanskrit },
        { Sinhala.Alpha3Code, Sinhala },
        { Slovak.Alpha3Code, Slovak },
        { Slovenian.Alpha3Code, Slovenian },
        { NorthernSami.Alpha3Code, NorthernSami },
        { Samoan.Alpha3Code, Samoan },
        { Shona.Alpha3Code, Shona },
        { Sindhi.Alpha3Code, Sindhi },
        { Somali.Alpha3Code, Somali },
        { SothoSouthern.Alpha3Code, SothoSouthern },
        { Spanish.Alpha3Code, Spanish },
        { Sardinian.Alpha3Code, Sardinian },
        { Serbian.Alpha3Code, Serbian },
        { Swati.Alpha3Code, Swati },
        { Sundanese.Alpha3Code, Sundanese },
        { Swahili.Alpha3Code, Swahili },
        { Swedish.Alpha3Code, Swedish },
        { Tamil.Alpha3Code, Tamil },
        { Telugu.Alpha3Code, Telugu },
        { Tajik.Alpha3Code, Tajik },
        { Thai.Alpha3Code, Thai },
        { Tigrinya.Alpha3Code, Tigrinya },
        { Turkmen.Alpha3Code, Turkmen },
        { Tagalog.Alpha3Code, Tagalog },
        { Tswana.Alpha3Code, Tswana },
        { TongaIslands.Alpha3Code, TongaIslands },
        { TongaNyasa.Alpha3Code, TongaNyasa },
        { Turkish.Alpha3Code, Turkish },
        { Tsonga.Alpha3Code, Tsonga },
        { Tatar.Alpha3Code, Tatar },
        { Twi.Alpha3Code, Twi },
        { Tahitian.Alpha3Code, Tahitian },
        { Uighur.Alpha3Code, Uighur },
        { Ukrainian.Alpha3Code, Ukrainian },
        { Urdu.Alpha3Code, Urdu },
        { Uzbek.Alpha3Code, Uzbek },
        { Venda.Alpha3Code, Venda },
        { Vietnamese.Alpha3Code, Vietnamese },
        { Volapuk.Alpha3Code, Volapuk },
        { Walloon.Alpha3Code, Walloon },
        { Wolof.Alpha3Code, Wolof },
        { Xhosa.Alpha3Code, Xhosa },
        { Yiddish.Alpha3Code, Yiddish },
        { Yoruba.Alpha3Code, Yoruba },
        { Zhuang.Alpha3Code, Zhuang },
        { Zulu.Alpha3Code, Zulu }
    };

    public static readonly IReadOnlyDictionary<string, Language> Alpha2CodeMap = new Dictionary<string, Language>
    {
        { Afar.Alpha2Code, Afar },
        { Abkhazian.Alpha2Code, Abkhazian },
        { Afrikaans.Alpha2Code, Afrikaans },
        { Akan.Alpha2Code, Akan },
        { Albanian.Alpha2Code, Albanian },
        { Amharic.Alpha2Code, Amharic },
        { Arabic.Alpha2Code, Arabic },
        { Aragonese.Alpha2Code, Aragonese },
        { Armenian.Alpha2Code, Armenian },
        { Azerbaijani.Alpha2Code, Azerbaijani },
        { Bashkir.Alpha2Code, Bashkir },
        { Bambara.Alpha2Code, Bambara },
        { Basque.Alpha2Code, Basque },
        { Belarusian.Alpha2Code, Belarusian },
        { Bengali.Alpha2Code, Bengali },
        { BihariLanguages.Alpha2Code, BihariLanguages },
        { Bislama.Alpha2Code, Bislama },
        { Tibetan.Alpha2Code, Tibetan },
        { Bosnian.Alpha2Code, Bosnian },
        { Breton.Alpha2Code, Breton },
        { Bulgarian.Alpha2Code, Bulgarian },
        { Burmese.Alpha2Code, Burmese },
        { Catalan.Alpha2Code, Catalan },
        { Czech.Alpha2Code, Czech },
        { Chamorro.Alpha2Code, Chamorro },
        { Chechen.Alpha2Code, Chechen },
        { Chinese.Alpha2Code, Chinese },
        { ChurchSlavic.Alpha2Code, ChurchSlavic },
        { Chuvash.Alpha2Code, Chuvash },
        { Welsh.Alpha2Code, Welsh },
        { Danish.Alpha2Code, Danish },
        { German.Alpha2Code, German },
        { Divehi.Alpha2Code, Divehi },
        { Dutch.Alpha2Code, Dutch },
        { Dzongkha.Alpha2Code, Dzongkha },
        { GreekModern.Alpha2Code, GreekModern },
        { English.Alpha2Code, English },
        { Esperanto.Alpha2Code, Esperanto },
        { Estonian.Alpha2Code, Estonian },
        { Ewe.Alpha2Code, Ewe },
        { Faroese.Alpha2Code, Faroese },
        { Persian.Alpha2Code, Persian },
        { Fijian.Alpha2Code, Fijian },
        { Finnish.Alpha2Code, Finnish },
        { French.Alpha2Code, French },
        { WesternFrisian.Alpha2Code, WesternFrisian },
        { Fulah.Alpha2Code, Fulah },
        { Georgian.Alpha2Code, Georgian },
        { Gaelic.Alpha2Code, Gaelic },
        { Irish.Alpha2Code, Irish },
        { Galician.Alpha2Code, Galician },
        { Manx.Alpha2Code, Manx },
        { Gujarati.Alpha2Code, Gujarati },
        { Haitian.Alpha2Code, Haitian },
        { Hausa.Alpha2Code, Hausa },
        { Hebrew.Alpha2Code, Hebrew },
        { Herero.Alpha2Code, Herero },
        { Hindi.Alpha2Code, Hindi },
        { HiriMotu.Alpha2Code, HiriMotu },
        { Croatian.Alpha2Code, Croatian },
        { Hungarian.Alpha2Code, Hungarian },
        { Igbo.Alpha2Code, Igbo },
        { Icelandic.Alpha2Code, Icelandic },
        { Ido.Alpha2Code, Ido },
        { SichuanYi.Alpha2Code, SichuanYi },
        { Inuktitut.Alpha2Code, Inuktitut },
        { Interlingue.Alpha2Code, Interlingue },
        { Interlingua.Alpha2Code, Interlingua },
        { Indonesian.Alpha2Code, Indonesian },
        { Inupiaq.Alpha2Code, Inupiaq },
        { Italian.Alpha2Code, Italian },
        { Japanese.Alpha2Code, Japanese },
        { Javanese.Alpha2Code, Javanese },
        { Kalaallisut.Alpha2Code, Kalaallisut },
        { Kannada.Alpha2Code, Kannada },
        { Kashmiri.Alpha2Code, Kashmiri },
        { Kanuri.Alpha2Code, Kanuri },
        { Kazakh.Alpha2Code, Kazakh },
        { Kikuyu.Alpha2Code, Kikuyu },
        { Kinyarwanda.Alpha2Code, Kinyarwanda },
        { Kirghiz.Alpha2Code, Kirghiz },
        { Komi.Alpha2Code, Komi },
        { Kongo.Alpha2Code, Kongo },
        { Korean.Alpha2Code, Korean },
        { Kurdish.Alpha2Code, Kurdish },
        { Lao.Alpha2Code, Lao },
        { Latin.Alpha2Code, Latin },
        { Latvian.Alpha2Code, Latvian },
        { Limburgan.Alpha2Code, Limburgan },
        { Lingala.Alpha2Code, Lingala },
        { Lithuanian.Alpha2Code, Lithuanian },
        { Luxembourgish.Alpha2Code, Luxembourgish },
        { LubaKatanga.Alpha2Code, LubaKatanga },
        { Ganda.Alpha2Code, Ganda },
        { Macedonian.Alpha2Code, Macedonian },
        { Marshallese.Alpha2Code, Marshallese },
        { Malayalam.Alpha2Code, Malayalam },
        { Marathi.Alpha2Code, Marathi },
        { Malay.Alpha2Code, Malay },
        { Maltese.Alpha2Code, Maltese },
        { Mongolian.Alpha2Code, Mongolian },
        { Nauru.Alpha2Code, Nauru },
        { Navajo.Alpha2Code, Navajo },
        { NdebeleSouth.Alpha2Code, NdebeleSouth },
        { NdebeleNorth.Alpha2Code, NdebeleNorth },
        { Ndonga.Alpha2Code, Ndonga },
        { Nepali.Alpha2Code, Nepali },
        { Norwegian.Alpha2Code, Norwegian },
        { NorwegianNynorsk.Alpha2Code, NorwegianNynorsk },
        { NorwegianBokmal.Alpha2Code, NorwegianBokmal },
        { Chichewa.Alpha2Code, Chichewa },
        { Occitan.Alpha2Code, Occitan },
        { Ojibwa.Alpha2Code, Ojibwa },
        { Oriya.Alpha2Code, Oriya },
        { Oromo.Alpha2Code, Oromo },
        { Ossetian.Alpha2Code, Ossetian },
        { Panjabi.Alpha2Code, Panjabi },
        { Pali.Alpha2Code, Pali },
        { Polish.Alpha2Code, Polish },
        { Portuguese.Alpha2Code, Portuguese },
        { Pushto.Alpha2Code, Pushto },
        { Quechua.Alpha2Code, Quechua },
        { Romansh.Alpha2Code, Romansh },
        { Romanian.Alpha2Code, Romanian },
        { Rundi.Alpha2Code, Rundi },
        { Russian.Alpha2Code, Russian },
        { Sango.Alpha2Code, Sango },
        { Sanskrit.Alpha2Code, Sanskrit },
        { Sinhala.Alpha2Code, Sinhala },
        { Slovak.Alpha2Code, Slovak },
        { Slovenian.Alpha2Code, Slovenian },
        { NorthernSami.Alpha2Code, NorthernSami },
        { Samoan.Alpha2Code, Samoan },
        { Shona.Alpha2Code, Shona },
        { Sindhi.Alpha2Code, Sindhi },
        { Somali.Alpha2Code, Somali },
        { SothoSouthern.Alpha2Code, SothoSouthern },
        { Spanish.Alpha2Code, Spanish },
        { Sardinian.Alpha2Code, Sardinian },
        { Serbian.Alpha2Code, Serbian },
        { Swati.Alpha2Code, Swati },
        { Sundanese.Alpha2Code, Sundanese },
        { Swahili.Alpha2Code, Swahili },
        { Swedish.Alpha2Code, Swedish },
        { Tamil.Alpha2Code, Tamil },
        { Telugu.Alpha2Code, Telugu },
        { Tajik.Alpha2Code, Tajik },
        { Thai.Alpha2Code, Thai },
        { Tigrinya.Alpha2Code, Tigrinya },
        { Turkmen.Alpha2Code, Turkmen },
        { Tagalog.Alpha2Code, Tagalog },
        { Tswana.Alpha2Code, Tswana },
        { TongaIslands.Alpha2Code, TongaIslands },
        { TongaNyasa.Alpha2Code, TongaNyasa },
        { Turkish.Alpha2Code, Turkish },
        { Tsonga.Alpha2Code, Tsonga },
        { Tatar.Alpha2Code, Tatar },
        { Twi.Alpha2Code, Twi },
        { Tahitian.Alpha2Code, Tahitian },
        { Uighur.Alpha2Code, Uighur },
        { Ukrainian.Alpha2Code, Ukrainian },
        { Urdu.Alpha2Code, Urdu },
        { Uzbek.Alpha2Code, Uzbek },
        { Venda.Alpha2Code, Venda },
        { Vietnamese.Alpha2Code, Vietnamese },
        { Volapuk.Alpha2Code, Volapuk },
        { Walloon.Alpha2Code, Walloon },
        { Wolof.Alpha2Code, Wolof },
        { Xhosa.Alpha2Code, Xhosa },
        { Yiddish.Alpha2Code, Yiddish },
        { Yoruba.Alpha2Code, Yoruba },
        { Zhuang.Alpha2Code, Zhuang },
        { Zulu.Alpha2Code, Zulu }
    };

    public static readonly IReadOnlyDictionary<string, Language> NameMap = new Dictionary<string, Language>
    {
        { Afar.Name, Afar },
        { Abkhazian.Name, Abkhazian },
        { Afrikaans.Name, Afrikaans },
        { Akan.Name, Akan },
        { Albanian.Name, Albanian },
        { Amharic.Name, Amharic },
        { Arabic.Name, Arabic },
        { Aragonese.Name, Aragonese },
        { Armenian.Name, Armenian },
        { Azerbaijani.Name, Azerbaijani },
        { Bashkir.Name, Bashkir },
        { Bambara.Name, Bambara },
        { Basque.Name, Basque },
        { Belarusian.Name, Belarusian },
        { Bengali.Name, Bengali },
        { BihariLanguages.Name, BihariLanguages },
        { Bislama.Name, Bislama },
        { Tibetan.Name, Tibetan },
        { Bosnian.Name, Bosnian },
        { Breton.Name, Breton },
        { Bulgarian.Name, Bulgarian },
        { Burmese.Name, Burmese },
        { Catalan.Name, Catalan },
        { Czech.Name, Czech },
        { Chamorro.Name, Chamorro },
        { Chechen.Name, Chechen },
        { Chinese.Name, Chinese },
        { ChurchSlavic.Name, ChurchSlavic },
        { Chuvash.Name, Chuvash },
        { Welsh.Name, Welsh },
        { Danish.Name, Danish },
        { German.Name, German },
        { Divehi.Name, Divehi },
        { Dutch.Name, Dutch },
        { Dzongkha.Name, Dzongkha },
        { GreekModern.Name, GreekModern },
        { English.Name, English },
        { Esperanto.Name, Esperanto },
        { Estonian.Name, Estonian },
        { Ewe.Name, Ewe },
        { Faroese.Name, Faroese },
        { Persian.Name, Persian },
        { Fijian.Name, Fijian },
        { Finnish.Name, Finnish },
        { French.Name, French },
        { WesternFrisian.Name, WesternFrisian },
        { Fulah.Name, Fulah },
        { Georgian.Name, Georgian },
        { Gaelic.Name, Gaelic },
        { Irish.Name, Irish },
        { Galician.Name, Galician },
        { Manx.Name, Manx },
        { Gujarati.Name, Gujarati },
        { Haitian.Name, Haitian },
        { Hausa.Name, Hausa },
        { Hebrew.Name, Hebrew },
        { Herero.Name, Herero },
        { Hindi.Name, Hindi },
        { HiriMotu.Name, HiriMotu },
        { Croatian.Name, Croatian },
        { Hungarian.Name, Hungarian },
        { Igbo.Name, Igbo },
        { Icelandic.Name, Icelandic },
        { Ido.Name, Ido },
        { SichuanYi.Name, SichuanYi },
        { Inuktitut.Name, Inuktitut },
        { Interlingue.Name, Interlingue },
        { Interlingua.Name, Interlingua },
        { Indonesian.Name, Indonesian },
        { Inupiaq.Name, Inupiaq },
        { Italian.Name, Italian },
        { Japanese.Name, Japanese },
        { Javanese.Name, Javanese },
        { Kalaallisut.Name, Kalaallisut },
        { Kannada.Name, Kannada },
        { Kashmiri.Name, Kashmiri },
        { Kanuri.Name, Kanuri },
        { Kazakh.Name, Kazakh },
        { Kikuyu.Name, Kikuyu },
        { Kinyarwanda.Name, Kinyarwanda },
        { Kirghiz.Name, Kirghiz },
        { Komi.Name, Komi },
        { Kongo.Name, Kongo },
        { Korean.Name, Korean },
        { Kurdish.Name, Kurdish },
        { Lao.Name, Lao },
        { Latin.Name, Latin },
        { Latvian.Name, Latvian },
        { Limburgan.Name, Limburgan },
        { Lingala.Name, Lingala },
        { Lithuanian.Name, Lithuanian },
        { Luxembourgish.Name, Luxembourgish },
        { LubaKatanga.Name, LubaKatanga },
        { Ganda.Name, Ganda },
        { Macedonian.Name, Macedonian },
        { Marshallese.Name, Marshallese },
        { Malayalam.Name, Malayalam },
        { Marathi.Name, Marathi },
        { Malay.Name, Malay },
        { Maltese.Name, Maltese },
        { Mongolian.Name, Mongolian },
        { Nauru.Name, Nauru },
        { Navajo.Name, Navajo },
        { NdebeleSouth.Name, NdebeleSouth },
        { NdebeleNorth.Name, NdebeleNorth },
        { Ndonga.Name, Ndonga },
        { Nepali.Name, Nepali },
        { Norwegian.Name, Norwegian },
        { NorwegianNynorsk.Name, NorwegianNynorsk },
        { NorwegianBokmal.Name, NorwegianBokmal },
        { Chichewa.Name, Chichewa },
        { Occitan.Name, Occitan },
        { Ojibwa.Name, Ojibwa },
        { Oriya.Name, Oriya },
        { Oromo.Name, Oromo },
        { Ossetian.Name, Ossetian },
        { Panjabi.Name, Panjabi },
        { Pali.Name, Pali },
        { Polish.Name, Polish },
        { Portuguese.Name, Portuguese },
        { Pushto.Name, Pushto },
        { Quechua.Name, Quechua },
        { Romansh.Name, Romansh },
        { Romanian.Name, Romanian },
        { Rundi.Name, Rundi },
        { Russian.Name, Russian },
        { Sango.Name, Sango },
        { Sanskrit.Name, Sanskrit },
        { Sinhala.Name, Sinhala },
        { Slovak.Name, Slovak },
        { Slovenian.Name, Slovenian },
        { NorthernSami.Name, NorthernSami },
        { Samoan.Name, Samoan },
        { Shona.Name, Shona },
        { Sindhi.Name, Sindhi },
        { Somali.Name, Somali },
        { SothoSouthern.Name, SothoSouthern },
        { Spanish.Name, Spanish },
        { Sardinian.Name, Sardinian },
        { Serbian.Name, Serbian },
        { Swati.Name, Swati },
        { Sundanese.Name, Sundanese },
        { Swahili.Name, Swahili },
        { Swedish.Name, Swedish },
        { Tamil.Name, Tamil },
        { Telugu.Name, Telugu },
        { Tajik.Name, Tajik },
        { Thai.Name, Thai },
        { Tigrinya.Name, Tigrinya },
        { Turkmen.Name, Turkmen },
        { Tagalog.Name, Tagalog },
        { Tswana.Name, Tswana },
        { TongaIslands.Name, TongaIslands },
        { TongaNyasa.Name, TongaNyasa },
        { Turkish.Name, Turkish },
        { Tsonga.Name, Tsonga },
        { Tatar.Name, Tatar },
        { Twi.Name, Twi },
        { Tahitian.Name, Tahitian },
        { Uighur.Name, Uighur },
        { Ukrainian.Name, Ukrainian },
        { Urdu.Name, Urdu },
        { Uzbek.Name, Uzbek },
        { Venda.Name, Venda },
        { Vietnamese.Name, Vietnamese },
        { Volapuk.Name, Volapuk },
        { Walloon.Name, Walloon },
        { Wolof.Name, Wolof },
        { Xhosa.Name, Xhosa },
        { Yiddish.Name, Yiddish },
        { Yoruba.Name, Yoruba },
        { Zhuang.Name, Zhuang },
        { Zulu.Name, Zulu }
    };
}