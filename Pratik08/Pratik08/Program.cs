

/*
    Bu pratikte aynı sorunun cevabını hem while hem de do-while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.

    Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
 
 */

// While döngüsünde koşulun doğru olması gerekir ancak do-while döngüsünde bir kez do bloğu çalışır ardından koşulun doğru olup olmadığına bakılır

// While Döngüsü

int whileLimit, whileSayac = 0;
Console.Write("Lütfen bir limit sayısı giriniz: ");
whileLimit = Convert.ToInt32(Console.ReadLine());

while (whileSayac <= whileLimit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    whileSayac++;
}

// do-while döngüsü

int doWhileLimit, doWhileSayac = 0;
Console.WriteLine("Lütfen bir limit sayısı giriniz: ");
doWhileLimit = Convert.ToInt32(Console.ReadLine());
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    doWhileSayac++;
}
while (doWhileSayac <= doWhileLimit);
