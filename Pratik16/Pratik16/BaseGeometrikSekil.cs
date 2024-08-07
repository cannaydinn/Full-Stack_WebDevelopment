using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pratik16
{
    // Polimorfizm, Kapsülleme, Kalıtım kullanılmıştır.

    // Base sınıf
    public abstract class BaseGeometrikSekil
    {
        // sınıfın field'ları
        private double yukseklik;
        private double genislik;

        // Constructor
        public BaseGeometrikSekil(double yukseklik, double genislik)
        {
            this.yukseklik = yukseklik;
            this.genislik = genislik;
        }


        // Sınıfın get/set metotları
        public double Yukseklik
        {
            get { return yukseklik; }
            set { yukseklik = value; }
        }

        public double Genislik
        {
            get { return genislik; }
            set { genislik = value; }
        }

        // Abstract metodu miras kalan diğer sayfalarda ezmemiz gerekiyor
        public abstract void AlanHesapla();
    }
}
