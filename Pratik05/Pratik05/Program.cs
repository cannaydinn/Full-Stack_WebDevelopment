

/*
   - Kim Milyoner Olmak İster ?
   - Bir bilgi yarışması yapıyoruz!

   - 2 cevap şıklı 3 adet sorumuz var !
   - Yarışmacı 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik 
     büyük ödülü kazanacak!
*/

string ilkSoruCevap, ikinciSoruCevap, ucuncuSoruCevap;
int dogruSoruSayisi = 0;
Console.WriteLine(" Kim Milyoner Olmak ister Yarışmasına Hoşgeldiniz! ");
Console.WriteLine(" İlk sorumuz geliyor");
Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?\n\n a) Lama  b) Deve ");
ilkSoruCevap = Console.ReadLine().ToLower();
if(ilkSoruCevap == "a")
{
    Console.WriteLine("Doğru Cevap!! Sıradaki Sorumuz gelsin");
    dogruSoruSayisi += 1;
    
}
else
{
    Console.WriteLine("Yanlış cevap!! Sıradaki Sorumuz gelsin");
}

Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?\n\n a) Venüs  b) Mars ");
ikinciSoruCevap = Console.ReadLine().ToLower();
if(ikinciSoruCevap == "a")
{
    Console.WriteLine("Doğru Cevap!!");
    dogruSoruSayisi += 1;
    if(dogruSoruSayisi == 2)
    {
        Console.WriteLine("Tebrikler 1 Milyon TL'lik Ödülü Kazandınız!!");
    }
    else if (dogruSoruSayisi == 1)
    {
        Console.WriteLine("Sıradaki sorumuz gelsin");
        Console.WriteLine(" 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?\n\n a) 7  b) 12 ");
        ucuncuSoruCevap = Console.ReadLine().ToLower();
        if(ucuncuSoruCevap == "b")
        {
            dogruSoruSayisi += 1;
            Console.WriteLine("Tebrikler 1 Milyon TL'lik Ödülü Kazandınız!!");
        }
        else
            Console.WriteLine("Üzgünüm Ödül Kazanamadınız!!");
    }
}
else
    Console.WriteLine("Üzgünüm Ödül Kazanamadınız!! ");












