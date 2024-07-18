


/* 
   Kullanıcıya T.C Kimlik Numarasını, adını, soyadını, telefon numarasını,
   yaşını, ilk aldığı ürünün fiyatını, ikinci aldığını ürünün fiyatını soran 
   ve bu değerleri kullanıcıdan sırasıyla alan bir uygulama kodladım.
*/

// Ürün fiyatları herzaman tam sayı olmayabilir o yüzden double tanımladım
// Telefon numarasını girilen formattan başka bir formata çevirmek istersek diye string tanımladım
double ilkUrunFiyati, ikinciUrunFiyati, toplamFiyat, patikaPuan;
string ad, soyad, telefonNo, kimlikNo;
int yas;

Console.WriteLine("Lütfen aşşağıdaki bilgileri giriniz:");
Console.Write("T.C. Kimlik numarası: ");
kimlikNo = Console.ReadLine();

Console.Write("Adı: ");
ad = Console.ReadLine();

Console.Write("Soyadı: ");
soyad = Console.ReadLine();

Console.Write("Telefon Numarası: ");
telefonNo = Console.ReadLine();

Console.Write("Yaş: ");
yas = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk Aldığı Ürünün Fiyatı: ");
ilkUrunFiyati = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
ikinciUrunFiyati = Convert.ToDouble(Console.ReadLine());

toplamFiyat = ilkUrunFiyati + ikinciUrunFiyati;
patikaPuan = (toplamFiyat * 10) / 100;


Console.WriteLine("------------------------------------------");

Console.WriteLine($"{kimlikNo} T.C. numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{telefonNo} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{toplamFiyat} toplam harcama karşılığı kazanılan 10% patika puan miktarı --> {patikaPuan} TL'dir.");