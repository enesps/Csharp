using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar.Ornek
{
    public class Emlak
    {
        protected int _say;
        public long IlanNo;
        public string Tipi;
        public int BrutAlan;
        public int NetAlan;
        public int BinaYasi;
        public int OdaSayisi;
        public string Isitma;
        public DateTime IlanTarihi;
        public bool KrediyeUygun;
        public string Kimden;
        public bool Takas;

        public void SetSay(int say)
        {
            _say = say;
        }
        public int GetSay()
        {
            return _say;
        }
    }

    public class Konut : Emlak
    {
        public int SalonSayisi;
        public int BulunduguKat;
        public int KatSayisi;
        public int BanyoSayisi;
        public bool Balkon;
        public bool Esyali;
        public string KullanimDurumu;
        public bool SiteIcerisinde;
        public string SiteAdi;
        public decimal Aidat;
        public bool GoruntuluGezilebilir;
    }

    public class IsYeri : Emlak
    {
        public string Kategori;
        public string Durumu;
        public double TavanYuksekligi;
    }

    public class Arsa : Emlak
    {
        public string ImarDurumu;
        public decimal M2Fiyatı;
        public int AdaNo;
        public int ParselNo;
        public int PaftaNo;
        public string Kaks;
        public string Gabari;
        public string TapuDurumu;
        public bool KatKarsiligi;
    }

    public class Bina : Emlak {
        public int KatSayisi;
        public int BirKattakiDaire;
    }
    public class DevreMulk : Emlak {
        public string Donem;
        public int Sure;
    }
    public class TuristikTesis : Emlak {
        public int KatSayisi;
        public int AcikAlan;
        public int KapaliAlan;
        public bool ZeminEtudu;
        public int YatakSayisi;
        public int YildizSayisi;
    }
}
