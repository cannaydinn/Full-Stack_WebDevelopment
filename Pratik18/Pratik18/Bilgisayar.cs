using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik18
{

    // Bilgisayar sınıfı (BaseMakine sınfından türetildi) 
    internal class Bilgisayar : BaseMakine
    {
        // Sınıfın field'ları
        private int ubsGirisSayisi;
        private bool bluetoothVarMi;

        // Constructor
        public Bilgisayar(DateTime uretimTarihi) 
            : base(uretimTarihi)
        {

        }


        // Sınıfın get/set metotları
        public int UsbGirisSayisi
        {
            get { return ubsGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    ubsGirisSayisi = value;
                else

                    ubsGirisSayisi = -1;
            }
        }

        public bool BluetoothVarMi
        {
            get { return bluetoothVarMi;}
            set { bluetoothVarMi = value; }
        }


        // Base sınıfının metotu ezilmesi
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}, Bluetooth: {(bluetoothVarMi ? "Var" : "Yok")}");

        }


        // Base sınıfının metodu ezilmesi
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın Adı --> {Ad}");
        }
    }
}
