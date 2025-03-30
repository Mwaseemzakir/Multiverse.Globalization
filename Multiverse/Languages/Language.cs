using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Multiverse.Languages
{
    public class Language
    {
    #region Languages
    public static readonly Language Aar = new Language("aa", "aar", "Afar");
    public static readonly Language Abk = new Language("ab", "abk", "Abkhazian");
    public static readonly Language Ace = new Language("", "ace", "Achinese");
    public static readonly Language Ach = new Language("", "ach", "Acoli");
    public static readonly Language Ada = new Language("", "ada", "Adangme");
    public static readonly Language Ady = new Language("", "ady", "Adyghe; Adygei");
    public static readonly Language Afa = new Language("", "afa", "Afro-Asiatic languages");
    public static readonly Language Afh = new Language("", "afh", "Afrihili");
    public static readonly Language Afr = new Language("af", "afr", "Afrikaans");
    public static readonly Language Ain = new Language("", "ain", "Ainu");
    public static readonly Language Aka = new Language("ak", "aka", "Akan");
    public static readonly Language Akk = new Language("", "akk", "Akkadian");
    public static readonly Language AlbB = new Language("sq", "alb", "Albanian");
    public static readonly Language SqiT = new Language("", "sqi", "");
    public static readonly Language Ale = new Language("", "ale", "Aleut");
    public static readonly Language Alg = new Language("", "alg", "Algonquian languages");
    public static readonly Language Alt = new Language("", "alt", "Southern Altai");
    public static readonly Language Amh = new Language("am", "amh", "Amharic");
    public static readonly Language Ang = new Language("", "ang", "English, Old (ca.450-1100)");
    public static readonly Language Anp = new Language("", "anp", "Angika");
    public static readonly Language Apa = new Language("", "apa", "Apache languages");
    public static readonly Language Ara = new Language("ar", "ara", "Arabic");
    public static readonly Language Arc = new Language("", "arc", "Official Aramaic (700-300 BCE); Imperial Aramaic (700-300 BCE)");
    public static readonly Language Arg = new Language("an", "arg", "Aragonese");
    public static readonly Language ArmB = new Language("hy", "arm", "Armenian");
    public static readonly Language HyeT = new Language("", "hye", "");
    public static readonly Language Arn = new Language("", "arn", "Mapudungun; Mapuche");
    public static readonly Language Arp = new Language("", "arp", "Arapaho");
    public static readonly Language Art = new Language("", "art", "Artificial languages");
    public static readonly Language Arw = new Language("", "arw", "Arawak");
    public static readonly Language Asm = new Language("as", "asm", "Assamese");
    public static readonly Language Ast = new Language("", "ast", "Asturian; Bable; Leonese; Asturleonese");
    public static readonly Language Ath = new Language("", "ath", "Athapascan languages");
    public static readonly Language Aus = new Language("", "aus", "Australian languages");
    public static readonly Language Ava = new Language("av", "ava", "Avaric");
    public static readonly Language Ave = new Language("ae", "ave", "Avestan");
    public static readonly Language Awa = new Language("", "awa", "Awadhi");
    public static readonly Language Aym = new Language("ay", "aym", "Aymara");
    public static readonly Language Aze = new Language("az", "aze", "Azerbaijani");



    public static readonly Language Bad = new Language("", "bad", "Banda languages");
    public static readonly Language Bai = new Language("", "bai", "Bamileke languages");
    public static readonly Language Bak = new Language("ba", "bak", "Bashkir");
    public static readonly Language Bal = new Language("", "bal", "Baluchi");
    public static readonly Language Bam = new Language("bm", "bam", "Bambara");
    public static readonly Language Ban = new Language("", "ban", "Balinese");
    public static readonly Language BaqB = new Language("eu", "baq", "Basque");
    public static readonly Language EusT = new Language("", "eus", "");
    public static readonly Language Bas = new Language("", "bas", "Basa");
    public static readonly Language Bat = new Language("", "bat", "Baltic languages");
    public static readonly Language Bej = new Language("", "bej", "Beja; Bedawiyet");
    public static readonly Language Bel = new Language("be", "bel", "Belarusian");
    public static readonly Language Bem = new Language("", "bem", "Bemba");
    public static readonly Language Ben = new Language("bn", "ben", "Bengali");
    public static readonly Language Ber = new Language("", "ber", "Berber languages");
    public static readonly Language Bho = new Language("", "bho", "Bhojpuri");
    public static readonly Language Bih = new Language("bh", "bih", "Bihari languages");
    public static readonly Language Bik = new Language("", "bik", "Bikol");
    public static readonly Language Bin = new Language("", "bin", "Bini; Edo");
    public static readonly Language Bis = new Language("bi", "bis", "Bislama");
    public static readonly Language Bla = new Language("", "bla", "Siksika");
    public static readonly Language Bnt = new Language("", "bnt", "Bantu languages");
    public static readonly Language TibB = new Language("bo", "tib", "Tibetan");
    public static readonly Language BodT = new Language("", "bod", "");
    public static readonly Language Bos = new Language("bs", "bos", "Bosnian");
    public static readonly Language Bra = new Language("", "bra", "Braj");
    public static readonly Language Bre = new Language("br", "bre", "Breton");
    public static readonly Language Btk = new Language("", "btk", "Batak languages");
    public static readonly Language Bua = new Language("", "bua", "Buriat");
    public static readonly Language Bug = new Language("", "bug", "Buginese");
    public static readonly Language Bul = new Language("bg", "bul", "Bulgarian");
    public static readonly Language BurB = new Language("my", "bur", "Burmese");
    public static readonly Language MyaT = new Language("", "mya", "");
    public static readonly Language Byn = new Language("", "byn", "Blin; Bilin");


    public static readonly Language Cad = new Language("", "cad", "Caddo");
    public static readonly Language Cai = new Language("", "cai", "Central American Indian languages");
    public static readonly Language Car = new Language("", "car", "Galibi Carib");
    public static readonly Language Cat = new Language("ca", "cat", "Catalan; Valencian");
    public static readonly Language Cau = new Language("", "cau", "Caucasian languages");
    public static readonly Language Ceb = new Language("", "ceb", "Cebuano");
    public static readonly Language Cel = new Language("", "cel", "Celtic languages");
    public static readonly Language CzeB = new Language("cs", "cze", "Czech");
    public static readonly Language CesT = new Language("", "ces", "");
    public static readonly Language Cha = new Language("ch", "cha", "Chamorro");
    public static readonly Language Chb = new Language("", "chb", "Chibcha");
    public static readonly Language Che = new Language("ce", "che", "Chechen");
    public static readonly Language Chg = new Language("", "chg", "Chagatai");
    public static readonly Language ChiB = new Language("zh", "chi", "Chinese");
    public static readonly Language ZhoT = new Language("", "zho", "");
    public static readonly Language Chk = new Language("", "chk", "Chuukese");
    public static readonly Language Chm = new Language("", "chm", "Mari");
    public static readonly Language Chn = new Language("", "chn", "Chinook jargon");
    public static readonly Language Cho = new Language("", "cho", "Choctaw");
    public static readonly Language Chp = new Language("", "chp", "Chipewyan; Dene Suline");
    public static readonly Language Chr = new Language("", "chr", "Cherokee");
    public static readonly Language Chu = new Language("cu", "chu", "Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic");
    public static readonly Language Chv = new Language("cv", "chv", "Chuvash");
    public static readonly Language Chy = new Language("", "chy", "Cheyenne");
    public static readonly Language Cmc = new Language("", "cmc", "Chamic languages");
    public static readonly Language Cnr = new Language("", "cnr", "Montenegrin");
    public static readonly Language Cop = new Language("", "cop", "Coptic");
    public static readonly Language Cor = new Language("kw", "cor", "Cornish");
    public static readonly Language Cos = new Language("co", "cos", "Corsican");
    public static readonly Language Cpe = new Language("", "cpe", "Creoles and pidgins, English based");
    public static readonly Language Cpf = new Language("", "cpf", "Creoles and pidgins, French-based");
    public static readonly Language Cpp = new Language("", "cpp", "Creoles and pidgins, Portuguese-based");
    public static readonly Language Cre = new Language("cr", "cre", "Cree");
    public static readonly Language Crh = new Language("", "crh", "Crimean Tatar; Crimean Turkish");
    public static readonly Language Crp = new Language("", "crp", "Creoles and pidgins");
    public static readonly Language Csb = new Language("", "csb", "Kashubian");
    public static readonly Language Cus = new Language("", "cus", "Cushitic languages");
    public static readonly Language WelB = new Language("cy", "wel", "Welsh");
    public static readonly Language CymT = new Language("", "cym", "");
    public static readonly Language CzeBBis = new Language("cs", "cze", "Czech");
    public static readonly Language CesTBis = new Language("", "ces", "");

    public static readonly Language Dak = new Language("", "dak", "Dakota");
    public static readonly Language Dan = new Language("da", "dan", "Danish");
    public static readonly Language Dar = new Language("", "dar", "Dargwa");
    public static readonly Language Day = new Language("", "day", "Land Dayak languages");
    public static readonly Language Del = new Language("", "del", "Delaware");
    public static readonly Language Den = new Language("", "den", "Slave (Athapascan)");
    public static readonly Language GerB = new Language("de", "ger", "German");
    public static readonly Language DeuT = new Language("", "deu", "");
    public static readonly Language Dgr = new Language("", "dgr", "Dogrib");
    public static readonly Language Din = new Language("", "din", "Dinka");
    public static readonly Language Div = new Language("dv", "div", "Divehi; Dhivehi; Maldivian");
    public static readonly Language Doi = new Language("", "doi", "Dogri");
    public static readonly Language Dra = new Language("", "dra", "Dravidian languages");
    public static readonly Language Dsb = new Language("", "dsb", "Lower Sorbian");
    public static readonly Language Dua = new Language("", "dua", "Duala");
    public static readonly Language Dum = new Language("", "dum", "Dutch, Middle (ca.1050-1350)");
    public static readonly Language DutB = new Language("nl", "dut", "Dutch; Flemish");
    public static readonly Language NldT = new Language("", "nld", "");
    public static readonly Language Dyu = new Language("", "dyu", "Dyula");
    public static readonly Language Dzo = new Language("dz", "dzo", "Dzongkha");

    public static readonly Language Efi = new Language("", "efi", "Efik");
    public static readonly Language Egy = new Language("", "egy", "Egyptian (Ancient)");
    public static readonly Language Eka = new Language("", "eka", "Ekajuk");
    public static readonly Language GreB = new Language("el", "gre", "Greek, Modern (1453-)");
    public static readonly Language EllT = new Language("", "ell", "");
    public static readonly Language Elx = new Language("", "elx", "Elamite");
    public static readonly Language Eng = new Language("en", "eng", "English");
    public static readonly Language Enm = new Language("", "enm", "English, Middle (1100-1500)");
    public static readonly Language Epo = new Language("eo", "epo", "Esperanto");
    public static readonly Language Est = new Language("et", "est", "Estonian");
    public static readonly Language Ewe = new Language("ee", "ewe", "Ewe");
    public static readonly Language Ewo = new Language("", "ewo", "Ewondo");


    public static readonly Language Fan = new Language("", "fan", "Fang");
    public static readonly Language Fao = new Language("fo", "fao", "Faroese");
    public static readonly Language PerB = new Language("fa", "per", "Persian");
    public static readonly Language FasT = new Language("", "fas", "");
    public static readonly Language Fat = new Language("", "fat", "Fanti");
    public static readonly Language Fij = new Language("fj", "fij", "Fijian");
    public static readonly Language Fil = new Language("", "fil", "Filipino; Pilipino");
    public static readonly Language Fin = new Language("fi", "fin", "Finnish");
    public static readonly Language Fiu = new Language("", "fiu", "Finno-Ugrian languages");
    public static readonly Language Fon = new Language("", "fon", "Fon");
    public static readonly Language FreB = new Language("fr", "fre", "French");
    public static readonly Language FraT = new Language("", "fra", "");
    public static readonly Language Frm = new Language("", "frm", "French, Middle (ca.1400-1600)");
    public static readonly Language Fro = new Language("", "fro", "French, Old (842-ca.1400)");
    public static readonly Language Frr = new Language("", "frr", "Northern Frisian");
    public static readonly Language Frs = new Language("", "frs", "Eastern Frisian");
    public static readonly Language Fry = new Language("fy", "fry", "Western Frisian");
    public static readonly Language Ful = new Language("ff", "ful", "Fulah");
    public static readonly Language Fur = new Language("", "fur", "Friulian");

    public static readonly Language Gaa = new Language("", "gaa", "Ga");
    public static readonly Language Gay = new Language("", "gay", "Gayo");
    public static readonly Language Gba = new Language("", "gba", "Gbaya");
    public static readonly Language Gem = new Language("", "gem", "Germanic languages");
    public static readonly Language GeoB = new Language("ka", "geo", "Georgian");
    public static readonly Language KatT = new Language("", "kat", "");
    public static readonly Language Gez = new Language("", "gez", "Geez");
    public static readonly Language Gil = new Language("", "gil", "Gilbertese");
    public static readonly Language Gla = new Language("gd", "gla", "Gaelic; Scottish Gaelic");
    public static readonly Language Gle = new Language("ga", "gle", "Irish");
    public static readonly Language Glg = new Language("gl", "glg", "Galician");
    public static readonly Language Glv = new Language("gv", "glv", "Manx");
    public static readonly Language Gmh = new Language("", "gmh", "German, Middle High (ca.1050-1500)");
    public static readonly Language Goh = new Language("", "goh", "German, Old High (ca.750-1050)");
    public static readonly Language Gon = new Language("", "gon", "Gondi");
    public static readonly Language Gor = new Language("", "gor", "Gorontalo");
    public static readonly Language Got = new Language("", "got", "Gothic");
    public static readonly Language Grb = new Language("", "grb", "Grebo");
    public static readonly Language Grc = new Language("", "grc", "Greek, Ancient (to 1453)");
    public static readonly Language Grn = new Language("gn", "grn", "Guarani");
    public static readonly Language Gsw = new Language("", "gsw", "Swiss German; Alemannic; Alsatian");
    public static readonly Language Guj = new Language("gu", "guj", "Gujarati");
    public static readonly Language Gwi = new Language("", "gwi", "Gwich'in");

    public static readonly Language Hai = new Language("", "hai", "Haida");
    public static readonly Language Hat = new Language("ht", "hat", "Haitian; Haitian Creole");
    public static readonly Language Hau = new Language("ha", "hau", "Hausa");
    public static readonly Language Haw = new Language("", "haw", "Hawaiian");
    public static readonly Language Heb = new Language("he", "heb", "Hebrew");
    public static readonly Language Her = new Language("hz", "her", "Herero");
    public static readonly Language Hil = new Language("", "hil", "Hiligaynon");
    public static readonly Language Him = new Language("", "him", "Himachali languages; Western Pahari languages");
    public static readonly Language Hin = new Language("hi", "hin", "Hindi");
    public static readonly Language Hit = new Language("", "hit", "Hittite");
    public static readonly Language Hmn = new Language("", "hmn", "Hmong; Mong");
    public static readonly Language Hmo = new Language("ho", "hmo", "Hiri Motu");
    public static readonly Language Hrv = new Language("hr", "hrv", "Croatian");
    public static readonly Language Hsb = new Language("", "hsb", "Upper Sorbian");
    public static readonly Language Hun = new Language("hu", "hun", "Hungarian");
    public static readonly Language Hup = new Language("", "hup", "Hupa");


    public static readonly Language Iba = new Language("", "iba", "Iban");
    public static readonly Language Ibo = new Language("ig", "ibo", "Igbo");
    public static readonly Language IceB = new Language("is", "ice", "Icelandic");
    public static readonly Language IslT = new Language("", "isl", "");
    public static readonly Language Ido = new Language("io", "ido", "Ido");
    public static readonly Language Iii = new Language("ii", "iii", "Sichuan Yi; Nuosu");
    public static readonly Language Ijo = new Language("", "ijo", "Ijo languages");
    public static readonly Language Iku = new Language("iu", "iku", "Inuktitut");
    public static readonly Language Ile = new Language("ie", "ile", "Interlingue; Occidental");
    public static readonly Language Ilo = new Language("", "ilo", "Iloko");
    public static readonly Language Ina = new Language("ia", "ina", "Interlingua (International Auxiliary Language Association)");
    public static readonly Language Inc = new Language("", "inc", "Indic languages");
    public static readonly Language Ind = new Language("id", "ind", "Indonesian");
    public static readonly Language Ine = new Language("", "ine", "Indo-European languages");
    public static readonly Language Inh = new Language("", "inh", "Ingush");
    public static readonly Language Ipk = new Language("ik", "ipk", "Inupiaq");
    public static readonly Language Ira = new Language("", "ira", "Iranian languages");
    public static readonly Language Iro = new Language("", "iro", "Iroquoian languages");
    public static readonly Language Ita = new Language("it", "ita", "Italian");


    public static readonly Language Jav = new Language("jv", "jav", "Javanese");
    public static readonly Language Jbo = new Language("", "jbo", "Lojban");
    public static readonly Language Jpn = new Language("ja", "jpn", "Japanese");
    public static readonly Language Jpr = new Language("", "jpr", "Judeo-Persian");
    public static readonly Language Jrb = new Language("", "jrb", "Judeo-Arabic");

    public static readonly Language Kaa = new Language("", "kaa", "Kara-Kalpak");
    public static readonly Language Kab = new Language("", "kab", "Kabyle");
    public static readonly Language Kac = new Language("", "kac", "Kachin; Jingpho");
    public static readonly Language Kal = new Language("kl", "kal", "Kalaallisut; Greenlandic");
    public static readonly Language Kam = new Language("", "kam", "Kamba");
    public static readonly Language Kan = new Language("kn", "kan", "Kannada");
    public static readonly Language Kar = new Language("", "kar", "Karen languages");
    public static readonly Language Kas = new Language("ks", "kas", "Kashmiri");
    public static readonly Language Kau = new Language("kr", "kau", "Kanuri");
    public static readonly Language Kaw = new Language("", "kaw", "Kawi");
    public static readonly Language Kaz = new Language("kk", "kaz", "Kazakh");
    public static readonly Language Kbd = new Language("", "kbd", "Kabardian");
    public static readonly Language Kha = new Language("", "kha", "Khasi");
    public static readonly Language Khi = new Language("", "khi", "Khoisan languages");
    public static readonly Language Khm = new Language("km", "khm", "Central Khmer");
    public static readonly Language Kho = new Language("", "kho", "Khotanese; Sakan");
    public static readonly Language Kik = new Language("ki", "kik", "Kikuyu; Gikuyu");
    public static readonly Language Kin = new Language("rw", "kin", "Kinyarwanda");
    public static readonly Language Kir = new Language("ky", "kir", "Kirghiz; Kyrgyz");
    public static readonly Language Kmb = new Language("", "kmb", "Kimbundu");
    public static readonly Language Kok = new Language("", "kok", "Konkani");
    public static readonly Language Kom = new Language("kv", "kom", "Komi");
    public static readonly Language Kon = new Language("kg", "kon", "Kongo");
    public static readonly Language Kor = new Language("ko", "kor", "Korean");
    public static readonly Language Kos = new Language("", "kos", "Kosraean");
    public static readonly Language Kpe = new Language("", "kpe", "Kpelle");
    public static readonly Language Krc = new Language("", "krc", "Karachay-Balkar");
    public static readonly Language Krl = new Language("", "krl", "Karelian");
    public static readonly Language Kro = new Language("", "kro", "Kru languages");
    public static readonly Language Kru = new Language("", "kru", "Kurukh");
    public static readonly Language Kua = new Language("kj", "kua", "Kuanyama; Kwanyama");
    public static readonly Language Kum = new Language("", "kum", "Kumyk");
    public static readonly Language Kur = new Language("ku", "kur", "Kurdish");
    public static readonly Language Kut = new Language("", "kut", "Kutenai");


    public static readonly Language Lad = new Language("", "lad", "Ladino");
    public static readonly Language Lah = new Language("", "lah", "Lahnda");
    public static readonly Language Lam = new Language("", "lam", "Lamba");
    public static readonly Language Lao = new Language("lo", "lao", "Lao");
    public static readonly Language Lat = new Language("la", "lat", "Latin");
    public static readonly Language Lav = new Language("lv", "lav", "Latvian");
    public static readonly Language Lez = new Language("", "lez", "Lezghian");
    public static readonly Language Lim = new Language("li", "lim", "Limburgan; Limburger; Limburgish");
    public static readonly Language Lin = new Language("ln", "lin", "Lingala");
    public static readonly Language Lit = new Language("lt", "lit", "Lithuanian");
    public static readonly Language Lol = new Language("", "lol", "Mongo");
    public static readonly Language Loz = new Language("", "loz", "Lozi");
    public static readonly Language Ltz = new Language("lb", "ltz", "Luxembourgish; Letzeburgesch");
    public static readonly Language Lua = new Language("", "lua", "Luba-Lulua");
    public static readonly Language Lub = new Language("lu", "lub", "Luba-Katanga");
    public static readonly Language Lug = new Language("lg", "lug", "Ganda");
    public static readonly Language Lui = new Language("", "lui", "Luiseno");
    public static readonly Language Lun = new Language("", "lun", "Lunda");
    public static readonly Language Luo = new Language("", "luo", "Luo (Kenya and Tanzania)");
    public static readonly Language Lus = new Language("", "lus", "Lushai");


    public static readonly Language Mac = new Language("mk", "mac", "Macedonian");
    public static readonly Language Mad = new Language("", "mad", "Madurese");
    public static readonly Language Mag = new Language("", "mag", "Magahi");
    public static readonly Language Mah = new Language("mh", "mah", "Marshallese");
    public static readonly Language Mai = new Language("", "mai", "Maithili");
    public static readonly Language Mak = new Language("", "mak", "Makasar");
    public static readonly Language Mal = new Language("ml", "mal", "Malayalam");
    public static readonly Language Man = new Language("", "man", "Mandingo");
    public static readonly Language Mao = new Language("mi", "mao", "Maori");
    public static readonly Language Map = new Language("", "map", "Austronesian languages");
    public static readonly Language Mar = new Language("mr", "mar", "Marathi");
    public static readonly Language Mas = new Language("", "mas", "Masai");
    public static readonly Language May = new Language("ms", "may", "Malay");
    public static readonly Language Mdf = new Language("", "mdf", "Moksha");
    public static readonly Language Mdr = new Language("", "mdr", "Mandar");
    public static readonly Language Men = new Language("", "men", "Mende");
    public static readonly Language Mga = new Language("", "mga", "Irish, Middle (900-1200)");
    public static readonly Language Mic = new Language("", "mic", "Mi'kmaq; Micmac");
    public static readonly Language Min = new Language("", "min", "Minangkabau");
    public static readonly Language Mis = new Language("", "mis", "Uncoded languages");
    public static readonly Language Mkh = new Language("", "mkh", "Mon-Khmer languages");
    public static readonly Language Mlg = new Language("mg", "mlg", "Malagasy");
    public static readonly Language Mlt = new Language("mt", "mlt", "Maltese");
    public static readonly Language Mnc = new Language("", "mnc", "Manchu");
    public static readonly Language Mni = new Language("", "mni", "Manipuri");
    public static readonly Language Mno = new Language("", "mno", "Manobo languages");
    public static readonly Language Moh = new Language("", "moh", "Mohawk");
    public static readonly Language Mon = new Language("mn", "mon", "Mongolian");
    public static readonly Language Mos = new Language("", "mos", "Mossi");
    public static readonly Language Maori = new Language("mi", "mao", "Maori");
    public static readonly Language Mri = new Language("", "mri", "");
    public static readonly Language Malay = new Language("ms", "may", "Malay");
    public static readonly Language Msa = new Language("", "msa", "");
    public static readonly Language Mul = new Language("", "mul", "Multiple languages");
    public static readonly Language Mun = new Language("", "mun", "Munda languages");
    public static readonly Language Mus = new Language("", "mus", "Creek");
    public static readonly Language Mwl = new Language("", "mwl", "Mirandese");
    public static readonly Language Mwr = new Language("", "mwr", "Marwari");
    public static readonly Language Mya = new Language("", "mya", "");
    public static readonly Language Myn = new Language("", "myn", "Mayan languages");
    public static readonly Language Myv = new Language("", "myv", "Erzya");


    public static readonly Language Nah = new Language("", "nah", "Nahuatl languages");
    public static readonly Language Nai = new Language("", "nai", "North American Indian languages");
    public static readonly Language Nap = new Language("", "nap", "Neapolitan");
    public static readonly Language Nau = new Language("na", "nau", "Nauru");
    public static readonly Language Nav = new Language("nv", "nav", "Navajo; Navaho");
    public static readonly Language Nbl = new Language("nr", "nbl", "Ndebele, South; South Ndebele");
    public static readonly Language Nde = new Language("nd", "nde", "Ndebele, North; North Ndebele");
    public static readonly Language Ndo = new Language("ng", "ndo", "Ndonga");
    public static readonly Language Nds = new Language("", "nds", "Low German; Low Saxon; German, Low; Saxon, Low");
    public static readonly Language Nep = new Language("ne", "nep", "Nepali");
    public static readonly Language NewLang = new Language("", "new", "Nepal Bhasa; Newari");
    public static readonly Language Nia = new Language("", "nia", "Nias");
    public static readonly Language Nic = new Language("", "nic", "Niger-Kordofanian languages");
    public static readonly Language Niu = new Language("", "niu", "Niuean");
    public static readonly Language Dut = new Language("nl", "dut", "Dutch; Flemish");
    public static readonly Language Nno = new Language("nn", "nno", "Norwegian Nynorsk; Nynorsk, Norwegian");
    public static readonly Language Nob = new Language("nb", "nob", "Bokmål, Norwegian; Norwegian Bokmål");
    public static readonly Language Nog = new Language("", "nog", "Nogai");
    public static readonly Language Non = new Language("", "non", "Norse, Old");
    public static readonly Language Nor = new Language("no", "nor", "Norwegian");
    public static readonly Language Nqo = new Language("", "nqo", "N'Ko");
    public static readonly Language Nso = new Language("", "nso", "Pedi; Sepedi; Northern Sotho");
    public static readonly Language Nub = new Language("", "nub", "Nubian languages");
    public static readonly Language Nwc = new Language("", "nwc", "Classical Newari; Old Newari; Classical Nepal Bhasa");
    public static readonly Language Nya = new Language("ny", "nya", "Chichewa; Chewa; Nyanja");
    public static readonly Language Nym = new Language("", "nym", "Nyamwezi");
    public static readonly Language Nyn = new Language("", "nyn", "Nyankole");
    public static readonly Language Nyo = new Language("", "nyo", "Nyoro");
    public static readonly Language Nzi = new Language("", "nzi", "Nzima");

    public static readonly Language Oci = new Language("oc", "oci", "Occitan (post 1500)");
    public static readonly Language Oji = new Language("oj", "oji", "Ojibwa");
    public static readonly Language Ori = new Language("or", "ori", "Oriya");
    public static readonly Language Orm = new Language("om", "orm", "Oromo");
    public static readonly Language Osa = new Language("", "osa", "Osage");
    public static readonly Language Oss = new Language("os", "oss", "Ossetian; Ossetic");
    public static readonly Language Ota = new Language("", "ota", "Turkish, Ottoman (1500-1928)");
    public static readonly Language Oto = new Language("", "oto", "Otomian languages");

    public static readonly Language Paa = new Language("", "paa", "Papuan languages");
    public static readonly Language Pag = new Language("", "pag", "Pangasinan");
    public static readonly Language Pal = new Language("", "pal", "Pahlavi");
    public static readonly Language Pam = new Language("", "pam", "Pampanga; Kapampangan");
    public static readonly Language Pan = new Language("pa", "pan", "Panjabi; Punjabi");
    public static readonly Language Pap = new Language("", "pap", "Papiamento");
    public static readonly Language Pau = new Language("", "pau", "Palauan");
    public static readonly Language Peo = new Language("", "peo", "Persian, Old (ca.600-400 B.C.)");
    public static readonly Language Phi = new Language("", "phi", "Philippine languages");
    public static readonly Language Phn = new Language("", "phn", "Phoenician");
    public static readonly Language Pli = new Language("pi", "pli", "Pali");
    public static readonly Language Pol = new Language("pl", "pol", "Polish");
    public static readonly Language Pon = new Language("", "pon", "Pohnpeian");
    public static readonly Language Por = new Language("pt", "por", "Portuguese");
    public static readonly Language Pra = new Language("", "pra", "Prakrit languages");
    public static readonly Language Pro = new Language("", "pro", "Provençal, Old (to 1500);Occitan, Old (to 1500)");
    public static readonly Language Pus = new Language("ps", "pus", "Pushto; Pashto");

    public static readonly Language QaaQtz = new Language("", "qaa-qtz", "Reserved for local use");
    public static readonly Language Que = new Language("qu", "que", "Quechua");
    public static readonly Language Raj = new Language("", "raj", "Rajasthani");
    public static readonly Language Rap = new Language("", "rap", "Rapanui");
    public static readonly Language Rar = new Language("", "rar", "Rarotongan; Cook Islands Maori");
    public static readonly Language Roa = new Language("", "roa", "Romance languages");
    public static readonly Language Roh = new Language("rm", "roh", "Romansh");
    public static readonly Language Rom = new Language("", "rom", "Romany");
    public static readonly Language RumB = new Language("ro", "rum", "Romanian; Moldavian; Moldovan");
    public static readonly Language RonT = new Language("", "ron", "");
    public static readonly Language Run = new Language("rn", "run", "Rundi");
    public static readonly Language Rup = new Language("", "rup", "Aromanian; Arumanian; Macedo-Romanian");
    public static readonly Language Rus = new Language("ru", "rus", "Russian");

    public static readonly Language Sad = new Language("", "sad", "Sandawe");
    public static readonly Language Sag = new Language("sg", "sag", "Sango");
    public static readonly Language Sah = new Language("", "sah", "Yakut");
    public static readonly Language Sai = new Language("", "sai", "South American Indian languages");
    public static readonly Language Sal = new Language("", "sal", "Salishan languages");
    public static readonly Language Sam = new Language("", "sam", "Samaritan Aramaic");
    public static readonly Language San = new Language("sa", "san", "Sanskrit");
    public static readonly Language Sas = new Language("", "sas", "Sasak");
    public static readonly Language Sat = new Language("", "sat", "Santali");
    public static readonly Language Scn = new Language("", "scn", "Sicilian");
    public static readonly Language Sco = new Language("", "sco", "Scots");
    public static readonly Language Sel = new Language("", "sel", "Selkup");
    public static readonly Language Sem = new Language("", "sem", "Semitic languages");
    public static readonly Language Sga = new Language("", "sga", "Irish, Old (to 900)");
    public static readonly Language Sgn = new Language("", "sgn", "Sign Languages");
    public static readonly Language Shn = new Language("", "shn", "Shan");
    public static readonly Language Sid = new Language("", "sid", "Sidamo");
    public static readonly Language Sin = new Language("si", "sin", "Sinhala; Sinhalese");
    public static readonly Language Sio = new Language("", "sio", "Siouan languages");
    public static readonly Language Sit = new Language("", "sit", "Sino-Tibetan languages");
    public static readonly Language Sla = new Language("", "sla", "Slavic languages");
    public static readonly Language SloB = new Language("sk", "slo", "Slovak");
    public static readonly Language SlkT = new Language("", "slk", "");
    public static readonly Language Slv = new Language("sl", "slv", "Slovenian");
    public static readonly Language Sma = new Language("", "sma", "Southern Sami");
    public static readonly Language Sme = new Language("se", "sme", "Northern Sami");
    public static readonly Language Smi = new Language("", "smi", "Sami languages");
    public static readonly Language Smj = new Language("", "smj", "Lule Sami");
    public static readonly Language Smn = new Language("", "smn", "Inari Sami");
    public static readonly Language Smo = new Language("sm", "smo", "Samoan");
    public static readonly Language Sms = new Language("", "sms", "Skolt Sami");
    public static readonly Language Sna = new Language("sn", "sna", "Shona");
    public static readonly Language Sind = new Language("sd", "snd", "Sindhi");
    public static readonly Language Snk = new Language("", "snk", "Soninke");
    public static readonly Language Sog = new Language("", "sog", "Sogdian");
    public static readonly Language Som = new Language("so", "som", "Somali");
    public static readonly Language Son = new Language("", "son", "Songhai languages");
    public static readonly Language Sot = new Language("st", "sot", "Sotho, Southern");
    public static readonly Language Spa = new Language("es", "spa", "Spanish; Castilian");
    public static readonly Language Srd = new Language("sc", "srd", "Sardinian");
    public static readonly Language Srn = new Language("", "srn", "Sranan Tongo");
    public static readonly Language Srp = new Language("sr", "srp", "Serbian");
    public static readonly Language Srr = new Language("", "srr", "Serer");
    public static readonly Language Ssa = new Language("", "ssa", "Nilo-Saharan languages");
    public static readonly Language Ssw = new Language("ss", "ssw", "Swati");
    public static readonly Language Suk = new Language("", "suk", "Sukuma");
    public static readonly Language Sun = new Language("su", "sun", "Sundanese");
    public static readonly Language Sus = new Language("", "sus", "Susu");
    public static readonly Language Sux = new Language("", "sux", "Sumerian");
    public static readonly Language Swa = new Language("sw", "swa", "Swahili");
    public static readonly Language Swe = new Language("sv", "swe", "Swedish");
    public static readonly Language Syc = new Language("", "syc", "Classical Syriac");
    public static readonly Language Syr = new Language("", "syr", "Syriac");

    public static readonly Language Tah = new Language("ty", "tah", "Tahitian");
    public static readonly Language Tai = new Language("", "tai", "Tai languages");
    public static readonly Language Tam = new Language("ta", "tam", "Tamil");
    public static readonly Language Tat = new Language("tt", "tat", "Tatar");
    public static readonly Language Tel = new Language("te", "tel", "Telugu");
    public static readonly Language Tem = new Language("", "tem", "Timne");
    public static readonly Language Ter = new Language("", "ter", "Tereno");
    public static readonly Language Tet = new Language("", "tet", "Tetum");
    public static readonly Language Tgk = new Language("tg", "tgk", "Tajik");
    public static readonly Language Tgl = new Language("tl", "tgl", "Tagalog");
    public static readonly Language Tha = new Language("th", "tha", "Thai");
    public static readonly Language Tig = new Language("", "tig", "Tigre");
    public static readonly Language Tir = new Language("ti", "tir", "Tigrinya");
    public static readonly Language Tiv = new Language("", "tiv", "Tiv");
    public static readonly Language Tok = new Language("", "tkl", "Tokelau");
    public static readonly Language Tlh = new Language("", "tlh", "Klingon; tlhIngan-Hol");
    public static readonly Language Tli = new Language("", "tli", "Tlingit");
    public static readonly Language Tmh = new Language("", "tmh", "Tamashek");
    public static readonly Language Tog = new Language("", "tog", "Tonga (Nyasa)");
    public static readonly Language Ton = new Language("to", "ton", "Tonga (Tonga Islands)");
    public static readonly Language Tpi = new Language("", "tpi", "Tok Pisin");
    public static readonly Language Tsi = new Language("", "tsi", "Tsimshian");
    public static readonly Language Tsn = new Language("tn", "tsn", "Tswana");
    public static readonly Language Tso = new Language("ts", "tso", "Tsonga");
    public static readonly Language Tuk = new Language("tk", "tuk", "Turkmen");
    public static readonly Language Tum = new Language("", "tum", "Tumbuka");
    public static readonly Language Tup = new Language("", "tup", "Tupi languages");
    public static readonly Language Tur = new Language("tr", "tur", "Turkish");
    public static readonly Language Tut = new Language("", "tut", "Altaic languages");
    public static readonly Language Tvl = new Language("", "tvl", "Tuvalu");
    public static readonly Language Twi = new Language("tw", "twi", "Twi");
    public static readonly Language Tyv = new Language("", "tyv", "Tuvinian");

    public static readonly Language Udm = new Language("", "udm", "Udmurt");
    public static readonly Language Uga = new Language("", "uga", "Ugaritic");
    public static readonly Language Uig = new Language("ug", "uig", "Uighur; Uyghur");
    public static readonly Language Ukr = new Language("uk", "ukr", "Ukrainian");
    public static readonly Language Umb = new Language("", "umb", "Umbundu");
    public static readonly Language Und = new Language("", "und", "Undetermined");
    public static readonly Language Urd = new Language("ur", "urd", "Urdu");
    public static readonly Language Uzb = new Language("uz", "uzb", "Uzbek");

    public static readonly Language Vai = new Language("", "vai", "Vai");
    public static readonly Language Ven = new Language("ve", "ven", "Venda");
    public static readonly Language Vie = new Language("vi", "vie", "Vietnamese");
    public static readonly Language Vol = new Language("vo", "vol", "Volapük");
    public static readonly Language Vot = new Language("", "vot", "Votic");
    public static readonly Language Wak = new Language("", "wak", "Wakashan languages");
    public static readonly Language Wal = new Language("", "wal", "Wolaitta; Wolaytta");
    public static readonly Language War = new Language("", "war", "Waray");
    public static readonly Language Was = new Language("", "was", "Washo");
    public static readonly Language Wen = new Language("", "wen", "Sorbian languages");
    public static readonly Language Wln = new Language("wa", "wln", "Walloon");
    public static readonly Language Wol = new Language("wo", "wol", "Wolof");


    public static readonly Language Xal = new Language("", "xal", "Kalmyk; Oirat");
    public static readonly Language Xho = new Language("xh", "xho", "Xhosa");
    public static readonly Language Yao = new Language("", "yao", "Yao");
    public static readonly Language Yap = new Language("", "yap", "Yapese");
    public static readonly Language Yid = new Language("yi", "yid", "Yiddish");
    public static readonly Language Yor = new Language("yo", "yor", "Yoruba");
    public static readonly Language Ypk = new Language("", "ypk", "Yupik languages");
    public static readonly Language Zap = new Language("", "zap", "Zapotec");
    public static readonly Language Zbl = new Language("", "zbl", "Blissymbols; Blissymbolics; Bliss");
    public static readonly Language Zen = new Language("", "zen", "Zenaga");
    public static readonly Language Zgh = new Language("", "zgh", "Standard Moroccan Tamazight");
    public static readonly Language Zha = new Language("za", "zha", "Zhuang; Chuang");
    public static readonly Language Znd = new Language("", "znd", "Zande languages");
    public static readonly Language Zul = new Language("zu", "zul", "Zulu");
    public static readonly Language Zun = new Language("", "zun", "Zuni");
    public static readonly Language Zxx = new Language("", "zxx", "No linguistic content; Not applicable");
    public static readonly Language Zza = new Language("", "zza", "Zaza; Dimili; Dimli; Kirdki; Kirmanjki; Zazaki");
    #endregion

    /// <summary>
    /// Represents an undefined language.
    /// </summary>
    public static readonly Language None = new Language(string.Empty, string.Empty, string.Empty);

    // Static dictionaries for fast lookups by language codes.
    public static readonly IReadOnlyDictionary<string, Language> Alpha2Codes = CreateAlpha2Codes();
    public static readonly IReadOnlyDictionary<string, Language> Alpha3Codes = CreateAlpha3Codes();

    /// <summary>
    /// Gets the 2-letter language code.
    /// </summary>
    public string Alpha2Code { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the 3-letter language code.
    /// </summary>
    public string Alpha3Code { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the name of the language.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Private constructor to initialize a Language instance.
    /// </summary>
    /// <param name="alpha2Code">The 2-letter language code.</param>
    /// <param name="alpha3Code">The 3-letter language code.</param>
    /// <param name="name">The language name.</param>
    private Language(string alpha2Code, string alpha3Code, string name)
    {
        // Normalize codes to lower-case.
        Alpha2Code = alpha2Code.ToLowerInvariant();
        Alpha3Code = alpha3Code.ToLowerInvariant();
        Name = name;
    }

    #region Validation Methods

    /// <summary>
    /// Determines whether the provided alpha-2 code is valid.
    /// </summary>
    /// <param name="code">A 2-letter language code.</param>
    /// <returns>
    /// True if the code is not null or empty, normalized to lower-case, and exists in the alpha-2 lookup dictionary; otherwise, false.
    /// </returns>
    public static bool IsValidAlpha2Code(string code)
    {
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();
            return Alpha2Codes.ContainsKey(code);
        }
        return false;
    }

    /// <summary>
    /// Determines whether the provided alpha-3 code is valid.
    /// </summary>
    /// <param name="code">A 3-letter language code.</param>
    /// <returns>
    /// True if the code is not null or empty, normalized to lower-case, and exists in the alpha-3 lookup dictionary; otherwise, false.
    /// </returns>
    public static bool IsValidAlpha3Code(string code)
    {
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();
            return Alpha3Codes.ContainsKey(code);
        }
        return false;
    }

    /// <summary>
    /// Determines whether the provided language code (either alpha-2 or alpha-3) is valid.
    /// </summary>
    /// <param name="code">A language code in either 2-letter or 3-letter format.</param>
    /// <returns>
    /// True if the code is valid as either an alpha-2 or alpha-3 code; otherwise, false.
    /// </returns>
    public static bool IsValidCode(string code)
    {
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();
            return Alpha2Codes.ContainsKey(code) || Alpha3Codes.ContainsKey(code);
        }
        return false;
    }

    #endregion

    #region Retrieval Methods

    /// <summary>
    /// Retrieves the Language instance corresponding to the specified alpha-2 code.
    /// </summary>
    /// <param name="code">A 2-letter language code.</param>
    /// <param name="paramName">The name of the parameter for error messaging.</param>
    /// <returns>The Language instance associated with the provided alpha-2 code.</returns>
    /// <exception cref="ApplicationException">Thrown if the language is not found or if the code is null/empty.</exception>
    public static Language FromAlpha2Code(
        string code,
        string paramName = null)
    {
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();

            if(Alpha2Codes.ContainsKey(code))
            {
                return Alpha2Codes[code];
            }

            throw new ApplicationException($"Language with code '{code}' is not supported for: {paramName}");
        }
        throw new ApplicationException($"Language with empty code is not supported for: {paramName}");
    }

    /// <summary>
    /// Retrieves the Language instance corresponding to the specified alpha-3 code.
    /// </summary>
    /// <param name="code">A 3-letter language code.</param>
    /// <param name="paramName">The name of the parameter for error messaging.</param>
    /// <returns>The Language instance associated with the provided alpha-3 code.</returns>
    /// <exception cref="ApplicationException">Thrown if the language is not found or if the code is null/empty.</exception>
    public static Language FromAlpha3Code(
        string code,
        string paramName = null)
    {
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();

            if(Alpha3Codes.ContainsKey(code))
            {
                return Alpha3Codes[code];
            }
            throw new ApplicationException($"Language with code '{code}' is not supported for: {paramName}");
        }
        throw new ApplicationException($"Language with empty code is not supported for: {paramName}");
    }

    #endregion

    #region Try-Get Methods

    /// <summary>
    /// Attempts to retrieve the Language instance corresponding to the specified alpha-2 code.
    /// </summary>
    /// <param name="code">A 2-letter language code.</param>
    /// <param name="language">
    /// When this method returns, contains the Language instance if found; otherwise, the 'None' instance.
    /// </param>
    /// <returns>True if a language with the specified alpha-2 code is found; otherwise, false.</returns>
    public static bool TryGetLanguageByAlpha2Code(string code, out Language language)
    {
        language = None;
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();
            return Alpha2Codes.TryGetValue(code, out language);
        }
        return false;
    }

    /// <summary>
    /// Attempts to retrieve the Language instance corresponding to the specified alpha-3 code.
    /// </summary>
    /// <param name="code">A 3-letter language code.</param>
    /// <param name="language">
    /// When this method returns, contains the Language instance if found; otherwise, the 'None' instance.
    /// </param>
    /// <returns>True if a language with the specified alpha-3 code is found; otherwise, false.</returns>
    public static bool TryGetLanguageByAlpha3Code(string code, out Language language)
    {
        language = None;
        if(!string.IsNullOrEmpty(code))
        {
            code = code.ToLowerInvariant();
            return Alpha3Codes.TryGetValue(code, out language);
        }
        return false;
    }

    #endregion

    #region Listing and Parsing Methods

    /// <summary>
    /// Retrieves all defined Language instances.
    /// </summary>
    /// <returns>An enumerable collection of all available Language instances.</returns>
    public static IEnumerable<Language> GetAllLanguages()
    {
        // Return distinct languages from the alpha-2 lookup dictionary.
        return Alpha2Codes.Values.Distinct();
    }

    /// <summary>
    /// Gets the total number of defined languages.
    /// </summary>
    public static int LanguageCount => Alpha2Codes.Count;

    /// <summary>
    /// Retrieves all available alpha-2 language codes.
    /// </summary>
    /// <returns>An enumerable collection of 2-letter language codes.</returns>
    public static IEnumerable<string> GetAllAlpha2Codes()
    {
        return Alpha2Codes.Keys;
    }

    /// <summary>
    /// Retrieves all available alpha-3 language codes.
    /// </summary>
    /// <returns>An enumerable collection of 3-letter language codes.</returns>
    public static IEnumerable<string> GetAllAlpha3Codes()
    {
        return Alpha3Codes.Keys;
    }

    /// <summary>
    /// Parses an input string to retrieve a corresponding Language instance.
    /// The input can be either an alpha-2 or alpha-3 language code.
    /// </summary>
    /// <param name="input">A language identifier in string format.</param>
    /// <returns>The Language instance associated with the input code.</returns>
    /// <exception cref="ArgumentException">Thrown if the input is null, empty, or does not match any language.</exception>
    public static Language ParseLanguage(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input cannot be null or empty.", nameof(input));
        }
        input = input.ToLowerInvariant();

        if(input.Length == 2 && IsValidAlpha2Code(input))
        {
            return FromAlpha2Code(input, nameof(input));
        }
        if(input.Length == 3 && IsValidAlpha3Code(input))
        {
            return FromAlpha3Code(input);
        }
        throw new ArgumentException($"Language with code '{input}' not found.", nameof(input));
    }

    #endregion

    #region Internal Dictionary Creation

    /// <summary>
    /// Creates a read-only dictionary that maps alpha-2 language codes to Language instances.
    /// Uses reflection to retrieve all static Language fields.
    /// </summary>
    /// <returns>
    /// An IReadOnlyDictionary where the key is the alpha-2 code and the value is the Language instance.
    /// </returns>
    private static IReadOnlyDictionary<string, Language> CreateAlpha2Codes()
    {
        var type = typeof(Language);
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Static)
                         .Where(f => f.FieldType == typeof(Language))
                         .Select(f => (Language)f.GetValue(default));
        return fields.ToDictionary(f => f.Alpha2Code);
    }

    /// <summary>
    /// Creates a read-only dictionary that maps alpha-3 language codes to Language instances.
    /// Uses reflection to retrieve all static Language fields.
    /// </summary>
    /// <returns>
    /// An IReadOnlyDictionary where the key is the alpha-3 code and the value is the Language instance.
    /// </returns>
    private static IReadOnlyDictionary<string, Language> CreateAlpha3Codes()
    {
        var type = typeof(Language);
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Static)
                         .Where(f => f.FieldType == typeof(Language))
                         .Select(f => (Language)f.GetValue(default));
        return fields.ToDictionary(f => f.Alpha3Code);
    }

    #endregion
}
}