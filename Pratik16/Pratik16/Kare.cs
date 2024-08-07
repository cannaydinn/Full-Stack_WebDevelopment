using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik16
{
    //Kare sınıfı(BaseGeometrikSekil sınıfından türetildi)
    public class Kare : BaseGeometrikSekil
    {
        // Constructor
        public Kare(double yukseklik)
            :base(yukseklik,yukseklik) 
        { }


        // Base sınıfın AlanHesapla() metodunun ezilmesi
        public override void AlanHesapla()
        {
            Console.WriteLine("Kare'nin alanı : "+Math.Pow(Yukseklik,2));
        }
    }
}
