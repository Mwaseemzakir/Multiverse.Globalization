using System.Collections.Generic;

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Provides country name translations in multiple languages.
/// </summary>
public static class CountryTranslationHelper
{
    // Outer key: alpha-2 country code, Inner key: language alpha-2 code, Value: translated name
    private static readonly Dictionary<string, Dictionary<string, string>> _data = InitializeData();

    internal static IReadOnlyDictionary<string, string> GetTranslationsForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return new Dictionary<string, string>();
        return _data.TryGetValue(alpha2Code.ToUpperInvariant(), out var t)
            ? t
            : new Dictionary<string, string>();
    }

    internal static string? GetTranslation(string countryAlpha2, string languageAlpha2)
    {
        if (string.IsNullOrWhiteSpace(countryAlpha2) || string.IsNullOrWhiteSpace(languageAlpha2))
            return null;
        if (_data.TryGetValue(countryAlpha2.ToUpperInvariant(), out var translations)
            && translations.TryGetValue(languageAlpha2.ToLowerInvariant(), out var name))
            return name;
        return null;
    }

    private static Dictionary<string, Dictionary<string, string>> InitializeData()
    {
        var d = new Dictionary<string, Dictionary<string, string>>();

        // Translations in: fr (French), es (Spanish), de (German), ar (Arabic), zh (Chinese), ja (Japanese), pt (Portuguese), ru (Russian)

        // ── Americas ──────────────────────────────────────────────────
        d["US"] = new Dictionary<string, string>
        {
            ["fr"] = "États-Unis", ["es"] = "Estados Unidos", ["de"] = "Vereinigte Staaten",
            ["ar"] = "الولايات المتحدة", ["zh"] = "美国", ["ja"] = "アメリカ合衆国",
            ["pt"] = "Estados Unidos", ["ru"] = "Соединённые Штаты"
        };
        d["CA"] = new Dictionary<string, string>
        {
            ["fr"] = "Canada", ["es"] = "Canadá", ["de"] = "Kanada",
            ["ar"] = "كندا", ["zh"] = "加拿大", ["ja"] = "カナダ",
            ["pt"] = "Canadá", ["ru"] = "Канада"
        };
        d["MX"] = new Dictionary<string, string>
        {
            ["fr"] = "Mexique", ["es"] = "México", ["de"] = "Mexiko",
            ["ar"] = "المكسيك", ["zh"] = "墨西哥", ["ja"] = "メキシコ",
            ["pt"] = "México", ["ru"] = "Мексика"
        };
        d["BR"] = new Dictionary<string, string>
        {
            ["fr"] = "Brésil", ["es"] = "Brasil", ["de"] = "Brasilien",
            ["ar"] = "البرازيل", ["zh"] = "巴西", ["ja"] = "ブラジル",
            ["pt"] = "Brasil", ["ru"] = "Бразилия"
        };
        d["AR"] = new Dictionary<string, string>
        {
            ["fr"] = "Argentine", ["es"] = "Argentina", ["de"] = "Argentinien",
            ["ar"] = "الأرجنتين", ["zh"] = "阿根廷", ["ja"] = "アルゼンチン",
            ["pt"] = "Argentina", ["ru"] = "Аргентина"
        };
        d["CO"] = new Dictionary<string, string>
        {
            ["fr"] = "Colombie", ["es"] = "Colombia", ["de"] = "Kolumbien",
            ["ar"] = "كولومبيا", ["zh"] = "哥伦比亚", ["ja"] = "コロンビア",
            ["pt"] = "Colômbia", ["ru"] = "Колумбия"
        };
        d["CL"] = new Dictionary<string, string>
        {
            ["fr"] = "Chili", ["es"] = "Chile", ["de"] = "Chile",
            ["ar"] = "تشيلي", ["zh"] = "智利", ["ja"] = "チリ",
            ["pt"] = "Chile", ["ru"] = "Чили"
        };
        d["PE"] = new Dictionary<string, string>
        {
            ["fr"] = "Pérou", ["es"] = "Perú", ["de"] = "Peru",
            ["ar"] = "بيرو", ["zh"] = "秘鲁", ["ja"] = "ペルー",
            ["pt"] = "Peru", ["ru"] = "Перу"
        };
        d["VE"] = new Dictionary<string, string>
        {
            ["fr"] = "Venezuela", ["es"] = "Venezuela", ["de"] = "Venezuela",
            ["ar"] = "فنزويلا", ["zh"] = "委内瑞拉", ["ja"] = "ベネズエラ",
            ["pt"] = "Venezuela", ["ru"] = "Венесуэла"
        };
        d["EC"] = new Dictionary<string, string>
        {
            ["fr"] = "Équateur", ["es"] = "Ecuador", ["de"] = "Ecuador",
            ["ar"] = "الإكوادور", ["zh"] = "厄瓜多尔", ["ja"] = "エクアドル",
            ["pt"] = "Equador", ["ru"] = "Эквадор"
        };
        d["BO"] = new Dictionary<string, string>
        {
            ["fr"] = "Bolivie", ["es"] = "Bolivia", ["de"] = "Bolivien",
            ["ar"] = "بوليفيا", ["zh"] = "玻利维亚", ["ja"] = "ボリビア",
            ["pt"] = "Bolívia", ["ru"] = "Боливия"
        };
        d["PY"] = new Dictionary<string, string>
        {
            ["fr"] = "Paraguay", ["es"] = "Paraguay", ["de"] = "Paraguay",
            ["ar"] = "باراغواي", ["zh"] = "巴拉圭", ["ja"] = "パラグアイ",
            ["pt"] = "Paraguai", ["ru"] = "Парагвай"
        };
        d["UY"] = new Dictionary<string, string>
        {
            ["fr"] = "Uruguay", ["es"] = "Uruguay", ["de"] = "Uruguay",
            ["ar"] = "الأوروغواي", ["zh"] = "乌拉圭", ["ja"] = "ウルグアイ",
            ["pt"] = "Uruguai", ["ru"] = "Уругвай"
        };
        d["GY"] = new Dictionary<string, string>
        {
            ["fr"] = "Guyana", ["es"] = "Guyana", ["de"] = "Guyana",
            ["ar"] = "غيانا", ["zh"] = "圭亚那", ["ja"] = "ガイアナ",
            ["pt"] = "Guiana", ["ru"] = "Гайана"
        };
        d["SR"] = new Dictionary<string, string>
        {
            ["fr"] = "Suriname", ["es"] = "Surinam", ["de"] = "Suriname",
            ["ar"] = "سورينام", ["zh"] = "苏里南", ["ja"] = "スリナム",
            ["pt"] = "Suriname", ["ru"] = "Суринам"
        };
        d["AG"] = new Dictionary<string, string>
        {
            ["fr"] = "Antigua-et-Barbuda", ["es"] = "Antigua y Barbuda", ["de"] = "Antigua und Barbuda",
            ["ar"] = "أنتيغوا وباربودا", ["zh"] = "安提瓜和巴布达", ["ja"] = "アンティグア・バーブーダ",
            ["pt"] = "Antígua e Barbuda", ["ru"] = "Антигуа и Барбуда"
        };
        d["BS"] = new Dictionary<string, string>
        {
            ["fr"] = "Bahamas", ["es"] = "Bahamas", ["de"] = "Bahamas",
            ["ar"] = "باهاماس", ["zh"] = "巴哈马", ["ja"] = "バハマ",
            ["pt"] = "Bahamas", ["ru"] = "Багамы"
        };
        d["BB"] = new Dictionary<string, string>
        {
            ["fr"] = "Barbade", ["es"] = "Barbados", ["de"] = "Barbados",
            ["ar"] = "باربادوس", ["zh"] = "巴巴多斯", ["ja"] = "バルバドス",
            ["pt"] = "Barbados", ["ru"] = "Барбадос"
        };
        d["BZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Belize", ["es"] = "Belice", ["de"] = "Belize",
            ["ar"] = "بليز", ["zh"] = "伯利兹", ["ja"] = "ベリーズ",
            ["pt"] = "Belize", ["ru"] = "Белиз"
        };
        d["CR"] = new Dictionary<string, string>
        {
            ["fr"] = "Costa Rica", ["es"] = "Costa Rica", ["de"] = "Costa Rica",
            ["ar"] = "كوستاريكا", ["zh"] = "哥斯达黎加", ["ja"] = "コスタリカ",
            ["pt"] = "Costa Rica", ["ru"] = "Коста-Рика"
        };
        d["CU"] = new Dictionary<string, string>
        {
            ["fr"] = "Cuba", ["es"] = "Cuba", ["de"] = "Kuba",
            ["ar"] = "كوبا", ["zh"] = "古巴", ["ja"] = "キューバ",
            ["pt"] = "Cuba", ["ru"] = "Куба"
        };
        d["DM"] = new Dictionary<string, string>
        {
            ["fr"] = "Dominique", ["es"] = "Dominica", ["de"] = "Dominica",
            ["ar"] = "دومينيكا", ["zh"] = "多米尼克", ["ja"] = "ドミニカ国",
            ["pt"] = "Dominica", ["ru"] = "Доминика"
        };
        d["DO"] = new Dictionary<string, string>
        {
            ["fr"] = "République dominicaine", ["es"] = "República Dominicana", ["de"] = "Dominikanische Republik",
            ["ar"] = "جمهورية الدومينيكان", ["zh"] = "多米尼加共和国", ["ja"] = "ドミニカ共和国",
            ["pt"] = "República Dominicana", ["ru"] = "Доминиканская Республика"
        };
        d["SV"] = new Dictionary<string, string>
        {
            ["fr"] = "Salvador", ["es"] = "El Salvador", ["de"] = "El Salvador",
            ["ar"] = "السلفادور", ["zh"] = "萨尔瓦多", ["ja"] = "エルサルバドル",
            ["pt"] = "El Salvador", ["ru"] = "Сальвадор"
        };
        d["GD"] = new Dictionary<string, string>
        {
            ["fr"] = "Grenade", ["es"] = "Granada", ["de"] = "Grenada",
            ["ar"] = "غرينادا", ["zh"] = "格林纳达", ["ja"] = "グレナダ",
            ["pt"] = "Granada", ["ru"] = "Гренада"
        };
        d["GT"] = new Dictionary<string, string>
        {
            ["fr"] = "Guatemala", ["es"] = "Guatemala", ["de"] = "Guatemala",
            ["ar"] = "غواتيمالا", ["zh"] = "危地马拉", ["ja"] = "グアテマラ",
            ["pt"] = "Guatemala", ["ru"] = "Гватемала"
        };
        d["HT"] = new Dictionary<string, string>
        {
            ["fr"] = "Haïti", ["es"] = "Haití", ["de"] = "Haiti",
            ["ar"] = "هايتي", ["zh"] = "海地", ["ja"] = "ハイチ",
            ["pt"] = "Haiti", ["ru"] = "Гаити"
        };
        d["HN"] = new Dictionary<string, string>
        {
            ["fr"] = "Honduras", ["es"] = "Honduras", ["de"] = "Honduras",
            ["ar"] = "هندوراس", ["zh"] = "洪都拉斯", ["ja"] = "ホンジュラス",
            ["pt"] = "Honduras", ["ru"] = "Гондурас"
        };
        d["JM"] = new Dictionary<string, string>
        {
            ["fr"] = "Jamaïque", ["es"] = "Jamaica", ["de"] = "Jamaika",
            ["ar"] = "جامايكا", ["zh"] = "牙买加", ["ja"] = "ジャマイカ",
            ["pt"] = "Jamaica", ["ru"] = "Ямайка"
        };
        d["NI"] = new Dictionary<string, string>
        {
            ["fr"] = "Nicaragua", ["es"] = "Nicaragua", ["de"] = "Nicaragua",
            ["ar"] = "نيكاراغوا", ["zh"] = "尼加拉瓜", ["ja"] = "ニカラグア",
            ["pt"] = "Nicarágua", ["ru"] = "Никарагуа"
        };
        d["PA"] = new Dictionary<string, string>
        {
            ["fr"] = "Panama", ["es"] = "Panamá", ["de"] = "Panama",
            ["ar"] = "بنما", ["zh"] = "巴拿马", ["ja"] = "パナマ",
            ["pt"] = "Panamá", ["ru"] = "Панама"
        };
        d["KN"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Kitts-et-Nevis", ["es"] = "San Cristóbal y Nieves", ["de"] = "St. Kitts und Nevis",
            ["ar"] = "سانت كيتس ونيفيس", ["zh"] = "圣基茨和尼维斯", ["ja"] = "セントクリストファー・ネービス",
            ["pt"] = "São Cristóvão e Névis", ["ru"] = "Сент-Китс и Невис"
        };
        d["LC"] = new Dictionary<string, string>
        {
            ["fr"] = "Sainte-Lucie", ["es"] = "Santa Lucía", ["de"] = "St. Lucia",
            ["ar"] = "سانت لوسيا", ["zh"] = "圣卢西亚", ["ja"] = "セントルシア",
            ["pt"] = "Santa Lúcia", ["ru"] = "Сент-Люсия"
        };
        d["VC"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Vincent-et-les-Grenadines", ["es"] = "San Vicente y las Granadinas", ["de"] = "St. Vincent und die Grenadinen",
            ["ar"] = "سانت فنسنت والغرينادين", ["zh"] = "圣文森特和格林纳丁斯", ["ja"] = "セントビンセント・グレナディーン",
            ["pt"] = "São Vicente e Granadinas", ["ru"] = "Сент-Винсент и Гренадины"
        };
        d["TT"] = new Dictionary<string, string>
        {
            ["fr"] = "Trinité-et-Tobago", ["es"] = "Trinidad y Tobago", ["de"] = "Trinidad und Tobago",
            ["ar"] = "ترينيداد وتوباغو", ["zh"] = "特立尼达和多巴哥", ["ja"] = "トリニダード・トバゴ",
            ["pt"] = "Trindade e Tobago", ["ru"] = "Тринидад и Тобаго"
        };

        // ── Europe ────────────────────────────────────────────────────
        d["GB"] = new Dictionary<string, string>
        {
            ["fr"] = "Royaume-Uni", ["es"] = "Reino Unido", ["de"] = "Vereinigtes Königreich",
            ["ar"] = "المملكة المتحدة", ["zh"] = "英国", ["ja"] = "イギリス",
            ["pt"] = "Reino Unido", ["ru"] = "Великобритания"
        };
        d["DE"] = new Dictionary<string, string>
        {
            ["fr"] = "Allemagne", ["es"] = "Alemania", ["de"] = "Deutschland",
            ["ar"] = "ألمانيا", ["zh"] = "德国", ["ja"] = "ドイツ",
            ["pt"] = "Alemanha", ["ru"] = "Германия"
        };
        d["FR"] = new Dictionary<string, string>
        {
            ["fr"] = "France", ["es"] = "Francia", ["de"] = "Frankreich",
            ["ar"] = "فرنسا", ["zh"] = "法国", ["ja"] = "フランス",
            ["pt"] = "França", ["ru"] = "Франция"
        };
        d["IT"] = new Dictionary<string, string>
        {
            ["fr"] = "Italie", ["es"] = "Italia", ["de"] = "Italien",
            ["ar"] = "إيطاليا", ["zh"] = "意大利", ["ja"] = "イタリア",
            ["pt"] = "Itália", ["ru"] = "Италия"
        };
        d["ES"] = new Dictionary<string, string>
        {
            ["fr"] = "Espagne", ["es"] = "España", ["de"] = "Spanien",
            ["ar"] = "إسبانيا", ["zh"] = "西班牙", ["ja"] = "スペイン",
            ["pt"] = "Espanha", ["ru"] = "Испания"
        };
        d["PT"] = new Dictionary<string, string>
        {
            ["fr"] = "Portugal", ["es"] = "Portugal", ["de"] = "Portugal",
            ["ar"] = "البرتغال", ["zh"] = "葡萄牙", ["ja"] = "ポルトガル",
            ["pt"] = "Portugal", ["ru"] = "Португалия"
        };
        d["NL"] = new Dictionary<string, string>
        {
            ["fr"] = "Pays-Bas", ["es"] = "Países Bajos", ["de"] = "Niederlande",
            ["ar"] = "هولندا", ["zh"] = "荷兰", ["ja"] = "オランダ",
            ["pt"] = "Países Baixos", ["ru"] = "Нидерланды"
        };
        d["BE"] = new Dictionary<string, string>
        {
            ["fr"] = "Belgique", ["es"] = "Bélgica", ["de"] = "Belgien",
            ["ar"] = "بلجيكا", ["zh"] = "比利时", ["ja"] = "ベルギー",
            ["pt"] = "Bélgica", ["ru"] = "Бельгия"
        };
        d["CH"] = new Dictionary<string, string>
        {
            ["fr"] = "Suisse", ["es"] = "Suiza", ["de"] = "Schweiz",
            ["ar"] = "سويسرا", ["zh"] = "瑞士", ["ja"] = "スイス",
            ["pt"] = "Suíça", ["ru"] = "Швейцария"
        };
        d["AT"] = new Dictionary<string, string>
        {
            ["fr"] = "Autriche", ["es"] = "Austria", ["de"] = "Österreich",
            ["ar"] = "النمسا", ["zh"] = "奥地利", ["ja"] = "オーストリア",
            ["pt"] = "Áustria", ["ru"] = "Австрия"
        };
        d["SE"] = new Dictionary<string, string>
        {
            ["fr"] = "Suède", ["es"] = "Suecia", ["de"] = "Schweden",
            ["ar"] = "السويد", ["zh"] = "瑞典", ["ja"] = "スウェーデン",
            ["pt"] = "Suécia", ["ru"] = "Швеция"
        };
        d["NO"] = new Dictionary<string, string>
        {
            ["fr"] = "Norvège", ["es"] = "Noruega", ["de"] = "Norwegen",
            ["ar"] = "النرويج", ["zh"] = "挪威", ["ja"] = "ノルウェー",
            ["pt"] = "Noruega", ["ru"] = "Норвегия"
        };
        d["DK"] = new Dictionary<string, string>
        {
            ["fr"] = "Danemark", ["es"] = "Dinamarca", ["de"] = "Dänemark",
            ["ar"] = "الدنمارك", ["zh"] = "丹麦", ["ja"] = "デンマーク",
            ["pt"] = "Dinamarca", ["ru"] = "Дания"
        };
        d["FI"] = new Dictionary<string, string>
        {
            ["fr"] = "Finlande", ["es"] = "Finlandia", ["de"] = "Finnland",
            ["ar"] = "فنلندا", ["zh"] = "芬兰", ["ja"] = "フィンランド",
            ["pt"] = "Finlândia", ["ru"] = "Финляндия"
        };
        d["PL"] = new Dictionary<string, string>
        {
            ["fr"] = "Pologne", ["es"] = "Polonia", ["de"] = "Polen",
            ["ar"] = "بولندا", ["zh"] = "波兰", ["ja"] = "ポーランド",
            ["pt"] = "Polónia", ["ru"] = "Польша"
        };
        d["CZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Tchéquie", ["es"] = "Chequia", ["de"] = "Tschechien",
            ["ar"] = "التشيك", ["zh"] = "捷克", ["ja"] = "チェコ",
            ["pt"] = "Chéquia", ["ru"] = "Чехия"
        };
        d["HU"] = new Dictionary<string, string>
        {
            ["fr"] = "Hongrie", ["es"] = "Hungría", ["de"] = "Ungarn",
            ["ar"] = "المجر", ["zh"] = "匈牙利", ["ja"] = "ハンガリー",
            ["pt"] = "Hungria", ["ru"] = "Венгрия"
        };
        d["RO"] = new Dictionary<string, string>
        {
            ["fr"] = "Roumanie", ["es"] = "Rumania", ["de"] = "Rumänien",
            ["ar"] = "رومانيا", ["zh"] = "罗马尼亚", ["ja"] = "ルーマニア",
            ["pt"] = "Roménia", ["ru"] = "Румыния"
        };
        d["GR"] = new Dictionary<string, string>
        {
            ["fr"] = "Grèce", ["es"] = "Grecia", ["de"] = "Griechenland",
            ["ar"] = "اليونان", ["zh"] = "希腊", ["ja"] = "ギリシャ",
            ["pt"] = "Grécia", ["ru"] = "Греция"
        };
        d["IE"] = new Dictionary<string, string>
        {
            ["fr"] = "Irlande", ["es"] = "Irlanda", ["de"] = "Irland",
            ["ar"] = "أيرلندا", ["zh"] = "爱尔兰", ["ja"] = "アイルランド",
            ["pt"] = "Irlanda", ["ru"] = "Ирландия"
        };
        d["RU"] = new Dictionary<string, string>
        {
            ["fr"] = "Russie", ["es"] = "Rusia", ["de"] = "Russland",
            ["ar"] = "روسيا", ["zh"] = "俄罗斯", ["ja"] = "ロシア",
            ["pt"] = "Rússia", ["ru"] = "Россия"
        };
        d["UA"] = new Dictionary<string, string>
        {
            ["fr"] = "Ukraine", ["es"] = "Ucrania", ["de"] = "Ukraine",
            ["ar"] = "أوكرانيا", ["zh"] = "乌克兰", ["ja"] = "ウクライナ",
            ["pt"] = "Ucrânia", ["ru"] = "Украина"
        };
        d["TR"] = new Dictionary<string, string>
        {
            ["fr"] = "Turquie", ["es"] = "Turquía", ["de"] = "Türkei",
            ["ar"] = "تركيا", ["zh"] = "土耳其", ["ja"] = "トルコ",
            ["pt"] = "Turquia", ["ru"] = "Турция"
        };
        d["AL"] = new Dictionary<string, string>
        {
            ["fr"] = "Albanie", ["es"] = "Albania", ["de"] = "Albanien",
            ["ar"] = "ألبانيا", ["zh"] = "阿尔巴尼亚", ["ja"] = "アルバニア",
            ["pt"] = "Albânia", ["ru"] = "Албания"
        };
        d["AD"] = new Dictionary<string, string>
        {
            ["fr"] = "Andorre", ["es"] = "Andorra", ["de"] = "Andorra",
            ["ar"] = "أندورا", ["zh"] = "安道尔", ["ja"] = "アンドラ",
            ["pt"] = "Andorra", ["ru"] = "Андорра"
        };
        d["BY"] = new Dictionary<string, string>
        {
            ["fr"] = "Biélorussie", ["es"] = "Bielorrusia", ["de"] = "Belarus",
            ["ar"] = "بيلاروسيا", ["zh"] = "白俄罗斯", ["ja"] = "ベラルーシ",
            ["pt"] = "Bielorrússia", ["ru"] = "Беларусь"
        };
        d["BA"] = new Dictionary<string, string>
        {
            ["fr"] = "Bosnie-Herzégovine", ["es"] = "Bosnia y Herzegovina", ["de"] = "Bosnien und Herzegowina",
            ["ar"] = "البوسنة والهرسك", ["zh"] = "波斯尼亚和黑塞哥维那", ["ja"] = "ボスニア・ヘルツェゴビナ",
            ["pt"] = "Bósnia e Herzegovina", ["ru"] = "Босния и Герцеговина"
        };
        d["BG"] = new Dictionary<string, string>
        {
            ["fr"] = "Bulgarie", ["es"] = "Bulgaria", ["de"] = "Bulgarien",
            ["ar"] = "بلغاريا", ["zh"] = "保加利亚", ["ja"] = "ブルガリア",
            ["pt"] = "Bulgária", ["ru"] = "Болгария"
        };
        d["HR"] = new Dictionary<string, string>
        {
            ["fr"] = "Croatie", ["es"] = "Croacia", ["de"] = "Kroatien",
            ["ar"] = "كرواتيا", ["zh"] = "克罗地亚", ["ja"] = "クロアチア",
            ["pt"] = "Croácia", ["ru"] = "Хорватия"
        };
        d["EE"] = new Dictionary<string, string>
        {
            ["fr"] = "Estonie", ["es"] = "Estonia", ["de"] = "Estland",
            ["ar"] = "إستونيا", ["zh"] = "爱沙尼亚", ["ja"] = "エストニア",
            ["pt"] = "Estónia", ["ru"] = "Эстония"
        };
        d["IS"] = new Dictionary<string, string>
        {
            ["fr"] = "Islande", ["es"] = "Islandia", ["de"] = "Island",
            ["ar"] = "آيسلندا", ["zh"] = "冰岛", ["ja"] = "アイスランド",
            ["pt"] = "Islândia", ["ru"] = "Исландия"
        };
        d["LV"] = new Dictionary<string, string>
        {
            ["fr"] = "Lettonie", ["es"] = "Letonia", ["de"] = "Lettland",
            ["ar"] = "لاتفيا", ["zh"] = "拉脱维亚", ["ja"] = "ラトビア",
            ["pt"] = "Letónia", ["ru"] = "Латвия"
        };
        d["LI"] = new Dictionary<string, string>
        {
            ["fr"] = "Liechtenstein", ["es"] = "Liechtenstein", ["de"] = "Liechtenstein",
            ["ar"] = "ليختنشتاين", ["zh"] = "列支敦士登", ["ja"] = "リヒテンシュタイン",
            ["pt"] = "Liechtenstein", ["ru"] = "Лихтенштейн"
        };
        d["LT"] = new Dictionary<string, string>
        {
            ["fr"] = "Lituanie", ["es"] = "Lituania", ["de"] = "Litauen",
            ["ar"] = "ليتوانيا", ["zh"] = "立陶宛", ["ja"] = "リトアニア",
            ["pt"] = "Lituânia", ["ru"] = "Литва"
        };
        d["LU"] = new Dictionary<string, string>
        {
            ["fr"] = "Luxembourg", ["es"] = "Luxemburgo", ["de"] = "Luxemburg",
            ["ar"] = "لوكسمبورغ", ["zh"] = "卢森堡", ["ja"] = "ルクセンブルク",
            ["pt"] = "Luxemburgo", ["ru"] = "Люксембург"
        };
        d["MT"] = new Dictionary<string, string>
        {
            ["fr"] = "Malte", ["es"] = "Malta", ["de"] = "Malta",
            ["ar"] = "مالطا", ["zh"] = "马耳他", ["ja"] = "マルタ",
            ["pt"] = "Malta", ["ru"] = "Мальта"
        };
        d["MD"] = new Dictionary<string, string>
        {
            ["fr"] = "Moldavie", ["es"] = "Moldavia", ["de"] = "Moldau",
            ["ar"] = "مولدوفا", ["zh"] = "摩尔多瓦", ["ja"] = "モルドバ",
            ["pt"] = "Moldávia", ["ru"] = "Молдавия"
        };
        d["MC"] = new Dictionary<string, string>
        {
            ["fr"] = "Monaco", ["es"] = "Mónaco", ["de"] = "Monaco",
            ["ar"] = "موناكو", ["zh"] = "摩纳哥", ["ja"] = "モナコ",
            ["pt"] = "Mónaco", ["ru"] = "Монако"
        };
        d["ME"] = new Dictionary<string, string>
        {
            ["fr"] = "Monténégro", ["es"] = "Montenegro", ["de"] = "Montenegro",
            ["ar"] = "الجبل الأسود", ["zh"] = "黑山", ["ja"] = "モンテネグロ",
            ["pt"] = "Montenegro", ["ru"] = "Черногория"
        };
        d["MK"] = new Dictionary<string, string>
        {
            ["fr"] = "Macédoine du Nord", ["es"] = "Macedonia del Norte", ["de"] = "Nordmazedonien",
            ["ar"] = "مقدونيا الشمالية", ["zh"] = "北马其顿", ["ja"] = "北マケドニア",
            ["pt"] = "Macedónia do Norte", ["ru"] = "Северная Македония"
        };
        d["RS"] = new Dictionary<string, string>
        {
            ["fr"] = "Serbie", ["es"] = "Serbia", ["de"] = "Serbien",
            ["ar"] = "صربيا", ["zh"] = "塞尔维亚", ["ja"] = "セルビア",
            ["pt"] = "Sérvia", ["ru"] = "Сербия"
        };
        d["SK"] = new Dictionary<string, string>
        {
            ["fr"] = "Slovaquie", ["es"] = "Eslovaquia", ["de"] = "Slowakei",
            ["ar"] = "سلوفاكيا", ["zh"] = "斯洛伐克", ["ja"] = "スロバキア",
            ["pt"] = "Eslováquia", ["ru"] = "Словакия"
        };
        d["SI"] = new Dictionary<string, string>
        {
            ["fr"] = "Slovénie", ["es"] = "Eslovenia", ["de"] = "Slowenien",
            ["ar"] = "سلوفينيا", ["zh"] = "斯洛文尼亚", ["ja"] = "スロベニア",
            ["pt"] = "Eslovénia", ["ru"] = "Словения"
        };
        d["SM"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Marin", ["es"] = "San Marino", ["de"] = "San Marino",
            ["ar"] = "سان مارينو", ["zh"] = "圣马力诺", ["ja"] = "サンマリノ",
            ["pt"] = "São Marinho", ["ru"] = "Сан-Марино"
        };
        d["VA"] = new Dictionary<string, string>
        {
            ["fr"] = "Vatican", ["es"] = "Ciudad del Vaticano", ["de"] = "Vatikanstadt",
            ["ar"] = "الفاتيكان", ["zh"] = "梵蒂冈", ["ja"] = "バチカン市国",
            ["pt"] = "Vaticano", ["ru"] = "Ватикан"
        };
        d["XK"] = new Dictionary<string, string>
        {
            ["fr"] = "Kosovo", ["es"] = "Kosovo", ["de"] = "Kosovo",
            ["ar"] = "كوسوفو", ["zh"] = "科索沃", ["ja"] = "コソボ",
            ["pt"] = "Kosovo", ["ru"] = "Косово"
        };

        // ── Asia ──────────────────────────────────────────────────────
        d["JP"] = new Dictionary<string, string>
        {
            ["fr"] = "Japon", ["es"] = "Japón", ["de"] = "Japan",
            ["ar"] = "اليابان", ["zh"] = "日本", ["ja"] = "日本",
            ["pt"] = "Japão", ["ru"] = "Япония"
        };
        d["CN"] = new Dictionary<string, string>
        {
            ["fr"] = "Chine", ["es"] = "China", ["de"] = "China",
            ["ar"] = "الصين", ["zh"] = "中国", ["ja"] = "中国",
            ["pt"] = "China", ["ru"] = "Китай"
        };
        d["IN"] = new Dictionary<string, string>
        {
            ["fr"] = "Inde", ["es"] = "India", ["de"] = "Indien",
            ["ar"] = "الهند", ["zh"] = "印度", ["ja"] = "インド",
            ["pt"] = "Índia", ["ru"] = "Индия"
        };
        d["KR"] = new Dictionary<string, string>
        {
            ["fr"] = "Corée du Sud", ["es"] = "Corea del Sur", ["de"] = "Südkorea",
            ["ar"] = "كوريا الجنوبية", ["zh"] = "韩国", ["ja"] = "韓国",
            ["pt"] = "Coreia do Sul", ["ru"] = "Республика Корея"
        };
        d["PK"] = new Dictionary<string, string>
        {
            ["fr"] = "Pakistan", ["es"] = "Pakistán", ["de"] = "Pakistan",
            ["ar"] = "باكستان", ["zh"] = "巴基斯坦", ["ja"] = "パキスタン",
            ["pt"] = "Paquistão", ["ru"] = "Пакистан"
        };
        d["BD"] = new Dictionary<string, string>
        {
            ["fr"] = "Bangladesh", ["es"] = "Bangladés", ["de"] = "Bangladesch",
            ["ar"] = "بنغلاديش", ["zh"] = "孟加拉国", ["ja"] = "バングラデシュ",
            ["pt"] = "Bangladesh", ["ru"] = "Бангладеш"
        };
        d["ID"] = new Dictionary<string, string>
        {
            ["fr"] = "Indonésie", ["es"] = "Indonesia", ["de"] = "Indonesien",
            ["ar"] = "إندونيسيا", ["zh"] = "印度尼西亚", ["ja"] = "インドネシア",
            ["pt"] = "Indonésia", ["ru"] = "Индонезия"
        };
        d["PH"] = new Dictionary<string, string>
        {
            ["fr"] = "Philippines", ["es"] = "Filipinas", ["de"] = "Philippinen",
            ["ar"] = "الفلبين", ["zh"] = "菲律宾", ["ja"] = "フィリピン",
            ["pt"] = "Filipinas", ["ru"] = "Филиппины"
        };
        d["VN"] = new Dictionary<string, string>
        {
            ["fr"] = "Viêt Nam", ["es"] = "Vietnam", ["de"] = "Vietnam",
            ["ar"] = "فيتنام", ["zh"] = "越南", ["ja"] = "ベトナム",
            ["pt"] = "Vietnã", ["ru"] = "Вьетнам"
        };
        d["TH"] = new Dictionary<string, string>
        {
            ["fr"] = "Thaïlande", ["es"] = "Tailandia", ["de"] = "Thailand",
            ["ar"] = "تايلاند", ["zh"] = "泰国", ["ja"] = "タイ",
            ["pt"] = "Tailândia", ["ru"] = "Таиланд"
        };
        d["MY"] = new Dictionary<string, string>
        {
            ["fr"] = "Malaisie", ["es"] = "Malasia", ["de"] = "Malaysia",
            ["ar"] = "ماليزيا", ["zh"] = "马来西亚", ["ja"] = "マレーシア",
            ["pt"] = "Malásia", ["ru"] = "Малайзия"
        };
        d["SG"] = new Dictionary<string, string>
        {
            ["fr"] = "Singapour", ["es"] = "Singapur", ["de"] = "Singapur",
            ["ar"] = "سنغافورة", ["zh"] = "新加坡", ["ja"] = "シンガポール",
            ["pt"] = "Singapura", ["ru"] = "Сингапур"
        };
        d["SA"] = new Dictionary<string, string>
        {
            ["fr"] = "Arabie saoudite", ["es"] = "Arabia Saudita", ["de"] = "Saudi-Arabien",
            ["ar"] = "المملكة العربية السعودية", ["zh"] = "沙特阿拉伯", ["ja"] = "サウジアラビア",
            ["pt"] = "Arábia Saudita", ["ru"] = "Саудовская Аравия"
        };
        d["AE"] = new Dictionary<string, string>
        {
            ["fr"] = "Émirats arabes unis", ["es"] = "Emiratos Árabes Unidos", ["de"] = "Vereinigte Arabische Emirate",
            ["ar"] = "الإمارات العربية المتحدة", ["zh"] = "阿联酋", ["ja"] = "アラブ首長国連邦",
            ["pt"] = "Emirados Árabes Unidos", ["ru"] = "Объединённые Арабские Эмираты"
        };
        d["IL"] = new Dictionary<string, string>
        {
            ["fr"] = "Israël", ["es"] = "Israel", ["de"] = "Israel",
            ["ar"] = "إسرائيل", ["zh"] = "以色列", ["ja"] = "イスラエル",
            ["pt"] = "Israel", ["ru"] = "Израиль"
        };
        d["IR"] = new Dictionary<string, string>
        {
            ["fr"] = "Iran", ["es"] = "Irán", ["de"] = "Iran",
            ["ar"] = "إيران", ["zh"] = "伊朗", ["ja"] = "イラン",
            ["pt"] = "Irão", ["ru"] = "Иран"
        };
        d["IQ"] = new Dictionary<string, string>
        {
            ["fr"] = "Irak", ["es"] = "Irak", ["de"] = "Irak",
            ["ar"] = "العراق", ["zh"] = "伊拉克", ["ja"] = "イラク",
            ["pt"] = "Iraque", ["ru"] = "Ирак"
        };
        d["AF"] = new Dictionary<string, string>
        {
            ["fr"] = "Afghanistan", ["es"] = "Afganistán", ["de"] = "Afghanistan",
            ["ar"] = "أفغانستان", ["zh"] = "阿富汗", ["ja"] = "アフガニスタン",
            ["pt"] = "Afeganistão", ["ru"] = "Афганистан"
        };
        d["AM"] = new Dictionary<string, string>
        {
            ["fr"] = "Arménie", ["es"] = "Armenia", ["de"] = "Armenien",
            ["ar"] = "أرمينيا", ["zh"] = "亚美尼亚", ["ja"] = "アルメニア",
            ["pt"] = "Arménia", ["ru"] = "Армения"
        };
        d["AZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Azerbaïdjan", ["es"] = "Azerbaiyán", ["de"] = "Aserbaidschan",
            ["ar"] = "أذربيجان", ["zh"] = "阿塞拜疆", ["ja"] = "アゼルバイジャン",
            ["pt"] = "Azerbaijão", ["ru"] = "Азербайджан"
        };
        d["BH"] = new Dictionary<string, string>
        {
            ["fr"] = "Bahreïn", ["es"] = "Baréin", ["de"] = "Bahrain",
            ["ar"] = "البحرين", ["zh"] = "巴林", ["ja"] = "バーレーン",
            ["pt"] = "Barém", ["ru"] = "Бахрейн"
        };
        d["BT"] = new Dictionary<string, string>
        {
            ["fr"] = "Bhoutan", ["es"] = "Bután", ["de"] = "Bhutan",
            ["ar"] = "بوتان", ["zh"] = "不丹", ["ja"] = "ブータン",
            ["pt"] = "Butão", ["ru"] = "Бутан"
        };
        d["BN"] = new Dictionary<string, string>
        {
            ["fr"] = "Brunei", ["es"] = "Brunéi", ["de"] = "Brunei",
            ["ar"] = "بروناي", ["zh"] = "文莱", ["ja"] = "ブルネイ",
            ["pt"] = "Brunei", ["ru"] = "Бруней"
        };
        d["KH"] = new Dictionary<string, string>
        {
            ["fr"] = "Cambodge", ["es"] = "Camboya", ["de"] = "Kambodscha",
            ["ar"] = "كمبوديا", ["zh"] = "柬埔寨", ["ja"] = "カンボジア",
            ["pt"] = "Camboja", ["ru"] = "Камбоджа"
        };
        d["CY"] = new Dictionary<string, string>
        {
            ["fr"] = "Chypre", ["es"] = "Chipre", ["de"] = "Zypern",
            ["ar"] = "قبرص", ["zh"] = "塞浦路斯", ["ja"] = "キプロス",
            ["pt"] = "Chipre", ["ru"] = "Кипр"
        };
        d["GE"] = new Dictionary<string, string>
        {
            ["fr"] = "Géorgie", ["es"] = "Georgia", ["de"] = "Georgien",
            ["ar"] = "جورجيا", ["zh"] = "格鲁吉亚", ["ja"] = "ジョージア",
            ["pt"] = "Geórgia", ["ru"] = "Грузия"
        };
        d["JO"] = new Dictionary<string, string>
        {
            ["fr"] = "Jordanie", ["es"] = "Jordania", ["de"] = "Jordanien",
            ["ar"] = "الأردن", ["zh"] = "约旦", ["ja"] = "ヨルダン",
            ["pt"] = "Jordânia", ["ru"] = "Иордания"
        };
        d["KZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Kazakhstan", ["es"] = "Kazajistán", ["de"] = "Kasachstan",
            ["ar"] = "كازاخستان", ["zh"] = "哈萨克斯坦", ["ja"] = "カザフスタン",
            ["pt"] = "Cazaquistão", ["ru"] = "Казахстан"
        };
        d["KW"] = new Dictionary<string, string>
        {
            ["fr"] = "Koweït", ["es"] = "Kuwait", ["de"] = "Kuwait",
            ["ar"] = "الكويت", ["zh"] = "科威特", ["ja"] = "クウェート",
            ["pt"] = "Kuwait", ["ru"] = "Кувейт"
        };
        d["KG"] = new Dictionary<string, string>
        {
            ["fr"] = "Kirghizistan", ["es"] = "Kirguistán", ["de"] = "Kirgisistan",
            ["ar"] = "قيرغيزستان", ["zh"] = "吉尔吉斯斯坦", ["ja"] = "キルギス",
            ["pt"] = "Quirguistão", ["ru"] = "Киргизия"
        };
        d["LA"] = new Dictionary<string, string>
        {
            ["fr"] = "Laos", ["es"] = "Laos", ["de"] = "Laos",
            ["ar"] = "لاوس", ["zh"] = "老挝", ["ja"] = "ラオス",
            ["pt"] = "Laos", ["ru"] = "Лаос"
        };
        d["LB"] = new Dictionary<string, string>
        {
            ["fr"] = "Liban", ["es"] = "Líbano", ["de"] = "Libanon",
            ["ar"] = "لبنان", ["zh"] = "黎巴嫩", ["ja"] = "レバノン",
            ["pt"] = "Líbano", ["ru"] = "Ливан"
        };
        d["MV"] = new Dictionary<string, string>
        {
            ["fr"] = "Maldives", ["es"] = "Maldivas", ["de"] = "Malediven",
            ["ar"] = "المالديف", ["zh"] = "马尔代夫", ["ja"] = "モルディブ",
            ["pt"] = "Maldivas", ["ru"] = "Мальдивы"
        };
        d["MN"] = new Dictionary<string, string>
        {
            ["fr"] = "Mongolie", ["es"] = "Mongolia", ["de"] = "Mongolei",
            ["ar"] = "منغوليا", ["zh"] = "蒙古", ["ja"] = "モンゴル",
            ["pt"] = "Mongólia", ["ru"] = "Монголия"
        };
        d["MM"] = new Dictionary<string, string>
        {
            ["fr"] = "Myanmar", ["es"] = "Birmania", ["de"] = "Myanmar",
            ["ar"] = "ميانمار", ["zh"] = "缅甸", ["ja"] = "ミャンマー",
            ["pt"] = "Mianmar", ["ru"] = "Мьянма"
        };
        d["NP"] = new Dictionary<string, string>
        {
            ["fr"] = "Népal", ["es"] = "Nepal", ["de"] = "Nepal",
            ["ar"] = "نيبال", ["zh"] = "尼泊尔", ["ja"] = "ネパール",
            ["pt"] = "Nepal", ["ru"] = "Непал"
        };
        d["KP"] = new Dictionary<string, string>
        {
            ["fr"] = "Corée du Nord", ["es"] = "Corea del Norte", ["de"] = "Nordkorea",
            ["ar"] = "كوريا الشمالية", ["zh"] = "朝鲜", ["ja"] = "朝鮮民主主義人民共和国",
            ["pt"] = "Coreia do Norte", ["ru"] = "КНДР"
        };
        d["OM"] = new Dictionary<string, string>
        {
            ["fr"] = "Oman", ["es"] = "Omán", ["de"] = "Oman",
            ["ar"] = "عمان", ["zh"] = "阿曼", ["ja"] = "オマーン",
            ["pt"] = "Omã", ["ru"] = "Оман"
        };
        d["QA"] = new Dictionary<string, string>
        {
            ["fr"] = "Qatar", ["es"] = "Catar", ["de"] = "Katar",
            ["ar"] = "قطر", ["zh"] = "卡塔尔", ["ja"] = "カタール",
            ["pt"] = "Catar", ["ru"] = "Катар"
        };
        d["PS"] = new Dictionary<string, string>
        {
            ["fr"] = "Palestine", ["es"] = "Palestina", ["de"] = "Palästina",
            ["ar"] = "فلسطين", ["zh"] = "巴勒斯坦", ["ja"] = "パレスチナ",
            ["pt"] = "Palestina", ["ru"] = "Палестина"
        };
        d["LK"] = new Dictionary<string, string>
        {
            ["fr"] = "Sri Lanka", ["es"] = "Sri Lanka", ["de"] = "Sri Lanka",
            ["ar"] = "سريلانكا", ["zh"] = "斯里兰卡", ["ja"] = "スリランカ",
            ["pt"] = "Sri Lanca", ["ru"] = "Шри-Ланка"
        };
        d["SY"] = new Dictionary<string, string>
        {
            ["fr"] = "Syrie", ["es"] = "Siria", ["de"] = "Syrien",
            ["ar"] = "سوريا", ["zh"] = "叙利亚", ["ja"] = "シリア",
            ["pt"] = "Síria", ["ru"] = "Сирия"
        };
        d["TW"] = new Dictionary<string, string>
        {
            ["fr"] = "Taïwan", ["es"] = "Taiwán", ["de"] = "Taiwan",
            ["ar"] = "تايوان", ["zh"] = "台湾", ["ja"] = "台湾",
            ["pt"] = "Taiwan", ["ru"] = "Тайвань"
        };
        d["TJ"] = new Dictionary<string, string>
        {
            ["fr"] = "Tadjikistan", ["es"] = "Tayikistán", ["de"] = "Tadschikistan",
            ["ar"] = "طاجيكستان", ["zh"] = "塔吉克斯坦", ["ja"] = "タジキスタン",
            ["pt"] = "Tajiquistão", ["ru"] = "Таджикистан"
        };
        d["TL"] = new Dictionary<string, string>
        {
            ["fr"] = "Timor oriental", ["es"] = "Timor Oriental", ["de"] = "Osttimor",
            ["ar"] = "تيمور الشرقية", ["zh"] = "东帝汶", ["ja"] = "東ティモール",
            ["pt"] = "Timor-Leste", ["ru"] = "Восточный Тимор"
        };
        d["TM"] = new Dictionary<string, string>
        {
            ["fr"] = "Turkménistan", ["es"] = "Turkmenistán", ["de"] = "Turkmenistan",
            ["ar"] = "تركمانستان", ["zh"] = "土库曼斯坦", ["ja"] = "トルクメニスタン",
            ["pt"] = "Turquemenistão", ["ru"] = "Туркменистан"
        };
        d["UZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Ouzbékistan", ["es"] = "Uzbekistán", ["de"] = "Usbekistan",
            ["ar"] = "أوزبكستان", ["zh"] = "乌兹别克斯坦", ["ja"] = "ウズベキスタン",
            ["pt"] = "Uzbequistão", ["ru"] = "Узбекистан"
        };
        d["YE"] = new Dictionary<string, string>
        {
            ["fr"] = "Yémen", ["es"] = "Yemen", ["de"] = "Jemen",
            ["ar"] = "اليمن", ["zh"] = "也门", ["ja"] = "イエメン",
            ["pt"] = "Iémen", ["ru"] = "Йемен"
        };

        // ── Africa ────────────────────────────────────────────────────
        d["EG"] = new Dictionary<string, string>
        {
            ["fr"] = "Égypte", ["es"] = "Egipto", ["de"] = "Ägypten",
            ["ar"] = "مصر", ["zh"] = "埃及", ["ja"] = "エジプト",
            ["pt"] = "Egito", ["ru"] = "Египет"
        };
        d["ZA"] = new Dictionary<string, string>
        {
            ["fr"] = "Afrique du Sud", ["es"] = "Sudáfrica", ["de"] = "Südafrika",
            ["ar"] = "جنوب أفريقيا", ["zh"] = "南非", ["ja"] = "南アフリカ",
            ["pt"] = "África do Sul", ["ru"] = "Южно-Африканская Республика"
        };
        d["NG"] = new Dictionary<string, string>
        {
            ["fr"] = "Nigéria", ["es"] = "Nigeria", ["de"] = "Nigeria",
            ["ar"] = "نيجيريا", ["zh"] = "尼日利亚", ["ja"] = "ナイジェリア",
            ["pt"] = "Nigéria", ["ru"] = "Нигерия"
        };
        d["KE"] = new Dictionary<string, string>
        {
            ["fr"] = "Kenya", ["es"] = "Kenia", ["de"] = "Kenia",
            ["ar"] = "كينيا", ["zh"] = "肯尼亚", ["ja"] = "ケニア",
            ["pt"] = "Quénia", ["ru"] = "Кения"
        };
        d["MA"] = new Dictionary<string, string>
        {
            ["fr"] = "Maroc", ["es"] = "Marruecos", ["de"] = "Marokko",
            ["ar"] = "المغرب", ["zh"] = "摩洛哥", ["ja"] = "モロッコ",
            ["pt"] = "Marrocos", ["ru"] = "Марокко"
        };
        d["DZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Algérie", ["es"] = "Argelia", ["de"] = "Algerien",
            ["ar"] = "الجزائر", ["zh"] = "阿尔及利亚", ["ja"] = "アルジェリア",
            ["pt"] = "Argélia", ["ru"] = "Алжир"
        };
        d["AO"] = new Dictionary<string, string>
        {
            ["fr"] = "Angola", ["es"] = "Angola", ["de"] = "Angola",
            ["ar"] = "أنغولا", ["zh"] = "安哥拉", ["ja"] = "アンゴラ",
            ["pt"] = "Angola", ["ru"] = "Ангола"
        };
        d["BJ"] = new Dictionary<string, string>
        {
            ["fr"] = "Bénin", ["es"] = "Benín", ["de"] = "Benin",
            ["ar"] = "بنين", ["zh"] = "贝宁", ["ja"] = "ベナン",
            ["pt"] = "Benim", ["ru"] = "Бенин"
        };
        d["BW"] = new Dictionary<string, string>
        {
            ["fr"] = "Botswana", ["es"] = "Botsuana", ["de"] = "Botswana",
            ["ar"] = "بوتسوانا", ["zh"] = "博茨瓦纳", ["ja"] = "ボツワナ",
            ["pt"] = "Botsuana", ["ru"] = "Ботсвана"
        };
        d["BF"] = new Dictionary<string, string>
        {
            ["fr"] = "Burkina Faso", ["es"] = "Burkina Faso", ["de"] = "Burkina Faso",
            ["ar"] = "بوركينا فاسو", ["zh"] = "布基纳法索", ["ja"] = "ブルキナファソ",
            ["pt"] = "Burquina Fasso", ["ru"] = "Буркина-Фасо"
        };
        d["BI"] = new Dictionary<string, string>
        {
            ["fr"] = "Burundi", ["es"] = "Burundi", ["de"] = "Burundi",
            ["ar"] = "بوروندي", ["zh"] = "布隆迪", ["ja"] = "ブルンジ",
            ["pt"] = "Burúndi", ["ru"] = "Бурунди"
        };
        d["CV"] = new Dictionary<string, string>
        {
            ["fr"] = "Cap-Vert", ["es"] = "Cabo Verde", ["de"] = "Kap Verde",
            ["ar"] = "الرأس الأخضر", ["zh"] = "佛得角", ["ja"] = "カーボベルデ",
            ["pt"] = "Cabo Verde", ["ru"] = "Кабо-Верде"
        };
        d["CM"] = new Dictionary<string, string>
        {
            ["fr"] = "Cameroun", ["es"] = "Camerún", ["de"] = "Kamerun",
            ["ar"] = "الكاميرون", ["zh"] = "喀麦隆", ["ja"] = "カメルーン",
            ["pt"] = "Camarões", ["ru"] = "Камерун"
        };
        d["CF"] = new Dictionary<string, string>
        {
            ["fr"] = "République centrafricaine", ["es"] = "República Centroafricana", ["de"] = "Zentralafrikanische Republik",
            ["ar"] = "جمهورية أفريقيا الوسطى", ["zh"] = "中非共和国", ["ja"] = "中央アフリカ共和国",
            ["pt"] = "República Centro-Africana", ["ru"] = "Центральноафриканская Республика"
        };
        d["TD"] = new Dictionary<string, string>
        {
            ["fr"] = "Tchad", ["es"] = "Chad", ["de"] = "Tschad",
            ["ar"] = "تشاد", ["zh"] = "乍得", ["ja"] = "チャド",
            ["pt"] = "Chade", ["ru"] = "Чад"
        };
        d["KM"] = new Dictionary<string, string>
        {
            ["fr"] = "Comores", ["es"] = "Comoras", ["de"] = "Komoren",
            ["ar"] = "جزر القمر", ["zh"] = "科摩罗", ["ja"] = "コモロ",
            ["pt"] = "Comores", ["ru"] = "Коморы"
        };
        d["CG"] = new Dictionary<string, string>
        {
            ["fr"] = "Congo", ["es"] = "Congo", ["de"] = "Kongo",
            ["ar"] = "الكونغو", ["zh"] = "刚果共和国", ["ja"] = "コンゴ共和国",
            ["pt"] = "Congo", ["ru"] = "Конго"
        };
        d["CD"] = new Dictionary<string, string>
        {
            ["fr"] = "République démocratique du Congo", ["es"] = "República Democrática del Congo", ["de"] = "Demokratische Republik Kongo",
            ["ar"] = "جمهورية الكونغو الديمقراطية", ["zh"] = "刚果民主共和国", ["ja"] = "コンゴ民主共和国",
            ["pt"] = "República Democrática do Congo", ["ru"] = "Демократическая Республика Конго"
        };
        d["CI"] = new Dictionary<string, string>
        {
            ["fr"] = "Côte d'Ivoire", ["es"] = "Costa de Marfil", ["de"] = "Elfenbeinküste",
            ["ar"] = "ساحل العاج", ["zh"] = "科特迪瓦", ["ja"] = "コートジボワール",
            ["pt"] = "Costa do Marfim", ["ru"] = "Кот-д'Ивуар"
        };
        d["DJ"] = new Dictionary<string, string>
        {
            ["fr"] = "Djibouti", ["es"] = "Yibuti", ["de"] = "Dschibuti",
            ["ar"] = "جيبوتي", ["zh"] = "吉布提", ["ja"] = "ジブチ",
            ["pt"] = "Djibuti", ["ru"] = "Джибути"
        };
        d["GQ"] = new Dictionary<string, string>
        {
            ["fr"] = "Guinée équatoriale", ["es"] = "Guinea Ecuatorial", ["de"] = "Äquatorialguinea",
            ["ar"] = "غينيا الاستوائية", ["zh"] = "赤道几内亚", ["ja"] = "赤道ギニア",
            ["pt"] = "Guiné Equatorial", ["ru"] = "Экваториальная Гвинея"
        };
        d["ER"] = new Dictionary<string, string>
        {
            ["fr"] = "Érythrée", ["es"] = "Eritrea", ["de"] = "Eritrea",
            ["ar"] = "إريتريا", ["zh"] = "厄立特里亚", ["ja"] = "エリトリア",
            ["pt"] = "Eritreia", ["ru"] = "Эритрея"
        };
        d["ET"] = new Dictionary<string, string>
        {
            ["fr"] = "Éthiopie", ["es"] = "Etiopía", ["de"] = "Äthiopien",
            ["ar"] = "إثيوبيا", ["zh"] = "埃塞俄比亚", ["ja"] = "エチオピア",
            ["pt"] = "Etiópia", ["ru"] = "Эфиопия"
        };
        d["SZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Eswatini", ["es"] = "Esuatini", ["de"] = "Eswatini",
            ["ar"] = "إسواتيني", ["zh"] = "斯威士兰", ["ja"] = "エスワティニ",
            ["pt"] = "Essuatíni", ["ru"] = "Эсватини"
        };
        d["GA"] = new Dictionary<string, string>
        {
            ["fr"] = "Gabon", ["es"] = "Gabón", ["de"] = "Gabun",
            ["ar"] = "الغابون", ["zh"] = "加蓬", ["ja"] = "ガボン",
            ["pt"] = "Gabão", ["ru"] = "Габон"
        };
        d["GM"] = new Dictionary<string, string>
        {
            ["fr"] = "Gambie", ["es"] = "Gambia", ["de"] = "Gambia",
            ["ar"] = "غامبيا", ["zh"] = "冈比亚", ["ja"] = "ガンビア",
            ["pt"] = "Gâmbia", ["ru"] = "Гамбия"
        };
        d["GH"] = new Dictionary<string, string>
        {
            ["fr"] = "Ghana", ["es"] = "Ghana", ["de"] = "Ghana",
            ["ar"] = "غانا", ["zh"] = "加纳", ["ja"] = "ガーナ",
            ["pt"] = "Gana", ["ru"] = "Гана"
        };
        d["GN"] = new Dictionary<string, string>
        {
            ["fr"] = "Guinée", ["es"] = "Guinea", ["de"] = "Guinea",
            ["ar"] = "غينيا", ["zh"] = "几内亚", ["ja"] = "ギニア",
            ["pt"] = "Guiné", ["ru"] = "Гвинея"
        };
        d["GW"] = new Dictionary<string, string>
        {
            ["fr"] = "Guinée-Bissau", ["es"] = "Guinea-Bisáu", ["de"] = "Guinea-Bissau",
            ["ar"] = "غينيا بيساو", ["zh"] = "几内亚比绍", ["ja"] = "ギニアビサウ",
            ["pt"] = "Guiné-Bissau", ["ru"] = "Гвинея-Бисау"
        };
        d["LS"] = new Dictionary<string, string>
        {
            ["fr"] = "Lesotho", ["es"] = "Lesoto", ["de"] = "Lesotho",
            ["ar"] = "ليسوتو", ["zh"] = "莱索托", ["ja"] = "レソト",
            ["pt"] = "Lesoto", ["ru"] = "Лесото"
        };
        d["LR"] = new Dictionary<string, string>
        {
            ["fr"] = "Libéria", ["es"] = "Liberia", ["de"] = "Liberia",
            ["ar"] = "ليبيريا", ["zh"] = "利比里亚", ["ja"] = "リベリア",
            ["pt"] = "Libéria", ["ru"] = "Либерия"
        };
        d["LY"] = new Dictionary<string, string>
        {
            ["fr"] = "Libye", ["es"] = "Libia", ["de"] = "Libyen",
            ["ar"] = "ليبيا", ["zh"] = "利比亚", ["ja"] = "リビア",
            ["pt"] = "Líbia", ["ru"] = "Ливия"
        };
        d["MG"] = new Dictionary<string, string>
        {
            ["fr"] = "Madagascar", ["es"] = "Madagascar", ["de"] = "Madagaskar",
            ["ar"] = "مدغشقر", ["zh"] = "马达加斯加", ["ja"] = "マダガスカル",
            ["pt"] = "Madagáscar", ["ru"] = "Мадагаскар"
        };
        d["MW"] = new Dictionary<string, string>
        {
            ["fr"] = "Malawi", ["es"] = "Malaui", ["de"] = "Malawi",
            ["ar"] = "ملاوي", ["zh"] = "马拉维", ["ja"] = "マラウイ",
            ["pt"] = "Maláui", ["ru"] = "Малави"
        };
        d["ML"] = new Dictionary<string, string>
        {
            ["fr"] = "Mali", ["es"] = "Malí", ["de"] = "Mali",
            ["ar"] = "مالي", ["zh"] = "马里", ["ja"] = "マリ",
            ["pt"] = "Mali", ["ru"] = "Мали"
        };
        d["MR"] = new Dictionary<string, string>
        {
            ["fr"] = "Mauritanie", ["es"] = "Mauritania", ["de"] = "Mauretanien",
            ["ar"] = "موريتانيا", ["zh"] = "毛里塔尼亚", ["ja"] = "モーリタニア",
            ["pt"] = "Mauritânia", ["ru"] = "Мавритания"
        };
        d["MU"] = new Dictionary<string, string>
        {
            ["fr"] = "Maurice", ["es"] = "Mauricio", ["de"] = "Mauritius",
            ["ar"] = "موريشيوس", ["zh"] = "毛里求斯", ["ja"] = "モーリシャス",
            ["pt"] = "Maurícia", ["ru"] = "Маврикий"
        };
        d["MZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Mozambique", ["es"] = "Mozambique", ["de"] = "Mosambik",
            ["ar"] = "موزمبيق", ["zh"] = "莫桑比克", ["ja"] = "モザンビーク",
            ["pt"] = "Moçambique", ["ru"] = "Мозамбик"
        };
        d["NA"] = new Dictionary<string, string>
        {
            ["fr"] = "Namibie", ["es"] = "Namibia", ["de"] = "Namibia",
            ["ar"] = "ناميبيا", ["zh"] = "纳米比亚", ["ja"] = "ナミビア",
            ["pt"] = "Namíbia", ["ru"] = "Намибия"
        };
        d["NE"] = new Dictionary<string, string>
        {
            ["fr"] = "Niger", ["es"] = "Níger", ["de"] = "Niger",
            ["ar"] = "النيجر", ["zh"] = "尼日尔", ["ja"] = "ニジェール",
            ["pt"] = "Níger", ["ru"] = "Нигер"
        };
        d["RW"] = new Dictionary<string, string>
        {
            ["fr"] = "Rwanda", ["es"] = "Ruanda", ["de"] = "Ruanda",
            ["ar"] = "رواندا", ["zh"] = "卢旺达", ["ja"] = "ルワンダ",
            ["pt"] = "Ruanda", ["ru"] = "Руанда"
        };
        d["ST"] = new Dictionary<string, string>
        {
            ["fr"] = "Sao Tomé-et-Príncipe", ["es"] = "Santo Tomé y Príncipe", ["de"] = "São Tomé und Príncipe",
            ["ar"] = "ساو تومي وبرينسيبي", ["zh"] = "圣多美和普林西比", ["ja"] = "サントメ・プリンシペ",
            ["pt"] = "São Tomé e Príncipe", ["ru"] = "Сан-Томе и Принсипи"
        };
        d["SN"] = new Dictionary<string, string>
        {
            ["fr"] = "Sénégal", ["es"] = "Senegal", ["de"] = "Senegal",
            ["ar"] = "السنغال", ["zh"] = "塞内加尔", ["ja"] = "セネガル",
            ["pt"] = "Senegal", ["ru"] = "Сенегал"
        };
        d["SC"] = new Dictionary<string, string>
        {
            ["fr"] = "Seychelles", ["es"] = "Seychelles", ["de"] = "Seychellen",
            ["ar"] = "سيشل", ["zh"] = "塞舌尔", ["ja"] = "セーシェル",
            ["pt"] = "Seicheles", ["ru"] = "Сейшельские Острова"
        };
        d["SL"] = new Dictionary<string, string>
        {
            ["fr"] = "Sierra Leone", ["es"] = "Sierra Leona", ["de"] = "Sierra Leone",
            ["ar"] = "سيراليون", ["zh"] = "塞拉利昂", ["ja"] = "シエラレオネ",
            ["pt"] = "Serra Leoa", ["ru"] = "Сьерра-Леоне"
        };
        d["SO"] = new Dictionary<string, string>
        {
            ["fr"] = "Somalie", ["es"] = "Somalia", ["de"] = "Somalia",
            ["ar"] = "الصومال", ["zh"] = "索马里", ["ja"] = "ソマリア",
            ["pt"] = "Somália", ["ru"] = "Сомали"
        };
        d["SS"] = new Dictionary<string, string>
        {
            ["fr"] = "Soudan du Sud", ["es"] = "Sudán del Sur", ["de"] = "Südsudan",
            ["ar"] = "جنوب السودان", ["zh"] = "南苏丹", ["ja"] = "南スーダン",
            ["pt"] = "Sudão do Sul", ["ru"] = "Южный Судан"
        };
        d["SD"] = new Dictionary<string, string>
        {
            ["fr"] = "Soudan", ["es"] = "Sudán", ["de"] = "Sudan",
            ["ar"] = "السودان", ["zh"] = "苏丹", ["ja"] = "スーダン",
            ["pt"] = "Sudão", ["ru"] = "Судан"
        };
        d["TZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Tanzanie", ["es"] = "Tanzania", ["de"] = "Tansania",
            ["ar"] = "تنزانيا", ["zh"] = "坦桑尼亚", ["ja"] = "タンザニア",
            ["pt"] = "Tanzânia", ["ru"] = "Танзания"
        };
        d["TG"] = new Dictionary<string, string>
        {
            ["fr"] = "Togo", ["es"] = "Togo", ["de"] = "Togo",
            ["ar"] = "توغو", ["zh"] = "多哥", ["ja"] = "トーゴ",
            ["pt"] = "Togo", ["ru"] = "Того"
        };
        d["TN"] = new Dictionary<string, string>
        {
            ["fr"] = "Tunisie", ["es"] = "Túnez", ["de"] = "Tunesien",
            ["ar"] = "تونس", ["zh"] = "突尼斯", ["ja"] = "チュニジア",
            ["pt"] = "Tunísia", ["ru"] = "Тунис"
        };
        d["UG"] = new Dictionary<string, string>
        {
            ["fr"] = "Ouganda", ["es"] = "Uganda", ["de"] = "Uganda",
            ["ar"] = "أوغندا", ["zh"] = "乌干达", ["ja"] = "ウガンダ",
            ["pt"] = "Uganda", ["ru"] = "Уганда"
        };
        d["ZM"] = new Dictionary<string, string>
        {
            ["fr"] = "Zambie", ["es"] = "Zambia", ["de"] = "Sambia",
            ["ar"] = "زامبيا", ["zh"] = "赞比亚", ["ja"] = "ザンビア",
            ["pt"] = "Zâmbia", ["ru"] = "Замбия"
        };
        d["ZW"] = new Dictionary<string, string>
        {
            ["fr"] = "Zimbabwe", ["es"] = "Zimbabue", ["de"] = "Simbabwe",
            ["ar"] = "زيمبابوي", ["zh"] = "津巴布韦", ["ja"] = "ジンバブエ",
            ["pt"] = "Zimbábue", ["ru"] = "Зимбабве"
        };

        // ── Oceania ───────────────────────────────────────────────────
        d["AU"] = new Dictionary<string, string>
        {
            ["fr"] = "Australie", ["es"] = "Australia", ["de"] = "Australien",
            ["ar"] = "أستراليا", ["zh"] = "澳大利亚", ["ja"] = "オーストラリア",
            ["pt"] = "Austrália", ["ru"] = "Австралия"
        };
        d["NZ"] = new Dictionary<string, string>
        {
            ["fr"] = "Nouvelle-Zélande", ["es"] = "Nueva Zelanda", ["de"] = "Neuseeland",
            ["ar"] = "نيوزيلندا", ["zh"] = "新西兰", ["ja"] = "ニュージーランド",
            ["pt"] = "Nova Zelândia", ["ru"] = "Новая Зеландия"
        };
        d["FJ"] = new Dictionary<string, string>
        {
            ["fr"] = "Fidji", ["es"] = "Fiyi", ["de"] = "Fidschi",
            ["ar"] = "فيجي", ["zh"] = "斐济", ["ja"] = "フィジー",
            ["pt"] = "Fiji", ["ru"] = "Фиджи"
        };
        d["PG"] = new Dictionary<string, string>
        {
            ["fr"] = "Papouasie-Nouvelle-Guinée", ["es"] = "Papúa Nueva Guinea", ["de"] = "Papua-Neuguinea",
            ["ar"] = "بابوا غينيا الجديدة", ["zh"] = "巴布亚新几内亚", ["ja"] = "パプアニューギニア",
            ["pt"] = "Papua-Nova Guiné", ["ru"] = "Папуа — Новая Гвинея"
        };
        d["WS"] = new Dictionary<string, string>
        {
            ["fr"] = "Samoa", ["es"] = "Samoa", ["de"] = "Samoa",
            ["ar"] = "ساموا", ["zh"] = "萨摩亚", ["ja"] = "サモア",
            ["pt"] = "Samoa", ["ru"] = "Самоа"
        };
        d["SB"] = new Dictionary<string, string>
        {
            ["fr"] = "Salomon", ["es"] = "Islas Salomón", ["de"] = "Salomonen",
            ["ar"] = "جزر سليمان", ["zh"] = "所罗门群岛", ["ja"] = "ソロモン諸島",
            ["pt"] = "Ilhas Salomão", ["ru"] = "Соломоновы Острова"
        };
        d["TO"] = new Dictionary<string, string>
        {
            ["fr"] = "Tonga", ["es"] = "Tonga", ["de"] = "Tonga",
            ["ar"] = "تونغا", ["zh"] = "汤加", ["ja"] = "トンガ",
            ["pt"] = "Tonga", ["ru"] = "Тонга"
        };
        d["VU"] = new Dictionary<string, string>
        {
            ["fr"] = "Vanuatu", ["es"] = "Vanuatu", ["de"] = "Vanuatu",
            ["ar"] = "فانواتو", ["zh"] = "瓦努阿图", ["ja"] = "バヌアツ",
            ["pt"] = "Vanuatu", ["ru"] = "Вануату"
        };
        d["FM"] = new Dictionary<string, string>
        {
            ["fr"] = "Micronésie", ["es"] = "Micronesia", ["de"] = "Mikronesien",
            ["ar"] = "ميكرونيسيا", ["zh"] = "密克罗尼西亚", ["ja"] = "ミクロネシア連邦",
            ["pt"] = "Micronésia", ["ru"] = "Микронезия"
        };
        d["KI"] = new Dictionary<string, string>
        {
            ["fr"] = "Kiribati", ["es"] = "Kiribati", ["de"] = "Kiribati",
            ["ar"] = "كيريباتي", ["zh"] = "基里巴斯", ["ja"] = "キリバス",
            ["pt"] = "Quiribáti", ["ru"] = "Кирибати"
        };
        d["MH"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Marshall", ["es"] = "Islas Marshall", ["de"] = "Marshallinseln",
            ["ar"] = "جزر مارشال", ["zh"] = "马绍尔群岛", ["ja"] = "マーシャル諸島",
            ["pt"] = "Ilhas Marshall", ["ru"] = "Маршалловы Острова"
        };
        d["NR"] = new Dictionary<string, string>
        {
            ["fr"] = "Nauru", ["es"] = "Nauru", ["de"] = "Nauru",
            ["ar"] = "ناورو", ["zh"] = "瑙鲁", ["ja"] = "ナウル",
            ["pt"] = "Nauru", ["ru"] = "Науру"
        };
        d["PW"] = new Dictionary<string, string>
        {
            ["fr"] = "Palaos", ["es"] = "Palaos", ["de"] = "Palau",
            ["ar"] = "بالاو", ["zh"] = "帕劳", ["ja"] = "パラオ",
            ["pt"] = "Palau", ["ru"] = "Палау"
        };
        d["TV"] = new Dictionary<string, string>
        {
            ["fr"] = "Tuvalu", ["es"] = "Tuvalu", ["de"] = "Tuvalu",
            ["ar"] = "توفالو", ["zh"] = "图瓦卢", ["ja"] = "ツバル",
            ["pt"] = "Tuvalu", ["ru"] = "Тувалу"
        };

        // ── Territories & Dependencies ────────────────────────────────
        d["HK"] = new Dictionary<string, string>
        {
            ["fr"] = "Hong Kong", ["es"] = "Hong Kong", ["de"] = "Hongkong",
            ["ar"] = "هونغ كونغ", ["zh"] = "香港", ["ja"] = "香港",
            ["pt"] = "Hong Kong", ["ru"] = "Гонконг"
        };
        d["MO"] = new Dictionary<string, string>
        {
            ["fr"] = "Macao", ["es"] = "Macao", ["de"] = "Macau",
            ["ar"] = "ماكاو", ["zh"] = "澳门", ["ja"] = "マカオ",
            ["pt"] = "Macau", ["ru"] = "Макао"
        };
        d["PR"] = new Dictionary<string, string>
        {
            ["fr"] = "Porto Rico", ["es"] = "Puerto Rico", ["de"] = "Puerto Rico",
            ["ar"] = "بورتوريكو", ["zh"] = "波多黎各", ["ja"] = "プエルトリコ",
            ["pt"] = "Porto Rico", ["ru"] = "Пуэрто-Рико"
        };
        d["GU"] = new Dictionary<string, string>
        {
            ["fr"] = "Guam", ["es"] = "Guam", ["de"] = "Guam",
            ["ar"] = "غوام", ["zh"] = "关岛", ["ja"] = "グアム",
            ["pt"] = "Guam", ["ru"] = "Гуам"
        };
        d["VI"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Vierges américaines", ["es"] = "Islas Vírgenes de EE. UU.", ["de"] = "Amerikanische Jungferninseln",
            ["ar"] = "جزر العذراء الأمريكية", ["zh"] = "美属维尔京群岛", ["ja"] = "アメリカ領ヴァージン諸島",
            ["pt"] = "Ilhas Virgens Americanas", ["ru"] = "Виргинские Острова (США)"
        };
        d["AS"] = new Dictionary<string, string>
        {
            ["fr"] = "Samoa américaines", ["es"] = "Samoa Americana", ["de"] = "Amerikanisch-Samoa",
            ["ar"] = "ساموا الأمريكية", ["zh"] = "美属萨摩亚", ["ja"] = "アメリカ領サモア",
            ["pt"] = "Samoa Americana", ["ru"] = "Американское Самоа"
        };
        d["MP"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Mariannes du Nord", ["es"] = "Islas Marianas del Norte", ["de"] = "Nördliche Marianen",
            ["ar"] = "جزر ماريانا الشمالية", ["zh"] = "北马里亚纳群岛", ["ja"] = "北マリアナ諸島",
            ["pt"] = "Ilhas Marianas do Norte", ["ru"] = "Северные Марианские острова"
        };
        d["UM"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles mineures éloignées des États-Unis", ["es"] = "Islas Ultramarinas Menores de EE. UU.", ["de"] = "Amerikanische Überseeinseln",
            ["ar"] = "جزر الولايات المتحدة الصغيرة النائية", ["zh"] = "美国本土外小岛屿", ["ja"] = "合衆国領有小離島",
            ["pt"] = "Ilhas Menores Distantes dos EUA", ["ru"] = "Внешние малые острова (США)"
        };
        d["AI"] = new Dictionary<string, string>
        {
            ["fr"] = "Anguilla", ["es"] = "Anguila", ["de"] = "Anguilla",
            ["ar"] = "أنغويلا", ["zh"] = "安圭拉", ["ja"] = "アンギラ",
            ["pt"] = "Anguila", ["ru"] = "Ангилья"
        };
        d["AW"] = new Dictionary<string, string>
        {
            ["fr"] = "Aruba", ["es"] = "Aruba", ["de"] = "Aruba",
            ["ar"] = "أروبا", ["zh"] = "阿鲁巴", ["ja"] = "アルバ",
            ["pt"] = "Aruba", ["ru"] = "Аруба"
        };
        d["BM"] = new Dictionary<string, string>
        {
            ["fr"] = "Bermudes", ["es"] = "Bermudas", ["de"] = "Bermuda",
            ["ar"] = "برمودا", ["zh"] = "百慕大", ["ja"] = "バミューダ",
            ["pt"] = "Bermudas", ["ru"] = "Бермуды"
        };
        d["BQ"] = new Dictionary<string, string>
        {
            ["fr"] = "Pays-Bas caribéens", ["es"] = "Bonaire, San Eustaquio y Saba", ["de"] = "Bonaire, Sint Eustatius und Saba",
            ["ar"] = "هولندا الكاريبية", ["zh"] = "荷兰加勒比区", ["ja"] = "ボネール、シント・ユースタティウスおよびサバ",
            ["pt"] = "Países Baixos Caribenhos", ["ru"] = "Бонэйр, Синт-Эстатиус и Саба"
        };
        d["VG"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Vierges britanniques", ["es"] = "Islas Vírgenes Británicas", ["de"] = "Britische Jungferninseln",
            ["ar"] = "جزر العذراء البريطانية", ["zh"] = "英属维尔京群岛", ["ja"] = "イギリス領ヴァージン諸島",
            ["pt"] = "Ilhas Virgens Britânicas", ["ru"] = "Виргинские Острова (Великобритания)"
        };
        d["KY"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Caïmans", ["es"] = "Islas Caimán", ["de"] = "Kaimaninseln",
            ["ar"] = "جزر كايمان", ["zh"] = "开曼群岛", ["ja"] = "ケイマン諸島",
            ["pt"] = "Ilhas Caimão", ["ru"] = "Каймановы острова"
        };
        d["CW"] = new Dictionary<string, string>
        {
            ["fr"] = "Curaçao", ["es"] = "Curazao", ["de"] = "Curaçao",
            ["ar"] = "كوراساو", ["zh"] = "库拉索", ["ja"] = "キュラソー",
            ["pt"] = "Curaçau", ["ru"] = "Кюрасао"
        };
        d["FK"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Malouines", ["es"] = "Islas Malvinas", ["de"] = "Falklandinseln",
            ["ar"] = "جزر فوكلاند", ["zh"] = "福克兰群岛", ["ja"] = "フォークランド諸島",
            ["pt"] = "Ilhas Malvinas", ["ru"] = "Фолклендские острова"
        };
        d["GF"] = new Dictionary<string, string>
        {
            ["fr"] = "Guyane française", ["es"] = "Guayana Francesa", ["de"] = "Französisch-Guayana",
            ["ar"] = "غويانا الفرنسية", ["zh"] = "法属圭亚那", ["ja"] = "フランス領ギアナ",
            ["pt"] = "Guiana Francesa", ["ru"] = "Французская Гвиана"
        };
        d["GP"] = new Dictionary<string, string>
        {
            ["fr"] = "Guadeloupe", ["es"] = "Guadalupe", ["de"] = "Guadeloupe",
            ["ar"] = "غوادلوب", ["zh"] = "瓜德罗普", ["ja"] = "グアドループ",
            ["pt"] = "Guadalupe", ["ru"] = "Гваделупа"
        };
        d["MQ"] = new Dictionary<string, string>
        {
            ["fr"] = "Martinique", ["es"] = "Martinica", ["de"] = "Martinique",
            ["ar"] = "مارتينيك", ["zh"] = "马提尼克", ["ja"] = "マルティニーク",
            ["pt"] = "Martinica", ["ru"] = "Мартиника"
        };
        d["MS"] = new Dictionary<string, string>
        {
            ["fr"] = "Montserrat", ["es"] = "Montserrat", ["de"] = "Montserrat",
            ["ar"] = "مونتسرات", ["zh"] = "蒙特塞拉特", ["ja"] = "モントセラト",
            ["pt"] = "Monserrate", ["ru"] = "Монтсеррат"
        };
        d["SX"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Martin (partie néerlandaise)", ["es"] = "San Martín (parte neerlandesa)", ["de"] = "Sint Maarten",
            ["ar"] = "سانت مارتن (الجزء الهولندي)", ["zh"] = "荷属圣马丁", ["ja"] = "シント・マールテン",
            ["pt"] = "São Martinho (Países Baixos)", ["ru"] = "Синт-Мартен"
        };
        d["TC"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Turques-et-Caïques", ["es"] = "Islas Turcas y Caicos", ["de"] = "Turks- und Caicosinseln",
            ["ar"] = "جزر تركس وكايكوس", ["zh"] = "特克斯和凯科斯群岛", ["ja"] = "タークス・カイコス諸島",
            ["pt"] = "Ilhas Turcas e Caicos", ["ru"] = "Тёркс и Кайкос"
        };
        d["RE"] = new Dictionary<string, string>
        {
            ["fr"] = "La Réunion", ["es"] = "Reunión", ["de"] = "Réunion",
            ["ar"] = "ريونيون", ["zh"] = "留尼汪", ["ja"] = "レユニオン",
            ["pt"] = "Reunião", ["ru"] = "Реюньон"
        };
        d["YT"] = new Dictionary<string, string>
        {
            ["fr"] = "Mayotte", ["es"] = "Mayotte", ["de"] = "Mayotte",
            ["ar"] = "مايوت", ["zh"] = "马约特", ["ja"] = "マヨット",
            ["pt"] = "Maiote", ["ru"] = "Майотта"
        };
        d["BL"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Barthélemy", ["es"] = "San Bartolomé", ["de"] = "Saint-Barthélemy",
            ["ar"] = "سان بارتليمي", ["zh"] = "圣巴泰勒米", ["ja"] = "サン・バルテルミー",
            ["pt"] = "São Bartolomeu", ["ru"] = "Сен-Бартелеми"
        };
        d["MF"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Martin (partie française)", ["es"] = "San Martín (parte francesa)", ["de"] = "Saint-Martin",
            ["ar"] = "سان مارتن (الجزء الفرنسي)", ["zh"] = "法属圣马丁", ["ja"] = "サン・マルタン",
            ["pt"] = "São Martinho (França)", ["ru"] = "Сен-Мартен"
        };
        d["PM"] = new Dictionary<string, string>
        {
            ["fr"] = "Saint-Pierre-et-Miquelon", ["es"] = "San Pedro y Miquelón", ["de"] = "Saint-Pierre und Miquelon",
            ["ar"] = "سان بيير وميكلون", ["zh"] = "圣皮埃尔和密克隆", ["ja"] = "サンピエール島・ミクロン島",
            ["pt"] = "São Pedro e Miquelon", ["ru"] = "Сен-Пьер и Микелон"
        };
        d["WF"] = new Dictionary<string, string>
        {
            ["fr"] = "Wallis-et-Futuna", ["es"] = "Wallis y Futuna", ["de"] = "Wallis und Futuna",
            ["ar"] = "واليس وفوتونا", ["zh"] = "瓦利斯和富图纳", ["ja"] = "ウォリス・フツナ",
            ["pt"] = "Wallis e Futuna", ["ru"] = "Уоллис и Футуна"
        };
        d["NC"] = new Dictionary<string, string>
        {
            ["fr"] = "Nouvelle-Calédonie", ["es"] = "Nueva Caledonia", ["de"] = "Neukaledonien",
            ["ar"] = "كاليدونيا الجديدة", ["zh"] = "新喀里多尼亚", ["ja"] = "ニューカレドニア",
            ["pt"] = "Nova Caledónia", ["ru"] = "Новая Каледония"
        };
        d["PF"] = new Dictionary<string, string>
        {
            ["fr"] = "Polynésie française", ["es"] = "Polinesia Francesa", ["de"] = "Französisch-Polynesien",
            ["ar"] = "بولينيزيا الفرنسية", ["zh"] = "法属波利尼西亚", ["ja"] = "フランス領ポリネシア",
            ["pt"] = "Polinésia Francesa", ["ru"] = "Французская Полинезия"
        };
        d["TF"] = new Dictionary<string, string>
        {
            ["fr"] = "Terres australes françaises", ["es"] = "Tierras Australes Francesas", ["de"] = "Französische Süd- und Antarktisgebiete",
            ["ar"] = "أراضي فرنسا الجنوبية والأنتاركتيكية", ["zh"] = "法属南部领地", ["ja"] = "フランス領南方・南極地域",
            ["pt"] = "Terras Austrais e Antárticas Francesas", ["ru"] = "Французские Южные территории"
        };
        d["GI"] = new Dictionary<string, string>
        {
            ["fr"] = "Gibraltar", ["es"] = "Gibraltar", ["de"] = "Gibraltar",
            ["ar"] = "جبل طارق", ["zh"] = "直布罗陀", ["ja"] = "ジブラルタル",
            ["pt"] = "Gibraltar", ["ru"] = "Гибралтар"
        };
        d["GL"] = new Dictionary<string, string>
        {
            ["fr"] = "Groenland", ["es"] = "Groenlandia", ["de"] = "Grönland",
            ["ar"] = "غرينلاند", ["zh"] = "格陵兰", ["ja"] = "グリーンランド",
            ["pt"] = "Gronelândia", ["ru"] = "Гренландия"
        };
        d["FO"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Féroé", ["es"] = "Islas Feroe", ["de"] = "Färöer",
            ["ar"] = "جزر فارو", ["zh"] = "法罗群岛", ["ja"] = "フェロー諸島",
            ["pt"] = "Ilhas Faroé", ["ru"] = "Фарерские острова"
        };
        d["AX"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Åland", ["es"] = "Islas Åland", ["de"] = "Ålandinseln",
            ["ar"] = "جزر أولاند", ["zh"] = "奥兰群岛", ["ja"] = "オーランド諸島",
            ["pt"] = "Ilhas Åland", ["ru"] = "Аландские острова"
        };
        d["SJ"] = new Dictionary<string, string>
        {
            ["fr"] = "Svalbard et Jan Mayen", ["es"] = "Svalbard y Jan Mayen", ["de"] = "Spitzbergen und Jan Mayen",
            ["ar"] = "سفالبارد ويان ماين", ["zh"] = "斯瓦尔巴和扬马延", ["ja"] = "スヴァールバル諸島およびヤンマイエン島",
            ["pt"] = "Svalbard e Jan Mayen", ["ru"] = "Шпицберген и Ян-Майен"
        };
        d["GG"] = new Dictionary<string, string>
        {
            ["fr"] = "Guernesey", ["es"] = "Guernsey", ["de"] = "Guernsey",
            ["ar"] = "غيرنزي", ["zh"] = "根西岛", ["ja"] = "ガーンジー",
            ["pt"] = "Guernsey", ["ru"] = "Гернси"
        };
        d["JE"] = new Dictionary<string, string>
        {
            ["fr"] = "Jersey", ["es"] = "Jersey", ["de"] = "Jersey",
            ["ar"] = "جيرزي", ["zh"] = "泽西岛", ["ja"] = "ジャージー",
            ["pt"] = "Jersey", ["ru"] = "Джерси"
        };
        d["IM"] = new Dictionary<string, string>
        {
            ["fr"] = "Île de Man", ["es"] = "Isla de Man", ["de"] = "Isle of Man",
            ["ar"] = "جزيرة مان", ["zh"] = "马恩岛", ["ja"] = "マン島",
            ["pt"] = "Ilha de Man", ["ru"] = "Остров Мэн"
        };
        d["CX"] = new Dictionary<string, string>
        {
            ["fr"] = "Île Christmas", ["es"] = "Isla de Navidad", ["de"] = "Weihnachtsinsel",
            ["ar"] = "جزيرة كريسماس", ["zh"] = "圣诞岛", ["ja"] = "クリスマス島",
            ["pt"] = "Ilha do Natal", ["ru"] = "Остров Рождества"
        };
        d["CC"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Cocos", ["es"] = "Islas Cocos", ["de"] = "Kokosinseln",
            ["ar"] = "جزر كوكوس", ["zh"] = "科科斯群岛", ["ja"] = "ココス諸島",
            ["pt"] = "Ilhas Cocos", ["ru"] = "Кокосовые острова"
        };
        d["NF"] = new Dictionary<string, string>
        {
            ["fr"] = "Île Norfolk", ["es"] = "Isla Norfolk", ["de"] = "Norfolkinsel",
            ["ar"] = "جزيرة نورفولك", ["zh"] = "诺福克岛", ["ja"] = "ノーフォーク島",
            ["pt"] = "Ilha Norfolk", ["ru"] = "Остров Норфолк"
        };
        d["CK"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Cook", ["es"] = "Islas Cook", ["de"] = "Cookinseln",
            ["ar"] = "جزر كوك", ["zh"] = "库克群岛", ["ja"] = "クック諸島",
            ["pt"] = "Ilhas Cook", ["ru"] = "Острова Кука"
        };
        d["NU"] = new Dictionary<string, string>
        {
            ["fr"] = "Niue", ["es"] = "Niue", ["de"] = "Niue",
            ["ar"] = "نييوي", ["zh"] = "纽埃", ["ja"] = "ニウエ",
            ["pt"] = "Niue", ["ru"] = "Ниуэ"
        };
        d["TK"] = new Dictionary<string, string>
        {
            ["fr"] = "Tokelau", ["es"] = "Tokelau", ["de"] = "Tokelau",
            ["ar"] = "توكيلاو", ["zh"] = "托克劳", ["ja"] = "トケラウ",
            ["pt"] = "Tokelau", ["ru"] = "Токелау"
        };
        d["PN"] = new Dictionary<string, string>
        {
            ["fr"] = "Pitcairn", ["es"] = "Islas Pitcairn", ["de"] = "Pitcairninseln",
            ["ar"] = "جزر بيتكيرن", ["zh"] = "皮特凯恩群岛", ["ja"] = "ピトケアン諸島",
            ["pt"] = "Ilhas Pitcairn", ["ru"] = "Острова Питкэрн"
        };
        d["SH"] = new Dictionary<string, string>
        {
            ["fr"] = "Sainte-Hélène", ["es"] = "Santa Elena", ["de"] = "St. Helena",
            ["ar"] = "سانت هيلينا", ["zh"] = "圣赫勒拿", ["ja"] = "セントヘレナ",
            ["pt"] = "Santa Helena", ["ru"] = "Остров Святой Елены"
        };
        d["IO"] = new Dictionary<string, string>
        {
            ["fr"] = "Territoire britannique de l'océan Indien", ["es"] = "Territorio Británico del Océano Índico", ["de"] = "Britisches Territorium im Indischen Ozean",
            ["ar"] = "إقليم المحيط الهندي البريطاني", ["zh"] = "英属印度洋领地", ["ja"] = "イギリス領インド洋地域",
            ["pt"] = "Território Britânico do Oceano Índico", ["ru"] = "Британская территория в Индийском океане"
        };
        d["GS"] = new Dictionary<string, string>
        {
            ["fr"] = "Géorgie du Sud-et-les îles Sandwich du Sud", ["es"] = "Georgia del Sur y las Islas Sandwich del Sur", ["de"] = "Südgeorgien und die Südlichen Sandwichinseln",
            ["ar"] = "جورجيا الجنوبية وجزر ساندويتش الجنوبية", ["zh"] = "南乔治亚和南桑威奇群岛", ["ja"] = "サウスジョージア・サウスサンドウィッチ諸島",
            ["pt"] = "Ilhas Geórgia do Sul e Sandwich do Sul", ["ru"] = "Южная Георгия и Южные Сандвичевы Острова"
        };
        d["BV"] = new Dictionary<string, string>
        {
            ["fr"] = "Île Bouvet", ["es"] = "Isla Bouvet", ["de"] = "Bouvetinsel",
            ["ar"] = "جزيرة بوفيه", ["zh"] = "布韦岛", ["ja"] = "ブーベ島",
            ["pt"] = "Ilha Bouvet", ["ru"] = "Остров Буве"
        };
        d["HM"] = new Dictionary<string, string>
        {
            ["fr"] = "Îles Heard-et-MacDonald", ["es"] = "Islas Heard y McDonald", ["de"] = "Heard und McDonaldinseln",
            ["ar"] = "جزيرة هيرد وجزر ماكدونالد", ["zh"] = "赫德岛和麦克唐纳群岛", ["ja"] = "ハード島とマクドナルド諸島",
            ["pt"] = "Ilhas Heard e McDonald", ["ru"] = "Остров Херд и острова Макдональд"
        };
        d["AQ"] = new Dictionary<string, string>
        {
            ["fr"] = "Antarctique", ["es"] = "Antártida", ["de"] = "Antarktis",
            ["ar"] = "أنتاركتيكا", ["zh"] = "南极洲", ["ja"] = "南極",
            ["pt"] = "Antártida", ["ru"] = "Антарктида"
        };
        d["EH"] = new Dictionary<string, string>
        {
            ["fr"] = "Sahara occidental", ["es"] = "Sahara Occidental", ["de"] = "Westsahara",
            ["ar"] = "الصحراء الغربية", ["zh"] = "西撒哈拉", ["ja"] = "西サハラ",
            ["pt"] = "Saara Ocidental", ["ru"] = "Западная Сахара"
        };
        d["AN"] = new Dictionary<string, string>
        {
            ["fr"] = "Antilles néerlandaises", ["es"] = "Antillas Neerlandesas", ["de"] = "Niederländische Antillen",
            ["ar"] = "جزر الأنتيل الهولندية", ["zh"] = "荷属安的列斯", ["ja"] = "オランダ領アンティル",
            ["pt"] = "Antilhas Neerlandesas", ["ru"] = "Нидерландские Антильские острова"
        };

        return d;
    }
}
