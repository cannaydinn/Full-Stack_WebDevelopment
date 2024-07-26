/*
    1 - Aşağıdaki çıktıyı yazan bir program.

    Merhaba
    Nasılsın ?
    İyiyim
    Sen nasılsın ?
*/
using System.Threading.Channels;

Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");
Console.WriteLine("---------------------------------");


//  2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
string metin = "Herkese selam, Ben Can Aydın";
int tamSayi = 10;

Console.WriteLine($"{metin}\n{tamSayi}");
Console.WriteLine("---------------------------------");


//  3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random random = new Random();
int rastgeleSayi = random.Next();
Console.WriteLine("Rastgele sayı üretimi: "+rastgeleSayi);
Console.WriteLine("---------------------------------");


//  4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random random1 = new Random();
int rastgeleSayi1 = random1.Next();
int kalan = rastgeleSayi1 % 3;
Console.WriteLine($"{rastgeleSayi1} sayısının 3 ile bölümünden kalan: "+kalan);
Console.WriteLine("---------------------------------");


//  5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
int yas;

Console.Write("Lütfen yaşınızı giriniz: ");
yas = Convert.ToInt32(Console.ReadLine());

if(yas >= 18)
    Console.WriteLine("+");
else
    Console.WriteLine("-");
Console.WriteLine("---------------------------------");


//  6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("---------------------------------");


//  7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
string metin1, metin2, yeniMetin;

Console.Write("İlk metni giriniz: ");
metin1 = Console.ReadLine();

Console.Write("İkinci metni giriniz: ");
metin2 = Console.ReadLine();

Console.WriteLine("Girdiğiniz metin sıralaması: "+metin1+", "+metin2);
yeniMetin = metin1;
metin1 = metin2;
metin2 = yeniMetin;
Console.WriteLine("\nYeni metin sıralaması: "+metin1+", "+metin2);
Console.WriteLine("---------------------------------");


//  8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni bir değişkene atamaya çalışma");
}
BenDegerDondurmem(); 
Console.WriteLine("---------------------------------");


//  9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int toplam = ToplamaIslemi(10, 5);
int ToplamaIslemi(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
Console.WriteLine("sayıların toplamı: "+toplam);
Console.WriteLine("---------------------------------");


//  10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
Console.WriteLine("Lütfen True ya da False değeri giriniz: ");




//  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
int yas1, yas2, yas3;
Console.Write("1. kişi Lütfen yaşınızı giriniz: ");
yas1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. kişi Lütfen yaşınızı giriniz: ");
yas2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. kişi Lütfen yaşınızı giriniz: ");
yas3 = Convert.ToInt32(Console.ReadLine());

int enBuyukYas = EnBuyukYas(yas1, yas2, yas3);

int EnBuyukYas(int yas1, int yas2, int yas3)
{
    if (yas1 > yas2 && yas1 > yas3)
        return yas1;
    else if (yas2 > yas1 && yas2 > yas3)
        return yas2;
    else
        return yas3;
}
Console.WriteLine("En Yaşlı kişinin yaşı: "+enBuyukYas);
Console.WriteLine("---------------------------------");


//  12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

int enBuyukSayi = EnBuyukSayiBulma();
Console.WriteLine("Girilen En Büyük Sayı: "+enBuyukSayi);
int EnBuyukSayiBulma()
{
    int enBuyukSayi = int.MinValue;
    while (true)
    {
        Console.Write("Bir sayı girin (Çıkmak için 'q' tuşuna basın): ");
        string input = Console.ReadLine();

        // Çıkmak için 'q' tuşuna basılmasını kontrol et
        if (input.ToLower() == "q")
        {
            break;
        }

        // Girdiyi tam sayıya dönüştürmeye çalış
        if (int.TryParse(input, out int number))
        {
            // Sayıyı en büyük sayı ile karşılaştır
            if (number > enBuyukSayi)
            {
                enBuyukSayi = number;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin.");
        }
    }
    return enBuyukSayi;
}
Console.WriteLine("---------------------------------");


//  13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
string isim1, isim2;

Console.Write("İlk ismi giriniz: ");
isim1 = Console.ReadLine();

Console.Write("İkinci ismi giriniz: ");
isim2 = Console.ReadLine();

Console.WriteLine("Girdiğiniz isim sıralaması: " + isim1 + ", " + isim2);


void YerDegistirme(string isim1, string isim2)
{
    string yeniIsim;
    yeniIsim = isim1;
    isim1 = isim2;
    isim2 = yeniIsim;
    Console.WriteLine("Yeni isim sıralaması: "+isim1+", "+isim2);
}
YerDegistirme(isim1, isim2);
Console.WriteLine("---------------------------------");


//  14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
int sayi;

Console.WriteLine("Lütfen bir sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());
bool CiftMiTekMi(int number)
{
    if (sayi % 2 == 0)
        return true;
    else
        return false;
}
Console.WriteLine("Girilen Sayı (çift = true/ tek = false): "+CiftMiTekMi(sayi));
Console.WriteLine("---------------------------------");


//  15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
int hiz, zaman;

Console.Write("Lütfen Hız ve zaman değerini sırası ile giriniz: ");
hiz = Convert.ToInt32(Console.ReadLine());
zaman = Convert.ToInt32(Console.ReadLine());

int GidilenYolHesapla(int hiz, int zaman)
{
    int gidilenYol = hiz * zaman;
    return gidilenYol;
}
int gidilenYol = GidilenYolHesapla(hiz, zaman);
Console.WriteLine("Katedilen yol: "+gidilenYol);
Console.WriteLine("---------------------------------");


//  16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
const double PI = Math.PI;
double yariCap;

Console.Write("Lütfen yarıçap bilgisini giriniz: ");
yariCap = Convert.ToDouble(Console.ReadLine());
void DaireAlanHesapla(double yariCap)
{
    double daireAlan = PI * (Math.Pow(yariCap,2));
    Console.WriteLine($"Yarıçapı {yariCap} olan dairenin alanı: "+daireAlan);
}
DaireAlanHesapla(yariCap);
Console.WriteLine("---------------------------------");


//  17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string cumle = "Zaman bir GeRi SayIm";

Console.WriteLine("Cümlenin büyük harflerle yazılışı: "+cumle.ToUpper());
Console.WriteLine("Cümlenin küçük harflerle yazılışı: " + cumle.ToLower());
Console.WriteLine("---------------------------------");


//  18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string kelime = "    Selamlar   ";
string yeniKelime =  kelime.Trim();
Console.WriteLine(yeniKelime);