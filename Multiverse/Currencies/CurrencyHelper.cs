using System.Collections.Generic;

namespace Multiverse.Globalization.Currencies;

internal static class CurrencyHelper
{
    public static readonly Currency None = new Currency(0, string.Empty, string.Empty, string.Empty);
    public static readonly Currency Afghani = new Currency(971, "Afghani", "AFN", "؋");
    public static readonly Currency Euro = new Currency(978, "Euro", "EUR", "€");
    public static readonly Currency UsDollar = new Currency(840, "US Dollar", "USD", "$");
    public static readonly Currency PoundSterling = new Currency(826, "Pound Sterling", "GBP", "£");
    public static readonly Currency Yen = new Currency(392, "Yen", "JPY", "¥");
    public static readonly Currency YuanRenminbi = new Currency(156, "Yuan Renminbi", "CNY", "¥");
    public static readonly Currency IndianRupee = new Currency(356, "Indian Rupee", "INR", "₹");
    public static readonly Currency AustralianDollar = new Currency(036, "Australian Dollar", "AUD", "$");
    public static readonly Currency CanadianDollar = new Currency(124, "Canadian Dollar", "CAD", "$");
    public static readonly Currency SwissFranc = new Currency(756, "Swiss Franc", "CHF", "CHF");
    public static readonly Currency SwedishKrona = new Currency(752, "Swedish Krona", "SEK", "kr");
    public static readonly Currency NorwegianKrone = new Currency(578, "Norwegian Krone", "NOK", "kr");
    public static readonly Currency DanishKrone = new Currency(208, "Danish Krone", "DKK", "kr");
    public static readonly Currency NewZealandDollar = new Currency(554, "New Zealand Dollar", "NZD", "$");
    public static readonly Currency Rand = new Currency(710, "Rand", "ZAR", "R");
    public static readonly Currency BrazilianReal = new Currency(986, "Brazilian Real", "BRL", "R$");
    public static readonly Currency RussianRuble = new Currency(643, "Russian Ruble", "RUB", "₽");
    public static readonly Currency MexicanPeso = new Currency(484, "Mexican Peso", "MXN", "$");
    public static readonly Currency SingaporeDollar = new Currency(702, "Singapore Dollar", "SGD", "$");
    public static readonly Currency HongKongDollar = new Currency(344, "Hong Kong Dollar", "HKD", "$");
    public static readonly Currency Won = new Currency(410, "Won", "KRW", "₩");
    public static readonly Currency TurkishLira = new Currency(949, "Turkish Lira", "TRY", "₺");
    public static readonly Currency SaudiRiyal = new Currency(682, "Saudi Riyal", "SAR", "﷼");
    public static readonly Currency UaeDirham = new Currency(784, "UAE Dirham", "AED", "د.إ");
    public static readonly Currency Baht = new Currency(764, "Baht", "THB", "฿");
    public static readonly Currency MalaysianRinggit = new Currency(458, "Malaysian Ringgit", "MYR", "RM");
    public static readonly Currency Rupiah = new Currency(360, "Rupiah", "IDR", "Rp");
    public static readonly Currency PhilippinePeso = new Currency(608, "Philippine Peso", "PHP", "₱");
    public static readonly Currency Dong = new Currency(704, "Dong", "VND", "₫");
    public static readonly Currency PakistanRupee = new Currency(586, "Pakistan Rupee", "PKR", "₨");
    public static readonly Currency Taka = new Currency(050, "Taka", "BDT", "৳");
    public static readonly Currency SriLankaRupee = new Currency(144, "Sri Lanka Rupee", "LKR", "Rs");
    public static readonly Currency NepaleseRupee = new Currency(524, "Nepalese Rupee", "NPR", "Rs");
    public static readonly Currency IraqiDinar = new Currency(368, "Iraqi Dinar", "IQD", "ع.د");
    public static readonly Currency IranianRial = new Currency(364, "Iranian Rial", "IRR", "﷼");
    public static readonly Currency EgyptianPound = new Currency(818, "Egyptian Pound", "EGP", "£");
    public static readonly Currency Naira = new Currency(566, "Naira", "NGN", "₦");
    public static readonly Currency KenyanShilling = new Currency(404, "Kenyan Shilling", "KES", "KSh");
    public static readonly Currency GhanaCedi = new Currency(936, "Ghana Cedi", "GHS", "₵");
    public static readonly Currency CfaFrancBceao = new Currency(952, "CFA Franc BCEAO", "XOF", "CFA");
    public static readonly Currency CfaFrancBeac = new Currency(950, "CFA Franc BEAC", "XAF", "CFA");
    public static readonly Currency ArgentinePeso = new Currency(032, "Argentine Peso", "ARS", "$");
    public static readonly Currency ChileanPeso = new Currency(152, "Chilean Peso", "CLP", "$");
    public static readonly Currency ColombianPeso = new Currency(170, "Colombian Peso", "COP", "$");
    public static readonly Currency Sol = new Currency(604, "Sol", "PEN", "S/");
    public static readonly Currency Hryvnia = new Currency(980, "Hryvnia", "UAH", "₴");
    public static readonly Currency Zloty = new Currency(985, "Zloty", "PLN", "zł");
    public static readonly Currency CzechKoruna = new Currency(203, "Czech Koruna", "CZK", "Kč");
    public static readonly Currency Forint = new Currency(348, "Forint", "HUF", "Ft");
    public static readonly Currency RomanianLeu = new Currency(946, "Romanian Leu", "RON", "lei");
    public static readonly Currency NewIsraeliSheqel = new Currency(376, "New Israeli Sheqel", "ILS", "₪");
    public static readonly Currency QatariRial = new Currency(634, "Qatari Rial", "QAR", "﷼");
    public static readonly Currency KuwaitiDinar = new Currency(414, "Kuwaiti Dinar", "KWD", "د.ك");
    public static readonly Currency RialOmani = new Currency(512, "Rial Omani", "OMR", "﷼");
    public static readonly Currency BahrainiDinar = new Currency(048, "Bahraini Dinar", "BHD", "ب.د");
    public static readonly Currency IcelandKrona = new Currency(352, "Iceland Krona", "ISK", "kr");
    public static readonly Currency CostaRicanColon = new Currency(188, "Costa Rican Colon", "CRC", "₡");
    public static readonly Currency DominicanPeso = new Currency(214, "Dominican Peso", "DOP", "RD$");
    public static readonly Currency Quetzal = new Currency(320, "Quetzal", "GTQ", "Q");
    public static readonly Currency Lempira = new Currency(340, "Lempira", "HNL", "L");
    public static readonly Currency Balboa = new Currency(590, "Balboa", "PAB", "B/.");
    public static readonly Currency PesoUruguayo = new Currency(858, "Peso Uruguayo", "UYU", "$U");
    public static readonly Currency Boliviano = new Currency(068, "Boliviano", "BOB", "Bs.");
    public static readonly Currency Guarani = new Currency(600, "Guarani", "PYG", "₲");
    public static readonly Currency UzbekistanSum = new Currency(860, "Uzbekistan Sum", "UZS", "лв");
    public static readonly Currency Tenge = new Currency(398, "Tenge", "KZT", "₸");
    public static readonly Currency Somoni = new Currency(972, "Somoni", "TJS", "ЅМ");
    public static readonly Currency Som = new Currency(417, "Som", "KGS", "лв");
    public static readonly Currency TurkmenistanNewManat = new Currency(934, "Turkmenistan New Manat", "TMT", "m");
    public static readonly Currency AzerbaijanManat = new Currency(944, "Azerbaijan Manat", "AZN", "₼");
    public static readonly Currency Lari = new Currency(981, "Lari", "GEL", "₾");
    public static readonly Currency ArmenianDram = new Currency(051, "Armenian Dram", "AMD", "֏");
    public static readonly Currency BelarusianRuble = new Currency(933, "Belarusian Ruble", "BYN", "Br");
    public static readonly Currency TunisianDinar = new Currency(788, "Tunisian Dinar", "TND", "د.ت");
    public static readonly Currency MoroccanDirham = new Currency(504, "Moroccan Dirham", "MAD", "د.م.");
    public static readonly Currency CfpFranc = new Currency(953, "CFP Franc", "XPF", "₣");
    public static readonly Currency EastCaribbeanDollar = new Currency(951, "East Caribbean Dollar", "XCD", "$");
    public static readonly Currency Sdr = new Currency(960, "SDR (Special Drawing Right)", "XDR", "XDR");

