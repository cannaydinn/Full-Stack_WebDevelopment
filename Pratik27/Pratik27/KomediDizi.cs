using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik27
{
    public class KomediDizi
    {

        // Sınıfın fieldları
        private string diziAdi;
        private string diziTuru;
        private string yonetmen;


        // Constructor
        public KomediDizi(string diziAdi, string diziTuru, string yonetmen)
        {
            this.diziAdi = diziAdi;
            this.diziTuru = diziTuru;
            this.yonetmen = yonetmen;
        }


        // Sınıfın get/set metotları
        public string DiziAdi
        {
            get { return diziAdi; }
            set { diziAdi = value; }
        }

        public string DiziTuru
        {
            get { return diziTuru; }
            set { diziTuru = value; }
        }

        public string Yonetmen
        {
            get { return yonetmen; }
            set { yonetmen = value; }
        }


        // ToString() metodunun ezilmesi
        public override string ToString() 
        {
            return $"Dizi Adı: {DiziAdi}, Tür: {DiziTuru}, Yönetmen: {Yonetmen}";
        }
    }
}
