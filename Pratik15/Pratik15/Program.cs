
using Pratik15;

// Öğretmen sınıfından nesne oluşturma
Ogretmen ogretmen = new Ogretmen("Steve", "Jobs", 1234);
ogretmen.BilgiYazdir(); // BaseKisi sınıfının Metodu
ogretmen.OgretmenBilgiYazdir(); // Kendi sınıfının metodu

Console.WriteLine("-------------------------------------");

// Öğrenci sınıfından nesne oluşturma
Ogrenci ogrenci = new Ogrenci("Can", "Aydın", 123454);
ogrenci.BilgiYazdir(); // BaseKisi sınıfının Metodu
ogrenci.OgrenciBilgiYazdir(); // Kendi sınıfının metodu
