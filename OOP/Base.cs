using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Base : Inheritance, IBase
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual void EkranaYaz()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Is Active: " + IsActive);
            Console.WriteLine("Is Deleted: " + IsDeleted);
        }
    }
}
