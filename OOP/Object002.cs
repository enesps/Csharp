using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Object002 : Base
    {
        public double Value { get; set; }

        public override void EkranaYaz()
        {
            base.EkranaYaz();
            Console.WriteLine("Value: " + Value);
        }
    }
}
