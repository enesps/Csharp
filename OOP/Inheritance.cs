using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Miras Alma/Kalıtım: Birden fazla sınıfın ortak özelliklerinin bir başka sınıfta toplanarak nesne yönetiminin kolaylaştırılması yöntemidir. Sadece tek bir sınıf kalıtımı yapılabilir.
    public class Inheritance
    {
        public string Heading { get => "Heading"; }
        public DateTime CreateDate { get; private set; }
        public Inheritance()
        {
            CreateDate = DateTime.Now;
        }
    }
}
