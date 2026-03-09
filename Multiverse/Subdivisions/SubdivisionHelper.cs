using System.Collections.Generic;

namespace Multiverse.Globalization.Subdivisions;

/// <summary>
/// Provides ISO 3166-2 subdivision data (states, provinces, regions) for countries.
/// </summary>
public static class SubdivisionHelper
{
    private static readonly Dictionary<string, List<Subdivision>> _data = InitializeData();

    internal static IReadOnlyList<Subdivision> GetSubdivisionsForCountry(string alpha2Code)
    {
        if (string.IsNullOrWhiteSpace(alpha2Code))
            return new List<Subdivision>();
        return _data.TryGetValue(alpha2Code.ToUpperInvariant(), out var list)
            ? list.AsReadOnly()
            : new List<Subdivision>();
    }

    /// <summary>All subdivision data keyed by country alpha-2 code.</summary>
    public static IReadOnlyDictionary<string, List<Subdivision>> All => _data;

    private static Dictionary<string, List<Subdivision>> InitializeData()
    {
        var s = new Dictionary<string, List<Subdivision>>();

        s["US"] = new List<Subdivision>
        {
            new("US-AL", "Alabama", "State"), new("US-AK", "Alaska", "State"),
            new("US-AZ", "Arizona", "State"), new("US-AR", "Arkansas", "State"),
            new("US-CA", "California", "State"), new("US-CO", "Colorado", "State"),
            new("US-CT", "Connecticut", "State"), new("US-DE", "Delaware", "State"),
            new("US-FL", "Florida", "State"), new("US-GA", "Georgia", "State"),
            new("US-HI", "Hawaii", "State"), new("US-ID", "Idaho", "State"),
            new("US-IL", "Illinois", "State"), new("US-IN", "Indiana", "State"),
            new("US-IA", "Iowa", "State"), new("US-KS", "Kansas", "State"),
            new("US-KY", "Kentucky", "State"), new("US-LA", "Louisiana", "State"),
            new("US-ME", "Maine", "State"), new("US-MD", "Maryland", "State"),
            new("US-MA", "Massachusetts", "State"), new("US-MI", "Michigan", "State"),
            new("US-MN", "Minnesota", "State"), new("US-MS", "Mississippi", "State"),
            new("US-MO", "Missouri", "State"), new("US-MT", "Montana", "State"),
            new("US-NE", "Nebraska", "State"), new("US-NV", "Nevada", "State"),
            new("US-NH", "New Hampshire", "State"), new("US-NJ", "New Jersey", "State"),
            new("US-NM", "New Mexico", "State"), new("US-NY", "New York", "State"),
            new("US-NC", "North Carolina", "State"), new("US-ND", "North Dakota", "State"),
            new("US-OH", "Ohio", "State"), new("US-OK", "Oklahoma", "State"),
            new("US-OR", "Oregon", "State"), new("US-PA", "Pennsylvania", "State"),
            new("US-RI", "Rhode Island", "State"), new("US-SC", "South Carolina", "State"),
            new("US-SD", "South Dakota", "State"), new("US-TN", "Tennessee", "State"),
            new("US-TX", "Texas", "State"), new("US-UT", "Utah", "State"),
            new("US-VT", "Vermont", "State"), new("US-VA", "Virginia", "State"),
            new("US-WA", "Washington", "State"), new("US-WV", "West Virginia", "State"),
            new("US-WI", "Wisconsin", "State"), new("US-WY", "Wyoming", "State"),
            new("US-DC", "District of Columbia", "District"),
        };

        s["CA"] = new List<Subdivision>
        {
            new("CA-AB", "Alberta", "Province"), new("CA-BC", "British Columbia", "Province"),
            new("CA-MB", "Manitoba", "Province"), new("CA-NB", "New Brunswick", "Province"),
            new("CA-NL", "Newfoundland and Labrador", "Province"), new("CA-NS", "Nova Scotia", "Province"),
            new("CA-ON", "Ontario", "Province"), new("CA-PE", "Prince Edward Island", "Province"),
            new("CA-QC", "Quebec", "Province"), new("CA-SK", "Saskatchewan", "Province"),
            new("CA-NT", "Northwest Territories", "Territory"), new("CA-NU", "Nunavut", "Territory"),
            new("CA-YT", "Yukon", "Territory"),
        };

        s["GB"] = new List<Subdivision>
        {
            new("GB-ENG", "England", "Country"), new("GB-SCT", "Scotland", "Country"),
            new("GB-WLS", "Wales", "Country"), new("GB-NIR", "Northern Ireland", "Province"),
        };

        s["DE"] = new List<Subdivision>
        {
            new("DE-BW", "Baden-Württemberg", "State"), new("DE-BY", "Bavaria", "State"),
            new("DE-BE", "Berlin", "State"), new("DE-BB", "Brandenburg", "State"),
            new("DE-HB", "Bremen", "State"), new("DE-HH", "Hamburg", "State"),
            new("DE-HE", "Hesse", "State"), new("DE-MV", "Mecklenburg-Vorpommern", "State"),
            new("DE-NI", "Lower Saxony", "State"), new("DE-NW", "North Rhine-Westphalia", "State"),
            new("DE-RP", "Rhineland-Palatinate", "State"), new("DE-SL", "Saarland", "State"),
            new("DE-SN", "Saxony", "State"), new("DE-ST", "Saxony-Anhalt", "State"),
            new("DE-SH", "Schleswig-Holstein", "State"), new("DE-TH", "Thuringia", "State"),
        };

        s["FR"] = new List<Subdivision>
        {
            new("FR-ARA", "Auvergne-Rhône-Alpes", "Region"), new("FR-BFC", "Bourgogne-Franche-Comté", "Region"),
            new("FR-BRE", "Bretagne", "Region"), new("FR-CVL", "Centre-Val de Loire", "Region"),
            new("FR-COR", "Corse", "Region"), new("FR-GES", "Grand Est", "Region"),
            new("FR-HDF", "Hauts-de-France", "Region"), new("FR-IDF", "Île-de-France", "Region"),
            new("FR-NOR", "Normandie", "Region"), new("FR-NAQ", "Nouvelle-Aquitaine", "Region"),
            new("FR-OCC", "Occitanie", "Region"), new("FR-PDL", "Pays de la Loire", "Region"),
            new("FR-PAC", "Provence-Alpes-Côte d'Azur", "Region"),
        };

        s["AU"] = new List<Subdivision>
        {
            new("AU-NSW", "New South Wales", "State"), new("AU-QLD", "Queensland", "State"),
            new("AU-SA", "South Australia", "State"), new("AU-TAS", "Tasmania", "State"),
            new("AU-VIC", "Victoria", "State"), new("AU-WA", "Western Australia", "State"),
            new("AU-ACT", "Australian Capital Territory", "Territory"), new("AU-NT", "Northern Territory", "Territory"),
        };

        s["IN"] = new List<Subdivision>
        {
            new("IN-AP", "Andhra Pradesh", "State"), new("IN-AR", "Arunachal Pradesh", "State"),
            new("IN-AS", "Assam", "State"), new("IN-BR", "Bihar", "State"),
            new("IN-CG", "Chhattisgarh", "State"), new("IN-GA", "Goa", "State"),
            new("IN-GJ", "Gujarat", "State"), new("IN-HR", "Haryana", "State"),
            new("IN-HP", "Himachal Pradesh", "State"), new("IN-JH", "Jharkhand", "State"),
            new("IN-KA", "Karnataka", "State"), new("IN-KL", "Kerala", "State"),
            new("IN-MP", "Madhya Pradesh", "State"), new("IN-MH", "Maharashtra", "State"),
            new("IN-MN", "Manipur", "State"), new("IN-ML", "Meghalaya", "State"),
            new("IN-MZ", "Mizoram", "State"), new("IN-NL", "Nagaland", "State"),
            new("IN-OD", "Odisha", "State"), new("IN-PB", "Punjab", "State"),
            new("IN-RJ", "Rajasthan", "State"), new("IN-SK", "Sikkim", "State"),
            new("IN-TN", "Tamil Nadu", "State"), new("IN-TS", "Telangana", "State"),
            new("IN-TR", "Tripura", "State"), new("IN-UP", "Uttar Pradesh", "State"),
            new("IN-UK", "Uttarakhand", "State"), new("IN-WB", "West Bengal", "State"),
            new("IN-DL", "Delhi", "Union Territory"),
        };

        s["PK"] = new List<Subdivision>
        {
            new("PK-PB", "Punjab", "Province"), new("PK-SD", "Sindh", "Province"),
            new("PK-KP", "Khyber Pakhtunkhwa", "Province"), new("PK-BA", "Balochistan", "Province"),
            new("PK-IS", "Islamabad Capital Territory", "Federal Territory"),
            new("PK-GB", "Gilgit-Baltistan", "Territory"), new("PK-JK", "Azad Jammu and Kashmir", "Territory"),
        };

        s["JP"] = new List<Subdivision>
        {
            new("JP-01", "Hokkaido", "Prefecture"), new("JP-02", "Aomori", "Prefecture"),
            new("JP-13", "Tokyo", "Metropolis"), new("JP-14", "Kanagawa", "Prefecture"),
            new("JP-23", "Aichi", "Prefecture"), new("JP-26", "Kyoto", "Prefecture"),
            new("JP-27", "Osaka", "Prefecture"), new("JP-28", "Hyogo", "Prefecture"),
            new("JP-40", "Fukuoka", "Prefecture"), new("JP-47", "Okinawa", "Prefecture"),
        };

        s["CN"] = new List<Subdivision>
        {
            new("CN-BJ", "Beijing", "Municipality"), new("CN-SH", "Shanghai", "Municipality"),
            new("CN-TJ", "Tianjin", "Municipality"), new("CN-CQ", "Chongqing", "Municipality"),
            new("CN-GD", "Guangdong", "Province"), new("CN-JS", "Jiangsu", "Province"),
            new("CN-ZJ", "Zhejiang", "Province"), new("CN-SD", "Shandong", "Province"),
            new("CN-HN", "Henan", "Province"), new("CN-SC", "Sichuan", "Province"),
            new("CN-HB", "Hubei", "Province"), new("CN-FJ", "Fujian", "Province"),
            new("CN-HK", "Hong Kong", "Special Administrative Region"),
            new("CN-MO", "Macau", "Special Administrative Region"),
            new("CN-XZ", "Tibet", "Autonomous Region"), new("CN-XJ", "Xinjiang", "Autonomous Region"),
        };

        s["BR"] = new List<Subdivision>
        {
            new("BR-AC", "Acre", "State"), new("BR-AL", "Alagoas", "State"),
            new("BR-AM", "Amazonas", "State"), new("BR-AP", "Amapá", "State"),
            new("BR-BA", "Bahia", "State"), new("BR-CE", "Ceará", "State"),
            new("BR-DF", "Federal District", "Federal District"), new("BR-ES", "Espírito Santo", "State"),
            new("BR-GO", "Goiás", "State"), new("BR-MA", "Maranhão", "State"),
            new("BR-MG", "Minas Gerais", "State"), new("BR-MS", "Mato Grosso do Sul", "State"),
            new("BR-MT", "Mato Grosso", "State"), new("BR-PA", "Pará", "State"),
            new("BR-PB", "Paraíba", "State"), new("BR-PE", "Pernambuco", "State"),
            new("BR-PI", "Piauí", "State"), new("BR-PR", "Paraná", "State"),
            new("BR-RJ", "Rio de Janeiro", "State"), new("BR-RN", "Rio Grande do Norte", "State"),
            new("BR-RO", "Rondônia", "State"), new("BR-RR", "Roraima", "State"),
            new("BR-RS", "Rio Grande do Sul", "State"), new("BR-SC", "Santa Catarina", "State"),
            new("BR-SE", "Sergipe", "State"), new("BR-SP", "São Paulo", "State"),
            new("BR-TO", "Tocantins", "State"),
        };

        s["MX"] = new List<Subdivision>
        {
            new("MX-AGU", "Aguascalientes", "State"), new("MX-BCN", "Baja California", "State"),
            new("MX-BCS", "Baja California Sur", "State"), new("MX-CAM", "Campeche", "State"),
            new("MX-CHP", "Chiapas", "State"), new("MX-CHH", "Chihuahua", "State"),
            new("MX-CMX", "Mexico City", "Federal District"), new("MX-COA", "Coahuila", "State"),
            new("MX-COL", "Colima", "State"), new("MX-DUR", "Durango", "State"),
            new("MX-GUA", "Guanajuato", "State"), new("MX-GRO", "Guerrero", "State"),
            new("MX-HID", "Hidalgo", "State"), new("MX-JAL", "Jalisco", "State"),
            new("MX-MEX", "State of Mexico", "State"), new("MX-MIC", "Michoacán", "State"),
            new("MX-MOR", "Morelos", "State"), new("MX-NAY", "Nayarit", "State"),
            new("MX-NLE", "Nuevo León", "State"), new("MX-OAX", "Oaxaca", "State"),
            new("MX-PUE", "Puebla", "State"), new("MX-QUE", "Querétaro", "State"),
            new("MX-ROO", "Quintana Roo", "State"), new("MX-SLP", "San Luis Potosí", "State"),
            new("MX-SIN", "Sinaloa", "State"), new("MX-SON", "Sonora", "State"),
            new("MX-TAB", "Tabasco", "State"), new("MX-TAM", "Tamaulipas", "State"),
            new("MX-TLA", "Tlaxcala", "State"), new("MX-VER", "Veracruz", "State"),
            new("MX-YUC", "Yucatán", "State"), new("MX-ZAC", "Zacatecas", "State"),
        };

        s["RU"] = new List<Subdivision>
        {
            new("RU-MOW", "Moscow", "Federal City"), new("RU-SPE", "Saint Petersburg", "Federal City"),
            new("RU-MOS", "Moscow Oblast", "Oblast"), new("RU-LEN", "Leningrad Oblast", "Oblast"),
            new("RU-NIZ", "Nizhny Novgorod Oblast", "Oblast"), new("RU-SVE", "Sverdlovsk Oblast", "Oblast"),
            new("RU-KDA", "Krasnodar Krai", "Krai"), new("RU-TAT", "Republic of Tatarstan", "Republic"),
            new("RU-BA", "Republic of Bashkortostan", "Republic"), new("RU-NSO", "Novosibirsk Oblast", "Oblast"),
            new("RU-CE", "Chechen Republic", "Republic"),
        };

        s["ZA"] = new List<Subdivision>
        {
            new("ZA-EC", "Eastern Cape", "Province"), new("ZA-FS", "Free State", "Province"),
            new("ZA-GP", "Gauteng", "Province"), new("ZA-KZN", "KwaZulu-Natal", "Province"),
            new("ZA-LP", "Limpopo", "Province"), new("ZA-MP", "Mpumalanga", "Province"),
            new("ZA-NC", "Northern Cape", "Province"), new("ZA-NW", "North West", "Province"),
            new("ZA-WC", "Western Cape", "Province"),
        };

        s["NG"] = new List<Subdivision>
        {
            new("NG-AB", "Abia", "State"), new("NG-AD", "Adamawa", "State"),
            new("NG-AK", "Akwa Ibom", "State"), new("NG-AN", "Anambra", "State"),
            new("NG-FC", "Federal Capital Territory", "Territory"), new("NG-LA", "Lagos", "State"),
            new("NG-KN", "Kano", "State"), new("NG-OG", "Ogun", "State"),
            new("NG-RI", "Rivers", "State"),
        };

        s["EG"] = new List<Subdivision>
        {
            new("EG-C", "Cairo", "Governorate"), new("EG-ALX", "Alexandria", "Governorate"),
            new("EG-GZ", "Giza", "Governorate"), new("EG-SHR", "Sharqia", "Governorate"),
            new("EG-ASN", "Aswan", "Governorate"), new("EG-LX", "Luxor", "Governorate"),
        };

        s["SA"] = new List<Subdivision>
        {
            new("SA-01", "Riyadh", "Region"), new("SA-02", "Makkah", "Region"),
            new("SA-03", "Madinah", "Region"), new("SA-04", "Eastern Province", "Region"),
            new("SA-05", "Al-Qassim", "Region"), new("SA-06", "Ha'il", "Region"),
            new("SA-07", "Tabuk", "Region"), new("SA-08", "Northern Borders", "Region"),
            new("SA-09", "Jazan", "Region"), new("SA-10", "Najran", "Region"),
            new("SA-11", "Al-Bahah", "Region"), new("SA-12", "Al Jawf", "Region"),
            new("SA-14", "Asir", "Region"),
        };

        s["IT"] = new List<Subdivision>
        {
            new("IT-65", "Abruzzo", "Region"), new("IT-77", "Basilicata", "Region"),
            new("IT-78", "Calabria", "Region"), new("IT-72", "Campania", "Region"),
            new("IT-45", "Emilia-Romagna", "Region"), new("IT-36", "Friuli Venezia Giulia", "Region"),
            new("IT-62", "Lazio", "Region"), new("IT-42", "Liguria", "Region"),
            new("IT-25", "Lombardy", "Region"), new("IT-57", "Marche", "Region"),
            new("IT-67", "Molise", "Region"), new("IT-21", "Piedmont", "Region"),
            new("IT-75", "Apulia", "Region"), new("IT-88", "Sardinia", "Region"),
            new("IT-82", "Sicily", "Region"), new("IT-52", "Tuscany", "Region"),
            new("IT-32", "Trentino-South Tyrol", "Region"), new("IT-55", "Umbria", "Region"),
            new("IT-23", "Aosta Valley", "Region"), new("IT-34", "Veneto", "Region"),
        };

        s["ES"] = new List<Subdivision>
        {
            new("ES-AN", "Andalusia", "Community"), new("ES-AR", "Aragon", "Community"),
            new("ES-AS", "Asturias", "Community"), new("ES-IB", "Balearic Islands", "Community"),
            new("ES-PV", "Basque Country", "Community"), new("ES-CN", "Canary Islands", "Community"),
            new("ES-CB", "Cantabria", "Community"), new("ES-CL", "Castile and León", "Community"),
            new("ES-CM", "Castilla-La Mancha", "Community"), new("ES-CT", "Catalonia", "Community"),
            new("ES-EX", "Extremadura", "Community"), new("ES-GA", "Galicia", "Community"),
            new("ES-RI", "La Rioja", "Community"), new("ES-MD", "Madrid", "Community"),
            new("ES-MC", "Murcia", "Community"), new("ES-NC", "Navarre", "Community"),
            new("ES-VC", "Valencia", "Community"),
        };

        s["TR"] = new List<Subdivision>
        {
            new("TR-06", "Ankara", "Province"), new("TR-34", "Istanbul", "Province"),
            new("TR-35", "Izmir", "Province"), new("TR-16", "Bursa", "Province"),
            new("TR-07", "Antalya", "Province"), new("TR-01", "Adana", "Province"),
            new("TR-42", "Konya", "Province"), new("TR-27", "Gaziantep", "Province"),
        };

        s["KR"] = new List<Subdivision>
        {
            new("KR-11", "Seoul", "Special City"), new("KR-26", "Busan", "Metropolitan City"),
            new("KR-28", "Incheon", "Metropolitan City"), new("KR-27", "Daegu", "Metropolitan City"),
            new("KR-29", "Gwangju", "Metropolitan City"), new("KR-30", "Daejeon", "Metropolitan City"),
            new("KR-31", "Ulsan", "Metropolitan City"), new("KR-41", "Gyeonggi", "Province"),
            new("KR-50", "Sejong", "Special Autonomous City"),
        };

        // ---------- Additional Americas ----------

        s["AR"] = new List<Subdivision>
        {
            new("AR-B", "Buenos Aires", "Province"), new("AR-C", "Ciudad Autónoma de Buenos Aires", "Federal District"),
            new("AR-K", "Catamarca", "Province"), new("AR-H", "Chaco", "Province"),
            new("AR-U", "Chubut", "Province"), new("AR-X", "Córdoba", "Province"),
            new("AR-W", "Corrientes", "Province"), new("AR-E", "Entre Ríos", "Province"),
            new("AR-P", "Formosa", "Province"), new("AR-Y", "Jujuy", "Province"),
            new("AR-L", "La Pampa", "Province"), new("AR-F", "La Rioja", "Province"),
            new("AR-M", "Mendoza", "Province"), new("AR-N", "Misiones", "Province"),
            new("AR-Q", "Neuquén", "Province"), new("AR-R", "Río Negro", "Province"),
            new("AR-A", "Salta", "Province"), new("AR-J", "San Juan", "Province"),
            new("AR-D", "San Luis", "Province"), new("AR-Z", "Santa Cruz", "Province"),
            new("AR-S", "Santa Fe", "Province"), new("AR-G", "Santiago del Estero", "Province"),
            new("AR-V", "Tierra del Fuego", "Province"), new("AR-T", "Tucumán", "Province"),
        };

        s["CO"] = new List<Subdivision>
        {
            new("CO-DC", "Bogotá", "Capital District"), new("CO-ANT", "Antioquia", "Department"),
            new("CO-ATL", "Atlántico", "Department"), new("CO-BOL", "Bolívar", "Department"),
            new("CO-BOY", "Boyacá", "Department"), new("CO-CAL", "Caldas", "Department"),
            new("CO-CUN", "Cundinamarca", "Department"), new("CO-HUI", "Huila", "Department"),
            new("CO-MAG", "Magdalena", "Department"), new("CO-NAR", "Nariño", "Department"),
            new("CO-NSA", "Norte de Santander", "Department"), new("CO-SAN", "Santander", "Department"),
            new("CO-TOL", "Tolima", "Department"), new("CO-VAC", "Valle del Cauca", "Department"),
        };

        s["CL"] = new List<Subdivision>
        {
            new("CL-AI", "Aisén", "Region"), new("CL-AN", "Antofagasta", "Region"),
            new("CL-AP", "Arica y Parinacota", "Region"), new("CL-AT", "Atacama", "Region"),
            new("CL-BI", "Biobío", "Region"), new("CL-CO", "Coquimbo", "Region"),
            new("CL-AR", "La Araucanía", "Region"), new("CL-LI", "O'Higgins", "Region"),
            new("CL-LL", "Los Lagos", "Region"), new("CL-LR", "Los Ríos", "Region"),
            new("CL-MA", "Magallanes", "Region"), new("CL-ML", "Maule", "Region"),
            new("CL-NB", "Ñuble", "Region"), new("CL-RM", "Santiago Metropolitan", "Region"),
            new("CL-TA", "Tarapacá", "Region"), new("CL-VS", "Valparaíso", "Region"),
        };

        s["PE"] = new List<Subdivision>
        {
            new("PE-LIM", "Lima", "Region"), new("PE-AMA", "Amazonas", "Region"),
            new("PE-ANC", "Áncash", "Region"), new("PE-APU", "Apurímac", "Region"),
            new("PE-ARE", "Arequipa", "Region"), new("PE-AYA", "Ayacucho", "Region"),
            new("PE-CAJ", "Cajamarca", "Region"), new("PE-CUS", "Cusco", "Region"),
            new("PE-HUV", "Huancavelica", "Region"), new("PE-HUC", "Huánuco", "Region"),
            new("PE-ICA", "Ica", "Region"), new("PE-JUN", "Junín", "Region"),
            new("PE-LAL", "La Libertad", "Region"), new("PE-LAM", "Lambayeque", "Region"),
            new("PE-LOR", "Loreto", "Region"), new("PE-MDD", "Madre de Dios", "Region"),
            new("PE-MOQ", "Moquegua", "Region"), new("PE-PAS", "Pasco", "Region"),
            new("PE-PIU", "Piura", "Region"), new("PE-PUN", "Puno", "Region"),
            new("PE-SAM", "San Martín", "Region"), new("PE-TAC", "Tacna", "Region"),
            new("PE-TUM", "Tumbes", "Region"), new("PE-UCA", "Ucayali", "Region"),
            new("PE-CAL", "Callao", "Constitutional Province"),
        };

        s["VE"] = new List<Subdivision>
        {
            new("VE-W", "Federal Dependencies", "Federal Dependency"), new("VE-A", "Distrito Capital", "Capital District"),
            new("VE-B", "Anzoátegui", "State"), new("VE-C", "Apure", "State"),
            new("VE-D", "Aragua", "State"), new("VE-E", "Barinas", "State"),
            new("VE-F", "Bolívar", "State"), new("VE-G", "Carabobo", "State"),
            new("VE-I", "Falcón", "State"), new("VE-K", "Lara", "State"),
            new("VE-L", "Mérida", "State"), new("VE-M", "Miranda", "State"),
            new("VE-O", "Monagas", "State"), new("VE-T", "Trujillo", "State"),
            new("VE-U", "Yaracuy", "State"), new("VE-V", "Zulia", "State"),
        };

        // ---------- Additional Europe ----------

        s["PL"] = new List<Subdivision>
        {
            new("PL-02", "Dolnośląskie", "Voivodeship"), new("PL-04", "Kujawsko-Pomorskie", "Voivodeship"),
            new("PL-06", "Lubelskie", "Voivodeship"), new("PL-08", "Lubuskie", "Voivodeship"),
            new("PL-10", "Łódzkie", "Voivodeship"), new("PL-12", "Małopolskie", "Voivodeship"),
            new("PL-14", "Mazowieckie", "Voivodeship"), new("PL-16", "Opolskie", "Voivodeship"),
            new("PL-18", "Podkarpackie", "Voivodeship"), new("PL-20", "Podlaskie", "Voivodeship"),
            new("PL-22", "Pomorskie", "Voivodeship"), new("PL-24", "Śląskie", "Voivodeship"),
            new("PL-26", "Świętokrzyskie", "Voivodeship"), new("PL-28", "Warmińsko-Mazurskie", "Voivodeship"),
            new("PL-30", "Wielkopolskie", "Voivodeship"), new("PL-32", "Zachodniopomorskie", "Voivodeship"),
        };

        s["UA"] = new List<Subdivision>
        {
            new("UA-71", "Cherkasy", "Oblast"), new("UA-74", "Chernihiv", "Oblast"),
            new("UA-77", "Chernivtsi", "Oblast"), new("UA-12", "Dnipropetrovsk", "Oblast"),
            new("UA-14", "Donetsk", "Oblast"), new("UA-26", "Ivano-Frankivsk", "Oblast"),
            new("UA-63", "Kharkiv", "Oblast"), new("UA-65", "Kherson", "Oblast"),
            new("UA-68", "Khmelnytskyi", "Oblast"), new("UA-35", "Kirovohrad", "Oblast"),
            new("UA-30", "Kyiv City", "City"), new("UA-32", "Kyiv", "Oblast"),
            new("UA-09", "Luhansk", "Oblast"), new("UA-46", "Lviv", "Oblast"),
            new("UA-48", "Mykolaiv", "Oblast"), new("UA-51", "Odesa", "Oblast"),
            new("UA-53", "Poltava", "Oblast"), new("UA-56", "Rivne", "Oblast"),
            new("UA-59", "Sumy", "Oblast"), new("UA-61", "Ternopil", "Oblast"),
            new("UA-05", "Vinnytsia", "Oblast"), new("UA-07", "Volyn", "Oblast"),
            new("UA-21", "Zakarpattia", "Oblast"), new("UA-23", "Zaporizhzhia", "Oblast"),
            new("UA-18", "Zhytomyr", "Oblast"),
        };

        s["RO"] = new List<Subdivision>
        {
            new("RO-B", "Bucharest", "Municipality"), new("RO-AB", "Alba", "County"),
            new("RO-AR", "Arad", "County"), new("RO-BC", "Bacău", "County"),
            new("RO-BH", "Bihor", "County"), new("RO-BN", "Bistrița-Năsăud", "County"),
            new("RO-BR", "Brăila", "County"), new("RO-BV", "Brașov", "County"),
            new("RO-BZ", "Buzău", "County"), new("RO-CJ", "Cluj", "County"),
            new("RO-CT", "Constanța", "County"), new("RO-CS", "Caraș-Severin", "County"),
            new("RO-CV", "Covasna", "County"), new("RO-DB", "Dâmbovița", "County"),
            new("RO-DJ", "Dolj", "County"), new("RO-GL", "Galați", "County"),
            new("RO-GR", "Giurgiu", "County"), new("RO-GJ", "Gorj", "County"),
            new("RO-HR", "Harghita", "County"), new("RO-HD", "Hunedoara", "County"),
            new("RO-IL", "Ialomița", "County"), new("RO-IS", "Iași", "County"),
            new("RO-IF", "Ilfov", "County"), new("RO-MM", "Maramureș", "County"),
            new("RO-MH", "Mehedinți", "County"), new("RO-MS", "Mureș", "County"),
            new("RO-NT", "Neamț", "County"), new("RO-OT", "Olt", "County"),
            new("RO-PH", "Prahova", "County"), new("RO-SJ", "Sălaj", "County"),
            new("RO-SM", "Satu Mare", "County"), new("RO-SB", "Sibiu", "County"),
            new("RO-SV", "Suceava", "County"), new("RO-TR", "Teleorman", "County"),
            new("RO-TM", "Timiș", "County"), new("RO-TL", "Tulcea", "County"),
            new("RO-VL", "Vâlcea", "County"), new("RO-VN", "Vrancea", "County"),
        };

        s["NL"] = new List<Subdivision>
        {
            new("NL-DR", "Drenthe", "Province"), new("NL-FL", "Flevoland", "Province"),
            new("NL-FR", "Friesland", "Province"), new("NL-GE", "Gelderland", "Province"),
            new("NL-GR", "Groningen", "Province"), new("NL-LI", "Limburg", "Province"),
            new("NL-NB", "North Brabant", "Province"), new("NL-NH", "North Holland", "Province"),
            new("NL-OV", "Overijssel", "Province"), new("NL-UT", "Utrecht", "Province"),
            new("NL-ZE", "Zeeland", "Province"), new("NL-ZH", "South Holland", "Province"),
        };

        s["SE"] = new List<Subdivision>
        {
            new("SE-AB", "Stockholm", "County"), new("SE-AC", "Västerbotten", "County"),
            new("SE-BD", "Norrbotten", "County"), new("SE-C", "Uppsala", "County"),
            new("SE-D", "Södermanland", "County"), new("SE-E", "Östergötland", "County"),
            new("SE-F", "Jönköping", "County"), new("SE-G", "Kronoberg", "County"),
            new("SE-H", "Kalmar", "County"), new("SE-I", "Gotland", "County"),
            new("SE-K", "Blekinge", "County"), new("SE-M", "Skåne", "County"),
            new("SE-N", "Halland", "County"), new("SE-O", "Västra Götaland", "County"),
            new("SE-S", "Värmland", "County"), new("SE-T", "Örebro", "County"),
            new("SE-U", "Västmanland", "County"), new("SE-W", "Dalarna", "County"),
            new("SE-X", "Gävleborg", "County"), new("SE-Y", "Västernorrland", "County"),
            new("SE-Z", "Jämtland", "County"),
        };

        s["NO"] = new List<Subdivision>
        {
            new("NO-03", "Oslo", "County"), new("NO-11", "Rogaland", "County"),
            new("NO-15", "Møre og Romsdal", "County"), new("NO-18", "Nordland", "County"),
            new("NO-30", "Viken", "County"), new("NO-34", "Innlandet", "County"),
            new("NO-38", "Vestfold og Telemark", "County"), new("NO-42", "Agder", "County"),
            new("NO-46", "Vestland", "County"), new("NO-50", "Trøndelag", "County"),
            new("NO-54", "Troms og Finnmark", "County"),
        };

        s["DK"] = new List<Subdivision>
        {
            new("DK-81", "Nordjylland", "Region"), new("DK-82", "Midtjylland", "Region"),
            new("DK-83", "Syddanmark", "Region"), new("DK-84", "Hovedstaden", "Region"),
            new("DK-85", "Sjælland", "Region"),
        };

        s["FI"] = new List<Subdivision>
        {
            new("FI-01", "Åland", "Region"), new("FI-02", "South Karelia", "Region"),
            new("FI-03", "Southern Ostrobothnia", "Region"), new("FI-04", "Southern Savonia", "Region"),
            new("FI-05", "Kainuu", "Region"), new("FI-06", "Tavastia Proper", "Region"),
            new("FI-07", "Central Ostrobothnia", "Region"), new("FI-08", "Central Finland", "Region"),
            new("FI-09", "Kymenlaakso", "Region"), new("FI-10", "Lapland", "Region"),
            new("FI-11", "Pirkanmaa", "Region"), new("FI-12", "Ostrobothnia", "Region"),
            new("FI-13", "North Karelia", "Region"), new("FI-14", "Northern Ostrobothnia", "Region"),
            new("FI-15", "Northern Savonia", "Region"), new("FI-16", "Päijänne Tavastia", "Region"),
            new("FI-17", "Satakunta", "Region"), new("FI-18", "Uusimaa", "Region"),
            new("FI-19", "Southwest Finland", "Region"),
        };

        s["CZ"] = new List<Subdivision>
        {
            new("CZ-10", "Prague", "Capital City"), new("CZ-20", "Central Bohemian", "Region"),
            new("CZ-31", "South Bohemian", "Region"), new("CZ-32", "Plzeň", "Region"),
            new("CZ-41", "Karlovy Vary", "Region"), new("CZ-42", "Ústí nad Labem", "Region"),
            new("CZ-51", "Liberec", "Region"), new("CZ-52", "Hradec Králové", "Region"),
            new("CZ-53", "Pardubice", "Region"), new("CZ-63", "Vysočina", "Region"),
            new("CZ-64", "South Moravian", "Region"), new("CZ-71", "Olomouc", "Region"),
            new("CZ-72", "Zlín", "Region"), new("CZ-80", "Moravian-Silesian", "Region"),
        };

        s["HU"] = new List<Subdivision>
        {
            new("HU-BU", "Budapest", "Capital City"), new("HU-BK", "Bács-Kiskun", "County"),
            new("HU-BA", "Baranya", "County"), new("HU-BE", "Békés", "County"),
            new("HU-BZ", "Borsod-Abaúj-Zemplén", "County"), new("HU-CS", "Csongrád-Csanád", "County"),
            new("HU-FE", "Fejér", "County"), new("HU-GS", "Győr-Moson-Sopron", "County"),
            new("HU-HB", "Hajdú-Bihar", "County"), new("HU-HE", "Heves", "County"),
            new("HU-JN", "Jász-Nagykun-Szolnok", "County"), new("HU-KE", "Komárom-Esztergom", "County"),
            new("HU-NO", "Nógrád", "County"), new("HU-PE", "Pest", "County"),
            new("HU-SO", "Somogy", "County"), new("HU-SZ", "Szabolcs-Szatmár-Bereg", "County"),
            new("HU-TO", "Tolna", "County"), new("HU-VA", "Vas", "County"),
            new("HU-VE", "Veszprém", "County"), new("HU-ZA", "Zala", "County"),
        };

        s["GR"] = new List<Subdivision>
        {
            new("GR-A", "Eastern Macedonia and Thrace", "Region"), new("GR-B", "Central Macedonia", "Region"),
            new("GR-C", "Western Macedonia", "Region"), new("GR-D", "Epirus", "Region"),
            new("GR-E", "Thessaly", "Region"), new("GR-F", "Ionian Islands", "Region"),
            new("GR-G", "Western Greece", "Region"), new("GR-H", "Central Greece", "Region"),
            new("GR-I", "Attica", "Region"), new("GR-J", "Peloponnese", "Region"),
            new("GR-K", "North Aegean", "Region"), new("GR-L", "South Aegean", "Region"),
            new("GR-M", "Crete", "Region"), new("GR-69", "Mount Athos", "Autonomous State"),
        };

        s["PT"] = new List<Subdivision>
        {
            new("PT-01", "Aveiro", "District"), new("PT-02", "Beja", "District"),
            new("PT-03", "Braga", "District"), new("PT-04", "Bragança", "District"),
            new("PT-05", "Castelo Branco", "District"), new("PT-06", "Coimbra", "District"),
            new("PT-07", "Évora", "District"), new("PT-08", "Faro", "District"),
            new("PT-09", "Guarda", "District"), new("PT-10", "Leiria", "District"),
            new("PT-11", "Lisbon", "District"), new("PT-12", "Portalegre", "District"),
            new("PT-13", "Porto", "District"), new("PT-14", "Santarém", "District"),
            new("PT-15", "Setúbal", "District"), new("PT-16", "Viana do Castelo", "District"),
            new("PT-17", "Vila Real", "District"), new("PT-18", "Viseu", "District"),
            new("PT-20", "Azores", "Autonomous Region"), new("PT-30", "Madeira", "Autonomous Region"),
        };

        s["AT"] = new List<Subdivision>
        {
            new("AT-1", "Burgenland", "State"), new("AT-2", "Carinthia", "State"),
            new("AT-3", "Lower Austria", "State"), new("AT-4", "Upper Austria", "State"),
            new("AT-5", "Salzburg", "State"), new("AT-6", "Styria", "State"),
            new("AT-7", "Tyrol", "State"), new("AT-8", "Vorarlberg", "State"),
            new("AT-9", "Vienna", "State"),
        };

        s["BE"] = new List<Subdivision>
        {
            new("BE-BRU", "Brussels-Capital Region", "Region"), new("BE-VLG", "Flemish Region", "Region"),
            new("BE-WAL", "Walloon Region", "Region"),
        };

        s["CH"] = new List<Subdivision>
        {
            new("CH-AG", "Aargau", "Canton"), new("CH-AI", "Appenzell Innerrhoden", "Canton"),
            new("CH-AR", "Appenzell Ausserrhoden", "Canton"), new("CH-BE", "Bern", "Canton"),
            new("CH-BL", "Basel-Landschaft", "Canton"), new("CH-BS", "Basel-Stadt", "Canton"),
            new("CH-FR", "Fribourg", "Canton"), new("CH-GE", "Geneva", "Canton"),
            new("CH-GL", "Glarus", "Canton"), new("CH-GR", "Graubünden", "Canton"),
            new("CH-JU", "Jura", "Canton"), new("CH-LU", "Lucerne", "Canton"),
            new("CH-NE", "Neuchâtel", "Canton"), new("CH-NW", "Nidwalden", "Canton"),
            new("CH-OW", "Obwalden", "Canton"), new("CH-SG", "St. Gallen", "Canton"),
            new("CH-SH", "Schaffhausen", "Canton"), new("CH-SO", "Solothurn", "Canton"),
            new("CH-SZ", "Schwyz", "Canton"), new("CH-TG", "Thurgau", "Canton"),
            new("CH-TI", "Ticino", "Canton"), new("CH-UR", "Uri", "Canton"),
            new("CH-VD", "Vaud", "Canton"), new("CH-VS", "Valais", "Canton"),
            new("CH-ZG", "Zug", "Canton"), new("CH-ZH", "Zurich", "Canton"),
        };

        s["IE"] = new List<Subdivision>
        {
            new("IE-C", "Connacht", "Province"), new("IE-L", "Leinster", "Province"),
            new("IE-M", "Munster", "Province"), new("IE-U", "Ulster", "Province"),
        };

        // ---------- Additional Asia ----------

        s["ID"] = new List<Subdivision>
        {
            new("ID-AC", "Aceh", "Province"), new("ID-BA", "Bali", "Province"),
            new("ID-BB", "Bangka Belitung Islands", "Province"), new("ID-BT", "Banten", "Province"),
            new("ID-BE", "Bengkulu", "Province"), new("ID-JK", "Jakarta", "Special Capital Region"),
            new("ID-JB", "West Java", "Province"), new("ID-JT", "Central Java", "Province"),
            new("ID-JI", "East Java", "Province"), new("ID-YO", "Yogyakarta", "Special Region"),
            new("ID-KB", "West Kalimantan", "Province"), new("ID-KT", "Central Kalimantan", "Province"),
            new("ID-KS", "South Kalimantan", "Province"), new("ID-KI", "East Kalimantan", "Province"),
            new("ID-KU", "North Kalimantan", "Province"), new("ID-LA", "Lampung", "Province"),
            new("ID-MA", "Maluku", "Province"), new("ID-MU", "North Maluku", "Province"),
            new("ID-NB", "West Nusa Tenggara", "Province"), new("ID-NT", "East Nusa Tenggara", "Province"),
            new("ID-PA", "Papua", "Province"), new("ID-PB", "West Papua", "Province"),
            new("ID-RI", "Riau", "Province"), new("ID-KR", "Riau Islands", "Province"),
            new("ID-SU", "North Sumatra", "Province"), new("ID-SB", "West Sumatra", "Province"),
            new("ID-SS", "South Sumatra", "Province"), new("ID-SG", "Southeast Sulawesi", "Province"),
            new("ID-SA", "North Sulawesi", "Province"), new("ID-ST", "Central Sulawesi", "Province"),
            new("ID-SN", "South Sulawesi", "Province"), new("ID-SR", "West Sulawesi", "Province"),
            new("ID-GO", "Gorontalo", "Province"), new("ID-JA", "Jambi", "Province"),
        };

        s["PH"] = new List<Subdivision>
        {
            new("PH-00", "National Capital Region", "Region"), new("PH-01", "Ilocos Region", "Region"),
            new("PH-02", "Cagayan Valley", "Region"), new("PH-03", "Central Luzon", "Region"),
            new("PH-05", "Bicol Region", "Region"), new("PH-06", "Western Visayas", "Region"),
            new("PH-07", "Central Visayas", "Region"), new("PH-08", "Eastern Visayas", "Region"),
            new("PH-09", "Zamboanga Peninsula", "Region"), new("PH-10", "Northern Mindanao", "Region"),
            new("PH-11", "Davao Region", "Region"), new("PH-12", "SOCCSKSARGEN", "Region"),
            new("PH-13", "Caraga", "Region"), new("PH-14", "BARMM", "Autonomous Region"),
            new("PH-15", "Cordillera", "Administrative Region"), new("PH-40", "CALABARZON", "Region"),
            new("PH-41", "MIMAROPA", "Region"),
        };

        s["TH"] = new List<Subdivision>
        {
            new("TH-10", "Bangkok", "Special Administrative Area"),
            new("TH-11", "Samut Prakan", "Province"), new("TH-12", "Nonthaburi", "Province"),
            new("TH-13", "Pathum Thani", "Province"), new("TH-14", "Phra Nakhon Si Ayutthaya", "Province"),
            new("TH-20", "Chon Buri", "Province"), new("TH-50", "Chiang Mai", "Province"),
            new("TH-83", "Phuket", "Province"), new("TH-96", "Narathiwat", "Province"),
        };

        s["MY"] = new List<Subdivision>
        {
            new("MY-01", "Johor", "State"), new("MY-02", "Kedah", "State"),
            new("MY-03", "Kelantan", "State"), new("MY-04", "Malacca", "State"),
            new("MY-05", "Negeri Sembilan", "State"), new("MY-06", "Pahang", "State"),
            new("MY-07", "Penang", "State"), new("MY-08", "Perak", "State"),
            new("MY-09", "Perlis", "State"), new("MY-10", "Selangor", "State"),
            new("MY-11", "Terengganu", "State"), new("MY-12", "Sabah", "State"),
            new("MY-13", "Sarawak", "State"), new("MY-14", "Kuala Lumpur", "Federal Territory"),
            new("MY-15", "Labuan", "Federal Territory"), new("MY-16", "Putrajaya", "Federal Territory"),
        };

        s["VN"] = new List<Subdivision>
        {
            new("VN-HN", "Hanoi", "Municipality"), new("VN-SG", "Ho Chi Minh City", "Municipality"),
            new("VN-HP", "Hai Phong", "Municipality"), new("VN-DN", "Da Nang", "Municipality"),
            new("VN-CT", "Can Tho", "Municipality"),
        };

        s["BD"] = new List<Subdivision>
        {
            new("BD-A", "Barishal", "Division"), new("BD-B", "Chattogram", "Division"),
            new("BD-C", "Dhaka", "Division"), new("BD-D", "Khulna", "Division"),
            new("BD-E", "Rajshahi", "Division"), new("BD-F", "Rangpur", "Division"),
            new("BD-G", "Sylhet", "Division"), new("BD-H", "Mymensingh", "Division"),
        };

        s["IR"] = new List<Subdivision>
        {
            new("IR-01", "East Azerbaijan", "Province"), new("IR-02", "West Azerbaijan", "Province"),
            new("IR-03", "Ardabil", "Province"), new("IR-04", "Isfahan", "Province"),
            new("IR-05", "Ilam", "Province"), new("IR-06", "Bushehr", "Province"),
            new("IR-07", "Tehran", "Province"), new("IR-08", "Chaharmahal and Bakhtiari", "Province"),
            new("IR-10", "Khuzestan", "Province"), new("IR-11", "Zanjan", "Province"),
            new("IR-12", "Semnan", "Province"), new("IR-13", "Sistan and Baluchestan", "Province"),
            new("IR-14", "Fars", "Province"), new("IR-15", "Kerman", "Province"),
            new("IR-16", "Kurdistan", "Province"), new("IR-17", "Kermanshah", "Province"),
            new("IR-18", "Kohgiluyeh and Boyer-Ahmad", "Province"),
            new("IR-19", "Gilan", "Province"), new("IR-20", "Lorestan", "Province"),
            new("IR-21", "Mazandaran", "Province"), new("IR-22", "Markazi", "Province"),
            new("IR-23", "Hormozgan", "Province"), new("IR-24", "Hamadan", "Province"),
            new("IR-25", "Yazd", "Province"), new("IR-26", "Qom", "Province"),
            new("IR-27", "Golestan", "Province"), new("IR-28", "Qazvin", "Province"),
            new("IR-29", "South Khorasan", "Province"), new("IR-30", "Razavi Khorasan", "Province"),
            new("IR-31", "North Khorasan", "Province"), new("IR-32", "Alborz", "Province"),
        };

        s["IQ"] = new List<Subdivision>
        {
            new("IQ-AN", "Al Anbar", "Governorate"), new("IQ-BA", "Basra", "Governorate"),
            new("IQ-BB", "Babil", "Governorate"), new("IQ-BG", "Baghdad", "Governorate"),
            new("IQ-DA", "Dohuk", "Governorate"), new("IQ-DI", "Diyala", "Governorate"),
            new("IQ-DQ", "Dhi Qar", "Governorate"), new("IQ-AR", "Erbil", "Governorate"),
            new("IQ-KA", "Karbala", "Governorate"), new("IQ-KI", "Kirkuk", "Governorate"),
            new("IQ-MA", "Maysan", "Governorate"), new("IQ-MU", "Muthanna", "Governorate"),
            new("IQ-NA", "Najaf", "Governorate"), new("IQ-NI", "Nineveh", "Governorate"),
            new("IQ-QA", "Al-Qadisiyyah", "Governorate"), new("IQ-SD", "Saladin", "Governorate"),
            new("IQ-SU", "Sulaymaniyah", "Governorate"), new("IQ-WA", "Wasit", "Governorate"),
        };

        s["AE"] = new List<Subdivision>
        {
            new("AE-AZ", "Abu Dhabi", "Emirate"), new("AE-AJ", "Ajman", "Emirate"),
            new("AE-DU", "Dubai", "Emirate"), new("AE-FU", "Fujairah", "Emirate"),
            new("AE-RK", "Ras al-Khaimah", "Emirate"), new("AE-SH", "Sharjah", "Emirate"),
            new("AE-UQ", "Umm al-Quwain", "Emirate"),
        };

        // ---------- Additional Africa ----------

        s["KE"] = new List<Subdivision>
        {
            new("KE-01", "Baringo", "County"), new("KE-02", "Bomet", "County"),
            new("KE-03", "Bungoma", "County"), new("KE-04", "Busia", "County"),
            new("KE-30", "Nairobi", "County"), new("KE-32", "Nakuru", "County"),
            new("KE-34", "Nyandarua", "County"), new("KE-36", "Nyeri", "County"),
            new("KE-22", "Kiambu", "County"), new("KE-28", "Mombasa", "County"),
        };

        s["ET"] = new List<Subdivision>
        {
            new("ET-AA", "Addis Ababa", "City Administration"),
            new("ET-AF", "Afar", "Region"), new("ET-AM", "Amhara", "Region"),
            new("ET-BE", "Benishangul-Gumuz", "Region"), new("ET-DD", "Dire Dawa", "City Administration"),
            new("ET-GA", "Gambela", "Region"), new("ET-HA", "Harari", "Region"),
            new("ET-OR", "Oromia", "Region"), new("ET-SN", "Southern Nations", "Region"),
            new("ET-SO", "Somali", "Region"), new("ET-TI", "Tigray", "Region"),
            new("ET-SI", "Sidama", "Region"),
        };

        s["GH"] = new List<Subdivision>
        {
            new("GH-AA", "Greater Accra", "Region"), new("GH-AH", "Ashanti", "Region"),
            new("GH-BA", "Brong-Ahafo", "Region"), new("GH-CP", "Central", "Region"),
            new("GH-EP", "Eastern", "Region"), new("GH-NP", "Northern", "Region"),
            new("GH-UE", "Upper East", "Region"), new("GH-UW", "Upper West", "Region"),
            new("GH-TV", "Volta", "Region"), new("GH-WP", "Western", "Region"),
        };

        s["TZ"] = new List<Subdivision>
        {
            new("TZ-01", "Arusha", "Region"), new("TZ-02", "Dar es Salaam", "Region"),
            new("TZ-03", "Dodoma", "Region"), new("TZ-04", "Iringa", "Region"),
            new("TZ-05", "Kagera", "Region"), new("TZ-06", "Pemba North", "Region"),
            new("TZ-07", "Zanzibar North", "Region"), new("TZ-08", "Kigoma", "Region"),
            new("TZ-09", "Kilimanjaro", "Region"), new("TZ-12", "Lindi", "Region"),
            new("TZ-13", "Mara", "Region"), new("TZ-14", "Mbeya", "Region"),
            new("TZ-16", "Morogoro", "Region"), new("TZ-17", "Mtwara", "Region"),
            new("TZ-18", "Mwanza", "Region"), new("TZ-26", "Manyara", "Region"),
        };

        s["MA"] = new List<Subdivision>
        {
            new("MA-01", "Tanger-Tétouan-Al Hoceïma", "Region"), new("MA-02", "L'Oriental", "Region"),
            new("MA-03", "Fès-Meknès", "Region"), new("MA-04", "Rabat-Salé-Kénitra", "Region"),
            new("MA-05", "Béni Mellal-Khénifra", "Region"), new("MA-06", "Casablanca-Settat", "Region"),
            new("MA-07", "Marrakech-Safi", "Region"), new("MA-08", "Drâa-Tafilalet", "Region"),
            new("MA-09", "Souss-Massa", "Region"), new("MA-10", "Guelmim-Oued Noun", "Region"),
            new("MA-11", "Laâyoune-Sakia El Hamra", "Region"), new("MA-12", "Dakhla-Oued Ed-Dahab", "Region"),
        };

        s["DZ"] = new List<Subdivision>
        {
            new("DZ-01", "Adrar", "Province"), new("DZ-02", "Chlef", "Province"),
            new("DZ-03", "Laghouat", "Province"), new("DZ-04", "Oum El Bouaghi", "Province"),
            new("DZ-06", "Béjaïa", "Province"), new("DZ-09", "Blida", "Province"),
            new("DZ-16", "Algiers", "Province"), new("DZ-19", "Sétif", "Province"),
            new("DZ-25", "Constantine", "Province"), new("DZ-31", "Oran", "Province"),
        };

        // ---------- Oceania ----------

        s["NZ"] = new List<Subdivision>
        {
            new("NZ-AUK", "Auckland", "Region"), new("NZ-BOP", "Bay of Plenty", "Region"),
            new("NZ-CAN", "Canterbury", "Region"), new("NZ-GIS", "Gisborne", "Region"),
            new("NZ-HKB", "Hawke's Bay", "Region"), new("NZ-MBH", "Marlborough", "Region"),
            new("NZ-MWT", "Manawatū-Whanganui", "Region"), new("NZ-NSN", "Nelson", "Region"),
            new("NZ-NTL", "Northland", "Region"), new("NZ-OTA", "Otago", "Region"),
            new("NZ-STL", "Southland", "Region"), new("NZ-TAS", "Tasman", "Region"),
            new("NZ-TKI", "Taranaki", "Region"), new("NZ-WGN", "Wellington", "Region"),
            new("NZ-WKO", "Waikato", "Region"), new("NZ-WTC", "West Coast", "Region"),
        };

        s["FJ"] = new List<Subdivision>
        {
            new("FJ-C", "Central", "Division"), new("FJ-E", "Eastern", "Division"),
            new("FJ-N", "Northern", "Division"), new("FJ-W", "Western", "Division"),
        };

        return s;
    }
}
