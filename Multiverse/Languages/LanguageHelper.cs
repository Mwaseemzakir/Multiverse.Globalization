using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiverse.Globalization.Languages;

/// <summary>
/// Provides access to all ISO 639 languages as static readonly fields and lookup maps.
/// </summary>
public static class LanguageHelper
{
    /// <summary>The Afar language.</summary>
    public static readonly Language Afar = new Language("aa", "aar", "Afar");

    /// <summary>The Abkhazian language.</summary>
    public static readonly Language Abkhazian = new Language("ab", "abk", "Abkhazian");
    /// <summary>The Afrikaans language.</summary>
    public static readonly Language Afrikaans = new Language("af", "afr", "Afrikaans");
    /// <summary>The Akan language.</summary>
    public static readonly Language Akan = new Language("ak", "aka", "Akan");
    /// <summary>The Albanian language.</summary>
    public static readonly Language Albanian = new Language("sq", "alb", "Albanian");
    /// <summary>The Amharic language.</summary>
    public static readonly Language Amharic = new Language("am", "amh", "Amharic");
    /// <summary>The English Old language.</summary>
    public static readonly Language EnglishOld = new Language("", "ang", "English, Old (ca.450-1100)");
    /// <summary>The Angika language.</summary>
    public static readonly Language Angika = new Language("", "anp", "Angika");
    /// <summary>The Apache Languages language.</summary>
    public static readonly Language ApacheLanguages = new Language("", "apa", "Apache languages");
    /// <summary>The Arabic language.</summary>
    public static readonly Language Arabic = new Language("ar", "ara", "Arabic");
    /// <summary>The Official Aramaic language.</summary>
    public static readonly Language OfficialAramaic = new Language("", "arc", "Official Aramaic (700-300 BCE); Imperial Aramaic (700-300 BCE)");
    /// <summary>The Aragonese language.</summary>
    public static readonly Language Aragonese = new Language("an", "arg", "Aragonese");
    /// <summary>The Armenian language.</summary>
    public static readonly Language Armenian = new Language("hy", "arm", "Armenian");
    /// <summary>The Mapudungun language.</summary>
    public static readonly Language Mapudungun = new Language("", "arn", "Mapudungun; Mapuche");
    /// <summary>The Arapaho language.</summary>
    public static readonly Language Arapaho = new Language("", "arp", "Arapaho");
    /// <summary>The Artificial Languages language.</summary>
    public static readonly Language ArtificialLanguages = new Language("", "art", "Artificial languages");
    /// <summary>The Arawak language.</summary>
    public static readonly Language Arawak = new Language("", "arw", "Arawak");
    /// <summary>The Assamese language.</summary>
    public static readonly Language Assamese = new Language("as", "asm", "Assamese");
    /// <summary>The Asturian language.</summary>
    public static readonly Language Asturian = new Language("", "ast", "Asturian; Bable; Leonese; Asturleonese");
    /// <summary>The Athapascan Languages language.</summary>
    public static readonly Language AthapascanLanguages = new Language("", "ath", "Athapascan languages");
    /// <summary>The Australian Languages language.</summary>
    public static readonly Language AustralianLanguages = new Language("", "aus", "Australian languages");
    /// <summary>The Avaric language.</summary>
    public static readonly Language Avaric = new Language("av", "ava", "Avaric");
    /// <summary>The Avestan language.</summary>
    public static readonly Language Avestan = new Language("ae", "ave", "Avestan");
    /// <summary>The Awadhi language.</summary>
    public static readonly Language Awadhi = new Language("", "awa", "Awadhi");
    /// <summary>The Aymara language.</summary>
    public static readonly Language Aymara = new Language("ay", "aym", "Aymara");
    /// <summary>The Azerbaijani language.</summary>
    public static readonly Language Azerbaijani = new Language("az", "aze", "Azerbaijani");

    /// <summary>The Banda Languages language.</summary>
    public static readonly Language BandaLanguages = new Language("", "bad", "Banda languages");
    /// <summary>The Bamileke Languages language.</summary>
    public static readonly Language BamilekeLanguages = new Language("", "bai", "Bamileke languages");
    /// <summary>The Bashkir language.</summary>
    public static readonly Language Bashkir = new Language("ba", "bak", "Bashkir");
    /// <summary>The Baluchi language.</summary>
    public static readonly Language Baluchi = new Language("", "bal", "Baluchi");
    /// <summary>The Bambara language.</summary>
    public static readonly Language Bambara = new Language("bm", "bam", "Bambara");
    /// <summary>The Balinese language.</summary>
    public static readonly Language Balinese = new Language("", "ban", "Balinese");
    /// <summary>The Basque language.</summary>
    public static readonly Language Basque = new Language("eu", "baq", "Basque");
    /// <summary>The Basa language.</summary>
    public static readonly Language Basa = new Language("", "bas", "Basa");
    /// <summary>The Baltic Languages language.</summary>
    public static readonly Language BalticLanguages = new Language("", "bat", "Baltic languages");
    /// <summary>The Beja language.</summary>
    public static readonly Language Beja = new Language("", "bej", "Beja; Bedawiyet");
    /// <summary>The Belarusian language.</summary>
    public static readonly Language Belarusian = new Language("be", "bel", "Belarusian");
    /// <summary>The Bemba language.</summary>
    public static readonly Language Bemba = new Language("", "bem", "Bemba");
    /// <summary>The Bengali language.</summary>
    public static readonly Language Bengali = new Language("bn", "ben", "Bengali");
    /// <summary>The Berber Languages language.</summary>
    public static readonly Language BerberLanguages = new Language("", "ber", "Berber languages");
    /// <summary>The Bhojpuri language.</summary>
    public static readonly Language Bhojpuri = new Language("", "bho", "Bhojpuri");
    /// <summary>The Bihari Languages language.</summary>
    public static readonly Language BihariLanguages = new Language("bh", "bih", "Bihari languages");
    /// <summary>The Bikol language.</summary>
    public static readonly Language Bikol = new Language("", "bik", "Bikol");
    /// <summary>The Bini language.</summary>
    public static readonly Language Bini = new Language("", "bin", "Bini; Edo");
    /// <summary>The Bislama language.</summary>
    public static readonly Language Bislama = new Language("bi", "bis", "Bislama");
    /// <summary>The Siksika language.</summary>
    public static readonly Language Siksika = new Language("", "bla", "Siksika");
    /// <summary>The Bantu Languages language.</summary>
    public static readonly Language BantuLanguages = new Language("", "bnt", "Bantu languages");
    /// <summary>The Tibetan language.</summary>
    public static readonly Language Tibetan = new Language("bo", "tib", "Tibetan");
    /// <summary>The Bosnian language.</summary>
    public static readonly Language Bosnian = new Language("bs", "bos", "Bosnian");
    /// <summary>The Braj language.</summary>
    public static readonly Language Braj = new Language("", "bra", "Braj");
    /// <summary>The Breton language.</summary>
    public static readonly Language Breton = new Language("br", "bre", "Breton");
    /// <summary>The Batak Languages language.</summary>
    public static readonly Language BatakLanguages = new Language("", "btk", "Batak languages");
    /// <summary>The Buriat language.</summary>
    public static readonly Language Buriat = new Language("", "bua", "Buriat");
    /// <summary>The Buginese language.</summary>
    public static readonly Language Buginese = new Language("", "bug", "Buginese");
    /// <summary>The Bulgarian language.</summary>
    public static readonly Language Bulgarian = new Language("bg", "bul", "Bulgarian");
    /// <summary>The Burmese language.</summary>
    public static readonly Language Burmese = new Language("my", "bur", "Burmese");
    /// <summary>The Blin language.</summary>
    public static readonly Language Blin = new Language("", "byn", "Blin; Bilin");

    /// <summary>The Caddo language.</summary>
    public static readonly Language Caddo = new Language("", "cad", "Caddo");
    /// <summary>The Central American Indian Languages language.</summary>
    public static readonly Language CentralAmericanIndianLanguages = new Language("", "cai", "Central American Indian languages");
    /// <summary>The Galibi Carib language.</summary>
    public static readonly Language GalibiCarib = new Language("", "car", "Galibi Carib");
    /// <summary>The Catalan language.</summary>
    public static readonly Language Catalan = new Language("ca", "cat", "Catalan; Valencian");
    /// <summary>The Caucasian Languages language.</summary>
    public static readonly Language CaucasianLanguages = new Language("", "cau", "Caucasian languages");
    /// <summary>The Cebuano language.</summary>
    public static readonly Language Cebuano = new Language("", "ceb", "Cebuano");
    /// <summary>The Celtic Languages language.</summary>
    public static readonly Language CelticLanguages = new Language("", "cel", "Celtic languages");
    /// <summary>The Czech language.</summary>
    public static readonly Language Czech = new Language("cs", "cze", "Czech");
    /// <summary>The Chamorro language.</summary>
    public static readonly Language Chamorro = new Language("ch", "cha", "Chamorro");
    /// <summary>The Chibcha language.</summary>
    public static readonly Language Chibcha = new Language("", "chb", "Chibcha");
    /// <summary>The Chechen language.</summary>
    public static readonly Language Chechen = new Language("ce", "che", "Chechen");
    /// <summary>The Chagatai language.</summary>
    public static readonly Language Chagatai = new Language("", "chg", "Chagatai");
    /// <summary>The Chinese language.</summary>
    public static readonly Language Chinese = new Language("zh", "chi", "Chinese");
    /// <summary>The Chuukese language.</summary>
    public static readonly Language Chuukese = new Language("", "chk", "Chuukese");
    /// <summary>The Mari language.</summary>
    public static readonly Language Mari = new Language("", "chm", "Mari");
    /// <summary>The Chinook Jargon language.</summary>
    public static readonly Language ChinookJargon = new Language("", "chn", "Chinook jargon");
    /// <summary>The Choctaw language.</summary>
    public static readonly Language Choctaw = new Language("", "cho", "Choctaw");
    /// <summary>The Chipewyan language.</summary>
    public static readonly Language Chipewyan = new Language("", "chp", "Chipewyan; Dene Suline");
    /// <summary>The Cherokee language.</summary>
    public static readonly Language Cherokee = new Language("", "chr", "Cherokee");
    /// <summary>The Church Slavic language.</summary>
    public static readonly Language ChurchSlavic = new Language("cu", "chu", "Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic");
    /// <summary>The Chuvash language.</summary>
    public static readonly Language Chuvash = new Language("cv", "chv", "Chuvash");
    /// <summary>The Cheyenne language.</summary>
    public static readonly Language Cheyenne = new Language("", "chy", "Cheyenne");
    /// <summary>The Chamic Languages language.</summary>
    public static readonly Language ChamicLanguages = new Language("", "cmc", "Chamic languages");
    /// <summary>The Montenegrin language.</summary>
    public static readonly Language Montenegrin = new Language("", "cnr", "Montenegrin");
    /// <summary>The Coptic language.</summary>
    public static readonly Language Coptic = new Language("", "cop", "Coptic");
    /// <summary>The Cornish language.</summary>
    public static readonly Language Cornish = new Language("kw", "cor", "Cornish");
    /// <summary>The Corsican language.</summary>
    public static readonly Language Corsican = new Language("co", "cos", "Corsican");
    /// <summary>The Creoles And Pidgins English Based language.</summary>
    public static readonly Language CreolesAndPidginsEnglishBased = new Language("", "cpe", "Creoles and pidgins, English based");
    /// <summary>The Creoles And Pidgins French Based language.</summary>
    public static readonly Language CreolesAndPidginsFrenchBased = new Language("", "cpf", "Creoles and pidgins, French-based");
    /// <summary>The Creoles And Pidgins Portuguese Based language.</summary>
    public static readonly Language CreolesAndPidginsPortugueseBased = new Language("", "cpp", "Creoles and pidgins, Portuguese-based");
    /// <summary>The Cree language.</summary>
    public static readonly Language Cree = new Language("cr", "cre", "Cree");
    /// <summary>The Crimean Tatar language.</summary>
    public static readonly Language CrimeanTatar = new Language("", "crh", "Crimean Tatar; Crimean Turkish");
    /// <summary>The Creoles And Pidgins language.</summary>
    public static readonly Language CreolesAndPidgins = new Language("", "crp", "Creoles and pidgins");
    /// <summary>The Kashubian language.</summary>
    public static readonly Language Kashubian = new Language("", "csb", "Kashubian");
    /// <summary>The Cushitic Languages language.</summary>
    public static readonly Language CushiticLanguages = new Language("", "cus", "Cushitic languages");
    /// <summary>The Welsh language.</summary>
    public static readonly Language Welsh = new Language("cy", "wel", "Welsh");
    /// <summary>The Dakota language.</summary>
    public static readonly Language Dakota = new Language("", "dak", "Dakota");
    /// <summary>The Danish language.</summary>
    public static readonly Language Danish = new Language("da", "dan", "Danish");
    /// <summary>The Dargwa language.</summary>
    public static readonly Language Dargwa = new Language("", "dar", "Dargwa");
    /// <summary>The Land Dayak Languages language.</summary>
    public static readonly Language LandDayakLanguages = new Language("", "day", "Land Dayak languages");
    /// <summary>The Delaware language.</summary>
    public static readonly Language Delaware = new Language("", "del", "Delaware");
    /// <summary>The Slave language.</summary>
    public static readonly Language Slave = new Language("", "den", "Slave (Athapascan)");
    /// <summary>The German language.</summary>
    public static readonly Language German = new Language("de", "ger", "German");
    /// <summary>The Dogrib language.</summary>
    public static readonly Language Dogrib = new Language("", "dgr", "Dogrib");
    /// <summary>The Dinka language.</summary>
    public static readonly Language Dinka = new Language("", "din", "Dinka");
    /// <summary>The Divehi language.</summary>
    public static readonly Language Divehi = new Language("dv", "div", "Divehi; Dhivehi; Maldivian");
    /// <summary>The Dogri language.</summary>
    public static readonly Language Dogri = new Language("", "doi", "Dogri");
    /// <summary>The Dravidian Languages language.</summary>
    public static readonly Language DravidianLanguages = new Language("", "dra", "Dravidian languages");
    /// <summary>The Lower Sorbian language.</summary>
    public static readonly Language LowerSorbian = new Language("", "dsb", "Lower Sorbian");
    /// <summary>The Duala language.</summary>
    public static readonly Language Duala = new Language("", "dua", "Duala");
    /// <summary>The Dutch Middle language.</summary>
    public static readonly Language DutchMiddle = new Language("", "dum", "Dutch, Middle (ca.1050-1350)");
    /// <summary>The Dutch language.</summary>
    public static readonly Language Dutch = new Language("nl", "dut", "Dutch; Flemish");
    /// <summary>The Dyula language.</summary>
    public static readonly Language Dyula = new Language("", "dyu", "Dyula");
    /// <summary>The Dzongkha language.</summary>
    public static readonly Language Dzongkha = new Language("dz", "dzo", "Dzongkha");

