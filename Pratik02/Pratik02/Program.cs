/*
    Kullanıcıya T.C Kimlik Numarasını, adını, soyadını , telefon numarasını, 
    yaşını, ilk aldığı ürünün fiyatını, 
    ikinci aldığını ürünün fiyatını soran ve bu değerleri kullanıcıdan 
    sırasıyla alan bir uygulama kodladım.
*/

//  Telefon numarasını farklı bir formata değiştirmek istersek diye string tanımladım.
//  Ürün fiyatları herzaman tam sayı olmayacağından double tanımladım.

double ilkUrunFiyati, ikinciUrunFiyati, fiyatToplam, patikaPuan;
string ad, soyad, telNo, kimlikNo;
int yas;

Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");
Console.Write("T.C. kimlik Numarası: ");
kimlikNo = Console.ReadLine();

Console.Write("Adı: ");
ad = Console.ReadLine();

Console.Write("Soyadı: ");
soyad = Console.ReadLine();

Console.Write("Telefon Numarası: ");
telNo = Console.ReadLine();

Console.Write("Yaş: ");
yas = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk Ürünün Fiyatı: ");
ilkUrunFiyati = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci Ürünün Fiyatı: ");
ikinciUrunFiyati= Convert.ToDouble(Console.ReadLine());

fiyatToplam = ilkUrunFiyati + ikinciUrunFiyati;

patikaPuan = (fiyatToplam * 10) / 100;

Console.WriteLine("-----------------------------------------");

Console.WriteLine($"{kimlikNo} T.C. numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{telNo} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{fiyatToplam} toplam harcama karşılığı kazanılan 10% patika puan miktarı --> {patikaPuan} TL'dir.");



