using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IBase
    {
        //Arayüzler: Bir sınıfın kullanması istenen metotların belirlendiği yapıdır. Metotlar erişim belirleyici taşımaz, static olmaz, kod bloğu taşımaz. Arayüzler sınırsız sayıda eklenebilir.

        void EkranaYaz();
    }
}