    public static List<Currency> GetAll()
    {
        return new List<Currency>
        {
            Afghani,
            Euro,
            UsDollar,
            PoundSterling,
            Yen,
            YuanRenminbi,
            IndianRupee,
            AustralianDollar,
            CanadianDollar,
            SwissFranc,
            SwedishKrona,
            NorwegianKrone,
            DanishKrone,
            NewZealandDollar,
            Rand,
            BrazilianReal,
            RussianRuble,
            MexicanPeso,
            SingaporeDollar,
            HongKongDollar,
            Won,
            TurkishLira,
            SaudiRiyal,
            UaeDirham,
            Baht,
            MalaysianRinggit,
            Rupiah,
            PhilippinePeso,
            Dong,
            PakistanRupee,
            Taka,
            SriLankaRupee,
            NepaleseRupee,
            IraqiDinar,
            IranianRial,
            EgyptianPound,
            Naira,
            KenyanShilling,
            GhanaCedi,
            CfaFrancBceao,
            CfaFrancBeac,
            ArgentinePeso,
            ChileanPeso,
            ColombianPeso,
            Sol,
            Hryvnia,
            Zloty,
            CzechKoruna,
            Forint,
            RomanianLeu,
            NewIsraeliSheqel,
            QatariRial,
            KuwaitiDinar,
            RialOmani,
            BahrainiDinar,
            IcelandKrona,
            CostaRicanColon,
            DominicanPeso,
            Quetzal,
            Lempira,
            Balboa,
            PesoUruguayo,
            Boliviano,
            Guarani,
            UzbekistanSum,
            Tenge,
            Somoni,
            Som,
            TurkmenistanNewManat,
            AzerbaijanManat,
            Lari,
            ArmenianDram,
            BelarusianRuble,
            TunisianDinar,
            MoroccanDirham,
            CfpFranc,
            EastCaribbeanDollar,
            Sdr
        };
    }

