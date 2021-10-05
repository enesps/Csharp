using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    //OOP Kalıtım/Miras Alma (Inheritence): Bir sınıfın başka ebeveyn bir sınıf kullanılarak genişletilmesini, özellik kazanmasını sağlayan yapıdır.
    public class Sekil //Ebeveyn/temel sınıf (parent/base class)
    {
        protected int _en;
        protected int _boy;

        public virtual void SetEn(int en)
        {
            _en = en;
        }

        public virtual void SetBoy(int boy)
        {
            _boy = boy;
        }
    }

    public class Dikdortgen : Sekil //Çocuk sınıf (Child class) : ebeveyn sınıf
    {
        public int AlanHesapla()
        {
            return _en * _boy;
        }
    }

    public class Kare : Sekil
    {
        //override: Bu işlem ebeveyn sınıf içerisinde zilebilen sanal metotların yerine çalışmak istediğimiz zaman yazdığımız metot tipidir. Sadece virtual yapılar override edilebilir.
        public override void SetBoy(int boy)
        {
            base.SetBoy(boy);
            base.SetEn(boy);
        }

        public override void SetEn(int en)
        {
            base.SetEn(en);
            base.SetBoy(en);
        }

        public int CevreHesapla()
        {
            return 2 * (_en + _boy);
        }
    }
}
