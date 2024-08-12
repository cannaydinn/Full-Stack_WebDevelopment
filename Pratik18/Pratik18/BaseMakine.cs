using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik18
{
    // Base Sınıf 
    public abstract class BaseMakine
    {
        // Base sınıfın field'ları
        private DateTime uretimTarihi;
        private string seriNumarasi;
        private string ad;
        private string aciklama;
        private string isletimSistemi;

        // Constructor
        public BaseMakine(DateTime uretimTarihi)
        {
            this.uretimTarihi = DateTime.Now;
        }

        // Sınıfın get/set metotları
        public DateTime UretimTarihi
        {
            get { return uretimTarihi; }
            set { uretimTarihi = value; }
        }

        public string SeriNumarasi
        {
            get { return seriNumarasi; }
            set { seriNumarasi = value; }
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }

        public string IsletimSistemi
        {
            get { return isletimSistemi; }
            set { isletimSistemi = value; }
        }

        // Bilgilerin Yazdırılması
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ürün Adı: {ad}, İşletim Sistemi: {isletimSistemi}, Açıklama: {aciklama}, Seri Numarası: {seriNumarasi}, Üretim Tarihi: {uretimTarihi}");
        }


        // Abstract metot oluşturma. Alt sınıflarda metodun ezilmesi gerekli
        public abstract void UrunAdiGetir();


    }
}