    public static readonly IReadOnlyDictionary<string, Currency> CodeMap = new Dictionary<string, Currency>
    {
        { None.Code, None },
        { Afghani.Code, Afghani },
        { Euro.Code, Euro },
        { UsDollar.Code, UsDollar },
        { PoundSterling.Code, PoundSterling },
        { Yen.Code, Yen },
        { YuanRenminbi.Code, YuanRenminbi },
        { IndianRupee.Code, IndianRupee },
        { AustralianDollar.Code, AustralianDollar },
        { CanadianDollar.Code, CanadianDollar },
        { SwissFranc.Code, SwissFranc },
        { SwedishKrona.Code, SwedishKrona },
        { NorwegianKrone.Code, NorwegianKrone },
        { DanishKrone.Code, DanishKrone },
        { NewZealandDollar.Code, NewZealandDollar },
        { Rand.Code, Rand },
        { BrazilianReal.Code, BrazilianReal },
        { RussianRuble.Code, RussianRuble },
        { MexicanPeso.Code, MexicanPeso },
        { SingaporeDollar.Code, SingaporeDollar },
        { HongKongDollar.Code, HongKongDollar },
        { Won.Code, Won },
        { TurkishLira.Code, TurkishLira },
        { SaudiRiyal.Code, SaudiRiyal },
        { UaeDirham.Code, UaeDirham },
        { Baht.Code, Baht },
        { MalaysianRinggit.Code, MalaysianRinggit },
        { Rupiah.Code, Rupiah },
        { PhilippinePeso.Code, PhilippinePeso },
        { Dong.Code, Dong },
        { PakistanRupee.Code, PakistanRupee },
        { Taka.Code, Taka },
        { SriLankaRupee.Code, SriLankaRupee },
        { NepaleseRupee.Code, NepaleseRupee },
        { IraqiDinar.Code, IraqiDinar },
        { IranianRial.Code, IranianRial },
        { EgyptianPound.Code, EgyptianPound },
        { Naira.Code, Naira },
        { KenyanShilling.Code, KenyanShilling },
        { GhanaCedi.Code, GhanaCedi },
        { CfaFrancBceao.Code, CfaFrancBceao },
        { CfaFrancBeac.Code, CfaFrancBeac },
        { ArgentinePeso.Code, ArgentinePeso },
        { ChileanPeso.Code, ChileanPeso },
        { ColombianPeso.Code, ColombianPeso },
        { Sol.Code, Sol },
        { Hryvnia.Code, Hryvnia },
        { Zloty.Code, Zloty },
        { CzechKoruna.Code, CzechKoruna },
        { Forint.Code, Forint },
        { RomanianLeu.Code, RomanianLeu },
        { NewIsraeliSheqel.Code, NewIsraeliSheqel },
        { QatariRial.Code, QatariRial },
        { KuwaitiDinar.Code, KuwaitiDinar },
        { RialOmani.Code, RialOmani },
        { BahrainiDinar.Code, BahrainiDinar },
        { IcelandKrona.Code, IcelandKrona },
        { CostaRicanColon.Code, CostaRicanColon },
        { DominicanPeso.Code, DominicanPeso },
        { Quetzal.Code, Quetzal },
        { Lempira.Code, Lempira },
        { Balboa.Code, Balboa },
        { PesoUruguayo.Code, PesoUruguayo },
        { Boliviano.Code, Boliviano },
        { Guarani.Code, Guarani },
        { UzbekistanSum.Code, UzbekistanSum },
        { Tenge.Code, Tenge },
        { Somoni.Code, Somoni },
        { Som.Code, Som },
        { TurkmenistanNewManat.Code, TurkmenistanNewManat },
        { AzerbaijanManat.Code, AzerbaijanManat },
        { Lari.Code, Lari },
        { ArmenianDram.Code, ArmenianDram },
        { BelarusianRuble.Code, BelarusianRuble },
        { TunisianDinar.Code, TunisianDinar },
        { MoroccanDirham.Code, MoroccanDirham },
        { CfpFranc.Code, CfpFranc },
        { EastCaribbeanDollar.Code, EastCaribbeanDollar },
        { Sdr.Code, Sdr }
    };

