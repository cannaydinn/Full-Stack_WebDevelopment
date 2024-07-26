/*
    İlk Metot Uygulamamız
 */


// Geriye Değer Döndürmeyen Bir void metot.
void SarkiSozu()
{
    Console.WriteLine("Bir sevmek bin defa ölmek demekmiş...");
}
// Metodun çağrılması
SarkiSozu();

Console.WriteLine("----------------------------------------------");

// Geriye Tamsayı Döndüren Bir metot
int BolumdenKalan()
{
    Random random = new Random();
    int rastgeleSayi = random.Next();
    return rastgeleSayi % 2;
}
// Metodun çağrılması ve atama işlemi
int bolumdenKalan = BolumdenKalan();
Console.WriteLine(bolumdenKalan);

Console.WriteLine("----------------------------------------------");

// Parametre Alan ve Geriye Değer Döndüren Bir Metot
// Metodun çağrılması ve atama işlemi
int carpim = CarpmaIslemi(2,5);
Console.WriteLine(carpim);

int CarpmaIslemi(int sayi1, int sayi2)
{
    return sayi1* sayi2;
}
Console.WriteLine("----------------------------------------------");

// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
// Metodun çağrılması
Selamlama("Can", "Aydın");
void Selamlama(string ad, string soyad)
{
    Console.WriteLine($"Hoş Geldiniz {ad} {soyad}");
}