    /// <summary>The Efik language.</summary>
    public static readonly Language Efik = new Language("", "efi", "Efik");
    /// <summary>The Egyptian Ancient language.</summary>
    public static readonly Language EgyptianAncient = new Language("", "egy", "Egyptian (Ancient)");
    /// <summary>The Ekajuk language.</summary>
    public static readonly Language Ekajuk = new Language("", "eka", "Ekajuk");
    /// <summary>The Greek Modern language.</summary>
    public static readonly Language GreekModern = new Language("el", "gre", "Greek, Modern (1453-)");
    /// <summary>The Elamite language.</summary>
    public static readonly Language Elamite = new Language("", "elx", "Elamite");
    /// <summary>The English language.</summary>
    public static readonly Language English = new Language("en", "eng", "English");
    /// <summary>The English Middle language.</summary>
    public static readonly Language EnglishMiddle = new Language("", "enm", "English, Middle (1100-1500)");
    /// <summary>The Esperanto language.</summary>
    public static readonly Language Esperanto = new Language("eo", "epo", "Esperanto");
    /// <summary>The Estonian language.</summary>
    public static readonly Language Estonian = new Language("et", "est", "Estonian");
    /// <summary>The Ewe language.</summary>
    public static readonly Language Ewe = new Language("ee", "ewe", "Ewe");
    /// <summary>The Ewondo language.</summary>
    public static readonly Language Ewondo = new Language("", "ewo", "Ewondo");

    /// <summary>The Fang language.</summary>
    public static readonly Language Fang = new Language("", "fan", "Fang");
    /// <summary>The Faroese language.</summary>
    public static readonly Language Faroese = new Language("fo", "fao", "Faroese");
    /// <summary>The Persian language.</summary>
    public static readonly Language Persian = new Language("fa", "per", "Persian");
    /// <summary>The Fanti language.</summary>
    public static readonly Language Fanti = new Language("", "fat", "Fanti");
    /// <summary>The Fijian language.</summary>
    public static readonly Language Fijian = new Language("fj", "fij", "Fijian");
    /// <summary>The Filipino language.</summary>
    public static readonly Language Filipino = new Language("", "fil", "Filipino; Pilipino");
    /// <summary>The Finnish language.</summary>
    public static readonly Language Finnish = new Language("fi", "fin", "Finnish");
    /// <summary>The Finno Ugrian Languages language.</summary>
    public static readonly Language FinnoUgrianLanguages = new Language("", "fiu", "Finno-Ugrian languages");
    /// <summary>The Fon language.</summary>
    public static readonly Language Fon = new Language("", "fon", "Fon");
    /// <summary>The French language.</summary>
    public static readonly Language French = new Language("fr", "fre", "French");
    /// <summary>The French Middle language.</summary>
    public static readonly Language FrenchMiddle = new Language("", "frm", "French, Middle (ca.1400-1600)");
    /// <summary>The French Old language.</summary>
    public static readonly Language FrenchOld = new Language("", "fro", "French, Old (842-ca.1400)");
    /// <summary>The Northern Frisian language.</summary>
    public static readonly Language NorthernFrisian = new Language("", "frr", "Northern Frisian");
    /// <summary>The Eastern Frisian language.</summary>
    public static readonly Language EasternFrisian = new Language("", "frs", "Eastern Frisian");
    /// <summary>The Western Frisian language.</summary>
    public static readonly Language WesternFrisian = new Language("fy", "fry", "Western Frisian");
    /// <summary>The Fulah language.</summary>
    public static readonly Language Fulah = new Language("ff", "ful", "Fulah");
    /// <summary>The Friulian language.</summary>
    public static readonly Language Friulian = new Language("", "fur", "Friulian");

    /// <summary>The Ga language.</summary>
    public static readonly Language Ga = new Language("", "gaa", "Ga");
    /// <summary>The Gayo language.</summary>
    public static readonly Language Gayo = new Language("", "gay", "Gayo");
    /// <summary>The Gbaya language.</summary>
    public static readonly Language Gbaya = new Language("", "gba", "Gbaya");
    /// <summary>The Germanic Languages language.</summary>
    public static readonly Language GermanicLanguages = new Language("", "gem", "Germanic languages");
    /// <summary>The Georgian language.</summary>
    public static readonly Language Georgian = new Language("ka", "geo", "Georgian");
    /// <summary>The Geez language.</summary>
    public static readonly Language Geez = new Language("", "gez", "Geez");
    /// <summary>The Gilbertese language.</summary>
    public static readonly Language Gilbertese = new Language("", "gil", "Gilbertese");
    /// <summary>The Gaelic language.</summary>
    public static readonly Language Gaelic = new Language("gd", "gla", "Gaelic; Scottish Gaelic");
    /// <summary>The Irish language.</summary>
    public static readonly Language Irish = new Language("ga", "gle", "Irish");
    /// <summary>The Galician language.</summary>
    public static readonly Language Galician = new Language("gl", "glg", "Galician");
    /// <summary>The Manx language.</summary>
    public static readonly Language Manx = new Language("gv", "glv", "Manx");
    /// <summary>The German Middle High language.</summary>
    public static readonly Language GermanMiddleHigh = new Language("", "gmh", "German, Middle High (ca.1050-1500)");
    /// <summary>The German Old High language.</summary>
    public static readonly Language GermanOldHigh = new Language("", "goh", "German, Old High (ca.750-1050)");
    /// <summary>The Gondi language.</summary>
    public static readonly Language Gondi = new Language("", "gon", "Gondi");
    /// <summary>The Gorontalo language.</summary>
    public static readonly Language Gorontalo = new Language("", "gor", "Gorontalo");
    /// <summary>The Gothic language.</summary>
    public static readonly Language Gothic = new Language("", "got", "Gothic");
    /// <summary>The Grebo language.</summary>
    public static readonly Language Grebo = new Language("", "grb", "Grebo");
    /// <summary>The Greek Ancient language.</summary>
    public static readonly Language GreekAncient = new Language("", "grc", "Greek, Ancient (to 1453)");
    /// <summary>The Guarani language.</summary>
    public static readonly Language Guarani = new Language("gn", "grn", "Guarani");
    /// <summary>The Swiss German language.</summary>
    public static readonly Language SwissGerman = new Language("", "gsw", "Swiss German; Alemannic; Alsatian");
    /// <summary>The Gujarati language.</summary>
    public static readonly Language Gujarati = new Language("gu", "guj", "Gujarati");
    /// <summary>The Gwichin language.</summary>
    public static readonly Language Gwichin = new Language("", "gwi", "Gwich'in");

    /// <summary>The Haida language.</summary>
    public static readonly Language Haida = new Language("", "hai", "Haida");
    /// <summary>The Haitian language.</summary>
    public static readonly Language Haitian = new Language("ht", "hat", "Haitian; Haitian Creole");
    /// <summary>The Hausa language.</summary>
    public static readonly Language Hausa = new Language("ha", "hau", "Hausa");
    /// <summary>The Hawaiian language.</summary>
    public static readonly Language Hawaiian = new Language("", "haw", "Hawaiian");
    /// <summary>The Hebrew language.</summary>
    public static readonly Language Hebrew = new Language("he", "heb", "Hebrew");
    /// <summary>The Herero language.</summary>
    public static readonly Language Herero = new Language("hz", "her", "Herero");
    /// <summary>The Hiligaynon language.</summary>
    public static readonly Language Hiligaynon = new Language("", "hil", "Hiligaynon");
    /// <summary>The Himachali Languages language.</summary>
    public static readonly Language HimachaliLanguages = new Language("", "him", "Himachali languages; Western Pahari languages");
    /// <summary>The Hindi language.</summary>
    public static readonly Language Hindi = new Language("hi", "hin", "Hindi");
    /// <summary>The Hittite language.</summary>
    public static readonly Language Hittite = new Language("", "hit", "Hittite");
    /// <summary>The Hmong language.</summary>
    public static readonly Language Hmong = new Language("", "hmn", "Hmong; Mong");
    /// <summary>The Hiri Motu language.</summary>
    public static readonly Language HiriMotu = new Language("ho", "hmo", "Hiri Motu");
    /// <summary>The Croatian language.</summary>
    public static readonly Language Croatian = new Language("hr", "hrv", "Croatian");
    /// <summary>The Upper Sorbian language.</summary>
    public static readonly Language UpperSorbian = new Language("", "hsb", "Upper Sorbian");
    /// <summary>The Hungarian language.</summary>
    public static readonly Language Hungarian = new Language("hu", "hun", "Hungarian");
    /// <summary>The Hupa language.</summary>
    public static readonly Language Hupa = new Language("", "hup", "Hupa");

    /// <summary>The Iban language.</summary>
    public static readonly Language Iban = new Language("", "iba", "Iban");
    /// <summary>The Igbo language.</summary>
    public static readonly Language Igbo = new Language("ig", "ibo", "Igbo");
    /// <summary>The Icelandic language.</summary>
    public static readonly Language Icelandic = new Language("is", "ice", "Icelandic");
    /// <summary>The Ido language.</summary>
    public static readonly Language Ido = new Language("io", "ido", "Ido");
    /// <summary>The Sichuan Yi language.</summary>
    public static readonly Language SichuanYi = new Language("ii", "iii", "Sichuan Yi; Nuosu");
    /// <summary>The Ijo Languages language.</summary>
    public static readonly Language IjoLanguages = new Language("", "ijo", "Ijo languages");
    /// <summary>The Inuktitut language.</summary>
    public static readonly Language Inuktitut = new Language("iu", "iku", "Inuktitut");
    /// <summary>The Interlingue language.</summary>
    public static readonly Language Interlingue = new Language("ie", "ile", "Interlingue; Occidental");
    /// <summary>The Iloko language.</summary>
    public static readonly Language Iloko = new Language("", "ilo", "Iloko");
    /// <summary>The Interlingua language.</summary>
    public static readonly Language Interlingua = new Language("ia", "ina", "Interlingua (International Auxiliary Language Association)");
    /// <summary>The Indic Languages language.</summary>
    public static readonly Language IndicLanguages = new Language("", "inc", "Indic languages");
    /// <summary>The Indonesian language.</summary>
    public static readonly Language Indonesian = new Language("id", "ind", "Indonesian");
    /// <summary>The Indo European Languages language.</summary>
    public static readonly Language IndoEuropeanLanguages = new Language("", "ine", "Indo-European languages");
    /// <summary>The Ingush language.</summary>
    public static readonly Language Ingush = new Language("", "inh", "Ingush");
    /// <summary>The Inupiaq language.</summary>
    public static readonly Language Inupiaq = new Language("ik", "ipk", "Inupiaq");
    /// <summary>The Iranian Languages language.</summary>
    public static readonly Language IranianLanguages = new Language("", "ira", "Iranian languages");
    /// <summary>The Iroquoian Languages language.</summary>
    public static readonly Language IroquoianLanguages = new Language("", "iro", "Iroquoian languages");
    /// <summary>The Italian language.</summary>
    public static readonly Language Italian = new Language("it", "ita", "Italian");

    /// <summary>The Javanese language.</summary>
    public static readonly Language Javanese = new Language("jv", "jav", "Javanese");
    /// <summary>The Lojban language.</summary>
    public static readonly Language Lojban = new Language("", "jbo", "Lojban");
    /// <summary>The Japanese language.</summary>
    public static readonly Language Japanese = new Language("ja", "jpn", "Japanese");
    /// <summary>The Judeo Persian language.</summary>
    public static readonly Language JudeoPersian = new Language("", "jpr", "Judeo-Persian");
    /// <summary>The Judeo Arabic language.</summary>
    public static readonly Language JudeoArabic = new Language("", "jrb", "Judeo-Arabic");

    /// <summary>The Kara Kalpak language.</summary>
    public static readonly Language KaraKalpak = new Language("", "kaa", "Kara-Kalpak");
    /// <summary>The Kabyle language.</summary>
    public static readonly Language Kabyle = new Language("", "kab", "Kabyle");
    /// <summary>The Kachin language.</summary>
    public static readonly Language Kachin = new Language("", "kac", "Kachin; Jingpho");
    /// <summary>The Kalaallisut language.</summary>
    public static readonly Language Kalaallisut = new Language("kl", "kal", "Kalaallisut; Greenlandic");
    /// <summary>The Kamba language.</summary>
    public static readonly Language Kamba = new Language("", "kam", "Kamba");
    /// <summary>The Kannada language.</summary>
    public static readonly Language Kannada = new Language("kn", "kan", "Kannada");
    /// <summary>The Karen Languages language.</summary>
    public static readonly Language KarenLanguages = new Language("", "kar", "Karen languages");
    /// <summary>The Kashmiri language.</summary>
    public static readonly Language Kashmiri = new Language("ks", "kas", "Kashmiri");
    /// <summary>The Kanuri language.</summary>
    public static readonly Language Kanuri = new Language("kr", "kau", "Kanuri");
    /// <summary>The Kawi language.</summary>
    public static readonly Language Kawi = new Language("", "kaw", "Kawi");
    /// <summary>The Kazakh language.</summary>
    public static readonly Language Kazakh = new Language("kk", "kaz", "Kazakh");
    /// <summary>The Kabardian language.</summary>
    public static readonly Language Kabardian = new Language("", "kbd", "Kabardian");
    /// <summary>The Khasi language.</summary>
    public static readonly Language Khasi = new Language("", "kha", "Khasi");
    /// <summary>The Khoisan Languages language.</summary>
    public static readonly Language KhoisanLanguages = new Language("", "khi", "Khoisan languages");
    /// <summary>The Central Khmer language.</summary>
    public static readonly Language CentralKhmer = new Language("km", "khm", "Central Khmer");
    /// <summary>The Khotanese language.</summary>
    public static readonly Language Khotanese = new Language("", "kho", "Khotanese; Sakan");
    /// <summary>The Kikuyu language.</summary>
    public static readonly Language Kikuyu = new Language("ki", "kik", "Kikuyu; Gikuyu");
    /// <summary>The Kinyarwanda language.</summary>
    public static readonly Language Kinyarwanda = new Language("rw", "kin", "Kinyarwanda");
    /// <summary>The Kirghiz language.</summary>
    public static readonly Language Kirghiz = new Language("ky", "kir", "Kirghiz; Kyrgyz");
    /// <summary>The Kimbundu language.</summary>
    public static readonly Language Kimbundu = new Language("", "kmb", "Kimbundu");
    /// <summary>The Konkani language.</summary>
    public static readonly Language Konkani = new Language("", "kok", "Konkani");
    /// <summary>The Komi language.</summary>
    public static readonly Language Komi = new Language("kv", "kom", "Komi");
    /// <summary>The Kongo language.</summary>
    public static readonly Language Kongo = new Language("kg", "kon", "Kongo");
    /// <summary>The Korean language.</summary>
    public static readonly Language Korean = new Language("ko", "kor", "Korean");
    /// <summary>The Kosraean language.</summary>
    public static readonly Language Kosraean = new Language("", "kos", "Kosraean");
    /// <summary>The Kpelle language.</summary>
    public static readonly Language Kpelle = new Language("", "kpe", "Kpelle");
    /// <summary>The Karachay Balkar language.</summary>
    public static readonly Language KarachayBalkar = new Language("", "krc", "Karachay-Balkar");
    /// <summary>The Karelian language.</summary>
    public static readonly Language Karelian = new Language("", "krl", "Karelian");
    /// <summary>The Kru Languages language.</summary>
    public static readonly Language KruLanguages = new Language("", "kro", "Kru languages");
    /// <summary>The Kurukh language.</summary>
    public static readonly Language Kurukh = new Language("", "kru", "Kurukh");
    /// <summary>The Kuanyama language.</summary>
    public static readonly Language Kuanyama = new Language("kj", "kua", "Kuanyama; Kwanyama");
    /// <summary>The Kumyk language.</summary>
    public static readonly Language Kumyk = new Language("", "kum", "Kumyk");
    /// <summary>The Kurdish language.</summary>
    public static readonly Language Kurdish = new Language("ku", "kur", "Kurdish");
    /// <summary>The Kutenai language.</summary>
    public static readonly Language Kutenai = new Language("", "kut", "Kutenai");