    public static readonly IReadOnlyDictionary<int, Currency> NumberMap = new Dictionary<int, Currency>
    {
        { None.Number, None },
        { Afghani.Number, Afghani },
        { Euro.Number, Euro },
        { UsDollar.Number, UsDollar },
        { PoundSterling.Number, PoundSterling },
        { Yen.Number, Yen },
        { YuanRenminbi.Number, YuanRenminbi },
        { IndianRupee.Number, IndianRupee },
        { AustralianDollar.Number, AustralianDollar },
        { CanadianDollar.Number, CanadianDollar },
        { SwissFranc.Number, SwissFranc },
        { SwedishKrona.Number, SwedishKrona },
        { NorwegianKrone.Number, NorwegianKrone },
        { DanishKrone.Number, DanishKrone },
        { NewZealandDollar.Number, NewZealandDollar },
        { Rand.Number, Rand },
        { BrazilianReal.Number, BrazilianReal },
        { RussianRuble.Number, RussianRuble },
        { MexicanPeso.Number, MexicanPeso },
        { SingaporeDollar.Number, SingaporeDollar },
        { HongKongDollar.Number, HongKongDollar },
        { Won.Number, Won },
        { TurkishLira.Number, TurkishLira },
        { SaudiRiyal.Number, SaudiRiyal },
        { UaeDirham.Number, UaeDirham },
        { Baht.Number, Baht },
        { MalaysianRinggit.Number, MalaysianRinggit },
        { Rupiah.Number, Rupiah },
        { PhilippinePeso.Number, PhilippinePeso },
        { Dong.Number, Dong },
        { PakistanRupee.Number, PakistanRupee },
        { Taka.Number, Taka },
        { SriLankaRupee.Number, SriLankaRupee },
        { NepaleseRupee.Number, NepaleseRupee },
        { IraqiDinar.Number, IraqiDinar },
        { IranianRial.Number, IranianRial },
        { EgyptianPound.Number, EgyptianPound },
        { Naira.Number, Naira },
        { KenyanShilling.Number, KenyanShilling },
        { GhanaCedi.Number, GhanaCedi },
        { CfaFrancBceao.Number, CfaFrancBceao },
        { CfaFrancBeac.Number, CfaFrancBeac },
        { ArgentinePeso.Number, ArgentinePeso },
        { ChileanPeso.Number, ChileanPeso },
        { ColombianPeso.Number, ColombianPeso },
        { Sol.Number, Sol },
        { Hryvnia.Number, Hryvnia },
        { Zloty.Number, Zloty },
        { CzechKoruna.Number, CzechKoruna },
        { Forint.Number, Forint },
        { RomanianLeu.Number, RomanianLeu },
        { NewIsraeliSheqel.Number, NewIsraeliSheqel },
        { QatariRial.Number, QatariRial },
        { KuwaitiDinar.Number, KuwaitiDinar },
        { RialOmani.Number, RialOmani },
        { BahrainiDinar.Number, BahrainiDinar },
        { IcelandKrona.Number, IcelandKrona },
        { CostaRicanColon.Number, CostaRicanColon },
        { DominicanPeso.Number, DominicanPeso },
        { Quetzal.Number, Quetzal },
        { Lempira.Number, Lempira },
        { Balboa.Number, Balboa },
        { PesoUruguayo.Number, PesoUruguayo },
        { Boliviano.Number, Boliviano },
        { Guarani.Number, Guarani },
        { UzbekistanSum.Number, UzbekistanSum },
        { Tenge.Number, Tenge },
        { Somoni.Number, Somoni },
        { Som.Number, Som },
        { TurkmenistanNewManat.Number, TurkmenistanNewManat },
        { AzerbaijanManat.Number, AzerbaijanManat },
        { Lari.Number, Lari },
        { ArmenianDram.Number, ArmenianDram },
        { BelarusianRuble.Number, BelarusianRuble },
        { TunisianDinar.Number, TunisianDinar },
        { MoroccanDirham.Number, MoroccanDirham },
        { CfpFranc.Number, CfpFranc },
        { EastCaribbeanDollar.Number, EastCaribbeanDollar },
        { Sdr.Number, Sdr }
    };

