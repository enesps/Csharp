using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Object001 : Base
    {
        public string Data { get; set; }

        public override void EkranaYaz() //Mirastan gelen sanal metot burada üzerine yazılarak güncellenir.
        {
            base.EkranaYaz();
            Console.WriteLine("Data: " + Data);
        }
    }
}
