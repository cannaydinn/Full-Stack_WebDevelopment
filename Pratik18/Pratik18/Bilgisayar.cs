using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik18
{
    internal class Bilgisayar : BaseMakine
    {

        private int ubsGirisSayisi;
        private bool bluetoothVarMi;
        public Bilgisayar(DateTime uretimTarihi) 
            : base(uretimTarihi)
        {

        }

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

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}, Bluetooth: {(bluetoothVarMi ? "Var" : "Yok")}");

        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın Adı --> {Ad}");
        }
    }
}