    /// <summary>The Ladino language.</summary>
    public static readonly Language Ladino = new Language("", "lad", "Ladino");
    /// <summary>The Lahnda language.</summary>
    public static readonly Language Lahnda = new Language("", "lah", "Lahnda");
    /// <summary>The Lamba language.</summary>
    public static readonly Language Lamba = new Language("", "lam", "Lamba");
    /// <summary>The Lao language.</summary>
    public static readonly Language Lao = new Language("lo", "lao", "Lao");
    /// <summary>The Latin language.</summary>
    public static readonly Language Latin = new Language("la", "lat", "Latin");
    /// <summary>The Latvian language.</summary>
    public static readonly Language Latvian = new Language("lv", "lav", "Latvian");
    /// <summary>The Lezghian language.</summary>
    public static readonly Language Lezghian = new Language("", "lez", "Lezghian");
    /// <summary>The Limburgan language.</summary>
    public static readonly Language Limburgan = new Language("li", "lim", "Limburgan; Limburger; Limburgish");
    /// <summary>The Lingala language.</summary>
    public static readonly Language Lingala = new Language("ln", "lin", "Lingala");
    /// <summary>The Lithuanian language.</summary>
    public static readonly Language Lithuanian = new Language("lt", "lit", "Lithuanian");
    /// <summary>The Mongo language.</summary>
    public static readonly Language Mongo = new Language("", "lol", "Mongo");
    /// <summary>The Lozi language.</summary>
    public static readonly Language Lozi = new Language("", "loz", "Lozi");
    /// <summary>The Luxembourgish language.</summary>
    public static readonly Language Luxembourgish = new Language("lb", "ltz", "Luxembourgish; Letzeburgesch");
    /// <summary>The Luba Lulua language.</summary>
    public static readonly Language LubaLulua = new Language("", "lua", "Luba-Lulua");
    /// <summary>The Luba Katanga language.</summary>
    public static readonly Language LubaKatanga = new Language("lu", "lub", "Luba-Katanga");
    /// <summary>The Ganda language.</summary>
    public static readonly Language Ganda = new Language("lg", "lug", "Ganda");
    /// <summary>The Luiseno language.</summary>
    public static readonly Language Luiseno = new Language("", "lui", "Luiseno");
    /// <summary>The Lunda language.</summary>
    public static readonly Language Lunda = new Language("", "lun", "Lunda");
    /// <summary>The Luo language.</summary>
    public static readonly Language Luo = new Language("", "luo", "Luo (Kenya and Tanzania)");
    /// <summary>The Lushai language.</summary>
    public static readonly Language Lushai = new Language("", "lus", "Lushai");

    /// <summary>The Macedonian language.</summary>
    public static readonly Language Macedonian = new Language("mk", "mac", "Macedonian");
    /// <summary>The Madurese language.</summary>
    public static readonly Language Madurese = new Language("", "mad", "Madurese");
    /// <summary>The Magahi language.</summary>
    public static readonly Language Magahi = new Language("", "mag", "Magahi");
    /// <summary>The Marshallese language.</summary>
    public static readonly Language Marshallese = new Language("mh", "mah", "Marshallese");
    /// <summary>The Maithili language.</summary>
    public static readonly Language Maithili = new Language("", "mai", "Maithili");
    /// <summary>The Makasar language.</summary>
    public static readonly Language Makasar = new Language("", "mak", "Makasar");
    /// <summary>The Malayalam language.</summary>
    public static readonly Language Malayalam = new Language("ml", "mal", "Malayalam");
    /// <summary>The Mandingo language.</summary>
    public static readonly Language Mandingo = new Language("", "man", "Mandingo");
    /// <summary>The Austronesian Languages language.</summary>
    public static readonly Language AustronesianLanguages = new Language("", "map", "Austronesian languages");
    /// <summary>The Marathi language.</summary>
    public static readonly Language Marathi = new Language("mr", "mar", "Marathi");
    /// <summary>The Masai language.</summary>
    public static readonly Language Masai = new Language("", "mas", "Masai");
    /// <summary>The Moksha language.</summary>
    public static readonly Language Moksha = new Language("", "mdf", "Moksha");
    /// <summary>The Mandar language.</summary>
    public static readonly Language Mandar = new Language("", "mdr", "Mandar");
    /// <summary>The Mende language.</summary>
    public static readonly Language Mende = new Language("", "men", "Mende");
    /// <summary>The Irish Middle language.</summary>
    public static readonly Language IrishMiddle = new Language("", "mga", "Irish, Middle (900-1200)");
    /// <summary>The Mi Kmaq language.</summary>
    public static readonly Language MiKmaq = new Language("", "mic", "Mi'kmaq; Micmac");
    /// <summary>The Minangkabau language.</summary>
    public static readonly Language Minangkabau = new Language("", "min", "Minangkabau");
    /// <summary>The Uncoded Languages language.</summary>
    public static readonly Language UncodedLanguages = new Language("", "mis", "Uncoded languages");
    /// <summary>The Mon Khmer Languages language.</summary>
    public static readonly Language MonKhmerLanguages = new Language("", "mkh", "Mon-Khmer languages");
    /// <summary>The Malagasy language.</summary>
    public static readonly Language Malagasy = new Language("mg", "mlg", "Malagasy");
    /// <summary>The Malay language.</summary>
    public static readonly Language Malay = new Language("ms", "may", "Malay");
    /// <summary>The Maltese language.</summary>
    public static readonly Language Maltese = new Language("mt", "mlt", "Maltese");
    /// <summary>The Manchu language.</summary>
    public static readonly Language Manchu = new Language("", "mnc", "Manchu");
    /// <summary>The Manipuri language.</summary>
    public static readonly Language Manipuri = new Language("", "mni", "Manipuri");
    /// <summary>The Manobo Languages language.</summary>
    public static readonly Language ManoboLanguages = new Language("", "mno", "Manobo languages");
    /// <summary>The Mohawk language.</summary>
    public static readonly Language Mohawk = new Language("", "moh", "Mohawk");
    /// <summary>The Mongolian language.</summary>
    public static readonly Language Mongolian = new Language("mn", "mon", "Mongolian");
    /// <summary>The Mossi language.</summary>
    public static readonly Language Mossi = new Language("", "mos", "Mossi");
    /// <summary>The Maori language.</summary>
    public static readonly Language Maori = new Language("mi", "mri", "Maori");
    /// <summary>The Multiple Languages language.</summary>
    public static readonly Language MultipleLanguages = new Language("", "mul", "Multiple languages");
    /// <summary>The Munda Languages language.</summary>
    public static readonly Language MundaLanguages = new Language("", "mun", "Munda languages");
    /// <summary>The Creek language.</summary>
    public static readonly Language Creek = new Language("", "mus", "Creek");
    /// <summary>The Mirandese language.</summary>
    public static readonly Language Mirandese = new Language("", "mwl", "Mirandese");
    /// <summary>The Marwari language.</summary>
    public static readonly Language Marwari = new Language("", "mwr", "Marwari");
    /// <summary>The Mayan Languages language.</summary>
    public static readonly Language MayanLanguages = new Language("", "myn", "Mayan languages");
    /// <summary>The Erzya language.</summary>
    public static readonly Language Erzya = new Language("", "myv", "Erzya");

    /// <summary>The Nahuatl Languages language.</summary>
    public static readonly Language NahuatlLanguages = new Language("", "nah", "Nahuatl languages");
    /// <summary>The North American Indian Languages language.</summary>
    public static readonly Language NorthAmericanIndianLanguages = new Language("", "nai", "North American Indian languages");
    /// <summary>The Neapolitan language.</summary>
    public static readonly Language Neapolitan = new Language("", "nap", "Neapolitan");
    /// <summary>The Nauru language.</summary>
    public static readonly Language Nauru = new Language("na", "nau", "Nauru");
    /// <summary>The Navajo language.</summary>
    public static readonly Language Navajo = new Language("nv", "nav", "Navajo; Navaho");
    /// <summary>The Ndebele South language.</summary>
    public static readonly Language NdebeleSouth = new Language("nr", "nbl", "Ndebele, South; South Ndebele");
    /// <summary>The Ndebele North language.</summary>
    public static readonly Language NdebeleNorth = new Language("nd", "nde", "Ndebele, North; North Ndebele");
    /// <summary>The Ndonga language.</summary>
    public static readonly Language Ndonga = new Language("ng", "ndo", "Ndonga");
    /// <summary>The Low German language.</summary>
    public static readonly Language LowGerman = new Language("", "nds", "Low German; Low Saxon; German, Low; Saxon, Low");
    /// <summary>The Nepali language.</summary>
    public static readonly Language Nepali = new Language("ne", "nep", "Nepali");
    /// <summary>The Nepal Bhasa language.</summary>
    public static readonly Language NepalBhasa = new Language("", "new", "Nepal Bhasa; Newari");
    /// <summary>The Nias language.</summary>
    public static readonly Language Nias = new Language("", "nia", "Nias");
    /// <summary>The Niger Kordofanian Languages language.</summary>
    public static readonly Language NigerKordofanianLanguages = new Language("", "nic", "Niger-Kordofanian languages");
    /// <summary>The Niuean language.</summary>
    public static readonly Language Niuean = new Language("", "niu", "Niuean");
    /// <summary>The Norwegian Nynorsk language.</summary>
    public static readonly Language NorwegianNynorsk = new Language("nn", "nno", "Norwegian Nynorsk; Nynorsk, Norwegian");
    /// <summary>The Norwegian Bokmal language.</summary>
    public static readonly Language NorwegianBokmal = new Language("nb", "nob", "Bokmål, Norwegian; Norwegian Bokmål");
    /// <summary>The Nogai language.</summary>
    public static readonly Language Nogai = new Language("", "nog", "Nogai");
    /// <summary>The Norse Old language.</summary>
    public static readonly Language NorseOld = new Language("", "non", "Norse, Old");
    /// <summary>The Norwegian language.</summary>
    public static readonly Language Norwegian = new Language("no", "nor", "Norwegian");
    /// <summary>The N Ko language.</summary>
    public static readonly Language NKo = new Language("", "nqo", "N'Ko");
    /// <summary>The Northern Sotho language.</summary>
    public static readonly Language NorthernSotho = new Language("", "nso", "Pedi; Sepedi; Northern Sotho");
    /// <summary>The Nubian Languages language.</summary>
    public static readonly Language NubianLanguages = new Language("", "nub", "Nubian languages");
    /// <summary>The Classical Newari language.</summary>
    public static readonly Language ClassicalNewari = new Language("", "nwc", "Classical Newari; Old Newari; Classical Nepal Bhasa");
    /// <summary>The Chichewa language.</summary>
    public static readonly Language Chichewa = new Language("ny", "nya", "Chichewa; Chewa; Nyanja");
    /// <summary>The Nyamwezi language.</summary>
    public static readonly Language Nyamwezi = new Language("", "nym", "Nyamwezi");
    /// <summary>The Nyankole language.</summary>
    public static readonly Language Nyankole = new Language("", "nyn", "Nyankole");
    /// <summary>The Nyoro language.</summary>
    public static readonly Language Nyoro = new Language("", "nyo", "Nyoro");
    /// <summary>The Nzima language.</summary>
    public static readonly Language Nzima = new Language("", "nzi", "Nzima");

    /// <summary>The Occitan language.</summary>
    public static readonly Language Occitan = new Language("oc", "oci", "Occitan (post 1500)");
    /// <summary>The Ojibwa language.</summary>
    public static readonly Language Ojibwa = new Language("oj", "oji", "Ojibwa");
    /// <summary>The Oriya language.</summary>
    public static readonly Language Oriya = new Language("or", "ori", "Oriya");
    /// <summary>The Oromo language.</summary>
    public static readonly Language Oromo = new Language("om", "orm", "Oromo");
    /// <summary>The Osage language.</summary>
    public static readonly Language Osage = new Language("", "osa", "Osage");
    /// <summary>The Ossetian language.</summary>
    public static readonly Language Ossetian = new Language("os", "oss", "Ossetian; Ossetic");
    /// <summary>The Turkish Ottoman language.</summary>
    public static readonly Language TurkishOttoman = new Language("", "ota", "Turkish, Ottoman (1500-1928)");
    /// <summary>The Otomian Languages language.</summary>
    public static readonly Language OtomianLanguages = new Language("", "oto", "Otomian languages");

    /// <summary>The Papuan Languages language.</summary>
    public static readonly Language PapuanLanguages = new Language("", "paa", "Papuan languages");
    /// <summary>The Pangasinan language.</summary>
    public static readonly Language Pangasinan = new Language("", "pag", "Pangasinan");
    /// <summary>The Pahlavi language.</summary>
    public static readonly Language Pahlavi = new Language("", "pal", "Pahlavi");
    /// <summary>The Pampanga language.</summary>
    public static readonly Language Pampanga = new Language("", "pam", "Pampanga; Kapampangan");
    /// <summary>The Panjabi language.</summary>
    public static readonly Language Panjabi = new Language("pa", "pan", "Panjabi; Punjabi");
    /// <summary>The Papiamento language.</summary>
    public static readonly Language Papiamento = new Language("", "pap", "Papiamento");
    /// <summary>The Palauan language.</summary>
    public static readonly Language Palauan = new Language("", "pau", "Palauan");
    /// <summary>The Persian Old language.</summary>
    public static readonly Language PersianOld = new Language("", "peo", "Persian, Old (ca.600-400 B.C.)");
    /// <summary>The Philippine Languages language.</summary>
    public static readonly Language PhilippineLanguages = new Language("", "phi", "Philippine languages");
    /// <summary>The Phoenician language.</summary>
    public static readonly Language Phoenician = new Language("", "phn", "Phoenician");
    /// <summary>The Pali language.</summary>
    public static readonly Language Pali = new Language("pi", "pli", "Pali");
    /// <summary>The Polish language.</summary>
    public static readonly Language Polish = new Language("pl", "pol", "Polish");
    /// <summary>The Pohnpeian language.</summary>
    public static readonly Language Pohnpeian = new Language("", "pon", "Pohnpeian");
    /// <summary>The Portuguese language.</summary>
    public static readonly Language Portuguese = new Language("pt", "por", "Portuguese");
    /// <summary>The Prakrit Languages language.</summary>
    public static readonly Language PrakritLanguages = new Language("", "pra", "Prakrit languages");
    /// <summary>The Provencal Old language.</summary>
    public static readonly Language ProvencalOld = new Language("", "pro", "Provençal, Old (to 1500);Occitan, Old (to 1500)");
    /// <summary>The Pushto language.</summary>
    public static readonly Language Pushto = new Language("ps", "pus", "Pushto; Pashto");

