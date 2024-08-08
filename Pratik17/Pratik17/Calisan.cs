using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pratik17
{

    // Base sınıf
    public abstract class Calisan
    {
        // Sınıfın field'ları
        private string ad;
        private string soyad;
        private string departman;


        // Consturctor
        public Calisan(string ad, string soyad, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.departman = departman;
        }


        // Sınıfın get/set metotları
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

        public string Departman
        {
            get { return departman; }
            set { departman = value; }
        }

        // Abstract metot (Alt Sınıflarda ezilmesi gerekiyor)
        public abstract void Gorev();

    }


    //Yazılım Geliştirici sınıfı (Çalışan sınıfından türetildi)
    public class YazilimGelistirici : Calisan
    {
        // Constructor
        public YazilimGelistirici(string ad, string soyad, string departman)
            : base(ad, soyad, departman)
        { }

        // Çalışan sınıfının Gorev() metodunun ezilmesi
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Yazılım Geliştiricisi, Yazılım Geliştirici olarak çalışıyorum.");
        }
    }


    //Proje Yöneticisi sınıfı (Çalışan sınıfından türetildi)
    public class ProjeYoneticisi : Calisan
    {

        // Constructor
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman)
        { }

        // Çalışan sınıfının Gorev() metodunun ezilmesi
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Proje Yöneticisi, Proje Yöneticisi olarak çalışıyorum.");
        }
    }

    //Satış Temsilcisi sınıfı (Çalışan sınıfından türetildi)

    public class SatisTemsilcisi : Calisan
    {

        // Constructor
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }


        // Çalışan Sınıfının Gorev Metodunun ezilmesi
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Satış Temsilcisi, Satış Temsilcisi olarak çalışıyorum.");
        }
    }
}
