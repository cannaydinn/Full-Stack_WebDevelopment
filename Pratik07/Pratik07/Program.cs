
/*
    Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.
*/

// 1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int deger1 = 1;
while(deger1 <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    deger1++;
}
Console.WriteLine("----------------------------------");

// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int deger2 = 2;
while(deger2 < 20)
{
    Console.WriteLine(deger2);
    deger2++;
}
Console.WriteLine("----------------------------------");

// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int deger3 = 2;
while(deger3 < 20)
{
    if(deger3 % 2 == 0)
    {
        Console.WriteLine(deger3);
    }
    deger3++;   
}
Console.WriteLine("----------------------------------");

// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int deger4 = 51;
int toplam = 0;
while (deger4 < 150)
{
    toplam += deger4;
    deger4++;
}
Console.WriteLine(toplam);
Console.WriteLine("----------------------------------");

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int tekSayiToplam = 0, ciftSayiToplam = 0;
int deger5 = 2;
while (deger5 < 120)
{
    if (deger5 % 2 == 0) {
        ciftSayiToplam += deger5;
    }
    else
    {
        tekSayiToplam += deger5;
    }
    deger5++;   
}
Console.WriteLine("Çift Sayıların Toplamı: "+ciftSayiToplam);
Console.WriteLine("Tek Sayıların Toplamı: "+tekSayiToplam);