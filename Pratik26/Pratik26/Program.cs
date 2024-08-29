
using Pratik26;


// Sarkici sınıfından nesne üreterek Listeye atama işlemi
List<Sarkici> sarkiciListesi = new List<Sarkici>
{
    new Sarkici("Ajda Pekkan", "Pop", 1968, 20000000) ,
    new Sarkici("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10000000),
    new Sarkici("Funda Akar", "Pop", 1999, 3000000),
    new Sarkici("Sertab Erener", "Pop", 1994, 5000000),
    new Sarkici("Sıla", "Pop", 2009, 3000000),
    new Sarkici("Serdar Ortaç", "Pop", 1994, 10000000),
    new Sarkici("Tarkan", "Pop", 1992, 40000000),
    new Sarkici("Hande Yener", "Pop", 1999, 7000000),
    new Sarkici("Hadise", "Pop", 2005, 5000000),
    new Sarkici("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10000000),
    new Sarkici("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2000000),
};

Console.WriteLine(" **** Liste Elemanları ****");
foreach (var s in sarkiciListesi)
{
    Console.WriteLine(s);
}


// Adı 'S' harfi ile başlayanları listeler
Console.WriteLine("\n **** Adı 'S' harfi ile başlayanlar ****");
var filtreS = sarkiciListesi.Where(x => x.FullName.StartsWith("S"));
foreach (var baslangicS in filtreS)
{
    Console.WriteLine(baslangicS);
}


// Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
Console.WriteLine("\n **** Albüm satışları 10 milyon'un üzerinde olan şarkıcılar ****");
var onMilyonUstu = sarkiciListesi.Where(x => x.SatisAdeti > 10000000);
foreach (var onMilyon in onMilyonUstu)
{
    Console.WriteLine(onMilyon);
}


// 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
Console.WriteLine("\n **** 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar ****");
var cikisYili = sarkiciListesi.Where(x => x.CikisYili < 2000 && x.MuzikTuru.Contains("Pop"))
                              .OrderBy(x => x.FullName)
                              .GroupBy(x => x.CikisYili);

foreach (var grup in cikisYili)
{
    Console.WriteLine($"\nÇıkış Yılı: {grup.Key}");
    foreach (var sarkici in grup)
    {
        Console.WriteLine(sarkici.FullName+", "+sarkici.MuzikTuru+", "+sarkici.SatisAdeti);
    }
}



// En çok albüm satan şarkıcı
Console.WriteLine("\n **** En çok albüm satan şarkıcı ****");
var enCokSatis = sarkiciListesi.OrderByDescending(x => x.SatisAdeti);
Console.WriteLine(enCokSatis.First());


// En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
Console.WriteLine("\n **** En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı ****");
var enEski = sarkiciListesi.OrderByDescending(x => x.CikisYili);
Console.WriteLine($"En yeni çıkış yapan -> {enEski.First()}");
Console.WriteLine($"En eski çıkış yapan -> {enEski.Last()}");


