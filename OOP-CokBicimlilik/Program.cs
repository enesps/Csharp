using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBicimlilik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çok Biçimlilik: Sınıfların temel /ebeveyn sınıf adıyla tanımlanabilmesi olayidir.

            Base[] Childeren = new Base[3];

            Childeren[0] = new Child1();
            Childeren[1] = new Child2();
            Childeren[2] = new Base();

        }
    }
}
