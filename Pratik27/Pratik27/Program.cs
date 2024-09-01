using Pratik27;


// Dizi sınıfından nesne üretimi, dizi sınıfı tipinde liste tanımlama
List<Dizi> diziListesi = new List<Dizi>();
Dizi dizi = new Dizi();


string programAkisi = "";
do
{
    // Konsol ekranından değerlerin girilmesi
    Console.Write("Dizinin adını giriniz: ");
    dizi.DiziAdi = Console.ReadLine();

    Console.Write("Dizinin yapım yılını giriniz: ");
    dizi.YapimYili = Convert.ToInt32(Console.ReadLine());

    Console.Write("Dizinin Türünü giriniz: ");
    dizi.DiziTuru = Console.ReadLine();

    Console.Write("Dizinin yayınlanmaya başlama tarihini giriniz: ");
    dizi.YayinTarihi = Convert.ToInt32(Console.ReadLine());

    Console.Write("Yönetmen adını giriniz: ");
    dizi.Yonetmen = Console.ReadLine();

    Console.Write("Dizinin yayınlandığı platformu giriniz: ");
    dizi.YayinPlatformu = Console.ReadLine();

    Console.Write("\nYeni bir dizi eklemek ister misiniz? (E/H): ");
    programAkisi = Console.ReadLine().ToUpper();

    // Konsol ekranından alınan verilerin listeye eklenmesi
    diziListesi.Add(dizi);
}
while (programAkisi == "E");


// Komedi dizilerinin listesini oluşturma
List<KomediDizi> komediDiziListesi = diziListesi
    .Where(x => x.DiziTuru.Contains("Komedi"))
    .Select(x => new KomediDizi(x.DiziAdi, x.DiziTuru, x.Yonetmen))
    .OrderBy(x => x.DiziAdi)       
    .ThenBy(x => x.Yonetmen)
    .ToList();

// 
Console.WriteLine(" **** Tüm Diziler ****");
foreach(var diziList in diziListesi)
{
    Console.WriteLine(diziList);
}

// Komedi dizilerini ekrana yazdırma
Console.WriteLine("\n**** Komedi Dizileri ****");
foreach (var komediDizi in komediDiziListesi)
{
    Console.WriteLine(komediDizi);
}
