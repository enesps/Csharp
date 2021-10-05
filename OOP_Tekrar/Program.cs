using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.SetEn(15);
            d1.SetBoy(10);
            Console.WriteLine(d1.AlanHesapla());

            Kare k1 = new Kare();
            k1.SetEn(17);
            Console.WriteLine(k1.CevreHesapla());

            Kopek kopek = new Kopek();
            kopek.SesCikar();
            kopek.Uyu();
            
            Kedi kedi = new Kedi();
            kedi.SesCikar();
            kedi.Uyu();

            Insan insan = new Insan();
            insan.SesCikar();
            insan.Uyu();
            insan.Giyin();

            Console.ReadKey();
        }
    }
}