    /// <summary>The Reserved For Local Use language.</summary>
    public static readonly Language ReservedForLocalUse = new Language("", "qaa-qtz", "Reserved for local use");
    /// <summary>The Quechua language.</summary>
    public static readonly Language Quechua = new Language("qu", "que", "Quechua");
    /// <summary>The Rajasthani language.</summary>
    public static readonly Language Rajasthani = new Language("", "raj", "Rajasthani");
    /// <summary>The Rapanui language.</summary>
    public static readonly Language Rapanui = new Language("", "rap", "Rapanui");
    /// <summary>The Rarotongan language.</summary>
    public static readonly Language Rarotongan = new Language("", "rar", "Rarotongan; Cook Islands Maori");
    /// <summary>The Romance Languages language.</summary>
    public static readonly Language RomanceLanguages = new Language("", "roa", "Romance languages");
    /// <summary>The Romansh language.</summary>
    public static readonly Language Romansh = new Language("rm", "roh", "Romansh");
    /// <summary>The Romany language.</summary>
    public static readonly Language Romany = new Language("", "rom", "Romany");
    /// <summary>The Romanian language.</summary>
    public static readonly Language Romanian = new Language("ro", "rum", "Romanian; Moldavian; Moldovan");
    /// <summary>The Rundi language.</summary>
    public static readonly Language Rundi = new Language("rn", "run", "Rundi");
    /// <summary>The Aromanian language.</summary>
    public static readonly Language Aromanian = new Language("", "rup", "Aromanian; Arumanian; Macedo-Romanian");
    /// <summary>The Russian language.</summary>
    public static readonly Language Russian = new Language("ru", "rus", "Russian");

    /// <summary>The Sandawe language.</summary>
    public static readonly Language Sandawe = new Language("", "sad", "Sandawe");
    /// <summary>The Sango language.</summary>
    public static readonly Language Sango = new Language("sg", "sag", "Sango");
    /// <summary>The Yakut language.</summary>
    public static readonly Language Yakut = new Language("", "sah", "Yakut");
    /// <summary>The South American Indian Languages language.</summary>
    public static readonly Language SouthAmericanIndianLanguages = new Language("", "sai", "South American Indian languages");
    /// <summary>The Salishan Languages language.</summary>
    public static readonly Language SalishanLanguages = new Language("", "sal", "Salishan languages");
    /// <summary>The Samaritan Aramaic language.</summary>
    public static readonly Language SamaritanAramaic = new Language("", "sam", "Samaritan Aramaic");
    /// <summary>The Sanskrit language.</summary>
    public static readonly Language Sanskrit = new Language("sa", "san", "Sanskrit");
    /// <summary>The Sasak language.</summary>
    public static readonly Language Sasak = new Language("", "sas", "Sasak");
    /// <summary>The Santali language.</summary>
    public static readonly Language Santali = new Language("", "sat", "Santali");
    /// <summary>The Sicilian language.</summary>
    public static readonly Language Sicilian = new Language("", "scn", "Sicilian");
    /// <summary>The Scots language.</summary>
    public static readonly Language Scots = new Language("", "sco", "Scots");
    /// <summary>The Selkup language.</summary>
    public static readonly Language Selkup = new Language("", "sel", "Selkup");
    /// <summary>The Semitic Languages language.</summary>
    public static readonly Language SemiticLanguages = new Language("", "sem", "Semitic languages");
    /// <summary>The Irish Old language.</summary>
    public static readonly Language IrishOld = new Language("", "sga", "Irish, Old (to 900)");
    /// <summary>The Sign Languages language.</summary>
    public static readonly Language SignLanguages = new Language("", "sgn", "Sign Languages");
    /// <summary>The Shan language.</summary>
    public static readonly Language Shan = new Language("", "shn", "Shan");
    /// <summary>The Sidamo language.</summary>
    public static readonly Language Sidamo = new Language("", "sid", "Sidamo");
    /// <summary>The Sinhala language.</summary>
    public static readonly Language Sinhala = new Language("si", "sin", "Sinhala; Sinhalese");
    /// <summary>The Siouan Languages language.</summary>
    public static readonly Language SiouanLanguages = new Language("", "sio", "Siouan languages");
    /// <summary>The Sino Tibetan Languages language.</summary>
    public static readonly Language SinoTibetanLanguages = new Language("", "sit", "Sino-Tibetan languages");
    /// <summary>The Slavic Languages language.</summary>
    public static readonly Language SlavicLanguages = new Language("", "sla", "Slavic languages");
    /// <summary>The Slovak language.</summary>
    public static readonly Language Slovak = new Language("sk", "slo", "Slovak");
    /// <summary>The Slovenian language.</summary>
    public static readonly Language Slovenian = new Language("sl", "slv", "Slovenian");
    /// <summary>The Southern Sami language.</summary>
    public static readonly Language SouthernSami = new Language("", "sma", "Southern Sami");
    /// <summary>The Northern Sami language.</summary>
    public static readonly Language NorthernSami = new Language("se", "sme", "Northern Sami");
    /// <summary>The Sami Languages language.</summary>
    public static readonly Language SamiLanguages = new Language("", "smi", "Sami languages");
    /// <summary>The Lule Sami language.</summary>
    public static readonly Language LuleSami = new Language("", "smj", "Lule Sami");
    /// <summary>The Inari Sami language.</summary>
    public static readonly Language InariSami = new Language("", "smn", "Inari Sami");
    /// <summary>The Samoan language.</summary>
    public static readonly Language Samoan = new Language("sm", "smo", "Samoan");
    /// <summary>The Skolt Sami language.</summary>
    public static readonly Language SkoltSami = new Language("", "sms", "Skolt Sami");
    /// <summary>The Shona language.</summary>
    public static readonly Language Shona = new Language("sn", "sna", "Shona");
    /// <summary>The Sindhi language.</summary>
    public static readonly Language Sindhi = new Language("sd", "snd", "Sindhi");
    /// <summary>The Soninke language.</summary>
    public static readonly Language Soninke = new Language("", "snk", "Soninke");
    /// <summary>The Sogdian language.</summary>
    public static readonly Language Sogdian = new Language("", "sog", "Sogdian");
    /// <summary>The Somali language.</summary>
    public static readonly Language Somali = new Language("so", "som", "Somali");
    /// <summary>The Songhai Languages language.</summary>
    public static readonly Language SonghaiLanguages = new Language("", "son", "Songhai languages");
    /// <summary>The Sotho Southern language.</summary>
    public static readonly Language SothoSouthern = new Language("st", "sot", "Sotho, Southern");
    /// <summary>The Spanish language.</summary>
    public static readonly Language Spanish = new Language("es", "spa", "Spanish; Castilian");
    /// <summary>The Sardinian language.</summary>
    public static readonly Language Sardinian = new Language("sc", "srd", "Sardinian");
    /// <summary>The Sranan Tongo language.</summary>
    public static readonly Language SrananTongo = new Language("", "srn", "Sranan Tongo");
    /// <summary>The Serbian language.</summary>
    public static readonly Language Serbian = new Language("sr", "srp", "Serbian");
    /// <summary>The Serer language.</summary>
    public static readonly Language Serer = new Language("", "srr", "Serer");
    /// <summary>The Nilo Saharan Languages language.</summary>
    public static readonly Language NiloSaharanLanguages = new Language("", "ssa", "Nilo-Saharan languages");
    /// <summary>The Swati language.</summary>
    public static readonly Language Swati = new Language("ss", "ssw", "Swati");
    /// <summary>The Sukuma language.</summary>
    public static readonly Language Sukuma = new Language("", "suk", "Sukuma");
    /// <summary>The Sundanese language.</summary>
    public static readonly Language Sundanese = new Language("su", "sun", "Sundanese");
    /// <summary>The Susu language.</summary>
    public static readonly Language Susu = new Language("", "sus", "Susu");
    /// <summary>The Sumerian language.</summary>
    public static readonly Language Sumerian = new Language("", "sux", "Sumerian");
    /// <summary>The Swahili language.</summary>
    public static readonly Language Swahili = new Language("sw", "swa", "Swahili");
    /// <summary>The Swedish language.</summary>
    public static readonly Language Swedish = new Language("sv", "swe", "Swedish");
    /// <summary>The Classical Syriac language.</summary>
    public static readonly Language ClassicalSyriac = new Language("", "syc", "Classical Syriac");
    /// <summary>The Syriac language.</summary>
    public static readonly Language Syriac = new Language("", "syr", "Syriac");

    /// <summary>The Tahitian language.</summary>
    public static readonly Language Tahitian = new Language("ty", "tah", "Tahitian");
    /// <summary>The Tai Languages language.</summary>
    public static readonly Language TaiLanguages = new Language("", "tai", "Tai languages");
    /// <summary>The Tamil language.</summary>
    public static readonly Language Tamil = new Language("ta", "tam", "Tamil");
    /// <summary>The Tatar language.</summary>
    public static readonly Language Tatar = new Language("tt", "tat", "Tatar");
    /// <summary>The Telugu language.</summary>
    public static readonly Language Telugu = new Language("te", "tel", "Telugu");
    /// <summary>The Timne language.</summary>
    public static readonly Language Timne = new Language("", "tem", "Timne");
    /// <summary>The Tereno language.</summary>
    public static readonly Language Tereno = new Language("", "ter", "Tereno");
    /// <summary>The Tetum language.</summary>
    public static readonly Language Tetum = new Language("", "tet", "Tetum");
    /// <summary>The Tajik language.</summary>
    public static readonly Language Tajik = new Language("tg", "tgk", "Tajik");
    /// <summary>The Tagalog language.</summary>
    public static readonly Language Tagalog = new Language("tl", "tgl", "Tagalog");
    /// <summary>The Thai language.</summary>
    public static readonly Language Thai = new Language("th", "tha", "Thai");
    /// <summary>The Tigre language.</summary>
    public static readonly Language Tigre = new Language("", "tig", "Tigre");
    /// <summary>The Tigrinya language.</summary>
    public static readonly Language Tigrinya = new Language("ti", "tir", "Tigrinya");
    /// <summary>The Tiv language.</summary>
    public static readonly Language Tiv = new Language("", "tiv", "Tiv");
    /// <summary>The Tokelau language.</summary>
    public static readonly Language Tokelau = new Language("", "tkl", "Tokelau");
    /// <summary>The Klingon language.</summary>
    public static readonly Language Klingon = new Language("", "tlh", "Klingon; tlhIngan-Hol");
    /// <summary>The Tlingit language.</summary>
    public static readonly Language Tlingit = new Language("", "tli", "Tlingit");
    /// <summary>The Tamashek language.</summary>
    public static readonly Language Tamashek = new Language("", "tmh", "Tamashek");
    /// <summary>The Tonga Nyasa language.</summary>
    public static readonly Language TongaNyasa = new Language("", "tog", "Tonga (Nyasa)");
    /// <summary>The Tonga Islands language.</summary>
    public static readonly Language TongaIslands = new Language("to", "ton", "Tonga (Tonga Islands)");
    /// <summary>The Tok Pisin language.</summary>
    public static readonly Language TokPisin = new Language("", "tpi", "Tok Pisin");
    /// <summary>The Tsimshian language.</summary>
    public static readonly Language Tsimshian = new Language("", "tsi", "Tsimshian");
    /// <summary>The Tswana language.</summary>
    public static readonly Language Tswana = new Language("tn", "tsn", "Tswana");
    /// <summary>The Tsonga language.</summary>
    public static readonly Language Tsonga = new Language("ts", "tso", "Tsonga");
    /// <summary>The Turkmen language.</summary>
    public static readonly Language Turkmen = new Language("tk", "tuk", "Turkmen");
    /// <summary>The Tumbuka language.</summary>
    public static readonly Language Tumbuka = new Language("", "tum", "Tumbuka");
    /// <summary>The Tupi Languages language.</summary>
    public static readonly Language TupiLanguages = new Language("", "tup", "Tupi languages");
    /// <summary>The Turkish language.</summary>
    public static readonly Language Turkish = new Language("tr", "tur", "Turkish");
    /// <summary>The Altaic Languages language.</summary>
    public static readonly Language AltaicLanguages = new Language("", "tut", "Altaic languages");
    /// <summary>The Tuvalu language.</summary>
    public static readonly Language Tuvalu = new Language("", "tvl", "Tuvalu");
    /// <summary>The Twi language.</summary>
    public static readonly Language Twi = new Language("tw", "twi", "Twi");
    /// <summary>The Tuvinian language.</summary>
    public static readonly Language Tuvinian = new Language("", "tyv", "Tuvinian");

    /// <summary>The Udmurt language.</summary>
    public static readonly Language Udmurt = new Language("", "udm", "Udmurt");
    /// <summary>The Ugaritic language.</summary>
    public static readonly Language Ugaritic = new Language("", "uga", "Ugaritic");
    /// <summary>The Uighur language.</summary>
    public static readonly Language Uighur = new Language("ug", "uig", "Uighur; Uyghur");
    /// <summary>The Ukrainian language.</summary>
    public static readonly Language Ukrainian = new Language("uk", "ukr", "Ukrainian");
    /// <summary>The Umbundu language.</summary>
    public static readonly Language Umbundu = new Language("", "umb", "Umbundu");
    /// <summary>The Undetermined language.</summary>
    public static readonly Language Undetermined = new Language("", "und", "Undetermined");
    /// <summary>The Urdu language.</summary>
    public static readonly Language Urdu = new Language("ur", "urd", "Urdu");
    /// <summary>The Uzbek language.</summary>
    public static readonly Language Uzbek = new Language("uz", "uzb", "Uzbek");

    /// <summary>The Vai language.</summary>
    public static readonly Language Vai = new Language("", "vai", "Vai");
    /// <summary>The Venda language.</summary>
    public static readonly Language Venda = new Language("ve", "ven", "Venda");
    /// <summary>The Vietnamese language.</summary>
    public static readonly Language Vietnamese = new Language("vi", "vie", "Vietnamese");
    /// <summary>The Volapuk language.</summary>
    public static readonly Language Volapuk = new Language("vo", "vol", "Volapük");
    /// <summary>The Votic language.</summary>
    public static readonly Language Votic = new Language("", "vot", "Votic");
    /// <summary>The Wakashan Languages language.</summary>
    public static readonly Language WakashanLanguages = new Language("", "wak", "Wakashan languages");
    /// <summary>The Wolaitta language.</summary>
    public static readonly Language Wolaitta = new Language("", "wal", "Wolaitta; Wolaytta");
    /// <summary>The Waray language.</summary>
    public static readonly Language Waray = new Language("", "war", "Waray");
    /// <summary>The Washo language.</summary>
    public static readonly Language Washo = new Language("", "was", "Washo");
    /// <summary>The Sorbian Languages language.</summary>
    public static readonly Language SorbianLanguages = new Language("", "wen", "Sorbian languages");
    /// <summary>The Walloon language.</summary>
    public static readonly Language Walloon = new Language("wa", "wln", "Walloon");
    /// <summary>The Wolof language.</summary>
    public static readonly Language Wolof = new Language("wo", "wol", "Wolof");

