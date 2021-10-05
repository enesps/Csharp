using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders003
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Operatör KAvramı: 
             * - Tamsayı veri tiplerinde operasyon sonucu tamsayi gelir, ondalık sonuc durumundaysa tam kısmını alır.
             * - Atama Operatörü(=, +=, -=, /=, *=, %=):*/
            int a = 15;
            double b = a;
            b = 35;
            b += 3; //b = b + 3;
            Console.WriteLine(b);
            b -= 3; //b = b - 3;
            Console.WriteLine(b);
            b /= 3; //b = b / 3;
            Console.WriteLine(b);
            b *= 3; //b = b * 3;
            Console.WriteLine(b);
            b %= 3; //b = b % 3;
            Console.WriteLine(b);

            /* - Aritmetik Operatörler(+,-,*,/,%):*/
            double c;
            c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a % b;
            Console.WriteLine(c);

            /* string veri tipinde toplama işlemi yanyana yazmak anlamına gelir.*/
            string isim = "ilker";
            isim += " turan";
            Console.WriteLine(isim);

            /* - İlişkisel Operatörler(==, !=, <, >, <=, >=): Karşılaitır sonucu mantıksal(bool) bir cevaptır.*/
            bool cevap;
            cevap = a == b; //Eşit midir?
            Console.WriteLine(cevap);
            cevap = a != b; //Eşit değil midir?
            Console.WriteLine(cevap);
            cevap = a < b; //Küçük müdür?
            Console.WriteLine(cevap);
            cevap = a > b; //Büyük müdür?
            Console.WriteLine(cevap);
            cevap = a <= b; //Küçük veya Eşit midir?
            Console.WriteLine(cevap);
            cevap = a >= b; //Büyük veya Eşit midir?
            Console.WriteLine(cevap);

            string isim1 = "ilker";
            string isim2 = "ilkay";

            cevap = isim1 == isim2; //Eşit midir?
            Console.WriteLine(cevap);
            cevap = isim1 != isim2; //Eşit değil midir?
            Console.WriteLine(cevap);

            /* - Mantıksal Operatörler: bir veya iki mantıksal veri tipini karşılaştırıp, mantıksal bir cevap üreten yapılardır.
             */
            bool data1 = true;
            bool data2 = false;
            /*AND (VE, &/&&): İki mantıksal değeri karşılaştırır, matematikte çarpma işlemine karşılık gelir. False(0) yutan elemandır.
             Mantıksal Tablo:
             TRUE &/&& TRUE => TRUE
             TRUE &/&& FALSE => FALSE
             FALSE &/&& TRUE => FALSE
             FALSE &/&& FALSE => FALSE
             */

            cevap = data1 && data2;
            Console.WriteLine(cevap);

            /*OR (VEYA, |/||): İki mantıksal değeri karşılaştırır, matematikte toplama işlemine karşılık gelir. False(0) etkisiz elemandır.
             Mantıksal Tablo:
             TRUE &/&& TRUE => TRUE
             TRUE &/&& FALSE => TRUE
             FALSE &/&& TRUE => TRUE
             FALSE &/&& FALSE => FALSE
             */

            cevap = data1 || data2;
            Console.WriteLine(cevap);

            /*NOT (DEĞİL, !): Önüne geldiği mantıksal değeri tersler.
             Mantıksal Tablo:
             !TRUE => FALSE
             !FALSE => TRUE
             */

            cevap = !cevap;
            Console.WriteLine(cevap);
        }
    }
}
