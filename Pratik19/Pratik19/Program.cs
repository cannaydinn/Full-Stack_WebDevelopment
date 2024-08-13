

//  Pratik - Array
//  Bu pratikte aşağıdaki 4 aşamayı kodlamanız isteniyor.

//  1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
int[] sayilar = new int[10];

// *******************************************************************

//  2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
int[] sayilar1 = new int[5];
for (int i = 0; i < sayilar1.Length; i++)
{
    Console.Write(i + 1 + ". değeri giriniz: ");
    sayilar1[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int sayi in sayilar1)
{
    Console.WriteLine(sayi);
}

// *******************************************************************


//  3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
// Başlangıçta 10 elemanlı bir dizi oluşturuyoruz
int[] sayilar2 = new int[10];

// Kullanıcıdan diziyi doldurmasını istiyoruz
for (int i = 0; i < sayilar2.Length; i++)
{
    Console.Write($"Dizinin {i + 1}. elemanını giriniz: ");
    sayilar2[i] = Convert.ToInt32(Console.ReadLine());
}

// Kullanıcıdan yeni bir eleman almamız gerekiyor
Console.Write("Diziye eklemek istediğiniz yeni değeri giriniz: ");
int yeniDeger = Convert.ToInt32(Console.ReadLine());

// Yeni bir dizi oluşturuyoruz, bir eleman daha büyük
int[] yeniDizi = new int[sayilar2.Length + 1];

// Eski diziyi yeni diziye kopyalıyoruz
for (int i = 0; i < sayilar2.Length; i++)
{
    yeniDizi[i] = sayilar2[i];
}

// Yeni elemanı dizinin sonuna ekliyoruz
yeniDizi[yeniDizi.Length - 1] = yeniDeger;

// Güncellenmiş diziyi ekrana yazdırıyoruz
Console.WriteLine("Güncellenmiş dizi elemanları:");
foreach (int sayi in yeniDizi)
{
    Console.WriteLine(sayi);
}

// *******************************************************************

//  4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.

Array.Sort(yeniDizi);
Array.Reverse(yeniDizi);
Console.WriteLine("Büyükten küçüğe sıralanmış hali");
foreach (int i in yeniDizi)
{
    Console.WriteLine(i);
}