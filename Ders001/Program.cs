/* Kod içerisinde silik şekilde görünen kod parçaları kullanımda değil demektir.
 * 
 */
//using: dışarıdan eklenen referansların bu kod sayfası için kullanılabilir olmasını sağlamaktadır.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace: Erişim bölgesi/alanı, kod sayfalarının erişim alanlarını gruplara ayırmak için kullanılır. Genellikle fiziksel klasörlerin hiyerarşisiyle aynı olur.
namespace Ders001
{
    //Bu noktadan sonra nesneler tanımlanmaya başlar. (class, enum, interface)

    /*Nesne tanım şablonu:
     * <Erişim Belirleyici> <Nesne Türü(class/enum/interface)> <Nesne Adı>{}
     * Erişim Belirleyiciler:
     *  - public: Genele açık kod parçaları/nesneler için kullanılır. Projenin her hangi bir yerinden erişim sağlamak için tanımlarız.
     *  - private: Özel yapılardır, dışarıdan erişime tamamen kapalıdırlar.
     *  - protected/yazılmaması durumu: Sınırlı yapılardır, OOP kurallarına göre ilişki kurulmuş nesneler arası erişimie açık sistemlerdir.
     *  
     *  Nesne Türleri:
     */

    //class(sınıf): En çok kullanılan nesne türüdür. Uygulamalarımız bu nesne çerçevesinde geliştirilir.
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }


    //enum(numaralı liste): Sıklıkla sabit bilgi dizisi ihtiyacımızda kullanılan nesne türüdür. Sıralaması 0'dan başlar.
    enum Enum
    {
        First,
        Second,
        Third
    }

    //interface(arayüz): Bir sınıf için tasarlanan manifestolardır, o sınıfın kullanması zorunlu olan yapılarını tutar. İçine çalıştırılabilir kod yazılmaz sadece kod parçaları takma ad(alias) belirtilir.
    interface IProgram
    {
        void Start();
    }



}
