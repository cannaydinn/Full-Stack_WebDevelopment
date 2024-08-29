using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik26
{
    public class Sarkici
    {
        private string fullName;
        private string muzikTuru;
        private int cikisYili;
        private int satisAdeti;

        public Sarkici(string fullName, string muzikTuru, int cikisYili, int satisAdeti)
        {
            this.fullName = fullName;
            this.muzikTuru = muzikTuru;
            this.cikisYili = cikisYili;
            this.satisAdeti = satisAdeti;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string MuzikTuru
        {
            get { return muzikTuru; }
            set { muzikTuru = value; }
        }

        public int CikisYili
        {
            get { return cikisYili; }
            set { cikisYili = value; }
        }

        public int SatisAdeti
        {
            get { return satisAdeti; }
            set { satisAdeti = value; }
        }

        public override string ToString()
        {
            return $"{FullName}, {MuzikTuru}, {CikisYili}, {SatisAdeti} adet albüm satışı";
        }
    }
}
