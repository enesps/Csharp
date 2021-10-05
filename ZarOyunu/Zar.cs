using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    public class Zar
    {
        private static readonly Random random = new Random();
        private int[] yuzler;
        public string Name { get; set; }

        //Çok Şekillilik(Polymorphism): Bir nesnenin aynı isimde birden fazla amaca yönelik kullanılabilmesine olanak sağlayan yapılardır.
        
        //Metotlar aynı isimle parametre farkıyla tekrar tekrar yazılabilir.
        public Zar(string name, int yuz_sayisi, int carpan)
        {
            Name = name;
            ZarOlustur(yuz_sayisi, carpan);
        }

        public Zar(int yuz_sayisi, int carpan)
        {
            Name = "Z" + (yuz_sayisi * carpan);
            ZarOlustur(yuz_sayisi, carpan);
        }

        public int At()
        {
            int yuzIndex = random.Next(yuzler.Length);
            return yuzler[yuzIndex];
        }

        private void ZarOlustur(int yuz_sayisi, int carpan)
        {
            yuzler = new int[yuz_sayisi];
            for (int i = 0; i < yuz_sayisi; i++)
            {
                yuzler[i] = (i + 1) * carpan;
            }
        }
    }
}
