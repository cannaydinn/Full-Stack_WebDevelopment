using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik16
{
    //Dik üçgen sınıfı(BaseGeometrikSekil sınıfından türetildi)
    public class DikUcgen : BaseGeometrikSekil
    {
        //Constructor
        public DikUcgen(double yukseklik, double genislik)
            : base(yukseklik, genislik)
        { }

        // Base sınıfın AlanHesapla() metodunun ezilmesi
        public override void AlanHesapla()
        {
            Console.WriteLine("Dik üçgenin alanı: " + (Yukseklik * Genislik) / 2);
        }

    }
}
