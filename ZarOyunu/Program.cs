using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Zar para = new Zar("Para", 2, 1);
            Zar z4 = new Zar("Z4", 4, 1);
            Zar tavla = new Zar("Tavla", 6, 1);
            Zar z100 = new Zar("Z100", 10, 10);
            Zar z77 = new Zar(7, 11);
            Zar z72 = new Zar(12, 6);

            Console.WriteLine(para.Name + ": " + para.At());
            Console.WriteLine(z4.Name + ": " + z4.At());
            Console.WriteLine(tavla.Name + ": " + tavla.At());
            Console.WriteLine(z100.Name + ": " + z100.At());
            Console.WriteLine(z77.Name + ": " + z77.At());
            Console.WriteLine(z72.Name + ": " + z72.At());

            Para p1 = new Para();
            Console.WriteLine(p1.Name + ": " + p1.At());

            Zar p2 = new Para();
            Console.WriteLine(p2.Name + ": " + p2.At());

            Console.ReadKey();
        }
    }
}
