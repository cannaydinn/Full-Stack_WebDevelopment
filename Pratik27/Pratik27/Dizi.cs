using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik27
{
    public class Dizi
    {

        // Sınıfın fieldları
        private string diziAdi;
        private int yapimYili;
        private string diziTuru;
        private int yayinTarihi;
        private string yonetmen;
        private string yayinPlatformu;

        // Sınıfın get/set metotları
        public string DiziAdi
        {
            get { return diziAdi; }
            set { diziAdi = value; }
        }

        public int YapimYili
        {
            get { return yapimYili; }
            set { yapimYili = value; }
        }

       public string DiziTuru
        {
            get { return diziTuru; }
            set { diziTuru = value; }
        }

        public int YayinTarihi
        {
            get { return yayinTarihi; }
            set { yayinTarihi = value; }
        }

        public string Yonetmen
        {
            get { return yonetmen; }
            set { yonetmen = value; }
        }

        public string YayinPlatformu
        {
            get { return yayinPlatformu; }
            set { yayinPlatformu = value; }
        }
    }
}
