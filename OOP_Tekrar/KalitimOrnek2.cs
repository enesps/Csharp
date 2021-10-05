using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    //Base Class:
    public class Hayvanlar { }

    //Sub/Base Class:
    public class SicakKanli : Hayvanlar { }

    //Sub/Base Class
    public class Memeliler : SicakKanli { }

    //Sub Class
    public class Ayi : Memeliler { }

    //Sub Class
    public class Kuslar : SicakKanli { }

    //Sub/Base Class:
    public class SogukKanli : Hayvanlar { }

    //Sub Class
    public class Baliklar : SogukKanli { }

    //Sub Class
    public class Kertenkeleler : SogukKanli { }

    //Sub Class
    public class Amfibiler : SogukKanli { }
}
