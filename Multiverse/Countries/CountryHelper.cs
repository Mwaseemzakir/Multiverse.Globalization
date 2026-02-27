using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
#if NET8_0_OR_GREATER
using System.Collections.Frozen;
#endif

namespace Multiverse.Globalization.Countries;

/// <summary>
/// Provides access to all country instances and lookup dictionaries.
/// Individual countries are defined as partial class members in the Data folder.
/// </summary>
public static partial class CountryHelper
{
    /// <summary>Empty sentinel value representing no country.</summary>
    public static readonly Country None = new Country("", "", "", "", "", "", "", null);

    /// <summary>
    /// Static constructor — runs after all static field initializers (the 250 country objects)
    /// have been created, enriching each country with sub-region, demonym, and TLD data.
    /// </summary>
    static CountryHelper()
    {
        InitializeExtendedData();
    }

    private static void InitializeExtendedData()
    {
        //                Alpha2 -> (SubRegion, Demonym, TLD)
        var data = new Dictionary<string, (string SubRegion, string Demonym, string TLD)>
        {
            // ── Asia ──────────────────────────────────────────────────────
            ["AF"] = ("Southern Asia", "Afghan", ".af"),
            ["AM"] = ("Western Asia", "Armenian", ".am"),
            ["AZ"] = ("Western Asia", "Azerbaijani", ".az"),
            ["BH"] = ("Western Asia", "Bahraini", ".bh"),
            ["BD"] = ("Southern Asia", "Bangladeshi", ".bd"),
            ["BT"] = ("Southern Asia", "Bhutanese", ".bt"),
            ["BN"] = ("South-eastern Asia", "Bruneian", ".bn"),
            ["KH"] = ("South-eastern Asia", "Cambodian", ".kh"),
            ["CN"] = ("Eastern Asia", "Chinese", ".cn"),
            ["CY"] = ("Western Asia", "Cypriot", ".cy"),
            ["GE"] = ("Western Asia", "Georgian", ".ge"),
            ["IN"] = ("Southern Asia", "Indian", ".in"),
            ["ID"] = ("South-eastern Asia", "Indonesian", ".id"),
            ["IR"] = ("Southern Asia", "Iranian", ".ir"),
            ["IQ"] = ("Western Asia", "Iraqi", ".iq"),
            ["IL"] = ("Western Asia", "Israeli", ".il"),
            ["JP"] = ("Eastern Asia", "Japanese", ".jp"),
            ["JO"] = ("Western Asia", "Jordanian", ".jo"),
            ["KZ"] = ("Central Asia", "Kazakhstani", ".kz"),
            ["KW"] = ("Western Asia", "Kuwaiti", ".kw"),
            ["KG"] = ("Central Asia", "Kyrgyz", ".kg"),
            ["LA"] = ("South-eastern Asia", "Laotian", ".la"),
            ["LB"] = ("Western Asia", "Lebanese", ".lb"),
            ["MY"] = ("South-eastern Asia", "Malaysian", ".my"),
            ["MV"] = ("Southern Asia", "Maldivian", ".mv"),
            ["MN"] = ("Eastern Asia", "Mongolian", ".mn"),
            ["MM"] = ("South-eastern Asia", "Burmese", ".mm"),
            ["NP"] = ("Southern Asia", "Nepalese", ".np"),
            ["KP"] = ("Eastern Asia", "North Korean", ".kp"),
            ["OM"] = ("Western Asia", "Omani", ".om"),
            ["PK"] = ("Southern Asia", "Pakistani", ".pk"),
            ["PS"] = ("Western Asia", "Palestinian", ".ps"),
            ["PH"] = ("South-eastern Asia", "Filipino", ".ph"),
            ["QA"] = ("Western Asia", "Qatari", ".qa"),
            ["SA"] = ("Western Asia", "Saudi", ".sa"),
            ["SG"] = ("South-eastern Asia", "Singaporean", ".sg"),
            ["KR"] = ("Eastern Asia", "South Korean", ".kr"),
            ["LK"] = ("Southern Asia", "Sri Lankan", ".lk"),
            ["SY"] = ("Western Asia", "Syrian", ".sy"),
            ["TW"] = ("Eastern Asia", "Taiwanese", ".tw"),
            ["TJ"] = ("Central Asia", "Tajik", ".tj"),
            ["TH"] = ("South-eastern Asia", "Thai", ".th"),
            ["TL"] = ("South-eastern Asia", "Timorese", ".tl"),
            ["TR"] = ("Western Asia", "Turkish", ".tr"),
            ["TM"] = ("Central Asia", "Turkmen", ".tm"),
            ["AE"] = ("Western Asia", "Emirati", ".ae"),
            ["UZ"] = ("Central Asia", "Uzbek", ".uz"),
            ["VN"] = ("South-eastern Asia", "Vietnamese", ".vn"),
            ["YE"] = ("Western Asia", "Yemeni", ".ye"),

            // ── Europe ────────────────────────────────────────────────────
            ["AL"] = ("Southern Europe", "Albanian", ".al"),
            ["AD"] = ("Southern Europe", "Andorran", ".ad"),
            ["AT"] = ("Western Europe", "Austrian", ".at"),
            ["BY"] = ("Eastern Europe", "Belarusian", ".by"),
            ["BE"] = ("Western Europe", "Belgian", ".be"),
            ["BA"] = ("Southern Europe", "Bosnian", ".ba"),
            ["BG"] = ("Eastern Europe", "Bulgarian", ".bg"),
            ["HR"] = ("Southern Europe", "Croatian", ".hr"),
            ["CZ"] = ("Eastern Europe", "Czech", ".cz"),
            ["DK"] = ("Northern Europe", "Danish", ".dk"),
            ["EE"] = ("Northern Europe", "Estonian", ".ee"),
            ["FI"] = ("Northern Europe", "Finnish", ".fi"),
            ["FR"] = ("Western Europe", "French", ".fr"),
            ["DE"] = ("Western Europe", "German", ".de"),
            ["GR"] = ("Southern Europe", "Greek", ".gr"),
            ["HU"] = ("Eastern Europe", "Hungarian", ".hu"),
            ["IS"] = ("Northern Europe", "Icelandic", ".is"),
            ["IE"] = ("Northern Europe", "Irish", ".ie"),
            ["IT"] = ("Southern Europe", "Italian", ".it"),
            ["LV"] = ("Northern Europe", "Latvian", ".lv"),
            ["LI"] = ("Western Europe", "Liechtensteiner", ".li"),
            ["LT"] = ("Northern Europe", "Lithuanian", ".lt"),
            ["LU"] = ("Western Europe", "Luxembourgish", ".lu"),
            ["MT"] = ("Southern Europe", "Maltese", ".mt"),
            ["MD"] = ("Eastern Europe", "Moldovan", ".md"),
            ["MC"] = ("Western Europe", "Monegasque", ".mc"),
            ["ME"] = ("Southern Europe", "Montenegrin", ".me"),
            ["NL"] = ("Western Europe", "Dutch", ".nl"),
            ["MK"] = ("Southern Europe", "Macedonian", ".mk"),
            ["NO"] = ("Northern Europe", "Norwegian", ".no"),
            ["PL"] = ("Eastern Europe", "Polish", ".pl"),
            ["PT"] = ("Southern Europe", "Portuguese", ".pt"),
            ["RO"] = ("Eastern Europe", "Romanian", ".ro"),
            ["RU"] = ("Eastern Europe", "Russian", ".ru"),
            ["SM"] = ("Southern Europe", "Sammarinese", ".sm"),
            ["RS"] = ("Southern Europe", "Serbian", ".rs"),
            ["SK"] = ("Eastern Europe", "Slovak", ".sk"),
            ["SI"] = ("Southern Europe", "Slovenian", ".si"),
            ["ES"] = ("Southern Europe", "Spanish", ".es"),
            ["SE"] = ("Northern Europe", "Swedish", ".se"),
            ["CH"] = ("Western Europe", "Swiss", ".ch"),
            ["UA"] = ("Eastern Europe", "Ukrainian", ".ua"),
            ["GB"] = ("Northern Europe", "British", ".uk"),
            ["VA"] = ("Southern Europe", "Vatican", ".va"),

            // ── Africa ────────────────────────────────────────────────────
            ["DZ"] = ("Northern Africa", "Algerian", ".dz"),
            ["AO"] = ("Middle Africa", "Angolan", ".ao"),
            ["BJ"] = ("Western Africa", "Beninese", ".bj"),
            ["BW"] = ("Southern Africa", "Motswana", ".bw"),
            ["BF"] = ("Western Africa", "Burkinabe", ".bf"),
            ["BI"] = ("Eastern Africa", "Burundian", ".bi"),
            ["CV"] = ("Western Africa", "Cape Verdean", ".cv"),
            ["CM"] = ("Middle Africa", "Cameroonian", ".cm"),
            ["CF"] = ("Middle Africa", "Central African", ".cf"),
            ["TD"] = ("Middle Africa", "Chadian", ".td"),
            ["KM"] = ("Eastern Africa", "Comorian", ".km"),
            ["CG"] = ("Middle Africa", "Congolese", ".cg"),
            ["CD"] = ("Middle Africa", "Congolese", ".cd"),
            ["CI"] = ("Western Africa", "Ivorian", ".ci"),
            ["DJ"] = ("Eastern Africa", "Djiboutian", ".dj"),
            ["EG"] = ("Northern Africa", "Egyptian", ".eg"),
            ["GQ"] = ("Middle Africa", "Equatoguinean", ".gq"),
            ["ER"] = ("Eastern Africa", "Eritrean", ".er"),
            ["SZ"] = ("Southern Africa", "Swazi", ".sz"),
            ["ET"] = ("Eastern Africa", "Ethiopian", ".et"),
            ["GA"] = ("Middle Africa", "Gabonese", ".ga"),
            ["GM"] = ("Western Africa", "Gambian", ".gm"),
            ["GH"] = ("Western Africa", "Ghanaian", ".gh"),
            ["GN"] = ("Western Africa", "Guinean", ".gn"),
            ["GW"] = ("Western Africa", "Bissau-Guinean", ".gw"),
            ["KE"] = ("Eastern Africa", "Kenyan", ".ke"),
            ["LS"] = ("Southern Africa", "Mosotho", ".ls"),
            ["LR"] = ("Western Africa", "Liberian", ".lr"),
            ["LY"] = ("Northern Africa", "Libyan", ".ly"),
            ["MG"] = ("Eastern Africa", "Malagasy", ".mg"),
            ["MW"] = ("Eastern Africa", "Malawian", ".mw"),
            ["ML"] = ("Western Africa", "Malian", ".ml"),
            ["MR"] = ("Western Africa", "Mauritanian", ".mr"),
            ["MU"] = ("Eastern Africa", "Mauritian", ".mu"),
            ["MA"] = ("Northern Africa", "Moroccan", ".ma"),
            ["MZ"] = ("Eastern Africa", "Mozambican", ".mz"),
            ["NA"] = ("Southern Africa", "Namibian", ".na"),
            ["NE"] = ("Western Africa", "Nigerien", ".ne"),
            ["NG"] = ("Western Africa", "Nigerian", ".ng"),
            ["RW"] = ("Eastern Africa", "Rwandan", ".rw"),
            ["ST"] = ("Middle Africa", "Sao Tomean", ".st"),
            ["SN"] = ("Western Africa", "Senegalese", ".sn"),
            ["SC"] = ("Eastern Africa", "Seychellois", ".sc"),
            ["SL"] = ("Western Africa", "Sierra Leonean", ".sl"),
            ["SO"] = ("Eastern Africa", "Somali", ".so"),
            ["ZA"] = ("Southern Africa", "South African", ".za"),
            ["SS"] = ("Eastern Africa", "South Sudanese", ".ss"),
            ["SD"] = ("Northern Africa", "Sudanese", ".sd"),
            ["TZ"] = ("Eastern Africa", "Tanzanian", ".tz"),
            ["TG"] = ("Western Africa", "Togolese", ".tg"),
            ["TN"] = ("Northern Africa", "Tunisian", ".tn"),
            ["UG"] = ("Eastern Africa", "Ugandan", ".ug"),
            ["ZM"] = ("Eastern Africa", "Zambian", ".zm"),
            ["ZW"] = ("Eastern Africa", "Zimbabwean", ".zw"),

            // ── Americas ──────────────────────────────────────────────────
            ["AG"] = ("Caribbean", "Antiguan", ".ag"),
            ["AR"] = ("South America", "Argentine", ".ar"),
            ["BS"] = ("Caribbean", "Bahamian", ".bs"),
            ["BB"] = ("Caribbean", "Barbadian", ".bb"),
            ["BZ"] = ("Central America", "Belizean", ".bz"),
            ["BO"] = ("South America", "Bolivian", ".bo"),
            ["BR"] = ("South America", "Brazilian", ".br"),
            ["CA"] = ("Northern America", "Canadian", ".ca"),
            ["CL"] = ("South America", "Chilean", ".cl"),
            ["CO"] = ("South America", "Colombian", ".co"),
            ["CR"] = ("Central America", "Costa Rican", ".cr"),
            ["CU"] = ("Caribbean", "Cuban", ".cu"),
            ["DM"] = ("Caribbean", "Dominican", ".dm"),
            ["DO"] = ("Caribbean", "Dominican", ".do"),
            ["EC"] = ("South America", "Ecuadorian", ".ec"),
            ["SV"] = ("Central America", "Salvadoran", ".sv"),
            ["GD"] = ("Caribbean", "Grenadian", ".gd"),
            ["GT"] = ("Central America", "Guatemalan", ".gt"),
            ["GY"] = ("South America", "Guyanese", ".gy"),
            ["HT"] = ("Caribbean", "Haitian", ".ht"),
            ["HN"] = ("Central America", "Honduran", ".hn"),
            ["JM"] = ("Caribbean", "Jamaican", ".jm"),
            ["MX"] = ("Central America", "Mexican", ".mx"),
            ["NI"] = ("Central America", "Nicaraguan", ".ni"),
            ["PA"] = ("Central America", "Panamanian", ".pa"),
            ["PY"] = ("South America", "Paraguayan", ".py"),
            ["PE"] = ("South America", "Peruvian", ".pe"),
            ["KN"] = ("Caribbean", "Kittitian", ".kn"),
            ["LC"] = ("Caribbean", "Saint Lucian", ".lc"),
            ["VC"] = ("Caribbean", "Vincentian", ".vc"),
            ["SR"] = ("South America", "Surinamese", ".sr"),
            ["TT"] = ("Caribbean", "Trinidadian", ".tt"),
            ["US"] = ("Northern America", "American", ".us"),
            ["UY"] = ("South America", "Uruguayan", ".uy"),
            ["VE"] = ("South America", "Venezuelan", ".ve"),

            // ── Oceania ───────────────────────────────────────────────────
            ["AU"] = ("Australia and New Zealand", "Australian", ".au"),
            ["FJ"] = ("Melanesia", "Fijian", ".fj"),
            ["KI"] = ("Micronesia", "I-Kiribati", ".ki"),
            ["MH"] = ("Micronesia", "Marshallese", ".mh"),
            ["FM"] = ("Micronesia", "Micronesian", ".fm"),
            ["NR"] = ("Micronesia", "Nauruan", ".nr"),
            ["NZ"] = ("Australia and New Zealand", "New Zealander", ".nz"),
            ["PW"] = ("Micronesia", "Palauan", ".pw"),
            ["PG"] = ("Melanesia", "Papua New Guinean", ".pg"),
            ["WS"] = ("Polynesia", "Samoan", ".ws"),
            ["SB"] = ("Melanesia", "Solomon Islander", ".sb"),
            ["TO"] = ("Polynesia", "Tongan", ".to"),
            ["TV"] = ("Polynesia", "Tuvaluan", ".tv"),
            ["VU"] = ("Melanesia", "Ni-Vanuatu", ".vu"),

            // ── Antarctic ─────────────────────────────────────────────────
            ["AQ"] = ("Antarctic", "", ".aq"),

            // ── Territories & Dependencies ─────────────────────────────────
            ["AS"] = ("Polynesia", "American Samoan", ".as"),
            ["AI"] = ("Caribbean", "Anguillan", ".ai"),
            ["AW"] = ("Caribbean", "Aruban", ".aw"),
            ["AN"] = ("Caribbean", "Dutch Antillean", ".an"),
            ["AX"] = ("Northern Europe", "Alandic", ".ax"),
            ["BM"] = ("Northern America", "Bermudian", ".bm"),
            ["BQ"] = ("Caribbean", "Dutch", ".bq"),
            ["BV"] = ("Antarctic", "Norwegian", ".bv"),
            ["VG"] = ("Caribbean", "British Virgin Islander", ".vg"),
            ["KY"] = ("Caribbean", "Caymanian", ".ky"),
            ["CK"] = ("Polynesia", "Cook Islander", ".ck"),
            ["CW"] = ("Caribbean", "Curacaoan", ".cw"),
            ["CC"] = ("Australia and New Zealand", "Cocos Islander", ".cc"),
            ["CX"] = ("Australia and New Zealand", "Christmas Islander", ".cx"),
            ["FK"] = ("South America", "Falkland Islander", ".fk"),
            ["FO"] = ("Northern Europe", "Faroese", ".fo"),
            ["GF"] = ("South America", "French Guianese", ".gf"),
            ["PF"] = ("Polynesia", "French Polynesian", ".pf"),
            ["TF"] = ("Antarctic", "French", ".tf"),
            ["GI"] = ("Southern Europe", "Gibraltarian", ".gi"),
            ["GL"] = ("Northern America", "Greenlandic", ".gl"),
            ["GP"] = ("Caribbean", "Guadeloupean", ".gp"),
            ["GU"] = ("Micronesia", "Guamanian", ".gu"),
            ["GG"] = ("Northern Europe", "Channel Islander", ".gg"),
            ["HK"] = ("Eastern Asia", "Hong Konger", ".hk"),
            ["HM"] = ("Antarctic", "Australian", ".hm"),
            ["IM"] = ("Northern Europe", "Manx", ".im"),
            ["IO"] = ("Eastern Africa", "British", ".io"),
            ["JE"] = ("Northern Europe", "Channel Islander", ".je"),
            ["MO"] = ("Eastern Asia", "Macanese", ".mo"),
            ["MQ"] = ("Caribbean", "Martinican", ".mq"),
            ["YT"] = ("Eastern Africa", "Mahoran", ".yt"),
            ["MS"] = ("Caribbean", "Montserratian", ".ms"),
            ["NC"] = ("Melanesia", "New Caledonian", ".nc"),
            ["NU"] = ("Polynesia", "Niuean", ".nu"),
            ["NF"] = ("Australia and New Zealand", "Norfolk Islander", ".nf"),
            ["MP"] = ("Micronesia", "Northern Mariana Islander", ".mp"),
            ["PN"] = ("Polynesia", "Pitcairn Islander", ".pn"),
            ["PR"] = ("Caribbean", "Puerto Rican", ".pr"),
            ["RE"] = ("Eastern Africa", "Reunionese", ".re"),
            ["BL"] = ("Caribbean", "Barthelemois", ".bl"),
            ["SH"] = ("Western Africa", "Saint Helenian", ".sh"),
            ["MF"] = ("Caribbean", "Saint-Martinoise", ".mf"),
            ["PM"] = ("Northern America", "Saint-Pierrais", ".pm"),
            ["SX"] = ("Caribbean", "Sint Maartener", ".sx"),
            ["GS"] = ("South America", "South Georgian", ".gs"),
            ["SJ"] = ("Northern Europe", "Norwegian", ".sj"),
            ["TK"] = ("Polynesia", "Tokelauan", ".tk"),
            ["TC"] = ("Caribbean", "Turks and Caicos Islander", ".tc"),
            ["VI"] = ("Caribbean", "U.S. Virgin Islander", ".vi"),
            ["UM"] = ("Polynesia", "American", ".um"),
            ["WF"] = ("Polynesia", "Wallisian", ".wf"),
            ["EH"] = ("Northern Africa", "Sahrawi", ".eh"),
        };

        foreach (var field in typeof(CountryHelper)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Country)))
        {
            var country = (Country)field.GetValue(null)!;
            if (data.TryGetValue(country.Alpha2Code, out var ext))
                country.SetExtendedData(ext.SubRegion, ext.Demonym, ext.TLD);
        }
    }

    private static readonly Lazy<List<Country>> _all = new(() =>
        typeof(CountryHelper)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Country))
            .Select(f => (Country)f.GetValue(null)!)
            .OrderBy(c => c.Name)
            .ToList());

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _alpha2CodeMap = new(() =>
#if NET8_0_OR_GREATER
        _all.Value.ToFrozenDictionary(c => c.Alpha2Code.ToLowerInvariant()));
