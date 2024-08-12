
using Pratik18;

// Değişken tanımlama ve atama işlemleri
bool devamEt = true;
int cihazUretim;

// Programa tekrar devam etmek istendiğinde devam eder
while (devamEt)
{
    Console.WriteLine("Ürün üretmek için bir seçenek seçin:");
    Console.WriteLine("1 - Telefon Üret");
    Console.WriteLine("2 - Bilgisayar Üret");
    Console.Write("Seçiminiz: ");
    cihazUretim = Convert.ToInt32(Console.ReadLine());

    // Konsoldan girilen değere göre seçim işlmei
    switch (cihazUretim)
    {
        case 1:
            //Telefon sınıfından nesne üretimi
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

            // Metotların çağrılması
            telefon.BilgileriYazdir();
            telefon.UrunAdiGetir();
            break;
        case 2:

            //Bilgisayar sınıfından nesne üretimi
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

            // Metotların çağrılması
            bilgisayar.BilgileriYazdir();
            bilgisayar.UrunAdiGetir();
            break;
        default:
            Console.WriteLine("Geçersiz bir değer girdiniz!!!");
            break;
    }

    Console.Write("Başka bir ürün üretmek ister misiniz? (Evet/Hayır): ");
    string devam = Console.ReadLine().ToLower();

    // programa devam etmek istemediğinin sorulması
    if (devam == "evet")
        devamEt = true;
    else
        devamEt = false;

   
}
Console.WriteLine("İyi Günler Dileriz...");



