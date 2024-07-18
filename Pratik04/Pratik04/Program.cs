

/*
    Bir Manav Uygulaması Geliştiriyoruz.
    Kullanıcımıza konsol ekranında hangi meyveyi satın almak istediğini soruyoruz. 
    Aldığımız cevaba göre ilgili meyvenin fiyatını ekrana yazdırıyoruz. 
 */

// Switch karar yapısı ile yapmamız daha doğru nedeni seçim işlemi yaptırdığımızdan

string secilenUrun;

Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");
Console.WriteLine("");

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
secilenUrun = Console.ReadLine().ToLower();

switch (secilenUrun)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;

}

if(secilenUrun == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if(secilenUrun == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else if (secilenUrun == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (secilenUrun == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
}

