using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir nesne için örnek oluşmak 'new' operatörü ile yapılır.
            HesapMakinesi makine1 = new HesapMakinesi();
            HesapMakinesi makine2 = new HesapMakinesi();

            makine1.Topla(5, 78);
            Console.WriteLine(makine1.SonucGetir());
            makine1.Topla(51, 8);
            Console.WriteLine(makine1.SonucGetir());
            makine1.Topla(52, 11);
            Console.WriteLine(makine1.SonucGetir());
            Console.WriteLine(HesapMakinesi.islemSayisiGetir());
            

            makine2.Topla(15, 8);
            Console.WriteLine(HesapMakinesi.islemSayisiGetir());
            Console.WriteLine(makine2.SonucGetir());
            Console.ReadLine();

        }
    }

    public class HesapMakinesi
    {
        public int sonuc;
        private static int islemSayisi;

        public static int islemSayisiGetir()
        {
            return islemSayisi;
        }

        //Geri dönen veri yok, parametre var.
        public void Topla(int a, int b)
        {
            sonuc = a + b;
            islemSayisi = islemSayisi + 1;
        }

        //Geri dönen veri var, parametre var.
        public int Carp(int a, int b)
        {
            sonuc = a * b;
            return sonuc;
        }

        //Geri dönen veri var, parametre yok.
        public int SonucGetir()
        {
            return sonuc;
        }

        //Geri dönen veri yok, parametre yok.
        public void SonucSifirla()
        {
            sonuc = 0;

        }
       

        
    }
}
