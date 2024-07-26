using System.Threading.Channels;

/*
    Yol Arkadaşı : Tatil uygulaması

    Bu pratikte bir yardımcı seyehat uygulaması ile kullanıcılarımızın planlayacakları 3 günlük bir tatilde harcayacakları yaklaşık tutarı hesaplamalarına yardımcı oluyoruz.

 */

// Değişkenlerim tanımlanması
string lokasyon = "", ulasimTuru = "";
int kisiSayisi, lokasyonFiyati = 0, ulasimFiyati = 0, toplamFiyat = 0;
bool lokasyonSecimi = false, ulasimSecimi = false, genelDurum = false;


while (!genelDurum)
{
    Console.WriteLine("Yol Arkadaşı - Tatil Uygulamasına Hoş Geldiniz..\n");
    Console.WriteLine("3 adet lokasyonumuz bulunmaktadır:");
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL");
    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL");
    Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL");
    Console.Write("Lütfen gitmek istediğiniz lokasyonu giriniz: ");

    // Lokasyon seçimi
    while (!lokasyonSecimi)
    {
        lokasyon = Console.ReadLine().ToUpper();
        if (lokasyon == "BODRUM")
        {
            lokasyonSecimi = true;
            lokasyonFiyati = 4000;
            Console.WriteLine($"{lokasyon}'da Akvaryum Koyu'na, Bodrum Kalesi'ne, Bodrum Antik Tiyatrosun'na gidebilirsiniz... ");
        }
        else if (lokasyon == "MARMARİS")
        {
            lokasyonSecimi = true;
            lokasyonFiyati = 3000;
            Console.WriteLine($"{lokasyon}'te Turgut Şelalesi'ne, Kleopatra Adası'na (Sedir Adası), Knidos Antik Kenti'ne gidebilirsiniz... ");
        }
        else if (lokasyon == "ÇEŞME")
        {
            lokasyonSecimi = true;
            lokasyonFiyati = 5000;
            Console.WriteLine($"{lokasyon}'de Altınkum Plajı'na, Ilıca Plajı'na gidebilirsiniz... ");
        }
        else
        {
            lokasyonSecimi = false; // False ataması hem sonsuz döngüye girmemesi hem de tekrar while döngüsüne girmesini istememiz
            Console.WriteLine("\nYanlış seçim yaptınız!!");
            Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL");
            Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL");
            Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL");
            Console.Write("Lütfen tekrar gitmek istediğiniz lokasyonu giriniz: ");
        }
    }


    // Tatil için konsoldan kişi sayısı alımı
    Console.Write("\nKaç kişi için tatil planlamak istiyorsunuz? : ");
    kisiSayisi = Convert.ToInt32(Console.ReadLine());

    // Ulaşım türü seçim işlemi
    Console.WriteLine("\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL ");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL");
    Console.Write("Lokasyona hangi ulaşım türü ile gitmek istersiniz? (Lütfen yukarıdaki seçeneklerden 1/2 şeklinde seçim yapınız!!) : ");

    while (!ulasimSecimi)
    {
        ulasimTuru = Console.ReadLine();
        switch (ulasimTuru)
        {
            case "1":
                ulasimTuru = "Kara Yolu";
                ulasimFiyati = 1500;
                ulasimSecimi = true;
                break;
            case "2":
                ulasimTuru = "Hava Yolu";
                ulasimFiyati = 4000;
                ulasimSecimi = true;
                break;
            default:
                Console.WriteLine("Yanlış seçim yaptınız!!");
                Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 ");
                Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL");
                Console.Write("Lütfen tekrar seçim yapınız: ");
                ulasimSecimi = false;
                break;

        }

    }
    
    // Toplam fiyatın hesaplanıp Konsol ekranına yazdırılması
    toplamFiyat = kisiSayisi * (lokasyonFiyati + ulasimFiyati);
    Console.WriteLine("\nYaptığınız seçimler doğrultusunda: "+kisiSayisi+" kişi "+ulasimTuru+" ile gideceğiniz "+lokasyon+" tatiline ödenecek tutar: "+toplamFiyat+" TL'dir.\n\n");

    // Programın yeni baştan çalıştırılması ya da çıkış işlemi
    Console.WriteLine("Yeni bir tatil planı oluşturmak için 1'e");
    Console.WriteLine("Çıkış yapmak için 2'ye basınız: ");
    int yeniPlan = Convert.ToInt32(Console.ReadLine());
    
    if (yeniPlan == 1)
    {
        genelDurum = false; 
    }
    else
    {
        Console.WriteLine("Bizi seçtiğiniz için teşekkür ederiz. İyi günler dileriz!!!");
        genelDurum = true;
    }

}