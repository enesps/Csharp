using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBicimlilik
{
    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TagLine { get; set; }
    }

    public class Child1 : Base
    {
        public int Child1Prop { get; set; }
    }

    public class Child2 : Base
    {
        public int Child2Prop { get; set; }
    }
}