    /// <summary>The Kalmyk language.</summary>
    public static readonly Language Kalmyk = new Language("", "xal", "Kalmyk; Oirat");
    /// <summary>The Xhosa language.</summary>
    public static readonly Language Xhosa = new Language("xh", "xho", "Xhosa");
    /// <summary>The Yao language.</summary>
    public static readonly Language Yao = new Language("", "yao", "Yao");
    /// <summary>The Yapese language.</summary>
    public static readonly Language Yapese = new Language("", "yap", "Yapese");
    /// <summary>The Yiddish language.</summary>
    public static readonly Language Yiddish = new Language("yi", "yid", "Yiddish");
    /// <summary>The Yoruba language.</summary>
    public static readonly Language Yoruba = new Language("yo", "yor", "Yoruba");
    /// <summary>The Yupik Languages language.</summary>
    public static readonly Language YupikLanguages = new Language("", "ypk", "Yupik languages");
    /// <summary>The Zapotec language.</summary>
    public static readonly Language Zapotec = new Language("", "zap", "Zapotec");
    /// <summary>The Blissymbols language.</summary>
    public static readonly Language Blissymbols = new Language("", "zbl", "Blissymbols; Blissymbolics; Bliss");
    /// <summary>The Zenaga language.</summary>
    public static readonly Language Zenaga = new Language("", "zen", "Zenaga");
    /// <summary>The Standard Moroccan Tamazight language.</summary>
    public static readonly Language StandardMoroccanTamazight = new Language("", "zgh", "Standard Moroccan Tamazight");
    /// <summary>The Zhuang language.</summary>
    public static readonly Language Zhuang = new Language("za", "zha", "Zhuang; Chuang");
    /// <summary>The Zande Languages language.</summary>
    public static readonly Language ZandeLanguages = new Language("", "znd", "Zande languages");
    /// <summary>The Zulu language.</summary>
    public static readonly Language Zulu = new Language("zu", "zul", "Zulu");
    /// <summary>The Zuni language.</summary>
    public static readonly Language Zuni = new Language("", "zun", "Zuni");
    /// <summary>The No Linguistic Content language.</summary>
    public static readonly Language NoLinguisticContent = new Language("", "zxx", "No linguistic content; Not applicable");
    /// <summary>The Zaza language.</summary>
    public static readonly Language Zaza = new Language("", "zza", "Zaza; Dimili; Dimli; Kirdki; Kirmanjki; Zazaki");

    /// <summary>The None language.</summary>
    public static readonly Language None = new Language(string.Empty, string.Empty, string.Empty);

    // ===== Static constructor — extended data initialization =====
    static LanguageHelper()
    {
        // Alpha2 -> (NativeName, Script, TextDirection)
        var data = new Dictionary<string, (string Native, string Script, TextDirection Dir)>
        {
            ["aa"] = ("Qafar", "Latin", TextDirection.LeftToRight),
            ["ab"] = ("аԥсуа бызшәа", "Cyrillic", TextDirection.LeftToRight),
            ["af"] = ("Afrikaans", "Latin", TextDirection.LeftToRight),
            ["ak"] = ("Akan", "Latin", TextDirection.LeftToRight),
            ["am"] = ("አማርኛ", "Ethiopic", TextDirection.LeftToRight),
            ["an"] = ("aragonés", "Latin", TextDirection.LeftToRight),
            ["ar"] = ("العربية", "Arabic", TextDirection.RightToLeft),
            ["as"] = ("অসমীয়া", "Bengali", TextDirection.LeftToRight),
            ["av"] = ("авар мацӀ", "Cyrillic", TextDirection.LeftToRight),
            ["ay"] = ("aymar aru", "Latin", TextDirection.LeftToRight),
            ["az"] = ("azərbaycan dili", "Latin", TextDirection.LeftToRight),
            ["ba"] = ("башҡорт теле", "Cyrillic", TextDirection.LeftToRight),
            ["be"] = ("беларуская", "Cyrillic", TextDirection.LeftToRight),
            ["bg"] = ("български", "Cyrillic", TextDirection.LeftToRight),
            ["bh"] = ("भोजपुरी", "Devanagari", TextDirection.LeftToRight),
            ["bi"] = ("Bislama", "Latin", TextDirection.LeftToRight),
            ["bm"] = ("bamanankan", "Latin", TextDirection.LeftToRight),
            ["bn"] = ("বাংলা", "Bengali", TextDirection.LeftToRight),
            ["bo"] = ("བོད་ཡིག", "Tibetan", TextDirection.LeftToRight),
            ["br"] = ("brezhoneg", "Latin", TextDirection.LeftToRight),
            ["bs"] = ("bosanski", "Latin", TextDirection.LeftToRight),
            ["ca"] = ("català", "Latin", TextDirection.LeftToRight),
            ["ce"] = ("нохчийн мотт", "Cyrillic", TextDirection.LeftToRight),
            ["ch"] = ("Chamoru", "Latin", TextDirection.LeftToRight),
            ["co"] = ("corsu", "Latin", TextDirection.LeftToRight),
            ["cr"] = ("ᓀᐦᐃᔭᐍᐏᐣ", "Canadian Aboriginal", TextDirection.LeftToRight),
            ["cs"] = ("čeština", "Latin", TextDirection.LeftToRight),
            ["cu"] = ("ѩзыкъ словѣньскъ", "Cyrillic", TextDirection.LeftToRight),
            ["cv"] = ("чӑваш чӗлхи", "Cyrillic", TextDirection.LeftToRight),
            ["cy"] = ("Cymraeg", "Latin", TextDirection.LeftToRight),
            ["da"] = ("dansk", "Latin", TextDirection.LeftToRight),
            ["de"] = ("Deutsch", "Latin", TextDirection.LeftToRight),
            ["dv"] = ("ދިވެހި", "Thaana", TextDirection.RightToLeft),
            ["dz"] = ("རྫོང་ཁ", "Tibetan", TextDirection.LeftToRight),
            ["ee"] = ("Eʋegbe", "Latin", TextDirection.LeftToRight),
            ["el"] = ("Ελληνικά", "Greek", TextDirection.LeftToRight),
            ["en"] = ("English", "Latin", TextDirection.LeftToRight),
            ["eo"] = ("Esperanto", "Latin", TextDirection.LeftToRight),
            ["es"] = ("Español", "Latin", TextDirection.LeftToRight),
            ["et"] = ("eesti", "Latin", TextDirection.LeftToRight),
            ["eu"] = ("euskara", "Latin", TextDirection.LeftToRight),
            ["fa"] = ("فارسی", "Arabic", TextDirection.RightToLeft),
            ["ff"] = ("Fulfulde", "Latin", TextDirection.LeftToRight),
            ["fi"] = ("suomi", "Latin", TextDirection.LeftToRight),
            ["fj"] = ("vosa Vakaviti", "Latin", TextDirection.LeftToRight),
            ["fo"] = ("føroyskt", "Latin", TextDirection.LeftToRight),
            ["fr"] = ("français", "Latin", TextDirection.LeftToRight),
            ["fy"] = ("Frysk", "Latin", TextDirection.LeftToRight),
            ["ga"] = ("Gaeilge", "Latin", TextDirection.LeftToRight),
            ["gd"] = ("Gàidhlig", "Latin", TextDirection.LeftToRight),
            ["gl"] = ("galego", "Latin", TextDirection.LeftToRight),
            ["gn"] = ("Avañeʼẽ", "Latin", TextDirection.LeftToRight),
            ["gu"] = ("ગુજરાતી", "Gujarati", TextDirection.LeftToRight),
            ["gv"] = ("Gaelg", "Latin", TextDirection.LeftToRight),
            ["ha"] = ("Hausa", "Latin", TextDirection.LeftToRight),
            ["he"] = ("עברית", "Hebrew", TextDirection.RightToLeft),
            ["hi"] = ("हिन्दी", "Devanagari", TextDirection.LeftToRight),
            ["ho"] = ("Hiri Motu", "Latin", TextDirection.LeftToRight),
            ["hr"] = ("hrvatski", "Latin", TextDirection.LeftToRight),
            ["ht"] = ("Kreyòl ayisyen", "Latin", TextDirection.LeftToRight),
            ["hu"] = ("magyar", "Latin", TextDirection.LeftToRight),
            ["hy"] = ("Հայերեն", "Armenian", TextDirection.LeftToRight),
            ["hz"] = ("Otjiherero", "Latin", TextDirection.LeftToRight),
            ["ia"] = ("Interlingua", "Latin", TextDirection.LeftToRight),
            ["id"] = ("Bahasa Indonesia", "Latin", TextDirection.LeftToRight),
            ["ie"] = ("Interlingue", "Latin", TextDirection.LeftToRight),
            ["ig"] = ("Igbo", "Latin", TextDirection.LeftToRight),
            ["ii"] = ("ꆈꌠ꒿", "Yi", TextDirection.LeftToRight),
            ["ik"] = ("Iñupiaq", "Latin", TextDirection.LeftToRight),
            ["io"] = ("Ido", "Latin", TextDirection.LeftToRight),
            ["is"] = ("íslenska", "Latin", TextDirection.LeftToRight),
            ["it"] = ("italiano", "Latin", TextDirection.LeftToRight),
            ["iu"] = ("ᐃᓄᒃᑎᑐᑦ", "Canadian Aboriginal", TextDirection.LeftToRight),
            ["ja"] = ("日本語", "Japanese", TextDirection.LeftToRight),
            ["jv"] = ("basa Jawa", "Latin", TextDirection.LeftToRight),
            ["ka"] = ("ქართული", "Georgian", TextDirection.LeftToRight),
            ["kg"] = ("Kikongo", "Latin", TextDirection.LeftToRight),
            ["ki"] = ("Gĩkũyũ", "Latin", TextDirection.LeftToRight),
            ["kj"] = ("Kuanyama", "Latin", TextDirection.LeftToRight),
            ["kk"] = ("қазақ тілі", "Cyrillic", TextDirection.LeftToRight),
            ["kl"] = ("kalaallisut", "Latin", TextDirection.LeftToRight),
            ["km"] = ("ខ្មែរ", "Khmer", TextDirection.LeftToRight),
            ["kn"] = ("ಕನ್ನಡ", "Kannada", TextDirection.LeftToRight),
            ["ko"] = ("한국어", "Hangul", TextDirection.LeftToRight),
            ["kr"] = ("Kanuri", "Latin", TextDirection.LeftToRight),
            ["ks"] = ("कॉशुर", "Arabic", TextDirection.RightToLeft),
            ["ku"] = ("Kurdî", "Latin", TextDirection.LeftToRight),
            ["kv"] = ("коми кыв", "Cyrillic", TextDirection.LeftToRight),
            ["kw"] = ("Kernewek", "Latin", TextDirection.LeftToRight),
            ["ky"] = ("кыргызча", "Cyrillic", TextDirection.LeftToRight),
            ["la"] = ("lingua latina", "Latin", TextDirection.LeftToRight),
            ["lb"] = ("Lëtzebuergesch", "Latin", TextDirection.LeftToRight),
            ["lg"] = ("Luganda", "Latin", TextDirection.LeftToRight),
            ["li"] = ("Limburgs", "Latin", TextDirection.LeftToRight),
            ["ln"] = ("lingála", "Latin", TextDirection.LeftToRight),
            ["lo"] = ("ລາວ", "Lao", TextDirection.LeftToRight),
            ["lt"] = ("lietuvių", "Latin", TextDirection.LeftToRight),
            ["lu"] = ("Kiluba", "Latin", TextDirection.LeftToRight),
            ["lv"] = ("latviešu", "Latin", TextDirection.LeftToRight),
            ["mg"] = ("Malagasy", "Latin", TextDirection.LeftToRight),
            ["mh"] = ("Kajin M̧ajeļ", "Latin", TextDirection.LeftToRight),
            ["mi"] = ("te reo Māori", "Latin", TextDirection.LeftToRight),
            ["mk"] = ("македонски", "Cyrillic", TextDirection.LeftToRight),
            ["ml"] = ("മലയാളം", "Malayalam", TextDirection.LeftToRight),
            ["mn"] = ("монгол", "Cyrillic", TextDirection.LeftToRight),
            ["mr"] = ("मराठी", "Devanagari", TextDirection.LeftToRight),
            ["ms"] = ("Bahasa Melayu", "Latin", TextDirection.LeftToRight),
            ["mt"] = ("Malti", "Latin", TextDirection.LeftToRight),
            ["my"] = ("ဗမာစာ", "Myanmar", TextDirection.LeftToRight),
            ["na"] = ("Dorerin Naoero", "Latin", TextDirection.LeftToRight),
            ["nb"] = ("norsk bokmål", "Latin", TextDirection.LeftToRight),
            ["nd"] = ("isiNdebele", "Latin", TextDirection.LeftToRight),
            ["ne"] = ("नेपाली", "Devanagari", TextDirection.LeftToRight),
            ["ng"] = ("Owambo", "Latin", TextDirection.LeftToRight),
            ["nl"] = ("Nederlands", "Latin", TextDirection.LeftToRight),
            ["nn"] = ("norsk nynorsk", "Latin", TextDirection.LeftToRight),
            ["no"] = ("norsk", "Latin", TextDirection.LeftToRight),
            ["nr"] = ("isiNdebele", "Latin", TextDirection.LeftToRight),
            ["nv"] = ("Diné bizaad", "Latin", TextDirection.LeftToRight),
            ["ny"] = ("chiCheŵa", "Latin", TextDirection.LeftToRight),
            ["oc"] = ("occitan", "Latin", TextDirection.LeftToRight),
            ["oj"] = ("ᐊᓂᔑᓈᐯᒧᐎᓐ", "Canadian Aboriginal", TextDirection.LeftToRight),
            ["om"] = ("Afaan Oromoo", "Latin", TextDirection.LeftToRight),
            ["or"] = ("ଓଡ଼ିଆ", "Odia", TextDirection.LeftToRight),
            ["os"] = ("ирон æвзаг", "Cyrillic", TextDirection.LeftToRight),
            ["pa"] = ("ਪੰਜਾਬੀ", "Gurmukhi", TextDirection.LeftToRight),
            ["pi"] = ("पालि", "Devanagari", TextDirection.LeftToRight),
            ["pl"] = ("polski", "Latin", TextDirection.LeftToRight),
            ["ps"] = ("پښتو", "Arabic", TextDirection.RightToLeft),
            ["pt"] = ("português", "Latin", TextDirection.LeftToRight),
            ["qu"] = ("Runa Simi", "Latin", TextDirection.LeftToRight),
            ["rm"] = ("rumantsch", "Latin", TextDirection.LeftToRight),
            ["rn"] = ("Ikirundi", "Latin", TextDirection.LeftToRight),
            ["ro"] = ("română", "Latin", TextDirection.LeftToRight),
            ["ru"] = ("русский", "Cyrillic", TextDirection.LeftToRight),
            ["rw"] = ("Ikinyarwanda", "Latin", TextDirection.LeftToRight),
            ["sa"] = ("संस्कृतम्", "Devanagari", TextDirection.LeftToRight),
            ["sc"] = ("sardu", "Latin", TextDirection.LeftToRight),
            ["sd"] = ("سنڌي", "Arabic", TextDirection.RightToLeft),
            ["se"] = ("davvisámegiella", "Latin", TextDirection.LeftToRight),
            ["sg"] = ("Sängö", "Latin", TextDirection.LeftToRight),
            ["si"] = ("සිංහල", "Sinhala", TextDirection.LeftToRight),
            ["sk"] = ("slovenčina", "Latin", TextDirection.LeftToRight),
            ["sl"] = ("slovenščina", "Latin", TextDirection.LeftToRight),
            ["sm"] = ("gagana Samoa", "Latin", TextDirection.LeftToRight),
            ["sn"] = ("chiShona", "Latin", TextDirection.LeftToRight),
            ["so"] = ("Soomaali", "Latin", TextDirection.LeftToRight),
            ["sq"] = ("shqip", "Latin", TextDirection.LeftToRight),
            ["sr"] = ("српски", "Cyrillic", TextDirection.LeftToRight),
            ["ss"] = ("SiSwati", "Latin", TextDirection.LeftToRight),
            ["st"] = ("Sesotho", "Latin", TextDirection.LeftToRight),
            ["su"] = ("Basa Sunda", "Latin", TextDirection.LeftToRight),
            ["sv"] = ("svenska", "Latin", TextDirection.LeftToRight),
            ["sw"] = ("Kiswahili", "Latin", TextDirection.LeftToRight),
            ["ta"] = ("தமிழ்", "Tamil", TextDirection.LeftToRight),
            ["te"] = ("తెలుగు", "Telugu", TextDirection.LeftToRight),
            ["tg"] = ("тоҷикӣ", "Cyrillic", TextDirection.LeftToRight),
            ["th"] = ("ไทย", "Thai", TextDirection.LeftToRight),
            ["ti"] = ("ትግርኛ", "Ethiopic", TextDirection.LeftToRight),
            ["tk"] = ("Türkmen", "Latin", TextDirection.LeftToRight),
            ["tl"] = ("Wikang Tagalog", "Latin", TextDirection.LeftToRight),
            ["tn"] = ("Setswana", "Latin", TextDirection.LeftToRight),
            ["to"] = ("lea fakatonga", "Latin", TextDirection.LeftToRight),
            ["tr"] = ("Türkçe", "Latin", TextDirection.LeftToRight),
            ["ts"] = ("Xitsonga", "Latin", TextDirection.LeftToRight),
            ["tt"] = ("татар теле", "Cyrillic", TextDirection.LeftToRight),
            ["tw"] = ("Twi", "Latin", TextDirection.LeftToRight),
            ["ty"] = ("Reo Tahiti", "Latin", TextDirection.LeftToRight),
            ["ug"] = ("ئۇيغۇرچە", "Arabic", TextDirection.RightToLeft),
            ["uk"] = ("українська", "Cyrillic", TextDirection.LeftToRight),
            ["ur"] = ("اردو", "Arabic", TextDirection.RightToLeft),
            ["uz"] = ("oʻzbek", "Latin", TextDirection.LeftToRight),
            ["ve"] = ("Tshivenḓa", "Latin", TextDirection.LeftToRight),
            ["vi"] = ("Tiếng Việt", "Latin", TextDirection.LeftToRight),
            ["vo"] = ("Volapük", "Latin", TextDirection.LeftToRight),
            ["wa"] = ("walon", "Latin", TextDirection.LeftToRight),
            ["wo"] = ("Wollof", "Latin", TextDirection.LeftToRight),
            ["xh"] = ("isiXhosa", "Latin", TextDirection.LeftToRight),
            ["yi"] = ("ייִדיש", "Hebrew", TextDirection.RightToLeft),
            ["yo"] = ("Yorùbá", "Latin", TextDirection.LeftToRight),
            ["za"] = ("Saɯ cueŋƅ", "Latin", TextDirection.LeftToRight),
            ["zh"] = ("中文", "Han", TextDirection.LeftToRight),
            ["zu"] = ("isiZulu", "Latin", TextDirection.LeftToRight),
        };

        foreach (var kvp in data)
        {
            var lang = GetAll().FirstOrDefault(l => l.Alpha2Code == kvp.Key);
            if (lang != null)
                lang.SetExtendedData(kvp.Value.Native, kvp.Value.Script, kvp.Value.Dir);
        }
    }

