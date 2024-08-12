
using Pratik18;

bool devamEt = true;
int cihazUretim;
while (devamEt)
{
    Console.WriteLine("Ürün üretmek için bir seçenek seçin:");
    Console.WriteLine("1 - Telefon Üret");
    Console.WriteLine("2 - Bilgisayar Üret");
    Console.Write("Seçiminiz: ");
    cihazUretim = Convert.ToInt32(Console.ReadLine());

    switch (cihazUretim)
    {
        case 1:
            Telefon telefon = new Telefon(DateTime.Now);

            Console.Write("Ürünün adını giriniz: ");
            telefon.Ad = Console.ReadLine();

            Console.Write("İşletim Sistemini giriniz: ");
            telefon.IsletimSistemi = Console.ReadLine();

            Console.Write("Açıklamasını giriniz: ");
            telefon.Aciklama = Console.ReadLine();

            Console.Write("Seri Numarasını giriniz: ");
            telefon.SeriNumarasi = Console.ReadLine();

            Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
            string trLisansliMi = Console.ReadLine().ToLower();
            telefon.TrLisansliMi = trLisansliMi == "evet";

            telefon.BilgileriYazdir();
            telefon.UrunAdiGetir();
            break;
        case 2:
            Bilgisayar bilgisayar = new Bilgisayar(DateTime.Now);

            Console.Write("Ürünün adını giriniz: ");
            bilgisayar.Ad = Console.ReadLine();

            Console.Write("İşletim sistemini giriniz: ");
            bilgisayar.IsletimSistemi = Console.ReadLine();

            Console.Write("Açıklamasını giriniz: ");
            bilgisayar.Aciklama = Console.ReadLine();

            Console.Write("Seri numarasını giriniz: ");
            bilgisayar.SeriNumarasi = Console.ReadLine();

            Console.Write("USB soket Sayısı: ");
            bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bluetooth var mı? (Var/Yok): ");
            string bluetoothVarMi = Console.ReadLine().ToLower();
            bilgisayar.BluetoothVarMi = bluetoothVarMi == "var";

            bilgisayar.BilgileriYazdir();
            bilgisayar.UrunAdiGetir();
            break;
        default:
            Console.WriteLine("Geçersiz bir değer girdiniz!!!");
            break;
    }

    Console.Write("Başka bir ürün üretmek ister misiniz? (Evet/Hayır): ");
    string devam = Console.ReadLine().ToLower();

    if (devam == "evet")
        devamEt = true;
    else
        devamEt = false;

   
}
Console.WriteLine("İyi Günler Dileriz...");



