using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik12
{
    internal class Bebek
    {
        // Özelliklerin tanımlanması
        private DateTime dogumTarihi;
        private string ad;
        private string soyad;

        // Parametresiz Constructor
        public Bebek()
        {
            dogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

       // Parametreli Constructor
        public Bebek(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
            dogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }


        // Get/Set metotları
        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        

        
    }
}