    private static readonly Lazy<IReadOnlyList<Language>> _all = new(() => InitializeAll());

    /// <summary>Gets all languages.</summary>
    public static IReadOnlyList<Language> GetAll() => _all.Value;

    private static List<Language> InitializeAll()
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
            Chamorro,
            Chibcha,
            Chechen,
            Chagatai,
            Chinese,
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
            Dakota,
            Danish,
            Dargwa,
            LandDayakLanguages,
            Delaware,
            Slave,
            German,
            Dogrib,
            Dinka,
            Divehi,
            Dogri,
            DravidianLanguages,
            LowerSorbian,
            Duala,
            DutchMiddle,
            Dutch,
            Dyula,
            Dzongkha,
            Efik,
            EgyptianAncient,
            Ekajuk,
            GreekModern,
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
            Fanti,
            Fijian,
            Filipino,
            Finnish,
            FinnoUgrianLanguages,
            Fon,
            French,
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
            Malay,
            Maltese,
            Manchu,
            Manipuri,
            ManoboLanguages,
            Mohawk,
            Mongolian,
            Mossi,
            Maori,
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

    /// <summary>Gets a dictionary mapping ISO 639-2 alpha-3 codes to languages.</summary>
    public static readonly IReadOnlyDictionary<string, Language> Alpha3CodeMap = new Dictionary<string, Language>
    {
        { Afar.Alpha3Code.ToLowerInvariant(), Afar },
        { Abkhazian.Alpha3Code.ToLowerInvariant(), Abkhazian },
        { Afrikaans.Alpha3Code.ToLowerInvariant(), Afrikaans },
        { Akan.Alpha3Code.ToLowerInvariant(), Akan },
        { Albanian.Alpha3Code.ToLowerInvariant(), Albanian },
        { Amharic.Alpha3Code.ToLowerInvariant(), Amharic },
        { Arabic.Alpha3Code.ToLowerInvariant(), Arabic },
        { Aragonese.Alpha3Code.ToLowerInvariant(), Aragonese },
        { Armenian.Alpha3Code.ToLowerInvariant(), Armenian },
        { Azerbaijani.Alpha3Code.ToLowerInvariant(), Azerbaijani },
        { Bashkir.Alpha3Code.ToLowerInvariant(), Bashkir },
        { Bambara.Alpha3Code.ToLowerInvariant(), Bambara },
        { Basque.Alpha3Code.ToLowerInvariant(), Basque },
        { Belarusian.Alpha3Code.ToLowerInvariant(), Belarusian },
        { Bengali.Alpha3Code.ToLowerInvariant(), Bengali },
        { BihariLanguages.Alpha3Code.ToLowerInvariant(), BihariLanguages },
        { Bislama.Alpha3Code.ToLowerInvariant(), Bislama },
        { Tibetan.Alpha3Code.ToLowerInvariant(), Tibetan },
        { Bosnian.Alpha3Code.ToLowerInvariant(), Bosnian },
        { Breton.Alpha3Code.ToLowerInvariant(), Breton },
        { Bulgarian.Alpha3Code.ToLowerInvariant(), Bulgarian },
        { Burmese.Alpha3Code.ToLowerInvariant(), Burmese },
        { Catalan.Alpha3Code.ToLowerInvariant(), Catalan },
        { Czech.Alpha3Code.ToLowerInvariant(), Czech },
        { Chamorro.Alpha3Code.ToLowerInvariant(), Chamorro },
        { Chechen.Alpha3Code.ToLowerInvariant(), Chechen },
        { Chinese.Alpha3Code.ToLowerInvariant(), Chinese },
        { ChurchSlavic.Alpha3Code.ToLowerInvariant(), ChurchSlavic },
        { Chuvash.Alpha3Code.ToLowerInvariant(), Chuvash },
        { Welsh.Alpha3Code.ToLowerInvariant(), Welsh },
        { Danish.Alpha3Code.ToLowerInvariant(), Danish },
        { German.Alpha3Code.ToLowerInvariant(), German },
        { Divehi.Alpha3Code.ToLowerInvariant(), Divehi },
        { Dutch.Alpha3Code.ToLowerInvariant(), Dutch },
        { Dzongkha.Alpha3Code.ToLowerInvariant(), Dzongkha },
        { GreekModern.Alpha3Code.ToLowerInvariant(), GreekModern },
        { English.Alpha3Code.ToLowerInvariant(), English },
        { Esperanto.Alpha3Code.ToLowerInvariant(), Esperanto },
        { Estonian.Alpha3Code.ToLowerInvariant(), Estonian },
        { Ewe.Alpha3Code.ToLowerInvariant(), Ewe },
        { Faroese.Alpha3Code.ToLowerInvariant(), Faroese },
        { Persian.Alpha3Code.ToLowerInvariant(), Persian },
        { Fijian.Alpha3Code.ToLowerInvariant(), Fijian },
        { Finnish.Alpha3Code.ToLowerInvariant(), Finnish },
        { French.Alpha3Code.ToLowerInvariant(), French },
        { WesternFrisian.Alpha3Code.ToLowerInvariant(), WesternFrisian },
        { Fulah.Alpha3Code.ToLowerInvariant(), Fulah },
        { Georgian.Alpha3Code.ToLowerInvariant(), Georgian },
        { Gaelic.Alpha3Code.ToLowerInvariant(), Gaelic },
        { Irish.Alpha3Code.ToLowerInvariant(), Irish },
        { Galician.Alpha3Code.ToLowerInvariant(), Galician },
        { Manx.Alpha3Code.ToLowerInvariant(), Manx },
        { Gujarati.Alpha3Code.ToLowerInvariant(), Gujarati },
        { Haitian.Alpha3Code.ToLowerInvariant(), Haitian },
        { Hausa.Alpha3Code.ToLowerInvariant(), Hausa },
        { Hebrew.Alpha3Code.ToLowerInvariant(), Hebrew },
        { Herero.Alpha3Code.ToLowerInvariant(), Herero },
        { Hindi.Alpha3Code.ToLowerInvariant(), Hindi },
        { HiriMotu.Alpha3Code.ToLowerInvariant(), HiriMotu },
        { Croatian.Alpha3Code.ToLowerInvariant(), Croatian },
        { Hungarian.Alpha3Code.ToLowerInvariant(), Hungarian },
        { Igbo.Alpha3Code.ToLowerInvariant(), Igbo },
        { Icelandic.Alpha3Code.ToLowerInvariant(), Icelandic },
        { Ido.Alpha3Code.ToLowerInvariant(), Ido },
        { SichuanYi.Alpha3Code.ToLowerInvariant(), SichuanYi },
        { Inuktitut.Alpha3Code.ToLowerInvariant(), Inuktitut },
        { Interlingue.Alpha3Code.ToLowerInvariant(), Interlingue },
        { Interlingua.Alpha3Code.ToLowerInvariant(), Interlingua },
        { Indonesian.Alpha3Code.ToLowerInvariant(), Indonesian },
        { Inupiaq.Alpha3Code.ToLowerInvariant(), Inupiaq },
        { Italian.Alpha3Code.ToLowerInvariant(), Italian },
        { Japanese.Alpha3Code.ToLowerInvariant(), Japanese },
        { Javanese.Alpha3Code.ToLowerInvariant(), Javanese },
        { Kalaallisut.Alpha3Code.ToLowerInvariant(), Kalaallisut },
        { Kannada.Alpha3Code.ToLowerInvariant(), Kannada },
        { Kashmiri.Alpha3Code.ToLowerInvariant(), Kashmiri },
        { Kanuri.Alpha3Code.ToLowerInvariant(), Kanuri },
        { Kazakh.Alpha3Code.ToLowerInvariant(), Kazakh },
        { Kikuyu.Alpha3Code.ToLowerInvariant(), Kikuyu },
        { Kinyarwanda.Alpha3Code.ToLowerInvariant(), Kinyarwanda },
        { Kirghiz.Alpha3Code.ToLowerInvariant(), Kirghiz },
        { Komi.Alpha3Code.ToLowerInvariant(), Komi },
        { Kongo.Alpha3Code.ToLowerInvariant(), Kongo },
        { Korean.Alpha3Code.ToLowerInvariant(), Korean },
        { Kurdish.Alpha3Code.ToLowerInvariant(), Kurdish },
        { Lao.Alpha3Code.ToLowerInvariant(), Lao },
        { Latin.Alpha3Code.ToLowerInvariant(), Latin },
        { Latvian.Alpha3Code.ToLowerInvariant(), Latvian },
        { Limburgan.Alpha3Code.ToLowerInvariant(), Limburgan },
        { Lingala.Alpha3Code.ToLowerInvariant(), Lingala },
        { Lithuanian.Alpha3Code.ToLowerInvariant(), Lithuanian },
        { Luxembourgish.Alpha3Code.ToLowerInvariant(), Luxembourgish },
        { LubaKatanga.Alpha3Code.ToLowerInvariant(), LubaKatanga },
        { Ganda.Alpha3Code.ToLowerInvariant(), Ganda },
        { Macedonian.Alpha3Code.ToLowerInvariant(), Macedonian },
        { Marshallese.Alpha3Code.ToLowerInvariant(), Marshallese },
        { Malayalam.Alpha3Code.ToLowerInvariant(), Malayalam },
        { Marathi.Alpha3Code.ToLowerInvariant(), Marathi },
        { Malay.Alpha3Code.ToLowerInvariant(), Malay },
        { Maltese.Alpha3Code.ToLowerInvariant(), Maltese },
        { Mongolian.Alpha3Code.ToLowerInvariant(), Mongolian },
        { Maori.Alpha3Code.ToLowerInvariant(), Maori },
        { Nauru.Alpha3Code.ToLowerInvariant(), Nauru },
        { Navajo.Alpha3Code.ToLowerInvariant(), Navajo },
        { NdebeleSouth.Alpha3Code.ToLowerInvariant(), NdebeleSouth },
        { NdebeleNorth.Alpha3Code.ToLowerInvariant(), NdebeleNorth },
        { Ndonga.Alpha3Code.ToLowerInvariant(), Ndonga },
        { Nepali.Alpha3Code.ToLowerInvariant(), Nepali },
        { Norwegian.Alpha3Code.ToLowerInvariant(), Norwegian },
        { NorwegianNynorsk.Alpha3Code.ToLowerInvariant(), NorwegianNynorsk },
        { NorwegianBokmal.Alpha3Code.ToLowerInvariant(), NorwegianBokmal },
        { Chichewa.Alpha3Code.ToLowerInvariant(), Chichewa },
        { Occitan.Alpha3Code.ToLowerInvariant(), Occitan },
        { Ojibwa.Alpha3Code.ToLowerInvariant(), Ojibwa },
        { Oriya.Alpha3Code.ToLowerInvariant(), Oriya },
        { Oromo.Alpha3Code.ToLowerInvariant(), Oromo },
        { Ossetian.Alpha3Code.ToLowerInvariant(), Ossetian },
        { Panjabi.Alpha3Code.ToLowerInvariant(), Panjabi },
        { Pali.Alpha3Code.ToLowerInvariant(), Pali },
        { Polish.Alpha3Code.ToLowerInvariant(), Polish },
        { Portuguese.Alpha3Code.ToLowerInvariant(), Portuguese },
        { Pushto.Alpha3Code.ToLowerInvariant(), Pushto },
        { Quechua.Alpha3Code.ToLowerInvariant(), Quechua },
        { Romansh.Alpha3Code.ToLowerInvariant(), Romansh },
        { Romanian.Alpha3Code.ToLowerInvariant(), Romanian },
        { Rundi.Alpha3Code.ToLowerInvariant(), Rundi },
        { Russian.Alpha3Code.ToLowerInvariant(), Russian },
        { Sango.Alpha3Code.ToLowerInvariant(), Sango },
        { Sanskrit.Alpha3Code.ToLowerInvariant(), Sanskrit },
        { Sinhala.Alpha3Code.ToLowerInvariant(), Sinhala },
        { Slovak.Alpha3Code.ToLowerInvariant(), Slovak },
        { Slovenian.Alpha3Code.ToLowerInvariant(), Slovenian },
        { NorthernSami.Alpha3Code.ToLowerInvariant(), NorthernSami },
        { Samoan.Alpha3Code.ToLowerInvariant(), Samoan },
        { Shona.Alpha3Code.ToLowerInvariant(), Shona },
        { Sindhi.Alpha3Code.ToLowerInvariant(), Sindhi },
        { Somali.Alpha3Code.ToLowerInvariant(), Somali },
        { SothoSouthern.Alpha3Code.ToLowerInvariant(), SothoSouthern },
        { Spanish.Alpha3Code.ToLowerInvariant(), Spanish },
        { Sardinian.Alpha3Code.ToLowerInvariant(), Sardinian },
        { Serbian.Alpha3Code.ToLowerInvariant(), Serbian },
        { Swati.Alpha3Code.ToLowerInvariant(), Swati },
        { Sundanese.Alpha3Code.ToLowerInvariant(), Sundanese },
        { Swahili.Alpha3Code.ToLowerInvariant(), Swahili },
        { Swedish.Alpha3Code.ToLowerInvariant(), Swedish },
        { Tamil.Alpha3Code.ToLowerInvariant(), Tamil },
        { Telugu.Alpha3Code.ToLowerInvariant(), Telugu },
        { Tajik.Alpha3Code.ToLowerInvariant(), Tajik },
        { Thai.Alpha3Code.ToLowerInvariant(), Thai },
        { Tigrinya.Alpha3Code.ToLowerInvariant(), Tigrinya },
        { Turkmen.Alpha3Code.ToLowerInvariant(), Turkmen },
        { Tagalog.Alpha3Code.ToLowerInvariant(), Tagalog },
        { Tswana.Alpha3Code.ToLowerInvariant(), Tswana },
        { TongaIslands.Alpha3Code.ToLowerInvariant(), TongaIslands },
        { TongaNyasa.Alpha3Code.ToLowerInvariant(), TongaNyasa },
        { Turkish.Alpha3Code.ToLowerInvariant(), Turkish },
        { Tsonga.Alpha3Code.ToLowerInvariant(), Tsonga },
        { Tatar.Alpha3Code.ToLowerInvariant(), Tatar },
        { Twi.Alpha3Code.ToLowerInvariant(), Twi },
        { Tahitian.Alpha3Code.ToLowerInvariant(), Tahitian },
        { Uighur.Alpha3Code.ToLowerInvariant(), Uighur },
        { Ukrainian.Alpha3Code.ToLowerInvariant(), Ukrainian },
        { Urdu.Alpha3Code.ToLowerInvariant(), Urdu },
        { Uzbek.Alpha3Code.ToLowerInvariant(), Uzbek },
        { Venda.Alpha3Code.ToLowerInvariant(), Venda },
        { Vietnamese.Alpha3Code.ToLowerInvariant(), Vietnamese },
        { Volapuk.Alpha3Code.ToLowerInvariant(), Volapuk },
        { Walloon.Alpha3Code.ToLowerInvariant(), Walloon },
        { Wolof.Alpha3Code.ToLowerInvariant(), Wolof },
        { Xhosa.Alpha3Code.ToLowerInvariant(), Xhosa },
        { Yiddish.Alpha3Code.ToLowerInvariant(), Yiddish },
        { Yoruba.Alpha3Code.ToLowerInvariant(), Yoruba },
        { Zhuang.Alpha3Code.ToLowerInvariant(), Zhuang },
        { Zulu.Alpha3Code.ToLowerInvariant(), Zulu }
    };

