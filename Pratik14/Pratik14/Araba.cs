using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik14
{
    internal class Araba
    {
        // Araba sınıfının property'leri
        private string marka;
        private string model;
        private string renk;
        private int kapiSayisi;

        // Araba sınıfının constructor'ı
        public Araba(string marka, string model, string renk, int kapiSayisi)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
            this.KapiSayisi = kapiSayisi;
        }


        // Property'lerin get/set metotları
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }


        public int KapiSayisi
        {
            get { return kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    kapiSayisi = value;
                else
                {
                    Console.WriteLine("Yanlış değer");
                    kapiSayisi = -1;
                }

                    
            }
        }
        
        // Konsol ekranına yazdırma
        public void BilgiYazdir()
        {
            Console.WriteLine("Arabanın Markası: "+Marka);
            Console.WriteLine("Arabanın Modeli: "+Model);
            Console.WriteLine("Arabanın Rengi: "+Renk);
            Console.WriteLine("Arabanın Kapı Sayısı: "+kapiSayisi);
        }
    }
}
