using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik18
{
    public class Telefon : BaseMakine
    {
        private bool trLisansliMi;
        public Telefon(DateTime uretimTarihi)
            : base (uretimTarihi)  
        {

        }

       public bool TrLisansliMi
        {
            get { return trLisansliMi; }
            set { trLisansliMi = value; }
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanlı {(trLisansliMi ? "Evet" : "Hayır")}");

        }


        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun Adı --> {Ad}");
        }


    }
}