    public static readonly IReadOnlyDictionary<string, Currency> NameMap = new Dictionary<string, Currency>
    {
        { None.Name, None },
        { Afghani.Name, Afghani },
        { Euro.Name, Euro },
        { UsDollar.Name, UsDollar },
        { PoundSterling.Name, PoundSterling },
        { Yen.Name, Yen },
        { YuanRenminbi.Name, YuanRenminbi },
        { IndianRupee.Name, IndianRupee },
        { AustralianDollar.Name, AustralianDollar },
        { CanadianDollar.Name, CanadianDollar },
        { SwissFranc.Name, SwissFranc },
        { SwedishKrona.Name, SwedishKrona },
        { NorwegianKrone.Name, NorwegianKrone },
        { DanishKrone.Name, DanishKrone },
        { NewZealandDollar.Name, NewZealandDollar },
        { Rand.Name, Rand },
        { BrazilianReal.Name, BrazilianReal },
        { RussianRuble.Name, RussianRuble },
        { MexicanPeso.Name, MexicanPeso },
        { SingaporeDollar.Name, SingaporeDollar },
        { HongKongDollar.Name, HongKongDollar },
        { Won.Name, Won },
        { TurkishLira.Name, TurkishLira },
        { SaudiRiyal.Name, SaudiRiyal },
        { UaeDirham.Name, UaeDirham },
        { Baht.Name, Baht },
        { MalaysianRinggit.Name, MalaysianRinggit },
        { Rupiah.Name, Rupiah },
        { PhilippinePeso.Name, PhilippinePeso },
        { Dong.Name, Dong },
        { PakistanRupee.Name, PakistanRupee },
        { Taka.Name, Taka },
        { SriLankaRupee.Name, SriLankaRupee },
        { NepaleseRupee.Name, NepaleseRupee },
        { IraqiDinar.Name, IraqiDinar },
        { IranianRial.Name, IranianRial },
        { EgyptianPound.Name, EgyptianPound },
        { Naira.Name, Naira },
        { KenyanShilling.Name, KenyanShilling },
        { GhanaCedi.Name, GhanaCedi },
        { CfaFrancBceao.Name, CfaFrancBceao },
        { CfaFrancBeac.Name, CfaFrancBeac },
        { ArgentinePeso.Name, ArgentinePeso },
        { ChileanPeso.Name, ChileanPeso },
        { ColombianPeso.Name, ColombianPeso },
        { Sol.Name, Sol },
        { Hryvnia.Name, Hryvnia },
        { Zloty.Name, Zloty },
        { CzechKoruna.Name, CzechKoruna },
        { Forint.Name, Forint },
        { RomanianLeu.Name, RomanianLeu },
        { NewIsraeliSheqel.Name, NewIsraeliSheqel },
        { QatariRial.Name, QatariRial },
        { KuwaitiDinar.Name, KuwaitiDinar },
        { RialOmani.Name, RialOmani },
        { BahrainiDinar.Name, BahrainiDinar },
        { IcelandKrona.Name, IcelandKrona },
        { CostaRicanColon.Name, CostaRicanColon },
        { DominicanPeso.Name, DominicanPeso },
        { Quetzal.Name, Quetzal },
        { Lempira.Name, Lempira },
        { Balboa.Name, Balboa },
        { PesoUruguayo.Name, PesoUruguayo },
        { Boliviano.Name, Boliviano },
        { Guarani.Name, Guarani },
        { UzbekistanSum.Name, UzbekistanSum },
        { Tenge.Name, Tenge },
        { Somoni.Name, Somoni },
        { Som.Name, Som },
        { TurkmenistanNewManat.Name, TurkmenistanNewManat },
        { AzerbaijanManat.Name, AzerbaijanManat },
        { Lari.Name, Lari },
        { ArmenianDram.Name, ArmenianDram },
        { BelarusianRuble.Name, BelarusianRuble },
        { TunisianDinar.Name, TunisianDinar },
        { MoroccanDirham.Name, MoroccanDirham },
        { CfpFranc.Name, CfpFranc },
        { EastCaribbeanDollar.Name, EastCaribbeanDollar },
        { Sdr.Name, Sdr }
    };
}