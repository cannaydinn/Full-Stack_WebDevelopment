using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik24
{
    public class Araba
    {
        // Araba sınıfının fieldları
        private DateTime uretimTarihi;
        private string seriNumarasi;
        private string marka;
        private string model;
        private string renk;
        private int kapiSayisi;


        // Constructor
        public Araba(DateTime uretimTarihi)
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
            set { kapiSayisi = value; }
        }
    }
}
