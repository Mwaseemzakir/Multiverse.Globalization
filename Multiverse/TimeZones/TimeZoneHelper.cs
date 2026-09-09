namespace Multiverse.Globalization.TimeZones;

/// <summary>
/// Provides IANA time-zone identifiers for the 250 compatibility country/territory records,
/// plus the widely used supplemental XK code for Kosovo. Bundled offsets are standard snapshots;
/// date-aware rules come from the operating system through <see cref="CountryTimeZone"/>.
/// </summary>
public static class TimeZoneHelper
{
    private static readonly Dictionary<string, List<CountryTimeZone>> _timeZones = InitializeTimeZones();

    /// <summary>
    /// Returns the time zones for a given country alpha-2 code, or an empty list if none are defined.
    /// </summary>
    internal static IReadOnlyList<CountryTimeZone> GetTimeZonesForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return [];

        return _timeZones.TryGetValue(alpha2Code.ToUpperInvariant(), out var list)
            ? list.AsReadOnly()
            : new List<CountryTimeZone>();
    }

    /// <summary>
    /// Returns the complete mapping of alpha-2 codes to time zone lists.
    /// </summary>
    public static IReadOnlyDictionary<string, List<CountryTimeZone>> All => _timeZones;

    private static Dictionary<string, List<CountryTimeZone>> InitializeTimeZones()
    {
        return new Dictionary<string, List<CountryTimeZone>>
        {
            // ── Asia ──────────────────────────────────────────────────────
            ["AF"] = [new("Asia/Kabul", 4.5, false)],
            ["AM"] = [new("Asia/Yerevan", 4, false)],
            ["AZ"] = [new("Asia/Baku", 4, false)],
            ["BH"] = [new("Asia/Bahrain", 3, false)],
            ["BD"] = [new("Asia/Dhaka", 6, false)],
            ["BT"] = [new("Asia/Thimphu", 6, false)],
            ["BN"] = [new("Asia/Brunei", 8, false)],
            ["KH"] = [new("Asia/Phnom_Penh", 7, false)],
            ["CN"] =
            [
                new("Asia/Shanghai", 8, false),
                new("Asia/Urumqi", 6, false)
            ],
            ["CY"] = [new("Asia/Nicosia", 2, true)],
            ["GE"] = [new("Asia/Tbilisi", 4, false)],
            ["IN"] = [new("Asia/Kolkata", 5.5, false)],
            ["ID"] =
            [
                new("Asia/Jakarta", 7, false),
                new("Asia/Makassar", 8, false),
                new("Asia/Jayapura", 9, false)
            ],
            ["IR"] = [new("Asia/Tehran", 3.5, true)],
            ["IQ"] = [new("Asia/Baghdad", 3, false)],
            ["IL"] = [new("Asia/Jerusalem", 2, true)],
            ["JP"] = [new("Asia/Tokyo", 9, false)],
            ["JO"] = [new("Asia/Amman", 3, false)],
            ["KZ"] =
            [
                new("Asia/Almaty", 5, false),
                new("Asia/Aqtobe", 5, false),
                new("Asia/Aqtau", 5, false),
                new("Asia/Atyrau", 5, false),
                new("Asia/Oral", 5, false),
                new("Asia/Qostanay", 5, false)
            ],
            ["KW"] = [new("Asia/Kuwait", 3, false)],
            ["KG"] = [new("Asia/Bishkek", 6, false)],
            ["LA"] = [new("Asia/Vientiane", 7, false)],
            ["LB"] = [new("Asia/Beirut", 2, true)],
            ["MY"] = [new("Asia/Kuala_Lumpur", 8, false)],
            ["MV"] = [new("Indian/Maldives", 5, false)],
            ["MN"] =
            [
                new("Asia/Ulaanbaatar", 8, false),
                new("Asia/Hovd", 7, false)
            ],
            ["MM"] = [new("Asia/Yangon", 6.5, false)],
            ["NP"] = [new("Asia/Kathmandu", 5.75, false)],
            ["KP"] = [new("Asia/Pyongyang", 9, false)],
            ["KR"] = [new("Asia/Seoul", 9, false)],
            ["OM"] = [new("Asia/Muscat", 4, false)],
            ["PK"] = [new("Asia/Karachi", 5, false)],
            ["PS"] =
            [
                new("Asia/Gaza", 2, true),
                new("Asia/Hebron", 2, true)
            ],
            ["PH"] = [new("Asia/Manila", 8, false)],
            ["QA"] = [new("Asia/Qatar", 3, false)],
            ["SA"] = [new("Asia/Riyadh", 3, false)],
            ["SG"] = [new("Asia/Singapore", 8, false)],
            ["LK"] = [new("Asia/Colombo", 5.5, false)],
            ["SY"] = [new("Asia/Damascus", 3, false)],
            ["TW"] = [new("Asia/Taipei", 8, false)],
            ["TJ"] = [new("Asia/Dushanbe", 5, false)],
            ["TH"] = [new("Asia/Bangkok", 7, false)],
            ["TL"] = [new("Asia/Dili", 9, false)],
            ["TM"] = [new("Asia/Ashgabat", 5, false)],
            ["AE"] = [new("Asia/Dubai", 4, false)],
            ["UZ"] =
            [
                new("Asia/Samarkand", 5, false),
                new("Asia/Tashkent", 5, false)
            ],
            ["VN"] = [new("Asia/Ho_Chi_Minh", 7, false)],
            ["YE"] = [new("Asia/Aden", 3, false)],

            // ── Europe ────────────────────────────────────────────────────
            ["AL"] = [new("Europe/Tirane", 1, true)],
            ["AD"] = [new("Europe/Andorra", 1, true)],
            ["AT"] = [new("Europe/Vienna", 1, true)],
            ["BY"] = [new("Europe/Minsk", 3, false)],
            ["BE"] = [new("Europe/Brussels", 1, true)],
            ["BA"] = [new("Europe/Sarajevo", 1, true)],
            ["BG"] = [new("Europe/Sofia", 2, true)],
            ["HR"] = [new("Europe/Zagreb", 1, true)],
            ["CZ"] = [new("Europe/Prague", 1, true)],
            ["DK"] = [new("Europe/Copenhagen", 1, true)],
            ["EE"] = [new("Europe/Tallinn", 2, true)],
            ["FI"] = [new("Europe/Helsinki", 2, true)],
            ["FR"] = [new("Europe/Paris", 1, true)],
            ["DE"] = [new("Europe/Berlin", 1, true)],
            ["GR"] = [new("Europe/Athens", 2, true)],
            ["HU"] = [new("Europe/Budapest", 1, true)],
            ["IS"] = [new("Atlantic/Reykjavik", 0, false)],
            ["IE"] = [new("Europe/Dublin", 1, true)],
            ["IT"] = [new("Europe/Rome", 1, true)],
            ["XK"] = [new("Europe/Belgrade", 1, true)],
            ["LV"] = [new("Europe/Riga", 2, true)],
            ["LI"] = [new("Europe/Vaduz", 1, true)],
            ["LT"] = [new("Europe/Vilnius", 2, true)],
            ["LU"] = [new("Europe/Luxembourg", 1, true)],
            ["MT"] = [new("Europe/Malta", 1, true)],
            ["MD"] = [new("Europe/Chisinau", 2, true)],
            ["MC"] = [new("Europe/Monaco", 1, true)],
            ["ME"] = [new("Europe/Podgorica", 1, true)],
            ["NL"] = [new("Europe/Amsterdam", 1, true)],
            ["MK"] = [new("Europe/Skopje", 1, true)],
            ["NO"] = [new("Europe/Oslo", 1, true)],
            ["PL"] = [new("Europe/Warsaw", 1, true)],
            ["PT"] =
            [
                new("Europe/Lisbon", 0, true),
                new("Atlantic/Azores", -1, true),
                new("Atlantic/Madeira", 0, true)
            ],
            ["RO"] = [new("Europe/Bucharest", 2, true)],
            ["RU"] =
            [
                new("Europe/Moscow", 3, false),
                new("Europe/Kaliningrad", 2, false),
                new("Europe/Samara", 4, false),
                new("Asia/Yekaterinburg", 5, false),
                new("Asia/Omsk", 6, false),
                new("Asia/Krasnoyarsk", 7, false),
                new("Asia/Irkutsk", 8, false),
                new("Asia/Yakutsk", 9, false),
                new("Asia/Vladivostok", 10, false),
                new("Asia/Magadan", 11, false),
                new("Asia/Kamchatka", 12, false)
            ],
            ["SM"] = [new("Europe/San_Marino", 1, true)],
            ["RS"] = [new("Europe/Belgrade", 1, true)],
            ["SK"] = [new("Europe/Bratislava", 1, true)],
            ["SI"] = [new("Europe/Ljubljana", 1, true)],
            ["ES"] =
            [
                new("Europe/Madrid", 1, true),
                new("Atlantic/Canary", 0, true)
            ],
            ["SE"] = [new("Europe/Stockholm", 1, true)],
            ["CH"] = [new("Europe/Zurich", 1, true)],
            ["TR"] = [new("Europe/Istanbul", 3, false)],
            ["UA"] = [new("Europe/Kyiv", 2, true)],
            ["GB"] = [new("Europe/London", 0, true)],
            ["VA"] = [new("Europe/Vatican", 1, true)],

            // ── Africa ────────────────────────────────────────────────────
            ["DZ"] = [new("Africa/Algiers", 1, false)],
            ["AO"] = [new("Africa/Luanda", 1, false)],
            ["BJ"] = [new("Africa/Porto-Novo", 1, false)],
            ["BW"] = [new("Africa/Gaborone", 2, false)],
            ["BF"] = [new("Africa/Ouagadougou", 0, false)],
            ["BI"] = [new("Africa/Bujumbura", 2, false)],
            ["CV"] = [new("Atlantic/Cape_Verde", -1, false)],
            ["CM"] = [new("Africa/Douala", 1, false)],
            ["CF"] = [new("Africa/Bangui", 1, false)],
            ["TD"] = [new("Africa/Ndjamena", 1, false)],
            ["KM"] = [new("Indian/Comoro", 3, false)],
            ["CG"] = [new("Africa/Brazzaville", 1, false)],
            ["CD"] =
            [
                new("Africa/Kinshasa", 1, false),
                new("Africa/Lubumbashi", 2, false)
            ],
            ["CI"] = [new("Africa/Abidjan", 0, false)],
            ["DJ"] = [new("Africa/Djibouti", 3, false)],
            ["EG"] = [new("Africa/Cairo", 2, true)],
            ["GQ"] = [new("Africa/Malabo", 1, false)],
            ["ER"] = [new("Africa/Asmara", 3, false)],
            ["SZ"] = [new("Africa/Mbabane", 2, false)],
            ["ET"] = [new("Africa/Addis_Ababa", 3, false)],
            ["GA"] = [new("Africa/Libreville", 1, false)],
            ["GM"] = [new("Africa/Banjul", 0, false)],
            ["GH"] = [new("Africa/Accra", 0, false)],
            ["GN"] = [new("Africa/Conakry", 0, false)],
            ["GW"] = [new("Africa/Bissau", 0, false)],
            ["KE"] = [new("Africa/Nairobi", 3, false)],
            ["LS"] = [new("Africa/Maseru", 2, false)],
            ["LR"] = [new("Africa/Monrovia", 0, false)],
            ["LY"] = [new("Africa/Tripoli", 2, false)],
            ["MG"] = [new("Indian/Antananarivo", 3, false)],
            ["MW"] = [new("Africa/Blantyre", 2, false)],
            ["ML"] = [new("Africa/Bamako", 0, false)],
            ["MR"] = [new("Africa/Nouakchott", 0, false)],
            ["MU"] = [new("Indian/Mauritius", 4, false)],
            ["MA"] = [new("Africa/Casablanca", 1, true)],
            ["MZ"] = [new("Africa/Maputo", 2, false)],
            ["NA"] = [new("Africa/Windhoek", 2, false)],
            ["NE"] = [new("Africa/Niamey", 1, false)],
            ["NG"] = [new("Africa/Lagos", 1, false)],
            ["RW"] = [new("Africa/Kigali", 2, false)],
            ["ST"] = [new("Africa/Sao_Tome", 0, false)],
            ["SN"] = [new("Africa/Dakar", 0, false)],
            ["SC"] = [new("Indian/Mahe", 4, false)],
            ["SL"] = [new("Africa/Freetown", 0, false)],
            ["SO"] = [new("Africa/Mogadishu", 3, false)],
            ["ZA"] = [new("Africa/Johannesburg", 2, false)],
            ["SS"] = [new("Africa/Juba", 2, false)],
            ["SD"] = [new("Africa/Khartoum", 2, false)],
            ["TZ"] = [new("Africa/Dar_es_Salaam", 3, false)],
            ["TG"] = [new("Africa/Lome", 0, false)],
            ["TN"] = [new("Africa/Tunis", 1, false)],
            ["UG"] = [new("Africa/Kampala", 3, false)],
            ["ZM"] = [new("Africa/Lusaka", 2, false)],
            ["ZW"] = [new("Africa/Harare", 2, false)],

            // ── Americas ──────────────────────────────────────────────────
            ["AG"] = [new("America/Antigua", -4, false)],
            ["AR"] = [new("America/Argentina/Buenos_Aires", -3, false)],
            ["BS"] = [new("America/Nassau", -5, true)],
            ["BB"] = [new("America/Barbados", -4, false)],
            ["BZ"] = [new("America/Belize", -6, false)],
            ["BO"] = [new("America/La_Paz", -4, false)],
            ["BR"] =
            [
                new("America/Sao_Paulo", -3, false),
                new("America/Manaus", -4, false),
                new("America/Cuiaba", -4, false),
                new("America/Belem", -3, false),
                new("America/Fortaleza", -3, false),
                new("America/Recife", -3, false),
                new("America/Noronha", -2, false),
                new("America/Rio_Branco", -5, false)
            ],
            ["CA"] =
            [
                new("America/Toronto", -5, true),
                new("America/Vancouver", -8, true),
                new("America/Edmonton", -7, true),
                new("America/Winnipeg", -6, true),
                new("America/Halifax", -4, true),
                new("America/St_Johns", -3.5, true),
                new("America/Regina", -6, false)
            ],
            ["CL"] =
            [
                new("America/Santiago", -4, true),
                new("Pacific/Easter", -6, true)
            ],
            ["CO"] = [new("America/Bogota", -5, false)],
            ["CR"] = [new("America/Costa_Rica", -6, false)],
            ["CU"] = [new("America/Havana", -5, true)],
            ["DM"] = [new("America/Dominica", -4, false)],
            ["DO"] = [new("America/Santo_Domingo", -4, false)],
            ["EC"] =
            [
                new("America/Guayaquil", -5, false),
                new("Pacific/Galapagos", -6, false)
            ],
            ["SV"] = [new("America/El_Salvador", -6, false)],
            ["GD"] = [new("America/Grenada", -4, false)],
            ["GT"] = [new("America/Guatemala", -6, false)],
            ["GY"] = [new("America/Guyana", -4, false)],
            ["HT"] = [new("America/Port-au-Prince", -5, true)],
            ["HN"] = [new("America/Tegucigalpa", -6, false)],
            ["JM"] = [new("America/Jamaica", -5, false)],
            ["MX"] =
            [
                new("America/Mexico_City", -6, false),
                new("America/Cancun", -5, false),
                new("America/Chihuahua", -6, false),
                new("America/Tijuana", -8, true),
                new("America/Hermosillo", -7, false),
                new("America/Mazatlan", -7, false)
            ],
            ["NI"] = [new("America/Managua", -6, false)],
            ["PA"] = [new("America/Panama", -5, false)],
            ["PY"] = [new("America/Asuncion", -4, true)],
            ["PE"] = [new("America/Lima", -5, false)],
            ["KN"] = [new("America/St_Kitts", -4, false)],
            ["LC"] = [new("America/St_Lucia", -4, false)],
            ["VC"] = [new("America/St_Vincent", -4, false)],
            ["SR"] = [new("America/Paramaribo", -3, false)],
            ["TT"] = [new("America/Port_of_Spain", -4, false)],
            ["US"] =
            [
                new("America/New_York", -5, true),
                new("America/Chicago", -6, true),
                new("America/Denver", -7, true),
                new("America/Los_Angeles", -8, true),
                new("America/Anchorage", -9, true),
                new("Pacific/Honolulu", -10, false),
                new("America/Phoenix", -7, false)
            ],
            ["UY"] = [new("America/Montevideo", -3, false)],
            ["VE"] = [new("America/Caracas", -4, false)],

            // ── Oceania ───────────────────────────────────────────────────
            ["AU"] =
            [
                new("Australia/Sydney", 11, true),
                new("Australia/Melbourne", 11, true),
                new("Australia/Brisbane", 10, false),
                new("Australia/Perth", 8, false),
                new("Australia/Adelaide", 10.5, true),
                new("Australia/Darwin", 9.5, false),
                new("Australia/Hobart", 11, true),
                new("Australia/Lord_Howe", 11, true)
            ],
            ["FJ"] = [new("Pacific/Fiji", 12, true)],
            ["KI"] =
            [
                new("Pacific/Tarawa", 12, false),
                new("Pacific/Kanton", 13, false),
                new("Pacific/Kiritimati", 14, false)
            ],
            ["MH"] = [new("Pacific/Majuro", 12, false)],
            ["FM"] =
            [
                new("Pacific/Chuuk", 10, false),
                new("Pacific/Pohnpei", 11, false),
                new("Pacific/Kosrae", 11, false)
            ],
            ["NR"] = [new("Pacific/Nauru", 12, false)],
            ["NZ"] =
            [
                new("Pacific/Auckland", 13, true),
                new("Pacific/Chatham", 13.75, true)
            ],
            ["PW"] = [new("Pacific/Palau", 9, false)],
            ["PG"] =
            [
                new("Pacific/Port_Moresby", 10, false),
                new("Pacific/Bougainville", 11, false)
            ],
            ["WS"] = [new("Pacific/Apia", 13, true)],
            ["SB"] = [new("Pacific/Guadalcanal", 11, false)],
            ["TO"] = [new("Pacific/Tongatapu", 13, false)],
            ["TV"] = [new("Pacific/Funafuti", 12, false)],
            ["VU"] = [new("Pacific/Efate", 11, false)],

            // ── Territories & Dependencies ────────────────────────────────
            ["AS"] = [new("Pacific/Pago_Pago", -11, false)],
            ["AI"] = [new("America/Anguilla", -4, false)],
            ["AW"] = [new("America/Aruba", -4, false)],
            ["BM"] = [new("Atlantic/Bermuda", -4, true)],
            ["BQ"] = [new("America/Kralendijk", -4, false)],
            ["VG"] = [new("America/Tortola", -4, false)],
            ["KY"] = [new("America/Cayman", -5, false)],
            ["CX"] = [new("Indian/Christmas", 7, false)],
            ["CC"] = [new("Indian/Cocos", 6.5, false)],
            ["CK"] = [new("Pacific/Rarotonga", -10, false)],
            ["CW"] = [new("America/Curacao", -4, false)],
            ["AN"] = [new("America/Curacao", -4, false)],
            ["FK"] = [new("Atlantic/Stanley", -3, false)],
            ["FO"] = [new("Atlantic/Faroe", 0, true)],
            ["GF"] = [new("America/Cayenne", -3, false)],
            ["PF"] =
            [
                new("Pacific/Tahiti", -10, false),
                new("Pacific/Marquesas", -9.5, false),
                new("Pacific/Gambier", -9, false)
            ],
            ["TF"] = [new("Indian/Kerguelen", 5, false)],
            ["HM"] = [new("Antarctica/Mawson", 5, false)],
            ["GI"] = [new("Europe/Gibraltar", 1, true)],
            ["GG"] = [new("Europe/Guernsey", 0, true)],
            ["JE"] = [new("Europe/Jersey", 0, true)],
            ["IM"] = [new("Europe/Isle_of_Man", 0, true)],
            ["GL"] =
            [
                new("America/Nuuk", -2, true),
                new("America/Danmarkshavn", 0, false),
                new("America/Scoresbysund", -1, true),
                new("America/Thule", -4, true)
            ],
            ["GP"] = [new("America/Guadeloupe", -4, false)],
            ["GU"] = [new("Pacific/Guam", 10, false)],
            ["HK"] = [new("Asia/Hong_Kong", 8, false)],
            ["IO"] = [new("Indian/Chagos", 6, false)],
            ["MO"] = [new("Asia/Macau", 8, false)],
            ["MQ"] = [new("America/Martinique", -4, false)],
            ["YT"] = [new("Indian/Mayotte", 3, false)],
            ["MS"] = [new("America/Montserrat", -4, false)],
            ["NC"] = [new("Pacific/Noumea", 11, false)],
            ["NU"] = [new("Pacific/Niue", -11, false)],
            ["NF"] = [new("Pacific/Norfolk", 12, true)],
            ["MP"] = [new("Pacific/Guam", 10, false)],
            ["PN"] = [new("Pacific/Pitcairn", -8, false)],
            ["PR"] = [new("America/Puerto_Rico", -4, false)],
            ["RE"] = [new("Indian/Reunion", 4, false)],
            ["BL"] = [new("America/St_Barthelemy", -4, false)],
            ["SH"] = [new("Atlantic/St_Helena", 0, false)],
            ["MF"] = [new("America/Marigot", -4, false)],
            ["PM"] = [new("America/Miquelon", -3, true)],
            ["SX"] = [new("America/Lower_Princes", -4, false)],
            ["GS"] = [new("Atlantic/South_Georgia", -2, false)],
            ["SJ"] = [new("Arctic/Longyearbyen", 1, true)],
            ["TK"] = [new("Pacific/Fakaofo", 13, false)],
            ["TC"] = [new("America/Grand_Turk", -5, true)],
            ["VI"] = [new("America/Virgin", -4, false)],
            ["UM"] =
            [
                new("Pacific/Wake", 12, false),
                new("Pacific/Midway", -11, false)
            ],
            ["WF"] = [new("Pacific/Wallis", 12, false)],
            ["EH"] = [new("Africa/El_Aaiun", 1, true)],
            ["AX"] = [new("Europe/Mariehamn", 2, true)],
            ["BV"] = [new("Antarctica/Troll", 0, true)],
            ["AQ"] =
            [
                new("Antarctica/Palmer", -3, false),
                new("Antarctica/McMurdo", 13, true),
                new("Antarctica/Rothera", -3, false),
                new("Antarctica/Syowa", 3, false),
                new("Antarctica/Mawson", 5, false),
                new("Antarctica/Davis", 7, false),
                new("Antarctica/Casey", 11, false),
                new("Antarctica/Vostok", 5, false),
                new("Antarctica/DumontDUrville", 10, false),
                new("Antarctica/Troll", 0, true)
            ],
        };
    }
}
