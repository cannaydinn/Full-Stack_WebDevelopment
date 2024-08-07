using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Pratik15
{


    // KAPSÜLLEME VE KALITIM/MİRAS KULLANILMIŞTIR
    public abstract class BaseKisi
    {
        // Private Alanlar
        private string ad;
        private string soyad;

        // Constructor
        public BaseKisi(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        // Public özelliklerin get/set metotları
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

        // Ekrana bilgi yazdırma 
        public void BilgiYazdir() 
        {
            Console.WriteLine($"Ad - Soyad: {Ad} {Soyad}");
        }   

    }


    // Öğrenci sınıfı tanımlama (BaseKisi sınıfından türeyen)
    public class Ogrenci : BaseKisi
    {

        // Private Alan
        private int ogrenciNumarasi;

        // Öğrenci sınıfının constructor'ı ve "base" anahtar kelimesi üst sınıfın özelliklerine erişmek için kullanıldı (super() vb.)
        public Ogrenci(string ad, string soyad, int ogrenciNumarasi)
            :base(ad, soyad) 
        {
            this.ogrenciNumarasi = ogrenciNumarasi;
        }

        // Public özelliklerin get/set metotları
        public int OgrenciNumarasi
        {
            get { return ogrenciNumarasi; }
            set { ogrenciNumarasi = value; }        
        }


        // Ekrana bilgi yazdırma
        public void OgrenciBilgiYazdir()
        {
            Console.WriteLine($"Ad - Soyad: {Ad} {Soyad}");
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        }
    }

    // Öğretmen sınıfı tanımlama (BaseKisi sınıfından türeyen)
    public class Ogretmen : BaseKisi
    {
        // Private Alan
        private int maasBilgisi;


        // Öğretmen sınıfının constructor'ı ve "base" anahtar kelimesi üst sınıfın özelliklerine erişmek için kullanıldı (super() vb.)
        public Ogretmen(string ad, string soyad, int maasBilgisi)
            :base(ad, soyad) 
        {
            this.maasBilgisi = maasBilgisi;
        }


        // // Public özelliklerin get/set metotları
        public int MaasBilgisi
        {
            get { return maasBilgisi; }
            set { maasBilgisi = value; }
        }


        // Ekrana bilgi yazdırma
        public void OgretmenBilgiYazdir()
        {
            Console.WriteLine($"Ad - Soyad: {Ad} {Soyad}");
            Console.WriteLine($"Öğretmen Maaşı: {maasBilgisi}");
        }
    }
}