#else
        _all.Value.ToDictionary(c => c.Alpha2Code.ToLowerInvariant()));
#endif

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _alpha3CodeMap = new(() =>
#if NET8_0_OR_GREATER
        _all.Value.ToFrozenDictionary(c => c.Alpha3Code.ToLowerInvariant()));
#else
        _all.Value.ToDictionary(c => c.Alpha3Code.ToLowerInvariant()));
#endif

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _nameMap = new(() =>
#if NET8_0_OR_GREATER
        _all.Value.ToFrozenDictionary(c => c.Name.ToLowerInvariant()));
#else
        _all.Value.ToDictionary(c => c.Name.ToLowerInvariant()));
#endif

    private static readonly Lazy<IReadOnlyDictionary<string, Country>> _numericCodeMap = new(() =>
#if NET8_0_OR_GREATER
        _all.Value.ToFrozenDictionary(c => c.NumericCode));
#else
        _all.Value.ToDictionary(c => c.NumericCode));
#endif

    /// <summary>Returns a cached read-only list containing all countries.</summary>
    public static IReadOnlyList<Country> GetAll() => _all.Value;

    /// <summary>Lookup by ISO 3166-1 alpha-2 code (case-insensitive).</summary>
    public static IReadOnlyDictionary<string, Country> Alpha2CodeMap => _alpha2CodeMap.Value;

    /// <summary>Lookup by ISO 3166-1 alpha-3 code (case-insensitive).</summary>
    public static IReadOnlyDictionary<string, Country> Alpha3CodeMap => _alpha3CodeMap.Value;

    /// <summary>Lookup by country name (case-insensitive).</summary>
    public static IReadOnlyDictionary<string, Country> NameMap => _nameMap.Value;

    /// <summary>Lookup by ISO 3166-1 numeric code.</summary>
    public static IReadOnlyDictionary<string, Country> NumericCodeMap => _numericCodeMap.Value;
}