    /// <summary>Gets a dictionary mapping ISO 639-1 alpha-2 codes to languages.</summary>
    public static readonly IReadOnlyDictionary<string, Language> Alpha2CodeMap = new Dictionary<string, Language>
    {
        { Afar.Alpha2Code.ToLowerInvariant(), Afar },
        { Abkhazian.Alpha2Code.ToLowerInvariant(), Abkhazian },
        { Afrikaans.Alpha2Code.ToLowerInvariant(), Afrikaans },
        { Akan.Alpha2Code.ToLowerInvariant(), Akan },
        { Albanian.Alpha2Code.ToLowerInvariant(), Albanian },
        { Amharic.Alpha2Code.ToLowerInvariant(), Amharic },
        { Arabic.Alpha2Code.ToLowerInvariant(), Arabic },
        { Aragonese.Alpha2Code.ToLowerInvariant(), Aragonese },
        { Armenian.Alpha2Code.ToLowerInvariant(), Armenian },
        { Azerbaijani.Alpha2Code.ToLowerInvariant(), Azerbaijani },
        { Bashkir.Alpha2Code.ToLowerInvariant(), Bashkir },
        { Bambara.Alpha2Code.ToLowerInvariant(), Bambara },
        { Basque.Alpha2Code.ToLowerInvariant(), Basque },
        { Belarusian.Alpha2Code.ToLowerInvariant(), Belarusian },
        { Bengali.Alpha2Code.ToLowerInvariant(), Bengali },
        { BihariLanguages.Alpha2Code.ToLowerInvariant(), BihariLanguages },
        { Bislama.Alpha2Code.ToLowerInvariant(), Bislama },
        { Tibetan.Alpha2Code.ToLowerInvariant(), Tibetan },
        { Bosnian.Alpha2Code.ToLowerInvariant(), Bosnian },
        { Breton.Alpha2Code.ToLowerInvariant(), Breton },
        { Bulgarian.Alpha2Code.ToLowerInvariant(), Bulgarian },
        { Burmese.Alpha2Code.ToLowerInvariant(), Burmese },
        { Catalan.Alpha2Code.ToLowerInvariant(), Catalan },
        { Czech.Alpha2Code.ToLowerInvariant(), Czech },
        { Chamorro.Alpha2Code.ToLowerInvariant(), Chamorro },
        { Chechen.Alpha2Code.ToLowerInvariant(), Chechen },
        { Chinese.Alpha2Code.ToLowerInvariant(), Chinese },
        { ChurchSlavic.Alpha2Code.ToLowerInvariant(), ChurchSlavic },
        { Chuvash.Alpha2Code.ToLowerInvariant(), Chuvash },
        { Welsh.Alpha2Code.ToLowerInvariant(), Welsh },
        { Danish.Alpha2Code.ToLowerInvariant(), Danish },
        { German.Alpha2Code.ToLowerInvariant(), German },
        { Divehi.Alpha2Code.ToLowerInvariant(), Divehi },
        { Dutch.Alpha2Code.ToLowerInvariant(), Dutch },
        { Dzongkha.Alpha2Code.ToLowerInvariant(), Dzongkha },
        { GreekModern.Alpha2Code.ToLowerInvariant(), GreekModern },
        { English.Alpha2Code.ToLowerInvariant(), English },
        { Esperanto.Alpha2Code.ToLowerInvariant(), Esperanto },
        { Estonian.Alpha2Code.ToLowerInvariant(), Estonian },
        { Ewe.Alpha2Code.ToLowerInvariant(), Ewe },
        { Faroese.Alpha2Code.ToLowerInvariant(), Faroese },
        { Persian.Alpha2Code.ToLowerInvariant(), Persian },
        { Fijian.Alpha2Code.ToLowerInvariant(), Fijian },
        { Finnish.Alpha2Code.ToLowerInvariant(), Finnish },
        { French.Alpha2Code.ToLowerInvariant(), French },
        { WesternFrisian.Alpha2Code.ToLowerInvariant(), WesternFrisian },
        { Fulah.Alpha2Code.ToLowerInvariant(), Fulah },
        { Georgian.Alpha2Code.ToLowerInvariant(), Georgian },
        { Gaelic.Alpha2Code.ToLowerInvariant(), Gaelic },
        { Irish.Alpha2Code.ToLowerInvariant(), Irish },
        { Galician.Alpha2Code.ToLowerInvariant(), Galician },
        { Manx.Alpha2Code.ToLowerInvariant(), Manx },
        { Gujarati.Alpha2Code.ToLowerInvariant(), Gujarati },
        { Haitian.Alpha2Code.ToLowerInvariant(), Haitian },
        { Hausa.Alpha2Code.ToLowerInvariant(), Hausa },
        { Hebrew.Alpha2Code.ToLowerInvariant(), Hebrew },
        { Herero.Alpha2Code.ToLowerInvariant(), Herero },
        { Hindi.Alpha2Code.ToLowerInvariant(), Hindi },
        { HiriMotu.Alpha2Code.ToLowerInvariant(), HiriMotu },
        { Croatian.Alpha2Code.ToLowerInvariant(), Croatian },
        { Hungarian.Alpha2Code.ToLowerInvariant(), Hungarian },
        { Igbo.Alpha2Code.ToLowerInvariant(), Igbo },
        { Icelandic.Alpha2Code.ToLowerInvariant(), Icelandic },
        { Ido.Alpha2Code.ToLowerInvariant(), Ido },
        { SichuanYi.Alpha2Code.ToLowerInvariant(), SichuanYi },
        { Inuktitut.Alpha2Code.ToLowerInvariant(), Inuktitut },
        { Interlingue.Alpha2Code.ToLowerInvariant(), Interlingue },
        { Interlingua.Alpha2Code.ToLowerInvariant(), Interlingua },
        { Indonesian.Alpha2Code.ToLowerInvariant(), Indonesian },
        { Inupiaq.Alpha2Code.ToLowerInvariant(), Inupiaq },
        { Italian.Alpha2Code.ToLowerInvariant(), Italian },
        { Japanese.Alpha2Code.ToLowerInvariant(), Japanese },
        { Javanese.Alpha2Code.ToLowerInvariant(), Javanese },
        { Kalaallisut.Alpha2Code.ToLowerInvariant(), Kalaallisut },
        { Kannada.Alpha2Code.ToLowerInvariant(), Kannada },
        { Kashmiri.Alpha2Code.ToLowerInvariant(), Kashmiri },
        { Kanuri.Alpha2Code.ToLowerInvariant(), Kanuri },
        { Kazakh.Alpha2Code.ToLowerInvariant(), Kazakh },
        { Kikuyu.Alpha2Code.ToLowerInvariant(), Kikuyu },
        { Kinyarwanda.Alpha2Code.ToLowerInvariant(), Kinyarwanda },
        { Kirghiz.Alpha2Code.ToLowerInvariant(), Kirghiz },
        { Komi.Alpha2Code.ToLowerInvariant(), Komi },
        { Kongo.Alpha2Code.ToLowerInvariant(), Kongo },
        { Korean.Alpha2Code.ToLowerInvariant(), Korean },
        { Kurdish.Alpha2Code.ToLowerInvariant(), Kurdish },
        { Lao.Alpha2Code.ToLowerInvariant(), Lao },
        { Latin.Alpha2Code.ToLowerInvariant(), Latin },
        { Latvian.Alpha2Code.ToLowerInvariant(), Latvian },
        { Limburgan.Alpha2Code.ToLowerInvariant(), Limburgan },
        { Lingala.Alpha2Code.ToLowerInvariant(), Lingala },
        { Lithuanian.Alpha2Code.ToLowerInvariant(), Lithuanian },
        { Luxembourgish.Alpha2Code.ToLowerInvariant(), Luxembourgish },
        { LubaKatanga.Alpha2Code.ToLowerInvariant(), LubaKatanga },
        { Ganda.Alpha2Code.ToLowerInvariant(), Ganda },
        { Macedonian.Alpha2Code.ToLowerInvariant(), Macedonian },
        { Marshallese.Alpha2Code.ToLowerInvariant(), Marshallese },
        { Malayalam.Alpha2Code.ToLowerInvariant(), Malayalam },
        { Marathi.Alpha2Code.ToLowerInvariant(), Marathi },
        { Malay.Alpha2Code.ToLowerInvariant(), Malay },
        { Maltese.Alpha2Code.ToLowerInvariant(), Maltese },
        { Mongolian.Alpha2Code.ToLowerInvariant(), Mongolian },
        { Maori.Alpha2Code.ToLowerInvariant(), Maori },
        { Nauru.Alpha2Code.ToLowerInvariant(), Nauru },
        { Navajo.Alpha2Code.ToLowerInvariant(), Navajo },
        { NdebeleSouth.Alpha2Code.ToLowerInvariant(), NdebeleSouth },
        { NdebeleNorth.Alpha2Code.ToLowerInvariant(), NdebeleNorth },
        { Ndonga.Alpha2Code.ToLowerInvariant(), Ndonga },
        { Nepali.Alpha2Code.ToLowerInvariant(), Nepali },
        { Norwegian.Alpha2Code.ToLowerInvariant(), Norwegian },
        { NorwegianNynorsk.Alpha2Code.ToLowerInvariant(), NorwegianNynorsk },
        { NorwegianBokmal.Alpha2Code.ToLowerInvariant(), NorwegianBokmal },
        { Chichewa.Alpha2Code.ToLowerInvariant(), Chichewa },
        { Occitan.Alpha2Code.ToLowerInvariant(), Occitan },
        { Ojibwa.Alpha2Code.ToLowerInvariant(), Ojibwa },
        { Oriya.Alpha2Code.ToLowerInvariant(), Oriya },
        { Oromo.Alpha2Code.ToLowerInvariant(), Oromo },
        { Ossetian.Alpha2Code.ToLowerInvariant(), Ossetian },
        { Panjabi.Alpha2Code.ToLowerInvariant(), Panjabi },
        { Pali.Alpha2Code.ToLowerInvariant(), Pali },
        { Polish.Alpha2Code.ToLowerInvariant(), Polish },
        { Portuguese.Alpha2Code.ToLowerInvariant(), Portuguese },
        { Pushto.Alpha2Code.ToLowerInvariant(), Pushto },
        { Quechua.Alpha2Code.ToLowerInvariant(), Quechua },
        { Romansh.Alpha2Code.ToLowerInvariant(), Romansh },
        { Romanian.Alpha2Code.ToLowerInvariant(), Romanian },
        { Rundi.Alpha2Code.ToLowerInvariant(), Rundi },
        { Russian.Alpha2Code.ToLowerInvariant(), Russian },
        { Sango.Alpha2Code.ToLowerInvariant(), Sango },
        { Sanskrit.Alpha2Code.ToLowerInvariant(), Sanskrit },
        { Sinhala.Alpha2Code.ToLowerInvariant(), Sinhala },
        { Slovak.Alpha2Code.ToLowerInvariant(), Slovak },
        { Slovenian.Alpha2Code.ToLowerInvariant(), Slovenian },
        { NorthernSami.Alpha2Code.ToLowerInvariant(), NorthernSami },
        { Samoan.Alpha2Code.ToLowerInvariant(), Samoan },
        { Shona.Alpha2Code.ToLowerInvariant(), Shona },
        { Sindhi.Alpha2Code.ToLowerInvariant(), Sindhi },
        { Somali.Alpha2Code.ToLowerInvariant(), Somali },
        { SothoSouthern.Alpha2Code.ToLowerInvariant(), SothoSouthern },
        { Spanish.Alpha2Code.ToLowerInvariant(), Spanish },
        { Sardinian.Alpha2Code.ToLowerInvariant(), Sardinian },
        { Serbian.Alpha2Code.ToLowerInvariant(), Serbian },
        { Swati.Alpha2Code.ToLowerInvariant(), Swati },
        { Sundanese.Alpha2Code.ToLowerInvariant(), Sundanese },
        { Swahili.Alpha2Code.ToLowerInvariant(), Swahili },
        { Swedish.Alpha2Code.ToLowerInvariant(), Swedish },
        { Tamil.Alpha2Code.ToLowerInvariant(), Tamil },
        { Telugu.Alpha2Code.ToLowerInvariant(), Telugu },
        { Tajik.Alpha2Code.ToLowerInvariant(), Tajik },
        { Thai.Alpha2Code.ToLowerInvariant(), Thai },
        { Tigrinya.Alpha2Code.ToLowerInvariant(), Tigrinya },
        { Turkmen.Alpha2Code.ToLowerInvariant(), Turkmen },
        { Tagalog.Alpha2Code.ToLowerInvariant(), Tagalog },
        { Tswana.Alpha2Code.ToLowerInvariant(), Tswana },
        { TongaIslands.Alpha2Code.ToLowerInvariant(), TongaIslands },
        { Turkish.Alpha2Code.ToLowerInvariant(), Turkish },
        { Tsonga.Alpha2Code.ToLowerInvariant(), Tsonga },
        { Tatar.Alpha2Code.ToLowerInvariant(), Tatar },
        { Twi.Alpha2Code.ToLowerInvariant(), Twi },
        { Tahitian.Alpha2Code.ToLowerInvariant(), Tahitian },
        { Uighur.Alpha2Code.ToLowerInvariant(), Uighur },
        { Ukrainian.Alpha2Code.ToLowerInvariant(), Ukrainian },
        { Urdu.Alpha2Code.ToLowerInvariant(), Urdu },
        { Uzbek.Alpha2Code.ToLowerInvariant(), Uzbek },
        { Venda.Alpha2Code.ToLowerInvariant(), Venda },
        { Vietnamese.Alpha2Code.ToLowerInvariant(), Vietnamese },
        { Volapuk.Alpha2Code.ToLowerInvariant(), Volapuk },
        { Walloon.Alpha2Code.ToLowerInvariant(), Walloon },
        { Wolof.Alpha2Code.ToLowerInvariant(), Wolof },
        { Xhosa.Alpha2Code.ToLowerInvariant(), Xhosa },
        { Yiddish.Alpha2Code.ToLowerInvariant(), Yiddish },
        { Yoruba.Alpha2Code.ToLowerInvariant(), Yoruba },
        { Zhuang.Alpha2Code.ToLowerInvariant(), Zhuang },
        { Zulu.Alpha2Code.ToLowerInvariant(), Zulu }
    };

