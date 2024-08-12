using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik18
{
    public abstract class BaseMakine
    {
        private DateTime uretimTarihi;
        private string seriNumarasi;
        private string ad;
        private string aciklama;
        private string isletimSistemi;

        public BaseMakine(DateTime uretimTarihi)
        {
            this.uretimTarihi = DateTime.Now;
        }

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

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ürün Adı: {ad}, İşletim Sistemi: {isletimSistemi}, Açıklama: {aciklama}, Seri Numarası: {seriNumarasi}, Üretim Tarihi: {uretimTarihi}");
        }

        public abstract void UrunAdiGetir();


    }
}
