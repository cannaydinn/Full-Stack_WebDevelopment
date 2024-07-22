/*
    Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları for kullanarak yapınız.
 */

//  1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i+". Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("-----------------------------------------");

//  2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
for (int i=2; i < 20; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------");

// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
for(int i=2; i < 20; i++)
{
    if(i % 2 == 0)
        Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------------");

// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
for(int i=51;i < 150; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);
Console.WriteLine("-----------------------------------------");

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int tekSayiToplam = 0, ciftSayiToplam = 0;
for(int i=2; i < 120; i++)
{
    if(i % 2 == 0)
    {
        ciftSayiToplam += i;
    }
    else
    {
        tekSayiToplam += i;
    }
}
Console.WriteLine(ciftSayiToplam);
Console.WriteLine(tekSayiToplam);