    /// <summary>Gets a dictionary mapping language names to languages.</summary>
    public static readonly IReadOnlyDictionary<string, Language> NameMap = new Dictionary<string, Language>
    {
        { Afar.Name.ToLowerInvariant(), Afar },
        { Abkhazian.Name.ToLowerInvariant(), Abkhazian },
        { Afrikaans.Name.ToLowerInvariant(), Afrikaans },
        { Akan.Name.ToLowerInvariant(), Akan },
        { Albanian.Name.ToLowerInvariant(), Albanian },
        { Amharic.Name.ToLowerInvariant(), Amharic },
        { Arabic.Name.ToLowerInvariant(), Arabic },
        { Aragonese.Name.ToLowerInvariant(), Aragonese },
        { Armenian.Name.ToLowerInvariant(), Armenian },
        { Azerbaijani.Name.ToLowerInvariant(), Azerbaijani },
        { Bashkir.Name.ToLowerInvariant(), Bashkir },
        { Bambara.Name.ToLowerInvariant(), Bambara },
        { Basque.Name.ToLowerInvariant(), Basque },
        { Belarusian.Name.ToLowerInvariant(), Belarusian },
        { Bengali.Name.ToLowerInvariant(), Bengali },
        { BihariLanguages.Name.ToLowerInvariant(), BihariLanguages },
        { Bislama.Name.ToLowerInvariant(), Bislama },
        { Tibetan.Name.ToLowerInvariant(), Tibetan },
        { Bosnian.Name.ToLowerInvariant(), Bosnian },
        { Breton.Name.ToLowerInvariant(), Breton },
        { Bulgarian.Name.ToLowerInvariant(), Bulgarian },
        { Burmese.Name.ToLowerInvariant(), Burmese },
        { Catalan.Name.ToLowerInvariant(), Catalan },
        { Czech.Name.ToLowerInvariant(), Czech },
        { Chamorro.Name.ToLowerInvariant(), Chamorro },
        { Chechen.Name.ToLowerInvariant(), Chechen },
        { Chinese.Name.ToLowerInvariant(), Chinese },
        { ChurchSlavic.Name.ToLowerInvariant(), ChurchSlavic },
        { Chuvash.Name.ToLowerInvariant(), Chuvash },
        { Welsh.Name.ToLowerInvariant(), Welsh },
        { Danish.Name.ToLowerInvariant(), Danish },
        { German.Name.ToLowerInvariant(), German },
        { Divehi.Name.ToLowerInvariant(), Divehi },
        { Dutch.Name.ToLowerInvariant(), Dutch },
        { Dzongkha.Name.ToLowerInvariant(), Dzongkha },
        { GreekModern.Name.ToLowerInvariant(), GreekModern },
        { English.Name.ToLowerInvariant(), English },
        { Esperanto.Name.ToLowerInvariant(), Esperanto },
        { Estonian.Name.ToLowerInvariant(), Estonian },
        { Ewe.Name.ToLowerInvariant(), Ewe },
        { Faroese.Name.ToLowerInvariant(), Faroese },
        { Persian.Name.ToLowerInvariant(), Persian },
        { Fijian.Name.ToLowerInvariant(), Fijian },
        { Finnish.Name.ToLowerInvariant(), Finnish },
        { French.Name.ToLowerInvariant(), French },
        { WesternFrisian.Name.ToLowerInvariant(), WesternFrisian },
        { Fulah.Name.ToLowerInvariant(), Fulah },
        { Georgian.Name.ToLowerInvariant(), Georgian },
        { Gaelic.Name.ToLowerInvariant(), Gaelic },
        { Irish.Name.ToLowerInvariant(), Irish },
        { Galician.Name.ToLowerInvariant(), Galician },
        { Manx.Name.ToLowerInvariant(), Manx },
        { Gujarati.Name.ToLowerInvariant(), Gujarati },
        { Haitian.Name.ToLowerInvariant(), Haitian },
        { Hausa.Name.ToLowerInvariant(), Hausa },
        { Hebrew.Name.ToLowerInvariant(), Hebrew },
        { Herero.Name.ToLowerInvariant(), Herero },
        { Hindi.Name.ToLowerInvariant(), Hindi },
        { HiriMotu.Name.ToLowerInvariant(), HiriMotu },
        { Croatian.Name.ToLowerInvariant(), Croatian },
        { Hungarian.Name.ToLowerInvariant(), Hungarian },
        { Igbo.Name.ToLowerInvariant(), Igbo },
        { Icelandic.Name.ToLowerInvariant(), Icelandic },
        { Ido.Name.ToLowerInvariant(), Ido },
        { SichuanYi.Name.ToLowerInvariant(), SichuanYi },
        { Inuktitut.Name.ToLowerInvariant(), Inuktitut },
        { Interlingue.Name.ToLowerInvariant(), Interlingue },
        { Interlingua.Name.ToLowerInvariant(), Interlingua },
        { Indonesian.Name.ToLowerInvariant(), Indonesian },
        { Inupiaq.Name.ToLowerInvariant(), Inupiaq },
        { Italian.Name.ToLowerInvariant(), Italian },
        { Japanese.Name.ToLowerInvariant(), Japanese },
        { Javanese.Name.ToLowerInvariant(), Javanese },
        { Kalaallisut.Name.ToLowerInvariant(), Kalaallisut },
        { Kannada.Name.ToLowerInvariant(), Kannada },
        { Kashmiri.Name.ToLowerInvariant(), Kashmiri },
        { Kanuri.Name.ToLowerInvariant(), Kanuri },
        { Kazakh.Name.ToLowerInvariant(), Kazakh },
        { Kikuyu.Name.ToLowerInvariant(), Kikuyu },
        { Kinyarwanda.Name.ToLowerInvariant(), Kinyarwanda },
        { Kirghiz.Name.ToLowerInvariant(), Kirghiz },
        { Komi.Name.ToLowerInvariant(), Komi },
        { Kongo.Name.ToLowerInvariant(), Kongo },
        { Korean.Name.ToLowerInvariant(), Korean },
        { Kurdish.Name.ToLowerInvariant(), Kurdish },
        { Lao.Name.ToLowerInvariant(), Lao },
        { Latin.Name.ToLowerInvariant(), Latin },
        { Latvian.Name.ToLowerInvariant(), Latvian },
        { Limburgan.Name.ToLowerInvariant(), Limburgan },
        { Lingala.Name.ToLowerInvariant(), Lingala },
        { Lithuanian.Name.ToLowerInvariant(), Lithuanian },
        { Luxembourgish.Name.ToLowerInvariant(), Luxembourgish },
        { LubaKatanga.Name.ToLowerInvariant(), LubaKatanga },
        { Ganda.Name.ToLowerInvariant(), Ganda },
        { Macedonian.Name.ToLowerInvariant(), Macedonian },
        { Marshallese.Name.ToLowerInvariant(), Marshallese },
        { Malayalam.Name.ToLowerInvariant(), Malayalam },
        { Marathi.Name.ToLowerInvariant(), Marathi },
        { Malay.Name.ToLowerInvariant(), Malay },
        { Maltese.Name.ToLowerInvariant(), Maltese },
        { Mongolian.Name.ToLowerInvariant(), Mongolian },
        { Maori.Name.ToLowerInvariant(), Maori },
        { Nauru.Name.ToLowerInvariant(), Nauru },
        { Navajo.Name.ToLowerInvariant(), Navajo },
        { NdebeleSouth.Name.ToLowerInvariant(), NdebeleSouth },
        { NdebeleNorth.Name.ToLowerInvariant(), NdebeleNorth },
        { Ndonga.Name.ToLowerInvariant(), Ndonga },
        { Nepali.Name.ToLowerInvariant(), Nepali },
        { Norwegian.Name.ToLowerInvariant(), Norwegian },
        { NorwegianNynorsk.Name.ToLowerInvariant(), NorwegianNynorsk },
        { NorwegianBokmal.Name.ToLowerInvariant(), NorwegianBokmal },
        { Chichewa.Name.ToLowerInvariant(), Chichewa },
        { Occitan.Name.ToLowerInvariant(), Occitan },
        { Ojibwa.Name.ToLowerInvariant(), Ojibwa },
        { Oriya.Name.ToLowerInvariant(), Oriya },
        { Oromo.Name.ToLowerInvariant(), Oromo },
        { Ossetian.Name.ToLowerInvariant(), Ossetian },
        { Panjabi.Name.ToLowerInvariant(), Panjabi },
        { Pali.Name.ToLowerInvariant(), Pali },
        { Polish.Name.ToLowerInvariant(), Polish },
        { Portuguese.Name.ToLowerInvariant(), Portuguese },
        { Pushto.Name.ToLowerInvariant(), Pushto },
        { Quechua.Name.ToLowerInvariant(), Quechua },
        { Romansh.Name.ToLowerInvariant(), Romansh },
        { Romanian.Name.ToLowerInvariant(), Romanian },
        { Rundi.Name.ToLowerInvariant(), Rundi },
        { Russian.Name.ToLowerInvariant(), Russian },
        { Sango.Name.ToLowerInvariant(), Sango },
        { Sanskrit.Name.ToLowerInvariant(), Sanskrit },
        { Sinhala.Name.ToLowerInvariant(), Sinhala },
        { Slovak.Name.ToLowerInvariant(), Slovak },
        { Slovenian.Name.ToLowerInvariant(), Slovenian },
        { NorthernSami.Name.ToLowerInvariant(), NorthernSami },
        { Samoan.Name.ToLowerInvariant(), Samoan },
        { Shona.Name.ToLowerInvariant(), Shona },
        { Sindhi.Name.ToLowerInvariant(), Sindhi },
        { Somali.Name.ToLowerInvariant(), Somali },
        { SothoSouthern.Name.ToLowerInvariant(), SothoSouthern },
        { Spanish.Name.ToLowerInvariant(), Spanish },
        { Sardinian.Name.ToLowerInvariant(), Sardinian },
        { Serbian.Name.ToLowerInvariant(), Serbian },
        { Swati.Name.ToLowerInvariant(), Swati },
        { Sundanese.Name.ToLowerInvariant(), Sundanese },
        { Swahili.Name.ToLowerInvariant(), Swahili },
        { Swedish.Name.ToLowerInvariant(), Swedish },
        { Tamil.Name.ToLowerInvariant(), Tamil },
        { Telugu.Name.ToLowerInvariant(), Telugu },
        { Tajik.Name.ToLowerInvariant(), Tajik },
        { Thai.Name.ToLowerInvariant(), Thai },
        { Tigrinya.Name.ToLowerInvariant(), Tigrinya },
        { Turkmen.Name.ToLowerInvariant(), Turkmen },
        { Tagalog.Name.ToLowerInvariant(), Tagalog },
        { Tswana.Name.ToLowerInvariant(), Tswana },
        { TongaIslands.Name.ToLowerInvariant(), TongaIslands },
        { TongaNyasa.Name.ToLowerInvariant(), TongaNyasa },
        { Turkish.Name.ToLowerInvariant(), Turkish },
        { Tsonga.Name.ToLowerInvariant(), Tsonga },
        { Tatar.Name.ToLowerInvariant(), Tatar },
        { Twi.Name.ToLowerInvariant(), Twi },
        { Tahitian.Name.ToLowerInvariant(), Tahitian },
        { Uighur.Name.ToLowerInvariant(), Uighur },
        { Ukrainian.Name.ToLowerInvariant(), Ukrainian },
        { Urdu.Name.ToLowerInvariant(), Urdu },
        { Uzbek.Name.ToLowerInvariant(), Uzbek },
        { Venda.Name.ToLowerInvariant(), Venda },
        { Vietnamese.Name.ToLowerInvariant(), Vietnamese },
        { Volapuk.Name.ToLowerInvariant(), Volapuk },
        { Walloon.Name.ToLowerInvariant(), Walloon },
        { Wolof.Name.ToLowerInvariant(), Wolof },
        { Xhosa.Name.ToLowerInvariant(), Xhosa },
        { Yiddish.Name.ToLowerInvariant(), Yiddish },
        { Yoruba.Name.ToLowerInvariant(), Yoruba },
        { Zhuang.Name.ToLowerInvariant(), Zhuang },
        { Zulu.Name.ToLowerInvariant(), Zulu }
    };
}
