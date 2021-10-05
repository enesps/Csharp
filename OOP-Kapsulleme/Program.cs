using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapsulleme
{
    public class Kisi
    {
        public static int SonId;
        private int id;
        private string isim;

        public int Id
        {
            get { return id; }
        }
        public string Isim { get => isim; set => isim = value; }

        public Kisi(string i)
        {
            Isim = i;//Set işlemi;
            SonId++;
            id = SonId;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme (Encapsulation): Sınıf özelliklerini/mülklerini (property) denetlemek, sınırlamak, yönetmek amacıyla kullanılan yöntemdir. Her bir özelliğin bir ayarlama(set), bir de okuma(get) metot düzeni vardır. Biz görmesek bile koşulsuz olarak arka planda ne verirsek yazan, ne varsa okuyan bir yapıdır.


            Kisi k1 = new Kisi("İlker");
            Kisi k2 = new Kisi("İlkay");
            Kisi k3 = new Kisi("Deniz");

            Console.WriteLine(k1.Isim + ":" + k1.Id);
            Console.WriteLine(k2.Isim + ":" + k2.Id);
            Console.WriteLine(k3.Isim + ":" + k3.Id);
            //Console.WriteLine(Guid.NewGuid().ToString().Replace("-","").ToUpper());
            Console.ReadKey();
        }
    }
}
