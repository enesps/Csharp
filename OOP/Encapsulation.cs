using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Encapsulation (Kapsülleme): Değişken mülklerin erişimini kısıtlamak, yönetmek, kontrol altında tutmak amacıyla kullanılır.
    public class Encapsulation
    {
        private int b;
        public int A;

        public int B
        {
            get => b == 0 ? 1 : b;
            set => b = value == 0 ? 1 : value;
        }

        public int C { get => 155; } //Sadece okunabilir
        public int D { set => D = value; } //Sadece yazılabilir.

        //Kısıtlamasız standart yazım:
        public int E { get; set; }

        public int Bol()
        {
            return A / B;
        }
    }
}
