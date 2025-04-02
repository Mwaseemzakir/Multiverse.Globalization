using System.Collections.Generic;

namespace Multiverse.Globalization.Currencies;

internal static class CurrencyHelper
{
    #region List
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

    #endregion
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
        { None.Code.ToLowerInvariant(), None },
        { Afghani.Code.ToLowerInvariant(), Afghani },
        { Euro.Code.ToLowerInvariant(), Euro },
        { UsDollar.Code.ToLowerInvariant(), UsDollar },
        { PoundSterling.Code.ToLowerInvariant(), PoundSterling },
        { Yen.Code.ToLowerInvariant(), Yen },
        { YuanRenminbi.Code.ToLowerInvariant(), YuanRenminbi },
        { IndianRupee.Code.ToLowerInvariant(), IndianRupee },
        { AustralianDollar.Code.ToLowerInvariant(), AustralianDollar },
        { CanadianDollar.Code.ToLowerInvariant(), CanadianDollar },
        { SwissFranc.Code.ToLowerInvariant(), SwissFranc },
        { SwedishKrona.Code.ToLowerInvariant(), SwedishKrona },
        { NorwegianKrone.Code.ToLowerInvariant(), NorwegianKrone },
        { DanishKrone.Code.ToLowerInvariant(), DanishKrone },
        { NewZealandDollar.Code.ToLowerInvariant(), NewZealandDollar },
        { Rand.Code.ToLowerInvariant(), Rand },
        { BrazilianReal.Code.ToLowerInvariant(), BrazilianReal },
        { RussianRuble.Code.ToLowerInvariant(), RussianRuble },
        { MexicanPeso.Code.ToLowerInvariant(), MexicanPeso },
        { SingaporeDollar.Code.ToLowerInvariant(), SingaporeDollar },
        { HongKongDollar.Code.ToLowerInvariant(), HongKongDollar },
        { Won.Code.ToLowerInvariant(), Won },
        { TurkishLira.Code.ToLowerInvariant(), TurkishLira },
        { SaudiRiyal.Code.ToLowerInvariant(), SaudiRiyal },
        { UaeDirham.Code.ToLowerInvariant(), UaeDirham },
        { Baht.Code.ToLowerInvariant(), Baht },
        { MalaysianRinggit.Code.ToLowerInvariant(), MalaysianRinggit },
        { Rupiah.Code.ToLowerInvariant(), Rupiah },
        { PhilippinePeso.Code.ToLowerInvariant(), PhilippinePeso },
        { Dong.Code.ToLowerInvariant(), Dong },
        { PakistanRupee.Code.ToLowerInvariant(), PakistanRupee },
        { Taka.Code.ToLowerInvariant(), Taka },
        { SriLankaRupee.Code.ToLowerInvariant(), SriLankaRupee },
        { NepaleseRupee.Code.ToLowerInvariant(), NepaleseRupee },
        { IraqiDinar.Code.ToLowerInvariant(), IraqiDinar },
        { IranianRial.Code.ToLowerInvariant(), IranianRial },
        { EgyptianPound.Code.ToLowerInvariant(), EgyptianPound },
        { Naira.Code.ToLowerInvariant(), Naira },
        { KenyanShilling.Code.ToLowerInvariant(), KenyanShilling },
        { GhanaCedi.Code.ToLowerInvariant(), GhanaCedi },
        { CfaFrancBceao.Code.ToLowerInvariant(), CfaFrancBceao },
        { CfaFrancBeac.Code.ToLowerInvariant(), CfaFrancBeac },
        { ArgentinePeso.Code.ToLowerInvariant(), ArgentinePeso },
        { ChileanPeso.Code.ToLowerInvariant(), ChileanPeso },
        { ColombianPeso.Code.ToLowerInvariant(), ColombianPeso },
        { Sol.Code.ToLowerInvariant(), Sol },
        { Hryvnia.Code.ToLowerInvariant(), Hryvnia },
        { Zloty.Code.ToLowerInvariant(), Zloty },
        { CzechKoruna.Code.ToLowerInvariant(), CzechKoruna },
        { Forint.Code.ToLowerInvariant(), Forint },
        { RomanianLeu.Code.ToLowerInvariant(), RomanianLeu },
        { NewIsraeliSheqel.Code.ToLowerInvariant(), NewIsraeliSheqel },
        { QatariRial.Code.ToLowerInvariant(), QatariRial },
        { KuwaitiDinar.Code.ToLowerInvariant(), KuwaitiDinar },
        { RialOmani.Code.ToLowerInvariant(), RialOmani },
        { BahrainiDinar.Code.ToLowerInvariant(), BahrainiDinar },
        { IcelandKrona.Code.ToLowerInvariant(), IcelandKrona },
        { CostaRicanColon.Code.ToLowerInvariant(), CostaRicanColon },
        { DominicanPeso.Code.ToLowerInvariant(), DominicanPeso },
        { Quetzal.Code.ToLowerInvariant(), Quetzal },
        { Lempira.Code.ToLowerInvariant(), Lempira },
        { Balboa.Code.ToLowerInvariant(), Balboa },
        { PesoUruguayo.Code.ToLowerInvariant(), PesoUruguayo },
        { Boliviano.Code.ToLowerInvariant(), Boliviano },
        { Guarani.Code.ToLowerInvariant(), Guarani },
        { UzbekistanSum.Code.ToLowerInvariant(), UzbekistanSum },
        { Tenge.Code.ToLowerInvariant(), Tenge },
        { Somoni.Code.ToLowerInvariant(), Somoni },
        { Som.Code.ToLowerInvariant(), Som },
        { TurkmenistanNewManat.Code.ToLowerInvariant(), TurkmenistanNewManat },
        { AzerbaijanManat.Code.ToLowerInvariant(), AzerbaijanManat },
        { Lari.Code.ToLowerInvariant(), Lari },
        { ArmenianDram.Code.ToLowerInvariant(), ArmenianDram },
        { BelarusianRuble.Code.ToLowerInvariant(), BelarusianRuble },
        { TunisianDinar.Code.ToLowerInvariant(), TunisianDinar },
        { MoroccanDirham.Code.ToLowerInvariant(), MoroccanDirham },
        { CfpFranc.Code.ToLowerInvariant(), CfpFranc },
        { EastCaribbeanDollar.Code.ToLowerInvariant(), EastCaribbeanDollar },
        { Sdr.Code.ToLowerInvariant(), Sdr }
    };

    public static readonly IReadOnlyDictionary<string, Currency> NameMap = new Dictionary<string, Currency>
    {
        { None.Name.ToLowerInvariant(), None },
        { Afghani.Name.ToLowerInvariant(), Afghani },
        { Euro.Name.ToLowerInvariant(), Euro },
        { UsDollar.Name.ToLowerInvariant(), UsDollar },
        { PoundSterling.Name.ToLowerInvariant(), PoundSterling },
        { Yen.Name.ToLowerInvariant(), Yen },
        { YuanRenminbi.Name.ToLowerInvariant(), YuanRenminbi },
        { IndianRupee.Name.ToLowerInvariant(), IndianRupee },
        { AustralianDollar.Name.ToLowerInvariant(), AustralianDollar },
        { CanadianDollar.Name.ToLowerInvariant(), CanadianDollar },
        { SwissFranc.Name.ToLowerInvariant(), SwissFranc },
        { SwedishKrona.Name.ToLowerInvariant(), SwedishKrona },
        { NorwegianKrone.Name.ToLowerInvariant(), NorwegianKrone },
        { DanishKrone.Name.ToLowerInvariant(), DanishKrone },
        { NewZealandDollar.Name.ToLowerInvariant(), NewZealandDollar },
        { Rand.Name.ToLowerInvariant(), Rand },
        { BrazilianReal.Name.ToLowerInvariant(), BrazilianReal },
        { RussianRuble.Name.ToLowerInvariant(), RussianRuble },
        { MexicanPeso.Name.ToLowerInvariant(), MexicanPeso },
        { SingaporeDollar.Name.ToLowerInvariant(), SingaporeDollar },
        { HongKongDollar.Name.ToLowerInvariant(), HongKongDollar },
        { Won.Name.ToLowerInvariant(), Won },
        { TurkishLira.Name.ToLowerInvariant(), TurkishLira },
        { SaudiRiyal.Name.ToLowerInvariant(), SaudiRiyal },
        { UaeDirham.Name.ToLowerInvariant(), UaeDirham },
        { Baht.Name.ToLowerInvariant(), Baht },
        { MalaysianRinggit.Name.ToLowerInvariant(), MalaysianRinggit },
        { Rupiah.Name.ToLowerInvariant(), Rupiah },
        { PhilippinePeso.Name.ToLowerInvariant(), PhilippinePeso },
        { Dong.Name.ToLowerInvariant(), Dong },
        { PakistanRupee.Name.ToLowerInvariant(), PakistanRupee },
        { Taka.Name.ToLowerInvariant(), Taka },
        { SriLankaRupee.Name.ToLowerInvariant(), SriLankaRupee },
        { NepaleseRupee.Name.ToLowerInvariant(), NepaleseRupee },
        { IraqiDinar.Name.ToLowerInvariant(), IraqiDinar },
        { IranianRial.Name.ToLowerInvariant(), IranianRial },
        { EgyptianPound.Name.ToLowerInvariant(), EgyptianPound },
        { Naira.Name.ToLowerInvariant(), Naira },
        { KenyanShilling.Name.ToLowerInvariant(), KenyanShilling },
        { GhanaCedi.Name.ToLowerInvariant(), GhanaCedi },
        { CfaFrancBceao.Name.ToLowerInvariant(), CfaFrancBceao },
        { CfaFrancBeac.Name.ToLowerInvariant(), CfaFrancBeac },
        { ArgentinePeso.Name.ToLowerInvariant(), ArgentinePeso },
        { ChileanPeso.Name.ToLowerInvariant(), ChileanPeso },
        { ColombianPeso.Name.ToLowerInvariant(), ColombianPeso },
        { Sol.Name.ToLowerInvariant(), Sol },
        { Hryvnia.Name.ToLowerInvariant(), Hryvnia },
        { Zloty.Name.ToLowerInvariant(), Zloty },
        { CzechKoruna.Name.ToLowerInvariant(), CzechKoruna },
        { Forint.Name.ToLowerInvariant(), Forint },
        { RomanianLeu.Name.ToLowerInvariant(), RomanianLeu },
        { NewIsraeliSheqel.Name.ToLowerInvariant(), NewIsraeliSheqel },
        { QatariRial.Name.ToLowerInvariant(), QatariRial },
        { KuwaitiDinar.Name.ToLowerInvariant(), KuwaitiDinar },
        { RialOmani.Name.ToLowerInvariant(), RialOmani },
        { BahrainiDinar.Name.ToLowerInvariant(), BahrainiDinar },
        { IcelandKrona.Name.ToLowerInvariant(), IcelandKrona },
        { CostaRicanColon.Name.ToLowerInvariant(), CostaRicanColon },
        { DominicanPeso.Name.ToLowerInvariant(), DominicanPeso },
        { Quetzal.Name.ToLowerInvariant(), Quetzal },
        { Lempira.Name.ToLowerInvariant(), Lempira },
        { Balboa.Name.ToLowerInvariant(), Balboa },
        { PesoUruguayo.Name.ToLowerInvariant(), PesoUruguayo },
        { Boliviano.Name.ToLowerInvariant(), Boliviano },
        { Guarani.Name.ToLowerInvariant(), Guarani },
        { UzbekistanSum.Name.ToLowerInvariant(), UzbekistanSum },
        { Tenge.Name.ToLowerInvariant(), Tenge },
        { Somoni.Name.ToLowerInvariant(), Somoni },
        { Som.Name.ToLowerInvariant(), Som },
        { TurkmenistanNewManat.Name.ToLowerInvariant(), TurkmenistanNewManat },
        { AzerbaijanManat.Name.ToLowerInvariant(), AzerbaijanManat },
        { Lari.Name.ToLowerInvariant(), Lari },
        { ArmenianDram.Name.ToLowerInvariant(), ArmenianDram },
        { BelarusianRuble.Name.ToLowerInvariant(), BelarusianRuble },
        { TunisianDinar.Name.ToLowerInvariant(), TunisianDinar },
        { MoroccanDirham.Name.ToLowerInvariant(), MoroccanDirham },
        { CfpFranc.Name.ToLowerInvariant(), CfpFranc },
        { EastCaribbeanDollar.Name.ToLowerInvariant(), EastCaribbeanDollar },
        { Sdr.Name.ToLowerInvariant(), Sdr }
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

}