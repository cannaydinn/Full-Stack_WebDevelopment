using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik18
{
    // Telefon sınıfı (BaseMakine sınıfından türetildi)
    public class Telefon : BaseMakine
    {
        // Telefon sınıfının field'ları
        private bool trLisansliMi;

        // Constructor
        public Telefon(DateTime uretimTarihi)
            : base (uretimTarihi)  
        {

        }


        // Sınıfın get/set metotları
       public bool TrLisansliMi
        {
            get { return trLisansliMi; }
            set { trLisansliMi = value; }
        }


        // Base sınıfının metotu ezilmesi
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanlı {(trLisansliMi ? "Evet" : "Hayır")}");

        }

        // Base sınıfının metotu ezilmesi
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun Adı --> {Ad}");
        }


    }
}
