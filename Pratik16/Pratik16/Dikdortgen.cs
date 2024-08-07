using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik16
{
    //Dikdörtgen sınıfı(BaseGeometrikSekil sınıfından türetildi)
    public class Dikdortgen : BaseGeometrikSekil
    {
        // Constructor
        public Dikdortgen(double yukseklik, double genislik)
            : base(yukseklik, genislik)
        { }


        // Base sınıfın AlanHesapla() metodunun ezilmesi
        public override void AlanHesapla()
        {
            Console.WriteLine("Dikdörtgenin alanı: " +Yukseklik * Genislik);
        }
    }
}
