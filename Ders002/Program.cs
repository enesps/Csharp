using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders002
{
    class Program
    {
        /*Sınıf Nesnesi Özellikleri:
         * - Değişken(variable) ve İşlevsel(method) Mülkler(Property) Bulundurur.
         * - Mülkler dışında bir yere yazılan komutlar hata verir.
         *  --> Değişken (variable) Mülkler.
         *      * Bir veri tipine ait veri veya verileri tutacak yapılardır.
         *      * Şablon: 
         *          - <Erişim Belirleyici> <Erişim Türü> <Yazma/Okuma Yetkisi> <Veri Tipi> <Mülk adı>;
         *          - <Erişim Belirleyici> <Erişim Türü> <Yazma/Okuma Yetkisi> <Veri Tipi> <Mülk adı> = <Veri tipinde değer>;
         */
        
        public int sayi;
        public static readonly int sayi2 = 135;
        /*Erişim Türü:
         * static: Prototip nesneler için kullanılan bir yapıdır. 
         * non-static (yazılmama durumu): Örneklenmiş nesnelerde kullanılan mülkleri anlatır.
         * 
         * Yazma/Okuma Yetkisi:
         * ReadOnly: Sadece okunabilir ve değerin tanımlama esmasında atandığını belirten özelliktir.
         */
         /*     --> İşlevsel(method) Mülkler: Bir görevi olan yapılardır. Kullanılabilir bir veri dönebilir veya kendi başına çalışabilir yapılardır. İhtiyacı durumunda ise dışarıdan bilgi talep eder.
          *
          * Şablon:
          * <Erişim Belirleyici> <Erişim Türü> <Geri Dönecek Veri Tipi/void> <Mülk Adı>(<Varsa Parametreler>){
          * <Çalışacak kod parçası>
          * <Geri dönecek veri tipi belirtilmişse return <veri tipinde değer/değişken/mülk>;>
          * }
          */

        static void Main(string[] args)
        {

        }

        public static int Topla(int a, int b)
        {
            int cevap = a + b;
            return cevap;
        }
    }
}
