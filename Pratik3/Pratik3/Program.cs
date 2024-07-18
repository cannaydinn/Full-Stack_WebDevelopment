/*
    konsol ekranı yardımıyla kullanıcıdan bir sayı değeri almanızı, 
    bu değerin 10'a eşit mi , 10'dan küçük mü, 10'dan büyük mü olduğu durumları 
    kontrol ederek kullanıcıya bir bilgilendirme mesajı yazmanız isteniyor.

    Ardından 2. bir kontrol yapısıyla girilen sayının çift mi yoksa tek mi 
    olduğunu ekrana yazdırınız.
 
 */

int sayi;

Console.Write("Lütfen bir sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

if(sayi == 10)
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}
else if(sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else if(sayi > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}

if(sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}