using System.Collections.Generic;

namespace Multiverse.Globalization.TimeZones;

/// <summary>
/// Provides IANA time zone data for all 250 countries and territories.
/// Each entry maps an ISO 3166-1 alpha-2 code to a list of time zones observed in that country.
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
            return new List<CountryTimeZone>();

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
            ["AF"] = new List<CountryTimeZone> { new("Asia/Kabul", 4.5, false) },
            ["AM"] = new List<CountryTimeZone> { new("Asia/Yerevan", 4, false) },
            ["AZ"] = new List<CountryTimeZone> { new("Asia/Baku", 4, false) },
            ["BH"] = new List<CountryTimeZone> { new("Asia/Bahrain", 3, false) },
            ["BD"] = new List<CountryTimeZone> { new("Asia/Dhaka", 6, false) },
            ["BT"] = new List<CountryTimeZone> { new("Asia/Thimphu", 6, false) },
            ["BN"] = new List<CountryTimeZone> { new("Asia/Brunei", 8, false) },
            ["KH"] = new List<CountryTimeZone> { new("Asia/Phnom_Penh", 7, false) },
            ["CN"] = new List<CountryTimeZone>
            {
                new("Asia/Shanghai", 8, false),
                new("Asia/Urumqi", 6, false)
            },
            ["CY"] = new List<CountryTimeZone> { new("Asia/Nicosia", 2, true) },
            ["GE"] = new List<CountryTimeZone> { new("Asia/Tbilisi", 4, false) },
            ["IN"] = new List<CountryTimeZone> { new("Asia/Kolkata", 5.5, false) },
            ["ID"] = new List<CountryTimeZone>
            {
                new("Asia/Jakarta", 7, false),
                new("Asia/Makassar", 8, false),
                new("Asia/Jayapura", 9, false)
            },
            ["IR"] = new List<CountryTimeZone> { new("Asia/Tehran", 3.5, true) },
            ["IQ"] = new List<CountryTimeZone> { new("Asia/Baghdad", 3, false) },
            ["IL"] = new List<CountryTimeZone> { new("Asia/Jerusalem", 2, true) },
            ["JP"] = new List<CountryTimeZone> { new("Asia/Tokyo", 9, false) },
            ["JO"] = new List<CountryTimeZone> { new("Asia/Amman", 3, false) },
            ["KZ"] = new List<CountryTimeZone>
            {
                new("Asia/Almaty", 5, false),
                new("Asia/Aqtobe", 5, false),
                new("Asia/Aqtau", 5, false),
                new("Asia/Atyrau", 5, false),
                new("Asia/Oral", 5, false),
                new("Asia/Qostanay", 5, false)
            },
            ["KW"] = new List<CountryTimeZone> { new("Asia/Kuwait", 3, false) },
            ["KG"] = new List<CountryTimeZone> { new("Asia/Bishkek", 6, false) },
            ["LA"] = new List<CountryTimeZone> { new("Asia/Vientiane", 7, false) },
            ["LB"] = new List<CountryTimeZone> { new("Asia/Beirut", 2, true) },
            ["MY"] = new List<CountryTimeZone> { new("Asia/Kuala_Lumpur", 8, false) },
            ["MV"] = new List<CountryTimeZone> { new("Indian/Maldives", 5, false) },
            ["MN"] = new List<CountryTimeZone>
            {
                new("Asia/Ulaanbaatar", 8, false),
                new("Asia/Hovd", 7, false)
            },
            ["MM"] = new List<CountryTimeZone> { new("Asia/Yangon", 6.5, false) },
            ["NP"] = new List<CountryTimeZone> { new("Asia/Kathmandu", 5.75, false) },
            ["KP"] = new List<CountryTimeZone> { new("Asia/Pyongyang", 9, false) },
            ["KR"] = new List<CountryTimeZone> { new("Asia/Seoul", 9, false) },
            ["OM"] = new List<CountryTimeZone> { new("Asia/Muscat", 4, false) },
            ["PK"] = new List<CountryTimeZone> { new("Asia/Karachi", 5, false) },
            ["PS"] = new List<CountryTimeZone>
            {
                new("Asia/Gaza", 2, true),
                new("Asia/Hebron", 2, true)
            },
            ["PH"] = new List<CountryTimeZone> { new("Asia/Manila", 8, false) },
            ["QA"] = new List<CountryTimeZone> { new("Asia/Qatar", 3, false) },
            ["SA"] = new List<CountryTimeZone> { new("Asia/Riyadh", 3, false) },
            ["SG"] = new List<CountryTimeZone> { new("Asia/Singapore", 8, false) },
            ["LK"] = new List<CountryTimeZone> { new("Asia/Colombo", 5.5, false) },
            ["SY"] = new List<CountryTimeZone> { new("Asia/Damascus", 3, false) },
            ["TW"] = new List<CountryTimeZone> { new("Asia/Taipei", 8, false) },
            ["TJ"] = new List<CountryTimeZone> { new("Asia/Dushanbe", 5, false) },
            ["TH"] = new List<CountryTimeZone> { new("Asia/Bangkok", 7, false) },
            ["TL"] = new List<CountryTimeZone> { new("Asia/Dili", 9, false) },
            ["TM"] = new List<CountryTimeZone> { new("Asia/Ashgabat", 5, false) },
            ["AE"] = new List<CountryTimeZone> { new("Asia/Dubai", 4, false) },
            ["UZ"] = new List<CountryTimeZone>
            {
                new("Asia/Samarkand", 5, false),
                new("Asia/Tashkent", 5, false)
            },
            ["VN"] = new List<CountryTimeZone> { new("Asia/Ho_Chi_Minh", 7, false) },
            ["YE"] = new List<CountryTimeZone> { new("Asia/Aden", 3, false) },

            // ── Europe ────────────────────────────────────────────────────
            ["AL"] = new List<CountryTimeZone> { new("Europe/Tirane", 1, true) },
            ["AD"] = new List<CountryTimeZone> { new("Europe/Andorra", 1, true) },
            ["AT"] = new List<CountryTimeZone> { new("Europe/Vienna", 1, true) },
            ["BY"] = new List<CountryTimeZone> { new("Europe/Minsk", 3, false) },
            ["BE"] = new List<CountryTimeZone> { new("Europe/Brussels", 1, true) },
            ["BA"] = new List<CountryTimeZone> { new("Europe/Sarajevo", 1, true) },
            ["BG"] = new List<CountryTimeZone> { new("Europe/Sofia", 2, true) },
            ["HR"] = new List<CountryTimeZone> { new("Europe/Zagreb", 1, true) },
            ["CZ"] = new List<CountryTimeZone> { new("Europe/Prague", 1, true) },
            ["DK"] = new List<CountryTimeZone> { new("Europe/Copenhagen", 1, true) },
            ["EE"] = new List<CountryTimeZone> { new("Europe/Tallinn", 2, true) },
            ["FI"] = new List<CountryTimeZone> { new("Europe/Helsinki", 2, true) },
            ["FR"] = new List<CountryTimeZone> { new("Europe/Paris", 1, true) },
            ["DE"] = new List<CountryTimeZone> { new("Europe/Berlin", 1, true) },
            ["GR"] = new List<CountryTimeZone> { new("Europe/Athens", 2, true) },
            ["HU"] = new List<CountryTimeZone> { new("Europe/Budapest", 1, true) },
            ["IS"] = new List<CountryTimeZone> { new("Atlantic/Reykjavik", 0, false) },
            ["IE"] = new List<CountryTimeZone> { new("Europe/Dublin", 1, true) },
            ["IT"] = new List<CountryTimeZone> { new("Europe/Rome", 1, true) },
            ["XK"] = new List<CountryTimeZone> { new("Europe/Belgrade", 1, true) },
            ["LV"] = new List<CountryTimeZone> { new("Europe/Riga", 2, true) },
            ["LI"] = new List<CountryTimeZone> { new("Europe/Vaduz", 1, true) },
            ["LT"] = new List<CountryTimeZone> { new("Europe/Vilnius", 2, true) },
            ["LU"] = new List<CountryTimeZone> { new("Europe/Luxembourg", 1, true) },
            ["MT"] = new List<CountryTimeZone> { new("Europe/Malta", 1, true) },
            ["MD"] = new List<CountryTimeZone> { new("Europe/Chisinau", 2, true) },
            ["MC"] = new List<CountryTimeZone> { new("Europe/Monaco", 1, true) },
            ["ME"] = new List<CountryTimeZone> { new("Europe/Podgorica", 1, true) },
            ["NL"] = new List<CountryTimeZone> { new("Europe/Amsterdam", 1, true) },
            ["MK"] = new List<CountryTimeZone> { new("Europe/Skopje", 1, true) },
            ["NO"] = new List<CountryTimeZone> { new("Europe/Oslo", 1, true) },
            ["PL"] = new List<CountryTimeZone> { new("Europe/Warsaw", 1, true) },
            ["PT"] = new List<CountryTimeZone>
            {
                new("Europe/Lisbon", 0, true),
                new("Atlantic/Azores", -1, true),
                new("Atlantic/Madeira", 0, true)
            },
            ["RO"] = new List<CountryTimeZone> { new("Europe/Bucharest", 2, true) },
            ["RU"] = new List<CountryTimeZone>
            {
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
            },
            ["SM"] = new List<CountryTimeZone> { new("Europe/San_Marino", 1, true) },
            ["RS"] = new List<CountryTimeZone> { new("Europe/Belgrade", 1, true) },
            ["SK"] = new List<CountryTimeZone> { new("Europe/Bratislava", 1, true) },
            ["SI"] = new List<CountryTimeZone> { new("Europe/Ljubljana", 1, true) },
            ["ES"] = new List<CountryTimeZone>
            {
                new("Europe/Madrid", 1, true),
                new("Atlantic/Canary", 0, true)
            },
            ["SE"] = new List<CountryTimeZone> { new("Europe/Stockholm", 1, true) },
            ["CH"] = new List<CountryTimeZone> { new("Europe/Zurich", 1, true) },
            ["TR"] = new List<CountryTimeZone> { new("Europe/Istanbul", 3, false) },
            ["UA"] = new List<CountryTimeZone> { new("Europe/Kyiv", 2, true) },
            ["GB"] = new List<CountryTimeZone> { new("Europe/London", 0, true) },
            ["VA"] = new List<CountryTimeZone> { new("Europe/Vatican", 1, true) },

            // ── Africa ────────────────────────────────────────────────────
            ["DZ"] = new List<CountryTimeZone> { new("Africa/Algiers", 1, false) },
            ["AO"] = new List<CountryTimeZone> { new("Africa/Luanda", 1, false) },
            ["BJ"] = new List<CountryTimeZone> { new("Africa/Porto-Novo", 1, false) },
            ["BW"] = new List<CountryTimeZone> { new("Africa/Gaborone", 2, false) },
            ["BF"] = new List<CountryTimeZone> { new("Africa/Ouagadougou", 0, false) },
            ["BI"] = new List<CountryTimeZone> { new("Africa/Bujumbura", 2, false) },
            ["CV"] = new List<CountryTimeZone> { new("Atlantic/Cape_Verde", -1, false) },
            ["CM"] = new List<CountryTimeZone> { new("Africa/Douala", 1, false) },
            ["CF"] = new List<CountryTimeZone> { new("Africa/Bangui", 1, false) },
            ["TD"] = new List<CountryTimeZone> { new("Africa/Ndjamena", 1, false) },
            ["KM"] = new List<CountryTimeZone> { new("Indian/Comoro", 3, false) },
            ["CG"] = new List<CountryTimeZone> { new("Africa/Brazzaville", 1, false) },
            ["CD"] = new List<CountryTimeZone>
            {
                new("Africa/Kinshasa", 1, false),
                new("Africa/Lubumbashi", 2, false)
            },
            ["CI"] = new List<CountryTimeZone> { new("Africa/Abidjan", 0, false) },
            ["DJ"] = new List<CountryTimeZone> { new("Africa/Djibouti", 3, false) },
            ["EG"] = new List<CountryTimeZone> { new("Africa/Cairo", 2, true) },
            ["GQ"] = new List<CountryTimeZone> { new("Africa/Malabo", 1, false) },
            ["ER"] = new List<CountryTimeZone> { new("Africa/Asmara", 3, false) },
            ["SZ"] = new List<CountryTimeZone> { new("Africa/Mbabane", 2, false) },
            ["ET"] = new List<CountryTimeZone> { new("Africa/Addis_Ababa", 3, false) },
            ["GA"] = new List<CountryTimeZone> { new("Africa/Libreville", 1, false) },
            ["GM"] = new List<CountryTimeZone> { new("Africa/Banjul", 0, false) },
            ["GH"] = new List<CountryTimeZone> { new("Africa/Accra", 0, false) },
            ["GN"] = new List<CountryTimeZone> { new("Africa/Conakry", 0, false) },
            ["GW"] = new List<CountryTimeZone> { new("Africa/Bissau", 0, false) },
            ["KE"] = new List<CountryTimeZone> { new("Africa/Nairobi", 3, false) },
            ["LS"] = new List<CountryTimeZone> { new("Africa/Maseru", 2, false) },
            ["LR"] = new List<CountryTimeZone> { new("Africa/Monrovia", 0, false) },
            ["LY"] = new List<CountryTimeZone> { new("Africa/Tripoli", 2, false) },
            ["MG"] = new List<CountryTimeZone> { new("Indian/Antananarivo", 3, false) },
            ["MW"] = new List<CountryTimeZone> { new("Africa/Blantyre", 2, false) },
            ["ML"] = new List<CountryTimeZone> { new("Africa/Bamako", 0, false) },
            ["MR"] = new List<CountryTimeZone> { new("Africa/Nouakchott", 0, false) },
            ["MU"] = new List<CountryTimeZone> { new("Indian/Mauritius", 4, false) },
            ["MA"] = new List<CountryTimeZone> { new("Africa/Casablanca", 1, true) },
            ["MZ"] = new List<CountryTimeZone> { new("Africa/Maputo", 2, false) },
            ["NA"] = new List<CountryTimeZone> { new("Africa/Windhoek", 2, false) },
            ["NE"] = new List<CountryTimeZone> { new("Africa/Niamey", 1, false) },
            ["NG"] = new List<CountryTimeZone> { new("Africa/Lagos", 1, false) },
            ["RW"] = new List<CountryTimeZone> { new("Africa/Kigali", 2, false) },
            ["ST"] = new List<CountryTimeZone> { new("Africa/Sao_Tome", 0, false) },
            ["SN"] = new List<CountryTimeZone> { new("Africa/Dakar", 0, false) },
            ["SC"] = new List<CountryTimeZone> { new("Indian/Mahe", 4, false) },
            ["SL"] = new List<CountryTimeZone> { new("Africa/Freetown", 0, false) },
            ["SO"] = new List<CountryTimeZone> { new("Africa/Mogadishu", 3, false) },
            ["ZA"] = new List<CountryTimeZone> { new("Africa/Johannesburg", 2, false) },
            ["SS"] = new List<CountryTimeZone> { new("Africa/Juba", 2, false) },
            ["SD"] = new List<CountryTimeZone> { new("Africa/Khartoum", 2, false) },
            ["TZ"] = new List<CountryTimeZone> { new("Africa/Dar_es_Salaam", 3, false) },
            ["TG"] = new List<CountryTimeZone> { new("Africa/Lome", 0, false) },
            ["TN"] = new List<CountryTimeZone> { new("Africa/Tunis", 1, false) },
            ["UG"] = new List<CountryTimeZone> { new("Africa/Kampala", 3, false) },
            ["ZM"] = new List<CountryTimeZone> { new("Africa/Lusaka", 2, false) },
            ["ZW"] = new List<CountryTimeZone> { new("Africa/Harare", 2, false) },

            // ── Americas ──────────────────────────────────────────────────
            ["AG"] = new List<CountryTimeZone> { new("America/Antigua", -4, false) },
            ["AR"] = new List<CountryTimeZone> { new("America/Argentina/Buenos_Aires", -3, false) },
            ["BS"] = new List<CountryTimeZone> { new("America/Nassau", -5, true) },
            ["BB"] = new List<CountryTimeZone> { new("America/Barbados", -4, false) },
            ["BZ"] = new List<CountryTimeZone> { new("America/Belize", -6, false) },
            ["BO"] = new List<CountryTimeZone> { new("America/La_Paz", -4, false) },
            ["BR"] = new List<CountryTimeZone>
            {
                new("America/Sao_Paulo", -3, false),
                new("America/Manaus", -4, false),
                new("America/Cuiaba", -4, false),
                new("America/Belem", -3, false),
                new("America/Fortaleza", -3, false),
                new("America/Recife", -3, false),
                new("America/Noronha", -2, false),
                new("America/Rio_Branco", -5, false)
            },
            ["CA"] = new List<CountryTimeZone>
            {
                new("America/Toronto", -5, true),
                new("America/Vancouver", -8, true),
                new("America/Edmonton", -7, true),
                new("America/Winnipeg", -6, true),
                new("America/Halifax", -4, true),
                new("America/St_Johns", -3.5, true),
                new("America/Regina", -6, false)
            },
            ["CL"] = new List<CountryTimeZone>
            {
                new("America/Santiago", -4, true),
                new("Pacific/Easter", -6, true)
            },
            ["CO"] = new List<CountryTimeZone> { new("America/Bogota", -5, false) },
            ["CR"] = new List<CountryTimeZone> { new("America/Costa_Rica", -6, false) },
            ["CU"] = new List<CountryTimeZone> { new("America/Havana", -5, true) },
            ["DM"] = new List<CountryTimeZone> { new("America/Dominica", -4, false) },
            ["DO"] = new List<CountryTimeZone> { new("America/Santo_Domingo", -4, false) },
            ["EC"] = new List<CountryTimeZone>
            {
                new("America/Guayaquil", -5, false),
                new("Pacific/Galapagos", -6, false)
            },
            ["SV"] = new List<CountryTimeZone> { new("America/El_Salvador", -6, false) },
            ["GD"] = new List<CountryTimeZone> { new("America/Grenada", -4, false) },
            ["GT"] = new List<CountryTimeZone> { new("America/Guatemala", -6, false) },
            ["GY"] = new List<CountryTimeZone> { new("America/Guyana", -4, false) },
            ["HT"] = new List<CountryTimeZone> { new("America/Port-au-Prince", -5, true) },
            ["HN"] = new List<CountryTimeZone> { new("America/Tegucigalpa", -6, false) },
            ["JM"] = new List<CountryTimeZone> { new("America/Jamaica", -5, false) },
            ["MX"] = new List<CountryTimeZone>
            {
                new("America/Mexico_City", -6, false),
                new("America/Cancun", -5, false),
                new("America/Chihuahua", -6, false),
                new("America/Tijuana", -8, true),
                new("America/Hermosillo", -7, false),
                new("America/Mazatlan", -7, false)
            },
            ["NI"] = new List<CountryTimeZone> { new("America/Managua", -6, false) },
            ["PA"] = new List<CountryTimeZone> { new("America/Panama", -5, false) },
            ["PY"] = new List<CountryTimeZone> { new("America/Asuncion", -4, true) },
            ["PE"] = new List<CountryTimeZone> { new("America/Lima", -5, false) },
            ["KN"] = new List<CountryTimeZone> { new("America/St_Kitts", -4, false) },
            ["LC"] = new List<CountryTimeZone> { new("America/St_Lucia", -4, false) },
            ["VC"] = new List<CountryTimeZone> { new("America/St_Vincent", -4, false) },
            ["SR"] = new List<CountryTimeZone> { new("America/Paramaribo", -3, false) },
            ["TT"] = new List<CountryTimeZone> { new("America/Port_of_Spain", -4, false) },
            ["US"] = new List<CountryTimeZone>
            {
                new("America/New_York", -5, true),
                new("America/Chicago", -6, true),
                new("America/Denver", -7, true),
                new("America/Los_Angeles", -8, true),
                new("America/Anchorage", -9, true),
                new("Pacific/Honolulu", -10, false),
                new("America/Phoenix", -7, false)
            },
            ["UY"] = new List<CountryTimeZone> { new("America/Montevideo", -3, false) },
            ["VE"] = new List<CountryTimeZone> { new("America/Caracas", -4, false) },

            // ── Oceania ───────────────────────────────────────────────────
            ["AU"] = new List<CountryTimeZone>
            {
                new("Australia/Sydney", 11, true),
                new("Australia/Melbourne", 11, true),
                new("Australia/Brisbane", 10, false),
                new("Australia/Perth", 8, false),
                new("Australia/Adelaide", 10.5, true),
                new("Australia/Darwin", 9.5, false),
                new("Australia/Hobart", 11, true),
                new("Australia/Lord_Howe", 11, true)
            },
            ["FJ"] = new List<CountryTimeZone> { new("Pacific/Fiji", 12, true) },
            ["KI"] = new List<CountryTimeZone>
            {
                new("Pacific/Tarawa", 12, false),
                new("Pacific/Kanton", 13, false),
                new("Pacific/Kiritimati", 14, false)
            },
            ["MH"] = new List<CountryTimeZone> { new("Pacific/Majuro", 12, false) },
            ["FM"] = new List<CountryTimeZone>
            {
                new("Pacific/Chuuk", 10, false),
                new("Pacific/Pohnpei", 11, false),
                new("Pacific/Kosrae", 11, false)
            },
            ["NR"] = new List<CountryTimeZone> { new("Pacific/Nauru", 12, false) },
            ["NZ"] = new List<CountryTimeZone>
            {
                new("Pacific/Auckland", 13, true),
                new("Pacific/Chatham", 13.75, true)
            },
            ["PW"] = new List<CountryTimeZone> { new("Pacific/Palau", 9, false) },
            ["PG"] = new List<CountryTimeZone>
            {
                new("Pacific/Port_Moresby", 10, false),
                new("Pacific/Bougainville", 11, false)
            },
            ["WS"] = new List<CountryTimeZone> { new("Pacific/Apia", 13, true) },
            ["SB"] = new List<CountryTimeZone> { new("Pacific/Guadalcanal", 11, false) },
            ["TO"] = new List<CountryTimeZone> { new("Pacific/Tongatapu", 13, false) },
            ["TV"] = new List<CountryTimeZone> { new("Pacific/Funafuti", 12, false) },
            ["VU"] = new List<CountryTimeZone> { new("Pacific/Efate", 11, false) },

            // ── Territories & Dependencies ────────────────────────────────
            ["AS"] = new List<CountryTimeZone> { new("Pacific/Pago_Pago", -11, false) },
            ["AI"] = new List<CountryTimeZone> { new("America/Anguilla", -4, false) },
            ["AW"] = new List<CountryTimeZone> { new("America/Aruba", -4, false) },
            ["BM"] = new List<CountryTimeZone> { new("Atlantic/Bermuda", -4, true) },
            ["BQ"] = new List<CountryTimeZone> { new("America/Kralendijk", -4, false) },
            ["VG"] = new List<CountryTimeZone> { new("America/Tortola", -4, false) },
            ["KY"] = new List<CountryTimeZone> { new("America/Cayman", -5, false) },
            ["CX"] = new List<CountryTimeZone> { new("Indian/Christmas", 7, false) },
            ["CC"] = new List<CountryTimeZone> { new("Indian/Cocos", 6.5, false) },
            ["CK"] = new List<CountryTimeZone> { new("Pacific/Rarotonga", -10, false) },
            ["CW"] = new List<CountryTimeZone> { new("America/Curacao", -4, false) },
            ["FK"] = new List<CountryTimeZone> { new("Atlantic/Stanley", -3, false) },
            ["FO"] = new List<CountryTimeZone> { new("Atlantic/Faroe", 0, true) },
            ["GF"] = new List<CountryTimeZone> { new("America/Cayenne", -3, false) },
            ["PF"] = new List<CountryTimeZone>
            {
                new("Pacific/Tahiti", -10, false),
                new("Pacific/Marquesas", -9.5, false),
                new("Pacific/Gambier", -9, false)
            },
            ["TF"] = new List<CountryTimeZone> { new("Indian/Kerguelen", 5, false) },
            ["GI"] = new List<CountryTimeZone> { new("Europe/Gibraltar", 1, true) },
            ["GL"] = new List<CountryTimeZone>
            {
                new("America/Nuuk", -2, true),
                new("America/Danmarkshavn", 0, false),
                new("America/Scoresbysund", -1, true),
                new("America/Thule", -4, true)
            },
            ["GP"] = new List<CountryTimeZone> { new("America/Guadeloupe", -4, false) },
            ["GU"] = new List<CountryTimeZone> { new("Pacific/Guam", 10, false) },
            ["HK"] = new List<CountryTimeZone> { new("Asia/Hong_Kong", 8, false) },
            ["IO"] = new List<CountryTimeZone> { new("Indian/Chagos", 6, false) },
            ["MO"] = new List<CountryTimeZone> { new("Asia/Macau", 8, false) },
            ["MQ"] = new List<CountryTimeZone> { new("America/Martinique", -4, false) },
            ["YT"] = new List<CountryTimeZone> { new("Indian/Mayotte", 3, false) },
            ["MS"] = new List<CountryTimeZone> { new("America/Montserrat", -4, false) },
            ["NC"] = new List<CountryTimeZone> { new("Pacific/Noumea", 11, false) },
            ["NU"] = new List<CountryTimeZone> { new("Pacific/Niue", -11, false) },
            ["NF"] = new List<CountryTimeZone> { new("Pacific/Norfolk", 12, true) },
            ["MP"] = new List<CountryTimeZone> { new("Pacific/Guam", 10, false) },
            ["PN"] = new List<CountryTimeZone> { new("Pacific/Pitcairn", -8, false) },
            ["PR"] = new List<CountryTimeZone> { new("America/Puerto_Rico", -4, false) },
            ["RE"] = new List<CountryTimeZone> { new("Indian/Reunion", 4, false) },
            ["BL"] = new List<CountryTimeZone> { new("America/St_Barthelemy", -4, false) },
            ["SH"] = new List<CountryTimeZone> { new("Atlantic/St_Helena", 0, false) },
            ["MF"] = new List<CountryTimeZone> { new("America/Marigot", -4, false) },
            ["PM"] = new List<CountryTimeZone> { new("America/Miquelon", -3, true) },
            ["SX"] = new List<CountryTimeZone> { new("America/Lower_Princes", -4, false) },
            ["GS"] = new List<CountryTimeZone> { new("Atlantic/South_Georgia", -2, false) },
            ["SJ"] = new List<CountryTimeZone> { new("Arctic/Longyearbyen", 1, true) },
            ["TK"] = new List<CountryTimeZone> { new("Pacific/Fakaofo", 13, false) },
            ["TC"] = new List<CountryTimeZone> { new("America/Grand_Turk", -5, true) },
            ["VI"] = new List<CountryTimeZone> { new("America/Virgin", -4, false) },
            ["UM"] = new List<CountryTimeZone>
            {
                new("Pacific/Wake", 12, false),
                new("Pacific/Midway", -11, false)
            },
            ["WF"] = new List<CountryTimeZone> { new("Pacific/Wallis", 12, false) },
            ["EH"] = new List<CountryTimeZone> { new("Africa/El_Aaiun", 1, true) },
            ["AX"] = new List<CountryTimeZone> { new("Europe/Mariehamn", 2, true) },
            ["BV"] = new List<CountryTimeZone> { new("Antarctica/Troll", 0, true) },
            ["AQ"] = new List<CountryTimeZone>
            {
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
            },
        };
    }
}
