using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    public class Hayvan
    {
        public void Uyu()
        {
            Console.WriteLine("Uyudum");
        }

        public virtual void SesCikar()
        {
            Console.WriteLine("Ses çıkardım...");
        }
    }

    public class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav...");
        }
    }

    public class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyav...");
        }
    }

    public class Insan : Hayvan
    {
        public void Giyin()
        {
            Console.WriteLine("Giyindim");
        }
    }
}
