

using Pratik11;

// Person sınıfından ogrenci ve ogretmen nesneleri oluşturulması
Person ogrenci =  new Person();
Person ogretmen = new Person();

// Person sınıfının özelliklerini kullanarak tanımlama işlemleri
ogrenci.Ad = "Can";
ogrenci.Soyad = "Aydın";
ogrenci.DogumTarihi = "24 Temmuz";

ogretmen.Ad = "Steve";
ogretmen.Soyad = "Jobs";
ogretmen.DogumTarihi = "24 Temmuz";


// Konsol ekranına yazdırma işlemleri
Console.WriteLine($"Öğrencinin Adı - Soyadı: {ogrenci.Ad} {ogrenci.Soyad}, Doğum Tarihi: {ogrenci.DogumTarihi}");

Console.WriteLine($"Öğretmenin Adı - Soyadı: {ogretmen.Ad} {ogretmen.Soyad}, Doğum Tarihi: {ogretmen.DogumTarihi}");
