using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karar Yapıları:
            /*IF (Eğer) İfadesi:
             * IF(<Koşul/Mantıksal Cevap>){<İşlemler>}
             */

            int a = 30;
            int b = 20;
            if (a > b)
            {
                Console.WriteLine("A büyüktür B");
            }

            /*IF(Eğer)...ELSE(Değilse) İfadesi:
             * IF(<Koşul/Mantıksal Cevap>){<Koşul TRUE işlemleri>}
             * ELSE{<Koşul FALSE işlemleri>}
             */

            if (a < b)
            {
                Console.WriteLine("A küçüktür B");
            }
            else
            {
                Console.WriteLine("A küçük değildir B");
            }

            /*IF(Eğer)...ELSE IF(Öyleyse)...ELSE(Değilse) İfadesi:
             * IF(<1. Koşul/Mantıksal Cevap>){<1. Koşul TRUE işlemleri>}
             * ELSE IF(<2. Koşul/Mantıksal Cevap>){<2. Koşul TRUE işlemleri>}
             * .
             * .
             * .
             * ELSE IF(<n. Koşul/Mantıksal Cevap>){<n. Koşul TRUE işlemleri>}
             * ELSE{<Tüm Koşullar FALSE işlemleri>}
             */

            if (a < b)
            {
                Console.WriteLine("A küçüktür B");
            }
            else if (b < a)
            {
                Console.WriteLine("A büyüktür B");
            }
            else
            {
                Console.WriteLine("A eşittir B");
            }

            /*switch(seç){case (uygula)} ifadesi: Gelen değişken/mülke eşit midir sorunu sorar.*/

            Gunler gun = Gunler.Pazar;

            switch (gun)
            {
                case Gunler.Pazartesi: Console.WriteLine("Pazartesi"); break;
                case Gunler.Salı: Console.WriteLine("Salı"); break;
                case Gunler.Çarşamba: Console.WriteLine("Çarşamba"); break;
                case Gunler.Perşembe: Console.WriteLine("Perşembe"); break;
                case Gunler.Cuma: Console.WriteLine("Cuma"); break;
                case Gunler.Cumartesi: Console.WriteLine("Cumartesi"); break;
                case Gunler.Pazar: Console.WriteLine("Pazar"); break;
                default: Console.WriteLine("Böyle bir gün bulunamadı"); break;
            }

            int gun1 = 9;

            switch (gun1)
            {
                case 1: Console.WriteLine("Pazartesi"); break;
                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Çarşamba"); break;
                case 4: Console.WriteLine("Perşembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Cumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;
                default: Console.WriteLine("Böyle bir gün bulunamadı"); break;
            }
        }

    }
    public enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}
