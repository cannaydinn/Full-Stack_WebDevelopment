// Liste tanımlama
List<int> list = new List<int>();

// Rastgele 10 adet sayı üretimi ve listeye atama
Random random = new Random();
for(int i = 0; i < 10; i++)
{
    int randomSayilar = random.Next(-10, 50);

    // Aynı sayı üretimini engeller
    if (!list.Contains(randomSayilar))
    {
        list.Add(randomSayilar);
    }
}

// Liste elemanlarını yazdırma
Console.WriteLine("---- Liste Elemanları ----");
foreach (int liste in list)
{
    Console.WriteLine(liste);
}

// LINQ ile çift sayılar
var ciftSayi = list.Where(x => x % 2 == 0);
Console.WriteLine(" ---- Çift Sayılar -----");
foreach (var cift in ciftSayi)
{
    Console.WriteLine(cift);
}

// LINQ ile tek sayılar
var tekSayi = list.Where(x => x % 2 != 0);
Console.WriteLine(" ---- Tek Sayılar -----");
foreach (var tek in tekSayi)
{
    Console.WriteLine(tek);
}

// LINQ ile negatif sayılar
var negatifSayi = list.Where(x => x < 0);
Console.WriteLine(" ---- Negatif Sayılar -----");
foreach (var negatif in negatifSayi)
{
    Console.WriteLine(negatif);
}

// LINQ ile pozitif sayılar
var pozitifSayi = list.Where(x => x > 0);
Console.WriteLine(" ---- Pozitif Sayılar -----");
foreach (var pozitif in pozitifSayi)
{
    Console.WriteLine(pozitif);
}

// LINQ ile 15'ten büyük ve 22'den küçük sayılar
var sayilar = list.Where(x => x > 15 && x < 22);
Console.WriteLine(" ---- 15'ten büyük ve 22'den küçük Sayılar -----");
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// LINQ ile sayıların karesi
var sayiKaresi = list.Select(x => x * x);
Console.WriteLine(" ---- Sayıların Karesi -----");
foreach (var sayiKareleri in sayiKaresi)
{
    Console.WriteLine(sayiKareleri);
}